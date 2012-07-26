/*
Creative Photo Intervalometer

Written by Trevor Green
for Texas Instruments Intern Design Challenge 2012
*/

#include <TimerSerial.h>
#include <Wire.h>

#define MAX_SHOTS 16000 //number of entries in EEPROM
#define MAX_COM_LEN 20 //max command length
#define MAX_SER_WAIT 1000 //max miliseconds to wait for serial data
#define PT_BASE_ADDR 64
//define config addresses
#define NUM_POINTS_ADDR 1
#define NUM_REPEATS_ADDR 3
//define pins
#define START_BTN 5
#define DONE_LED 10
#define SHUTTER 8
#define FOCUS 9


TimerSerial mySerial; // Create a new TimerSerial object
char ReadData[MAX_COM_LEN]; //Read buffer, commands not longer than 20 chars

word DebugWord;

void setup()
{
  mySerial.begin(); // 9600 baud
  mySerial.flush();
  //mySerial.println("reset"); //alert computer that MSP reset
  Wire.begin(); // join i2c bus (address optional for master)
  
  //setup digital channels
  pinMode(START_BTN, INPUT_PULLUP);
  pinMode(DONE_LED, OUTPUT);
  pinMode(SHUTTER, OUTPUT);
  pinMode(FOCUS, OUTPUT);
  
  digitalWrite(DONE_LED, LOW);
  digitalWrite(SHUTTER, LOW);
  digitalWrite(FOCUS, LOW);
  BlinkDoneLED(1); //let user know it turned on
}

void loop() //main function
{
  //control idle loop rate
  delay(10);
  
  int i = 0; //general loop index
  boolean read_done = false; //read done flag
  
  //read serial port, check for GUI control
  if (mySerial.available() > 0) {
    ReadSerialBlocking(ReadData, MAX_COM_LEN); //read command
    //interpret command
    if(StrCmp(ReadData, "gui_control")) {
      //gui asserted control, acknowledge
      mySerial.println("gui_control_ack");
      //begin read loop
      word numPoints = 0;
      word shutterTime;
      word waitTime;
      read_done = false;
      while(read_done == false) {
        if (ReadSerialBlocking(ReadData, MAX_COM_LEN)) {
          //check to see if gui is done
          if(StrCmp(ReadData, "gui_done")) {
            read_done = true; //data write is done
            BlinkDoneLED(3); //blink to let user know code loaded
            break;
          }
          else if (StrCmp(ReadData, "gui_set_repeats")) {
            //set repeats
            ReadSerialBlocking(ReadData, MAX_COM_LEN); //gui sends parameter
            WriteConfigWord(NUM_REPEATS_ADDR, word(ReadData[1],ReadData[0]));
            //acknowledge config stored
            mySerial.println("gui_stored_ack");
          }
          else if (StrCmp(ReadData, "gui_num_shots")) {
            //number of shots
            ReadSerialBlocking(ReadData, MAX_COM_LEN); //gui sends parameter
            WriteConfigWord(NUM_POINTS_ADDR, word(ReadData[1],ReadData[0]));
            //acknowledge config stored
            mySerial.println("gui_stored_ack");
          }
          else {
            //write points to EEPROM
            shutterTime = word(ReadData[1],ReadData[0]);
            waitTime = word(ReadData[3], ReadData[2]);
            WritePoint(shutterTime,waitTime,numPoints);
            numPoints++; //count number of points
            //acknowledge point stored
            mySerial.println("gui_stored_ack");
            if (numPoints >= MAX_SHOTS) {
              //more points entered than mem can handle
              read_done = true; //cut off early
            }
          }
        }
        else //gui not responding!
        {
          read_done = true;
        }
      }
    }
    else {
    //unknown command!
    }
  }
  else { //no gui control, check for start button
    if (digitalRead(START_BTN) == LOW) { //button pushed?
      //button pushed, start sequence
      word n = GetConfigWord(NUM_POINTS_ADDR);
      word r = GetConfigWord(NUM_REPEATS_ADDR);
      //mySerial.println(r,HEX);
      word WaitTime = 0;
      word ShutterTime = 0;
      int j;
      for (j=0; j < r; j++) { //repeat for stored number of times
        //mySerial.println(j,HEX);
        for (i=0; i<n; i++) { //loop through each shot
          WaitTime = GetWaitTime(i);
          ShutterTime = GetShutterTime(i);
          delay(WaitTime);
          digitalWrite(SHUTTER, HIGH);
          delay(ShutterTime);
          digitalWrite(SHUTTER, LOW);
        }
      }
      //end of sequence
      digitalWrite(DONE_LED, HIGH); //light done led
    }
  }
}

