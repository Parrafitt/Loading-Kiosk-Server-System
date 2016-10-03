<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSysSettings
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSysSettings))
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel5 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.btnCmd = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtCommand = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCpNum = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDongle = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtReceived1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbSim1 = New DevComponents.DotNetBar.RibbonBar()
        Me.ItemContainer12 = New DevComponents.DotNetBar.ItemContainer()
        Me.btnSimStat1 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnSimSignal1 = New DevComponents.DotNetBar.ButtonItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.cboBaudRate1 = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboPort1 = New System.Windows.Forms.ComboBox()
        Me.cboStopBits1 = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboDataBits1 = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboParity1 = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.spSMSConfig = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.gpDeviceSettings = New System.Windows.Forms.GroupBox()
        Me.btnDevCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnDevEdit = New DevComponents.DotNetBar.ButtonX()
        Me.txtDevice = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.cboDevice = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.spSystemSettings = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.gp3 = New System.Windows.Forms.GroupBox()
        Me.cpDb = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.txtDBpw = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblPassword = New DevComponents.DotNetBar.LabelX()
        Me.txtDBuser = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.btnDBtest = New DevComponents.DotNetBar.ButtonX()
        Me.txtDBname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtDBsource = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.gp2 = New System.Windows.Forms.GroupBox()
        Me.btnOpen = New DevComponents.DotNetBar.ButtonX()
        Me.btnRestore = New DevComponents.DotNetBar.ButtonX()
        Me.txtRestoreFileName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtRestoreLoc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.gp1 = New System.Windows.Forms.GroupBox()
        Me.cbBackupOnExit = New System.Windows.Forms.CheckBox()
        Me.btnBrowse = New DevComponents.DotNetBar.ButtonX()
        Me.btnBackup = New DevComponents.DotNetBar.ButtonX()
        Me.txtBackupName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtBackupLocation = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.spDatabase = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.gpActivate = New System.Windows.Forms.GroupBox()
        Me.cp2 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.btnActivate = New DevComponents.DotNetBar.ButtonX()
        Me.txtCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.txtKey = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.gpActivationStatus = New System.Windows.Forms.GroupBox()
        Me.lblActivationStatus = New DevComponents.DotNetBar.LabelX()
        Me.spActivation = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.gpFingerprint = New System.Windows.Forms.GroupBox()
        Me.txtEmpNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.btnPwCancel = New DevComponents.DotNetBar.ButtonX()
        Me.imgPwError = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.imgPw = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.btnPwEdit = New DevComponents.DotNetBar.ButtonX()
        Me.txtPw1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblPw2 = New DevComponents.DotNetBar.LabelX()
        Me.txtPw2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnClearFp = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.imgFpError1 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.imgFpError0 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.imgFp0 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.imgFp1 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.btnFp0 = New DevComponents.DotNetBar.ButtonX()
        Me.btnFp1 = New DevComponents.DotNetBar.ButtonX()
        Me.gpInfo = New System.Windows.Forms.GroupBox()
        Me.btnChangePass = New DevComponents.DotNetBar.ButtonX()
        Me.txtTitle = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAccessLevel = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX22 = New DevComponents.DotNetBar.LabelX()
        Me.cboTitle = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.Mr = New DevComponents.Editors.ComboItem()
        Me.Ms = New DevComponents.Editors.ComboItem()
        Me.Mrs = New DevComponents.Editors.ComboItem()
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX()
        Me.cboAccessLevel = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.blank = New DevComponents.Editors.ComboItem()
        Me.Supervisor = New DevComponents.Editors.ComboItem()
        Me.staff = New DevComponents.Editors.ComboItem()
        Me.txtLname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.txtFname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.txtPass1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblPass1 = New DevComponents.DotNetBar.LabelX()
        Me.txtPass = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblPass = New DevComponents.DotNetBar.LabelX()
        Me.txtLogName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.gpList = New System.Windows.Forms.GroupBox()
        Me.cp1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.lblNoRecords = New DevComponents.DotNetBar.LabelX()
        Me.advTree1 = New DevComponents.AdvTree.AdvTree()
        Me.ElementStyle4 = New DevComponents.DotNetBar.ElementStyle()
        Me.ElementStyle2 = New DevComponents.DotNetBar.ElementStyle()
        Me.ElementStyle3 = New DevComponents.DotNetBar.ElementStyle()
        Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
        Me.btnRefresh = New DevComponents.DotNetBar.ButtonX()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.spUser = New DevComponents.DotNetBar.SuperTabItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bwQuery = New System.ComponentModel.BackgroundWorker()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.spDevice = New System.IO.Ports.SerialPort(Me.components)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.gpDeviceSettings.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.gp3.SuspendLayout()
        Me.gp2.SuspendLayout()
        Me.gp1.SuspendLayout()
        Me.SuperTabControlPanel3.SuspendLayout()
        Me.gpActivate.SuspendLayout()
        Me.gpActivationStatus.SuspendLayout()
        Me.SuperTabControlPanel4.SuspendLayout()
        Me.gpFingerprint.SuspendLayout()
        Me.gpInfo.SuspendLayout()
        Me.gpList.SuspendLayout()
        CType(Me.advTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SuperTabControl1
        '
        Me.SuperTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SuperTabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.ControlBox.Visible = False
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel5)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel4)
        Me.SuperTabControl1.ForeColor = System.Drawing.Color.Black
        Me.SuperTabControl1.Location = New System.Drawing.Point(12, 12)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(678, 454)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 0
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.spSystemSettings, Me.spUser, Me.spDatabase, Me.spActivation, Me.spSMSConfig})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Dock
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel5
        '
        Me.SuperTabControlPanel5.Controls.Add(Me.btnCmd)
        Me.SuperTabControlPanel5.Controls.Add(Me.GroupBox6)
        Me.SuperTabControlPanel5.Controls.Add(Me.GroupBox2)
        Me.SuperTabControlPanel5.Controls.Add(Me.GroupBox5)
        Me.SuperTabControlPanel5.Controls.Add(Me.GroupBox3)
        Me.SuperTabControlPanel5.Controls.Add(Me.GroupBox1)
        Me.SuperTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel5.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel5.Name = "SuperTabControlPanel5"
        Me.SuperTabControlPanel5.Size = New System.Drawing.Size(678, 454)
        Me.SuperTabControlPanel5.TabIndex = 0
        Me.SuperTabControlPanel5.TabItem = Me.spSMSConfig
        '
        'btnCmd
        '
        Me.btnCmd.Location = New System.Drawing.Point(530, 372)
        Me.btnCmd.Name = "btnCmd"
        Me.btnCmd.Size = New System.Drawing.Size(76, 23)
        Me.btnCmd.TabIndex = 36
        Me.btnCmd.Text = "Send"
        Me.btnCmd.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtCommand)
        Me.GroupBox6.Location = New System.Drawing.Point(16, 356)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(508, 48)
        Me.GroupBox6.TabIndex = 35
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Commands"
        '
        'txtCommand
        '
        '
        '
        '
        Me.txtCommand.Border.Class = "TextBoxBorder"
        Me.txtCommand.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCommand.Location = New System.Drawing.Point(3, 16)
        Me.txtCommand.Name = "txtCommand"
        Me.txtCommand.Size = New System.Drawing.Size(502, 20)
        Me.txtCommand.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCpNum)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cboDongle)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(290, 92)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Settings"
        '
        'txtCpNum
        '
        '
        '
        '
        Me.txtCpNum.Border.Class = "TextBoxBorder"
        Me.txtCpNum.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCpNum.Location = New System.Drawing.Point(77, 49)
        Me.txtCpNum.Name = "txtCpNum"
        Me.txtCpNum.Size = New System.Drawing.Size(207, 20)
        Me.txtCpNum.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Number"
        '
        'cboDongle
        '
        Me.cboDongle.FormattingEnabled = True
        Me.cboDongle.Location = New System.Drawing.Point(77, 19)
        Me.cboDongle.Name = "cboDongle"
        Me.cboDongle.Size = New System.Drawing.Size(207, 21)
        Me.cboDongle.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Device"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtReceived1)
        Me.GroupBox5.Location = New System.Drawing.Point(221, 129)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(446, 212)
        Me.GroupBox5.TabIndex = 33
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Data Recieve"
        '
        'txtReceived1
        '
        Me.txtReceived1.AcceptsTab = True
        Me.txtReceived1.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.txtReceived1.Border.Class = "TextBoxBorder"
        Me.txtReceived1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtReceived1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtReceived1.ForeColor = System.Drawing.Color.Yellow
        Me.txtReceived1.Location = New System.Drawing.Point(3, 16)
        Me.txtReceived1.Multiline = True
        Me.txtReceived1.Name = "txtReceived1"
        Me.txtReceived1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtReceived1.Size = New System.Drawing.Size(440, 193)
        Me.txtReceived1.TabIndex = 8
        Me.txtReceived1.Text = "Click 'Connect & Read' button to start . . ."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbSim1)
        Me.GroupBox3.Location = New System.Drawing.Point(309, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(142, 98)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Signal"
        '
        'rbSim1
        '
        Me.rbSim1.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbSim1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbSim1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbSim1.ContainerControlProcessDialogKey = True
        Me.rbSim1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbSim1.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center
        Me.rbSim1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer12})
        Me.rbSim1.Location = New System.Drawing.Point(3, 16)
        Me.rbSim1.Name = "rbSim1"
        Me.rbSim1.Size = New System.Drawing.Size(136, 79)
        Me.rbSim1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rbSim1.TabIndex = 28
        Me.rbSim1.Text = "NO SERVICE"
        '
        '
        '
        Me.rbSim1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbSim1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer12
        '
        '
        '
        '
        Me.ItemContainer12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer12.Name = "ItemContainer12"
        Me.ItemContainer12.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnSimStat1, Me.btnSimSignal1})
        '
        '
        '
        Me.ItemContainer12.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnSimStat1
        '
        Me.btnSimStat1.HoverImage = CType(resources.GetObject("btnSimStat1.HoverImage"), System.Drawing.Image)
        Me.btnSimStat1.Image = CType(resources.GetObject("btnSimStat1.Image"), System.Drawing.Image)
        Me.btnSimStat1.Name = "btnSimStat1"
        Me.btnSimStat1.SubItemsExpandWidth = 14
        Me.btnSimStat1.Text = "ButtonItem3"
        '
        'btnSimSignal1
        '
        Me.btnSimSignal1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.btnSimSignal1.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources._0x25
        Me.btnSimSignal1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSimSignal1.Name = "btnSimSignal1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Controls.Add(Me.cboBaudRate1)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cboPort1)
        Me.GroupBox1.Controls.Add(Me.cboStopBits1)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.cboDataBits1)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.cboParity1)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 222)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(78, 152)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(107, 53)
        Me.btnConnect.TabIndex = 33
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'cboBaudRate1
        '
        Me.cboBaudRate1.FormattingEnabled = True
        Me.cboBaudRate1.Items.AddRange(New Object() {"110", "300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "460800", "921600"})
        Me.cboBaudRate1.Location = New System.Drawing.Point(78, 46)
        Me.cboBaudRate1.Name = "cboBaudRate1"
        Me.cboBaudRate1.Size = New System.Drawing.Size(107, 21)
        Me.cboBaudRate1.TabIndex = 32
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(14, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 13)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Com Port"
        '
        'cboPort1
        '
        Me.cboPort1.FormattingEnabled = True
        Me.cboPort1.Location = New System.Drawing.Point(78, 19)
        Me.cboPort1.Name = "cboPort1"
        Me.cboPort1.Size = New System.Drawing.Size(107, 21)
        Me.cboPort1.TabIndex = 23
        '
        'cboStopBits1
        '
        Me.cboStopBits1.FormattingEnabled = True
        Me.cboStopBits1.Items.AddRange(New Object() {"1", "2"})
        Me.cboStopBits1.Location = New System.Drawing.Point(78, 125)
        Me.cboStopBits1.Name = "cboStopBits1"
        Me.cboStopBits1.Size = New System.Drawing.Size(107, 21)
        Me.cboStopBits1.TabIndex = 31
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(14, 128)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 13)
        Me.Label21.TabIndex = 30
        Me.Label21.Text = "Stop Bits"
        '
        'cboDataBits1
        '
        Me.cboDataBits1.FormattingEnabled = True
        Me.cboDataBits1.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.cboDataBits1.Location = New System.Drawing.Point(78, 100)
        Me.cboDataBits1.Name = "cboDataBits1"
        Me.cboDataBits1.Size = New System.Drawing.Size(107, 21)
        Me.cboDataBits1.TabIndex = 29
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(14, 103)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 13)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "Data Bits"
        '
        'cboParity1
        '
        Me.cboParity1.FormattingEnabled = True
        Me.cboParity1.Items.AddRange(New Object() {"Even", "Odd", "None", "Mark"})
        Me.cboParity1.Location = New System.Drawing.Point(78, 73)
        Me.cboParity1.Name = "cboParity1"
        Me.cboParity1.Size = New System.Drawing.Size(107, 21)
        Me.cboParity1.TabIndex = 27
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(14, 76)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(33, 13)
        Me.Label23.TabIndex = 26
        Me.Label23.Text = "Parity"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(14, 49)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 13)
        Me.Label25.TabIndex = 25
        Me.Label25.Text = "Baud Rate"
        '
        'spSMSConfig
        '
        Me.spSMSConfig.AttachedControl = Me.SuperTabControlPanel5
        Me.spSMSConfig.GlobalItem = False
        Me.spSMSConfig.Name = "spSMSConfig"
        Me.spSMSConfig.Text = "SMS Configuration"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.gpDeviceSettings)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(678, 429)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.spSystemSettings
        '
        'gpDeviceSettings
        '
        Me.gpDeviceSettings.BackColor = System.Drawing.Color.Transparent
        Me.gpDeviceSettings.Controls.Add(Me.btnDevCancel)
        Me.gpDeviceSettings.Controls.Add(Me.btnDevEdit)
        Me.gpDeviceSettings.Controls.Add(Me.txtDevice)
        Me.gpDeviceSettings.Controls.Add(Me.LabelX10)
        Me.gpDeviceSettings.Controls.Add(Me.cboDevice)
        Me.gpDeviceSettings.Location = New System.Drawing.Point(13, 10)
        Me.gpDeviceSettings.Name = "gpDeviceSettings"
        Me.gpDeviceSettings.Size = New System.Drawing.Size(534, 57)
        Me.gpDeviceSettings.TabIndex = 152
        Me.gpDeviceSettings.TabStop = False
        Me.gpDeviceSettings.Text = "Device Settings"
        '
        'btnDevCancel
        '
        Me.btnDevCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDevCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDevCancel.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources.cancel
        Me.btnDevCancel.Location = New System.Drawing.Point(340, 23)
        Me.btnDevCancel.Name = "btnDevCancel"
        Me.btnDevCancel.Size = New System.Drawing.Size(23, 20)
        Me.btnDevCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDevCancel.TabIndex = 165
        Me.btnDevCancel.TabStop = False
        Me.btnDevCancel.Tooltip = "Cancel"
        Me.btnDevCancel.Visible = False
        '
        'btnDevEdit
        '
        Me.btnDevEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDevEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDevEdit.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources.edit
        Me.btnDevEdit.Location = New System.Drawing.Point(311, 23)
        Me.btnDevEdit.Name = "btnDevEdit"
        Me.btnDevEdit.Size = New System.Drawing.Size(23, 20)
        Me.btnDevEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDevEdit.TabIndex = 164
        Me.btnDevEdit.TabStop = False
        Me.btnDevEdit.Tooltip = "Edit Registration Device..."
        '
        'txtDevice
        '
        Me.txtDevice.BackColor = System.Drawing.Color.Azure
        '
        '
        '
        Me.txtDevice.Border.Class = "TextBoxBorder"
        Me.txtDevice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDevice.ForeColor = System.Drawing.Color.Black
        Me.txtDevice.Location = New System.Drawing.Point(127, 23)
        Me.txtDevice.Name = "txtDevice"
        Me.txtDevice.ReadOnly = True
        Me.txtDevice.Size = New System.Drawing.Size(178, 20)
        Me.txtDevice.TabIndex = 162
        Me.txtDevice.TabStop = False
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(6, 23)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(115, 20)
        Me.LabelX10.TabIndex = 159
        Me.LabelX10.Text = "Registration Device"
        Me.LabelX10.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cboDevice
        '
        Me.cboDevice.DisabledBackColor = System.Drawing.Color.White
        Me.cboDevice.DisplayMember = "Text"
        Me.cboDevice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDevice.FocusHighlightEnabled = True
        Me.cboDevice.FormattingEnabled = True
        Me.cboDevice.ItemHeight = 16
        Me.cboDevice.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6, Me.ComboItem8})
        Me.cboDevice.Location = New System.Drawing.Point(369, 23)
        Me.cboDevice.Name = "cboDevice"
        Me.cboDevice.Size = New System.Drawing.Size(148, 22)
        Me.cboDevice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboDevice.TabIndex = 1
        Me.cboDevice.Visible = False
        Me.cboDevice.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.cboDevice.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Supervisor"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "Operator"
        '
        'spSystemSettings
        '
        Me.spSystemSettings.AttachedControl = Me.SuperTabControlPanel2
        Me.spSystemSettings.GlobalItem = False
        Me.spSystemSettings.Name = "spSystemSettings"
        Me.spSystemSettings.Text = "System Settings"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.gp3)
        Me.SuperTabControlPanel1.Controls.Add(Me.gp2)
        Me.SuperTabControlPanel1.Controls.Add(Me.gp1)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(678, 454)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.spDatabase
        '
        'gp3
        '
        Me.gp3.BackColor = System.Drawing.Color.Transparent
        Me.gp3.Controls.Add(Me.cpDb)
        Me.gp3.Controls.Add(Me.txtDBpw)
        Me.gp3.Controls.Add(Me.lblPassword)
        Me.gp3.Controls.Add(Me.txtDBuser)
        Me.gp3.Controls.Add(Me.LabelX7)
        Me.gp3.Controls.Add(Me.btnDBtest)
        Me.gp3.Controls.Add(Me.txtDBname)
        Me.gp3.Controls.Add(Me.LabelX5)
        Me.gp3.Controls.Add(Me.txtDBsource)
        Me.gp3.Controls.Add(Me.LabelX6)
        Me.gp3.Enabled = False
        Me.gp3.Location = New System.Drawing.Point(385, 8)
        Me.gp3.Name = "gp3"
        Me.gp3.Size = New System.Drawing.Size(275, 208)
        Me.gp3.TabIndex = 2
        Me.gp3.TabStop = False
        Me.gp3.Text = "Database Connection Settings"
        '
        'cpDb
        '
        Me.cpDb.AnimationSpeed = 50
        Me.cpDb.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.cpDb.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cpDb.Location = New System.Drawing.Point(38, 140)
        Me.cpDb.Name = "cpDb"
        Me.cpDb.PieBorderLight = System.Drawing.Color.Black
        Me.cpDb.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut
        Me.cpDb.ProgressColor = System.Drawing.Color.Tomato
        Me.cpDb.Size = New System.Drawing.Size(36, 46)
        Me.cpDb.SpokeBorderDark = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cpDb.SpokeBorderLight = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cpDb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cpDb.TabIndex = 129
        Me.cpDb.Value = 100
        Me.cpDb.Visible = False
        '
        'txtDBpw
        '
        Me.txtDBpw.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        '
        '
        '
        Me.txtDBpw.Border.Class = "TextBoxBorder"
        Me.txtDBpw.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDBpw.FocusHighlightColor = System.Drawing.Color.Khaki
        Me.txtDBpw.FocusHighlightEnabled = True
        Me.txtDBpw.ForeColor = System.Drawing.Color.Black
        Me.txtDBpw.Location = New System.Drawing.Point(84, 100)
        Me.txtDBpw.Name = "txtDBpw"
        Me.txtDBpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDBpw.Size = New System.Drawing.Size(173, 20)
        Me.txtDBpw.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPassword.Location = New System.Drawing.Point(6, 97)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(72, 23)
        Me.lblPassword.TabIndex = 15
        Me.lblPassword.Text = "Password"
        Me.lblPassword.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtDBuser
        '
        Me.txtDBuser.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        '
        '
        '
        Me.txtDBuser.Border.Class = "TextBoxBorder"
        Me.txtDBuser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDBuser.FocusHighlightColor = System.Drawing.Color.Khaki
        Me.txtDBuser.FocusHighlightEnabled = True
        Me.txtDBuser.ForeColor = System.Drawing.Color.Black
        Me.txtDBuser.Location = New System.Drawing.Point(84, 74)
        Me.txtDBuser.Name = "txtDBuser"
        Me.txtDBuser.Size = New System.Drawing.Size(173, 20)
        Me.txtDBuser.TabIndex = 2
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(6, 71)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(72, 23)
        Me.LabelX7.TabIndex = 13
        Me.LabelX7.Text = "User"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'btnDBtest
        '
        Me.btnDBtest.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDBtest.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDBtest.Image = CType(resources.GetObject("btnDBtest.Image"), System.Drawing.Image)
        Me.btnDBtest.Location = New System.Drawing.Point(84, 140)
        Me.btnDBtest.Name = "btnDBtest"
        Me.btnDBtest.Size = New System.Drawing.Size(173, 46)
        Me.btnDBtest.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDBtest.TabIndex = 4
        Me.btnDBtest.Text = "&Test and Update"
        '
        'txtDBname
        '
        Me.txtDBname.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        '
        '
        '
        Me.txtDBname.Border.Class = "TextBoxBorder"
        Me.txtDBname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDBname.FocusHighlightColor = System.Drawing.Color.Khaki
        Me.txtDBname.FocusHighlightEnabled = True
        Me.txtDBname.ForeColor = System.Drawing.Color.Black
        Me.txtDBname.Location = New System.Drawing.Point(84, 48)
        Me.txtDBname.Name = "txtDBname"
        Me.txtDBname.Size = New System.Drawing.Size(173, 20)
        Me.txtDBname.TabIndex = 1
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(6, 45)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(72, 23)
        Me.LabelX5.TabIndex = 10
        Me.LabelX5.Text = "DB Name"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtDBsource
        '
        Me.txtDBsource.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        '
        '
        '
        Me.txtDBsource.Border.Class = "TextBoxBorder"
        Me.txtDBsource.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDBsource.FocusHighlightColor = System.Drawing.Color.Khaki
        Me.txtDBsource.FocusHighlightEnabled = True
        Me.txtDBsource.ForeColor = System.Drawing.Color.Black
        Me.txtDBsource.Location = New System.Drawing.Point(84, 22)
        Me.txtDBsource.Name = "txtDBsource"
        Me.txtDBsource.Size = New System.Drawing.Size(173, 20)
        Me.txtDBsource.TabIndex = 0
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(6, 19)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(72, 23)
        Me.LabelX6.TabIndex = 8
        Me.LabelX6.Text = "DB Source"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'gp2
        '
        Me.gp2.BackColor = System.Drawing.Color.Transparent
        Me.gp2.Controls.Add(Me.btnOpen)
        Me.gp2.Controls.Add(Me.btnRestore)
        Me.gp2.Controls.Add(Me.txtRestoreFileName)
        Me.gp2.Controls.Add(Me.LabelX3)
        Me.gp2.Controls.Add(Me.txtRestoreLoc)
        Me.gp2.Controls.Add(Me.LabelX4)
        Me.gp2.Location = New System.Drawing.Point(9, 115)
        Me.gp2.Name = "gp2"
        Me.gp2.Size = New System.Drawing.Size(370, 101)
        Me.gp2.TabIndex = 1
        Me.gp2.TabStop = False
        Me.gp2.Text = "Restore Database"
        '
        'btnOpen
        '
        Me.btnOpen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOpen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOpen.Location = New System.Drawing.Point(331, 22)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(21, 20)
        Me.btnOpen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOpen.TabIndex = 14
        Me.btnOpen.Text = "..."
        Me.btnOpen.Tooltip = "Select Database Location..."
        '
        'btnRestore
        '
        Me.btnRestore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRestore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRestore.Image = CType(resources.GetObject("btnRestore.Image"), System.Drawing.Image)
        Me.btnRestore.Location = New System.Drawing.Point(103, 74)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(107, 20)
        Me.btnRestore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRestore.TabIndex = 12
        Me.btnRestore.Text = "Restore"
        '
        'txtRestoreFileName
        '
        Me.txtRestoreFileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        '
        '
        '
        Me.txtRestoreFileName.Border.Class = "TextBoxBorder"
        Me.txtRestoreFileName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRestoreFileName.FocusHighlightColor = System.Drawing.Color.Khaki
        Me.txtRestoreFileName.FocusHighlightEnabled = True
        Me.txtRestoreFileName.ForeColor = System.Drawing.Color.Black
        Me.txtRestoreFileName.Location = New System.Drawing.Point(103, 48)
        Me.txtRestoreFileName.MaxLength = 11
        Me.txtRestoreFileName.Name = "txtRestoreFileName"
        Me.txtRestoreFileName.ReadOnly = True
        Me.txtRestoreFileName.Size = New System.Drawing.Size(249, 20)
        Me.txtRestoreFileName.TabIndex = 11
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(6, 45)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(91, 23)
        Me.LabelX3.TabIndex = 10
        Me.LabelX3.Text = "Filename"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtRestoreLoc
        '
        Me.txtRestoreLoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        '
        '
        '
        Me.txtRestoreLoc.Border.Class = "TextBoxBorder"
        Me.txtRestoreLoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRestoreLoc.FocusHighlightColor = System.Drawing.Color.Khaki
        Me.txtRestoreLoc.FocusHighlightEnabled = True
        Me.txtRestoreLoc.ForeColor = System.Drawing.Color.Black
        Me.txtRestoreLoc.Location = New System.Drawing.Point(103, 22)
        Me.txtRestoreLoc.MaxLength = 11
        Me.txtRestoreLoc.Name = "txtRestoreLoc"
        Me.txtRestoreLoc.ReadOnly = True
        Me.txtRestoreLoc.Size = New System.Drawing.Size(222, 20)
        Me.txtRestoreLoc.TabIndex = 9
        Me.txtRestoreLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(6, 19)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(91, 23)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "File Location"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'gp1
        '
        Me.gp1.BackColor = System.Drawing.Color.Transparent
        Me.gp1.Controls.Add(Me.cbBackupOnExit)
        Me.gp1.Controls.Add(Me.btnBrowse)
        Me.gp1.Controls.Add(Me.btnBackup)
        Me.gp1.Controls.Add(Me.txtBackupName)
        Me.gp1.Controls.Add(Me.LabelX2)
        Me.gp1.Controls.Add(Me.txtBackupLocation)
        Me.gp1.Controls.Add(Me.LabelX1)
        Me.gp1.Location = New System.Drawing.Point(9, 8)
        Me.gp1.Name = "gp1"
        Me.gp1.Size = New System.Drawing.Size(370, 101)
        Me.gp1.TabIndex = 0
        Me.gp1.TabStop = False
        Me.gp1.Text = "Backup Database"
        '
        'cbBackupOnExit
        '
        Me.cbBackupOnExit.AutoSize = True
        Me.cbBackupOnExit.Location = New System.Drawing.Point(254, 76)
        Me.cbBackupOnExit.Name = "cbBackupOnExit"
        Me.cbBackupOnExit.Size = New System.Drawing.Size(98, 17)
        Me.cbBackupOnExit.TabIndex = 16
        Me.cbBackupOnExit.Text = "Backup on Exit"
        Me.cbBackupOnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbBackupOnExit.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBrowse.Location = New System.Drawing.Point(331, 22)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(21, 20)
        Me.btnBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBrowse.TabIndex = 13
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.Tooltip = "Set Backup Location..."
        '
        'btnBackup
        '
        Me.btnBackup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBackup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), System.Drawing.Image)
        Me.btnBackup.Location = New System.Drawing.Point(103, 74)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(107, 20)
        Me.btnBackup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBackup.TabIndex = 12
        Me.btnBackup.Text = "Backup"
        '
        'txtBackupName
        '
        Me.txtBackupName.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        '
        '
        '
        Me.txtBackupName.Border.Class = "TextBoxBorder"
        Me.txtBackupName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBackupName.FocusHighlightColor = System.Drawing.Color.Khaki
        Me.txtBackupName.FocusHighlightEnabled = True
        Me.txtBackupName.ForeColor = System.Drawing.Color.Black
        Me.txtBackupName.Location = New System.Drawing.Point(103, 48)
        Me.txtBackupName.MaxLength = 11
        Me.txtBackupName.Name = "txtBackupName"
        Me.txtBackupName.ReadOnly = True
        Me.txtBackupName.Size = New System.Drawing.Size(249, 20)
        Me.txtBackupName.TabIndex = 11
        Me.txtBackupName.Text = "backup.sql"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(6, 45)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(91, 23)
        Me.LabelX2.TabIndex = 10
        Me.LabelX2.Text = "Filename"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtBackupLocation
        '
        Me.txtBackupLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        '
        '
        '
        Me.txtBackupLocation.Border.Class = "TextBoxBorder"
        Me.txtBackupLocation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBackupLocation.FocusHighlightColor = System.Drawing.Color.Khaki
        Me.txtBackupLocation.FocusHighlightEnabled = True
        Me.txtBackupLocation.ForeColor = System.Drawing.Color.Black
        Me.txtBackupLocation.Location = New System.Drawing.Point(103, 22)
        Me.txtBackupLocation.Name = "txtBackupLocation"
        Me.txtBackupLocation.Size = New System.Drawing.Size(222, 20)
        Me.txtBackupLocation.TabIndex = 9
        Me.txtBackupLocation.Text = "C:\"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(6, 19)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(91, 23)
        Me.LabelX1.TabIndex = 8
        Me.LabelX1.Text = "Backup Location"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'spDatabase
        '
        Me.spDatabase.AttachedControl = Me.SuperTabControlPanel1
        Me.spDatabase.GlobalItem = False
        Me.spDatabase.Name = "spDatabase"
        Me.spDatabase.Text = "Database Settings"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me.gpActivate)
        Me.SuperTabControlPanel3.Controls.Add(Me.gpActivationStatus)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(678, 454)
        Me.SuperTabControlPanel3.TabIndex = 0
        Me.SuperTabControlPanel3.TabItem = Me.spActivation
        '
        'gpActivate
        '
        Me.gpActivate.BackColor = System.Drawing.Color.Transparent
        Me.gpActivate.Controls.Add(Me.cp2)
        Me.gpActivate.Controls.Add(Me.btnActivate)
        Me.gpActivate.Controls.Add(Me.txtCode)
        Me.gpActivate.Controls.Add(Me.LabelX15)
        Me.gpActivate.Controls.Add(Me.txtKey)
        Me.gpActivate.Controls.Add(Me.LabelX16)
        Me.gpActivate.Location = New System.Drawing.Point(8, 73)
        Me.gpActivate.Name = "gpActivate"
        Me.gpActivate.Size = New System.Drawing.Size(657, 133)
        Me.gpActivate.TabIndex = 7
        Me.gpActivate.TabStop = False
        Me.gpActivate.Text = "Please Enter Product Activation Information"
        '
        'cp2
        '
        Me.cp2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cp2.AnimationSpeed = 50
        Me.cp2.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.cp2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp2.BackgroundStyle.BorderBottomWidth = 1
        Me.cp2.BackgroundStyle.BorderColor = System.Drawing.Color.Black
        Me.cp2.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp2.BackgroundStyle.BorderLeftWidth = 1
        Me.cp2.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp2.BackgroundStyle.BorderRightWidth = 1
        Me.cp2.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp2.BackgroundStyle.BorderTopWidth = 1
        Me.cp2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cp2.Location = New System.Drawing.Point(219, 30)
        Me.cp2.Name = "cp2"
        Me.cp2.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut
        Me.cp2.ProgressColor = System.Drawing.Color.Chartreuse
        Me.cp2.Size = New System.Drawing.Size(39, 19)
        Me.cp2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.cp2.TabIndex = 131
        Me.cp2.Visible = False
        '
        'btnActivate
        '
        Me.btnActivate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnActivate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnActivate.Image = CType(resources.GetObject("btnActivate.Image"), System.Drawing.Image)
        Me.btnActivate.Location = New System.Drawing.Point(457, 95)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(182, 29)
        Me.btnActivate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnActivate.TabIndex = 8
        Me.btnActivate.Text = "Activate"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.txtCode.Border.Class = "TextBoxBorder"
        Me.txtCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.Yellow
        Me.txtCode.Location = New System.Drawing.Point(103, 25)
        Me.txtCode.MaxLength = 0
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(536, 29)
        Me.txtCode.TabIndex = 21
        Me.txtCode.Text = "Generating Activation Code . . ."
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Location = New System.Drawing.Point(6, 25)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(91, 29)
        Me.LabelX15.TabIndex = 22
        Me.LabelX15.Text = "Activation Code"
        Me.LabelX15.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtKey
        '
        Me.txtKey.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtKey.Border.Class = "TextBoxBorder"
        Me.txtKey.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKey.FocusHighlightEnabled = True
        Me.txtKey.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKey.ForeColor = System.Drawing.Color.Black
        Me.txtKey.Location = New System.Drawing.Point(103, 60)
        Me.txtKey.MaxLength = 0
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(536, 29)
        Me.txtKey.TabIndex = 19
        Me.txtKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX16
        '
        Me.LabelX16.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Location = New System.Drawing.Point(6, 60)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(91, 29)
        Me.LabelX16.TabIndex = 20
        Me.LabelX16.Text = "Activation Key"
        Me.LabelX16.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'gpActivationStatus
        '
        Me.gpActivationStatus.BackColor = System.Drawing.Color.Transparent
        Me.gpActivationStatus.Controls.Add(Me.lblActivationStatus)
        Me.gpActivationStatus.Location = New System.Drawing.Point(8, 8)
        Me.gpActivationStatus.Name = "gpActivationStatus"
        Me.gpActivationStatus.Size = New System.Drawing.Size(657, 59)
        Me.gpActivationStatus.TabIndex = 6
        Me.gpActivationStatus.TabStop = False
        Me.gpActivationStatus.Text = "Activation Status"
        '
        'lblActivationStatus
        '
        Me.lblActivationStatus.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblActivationStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblActivationStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblActivationStatus.ForeColor = System.Drawing.Color.Crimson
        Me.lblActivationStatus.Location = New System.Drawing.Point(16, 13)
        Me.lblActivationStatus.Name = "lblActivationStatus"
        Me.lblActivationStatus.Size = New System.Drawing.Size(623, 40)
        Me.lblActivationStatus.TabIndex = 14
        Me.lblActivationStatus.Text = "TRIAL VERSION"
        Me.lblActivationStatus.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'spActivation
        '
        Me.spActivation.AttachedControl = Me.SuperTabControlPanel3
        Me.spActivation.GlobalItem = False
        Me.spActivation.Name = "spActivation"
        Me.spActivation.Text = "Product Activation"
        '
        'SuperTabControlPanel4
        '
        Me.SuperTabControlPanel4.Controls.Add(Me.gpFingerprint)
        Me.SuperTabControlPanel4.Controls.Add(Me.gpInfo)
        Me.SuperTabControlPanel4.Controls.Add(Me.gpList)
        Me.SuperTabControlPanel4.Controls.Add(Me.btnSave)
        Me.SuperTabControlPanel4.Controls.Add(Me.btnCancel)
        Me.SuperTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel4.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel4.Name = "SuperTabControlPanel4"
        Me.SuperTabControlPanel4.Size = New System.Drawing.Size(678, 454)
        Me.SuperTabControlPanel4.TabIndex = 0
        Me.SuperTabControlPanel4.TabItem = Me.spUser
        '
        'gpFingerprint
        '
        Me.gpFingerprint.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpFingerprint.BackColor = System.Drawing.Color.Transparent
        Me.gpFingerprint.Controls.Add(Me.txtEmpNo)
        Me.gpFingerprint.Controls.Add(Me.LabelX14)
        Me.gpFingerprint.Controls.Add(Me.btnPwCancel)
        Me.gpFingerprint.Controls.Add(Me.imgPwError)
        Me.gpFingerprint.Controls.Add(Me.imgPw)
        Me.gpFingerprint.Controls.Add(Me.LabelX13)
        Me.gpFingerprint.Controls.Add(Me.btnPwEdit)
        Me.gpFingerprint.Controls.Add(Me.txtPw1)
        Me.gpFingerprint.Controls.Add(Me.lblPw2)
        Me.gpFingerprint.Controls.Add(Me.txtPw2)
        Me.gpFingerprint.Controls.Add(Me.btnClearFp)
        Me.gpFingerprint.Controls.Add(Me.LabelX9)
        Me.gpFingerprint.Controls.Add(Me.LabelX12)
        Me.gpFingerprint.Controls.Add(Me.imgFpError1)
        Me.gpFingerprint.Controls.Add(Me.imgFpError0)
        Me.gpFingerprint.Controls.Add(Me.imgFp0)
        Me.gpFingerprint.Controls.Add(Me.imgFp1)
        Me.gpFingerprint.Controls.Add(Me.btnFp0)
        Me.gpFingerprint.Controls.Add(Me.btnFp1)
        Me.gpFingerprint.Location = New System.Drawing.Point(254, 235)
        Me.gpFingerprint.Name = "gpFingerprint"
        Me.gpFingerprint.Size = New System.Drawing.Size(410, 142)
        Me.gpFingerprint.TabIndex = 156
        Me.gpFingerprint.TabStop = False
        Me.gpFingerprint.Text = "Device Access Information"
        '
        'txtEmpNo
        '
        Me.txtEmpNo.BackColor = System.Drawing.Color.Azure
        '
        '
        '
        Me.txtEmpNo.Border.Class = "TextBoxBorder"
        Me.txtEmpNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEmpNo.ForeColor = System.Drawing.Color.Black
        Me.txtEmpNo.Location = New System.Drawing.Point(306, 30)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.ReadOnly = True
        Me.txtEmpNo.Size = New System.Drawing.Size(87, 20)
        Me.txtEmpNo.TabIndex = 155
        Me.txtEmpNo.TabStop = False
        Me.txtEmpNo.Text = "EmpNo"
        Me.txtEmpNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.Location = New System.Drawing.Point(306, 10)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(87, 24)
        Me.LabelX14.TabIndex = 196
        Me.LabelX14.Text = "User No."
        '
        'btnPwCancel
        '
        Me.btnPwCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPwCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPwCancel.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources.cancel
        Me.btnPwCancel.Location = New System.Drawing.Point(273, 87)
        Me.btnPwCancel.Name = "btnPwCancel"
        Me.btnPwCancel.Size = New System.Drawing.Size(23, 20)
        Me.btnPwCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPwCancel.TabIndex = 191
        Me.btnPwCancel.Tooltip = "Cancel"
        Me.btnPwCancel.Visible = False
        '
        'imgPwError
        '
        '
        '
        '
        Me.imgPwError.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.imgPwError.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.imgPwError.Image = CType(resources.GetObject("imgPwError.Image"), System.Drawing.Image)
        Me.imgPwError.Location = New System.Drawing.Point(273, 113)
        Me.imgPwError.Name = "imgPwError"
        Me.imgPwError.Size = New System.Drawing.Size(23, 20)
        Me.imgPwError.TabIndex = 195
        Me.imgPwError.Visible = False
        '
        'imgPw
        '
        Me.imgPw.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.imgPw.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.imgPw.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.imgPw.Image = CType(resources.GetObject("imgPw.Image"), System.Drawing.Image)
        Me.imgPw.Location = New System.Drawing.Point(247, 113)
        Me.imgPw.Name = "imgPw"
        Me.imgPw.Size = New System.Drawing.Size(23, 20)
        Me.imgPw.TabIndex = 194
        Me.imgPw.Visible = False
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Location = New System.Drawing.Point(5, 87)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(117, 20)
        Me.LabelX13.TabIndex = 192
        Me.LabelX13.Text = "Password"
        Me.LabelX13.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'btnPwEdit
        '
        Me.btnPwEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPwEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPwEdit.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources.edit
        Me.btnPwEdit.Location = New System.Drawing.Point(247, 87)
        Me.btnPwEdit.Name = "btnPwEdit"
        Me.btnPwEdit.Size = New System.Drawing.Size(23, 20)
        Me.btnPwEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPwEdit.TabIndex = 190
        Me.btnPwEdit.Tooltip = "Edit User Device Password..."
        '
        'txtPw1
        '
        '
        '
        '
        Me.txtPw1.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtPw1.Border.BorderBottomWidth = 1
        Me.txtPw1.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.txtPw1.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtPw1.Border.BorderLeftWidth = 1
        Me.txtPw1.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtPw1.Border.BorderRightWidth = 1
        Me.txtPw1.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtPw1.Border.BorderTopWidth = 1
        Me.txtPw1.Border.Class = "TextBoxBorder"
        Me.txtPw1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPw1.Location = New System.Drawing.Point(128, 87)
        Me.txtPw1.MaxLength = 4
        Me.txtPw1.Name = "txtPw1"
        Me.txtPw1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPw1.Size = New System.Drawing.Size(113, 20)
        Me.txtPw1.TabIndex = 188
        '
        'lblPw2
        '
        Me.lblPw2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblPw2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPw2.Location = New System.Drawing.Point(5, 113)
        Me.lblPw2.Name = "lblPw2"
        Me.lblPw2.Size = New System.Drawing.Size(117, 20)
        Me.lblPw2.TabIndex = 193
        Me.lblPw2.Text = "Re-enter Password"
        Me.lblPw2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtPw2
        '
        '
        '
        '
        Me.txtPw2.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtPw2.Border.BorderBottomWidth = 1
        Me.txtPw2.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.txtPw2.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtPw2.Border.BorderLeftWidth = 1
        Me.txtPw2.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtPw2.Border.BorderRightWidth = 1
        Me.txtPw2.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtPw2.Border.BorderTopWidth = 1
        Me.txtPw2.Border.Class = "TextBoxBorder"
        Me.txtPw2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPw2.FocusHighlightEnabled = True
        Me.txtPw2.Location = New System.Drawing.Point(128, 113)
        Me.txtPw2.MaxLength = 4
        Me.txtPw2.Name = "txtPw2"
        Me.txtPw2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPw2.Size = New System.Drawing.Size(113, 20)
        Me.txtPw2.TabIndex = 189
        '
        'btnClearFp
        '
        Me.btnClearFp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClearFp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClearFp.Location = New System.Drawing.Point(306, 56)
        Me.btnClearFp.Name = "btnClearFp"
        Me.btnClearFp.Size = New System.Drawing.Size(87, 51)
        Me.btnClearFp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClearFp.TabIndex = 185
        Me.btnClearFp.Text = "Clear User Fingerprints"
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(5, 56)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(117, 25)
        Me.LabelX9.TabIndex = 181
        Me.LabelX9.Text = "Secondary Fingerprint"
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(5, 25)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(117, 25)
        Me.LabelX12.TabIndex = 180
        Me.LabelX12.Text = "Primary Fingerprint"
        Me.LabelX12.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'imgFpError1
        '
        '
        '
        '
        Me.imgFpError1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.imgFpError1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.imgFpError1.Image = CType(resources.GetObject("imgFpError1.Image"), System.Drawing.Image)
        Me.imgFpError1.Location = New System.Drawing.Point(273, 56)
        Me.imgFpError1.Name = "imgFpError1"
        Me.imgFpError1.Size = New System.Drawing.Size(25, 25)
        Me.imgFpError1.TabIndex = 151
        Me.imgFpError1.Visible = False
        '
        'imgFpError0
        '
        '
        '
        '
        Me.imgFpError0.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.imgFpError0.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.imgFpError0.Image = CType(resources.GetObject("imgFpError0.Image"), System.Drawing.Image)
        Me.imgFpError0.Location = New System.Drawing.Point(273, 25)
        Me.imgFpError0.Name = "imgFpError0"
        Me.imgFpError0.Size = New System.Drawing.Size(25, 25)
        Me.imgFpError0.TabIndex = 150
        Me.imgFpError0.Visible = False
        '
        'imgFp0
        '
        Me.imgFp0.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.imgFp0.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.imgFp0.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.imgFp0.Image = CType(resources.GetObject("imgFp0.Image"), System.Drawing.Image)
        Me.imgFp0.Location = New System.Drawing.Point(247, 25)
        Me.imgFp0.Name = "imgFp0"
        Me.imgFp0.Size = New System.Drawing.Size(25, 25)
        Me.imgFp0.TabIndex = 149
        Me.imgFp0.Visible = False
        '
        'imgFp1
        '
        Me.imgFp1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.imgFp1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.imgFp1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.imgFp1.Image = CType(resources.GetObject("imgFp1.Image"), System.Drawing.Image)
        Me.imgFp1.Location = New System.Drawing.Point(247, 56)
        Me.imgFp1.Name = "imgFp1"
        Me.imgFp1.Size = New System.Drawing.Size(25, 25)
        Me.imgFp1.TabIndex = 148
        Me.imgFp1.Visible = False
        '
        'btnFp0
        '
        Me.btnFp0.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFp0.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFp0.Location = New System.Drawing.Point(128, 25)
        Me.btnFp0.Name = "btnFp0"
        Me.btnFp0.Size = New System.Drawing.Size(113, 25)
        Me.btnFp0.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnFp0.TabIndex = 140
        Me.btnFp0.Text = "Register"
        '
        'btnFp1
        '
        Me.btnFp1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFp1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFp1.Location = New System.Drawing.Point(128, 56)
        Me.btnFp1.Name = "btnFp1"
        Me.btnFp1.Size = New System.Drawing.Size(113, 25)
        Me.btnFp1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnFp1.TabIndex = 139
        Me.btnFp1.Text = "Register"
        '
        'gpInfo
        '
        Me.gpInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpInfo.BackColor = System.Drawing.Color.Transparent
        Me.gpInfo.Controls.Add(Me.btnChangePass)
        Me.gpInfo.Controls.Add(Me.txtTitle)
        Me.gpInfo.Controls.Add(Me.txtAccessLevel)
        Me.gpInfo.Controls.Add(Me.LabelX22)
        Me.gpInfo.Controls.Add(Me.cboTitle)
        Me.gpInfo.Controls.Add(Me.LabelX21)
        Me.gpInfo.Controls.Add(Me.cboAccessLevel)
        Me.gpInfo.Controls.Add(Me.txtLname)
        Me.gpInfo.Controls.Add(Me.LabelX20)
        Me.gpInfo.Controls.Add(Me.txtFname)
        Me.gpInfo.Controls.Add(Me.LabelX19)
        Me.gpInfo.Controls.Add(Me.txtPass1)
        Me.gpInfo.Controls.Add(Me.lblPass1)
        Me.gpInfo.Controls.Add(Me.txtPass)
        Me.gpInfo.Controls.Add(Me.lblPass)
        Me.gpInfo.Controls.Add(Me.txtLogName)
        Me.gpInfo.Controls.Add(Me.LabelX11)
        Me.gpInfo.Location = New System.Drawing.Point(254, 10)
        Me.gpInfo.Name = "gpInfo"
        Me.gpInfo.Size = New System.Drawing.Size(410, 219)
        Me.gpInfo.TabIndex = 151
        Me.gpInfo.TabStop = False
        Me.gpInfo.Text = "User Information"
        '
        'btnChangePass
        '
        Me.btnChangePass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnChangePass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnChangePass.Image = CType(resources.GetObject("btnChangePass.Image"), System.Drawing.Image)
        Me.btnChangePass.Location = New System.Drawing.Point(280, 157)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(23, 22)
        Me.btnChangePass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnChangePass.TabIndex = 164
        Me.btnChangePass.TabStop = False
        Me.btnChangePass.Tooltip = "Edit Password"
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtTitle.Border.Class = "TextBoxBorder"
        Me.txtTitle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTitle.FocusHighlightEnabled = True
        Me.txtTitle.ForeColor = System.Drawing.Color.Black
        Me.txtTitle.Location = New System.Drawing.Point(203, 75)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(71, 20)
        Me.txtTitle.TabIndex = 163
        Me.txtTitle.TabStop = False
        '
        'txtAccessLevel
        '
        Me.txtAccessLevel.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtAccessLevel.Border.Class = "TextBoxBorder"
        Me.txtAccessLevel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAccessLevel.ForeColor = System.Drawing.Color.Black
        Me.txtAccessLevel.Location = New System.Drawing.Point(280, 47)
        Me.txtAccessLevel.Name = "txtAccessLevel"
        Me.txtAccessLevel.ReadOnly = True
        Me.txtAccessLevel.Size = New System.Drawing.Size(221, 20)
        Me.txtAccessLevel.TabIndex = 162
        Me.txtAccessLevel.TabStop = False
        '
        'LabelX22
        '
        Me.LabelX22.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX22.Location = New System.Drawing.Point(24, 75)
        Me.LabelX22.Name = "LabelX22"
        Me.LabelX22.Size = New System.Drawing.Size(96, 22)
        Me.LabelX22.TabIndex = 161
        Me.LabelX22.Text = "Title"
        Me.LabelX22.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cboTitle
        '
        Me.cboTitle.DisabledBackColor = System.Drawing.Color.White
        Me.cboTitle.DisplayMember = "Text"
        Me.cboTitle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTitle.FocusHighlightEnabled = True
        Me.cboTitle.FormattingEnabled = True
        Me.cboTitle.ItemHeight = 16
        Me.cboTitle.Items.AddRange(New Object() {Me.ComboItem7, Me.Mr, Me.Ms, Me.Mrs})
        Me.cboTitle.Location = New System.Drawing.Point(126, 75)
        Me.cboTitle.Name = "cboTitle"
        Me.cboTitle.Size = New System.Drawing.Size(71, 22)
        Me.cboTitle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboTitle.TabIndex = 2
        Me.cboTitle.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.cboTitle.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Mr
        '
        Me.Mr.Text = "Mr"
        '
        'Ms
        '
        Me.Ms.Text = "Ms"
        '
        'Mrs
        '
        Me.Mrs.Text = "Mrs"
        '
        'LabelX21
        '
        Me.LabelX21.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX21.Location = New System.Drawing.Point(24, 47)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(96, 22)
        Me.LabelX21.TabIndex = 159
        Me.LabelX21.Text = "Access Level"
        Me.LabelX21.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cboAccessLevel
        '
        Me.cboAccessLevel.DisabledBackColor = System.Drawing.Color.White
        Me.cboAccessLevel.DisplayMember = "Text"
        Me.cboAccessLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAccessLevel.FocusHighlightEnabled = True
        Me.cboAccessLevel.FormattingEnabled = True
        Me.cboAccessLevel.ItemHeight = 16
        Me.cboAccessLevel.Items.AddRange(New Object() {Me.blank, Me.Supervisor, Me.staff})
        Me.cboAccessLevel.Location = New System.Drawing.Point(126, 47)
        Me.cboAccessLevel.Name = "cboAccessLevel"
        Me.cboAccessLevel.Size = New System.Drawing.Size(148, 22)
        Me.cboAccessLevel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboAccessLevel.TabIndex = 1
        Me.cboAccessLevel.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.cboAccessLevel.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Supervisor
        '
        Me.Supervisor.Text = "Supervisor"
        '
        'staff
        '
        Me.staff.Text = "Staff"
        '
        'txtLname
        '
        Me.txtLname.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtLname.Border.Class = "TextBoxBorder"
        Me.txtLname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtLname.FocusHighlightEnabled = True
        Me.txtLname.ForeColor = System.Drawing.Color.Black
        Me.txtLname.Location = New System.Drawing.Point(126, 131)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(221, 20)
        Me.txtLname.TabIndex = 4
        '
        'LabelX20
        '
        Me.LabelX20.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX20.Location = New System.Drawing.Point(24, 129)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(96, 22)
        Me.LabelX20.TabIndex = 156
        Me.LabelX20.Text = "Last Name"
        Me.LabelX20.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtFname
        '
        Me.txtFname.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtFname.Border.Class = "TextBoxBorder"
        Me.txtFname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFname.FocusHighlightEnabled = True
        Me.txtFname.ForeColor = System.Drawing.Color.Black
        Me.txtFname.Location = New System.Drawing.Point(126, 103)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(221, 20)
        Me.txtFname.TabIndex = 3
        '
        'LabelX19
        '
        Me.LabelX19.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.Location = New System.Drawing.Point(24, 101)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(96, 22)
        Me.LabelX19.TabIndex = 154
        Me.LabelX19.Text = "First Name"
        Me.LabelX19.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtPass1
        '
        Me.txtPass1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPass1.Border.Class = "TextBoxBorder"
        Me.txtPass1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPass1.FocusHighlightEnabled = True
        Me.txtPass1.ForeColor = System.Drawing.Color.Black
        Me.txtPass1.Location = New System.Drawing.Point(126, 185)
        Me.txtPass1.Name = "txtPass1"
        Me.txtPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass1.Size = New System.Drawing.Size(148, 20)
        Me.txtPass1.TabIndex = 6
        '
        'lblPass1
        '
        Me.lblPass1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblPass1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPass1.Location = New System.Drawing.Point(24, 183)
        Me.lblPass1.Name = "lblPass1"
        Me.lblPass1.Size = New System.Drawing.Size(96, 22)
        Me.lblPass1.TabIndex = 152
        Me.lblPass1.Text = "Re-enter Password"
        Me.lblPass1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPass.Border.Class = "TextBoxBorder"
        Me.txtPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPass.FocusHighlightEnabled = True
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.Location = New System.Drawing.Point(126, 157)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(148, 20)
        Me.txtPass.TabIndex = 5
        '
        'lblPass
        '
        Me.lblPass.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblPass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPass.Location = New System.Drawing.Point(24, 155)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(96, 22)
        Me.lblPass.TabIndex = 150
        Me.lblPass.Text = "Password"
        Me.lblPass.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtLogName
        '
        Me.txtLogName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtLogName.Border.Class = "TextBoxBorder"
        Me.txtLogName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtLogName.FocusHighlightEnabled = True
        Me.txtLogName.ForeColor = System.Drawing.Color.Black
        Me.txtLogName.Location = New System.Drawing.Point(126, 19)
        Me.txtLogName.Name = "txtLogName"
        Me.txtLogName.Size = New System.Drawing.Size(221, 20)
        Me.txtLogName.TabIndex = 0
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(24, 17)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(96, 22)
        Me.LabelX11.TabIndex = 148
        Me.LabelX11.Text = "Login Name"
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'gpList
        '
        Me.gpList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gpList.BackColor = System.Drawing.Color.Transparent
        Me.gpList.Controls.Add(Me.cp1)
        Me.gpList.Controls.Add(Me.lblNoRecords)
        Me.gpList.Controls.Add(Me.advTree1)
        Me.gpList.Controls.Add(Me.btnRefresh)
        Me.gpList.Controls.Add(Me.btnDelete)
        Me.gpList.Controls.Add(Me.btnEdit)
        Me.gpList.Controls.Add(Me.btnAdd)
        Me.gpList.Location = New System.Drawing.Point(13, 10)
        Me.gpList.Name = "gpList"
        Me.gpList.Size = New System.Drawing.Size(235, 434)
        Me.gpList.TabIndex = 152
        Me.gpList.TabStop = False
        Me.gpList.Text = "User List"
        '
        'cp1
        '
        Me.cp1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cp1.AnimationSpeed = 50
        '
        '
        '
        Me.cp1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderBottomWidth = 1
        Me.cp1.BackgroundStyle.BorderColor = System.Drawing.Color.Black
        Me.cp1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderLeftWidth = 1
        Me.cp1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderRightWidth = 1
        Me.cp1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderTopWidth = 1
        Me.cp1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cp1.Location = New System.Drawing.Point(3, 213)
        Me.cp1.Name = "cp1"
        Me.cp1.Size = New System.Drawing.Size(230, 41)
        Me.cp1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.cp1.TabIndex = 130
        Me.cp1.Visible = False
        '
        'lblNoRecords
        '
        Me.lblNoRecords.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoRecords.BackColor = System.Drawing.Color.LightCoral
        '
        '
        '
        Me.lblNoRecords.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblNoRecords.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNoRecords.Location = New System.Drawing.Point(8, 185)
        Me.lblNoRecords.Name = "lblNoRecords"
        Me.lblNoRecords.Size = New System.Drawing.Size(219, 23)
        Me.lblNoRecords.TabIndex = 45
        Me.lblNoRecords.Text = "No Record(s) Found."
        Me.lblNoRecords.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'advTree1
        '
        Me.advTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.advTree1.AllowDrop = True
        Me.advTree1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.advTree1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.advTree1.BackgroundStyle.Class = "TreeBorderKey"
        Me.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.advTree1.DragDropEnabled = False
        Me.advTree1.DragDropNodeCopyEnabled = False
        Me.advTree1.ExpandButtonSize = New System.Drawing.Size(0, 0)
        Me.advTree1.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Ellipse
        Me.advTree1.ExpandWidth = 0
        Me.advTree1.GridColumnLines = False
        Me.advTree1.Location = New System.Drawing.Point(0, 14)
        Me.advTree1.Name = "advTree1"
        Me.advTree1.NodeStyle = Me.ElementStyle4
        Me.advTree1.PathSeparator = ";"
        Me.advTree1.SelectionBoxStyle = DevComponents.AdvTree.eSelectionStyle.FullRowSelect
        Me.advTree1.Size = New System.Drawing.Size(235, 378)
        Me.advTree1.Styles.Add(Me.ElementStyle2)
        Me.advTree1.Styles.Add(Me.ElementStyle3)
        Me.advTree1.Styles.Add(Me.ElementStyle4)
        Me.advTree1.Styles.Add(Me.ElementStyle1)
        Me.advTree1.TabIndex = 128
        '
        'ElementStyle4
        '
        Me.ElementStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ElementStyle4.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.ElementStyle4.BackColorGradientAngle = 90
        Me.ElementStyle4.BorderBottomWidth = 1
        Me.ElementStyle4.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle4.BorderLeftWidth = 1
        Me.ElementStyle4.BorderRightWidth = 1
        Me.ElementStyle4.BorderTopWidth = 1
        Me.ElementStyle4.CornerDiameter = 4
        Me.ElementStyle4.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle4.Description = "Green"
        Me.ElementStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElementStyle4.Name = "ElementStyle4"
        Me.ElementStyle4.PaddingBottom = 1
        Me.ElementStyle4.PaddingLeft = 1
        Me.ElementStyle4.PaddingRight = 1
        Me.ElementStyle4.PaddingTop = 1
        Me.ElementStyle4.TextColor = System.Drawing.Color.Black
        '
        'ElementStyle2
        '
        Me.ElementStyle2.BackColor = System.Drawing.Color.Yellow
        Me.ElementStyle2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ElementStyle2.BackColorGradientAngle = 90
        Me.ElementStyle2.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle2.BorderBottomWidth = 1
        Me.ElementStyle2.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle2.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle2.BorderLeftWidth = 1
        Me.ElementStyle2.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle2.BorderRightWidth = 1
        Me.ElementStyle2.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle2.BorderTopWidth = 1
        Me.ElementStyle2.CornerDiameter = 4
        Me.ElementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle2.Description = "Lemon"
        Me.ElementStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElementStyle2.Name = "ElementStyle2"
        Me.ElementStyle2.PaddingBottom = 1
        Me.ElementStyle2.PaddingLeft = 1
        Me.ElementStyle2.PaddingRight = 1
        Me.ElementStyle2.PaddingTop = 1
        Me.ElementStyle2.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ElementStyle2.TextColor = System.Drawing.Color.Black
        '
        'ElementStyle3
        '
        Me.ElementStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ElementStyle3.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ElementStyle3.BackColorGradientAngle = 90
        Me.ElementStyle3.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle3.BorderBottomWidth = 1
        Me.ElementStyle3.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle3.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle3.BorderLeftWidth = 1
        Me.ElementStyle3.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle3.BorderRightWidth = 1
        Me.ElementStyle3.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle3.BorderTopWidth = 1
        Me.ElementStyle3.CornerDiameter = 4
        Me.ElementStyle3.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle3.Description = "Yellow"
        Me.ElementStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElementStyle3.Name = "ElementStyle3"
        Me.ElementStyle3.PaddingBottom = 1
        Me.ElementStyle3.PaddingLeft = 1
        Me.ElementStyle3.PaddingRight = 1
        Me.ElementStyle3.PaddingTop = 1
        Me.ElementStyle3.TextColor = System.Drawing.Color.Black
        '
        'ElementStyle1
        '
        Me.ElementStyle1.BackColor = System.Drawing.Color.White
        Me.ElementStyle1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ElementStyle1.BackColorGradientAngle = 90
        Me.ElementStyle1.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle1.BorderBottomWidth = 1
        Me.ElementStyle1.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle1.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle1.BorderLeftWidth = 1
        Me.ElementStyle1.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle1.BorderRightWidth = 1
        Me.ElementStyle1.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle1.BorderTopWidth = 1
        Me.ElementStyle1.CornerDiameter = 4
        Me.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle1.Description = "Gray"
        Me.ElementStyle1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.ElementStyle1.Name = "ElementStyle1"
        Me.ElementStyle1.PaddingBottom = 1
        Me.ElementStyle1.PaddingLeft = 1
        Me.ElementStyle1.PaddingRight = 1
        Me.ElementStyle1.PaddingTop = 1
        Me.ElementStyle1.TextColor = System.Drawing.Color.Black
        '
        'btnRefresh
        '
        Me.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRefresh.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources.refresh
        Me.btnRefresh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.btnRefresh.Location = New System.Drawing.Point(194, 398)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(35, 30)
        Me.btnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRefresh.TabIndex = 127
        Me.btnRefresh.Tooltip = "Refresh"
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(82, 398)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(35, 30)
        Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Tooltip = "Delete . . ."
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(41, 398)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(35, 30)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 14
        Me.btnEdit.Tooltip = "Edit . . ."
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(5, 398)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(30, 30)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Tooltip = "Add New . . ."
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(424, 414)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 30)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 153
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(541, 414)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(123, 30)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 154
        Me.btnCancel.Text = "Ca&ncel"
        '
        'spUser
        '
        Me.spUser.AttachedControl = Me.SuperTabControlPanel4
        Me.spUser.GlobalItem = False
        Me.spUser.Name = "spUser"
        Me.spUser.Text = "User Accounts"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 600
        '
        'bwQuery
        '
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(494, 472)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(196, 29)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        '
        'spDevice
        '
        '
        'frmSysSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 513)
        Me.Controls.Add(Me.SuperTabControl1)
        Me.Controls.Add(Me.btnClose)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSysSettings"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TitleText = "<h5>SYSTEM SETTINGS</h5>"
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.gpDeviceSettings.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.gp3.ResumeLayout(False)
        Me.gp2.ResumeLayout(False)
        Me.gp1.ResumeLayout(False)
        Me.gp1.PerformLayout()
        Me.SuperTabControlPanel3.ResumeLayout(False)
        Me.gpActivate.ResumeLayout(False)
        Me.gpActivationStatus.ResumeLayout(False)
        Me.SuperTabControlPanel4.ResumeLayout(False)
        Me.gpFingerprint.ResumeLayout(False)
        Me.gpInfo.ResumeLayout(False)
        Me.gpList.ResumeLayout(False)
        CType(Me.advTree1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents spDatabase As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents gp1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtBackupLocation As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBackupName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnBackup As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gp2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRestore As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtRestoreFileName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtRestoreLoc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnBrowse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOpen As DevComponents.DotNetBar.ButtonX
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents spSystemSettings As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents gp3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDBtest As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtDBname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDBsource As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDBpw As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblPassword As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDBuser As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbBackupOnExit As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents gpActivationStatus As System.Windows.Forms.GroupBox
    Friend WithEvents lblActivationStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents spActivation As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents gpActivate As System.Windows.Forms.GroupBox
    Friend WithEvents txtCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKey As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnActivate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SuperTabControlPanel4 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents spUser As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents txtEmpNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpList As System.Windows.Forms.GroupBox
    Public WithEvents lblNoRecords As DevComponents.DotNetBar.LabelX
    Public WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Public WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Public WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnChangePass As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtTitle As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAccessLevel As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX22 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboTitle As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents Mr As DevComponents.Editors.ComboItem
    Friend WithEvents Ms As DevComponents.Editors.ComboItem
    Friend WithEvents Mrs As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboAccessLevel As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents blank As DevComponents.Editors.ComboItem
    Friend WithEvents Supervisor As DevComponents.Editors.ComboItem
    Friend WithEvents staff As DevComponents.Editors.ComboItem
    Friend WithEvents txtLname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPass1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblPass1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPass As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblPass As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtLogName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents bwQuery As System.ComponentModel.BackgroundWorker
    Public WithEvents btnRefresh As DevComponents.DotNetBar.ButtonX
    Private WithEvents advTree1 As DevComponents.AdvTree.AdvTree
    Friend WithEvents ElementStyle4 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ElementStyle2 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ElementStyle3 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents cp1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents cp2 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents gpDeviceSettings As System.Windows.Forms.GroupBox
    Friend WithEvents btnDevCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDevEdit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtDevice As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboDevice As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents gpFingerprint As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents imgFpError1 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents imgFpError0 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents imgFp0 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents imgFp1 As DevComponents.DotNetBar.Controls.ReflectionImage
    Public WithEvents btnFp0 As DevComponents.DotNetBar.ButtonX
    Public WithEvents btnFp1 As DevComponents.DotNetBar.ButtonX
    Public WithEvents btnClearFp As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPwCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents imgPwError As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents imgPw As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnPwEdit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtPw1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblPw2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPw2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cpDb As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents SuperTabControlPanel5 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents btnCmd As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCommand As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCpNum As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboDongle As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtReceived1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbSim1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ItemContainer12 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btnSimStat1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnSimSignal1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents cboBaudRate1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboPort1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboStopBits1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cboDataBits1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboParity1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents spSMSConfig As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents spDevice As System.IO.Ports.SerialPort
End Class
