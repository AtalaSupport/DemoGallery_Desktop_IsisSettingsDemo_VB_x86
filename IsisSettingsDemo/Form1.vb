Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Atalasoft.Isis
Imports Atalasoft.Imaging.Metadata

Namespace SaveRestoreSettings
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private _overscanColor As System.Drawing.Color = Color.Empty
		Private _controller As Atalasoft.Isis.IsisController
		Private WithEvents btnSave As System.Windows.Forms.Button
		Private WithEvents btnRestore As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		Private WithEvents cboDevice As System.Windows.Forms.ComboBox
		Private panel1 As System.Windows.Forms.Panel
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private label10 As System.Windows.Forms.Label
		Private label11 As System.Windows.Forms.Label
		Private label15 As System.Windows.Forms.Label
		Private label17 As System.Windows.Forms.Label
		Private label18 As System.Windows.Forms.Label
		Private label19 As System.Windows.Forms.Label
		Private label21 As System.Windows.Forms.Label
		Private label24 As System.Windows.Forms.Label
		Private label25 As System.Windows.Forms.Label
		Private tabControl1 As System.Windows.Forms.TabControl
		Private tabPage1 As System.Windows.Forms.TabPage
		Private tabPage3 As System.Windows.Forms.TabPage
		Private tabPage4 As System.Windows.Forms.TabPage
		Private tabPage6 As System.Windows.Forms.TabPage
		Private cboScanType As System.Windows.Forms.ComboBox
		Private chkScanAhead As System.Windows.Forms.CheckBox
		Private chkMixedScanning As System.Windows.Forms.CheckBox
		Private cboJobSeparation As System.Windows.Forms.ComboBox
		Private cboFileType As System.Windows.Forms.ComboBox
		Private cboDataOrientation As System.Windows.Forms.ComboBox
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private label8 As System.Windows.Forms.Label
		Private numAreaLeft As System.Windows.Forms.NumericUpDown
		Private label12 As System.Windows.Forms.Label
		Private numAreaTop As System.Windows.Forms.NumericUpDown
		Private label13 As System.Windows.Forms.Label
		Private numAreaWidth As System.Windows.Forms.NumericUpDown
		Private label16 As System.Windows.Forms.Label
		Private numAreaHeight As System.Windows.Forms.NumericUpDown
		Private cboColorFormat As System.Windows.Forms.ComboBox
		Private WithEvents cboPageSize As System.Windows.Forms.ComboBox
		Private cboResolutionUnit As System.Windows.Forms.ComboBox
		Private cboResolution As System.Windows.Forms.ComboBox
		Private numScanAheadCount As System.Windows.Forms.NumericUpDown
		Private groupBox4 As System.Windows.Forms.GroupBox
		Private label20 As System.Windows.Forms.Label
		Private label22 As System.Windows.Forms.Label
		Private label23 As System.Windows.Forms.Label
		Private label26 As System.Windows.Forms.Label
		Private lblFeederExists As System.Windows.Forms.Label
		Private lblFeederPageCount As System.Windows.Forms.Label
		Private lblFeederPageDetect As System.Windows.Forms.Label
		Private lblFeederPause As System.Windows.Forms.Label
		Private chkFeederStopPause As System.Windows.Forms.CheckBox
		Private chkFeederImmediateStop As System.Windows.Forms.CheckBox
		Private label28 As System.Windows.Forms.Label
		Private label29 As System.Windows.Forms.Label
		Private numFeederTimeout As System.Windows.Forms.NumericUpDown
		Private chkBarcodeFrontSide As System.Windows.Forms.CheckBox
		Private chkBarcodeBackSide As System.Windows.Forms.CheckBox
		Private label30 As System.Windows.Forms.Label
		Private cboBarcodeEmphasis As System.Windows.Forms.ComboBox
		Private label31 As System.Windows.Forms.Label
		Private cboBarcodeImageQuality As System.Windows.Forms.ComboBox
		Private chkBarcodeLinearSearch As System.Windows.Forms.CheckBox
		Private label32 As System.Windows.Forms.Label
		Private cboBarcodeSearchDirection As System.Windows.Forms.ComboBox
		Private label33 As System.Windows.Forms.Label
		Private cboBarcodeSearchMode As System.Windows.Forms.ComboBox
		Private label34 As System.Windows.Forms.Label
		Private chkBarcodeVerifyChecksum As System.Windows.Forms.CheckBox
		Private cboBarcodeSearchOrientation As System.Windows.Forms.ComboBox
		Private label35 As System.Windows.Forms.Label
		Private label36 As System.Windows.Forms.Label
		Private label37 As System.Windows.Forms.Label
		Private numContrastRed As System.Windows.Forms.NumericUpDown
		Private numContrastGreen As System.Windows.Forms.NumericUpDown
		Private numContrastBlue As System.Windows.Forms.NumericUpDown
		Private cboContrast As System.Windows.Forms.ComboBox
		Private cboBrightness As System.Windows.Forms.ComboBox
		Private label38 As System.Windows.Forms.Label
		Private label39 As System.Windows.Forms.Label
		Private label40 As System.Windows.Forms.Label
		Private numBrightnessBlue As System.Windows.Forms.NumericUpDown
		Private numBrightnessGreen As System.Windows.Forms.NumericUpDown
		Private numBrightnessRed As System.Windows.Forms.NumericUpDown
		Private cboDither As System.Windows.Forms.ComboBox
		Private cboEmphasis As System.Windows.Forms.ComboBox
		Private cboGamma As System.Windows.Forms.ComboBox
		Private cboSharpness As System.Windows.Forms.ComboBox
		Private WithEvents btnOverscanColor As System.Windows.Forms.Button
		Private chkOutline As System.Windows.Forms.CheckBox
		Private WithEvents btnScan As System.Windows.Forms.Button
		Private tabPage2 As System.Windows.Forms.TabPage
		Private label14 As System.Windows.Forms.Label
        Private listSettings As System.Windows.Forms.ListBox
        Friend WithEvents ButtonAbout As System.Windows.Forms.Button
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.btnSave = New System.Windows.Forms.Button
            Me.btnRestore = New System.Windows.Forms.Button
            Me.label1 = New System.Windows.Forms.Label
            Me.cboDevice = New System.Windows.Forms.ComboBox
            Me.panel1 = New System.Windows.Forms.Panel
            Me.btnScan = New System.Windows.Forms.Button
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.numBrightnessBlue = New System.Windows.Forms.NumericUpDown
            Me.numBrightnessGreen = New System.Windows.Forms.NumericUpDown
            Me.numBrightnessRed = New System.Windows.Forms.NumericUpDown
            Me.label38 = New System.Windows.Forms.Label
            Me.label39 = New System.Windows.Forms.Label
            Me.label40 = New System.Windows.Forms.Label
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.numContrastBlue = New System.Windows.Forms.NumericUpDown
            Me.numContrastGreen = New System.Windows.Forms.NumericUpDown
            Me.numContrastRed = New System.Windows.Forms.NumericUpDown
            Me.label37 = New System.Windows.Forms.Label
            Me.label36 = New System.Windows.Forms.Label
            Me.label35 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.label9 = New System.Windows.Forms.Label
            Me.label10 = New System.Windows.Forms.Label
            Me.label11 = New System.Windows.Forms.Label
            Me.label15 = New System.Windows.Forms.Label
            Me.label17 = New System.Windows.Forms.Label
            Me.label18 = New System.Windows.Forms.Label
            Me.label19 = New System.Windows.Forms.Label
            Me.label21 = New System.Windows.Forms.Label
            Me.label24 = New System.Windows.Forms.Label
            Me.label25 = New System.Windows.Forms.Label
            Me.tabControl1 = New System.Windows.Forms.TabControl
            Me.tabPage1 = New System.Windows.Forms.TabPage
            Me.numScanAheadCount = New System.Windows.Forms.NumericUpDown
            Me.cboResolution = New System.Windows.Forms.ComboBox
            Me.cboResolutionUnit = New System.Windows.Forms.ComboBox
            Me.cboPageSize = New System.Windows.Forms.ComboBox
            Me.cboColorFormat = New System.Windows.Forms.ComboBox
            Me.groupBox3 = New System.Windows.Forms.GroupBox
            Me.numAreaHeight = New System.Windows.Forms.NumericUpDown
            Me.label16 = New System.Windows.Forms.Label
            Me.numAreaWidth = New System.Windows.Forms.NumericUpDown
            Me.label13 = New System.Windows.Forms.Label
            Me.numAreaTop = New System.Windows.Forms.NumericUpDown
            Me.label12 = New System.Windows.Forms.Label
            Me.numAreaLeft = New System.Windows.Forms.NumericUpDown
            Me.label8 = New System.Windows.Forms.Label
            Me.cboDataOrientation = New System.Windows.Forms.ComboBox
            Me.cboFileType = New System.Windows.Forms.ComboBox
            Me.cboJobSeparation = New System.Windows.Forms.ComboBox
            Me.chkMixedScanning = New System.Windows.Forms.CheckBox
            Me.chkScanAhead = New System.Windows.Forms.CheckBox
            Me.cboScanType = New System.Windows.Forms.ComboBox
            Me.tabPage6 = New System.Windows.Forms.TabPage
            Me.chkOutline = New System.Windows.Forms.CheckBox
            Me.btnOverscanColor = New System.Windows.Forms.Button
            Me.cboSharpness = New System.Windows.Forms.ComboBox
            Me.cboGamma = New System.Windows.Forms.ComboBox
            Me.cboEmphasis = New System.Windows.Forms.ComboBox
            Me.cboDither = New System.Windows.Forms.ComboBox
            Me.cboBrightness = New System.Windows.Forms.ComboBox
            Me.cboContrast = New System.Windows.Forms.ComboBox
            Me.tabPage3 = New System.Windows.Forms.TabPage
            Me.label29 = New System.Windows.Forms.Label
            Me.label28 = New System.Windows.Forms.Label
            Me.numFeederTimeout = New System.Windows.Forms.NumericUpDown
            Me.chkFeederImmediateStop = New System.Windows.Forms.CheckBox
            Me.chkFeederStopPause = New System.Windows.Forms.CheckBox
            Me.groupBox4 = New System.Windows.Forms.GroupBox
            Me.lblFeederPause = New System.Windows.Forms.Label
            Me.lblFeederPageDetect = New System.Windows.Forms.Label
            Me.lblFeederPageCount = New System.Windows.Forms.Label
            Me.lblFeederExists = New System.Windows.Forms.Label
            Me.label26 = New System.Windows.Forms.Label
            Me.label23 = New System.Windows.Forms.Label
            Me.label22 = New System.Windows.Forms.Label
            Me.label20 = New System.Windows.Forms.Label
            Me.tabPage4 = New System.Windows.Forms.TabPage
            Me.chkBarcodeVerifyChecksum = New System.Windows.Forms.CheckBox
            Me.cboBarcodeSearchOrientation = New System.Windows.Forms.ComboBox
            Me.label34 = New System.Windows.Forms.Label
            Me.cboBarcodeSearchMode = New System.Windows.Forms.ComboBox
            Me.label33 = New System.Windows.Forms.Label
            Me.cboBarcodeSearchDirection = New System.Windows.Forms.ComboBox
            Me.label32 = New System.Windows.Forms.Label
            Me.chkBarcodeLinearSearch = New System.Windows.Forms.CheckBox
            Me.cboBarcodeImageQuality = New System.Windows.Forms.ComboBox
            Me.label31 = New System.Windows.Forms.Label
            Me.cboBarcodeEmphasis = New System.Windows.Forms.ComboBox
            Me.label30 = New System.Windows.Forms.Label
            Me.chkBarcodeBackSide = New System.Windows.Forms.CheckBox
            Me.chkBarcodeFrontSide = New System.Windows.Forms.CheckBox
            Me.tabPage2 = New System.Windows.Forms.TabPage
            Me.listSettings = New System.Windows.Forms.ListBox
            Me.label14 = New System.Windows.Forms.Label
            Me.ButtonAbout = New System.Windows.Forms.Button
            Me.panel1.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            CType(Me.numBrightnessBlue, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numBrightnessGreen, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numBrightnessRed, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox2.SuspendLayout()
            CType(Me.numContrastBlue, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numContrastGreen, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numContrastRed, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControl1.SuspendLayout()
            Me.tabPage1.SuspendLayout()
            CType(Me.numScanAheadCount, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox3.SuspendLayout()
            CType(Me.numAreaHeight, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numAreaWidth, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numAreaTop, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numAreaLeft, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPage6.SuspendLayout()
            Me.tabPage3.SuspendLayout()
            CType(Me.numFeederTimeout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox4.SuspendLayout()
            Me.tabPage4.SuspendLayout()
            Me.tabPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnSave
            '
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnSave.Location = New System.Drawing.Point(384, 24)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(96, 24)
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save Settings"
            '
            'btnRestore
            '
            Me.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnRestore.Location = New System.Drawing.Point(496, 24)
            Me.btnRestore.Name = "btnRestore"
            Me.btnRestore.Size = New System.Drawing.Size(96, 24)
            Me.btnRestore.TabIndex = 2
            Me.btnRestore.Text = "Restore Settings"
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(24, 26)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(40, 16)
            Me.label1.TabIndex = 3
            Me.label1.Text = "Device:"
            '
            'cboDevice
            '
            Me.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboDevice.Location = New System.Drawing.Point(72, 24)
            Me.cboDevice.Name = "cboDevice"
            Me.cboDevice.Size = New System.Drawing.Size(184, 21)
            Me.cboDevice.Sorted = True
            Me.cboDevice.TabIndex = 4
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.btnScan)
            Me.panel1.Controls.Add(Me.btnSave)
            Me.panel1.Controls.Add(Me.btnRestore)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.cboDevice)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(624, 56)
            Me.panel1.TabIndex = 5
            '
            'btnScan
            '
            Me.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnScan.Location = New System.Drawing.Point(272, 24)
            Me.btnScan.Name = "btnScan"
            Me.btnScan.Size = New System.Drawing.Size(96, 24)
            Me.btnScan.TabIndex = 5
            Me.btnScan.Text = "Scan"
            '
            'label2
            '
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label2.Location = New System.Drawing.Point(40, 24)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(64, 21)
            Me.label2.TabIndex = 0
            Me.label2.Text = "Brightness:"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label3
            '
            Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label3.Location = New System.Drawing.Point(24, 62)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(80, 16)
            Me.label3.TabIndex = 1
            Me.label3.Text = "Color Format:"
            '
            'label4
            '
            Me.label4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label4.Location = New System.Drawing.Point(320, 24)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(64, 21)
            Me.label4.TabIndex = 2
            Me.label4.Text = "Contrast:"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.numBrightnessBlue)
            Me.groupBox1.Controls.Add(Me.numBrightnessGreen)
            Me.groupBox1.Controls.Add(Me.numBrightnessRed)
            Me.groupBox1.Controls.Add(Me.label38)
            Me.groupBox1.Controls.Add(Me.label39)
            Me.groupBox1.Controls.Add(Me.label40)
            Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox1.Location = New System.Drawing.Point(40, 56)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(144, 104)
            Me.groupBox1.TabIndex = 3
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Custom Brightness"
            '
            'numBrightnessBlue
            '
            Me.numBrightnessBlue.Location = New System.Drawing.Point(64, 72)
            Me.numBrightnessBlue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.numBrightnessBlue.Name = "numBrightnessBlue"
            Me.numBrightnessBlue.Size = New System.Drawing.Size(48, 20)
            Me.numBrightnessBlue.TabIndex = 11
            '
            'numBrightnessGreen
            '
            Me.numBrightnessGreen.Location = New System.Drawing.Point(64, 48)
            Me.numBrightnessGreen.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.numBrightnessGreen.Name = "numBrightnessGreen"
            Me.numBrightnessGreen.Size = New System.Drawing.Size(48, 20)
            Me.numBrightnessGreen.TabIndex = 10
            '
            'numBrightnessRed
            '
            Me.numBrightnessRed.Location = New System.Drawing.Point(64, 24)
            Me.numBrightnessRed.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.numBrightnessRed.Name = "numBrightnessRed"
            Me.numBrightnessRed.Size = New System.Drawing.Size(48, 20)
            Me.numBrightnessRed.TabIndex = 9
            '
            'label38
            '
            Me.label38.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label38.Location = New System.Drawing.Point(16, 72)
            Me.label38.Name = "label38"
            Me.label38.Size = New System.Drawing.Size(32, 16)
            Me.label38.TabIndex = 8
            Me.label38.Text = "Blue:"
            '
            'label39
            '
            Me.label39.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label39.Location = New System.Drawing.Point(16, 48)
            Me.label39.Name = "label39"
            Me.label39.Size = New System.Drawing.Size(48, 16)
            Me.label39.TabIndex = 7
            Me.label39.Text = "Green:"
            '
            'label40
            '
            Me.label40.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label40.Location = New System.Drawing.Point(16, 24)
            Me.label40.Name = "label40"
            Me.label40.Size = New System.Drawing.Size(40, 16)
            Me.label40.TabIndex = 6
            Me.label40.Text = "Red:"
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.numContrastBlue)
            Me.groupBox2.Controls.Add(Me.numContrastGreen)
            Me.groupBox2.Controls.Add(Me.numContrastRed)
            Me.groupBox2.Controls.Add(Me.label37)
            Me.groupBox2.Controls.Add(Me.label36)
            Me.groupBox2.Controls.Add(Me.label35)
            Me.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox2.Location = New System.Drawing.Point(320, 56)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(144, 104)
            Me.groupBox2.TabIndex = 4
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Custom Contrast"
            '
            'numContrastBlue
            '
            Me.numContrastBlue.Location = New System.Drawing.Point(64, 72)
            Me.numContrastBlue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.numContrastBlue.Name = "numContrastBlue"
            Me.numContrastBlue.Size = New System.Drawing.Size(48, 20)
            Me.numContrastBlue.TabIndex = 5
            '
            'numContrastGreen
            '
            Me.numContrastGreen.Location = New System.Drawing.Point(64, 48)
            Me.numContrastGreen.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.numContrastGreen.Name = "numContrastGreen"
            Me.numContrastGreen.Size = New System.Drawing.Size(48, 20)
            Me.numContrastGreen.TabIndex = 4
            '
            'numContrastRed
            '
            Me.numContrastRed.Location = New System.Drawing.Point(64, 24)
            Me.numContrastRed.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.numContrastRed.Name = "numContrastRed"
            Me.numContrastRed.Size = New System.Drawing.Size(48, 20)
            Me.numContrastRed.TabIndex = 3
            '
            'label37
            '
            Me.label37.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label37.Location = New System.Drawing.Point(16, 74)
            Me.label37.Name = "label37"
            Me.label37.Size = New System.Drawing.Size(32, 16)
            Me.label37.TabIndex = 2
            Me.label37.Text = "Blue:"
            '
            'label36
            '
            Me.label36.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label36.Location = New System.Drawing.Point(16, 50)
            Me.label36.Name = "label36"
            Me.label36.Size = New System.Drawing.Size(48, 16)
            Me.label36.TabIndex = 1
            Me.label36.Text = "Green:"
            '
            'label35
            '
            Me.label35.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label35.Location = New System.Drawing.Point(16, 26)
            Me.label35.Name = "label35"
            Me.label35.Size = New System.Drawing.Size(40, 16)
            Me.label35.TabIndex = 0
            Me.label35.Text = "Red:"
            '
            'label5
            '
            Me.label5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label5.Location = New System.Drawing.Point(328, 208)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(112, 16)
            Me.label5.TabIndex = 5
            Me.label5.Text = "Data Orientation:"
            '
            'label6
            '
            Me.label6.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label6.Location = New System.Drawing.Point(40, 186)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(56, 16)
            Me.label6.TabIndex = 6
            Me.label6.Text = "Dither:"
            '
            'label7
            '
            Me.label7.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label7.Location = New System.Drawing.Point(40, 218)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(64, 16)
            Me.label7.TabIndex = 9
            Me.label7.Text = "Emphasis:"
            '
            'label9
            '
            Me.label9.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label9.Location = New System.Drawing.Point(328, 232)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(56, 16)
            Me.label9.TabIndex = 11
            Me.label9.Text = "File Type:"
            '
            'label10
            '
            Me.label10.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label10.Location = New System.Drawing.Point(40, 250)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(56, 16)
            Me.label10.TabIndex = 12
            Me.label10.Text = "Gamma:"
            '
            'label11
            '
            Me.label11.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label11.Location = New System.Drawing.Point(24, 256)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(136, 16)
            Me.label11.TabIndex = 13
            Me.label11.Text = "Job Separator Detection:"
            '
            'label15
            '
            Me.label15.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label15.Location = New System.Drawing.Point(320, 220)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(88, 16)
            Me.label15.TabIndex = 17
            Me.label15.Text = "Overscan Color:"
            '
            'label17
            '
            Me.label17.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label17.Location = New System.Drawing.Point(328, 184)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(80, 16)
            Me.label17.TabIndex = 19
            Me.label17.Text = "Page Size:"
            '
            'label18
            '
            Me.label18.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label18.Location = New System.Drawing.Point(24, 100)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(64, 16)
            Me.label18.TabIndex = 20
            Me.label18.Text = "Resolution:"
            '
            'label19
            '
            Me.label19.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label19.Location = New System.Drawing.Point(24, 138)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(88, 16)
            Me.label19.TabIndex = 21
            Me.label19.Text = "Resolution Unit:"
            '
            'label21
            '
            Me.label21.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label21.Location = New System.Drawing.Point(24, 232)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(104, 16)
            Me.label21.TabIndex = 23
            Me.label21.Text = "Scan Ahead Count:"
            '
            'label24
            '
            Me.label24.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label24.Location = New System.Drawing.Point(24, 24)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(64, 16)
            Me.label24.TabIndex = 26
            Me.label24.Text = "Scan Type:"
            '
            'label25
            '
            Me.label25.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label25.Location = New System.Drawing.Point(320, 186)
            Me.label25.Name = "label25"
            Me.label25.Size = New System.Drawing.Size(72, 16)
            Me.label25.TabIndex = 27
            Me.label25.Text = "Sharpness:"
            '
            'tabControl1
            '
            Me.tabControl1.Controls.Add(Me.tabPage1)
            Me.tabControl1.Controls.Add(Me.tabPage6)
            Me.tabControl1.Controls.Add(Me.tabPage3)
            Me.tabControl1.Controls.Add(Me.tabPage4)
            Me.tabControl1.Controls.Add(Me.tabPage2)
            Me.tabControl1.Location = New System.Drawing.Point(16, 64)
            Me.tabControl1.Name = "tabControl1"
            Me.tabControl1.SelectedIndex = 0
            Me.tabControl1.Size = New System.Drawing.Size(592, 320)
            Me.tabControl1.TabIndex = 7
            '
            'tabPage1
            '
            Me.tabPage1.Controls.Add(Me.ButtonAbout)
            Me.tabPage1.Controls.Add(Me.numScanAheadCount)
            Me.tabPage1.Controls.Add(Me.cboResolution)
            Me.tabPage1.Controls.Add(Me.cboResolutionUnit)
            Me.tabPage1.Controls.Add(Me.cboPageSize)
            Me.tabPage1.Controls.Add(Me.cboColorFormat)
            Me.tabPage1.Controls.Add(Me.groupBox3)
            Me.tabPage1.Controls.Add(Me.cboDataOrientation)
            Me.tabPage1.Controls.Add(Me.cboFileType)
            Me.tabPage1.Controls.Add(Me.cboJobSeparation)
            Me.tabPage1.Controls.Add(Me.chkMixedScanning)
            Me.tabPage1.Controls.Add(Me.chkScanAhead)
            Me.tabPage1.Controls.Add(Me.cboScanType)
            Me.tabPage1.Controls.Add(Me.label5)
            Me.tabPage1.Controls.Add(Me.label9)
            Me.tabPage1.Controls.Add(Me.label11)
            Me.tabPage1.Controls.Add(Me.label21)
            Me.tabPage1.Controls.Add(Me.label24)
            Me.tabPage1.Controls.Add(Me.label18)
            Me.tabPage1.Controls.Add(Me.label19)
            Me.tabPage1.Controls.Add(Me.label17)
            Me.tabPage1.Controls.Add(Me.label3)
            Me.tabPage1.Location = New System.Drawing.Point(4, 22)
            Me.tabPage1.Name = "tabPage1"
            Me.tabPage1.Size = New System.Drawing.Size(584, 294)
            Me.tabPage1.TabIndex = 0
            Me.tabPage1.Text = "General"
            '
            'numScanAheadCount
            '
            Me.numScanAheadCount.Location = New System.Drawing.Point(152, 230)
            Me.numScanAheadCount.Name = "numScanAheadCount"
            Me.numScanAheadCount.Size = New System.Drawing.Size(64, 20)
            Me.numScanAheadCount.TabIndex = 38
            '
            'cboResolution
            '
            Me.cboResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboResolution.Location = New System.Drawing.Point(112, 98)
            Me.cboResolution.Name = "cboResolution"
            Me.cboResolution.Size = New System.Drawing.Size(120, 21)
            Me.cboResolution.TabIndex = 37
            '
            'cboResolutionUnit
            '
            Me.cboResolutionUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboResolutionUnit.Location = New System.Drawing.Point(112, 136)
            Me.cboResolutionUnit.Name = "cboResolutionUnit"
            Me.cboResolutionUnit.Size = New System.Drawing.Size(120, 21)
            Me.cboResolutionUnit.TabIndex = 36
            '
            'cboPageSize
            '
            Me.cboPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboPageSize.Location = New System.Drawing.Point(416, 182)
            Me.cboPageSize.Name = "cboPageSize"
            Me.cboPageSize.Size = New System.Drawing.Size(144, 21)
            Me.cboPageSize.TabIndex = 35
            '
            'cboColorFormat
            '
            Me.cboColorFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboColorFormat.Location = New System.Drawing.Point(112, 60)
            Me.cboColorFormat.Name = "cboColorFormat"
            Me.cboColorFormat.Size = New System.Drawing.Size(120, 21)
            Me.cboColorFormat.TabIndex = 34
            '
            'groupBox3
            '
            Me.groupBox3.Controls.Add(Me.numAreaHeight)
            Me.groupBox3.Controls.Add(Me.label16)
            Me.groupBox3.Controls.Add(Me.numAreaWidth)
            Me.groupBox3.Controls.Add(Me.label13)
            Me.groupBox3.Controls.Add(Me.numAreaTop)
            Me.groupBox3.Controls.Add(Me.label12)
            Me.groupBox3.Controls.Add(Me.numAreaLeft)
            Me.groupBox3.Controls.Add(Me.label8)
            Me.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox3.Location = New System.Drawing.Point(328, 16)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Size = New System.Drawing.Size(152, 144)
            Me.groupBox3.TabIndex = 33
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "Scan Area"
            '
            'numAreaHeight
            '
            Me.numAreaHeight.Location = New System.Drawing.Point(72, 111)
            Me.numAreaHeight.Name = "numAreaHeight"
            Me.numAreaHeight.Size = New System.Drawing.Size(56, 20)
            Me.numAreaHeight.TabIndex = 7
            '
            'label16
            '
            Me.label16.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label16.Location = New System.Drawing.Point(16, 113)
            Me.label16.Name = "label16"
            Me.label16.Size = New System.Drawing.Size(56, 16)
            Me.label16.TabIndex = 6
            Me.label16.Text = "Height:"
            '
            'numAreaWidth
            '
            Me.numAreaWidth.Location = New System.Drawing.Point(72, 82)
            Me.numAreaWidth.Name = "numAreaWidth"
            Me.numAreaWidth.Size = New System.Drawing.Size(56, 20)
            Me.numAreaWidth.TabIndex = 5
            '
            'label13
            '
            Me.label13.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label13.Location = New System.Drawing.Point(16, 84)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(56, 16)
            Me.label13.TabIndex = 4
            Me.label13.Text = "Width:"
            '
            'numAreaTop
            '
            Me.numAreaTop.Location = New System.Drawing.Point(72, 53)
            Me.numAreaTop.Name = "numAreaTop"
            Me.numAreaTop.Size = New System.Drawing.Size(56, 20)
            Me.numAreaTop.TabIndex = 3
            '
            'label12
            '
            Me.label12.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label12.Location = New System.Drawing.Point(16, 55)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(56, 16)
            Me.label12.TabIndex = 2
            Me.label12.Text = "Top:"
            '
            'numAreaLeft
            '
            Me.numAreaLeft.Location = New System.Drawing.Point(72, 24)
            Me.numAreaLeft.Name = "numAreaLeft"
            Me.numAreaLeft.Size = New System.Drawing.Size(56, 20)
            Me.numAreaLeft.TabIndex = 1
            '
            'label8
            '
            Me.label8.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label8.Location = New System.Drawing.Point(16, 26)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(56, 16)
            Me.label8.TabIndex = 0
            Me.label8.Text = "Left:"
            '
            'cboDataOrientation
            '
            Me.cboDataOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboDataOrientation.Location = New System.Drawing.Point(416, 206)
            Me.cboDataOrientation.Name = "cboDataOrientation"
            Me.cboDataOrientation.Size = New System.Drawing.Size(144, 21)
            Me.cboDataOrientation.TabIndex = 32
            '
            'cboFileType
            '
            Me.cboFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboFileType.Location = New System.Drawing.Point(416, 230)
            Me.cboFileType.Name = "cboFileType"
            Me.cboFileType.Size = New System.Drawing.Size(144, 21)
            Me.cboFileType.TabIndex = 31
            '
            'cboJobSeparation
            '
            Me.cboJobSeparation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboJobSeparation.Location = New System.Drawing.Point(152, 254)
            Me.cboJobSeparation.Name = "cboJobSeparation"
            Me.cboJobSeparation.Size = New System.Drawing.Size(128, 21)
            Me.cboJobSeparation.TabIndex = 30
            '
            'chkMixedScanning
            '
            Me.chkMixedScanning.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkMixedScanning.Location = New System.Drawing.Point(24, 184)
            Me.chkMixedScanning.Name = "chkMixedScanning"
            Me.chkMixedScanning.Size = New System.Drawing.Size(112, 16)
            Me.chkMixedScanning.TabIndex = 29
            Me.chkMixedScanning.Text = "Mixed Scanning"
            '
            'chkScanAhead
            '
            Me.chkScanAhead.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkScanAhead.Location = New System.Drawing.Point(24, 208)
            Me.chkScanAhead.Name = "chkScanAhead"
            Me.chkScanAhead.Size = New System.Drawing.Size(88, 16)
            Me.chkScanAhead.TabIndex = 28
            Me.chkScanAhead.Text = "Scan Ahead"
            '
            'cboScanType
            '
            Me.cboScanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboScanType.Location = New System.Drawing.Point(112, 22)
            Me.cboScanType.Name = "cboScanType"
            Me.cboScanType.Size = New System.Drawing.Size(120, 21)
            Me.cboScanType.TabIndex = 27
            '
            'tabPage6
            '
            Me.tabPage6.Controls.Add(Me.chkOutline)
            Me.tabPage6.Controls.Add(Me.btnOverscanColor)
            Me.tabPage6.Controls.Add(Me.cboSharpness)
            Me.tabPage6.Controls.Add(Me.cboGamma)
            Me.tabPage6.Controls.Add(Me.cboEmphasis)
            Me.tabPage6.Controls.Add(Me.cboDither)
            Me.tabPage6.Controls.Add(Me.cboBrightness)
            Me.tabPage6.Controls.Add(Me.cboContrast)
            Me.tabPage6.Controls.Add(Me.label7)
            Me.tabPage6.Controls.Add(Me.label10)
            Me.tabPage6.Controls.Add(Me.label6)
            Me.tabPage6.Controls.Add(Me.label4)
            Me.tabPage6.Controls.Add(Me.label2)
            Me.tabPage6.Controls.Add(Me.groupBox2)
            Me.tabPage6.Controls.Add(Me.groupBox1)
            Me.tabPage6.Controls.Add(Me.label25)
            Me.tabPage6.Controls.Add(Me.label15)
            Me.tabPage6.Location = New System.Drawing.Point(4, 22)
            Me.tabPage6.Name = "tabPage6"
            Me.tabPage6.Size = New System.Drawing.Size(584, 294)
            Me.tabPage6.TabIndex = 5
            Me.tabPage6.Text = "Image Processing"
            '
            'chkOutline
            '
            Me.chkOutline.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkOutline.Location = New System.Drawing.Point(320, 250)
            Me.chkOutline.Name = "chkOutline"
            Me.chkOutline.Size = New System.Drawing.Size(64, 16)
            Me.chkOutline.TabIndex = 35
            Me.chkOutline.Text = "Outline"
            '
            'btnOverscanColor
            '
            Me.btnOverscanColor.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnOverscanColor.Location = New System.Drawing.Point(408, 216)
            Me.btnOverscanColor.Name = "btnOverscanColor"
            Me.btnOverscanColor.Size = New System.Drawing.Size(104, 24)
            Me.btnOverscanColor.TabIndex = 34
            Me.btnOverscanColor.Text = "Choose Color..."
            '
            'cboSharpness
            '
            Me.cboSharpness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboSharpness.Location = New System.Drawing.Point(408, 184)
            Me.cboSharpness.Name = "cboSharpness"
            Me.cboSharpness.Size = New System.Drawing.Size(104, 21)
            Me.cboSharpness.TabIndex = 33
            '
            'cboGamma
            '
            Me.cboGamma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboGamma.Location = New System.Drawing.Point(104, 248)
            Me.cboGamma.Name = "cboGamma"
            Me.cboGamma.Size = New System.Drawing.Size(128, 21)
            Me.cboGamma.TabIndex = 32
            '
            'cboEmphasis
            '
            Me.cboEmphasis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboEmphasis.Location = New System.Drawing.Point(104, 216)
            Me.cboEmphasis.Name = "cboEmphasis"
            Me.cboEmphasis.Size = New System.Drawing.Size(128, 21)
            Me.cboEmphasis.TabIndex = 31
            '
            'cboDither
            '
            Me.cboDither.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboDither.Location = New System.Drawing.Point(104, 184)
            Me.cboDither.Name = "cboDither"
            Me.cboDither.Size = New System.Drawing.Size(128, 21)
            Me.cboDither.TabIndex = 30
            '
            'cboBrightness
            '
            Me.cboBrightness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboBrightness.Location = New System.Drawing.Point(104, 24)
            Me.cboBrightness.Name = "cboBrightness"
            Me.cboBrightness.Size = New System.Drawing.Size(72, 21)
            Me.cboBrightness.TabIndex = 29
            '
            'cboContrast
            '
            Me.cboContrast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboContrast.Location = New System.Drawing.Point(376, 24)
            Me.cboContrast.Name = "cboContrast"
            Me.cboContrast.Size = New System.Drawing.Size(72, 21)
            Me.cboContrast.TabIndex = 28
            '
            'tabPage3
            '
            Me.tabPage3.Controls.Add(Me.label29)
            Me.tabPage3.Controls.Add(Me.label28)
            Me.tabPage3.Controls.Add(Me.numFeederTimeout)
            Me.tabPage3.Controls.Add(Me.chkFeederImmediateStop)
            Me.tabPage3.Controls.Add(Me.chkFeederStopPause)
            Me.tabPage3.Controls.Add(Me.groupBox4)
            Me.tabPage3.Location = New System.Drawing.Point(4, 22)
            Me.tabPage3.Name = "tabPage3"
            Me.tabPage3.Size = New System.Drawing.Size(584, 294)
            Me.tabPage3.TabIndex = 2
            Me.tabPage3.Text = "Feeder"
            '
            'label29
            '
            Me.label29.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label29.Location = New System.Drawing.Point(224, 232)
            Me.label29.Name = "label29"
            Me.label29.Size = New System.Drawing.Size(64, 16)
            Me.label29.TabIndex = 5
            Me.label29.Text = "seconds"
            '
            'label28
            '
            Me.label28.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label28.Location = New System.Drawing.Point(40, 232)
            Me.label28.Name = "label28"
            Me.label28.Size = New System.Drawing.Size(128, 16)
            Me.label28.TabIndex = 4
            Me.label28.Text = "Scan Attempt Timeout:"
            '
            'numFeederTimeout
            '
            Me.numFeederTimeout.Location = New System.Drawing.Point(168, 230)
            Me.numFeederTimeout.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.numFeederTimeout.Name = "numFeederTimeout"
            Me.numFeederTimeout.Size = New System.Drawing.Size(56, 20)
            Me.numFeederTimeout.TabIndex = 3
            '
            'chkFeederImmediateStop
            '
            Me.chkFeederImmediateStop.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkFeederImmediateStop.Location = New System.Drawing.Point(40, 200)
            Me.chkFeederImmediateStop.Name = "chkFeederImmediateStop"
            Me.chkFeederImmediateStop.Size = New System.Drawing.Size(288, 16)
            Me.chkFeederImmediateStop.TabIndex = 2
            Me.chkFeederImmediateStop.Text = "Stop immediately when the Stop button is pressed."
            '
            'chkFeederStopPause
            '
            Me.chkFeederStopPause.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkFeederStopPause.Location = New System.Drawing.Point(40, 168)
            Me.chkFeederStopPause.Name = "chkFeederStopPause"
            Me.chkFeederStopPause.Size = New System.Drawing.Size(200, 24)
            Me.chkFeederStopPause.TabIndex = 1
            Me.chkFeederStopPause.Text = "Stop scan ahead feature on pause"
            '
            'groupBox4
            '
            Me.groupBox4.Controls.Add(Me.lblFeederPause)
            Me.groupBox4.Controls.Add(Me.lblFeederPageDetect)
            Me.groupBox4.Controls.Add(Me.lblFeederPageCount)
            Me.groupBox4.Controls.Add(Me.lblFeederExists)
            Me.groupBox4.Controls.Add(Me.label26)
            Me.groupBox4.Controls.Add(Me.label23)
            Me.groupBox4.Controls.Add(Me.label22)
            Me.groupBox4.Controls.Add(Me.label20)
            Me.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox4.Location = New System.Drawing.Point(32, 24)
            Me.groupBox4.Name = "groupBox4"
            Me.groupBox4.Size = New System.Drawing.Size(272, 112)
            Me.groupBox4.TabIndex = 0
            Me.groupBox4.TabStop = False
            Me.groupBox4.Text = "Feeder Information"
            '
            'lblFeederPause
            '
            Me.lblFeederPause.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.lblFeederPause.Location = New System.Drawing.Point(152, 80)
            Me.lblFeederPause.Name = "lblFeederPause"
            Me.lblFeederPause.Size = New System.Drawing.Size(88, 16)
            Me.lblFeederPause.TabIndex = 8
            '
            'lblFeederPageDetect
            '
            Me.lblFeederPageDetect.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.lblFeederPageDetect.Location = New System.Drawing.Point(152, 64)
            Me.lblFeederPageDetect.Name = "lblFeederPageDetect"
            Me.lblFeederPageDetect.Size = New System.Drawing.Size(88, 16)
            Me.lblFeederPageDetect.TabIndex = 7
            '
            'lblFeederPageCount
            '
            Me.lblFeederPageCount.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.lblFeederPageCount.Location = New System.Drawing.Point(152, 48)
            Me.lblFeederPageCount.Name = "lblFeederPageCount"
            Me.lblFeederPageCount.Size = New System.Drawing.Size(88, 16)
            Me.lblFeederPageCount.TabIndex = 6
            '
            'lblFeederExists
            '
            Me.lblFeederExists.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.lblFeederExists.Location = New System.Drawing.Point(152, 32)
            Me.lblFeederExists.Name = "lblFeederExists"
            Me.lblFeederExists.Size = New System.Drawing.Size(88, 16)
            Me.lblFeederExists.TabIndex = 5
            '
            'label26
            '
            Me.label26.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label26.Location = New System.Drawing.Point(24, 80)
            Me.label26.Name = "label26"
            Me.label26.Size = New System.Drawing.Size(88, 16)
            Me.label26.TabIndex = 3
            Me.label26.Text = "Can Pause:"
            '
            'label23
            '
            Me.label23.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label23.Location = New System.Drawing.Point(24, 64)
            Me.label23.Name = "label23"
            Me.label23.Size = New System.Drawing.Size(88, 16)
            Me.label23.TabIndex = 2
            Me.label23.Text = "Page Detection:"
            '
            'label22
            '
            Me.label22.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label22.Location = New System.Drawing.Point(24, 48)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(128, 16)
            Me.label22.TabIndex = 1
            Me.label22.Text = "Maximum Page Count:"
            '
            'label20
            '
            Me.label20.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label20.Location = New System.Drawing.Point(24, 32)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(88, 16)
            Me.label20.TabIndex = 0
            Me.label20.Text = "Exists:"
            '
            'tabPage4
            '
            Me.tabPage4.Controls.Add(Me.chkBarcodeVerifyChecksum)
            Me.tabPage4.Controls.Add(Me.cboBarcodeSearchOrientation)
            Me.tabPage4.Controls.Add(Me.label34)
            Me.tabPage4.Controls.Add(Me.cboBarcodeSearchMode)
            Me.tabPage4.Controls.Add(Me.label33)
            Me.tabPage4.Controls.Add(Me.cboBarcodeSearchDirection)
            Me.tabPage4.Controls.Add(Me.label32)
            Me.tabPage4.Controls.Add(Me.chkBarcodeLinearSearch)
            Me.tabPage4.Controls.Add(Me.cboBarcodeImageQuality)
            Me.tabPage4.Controls.Add(Me.label31)
            Me.tabPage4.Controls.Add(Me.cboBarcodeEmphasis)
            Me.tabPage4.Controls.Add(Me.label30)
            Me.tabPage4.Controls.Add(Me.chkBarcodeBackSide)
            Me.tabPage4.Controls.Add(Me.chkBarcodeFrontSide)
            Me.tabPage4.Location = New System.Drawing.Point(4, 22)
            Me.tabPage4.Name = "tabPage4"
            Me.tabPage4.Size = New System.Drawing.Size(584, 294)
            Me.tabPage4.TabIndex = 3
            Me.tabPage4.Text = "Barcode"
            '
            'chkBarcodeVerifyChecksum
            '
            Me.chkBarcodeVerifyChecksum.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkBarcodeVerifyChecksum.Location = New System.Drawing.Point(24, 128)
            Me.chkBarcodeVerifyChecksum.Name = "chkBarcodeVerifyChecksum"
            Me.chkBarcodeVerifyChecksum.Size = New System.Drawing.Size(120, 16)
            Me.chkBarcodeVerifyChecksum.TabIndex = 13
            Me.chkBarcodeVerifyChecksum.Text = "Verify Checksum"
            '
            'cboBarcodeSearchOrientation
            '
            Me.cboBarcodeSearchOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboBarcodeSearchOrientation.Location = New System.Drawing.Point(384, 32)
            Me.cboBarcodeSearchOrientation.Name = "cboBarcodeSearchOrientation"
            Me.cboBarcodeSearchOrientation.Size = New System.Drawing.Size(104, 21)
            Me.cboBarcodeSearchOrientation.TabIndex = 12
            '
            'label34
            '
            Me.label34.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label34.Location = New System.Drawing.Point(280, 32)
            Me.label34.Name = "label34"
            Me.label34.Size = New System.Drawing.Size(120, 16)
            Me.label34.TabIndex = 11
            Me.label34.Text = "Search Orientation:"
            '
            'cboBarcodeSearchMode
            '
            Me.cboBarcodeSearchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboBarcodeSearchMode.Items.AddRange(New Object() {"Horizontal", "Vertical", "VerticalHorizontal", "HorizontalVertical"})
            Me.cboBarcodeSearchMode.Location = New System.Drawing.Point(384, 96)
            Me.cboBarcodeSearchMode.Name = "cboBarcodeSearchMode"
            Me.cboBarcodeSearchMode.Size = New System.Drawing.Size(104, 21)
            Me.cboBarcodeSearchMode.TabIndex = 10
            '
            'label33
            '
            Me.label33.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label33.Location = New System.Drawing.Point(280, 96)
            Me.label33.Name = "label33"
            Me.label33.Size = New System.Drawing.Size(88, 16)
            Me.label33.TabIndex = 9
            Me.label33.Text = "Search Mode:"
            '
            'cboBarcodeSearchDirection
            '
            Me.cboBarcodeSearchDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboBarcodeSearchDirection.Items.AddRange(New Object() {"Forward", "Reverse"})
            Me.cboBarcodeSearchDirection.Location = New System.Drawing.Point(384, 64)
            Me.cboBarcodeSearchDirection.Name = "cboBarcodeSearchDirection"
            Me.cboBarcodeSearchDirection.Size = New System.Drawing.Size(104, 21)
            Me.cboBarcodeSearchDirection.TabIndex = 8
            '
            'label32
            '
            Me.label32.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label32.Location = New System.Drawing.Point(280, 64)
            Me.label32.Name = "label32"
            Me.label32.Size = New System.Drawing.Size(120, 16)
            Me.label32.TabIndex = 7
            Me.label32.Text = "Search Direction:"
            '
            'chkBarcodeLinearSearch
            '
            Me.chkBarcodeLinearSearch.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkBarcodeLinearSearch.Location = New System.Drawing.Point(24, 104)
            Me.chkBarcodeLinearSearch.Name = "chkBarcodeLinearSearch"
            Me.chkBarcodeLinearSearch.Size = New System.Drawing.Size(128, 16)
            Me.chkBarcodeLinearSearch.TabIndex = 6
            Me.chkBarcodeLinearSearch.Text = "Linear Search"
            '
            'cboBarcodeImageQuality
            '
            Me.cboBarcodeImageQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboBarcodeImageQuality.Items.AddRange(New Object() {"Auto", "Dot Matrix", "Dithered"})
            Me.cboBarcodeImageQuality.Location = New System.Drawing.Point(384, 160)
            Me.cboBarcodeImageQuality.Name = "cboBarcodeImageQuality"
            Me.cboBarcodeImageQuality.Size = New System.Drawing.Size(104, 21)
            Me.cboBarcodeImageQuality.TabIndex = 5
            '
            'label31
            '
            Me.label31.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label31.Location = New System.Drawing.Point(280, 162)
            Me.label31.Name = "label31"
            Me.label31.Size = New System.Drawing.Size(104, 16)
            Me.label31.TabIndex = 4
            Me.label31.Text = "Image Quality:"
            '
            'cboBarcodeEmphasis
            '
            Me.cboBarcodeEmphasis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboBarcodeEmphasis.Items.AddRange(New Object() {"None", "White", "Black"})
            Me.cboBarcodeEmphasis.Location = New System.Drawing.Point(384, 128)
            Me.cboBarcodeEmphasis.Name = "cboBarcodeEmphasis"
            Me.cboBarcodeEmphasis.Size = New System.Drawing.Size(104, 21)
            Me.cboBarcodeEmphasis.TabIndex = 3
            '
            'label30
            '
            Me.label30.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label30.Location = New System.Drawing.Point(280, 130)
            Me.label30.Name = "label30"
            Me.label30.Size = New System.Drawing.Size(96, 16)
            Me.label30.TabIndex = 2
            Me.label30.Text = "Emphasis:"
            '
            'chkBarcodeBackSide
            '
            Me.chkBarcodeBackSide.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkBarcodeBackSide.Location = New System.Drawing.Point(24, 64)
            Me.chkBarcodeBackSide.Name = "chkBarcodeBackSide"
            Me.chkBarcodeBackSide.Size = New System.Drawing.Size(120, 16)
            Me.chkBarcodeBackSide.TabIndex = 1
            Me.chkBarcodeBackSide.Text = "Enable Back Side"
            '
            'chkBarcodeFrontSide
            '
            Me.chkBarcodeFrontSide.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkBarcodeFrontSide.Location = New System.Drawing.Point(24, 40)
            Me.chkBarcodeFrontSide.Name = "chkBarcodeFrontSide"
            Me.chkBarcodeFrontSide.Size = New System.Drawing.Size(128, 16)
            Me.chkBarcodeFrontSide.TabIndex = 0
            Me.chkBarcodeFrontSide.Text = "Enable Front Side"
            '
            'tabPage2
            '
            Me.tabPage2.Controls.Add(Me.listSettings)
            Me.tabPage2.Controls.Add(Me.label14)
            Me.tabPage2.Location = New System.Drawing.Point(4, 22)
            Me.tabPage2.Name = "tabPage2"
            Me.tabPage2.Size = New System.Drawing.Size(584, 294)
            Me.tabPage2.TabIndex = 6
            Me.tabPage2.Text = "Supported Settings"
            '
            'listSettings
            '
            Me.listSettings.Location = New System.Drawing.Point(128, 61)
            Me.listSettings.Name = "listSettings"
            Me.listSettings.Size = New System.Drawing.Size(328, 173)
            Me.listSettings.TabIndex = 1
            '
            'label14
            '
            Me.label14.Location = New System.Drawing.Point(72, 24)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(440, 24)
            Me.label14.TabIndex = 0
            Me.label14.Text = "This is a list of settings retrieved from the IsisController.GetSupportedSettings" & _
                " method."
            '
            'ButtonAbout
            '
            Me.ButtonAbout.Location = New System.Drawing.Point(485, 257)
            Me.ButtonAbout.Name = "ButtonAbout"
            Me.ButtonAbout.Size = New System.Drawing.Size(75, 23)
            Me.ButtonAbout.TabIndex = 39
            Me.ButtonAbout.Text = "About ..."
            Me.ButtonAbout.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(624, 398)
            Me.Controls.Add(Me.tabControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "Form1"
            Me.Text = "Save and Restore Settings"
            Me.panel1.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            CType(Me.numBrightnessBlue, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numBrightnessGreen, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numBrightnessRed, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox2.ResumeLayout(False)
            CType(Me.numContrastBlue, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numContrastGreen, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numContrastRed, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControl1.ResumeLayout(False)
            Me.tabPage1.ResumeLayout(False)
            CType(Me.numScanAheadCount, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox3.ResumeLayout(False)
            CType(Me.numAreaHeight, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numAreaWidth, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numAreaTop, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numAreaLeft, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPage6.ResumeLayout(False)
            Me.tabPage3.ResumeLayout(False)
            CType(Me.numFeederTimeout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox4.ResumeLayout(False)
            Me.tabPage4.ResumeLayout(False)
            Me.tabPage2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.DoEvents()
            Application.Run(New Form1())
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' This will throw an exception if there is no license.
            Try
                Dim img As Atalasoft.Imaging.AtalaImage = New Atalasoft.Imaging.AtalaImage()
                img.Dispose()

                _controller = New Atalasoft.Isis.IsisController()
            Catch e1 As Atalasoft.Imaging.AtalasoftLicenseException
                MessageBox.Show("This demo requires a license for 'DotImage' and 'DotImage ISIS'." & Constants.vbCrLf & Constants.vbCrLf & "You can get an evaluation license using the Activation utility or" & Constants.vbCrLf & "from http://www.atalasoft.com/portal/requestevaluation.aspx.", "No License Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Return
            End Try

            AddHandler _controller.ImageAcquired, AddressOf _controller_ImageAcquired
            AddHandler _controller.ErrorNotification, AddressOf _controller_ErrorNotification
            AddHandler _controller.BarcodeDetected, AddressOf _controller_BarcodeDetected

            If _controller.Devices.Count > 0 Then
                Me.cboDevice.Items.AddRange(_controller.Devices.ToArray())
                Dim defaultDev As IsisDevice = _controller.Devices.Default
                If defaultDev IsNot Nothing Then
                    Dim index As Integer = Me.cboDevice.Items.IndexOf(defaultDev)
                    If index > -1 Then
                        Me.cboDevice.SelectedIndex = index
                    End If
                End If
            Else
                Me.tabControl1.Enabled = False
                Me.btnScan.Enabled = False
                Me.btnSave.Enabled = False
                Me.btnRestore.Enabled = False
                Me.cboDevice.Enabled = False

                MessageBox.Show("No ISIS devices were found on your system.", "No Devices", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.Text = "Atalasoft DotImage ISIS Settings Demo - Version " & GetDotImageIsisVersion()
        End Sub

        Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
            If _controller IsNot Nothing Then
                _controller.Dispose()
            End If
        End Sub

#Region "Main Controls"

        Private Sub btnRestore_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRestore.Click
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Filter = "XML File (*.xml)|*.xml|INI File (*.ini)|*.ini"
            If dlg.ShowDialog(Me) = DialogResult.OK Then
                If _controller.Open() Then
                    Try
                        If dlg.FilterIndex = 1 Then
                            _controller.RestoreSettings(dlg.FileName)
                        Else
                            _controller.RestoreIniSettings(dlg.FileName, "ScannerSettings")
                        End If

                        ' Update the settings.
                        FillControls()
                    Finally
                        _controller.Close()
                    End Try
                End If
            End If
            dlg.Dispose()

        End Sub

        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
            Dim dlg As SaveFileDialog = New SaveFileDialog()
            dlg.Filter = "XML File (*.xml)|*.xml|INI File (*.ini)|*.ini"
            If dlg.ShowDialog(Me) = DialogResult.OK Then
                If _controller.Open() Then
                    Try
                        SetDeviceSettings()

                        ' Normally you would not need to use the SaveSettings when you have your own
                        ' user interface for the driver.  This is here simply to provide an example.
                        If dlg.FilterIndex = 1 Then
                            _controller.SaveSettings(dlg.FileName)
                        Else
                            _controller.SaveIniSettings(dlg.FileName, "ScannerSettings")
                        End If
                    Finally
                        _controller.Close()
                    End Try
                End If
            End If
            dlg.Dispose()
        End Sub

        Private Sub btnScan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnScan.Click
            If _controller.ActiveDevice.Open() Then
                Try
                    Me.Cursor = Cursors.WaitCursor
                    SetDeviceSettings()

                    If _controller.ShowDeviceDialog(Me) Then
                        _controller.Acquire()
                    End If
                Finally
                    _controller.ActiveDevice.Close()
                    Me.Cursor = Cursors.Default
                End Try
            Else
                MessageBox.Show("We were unable to open an connection to the device.", "Open Failed")
            End If
        End Sub

        Private Sub cboDevice_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDevice.SelectedIndexChanged
            _controller.ActiveDevice = CType(Me.cboDevice.SelectedItem, Atalasoft.Isis.IsisDevice)
            FillControls()
        End Sub

        Private Sub cboPageSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPageSize.SelectedIndexChanged
            If _controller.State = IsisState.Open Then
                Return
            End If

            ' If the scan area is supported, update the values.
            If _controller.Open() Then
                Try
                    If _controller.QuerySupport(IsisSetting.PositionX) Then
                        Dim rc As Rectangle = _controller.ActiveDevice.Settings.ScanArea
                        Me.numAreaLeft.Value = rc.X
                        Me.numAreaTop.Value = rc.Y
                        Me.numAreaWidth.Value = rc.Width
                        Me.numAreaHeight.Value = rc.Height
                    End If
                Finally
                    _controller.Close()
                End Try
            End If
        End Sub

#End Region

        Private Sub SetDeviceSettings()
            If _controller.ActiveDevice.State <> IsisState.Open Then
                MessageBox.Show("The device must be open before calling SetDeviceSettings.", "Device Not Open")
                Return
            End If

            Dim settings As IsisSettings = _controller.ActiveDevice.Settings

            ' General
            If Me.cboScanType.Enabled Then
                settings.ScanType = CType(Me.cboScanType.SelectedItem, IsisScanType)
            End If
            If Me.cboColorFormat.Enabled Then
                settings.PixelFormat = CType(Me.cboColorFormat.SelectedItem, IsisPixelFormat)
            End If
            If Me.cboPageSize.Enabled Then
                settings.PageSize = Me.cboPageSize.Text
            End If
            If Me.cboResolutionUnit.Enabled Then
                settings.ResolutionUnit = CType(Me.cboResolutionUnit.SelectedItem, IsisResolutionUnit)
            End If
            If Me.cboResolution.Enabled Then
                settings.Resolution = CType(Me.cboResolution.SelectedItem, Rational)
            End If
            If Me.cboJobSeparation.Enabled Then
                settings.JobSeparatorDetection = CType(Me.cboJobSeparation.SelectedItem, IsisJobSeparatorDetection)
            End If
            If Me.cboDataOrientation.Enabled Then
                settings.DataOrientation = CType(Me.cboDataOrientation.SelectedItem, IsisOrientation)
            End If
            If Me.cboFileType.Enabled Then
                settings.FileType = CType(Me.cboFileType.SelectedItem, IsisFileType)
            End If

            settings.MixedScanning = Me.chkMixedScanning.Checked
            settings.ScanAhead = Me.chkScanAhead.Checked
            settings.ScanAheadCount = CInt(Me.numScanAheadCount.Value)

            If Me.numAreaLeft.Enabled Then
                Dim x As Integer = Convert.ToInt32(Me.numAreaLeft.Value)
                Dim y As Integer = Convert.ToInt32(Me.numAreaTop.Value)
                Dim w As Integer = Convert.ToInt32(Me.numAreaWidth.Value)
                Dim h As Integer = Convert.ToInt32(Me.numAreaHeight.Value)
                If w <> 0 AndAlso h <> 0 Then
                    settings.ScanArea = New Rectangle(x, y, w, h)
                End If
            End If

            ' Image Processing
            If Me.cboBrightness.Enabled Then
                settings.Brightness = CType(Me.cboBrightness.SelectedItem, IsisBrightness)
            End If
            If Me.cboContrast.Enabled Then
                settings.Contrast = CInt(Me.cboContrast.SelectedItem)
            End If
            If Me.cboEmphasis.Enabled Then
                settings.Emphasis = CType(Me.cboEmphasis.SelectedItem, IsisEmphasis)
            End If
            If Me.cboGamma.Enabled Then
                settings.Gamma = CInt(Me.cboGamma.SelectedItem)
            End If
            If Me.cboDither.Enabled Then
                settings.Dither = CStr(Me.cboDither.SelectedItem)
            End If
            If Me.cboSharpness.Enabled Then
                settings.Sharpness = CInt(Me.cboSharpness.SelectedItem)
            End If

            settings.Outline = Me.chkOutline.Checked

            If Me.btnOverscanColor.Enabled Then
                settings.OverscanColor = _overscanColor
            End If

            If Me.numBrightnessBlue.Enabled AndAlso Me.numBrightnessGreen.Enabled AndAlso Me.numBrightnessRed.Enabled Then
                settings.CustomBrightness = New IsisCustomBrightnessContrast(CInt(Me.numBrightnessRed.Value), CInt(Me.numBrightnessGreen.Value), CInt(Me.numBrightnessBlue.Value))
            End If

            If Me.numContrastBlue.Enabled AndAlso Me.numContrastGreen.Enabled AndAlso Me.numContrastRed.Enabled Then
                settings.CustomContrast = New IsisCustomBrightnessContrast(CInt(Me.numContrastRed.Value), CInt(Me.numContrastGreen.Value), CInt(Me.numContrastBlue.Value))
            End If

            ' Feeder
            settings.DocumentFeeder.StopScanAheadOnPause = Me.chkFeederStopPause.Checked
            settings.DocumentFeeder.ImmediateStop = Me.chkFeederImmediateStop.Checked
            settings.DocumentFeeder.Timeout = Convert.ToInt32(Me.numFeederTimeout.Value)

            ' Barcode
            If Me.chkBarcodeBackSide.Enabled OrElse Me.chkBarcodeFrontSide.Enabled Then
                Dim barSupport As IsisBarcodeSupport = IsisBarcodeSupport.None
                If Me.chkBarcodeFrontSide.Checked Then
                    barSupport = IsisBarcodeSupport.FrontSide
                End If
                If Me.chkBarcodeBackSide.Checked Then
                    barSupport = barSupport Or IsisBarcodeSupport.BackSide
                End If
                settings.Barcode.Enabled = barSupport

                If Me.chkBarcodeLinearSearch.Enabled Then
                    settings.Barcode.LinearSearch = Me.chkBarcodeLinearSearch.Checked
                End If
                If Me.chkBarcodeVerifyChecksum.Enabled Then
                    settings.Barcode.VerifyChecksum = Me.chkBarcodeVerifyChecksum.Checked
                End If
                If Me.cboBarcodeEmphasis.Enabled Then
                    settings.Barcode.Emphasis = CType(Me.cboBarcodeEmphasis.SelectedItem, IsisBarcodeEmphasis)
                End If
                If Me.cboBarcodeImageQuality.Enabled Then
                    settings.Barcode.ImageQuality = CType(Me.cboBarcodeImageQuality.SelectedItem, IsisBarcodeImageQuality)
                End If
                If Me.cboBarcodeSearchDirection.Enabled Then
                    settings.Barcode.SearchDirection = CType(Me.cboBarcodeSearchDirection.SelectedItem, IsisBarcodeSearchDirection)
                End If
                If Me.cboBarcodeSearchMode.Enabled Then
                    settings.Barcode.SearchMode = CType(Me.cboBarcodeSearchMode.SelectedItem, IsisBarcodeSearchMode)
                End If
                If Me.cboBarcodeSearchOrientation.Enabled Then
                    settings.Barcode.SearchOrientation = CType(Me.cboBarcodeSearchOrientation.SelectedItem, IsisOrientation)
                End If
            End If
        End Sub

        Private Sub FillControls()
            ClearControls()

            Dim closeDevice As Boolean = _controller.ActiveDevice.State = IsisState.Closed

            If (Not closeDevice) OrElse _controller.ActiveDevice.Open() Then
                Try
                    Me.Cursor = Cursors.WaitCursor
                    Dim settings As IsisSettings = _controller.ActiveDevice.Settings

                    Me.listSettings.Items.Clear()
                    Dim allSettings As IsisSetting() = _controller.GetSupportedSettings(False)
                    For Each isg As IsisSetting In allSettings
                        Me.listSettings.Items.Add(isg)
                    Next isg

                    ' Color format must always be supported.
                    Dim formats As IsisPixelFormat() = settings.GetSupportedColorFormats()
                    For Each cf As IsisPixelFormat In formats
                        Me.cboColorFormat.Items.Add(cf)
                    Next cf

                    Me.cboColorFormat.SelectedIndex = Me.cboColorFormat.Items.IndexOf(settings.PixelFormat)

                    LoadComboBoxValues(Me.cboScanType, IsisSetting.ScanType)
                    LoadComboBoxValues(Me.cboPageSize, IsisSetting.PageSize)
                    LoadComboBoxValues(Me.cboResolution, IsisSetting.ResolutionX)
                    LoadComboBoxValues(Me.cboResolutionUnit, IsisSetting.ResolutionUnit)
                    LoadNumValue(Me.numScanAheadCount, IsisSetting.ScanAheadCount)
                    LoadComboBoxValues(Me.cboJobSeparation, IsisSetting.JobSeparatorDetection)
                    LoadComboBoxValues(Me.cboDataOrientation, IsisSetting.DataOrientation)
                    LoadComboBoxValues(Me.cboFileType, IsisSetting.FileType)

                    If _controller.QuerySupport(IsisSetting.MixedScanning) Then
                        Me.chkMixedScanning.Enabled = True
                        Me.chkMixedScanning.Checked = settings.MixedScanning
                    Else
                        Me.chkMixedScanning.Enabled = False
                    End If

                    If _controller.QuerySupport(IsisSetting.ScanAhead) Then
                        Me.chkScanAhead.Enabled = True
                        Me.chkScanAhead.Checked = settings.ScanAhead
                    Else
                        Me.chkScanAhead.Enabled = False
                    End If

                    Dim rc As Rectangle = settings.ScanArea
                    If _controller.QuerySupport(IsisSetting.PositionX) Then
                        Me.numAreaLeft.Enabled = True
                        Me.numAreaLeft.Maximum = Integer.MaxValue
                        Me.numAreaLeft.Value = rc.X
                    Else
                        Me.numAreaLeft.Enabled = False
                    End If

                    If _controller.QuerySupport(IsisSetting.PositionY) Then
                        Me.numAreaTop.Enabled = True
                        Me.numAreaTop.Maximum = Integer.MaxValue
                        Me.numAreaTop.Value = rc.Y
                    Else
                        Me.numAreaTop.Enabled = False
                    End If

                    If _controller.QuerySupport(IsisSetting.ImageWidth) Then
                        Me.numAreaWidth.Enabled = True
                        Me.numAreaWidth.Maximum = Integer.MaxValue
                        Me.numAreaWidth.Value = rc.Width
                    Else
                        Me.numAreaWidth.Enabled = False
                    End If

                    If _controller.QuerySupport(IsisSetting.ImageLength) Then
                        Me.numAreaHeight.Enabled = True
                        Me.numAreaHeight.Maximum = Integer.MaxValue
                        Me.numAreaHeight.Value = rc.Height
                    Else
                        Me.numAreaHeight.Enabled = False
                    End If

                    ' Image Processing
                    LoadComboBoxValues(Me.cboBrightness, IsisSetting.Brightness)
                    LoadComboBoxValues(Me.cboContrast, IsisSetting.Contrast)
                    LoadComboBoxValues(Me.cboDither, IsisSetting.Dither)
                    LoadComboBoxValues(Me.cboGamma, IsisSetting.Gamma)
                    LoadComboBoxValues(Me.cboEmphasis, IsisSetting.Emphasis)
                    LoadComboBoxValues(Me.cboSharpness, IsisSetting.Sharpness)
                    LoadNumValue(Me.numBrightnessBlue, IsisSetting.BlueBrightness)
                    LoadNumValue(Me.numBrightnessGreen, IsisSetting.GreenBrightness)
                    LoadNumValue(Me.numBrightnessRed, IsisSetting.RedBrightness)
                    LoadNumValue(Me.numContrastBlue, IsisSetting.BlueContrast)
                    LoadNumValue(Me.numContrastGreen, IsisSetting.GreenContrast)
                    LoadNumValue(Me.numContrastRed, IsisSetting.RedContrast)

                    If _controller.QuerySupport(IsisSetting.OverscanColor) Then
                        Me.btnOverscanColor.Enabled = True
                        _overscanColor = settings.OverscanColor
                        Me.btnOverscanColor.Text = _overscanColor.Name
                    Else
                        Me.btnOverscanColor.Enabled = False
                    End If

                    ' Feeder settings
                    Me.lblFeederExists.Text = settings.DocumentFeeder.Exists.ToString()
                    Me.lblFeederPageCount.Text = settings.DocumentFeeder.MaximumPageCount.ToString()
                    Me.lblFeederPageDetect.Text = settings.DocumentFeeder.PageDetection.ToString()
                    Me.lblFeederPause.Text = settings.DocumentFeeder.CanPause.ToString()
                    LoadNumValue(Me.numFeederTimeout, IsisSetting.FeederTimeout)

                    If _controller.QuerySupport(IsisSetting.FeederStopMode) Then
                        Me.chkFeederImmediateStop.Enabled = True
                        Me.chkFeederImmediateStop.Checked = settings.DocumentFeeder.ImmediateStop
                    Else
                        Me.chkFeederImmediateStop.Enabled = False
                    End If

                    If _controller.QuerySupport(IsisSetting.FeederPauseMode) Then
                        Me.chkFeederStopPause.Enabled = True
                        Me.chkFeederStopPause.Checked = settings.DocumentFeeder.StopScanAheadOnPause
                    Else
                        Me.chkFeederStopPause.Enabled = False
                    End If

                    ' Barcode settings
                    Me.chkBarcodeBackSide.Enabled = False
                    Me.chkBarcodeFrontSide.Enabled = False
                    Me.chkBarcodeLinearSearch.Enabled = False
                    Me.chkBarcodeVerifyChecksum.Enabled = False

                    If settings.QuerySupport(IsisSetting.BarcodeAutoReadBack) Then
                        Me.chkBarcodeBackSide.Enabled = True
                        Me.chkBarcodeBackSide.Checked = ((settings.Barcode.Enabled And IsisBarcodeSupport.BackSide) = IsisBarcodeSupport.BackSide)
                    End If

                    If settings.QuerySupport(IsisSetting.BarcodeAutoReadFront) OrElse settings.QuerySupport(IsisSetting.Barcode) Then
                        Me.chkBarcodeFrontSide.Enabled = True
                        Me.chkBarcodeFrontSide.Checked = ((settings.Barcode.Enabled And IsisBarcodeSupport.FrontSide) = IsisBarcodeSupport.FrontSide)
                    End If

                    If settings.QuerySupport(IsisSetting.BarcodeChecksum) Then
                        Me.chkBarcodeVerifyChecksum.Enabled = True
                        Me.chkBarcodeVerifyChecksum.Checked = settings.Barcode.VerifyChecksum
                    End If

                    If settings.QuerySupport(IsisSetting.BarcodeSearchLinear) Then
                        Me.chkBarcodeLinearSearch.Enabled = True
                        Me.chkBarcodeLinearSearch.Checked = settings.Barcode.LinearSearch
                    End If

                    LoadComboBoxValues(Me.cboBarcodeEmphasis, IsisSetting.BarcodeEmphasis)
                    LoadComboBoxValues(Me.cboBarcodeImageQuality, IsisSetting.BarcodeImageQuality)
                    LoadComboBoxValues(Me.cboBarcodeSearchDirection, IsisSetting.BarcodeSearchDirection)
                    LoadComboBoxValues(Me.cboBarcodeSearchMode, IsisSetting.BarcodeSearchMode)
                    LoadComboBoxValues(Me.cboBarcodeSearchOrientation, IsisSetting.BarcodeSearchOrientation)
                Finally
                    If closeDevice Then
                        _controller.ActiveDevice.Close()
                    End If

                    Me.Cursor = Cursors.Default
                End Try
            Else
                MessageBox.Show("We were unable to open an connection to the device.", "Open Failed")
            End If

        End Sub

        Private Sub LoadNumValue(ByVal ctrl As NumericUpDown, ByVal setting As IsisSetting)
            If _controller.QuerySupport(setting) Then
                ctrl.Enabled = True
                Dim val As Integer = _controller.GetIntValue(setting, 0)

                ' Just in case a driver returns a larger value than expected.
                If val > ctrl.Maximum Then
                    ctrl.Maximum = val
                End If
                If val < ctrl.Minimum Then
                    ctrl.Minimum = val
                End If
                ctrl.Value = val
            Else
                ctrl.Enabled = False
            End If
        End Sub

        Private Sub LoadComboBoxValues(ByVal ctrl As ComboBox, ByVal setting As IsisSetting)
            ctrl.Items.Clear()

            Dim list As Object() = Nothing
            Dim selectedIndex As Integer = -1

            ctrl.Enabled = _controller.GetSupportedListValues(setting, list, selectedIndex)

            If Not list Is Nothing Then
                ctrl.Items.AddRange(list)
            End If

            If selectedIndex <> -1 Then
                ctrl.SelectedIndex = selectedIndex
            End If
        End Sub

        Private Sub ClearControls()
            ' General
            Me.cboColorFormat.Items.Clear()
            Me.chkMixedScanning.Checked = False
            Me.chkScanAhead.Checked = False
            ClearNumberControl(Me.numAreaHeight)
            ClearNumberControl(Me.numAreaLeft)
            ClearNumberControl(Me.numAreaTop)
            ClearNumberControl(Me.numAreaWidth)
            ClearNumberControl(Me.numScanAheadCount)

            ' Image Processing
            Me.chkOutline.Checked = False
            Me.numBrightnessBlue.Value = 0
            Me.numBrightnessGreen.Value = 0
            Me.numBrightnessRed.Value = 0
            Me.numContrastBlue.Value = 0
            Me.numContrastGreen.Value = 0
            Me.numContrastRed.Value = 0
            Me.btnOverscanColor.Text = "Choose Color..."

            ' Feeder
            Me.chkFeederImmediateStop.Checked = False
            Me.chkFeederStopPause.Checked = False
            Me.numFeederTimeout.Value = 0
            Me.lblFeederExists.Text = ""
            Me.lblFeederPageCount.Text = ""
            Me.lblFeederPageDetect.Text = ""
            Me.lblFeederPause.Text = ""

            ' Barcode
            Me.chkBarcodeBackSide.Checked = False
            Me.chkBarcodeFrontSide.Checked = False
            Me.chkBarcodeLinearSearch.Checked = False
            Me.chkBarcodeVerifyChecksum.Checked = False
        End Sub

        Private Sub ClearNumberControl(ByVal ctrl As NumericUpDown)
            ctrl.Minimum = 0
            ctrl.Value = 0
            ctrl.Maximum = 0
        End Sub

        Private Sub btnOverscanColor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOverscanColor.Click
            Dim dlg As ColorDialog = New ColorDialog()
            dlg.Color = _overscanColor

            If dlg.ShowDialog(Me) = DialogResult.OK Then
                _overscanColor = dlg.Color
                Me.btnOverscanColor.Text = dlg.Color.Name
            End If

            dlg.Dispose()
        End Sub

#Region "IsisController Events"

        Private Sub _controller_ImageAcquired(ByVal sender As Object, ByVal e As IsisImageAcquiredEventArgs)
            ' We don't care about the image in this demo.
            If Not e.Image Is Nothing Then
                e.Image.Dispose()
            End If
        End Sub

        Private Sub _controller_ErrorNotification(ByVal sender As Object, ByVal e As IsisErrorNotificationEventArgs)
            MessageBox.Show(e.Message, "Exception Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub

        Private Sub _controller_BarcodeDetected(ByVal sender As Object, ByVal e As IsisBarcodeDetectedEventArgs)
            MessageBox.Show("Code Type: " & e.CodeType.ToString(), "Barcode Detected")
        End Sub

#End Region

        Private Function GetDotImageIsisVersion() As String
            Try
                Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.Load("Atalasoft.dotImage.Isis")
                Dim ver As Version = asm.GetName().Version
                Return ver.ToString()
            Catch
                Return "unknown"
            End Try
        End Function

        Private Sub ButtonAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAbout.Click
            Dim aboutBox As AtalaDemos.AboutBox.About = New AtalaDemos.AboutBox.About("Atalasoft DotImage ISIS Settings Demo", "ISIS Settings Demo")
            aboutBox.Description = "Explores control over ISIS scanning settings in greater depth than our ISIS Demo." & vbCrLf & vbCrLf & _
                                   "Unlike our ISIS Demo, this is an in-depth exploration of available ISIS settings when connected to a given scanner. It allows you to view and modify the settings for your scanner." & vbCrLf & vbCrLf & _
                                   "Note: While you can tell it to perform a scan, there's no viewer here. Please see the aforementioned ISIS Demo if you're looking for an example of handling the acquired images"
            aboutBox.ShowDialog()
        End Sub
    End Class
End Namespace