void WritePoint(word shutterTime, word waitTime, word index) {
  byte SControlByte = 0b01010011; //shutter times on block 0
  byte WControlByte = 0b01010111; //wait times on block 1
  word address1 = (index * 2) + PT_BASE_ADDR; //start on page 2
  word address2 = address1 + 1;
  //send shutter time high byte
  WriteEEPROMByte(SControlByte, address1, highByte(shutterTime));
  //send shutter time low byte
  WriteEEPROMByte(SControlByte, address2, lowByte(shutterTime));
  //send wait time high byte
  WriteEEPROMByte(WControlByte, address1, highByte(waitTime));
  //send wait time low byte
  WriteEEPROMByte(WControlByte, address2, lowByte(waitTime));
}

word GetConfigWord(byte addr) {
  byte ControlByte = 0b01010011; //block one read

  byte a = GetEEPROMByte(ControlByte, word(0, addr));
  byte b = GetEEPROMByte(ControlByte, word(0, addr+1));
  
  return word(a,b);
}

void WriteConfigWord(byte addr, word data) {
  byte ControlByte = 0b01010011; //block one write
  WriteEEPROMByte(ControlByte, word(0,addr), highByte(data));
  WriteEEPROMByte(ControlByte, word(0,addr+1), lowByte(data));
}

word GetWaitTime(int index) {
  byte ControlByte = 0b01010111;
  word address1 = (index * 2) + PT_BASE_ADDR; //start on page 2
  word address2 = address1 + 1;
 
  byte a = GetEEPROMByte(ControlByte, address1);
  byte b = GetEEPROMByte(ControlByte, address2);
  
  return word(a,b);
}

word GetShutterTime(int index) {
  byte ControlByte = 0b01010011;
  word address1 = (index * 2) + PT_BASE_ADDR; //start on page 2
  word address2 = address1 + 1;
 
  byte a = GetEEPROMByte(ControlByte, address1);
  byte b = GetEEPROMByte(ControlByte, address2);
  
  return word(a,b);
}

//EEPROM utils

byte GetEEPROMByte(byte ControlByte, word Address) {
  Wire.beginTransmission(ControlByte);
  Wire.write(highByte(Address));
  Wire.write(lowByte(Address));
  Wire.endTransmission();
  Wire.requestFrom(ControlByte, 1);
  return Wire.read();
}

void WriteEEPROMByte(byte ControlByte, word Address, byte Data) {
  Wire.beginTransmission(ControlByte); 
  Wire.write(highByte(Address));
  Wire.write(lowByte(Address));
  Wire.write(Data);
  Wire.endTransmission();
  delay(10);
}

//Misc Utilities

void BlinkDoneLED(int times) {
  int i;
  for(i=0; i<times; i++) {
    digitalWrite(DONE_LED, HIGH);
    delay(500);
    digitalWrite(DONE_LED, LOW);
    delay(300);
  }
}

//Serial Utilities

/*
boolean ReadSerial(char *str, int limit) {
  int BytesAvailable;
  int i;
  BytesAvailable = mySerial.available();
  if (BytesAvailable > limit)
    BytesAvailable = limit; //cap at limit
  for(i=0; i<BytesAvailable; i++) {
    str[i] = mySerial.read();
  }
  //return true if data was read
  if (BytesAvailable > 0)
    return true;
  else
    return false;
}
*/

//doesn't return until CrLf is read or time-out
boolean ReadSerialBlocking(char *str, int lenLim) {
  unsigned long EndTime = millis(); //start stopwatch
  EndTime = EndTime + MAX_SER_WAIT;
  boolean done = false;
  int i = 0;
  while(done == false) {
    delay(1);
    if (mySerial.available() > 0) {
      byte ByteRead = mySerial.read();
      delay(1);
      if(ByteRead == '\r') {
        if(mySerial.peek() == '\n') {
          //CRLF reached, return string
          mySerial.read(); //clear LF
          str[i] = '\0';
          done = true; 
          return true;
        }
      }
      //add char to string
      str[i] = ByteRead;
      i++;
      if (i >= lenLim) {
        return false; //length limit reached, return error
      }
    }
    else if (millis() > EndTime) {
      return false; //timed out
    }
  }
}

//String Utilities

//compares two strings for equality
boolean StrCmp(char *Str1, char *Str2) {
  byte i = 0;
  int len1 = StrLen(Str1);
  int len2 = StrLen(Str2);
  if (len1 != len2)
    return false; //not same length
  for(i=0; i<len1; i++) {
    if(Str1[i] != Str2[i])
      return false; //chars unequal
  }
  return true; //all chars equal
}

//returns length of null-terminated string
int StrLen(char *Str) {
  int n = 0;
  while(Str[n] != '\0') {
    n++;
    if (n>255) 
      return 0; //error occured, no null found
  }
  return n;
}
