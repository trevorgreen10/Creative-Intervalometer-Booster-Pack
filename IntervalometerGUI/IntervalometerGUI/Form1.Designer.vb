<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim PtByPtTabPage As System.Windows.Forms.TabPage
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.PtLoadingLabel = New System.Windows.Forms.Label()
        Me.PatternOpenBtn = New System.Windows.Forms.Button()
        Me.PatternSaveBtn = New System.Windows.Forms.Button()
        Me.ComPortPt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RepeatSequencePt = New System.Windows.Forms.TextBox()
        Me.PtUpload = New System.Windows.Forms.Button()
        Me.PtAddBtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TimesPt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WaitTimePt = New System.Windows.Forms.TextBox()
        Me.ShutterTimePt = New System.Windows.Forms.TextBox()
        Me.PtGrid = New System.Windows.Forms.DataGridView()
        Me.Shot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShutterTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaitTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Times = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ProfileTabPage = New System.Windows.Forms.TabPage()
        Me.ProfileLoadingLbl = New System.Windows.Forms.Label()
        Me.ComPortProfile = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RepeatSequenceProfile = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.UploadBtnProfile = New System.Windows.Forms.Button()
        Me.NumShotsProfile = New System.Windows.Forms.TextBox()
        Me.GenerateBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.WaitPeriod = New System.Windows.Forms.TextBox()
        Me.WaitTimeProfile = New System.Windows.Forms.ComboBox()
        Me.WaitMax = New System.Windows.Forms.TextBox()
        Me.WaitMin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShutterSpeedPeriod = New System.Windows.Forms.TextBox()
        Me.ShutterSpeedProfile = New System.Windows.Forms.ComboBox()
        Me.ShutterSpeedMax = New System.Windows.Forms.TextBox()
        Me.ShutterSpeedMin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ShutterChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.WaitTimeChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SavePatternDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenPatternDialog = New System.Windows.Forms.OpenFileDialog()
        Me.DeviceUploadBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        PtByPtTabPage = New System.Windows.Forms.TabPage()
        PtByPtTabPage.SuspendLayout()
        CType(Me.PtGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.ProfileTabPage.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ShutterChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.WaitTimeChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PtByPtTabPage
        '
        PtByPtTabPage.Controls.Add(Me.Label21)
        PtByPtTabPage.Controls.Add(Me.Label18)
        PtByPtTabPage.Controls.Add(Me.PtLoadingLabel)
        PtByPtTabPage.Controls.Add(Me.PatternOpenBtn)
        PtByPtTabPage.Controls.Add(Me.PatternSaveBtn)
        PtByPtTabPage.Controls.Add(Me.ComPortPt)
        PtByPtTabPage.Controls.Add(Me.Label12)
        PtByPtTabPage.Controls.Add(Me.Label11)
        PtByPtTabPage.Controls.Add(Me.RepeatSequencePt)
        PtByPtTabPage.Controls.Add(Me.PtUpload)
        PtByPtTabPage.Controls.Add(Me.PtAddBtn)
        PtByPtTabPage.Controls.Add(Me.Label10)
        PtByPtTabPage.Controls.Add(Me.TimesPt)
        PtByPtTabPage.Controls.Add(Me.Label9)
        PtByPtTabPage.Controls.Add(Me.Label4)
        PtByPtTabPage.Controls.Add(Me.WaitTimePt)
        PtByPtTabPage.Controls.Add(Me.ShutterTimePt)
        PtByPtTabPage.Controls.Add(Me.PtGrid)
        PtByPtTabPage.Location = New System.Drawing.Point(4, 22)
        PtByPtTabPage.Name = "PtByPtTabPage"
        PtByPtTabPage.Padding = New System.Windows.Forms.Padding(3)
        PtByPtTabPage.Size = New System.Drawing.Size(756, 555)
        PtByPtTabPage.TabIndex = 1
        PtByPtTabPage.Text = "Point By Point"
        PtByPtTabPage.UseVisualStyleBackColor = True
        '
        'PtLoadingLabel
        '
        Me.PtLoadingLabel.AutoSize = True
        Me.PtLoadingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PtLoadingLabel.ForeColor = System.Drawing.Color.Red
        Me.PtLoadingLabel.Location = New System.Drawing.Point(404, 261)
        Me.PtLoadingLabel.Name = "PtLoadingLabel"
        Me.PtLoadingLabel.Size = New System.Drawing.Size(88, 20)
        Me.PtLoadingLabel.TabIndex = 30
        Me.PtLoadingLabel.Text = "Loading..."
        Me.PtLoadingLabel.Visible = False
        '
        'PatternOpenBtn
        '
        Me.PatternOpenBtn.Location = New System.Drawing.Point(589, 325)
        Me.PatternOpenBtn.Name = "PatternOpenBtn"
        Me.PatternOpenBtn.Size = New System.Drawing.Size(75, 23)
        Me.PatternOpenBtn.TabIndex = 25
        Me.PatternOpenBtn.Text = "Open"
        Me.PatternOpenBtn.UseVisualStyleBackColor = True
        '
        'PatternSaveBtn
        '
        Me.PatternSaveBtn.Location = New System.Drawing.Point(510, 325)
        Me.PatternSaveBtn.Name = "PatternSaveBtn"
        Me.PatternSaveBtn.Size = New System.Drawing.Size(75, 23)
        Me.PatternSaveBtn.TabIndex = 24
        Me.PatternSaveBtn.Text = "Save"
        Me.PatternSaveBtn.UseVisualStyleBackColor = True
        '
        'ComPortPt
        '
        Me.ComPortPt.Location = New System.Drawing.Point(594, 258)
        Me.ComPortPt.Name = "ComPortPt"
        Me.ComPortPt.Size = New System.Drawing.Size(70, 20)
        Me.ComPortPt.TabIndex = 23
        Me.ComPortPt.Text = "COM3"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(628, 189)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "times"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(455, 189)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Run Sequence"
        '
        'RepeatSequencePt
        '
        Me.RepeatSequencePt.Location = New System.Drawing.Point(552, 186)
        Me.RepeatSequencePt.Name = "RepeatSequencePt"
        Me.RepeatSequencePt.Size = New System.Drawing.Size(70, 20)
        Me.RepeatSequencePt.TabIndex = 20
        Me.RepeatSequencePt.Text = "1"
        '
        'PtUpload
        '
        Me.PtUpload.Location = New System.Drawing.Point(510, 258)
        Me.PtUpload.Name = "PtUpload"
        Me.PtUpload.Size = New System.Drawing.Size(75, 23)
        Me.PtUpload.TabIndex = 19
        Me.PtUpload.Text = "Upload"
        Me.PtUpload.UseVisualStyleBackColor = True
        '
        'PtAddBtn
        '
        Me.PtAddBtn.Location = New System.Drawing.Point(546, 124)
        Me.PtAddBtn.Name = "PtAddBtn"
        Me.PtAddBtn.Size = New System.Drawing.Size(75, 23)
        Me.PtAddBtn.TabIndex = 18
        Me.PtAddBtn.Text = "Add"
        Me.PtAddBtn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(531, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "X"
        '
        'TimesPt
        '
        Me.TimesPt.Location = New System.Drawing.Point(552, 87)
        Me.TimesPt.Name = "TimesPt"
        Me.TimesPt.Size = New System.Drawing.Size(70, 20)
        Me.TimesPt.TabIndex = 16
        Me.TimesPt.Text = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(482, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Wait Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(467, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Shutter Time"
        '
        'WaitTimePt
        '
        Me.WaitTimePt.Location = New System.Drawing.Point(552, 61)
        Me.WaitTimePt.Name = "WaitTimePt"
        Me.WaitTimePt.Size = New System.Drawing.Size(70, 20)
        Me.WaitTimePt.TabIndex = 2
        Me.WaitTimePt.Text = "0"
        '
        'ShutterTimePt
        '
        Me.ShutterTimePt.Location = New System.Drawing.Point(552, 35)
        Me.ShutterTimePt.Name = "ShutterTimePt"
        Me.ShutterTimePt.Size = New System.Drawing.Size(70, 20)
        Me.ShutterTimePt.TabIndex = 1
        Me.ShutterTimePt.Text = "0"
        '
        'PtGrid
        '
        Me.PtGrid.AllowUserToAddRows = False
        Me.PtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PtGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Shot, Me.ShutterTime, Me.WaitTime, Me.Times})
        Me.PtGrid.Location = New System.Drawing.Point(6, 6)
        Me.PtGrid.Name = "PtGrid"
        Me.PtGrid.ReadOnly = True
        Me.PtGrid.Size = New System.Drawing.Size(367, 479)
        Me.PtGrid.TabIndex = 0
        '
        'Shot
        '
        Me.Shot.HeaderText = "Num"
        Me.Shot.Name = "Shot"
        Me.Shot.ReadOnly = True
        Me.Shot.Width = 50
        '
        'ShutterTime
        '
        Me.ShutterTime.HeaderText = "Shutter Time"
        Me.ShutterTime.Name = "ShutterTime"
        Me.ShutterTime.ReadOnly = True
        '
        'WaitTime
        '
        Me.WaitTime.HeaderText = "Wait Time"
        Me.WaitTime.Name = "WaitTime"
        Me.WaitTime.ReadOnly = True
        '
        'Times
        '
        Me.Times.HeaderText = "X"
        Me.Times.Name = "Times"
        Me.Times.ReadOnly = True
        Me.Times.Width = 50
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ProfileTabPage)
        Me.TabControl1.Controls.Add(PtByPtTabPage)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(764, 581)
        Me.TabControl1.TabIndex = 0
        '
        'ProfileTabPage
        '
        Me.ProfileTabPage.Controls.Add(Me.ProfileLoadingLbl)
        Me.ProfileTabPage.Controls.Add(Me.ComPortProfile)
        Me.ProfileTabPage.Controls.Add(Me.Label14)
        Me.ProfileTabPage.Controls.Add(Me.Label13)
        Me.ProfileTabPage.Controls.Add(Me.RepeatSequenceProfile)
        Me.ProfileTabPage.Controls.Add(Me.Label8)
        Me.ProfileTabPage.Controls.Add(Me.UploadBtnProfile)
        Me.ProfileTabPage.Controls.Add(Me.NumShotsProfile)
        Me.ProfileTabPage.Controls.Add(Me.GenerateBtn)
        Me.ProfileTabPage.Controls.Add(Me.GroupBox2)
        Me.ProfileTabPage.Controls.Add(Me.GroupBox1)
        Me.ProfileTabPage.Controls.Add(Me.TabControl2)
        Me.ProfileTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ProfileTabPage.Name = "ProfileTabPage"
        Me.ProfileTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ProfileTabPage.Size = New System.Drawing.Size(756, 555)
        Me.ProfileTabPage.TabIndex = 0
        Me.ProfileTabPage.Text = "Profile"
        Me.ProfileTabPage.UseVisualStyleBackColor = True
        '
        'ProfileLoadingLbl
        '
        Me.ProfileLoadingLbl.AutoSize = True
        Me.ProfileLoadingLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfileLoadingLbl.ForeColor = System.Drawing.Color.Red
        Me.ProfileLoadingLbl.Location = New System.Drawing.Point(631, 115)
        Me.ProfileLoadingLbl.Name = "ProfileLoadingLbl"
        Me.ProfileLoadingLbl.Size = New System.Drawing.Size(88, 20)
        Me.ProfileLoadingLbl.TabIndex = 29
        Me.ProfileLoadingLbl.Text = "Loading..."
        Me.ProfileLoadingLbl.Visible = False
        '
        'ComPortProfile
        '
        Me.ComPortProfile.Location = New System.Drawing.Point(640, 80)
        Me.ComPortProfile.Name = "ComPortProfile"
        Me.ComPortProfile.Size = New System.Drawing.Size(70, 20)
        Me.ComPortProfile.TabIndex = 28
        Me.ComPortProfile.Text = "COM3"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(499, 168)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Times"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(326, 168)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Run Sequence"
        '
        'RepeatSequenceProfile
        '
        Me.RepeatSequenceProfile.Location = New System.Drawing.Point(423, 165)
        Me.RepeatSequenceProfile.Name = "RepeatSequenceProfile"
        Me.RepeatSequenceProfile.Size = New System.Drawing.Size(70, 20)
        Me.RepeatSequenceProfile.TabIndex = 25
        Me.RepeatSequenceProfile.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(169, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Shots"
        '
        'UploadBtnProfile
        '
        Me.UploadBtnProfile.Enabled = False
        Me.UploadBtnProfile.Location = New System.Drawing.Point(635, 44)
        Me.UploadBtnProfile.Name = "UploadBtnProfile"
        Me.UploadBtnProfile.Size = New System.Drawing.Size(75, 23)
        Me.UploadBtnProfile.TabIndex = 24
        Me.UploadBtnProfile.Text = "Upload"
        Me.UploadBtnProfile.UseVisualStyleBackColor = True
        '
        'NumShotsProfile
        '
        Me.NumShotsProfile.Location = New System.Drawing.Point(214, 165)
        Me.NumShotsProfile.Name = "NumShotsProfile"
        Me.NumShotsProfile.Size = New System.Drawing.Size(70, 20)
        Me.NumShotsProfile.TabIndex = 23
        Me.NumShotsProfile.Text = "1"
        '
        'GenerateBtn
        '
        Me.GenerateBtn.Location = New System.Drawing.Point(569, 163)
        Me.GenerateBtn.Name = "GenerateBtn"
        Me.GenerateBtn.Size = New System.Drawing.Size(75, 23)
        Me.GenerateBtn.TabIndex = 23
        Me.GenerateBtn.Text = "Generate"
        Me.GenerateBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.WaitPeriod)
        Me.GroupBox2.Controls.Add(Me.WaitTimeProfile)
        Me.GroupBox2.Controls.Add(Me.WaitMax)
        Me.GroupBox2.Controls.Add(Me.WaitMin)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(309, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(291, 126)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Wait Time"
        '
        'WaitPeriod
        '
        Me.WaitPeriod.Location = New System.Drawing.Point(192, 83)
        Me.WaitPeriod.Name = "WaitPeriod"
        Me.WaitPeriod.Size = New System.Drawing.Size(70, 20)
        Me.WaitPeriod.TabIndex = 10
        '
        'WaitTimeProfile
        '
        Me.WaitTimeProfile.FormattingEnabled = True
        Me.WaitTimeProfile.Items.AddRange(New Object() {"Sine", "Square", "Sawtooth", "Constant"})
        Me.WaitTimeProfile.Location = New System.Drawing.Point(6, 35)
        Me.WaitTimeProfile.Name = "WaitTimeProfile"
        Me.WaitTimeProfile.Size = New System.Drawing.Size(121, 21)
        Me.WaitTimeProfile.TabIndex = 20
        Me.WaitTimeProfile.Text = "Sine"
        '
        'WaitMax
        '
        Me.WaitMax.Location = New System.Drawing.Point(192, 31)
        Me.WaitMax.Name = "WaitMax"
        Me.WaitMax.Size = New System.Drawing.Size(70, 20)
        Me.WaitMax.TabIndex = 8
        '
        'WaitMin
        '
        Me.WaitMin.Location = New System.Drawing.Point(192, 57)
        Me.WaitMin.Name = "WaitMin"
        Me.WaitMin.Size = New System.Drawing.Size(70, 20)
        Me.WaitMin.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Period"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(157, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Min"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Max"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.ShutterSpeedPeriod)
        Me.GroupBox1.Controls.Add(Me.ShutterSpeedProfile)
        Me.GroupBox1.Controls.Add(Me.ShutterSpeedMax)
        Me.GroupBox1.Controls.Add(Me.ShutterSpeedMin)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(287, 126)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Shutter Speed"
        '
        'ShutterSpeedPeriod
        '
        Me.ShutterSpeedPeriod.Location = New System.Drawing.Point(192, 83)
        Me.ShutterSpeedPeriod.Name = "ShutterSpeedPeriod"
        Me.ShutterSpeedPeriod.Size = New System.Drawing.Size(70, 20)
        Me.ShutterSpeedPeriod.TabIndex = 10
        '
        'ShutterSpeedProfile
        '
        Me.ShutterSpeedProfile.FormattingEnabled = True
        Me.ShutterSpeedProfile.Items.AddRange(New Object() {"Sine", "Square", "Sawtooth", "Constant"})
        Me.ShutterSpeedProfile.Location = New System.Drawing.Point(6, 35)
        Me.ShutterSpeedProfile.Name = "ShutterSpeedProfile"
        Me.ShutterSpeedProfile.Size = New System.Drawing.Size(121, 21)
        Me.ShutterSpeedProfile.TabIndex = 20
        Me.ShutterSpeedProfile.Text = "Sine"
        '
        'ShutterSpeedMax
        '
        Me.ShutterSpeedMax.Location = New System.Drawing.Point(192, 31)
        Me.ShutterSpeedMax.Name = "ShutterSpeedMax"
        Me.ShutterSpeedMax.Size = New System.Drawing.Size(70, 20)
        Me.ShutterSpeedMax.TabIndex = 8
        '
        'ShutterSpeedMin
        '
        Me.ShutterSpeedMin.Location = New System.Drawing.Point(192, 57)
        Me.ShutterSpeedMin.Name = "ShutterSpeedMin"
        Me.ShutterSpeedMin.Size = New System.Drawing.Size(70, 20)
        Me.ShutterSpeedMin.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(141, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Period"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(157, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Min"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(154, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Max"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(6, 205)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(744, 344)
        Me.TabControl2.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ShutterChart)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(736, 318)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Shutter Speed"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ShutterChart
        '
        ChartArea1.AxisX.Title = "Shot"
        ChartArea1.AxisY.Title = "Time (ms)"
        ChartArea1.Name = "ChartArea1"
        Me.ShutterChart.ChartAreas.Add(ChartArea1)
        Me.ShutterChart.Location = New System.Drawing.Point(6, 6)
        Me.ShutterChart.Name = "ShutterChart"
        Series1.ChartArea = "ChartArea1"
        Series1.IsXValueIndexed = True
        Series1.Name = "Shutter Speed"
        Me.ShutterChart.Series.Add(Series1)
        Me.ShutterChart.Size = New System.Drawing.Size(730, 300)
        Me.ShutterChart.TabIndex = 0
        Me.ShutterChart.Text = "Chart1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.WaitTimeChart)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(736, 318)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Wait Time"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'WaitTimeChart
        '
        ChartArea2.AxisX.Title = "Shot"
        ChartArea2.AxisY.Title = "Time (ms)"
        ChartArea2.Name = "ChartArea1"
        Me.WaitTimeChart.ChartAreas.Add(ChartArea2)
        Me.WaitTimeChart.Location = New System.Drawing.Point(6, 6)
        Me.WaitTimeChart.Name = "WaitTimeChart"
        Me.WaitTimeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series2.ChartArea = "ChartArea1"
        Series2.IsXValueIndexed = True
        Series2.Name = "Wait Time"
        Me.WaitTimeChart.Series.Add(Series2)
        Me.WaitTimeChart.Size = New System.Drawing.Size(730, 300)
        Me.WaitTimeChart.TabIndex = 1
        Me.WaitTimeChart.Text = "Chart1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(485, 604)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(292, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Written by Trevor Green for TI Intern Design Challenge 2012"
        '
        'SavePatternDialog
        '
        Me.SavePatternDialog.DefaultExt = "txt"
        Me.SavePatternDialog.FileName = "Pattern"
        '
        'OpenPatternDialog
        '
        Me.OpenPatternDialog.DefaultExt = "txt"
        Me.OpenPatternDialog.FileName = "Pattern.txt"
        '
        'DeviceUploadBackgroundWorker
        '
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(268, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(22, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "ms"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(268, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(22, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "ms"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(265, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(22, 13)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "ms"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(265, 60)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(22, 13)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "ms"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(628, 38)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(22, 13)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "ms"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(628, 68)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(22, 13)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "ms"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 626)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Intervalometer GUI"
        PtByPtTabPage.ResumeLayout(False)
        PtByPtTabPage.PerformLayout()
        CType(Me.PtGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ProfileTabPage.ResumeLayout(False)
        Me.ProfileTabPage.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.ShutterChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.WaitTimeChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ProfileTabPage As System.Windows.Forms.TabPage
    Friend WithEvents ShutterChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ShutterSpeedPeriod As System.Windows.Forms.TextBox
    Friend WithEvents ShutterSpeedMin As System.Windows.Forms.TextBox
    Friend WithEvents ShutterSpeedMax As System.Windows.Forms.TextBox
    Friend WithEvents UploadBtnProfile As System.Windows.Forms.Button
    Friend WithEvents GenerateBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents WaitPeriod As System.Windows.Forms.TextBox
    Friend WithEvents WaitTimeProfile As System.Windows.Forms.ComboBox
    Friend WithEvents WaitMax As System.Windows.Forms.TextBox
    Friend WithEvents WaitMin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ShutterSpeedProfile As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NumShotsProfile As System.Windows.Forms.TextBox
    Friend WithEvents WaitTimeChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents WaitTimePt As System.Windows.Forms.TextBox
    Friend WithEvents ShutterTimePt As System.Windows.Forms.TextBox
    Friend WithEvents PtGrid As System.Windows.Forms.DataGridView
    Friend WithEvents PtAddBtn As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TimesPt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Shot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShutterTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaitTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Times As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PtUpload As System.Windows.Forms.Button
    Friend WithEvents RepeatSequencePt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComPortProfile As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents RepeatSequenceProfile As System.Windows.Forms.TextBox
    Friend WithEvents ComPortPt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PatternOpenBtn As System.Windows.Forms.Button
    Friend WithEvents PatternSaveBtn As System.Windows.Forms.Button
    Friend WithEvents SavePatternDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenPatternDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ProfileLoadingLbl As System.Windows.Forms.Label
    Friend WithEvents DeviceUploadBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents PtLoadingLabel As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label

End Class
