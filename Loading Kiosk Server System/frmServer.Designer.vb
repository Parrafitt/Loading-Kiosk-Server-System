<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServer
    Inherits DevComponents.DotNetBar.OfficeForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServer))
        Me.LabelItem9 = New DevComponents.DotNetBar.LabelItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lvTcpClient = New System.Windows.Forms.ListView()
        Me.colTcpDT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTcpMach = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTcpStat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemContainer10 = New DevComponents.DotNetBar.ItemContainer()
        Me.btnSimStat1 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnSimSignal1 = New DevComponents.DotNetBar.ButtonItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEventLog = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lvTransQueue = New System.Windows.Forms.ListView()
        Me.colQueueNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colQMachine = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colQProduct = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colQConn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblServerStatus = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lvTransComplete = New System.Windows.Forms.ListView()
        Me.transNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.machine = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.product = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.connection = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtTcpLog = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cpServer = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.lblServerStat = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.lblQueueNo = New DevComponents.DotNetBar.LabelX()
        Me.lblMachine = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnStartServer = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtSmsLog = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lvSmsDevice = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.tmrTrans = New System.Windows.Forms.Timer(Me.components)
        Me.bwDevice = New System.ComponentModel.BackgroundWorker()
        Me.imgSignal = New System.Windows.Forms.ImageList(Me.components)
        Me.spDevice = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelItem9
        '
        Me.LabelItem9.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelItem9.ForeColor = System.Drawing.Color.Brown
        Me.LabelItem9.Name = "LabelItem9"
        Me.LabelItem9.Text = "Load Kiosk"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lvTcpClient)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(300, 318)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TCP CONNECTION LOG"
        '
        'lvTcpClient
        '
        Me.lvTcpClient.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTcpDT, Me.colTcpMach, Me.colTcpStat})
        Me.lvTcpClient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvTcpClient.FullRowSelect = True
        Me.lvTcpClient.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvTcpClient.Location = New System.Drawing.Point(2, 13)
        Me.lvTcpClient.Name = "lvTcpClient"
        Me.lvTcpClient.Size = New System.Drawing.Size(296, 303)
        Me.lvTcpClient.TabIndex = 0
        Me.lvTcpClient.UseCompatibleStateImageBehavior = False
        Me.lvTcpClient.View = System.Windows.Forms.View.Details
        '
        'colTcpDT
        '
        Me.colTcpDT.Text = "DATETIME"
        Me.colTcpDT.Width = 110
        '
        'colTcpMach
        '
        Me.colTcpMach.Text = "MACHINE"
        Me.colTcpMach.Width = 100
        '
        'colTcpStat
        '
        Me.colTcpStat.Text = "STATUS"
        Me.colTcpStat.Width = 70
        '
        'ItemContainer10
        '
        '
        '
        '
        Me.ItemContainer10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer10.Name = "ItemContainer10"
        Me.ItemContainer10.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnSimStat1, Me.btnSimSignal1})
        '
        '
        '
        Me.ItemContainer10.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnSimStat1
        '
        Me.btnSimStat1.HoverImage = CType(resources.GetObject("btnSimStat1.HoverImage"), System.Drawing.Image)
        Me.btnSimStat1.Name = "btnSimStat1"
        Me.btnSimStat1.SubItemsExpandWidth = 14
        Me.btnSimStat1.Text = "ButtonItem3"
        '
        'btnSimSignal1
        '
        Me.btnSimSignal1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.btnSimSignal1.Image = CType(resources.GetObject("btnSimSignal1.Image"), System.Drawing.Image)
        Me.btnSimSignal1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSimSignal1.Name = "btnSimSignal1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtEventLog)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(952, 238)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(330, 448)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EVENT LOG"
        '
        'txtEventLog
        '
        Me.txtEventLog.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.txtEventLog.Border.Class = "TextBoxBorder"
        Me.txtEventLog.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEventLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEventLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtEventLog.ForeColor = System.Drawing.Color.Azure
        Me.txtEventLog.Location = New System.Drawing.Point(2, 13)
        Me.txtEventLog.Multiline = True
        Me.txtEventLog.Name = "txtEventLog"
        Me.txtEventLog.ReadOnly = True
        Me.txtEventLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEventLog.Size = New System.Drawing.Size(326, 433)
        Me.txtEventLog.TabIndex = 0
        Me.txtEventLog.Text = "<h1>test</h1>"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.lvTransQueue)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(619, 11)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(329, 318)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TRANSACTIONS ON-QUEUE"
        '
        'lvTransQueue
        '
        Me.lvTransQueue.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colQueueNo, Me.colQMachine, Me.colQProduct, Me.colQConn})
        Me.lvTransQueue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvTransQueue.FullRowSelect = True
        Me.lvTransQueue.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvTransQueue.Location = New System.Drawing.Point(2, 13)
        Me.lvTransQueue.Name = "lvTransQueue"
        Me.lvTransQueue.Size = New System.Drawing.Size(325, 303)
        Me.lvTransQueue.TabIndex = 0
        Me.lvTransQueue.UseCompatibleStateImageBehavior = False
        Me.lvTransQueue.View = System.Windows.Forms.View.Details
        '
        'colQueueNo
        '
        Me.colQueueNo.Text = "QUEUE NO."
        Me.colQueueNo.Width = 70
        '
        'colQMachine
        '
        Me.colQMachine.Text = "MACHINE"
        Me.colQMachine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colQMachine.Width = 80
        '
        'colQProduct
        '
        Me.colQProduct.Text = "PRODUCT"
        Me.colQProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colQProduct.Width = 75
        '
        'colQConn
        '
        Me.colQConn.Text = "CONNECTION"
        Me.colQConn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colQConn.Width = 75
        '
        'lblServerStatus
        '
        Me.lblServerStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblServerStatus.BackColor = System.Drawing.Color.IndianRed
        '
        '
        '
        Me.lblServerStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblServerStatus.Font = New System.Drawing.Font("Arial", 24.0!)
        Me.lblServerStatus.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblServerStatus.Location = New System.Drawing.Point(5, 16)
        Me.lblServerStatus.Name = "lblServerStatus"
        Me.lblServerStatus.Size = New System.Drawing.Size(320, 66)
        Me.lblServerStatus.TabIndex = 12
        Me.lblServerStatus.Text = "STATUS: OFFLINE"
        Me.lblServerStatus.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.lvTransComplete)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.GroupBox5.Location = New System.Drawing.Point(619, 333)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(329, 353)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "TRANSACTIONS COMPLETED"
        '
        'lvTransComplete
        '
        Me.lvTransComplete.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.transNo, Me.machine, Me.product, Me.connection})
        Me.lvTransComplete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvTransComplete.FullRowSelect = True
        Me.lvTransComplete.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvTransComplete.Location = New System.Drawing.Point(2, 13)
        Me.lvTransComplete.Name = "lvTransComplete"
        Me.lvTransComplete.Size = New System.Drawing.Size(325, 338)
        Me.lvTransComplete.TabIndex = 0
        Me.lvTransComplete.UseCompatibleStateImageBehavior = False
        Me.lvTransComplete.View = System.Windows.Forms.View.Details
        '
        'transNo
        '
        Me.transNo.Text = "TRANS NO."
        Me.transNo.Width = 70
        '
        'machine
        '
        Me.machine.Text = "MACHINE"
        Me.machine.Width = 80
        '
        'product
        '
        Me.product.Text = "PRODUCT"
        Me.product.Width = 75
        '
        'connection
        '
        Me.connection.Text = "CONNECTION"
        Me.connection.Width = 75
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.txtTcpLog)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.GroupBox6.Location = New System.Drawing.Point(11, 333)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Size = New System.Drawing.Size(300, 353)
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "TCP CONNECTION ACTIVITY LOG"
        '
        'txtTcpLog
        '
        Me.txtTcpLog.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.txtTcpLog.Border.Class = "TextBoxBorder"
        Me.txtTcpLog.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTcpLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTcpLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTcpLog.ForeColor = System.Drawing.Color.GreenYellow
        Me.txtTcpLog.Location = New System.Drawing.Point(2, 13)
        Me.txtTcpLog.Multiline = True
        Me.txtTcpLog.Name = "txtTcpLog"
        Me.txtTcpLog.ReadOnly = True
        Me.txtTcpLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTcpLog.Size = New System.Drawing.Size(296, 338)
        Me.txtTcpLog.TabIndex = 0
        Me.txtTcpLog.Text = "> testing . . ."
        '
        'cpServer
        '
        Me.cpServer.AnimationSpeed = 50
        Me.cpServer.BackColor = System.Drawing.Color.DimGray
        '
        '
        '
        Me.cpServer.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cpServer.BackgroundStyle.BorderBottomWidth = 2
        Me.cpServer.BackgroundStyle.BorderColor = System.Drawing.Color.Black
        Me.cpServer.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cpServer.BackgroundStyle.BorderLeftWidth = 2
        Me.cpServer.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cpServer.BackgroundStyle.BorderRightWidth = 2
        Me.cpServer.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cpServer.BackgroundStyle.BorderTopWidth = 2
        Me.cpServer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cpServer.Location = New System.Drawing.Point(5, 88)
        Me.cpServer.Name = "cpServer"
        Me.cpServer.ProgressColor = System.Drawing.Color.Orange
        Me.cpServer.ProgressTextColor = System.Drawing.Color.WhiteSmoke
        Me.cpServer.ProgressTextFormat = "{0}"
        Me.cpServer.Size = New System.Drawing.Size(75, 67)
        Me.cpServer.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.cpServer.TabIndex = 139
        Me.cpServer.Value = 100
        '
        'lblServerStat
        '
        Me.lblServerStat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblServerStat.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.lblServerStat.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblServerStat.BackgroundStyle.BorderBottomWidth = 2
        Me.lblServerStat.BackgroundStyle.BorderColor = System.Drawing.Color.DimGray
        Me.lblServerStat.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblServerStat.BackgroundStyle.BorderLeftWidth = 2
        Me.lblServerStat.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblServerStat.BackgroundStyle.BorderRightWidth = 2
        Me.lblServerStat.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblServerStat.BackgroundStyle.BorderTopWidth = 2
        Me.lblServerStat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblServerStat.BackgroundStyle.PaddingLeft = 5
        Me.lblServerStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblServerStat.ForeColor = System.Drawing.Color.FloralWhite
        Me.lblServerStat.Location = New System.Drawing.Point(77, 88)
        Me.lblServerStat.Name = "lblServerStat"
        Me.lblServerStat.Size = New System.Drawing.Size(248, 67)
        Me.lblServerStat.TabIndex = 140
        Me.lblServerStat.Text = "Ready..."
        Me.lblServerStat.WordWrap = True
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LabelX3.Location = New System.Drawing.Point(5, 161)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(66, 23)
        Me.LabelX3.TabIndex = 141
        Me.LabelX3.Text = "QUEUE NO.:"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LabelX4.Location = New System.Drawing.Point(5, 184)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(66, 23)
        Me.LabelX4.TabIndex = 142
        Me.LabelX4.Text = "MACHINE:"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblQueueNo
        '
        Me.lblQueueNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQueueNo.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.lblQueueNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblQueueNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblQueueNo.ForeColor = System.Drawing.Color.Gold
        Me.lblQueueNo.Location = New System.Drawing.Point(77, 161)
        Me.lblQueueNo.Name = "lblQueueNo"
        Me.lblQueueNo.PaddingLeft = 5
        Me.lblQueueNo.Size = New System.Drawing.Size(97, 23)
        Me.lblQueueNo.TabIndex = 143
        Me.lblQueueNo.Text = "-"
        '
        'lblMachine
        '
        Me.lblMachine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMachine.BackColor = System.Drawing.Color.DimGray
        '
        '
        '
        Me.lblMachine.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblMachine.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblMachine.ForeColor = System.Drawing.Color.SeaShell
        Me.lblMachine.Location = New System.Drawing.Point(77, 184)
        Me.lblMachine.Name = "lblMachine"
        Me.lblMachine.PaddingLeft = 5
        Me.lblMachine.Size = New System.Drawing.Size(97, 23)
        Me.lblMachine.TabIndex = 144
        Me.lblMachine.Text = "-"
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.lblServerStatus)
        Me.GroupBox7.Controls.Add(Me.lblMachine)
        Me.GroupBox7.Controls.Add(Me.btnStartServer)
        Me.GroupBox7.Controls.Add(Me.lblQueueNo)
        Me.GroupBox7.Controls.Add(Me.lblServerStat)
        Me.GroupBox7.Controls.Add(Me.LabelX4)
        Me.GroupBox7.Controls.Add(Me.cpServer)
        Me.GroupBox7.Controls.Add(Me.LabelX3)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.GroupBox7.Location = New System.Drawing.Point(952, 11)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Size = New System.Drawing.Size(330, 223)
        Me.GroupBox7.TabIndex = 145
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "SERVER EVENTS"
        '
        'btnStartServer
        '
        Me.btnStartServer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnStartServer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStartServer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnStartServer.Location = New System.Drawing.Point(180, 161)
        Me.btnStartServer.Name = "btnStartServer"
        Me.btnStartServer.Size = New System.Drawing.Size(145, 46)
        Me.btnStartServer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnStartServer.TabIndex = 11
        Me.btnStartServer.Text = "START SERVER"
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox8.Controls.Add(Me.txtSmsLog)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.GroupBox8.Location = New System.Drawing.Point(315, 333)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Size = New System.Drawing.Size(300, 353)
        Me.GroupBox8.TabIndex = 147
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "SMS CONNECTION LOG"
        '
        'txtSmsLog
        '
        Me.txtSmsLog.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.txtSmsLog.Border.Class = "TextBoxBorder"
        Me.txtSmsLog.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSmsLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSmsLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtSmsLog.ForeColor = System.Drawing.Color.Yellow
        Me.txtSmsLog.Location = New System.Drawing.Point(2, 13)
        Me.txtSmsLog.Multiline = True
        Me.txtSmsLog.Name = "txtSmsLog"
        Me.txtSmsLog.ReadOnly = True
        Me.txtSmsLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSmsLog.Size = New System.Drawing.Size(296, 338)
        Me.txtSmsLog.TabIndex = 0
        Me.txtSmsLog.Text = "> testing . . ."
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.lvSmsDevice)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.GroupBox9.Location = New System.Drawing.Point(315, 11)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox9.Size = New System.Drawing.Size(300, 318)
        Me.GroupBox9.TabIndex = 146
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "SMS DONGLES"
        '
        'lvSmsDevice
        '
        Me.lvSmsDevice.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvSmsDevice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvSmsDevice.FullRowSelect = True
        Me.lvSmsDevice.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvSmsDevice.Location = New System.Drawing.Point(2, 13)
        Me.lvSmsDevice.Name = "lvSmsDevice"
        Me.lvSmsDevice.Size = New System.Drawing.Size(296, 303)
        Me.lvSmsDevice.TabIndex = 0
        Me.lvSmsDevice.UseCompatibleStateImageBehavior = False
        Me.lvSmsDevice.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "SIGNAL STRENGTH"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "SIM NO."
        Me.ColumnHeader9.Width = 128
        '
        'ButtonItem8
        '
        Me.ButtonItem8.HoverImage = CType(resources.GetObject("ButtonItem8.HoverImage"), System.Drawing.Image)
        Me.ButtonItem8.Image = CType(resources.GetObject("ButtonItem8.Image"), System.Drawing.Image)
        Me.ButtonItem8.Name = "ButtonItem8"
        Me.ButtonItem8.SubItemsExpandWidth = 14
        Me.ButtonItem8.Text = "ButtonItem3"
        '
        'ButtonItem9
        '
        Me.ButtonItem9.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItem9.Image = CType(resources.GetObject("ButtonItem9.Image"), System.Drawing.Image)
        Me.ButtonItem9.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem9.Name = "ButtonItem9"
        '
        'ButtonItem6
        '
        Me.ButtonItem6.HoverImage = CType(resources.GetObject("ButtonItem6.HoverImage"), System.Drawing.Image)
        Me.ButtonItem6.Image = CType(resources.GetObject("ButtonItem6.Image"), System.Drawing.Image)
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.SubItemsExpandWidth = 14
        Me.ButtonItem6.Text = "ButtonItem3"
        '
        'ButtonItem7
        '
        Me.ButtonItem7.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItem7.Image = CType(resources.GetObject("ButtonItem7.Image"), System.Drawing.Image)
        Me.ButtonItem7.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem7.Name = "ButtonItem7"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.HoverImage = CType(resources.GetObject("ButtonItem4.HoverImage"), System.Drawing.Image)
        Me.ButtonItem4.Image = CType(resources.GetObject("ButtonItem4.Image"), System.Drawing.Image)
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.SubItemsExpandWidth = 14
        Me.ButtonItem4.Text = "ButtonItem3"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItem5.Image = CType(resources.GetObject("ButtonItem5.Image"), System.Drawing.Image)
        Me.ButtonItem5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem5.Name = "ButtonItem5"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.HoverImage = CType(resources.GetObject("ButtonItem2.HoverImage"), System.Drawing.Image)
        Me.ButtonItem2.Image = CType(resources.GetObject("ButtonItem2.Image"), System.Drawing.Image)
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.SubItemsExpandWidth = 14
        Me.ButtonItem2.Text = "ButtonItem3"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItem3.Image = CType(resources.GetObject("ButtonItem3.Image"), System.Drawing.Image)
        Me.ButtonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem3.Name = "ButtonItem3"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.HoverImage = CType(resources.GetObject("ButtonItem1.HoverImage"), System.Drawing.Image)
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.SubItemsExpandWidth = 14
        Me.ButtonItem1.Text = "ButtonItem3"
        '
        'tmrTrans
        '
        Me.tmrTrans.Enabled = True
        Me.tmrTrans.Interval = 1000
        '
        'imgSignal
        '
        Me.imgSignal.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imgSignal.ImageSize = New System.Drawing.Size(16, 16)
        Me.imgSignal.TransparentColor = System.Drawing.Color.Transparent
        '
        'spDevice
        '
        '
        'frmServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1293, 697)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmServer"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TitleText = "<h5>SERVER CENTRAL</h5>"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelItem9 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lvTcpClient As System.Windows.Forms.ListView
    Friend WithEvents colTcpDT As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTcpStat As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTcpMach As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItemContainer10 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btnSimStat1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnSimSignal1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEventLog As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lvTransQueue As System.Windows.Forms.ListView
    Friend WithEvents btnStartServer As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblServerStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lvTransComplete As System.Windows.Forms.ListView
    Friend WithEvents transNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents machine As System.Windows.Forms.ColumnHeader
    Friend WithEvents connection As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTcpLog As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cpServer As DevComponents.DotNetBar.Controls.CircularProgress
    Public WithEvents lblServerStat As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblQueueNo As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblMachine As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSmsLog As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents lvSmsDevice As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents colQueueNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colQMachine As System.Windows.Forms.ColumnHeader
    Friend WithEvents colQProduct As System.Windows.Forms.ColumnHeader
    Friend WithEvents tmrTrans As System.Windows.Forms.Timer
    Friend WithEvents product As System.Windows.Forms.ColumnHeader
    Friend WithEvents colQConn As System.Windows.Forms.ColumnHeader
    Friend WithEvents bwDevice As System.ComponentModel.BackgroundWorker
    Friend WithEvents imgSignal As System.Windows.Forms.ImageList
    Friend WithEvents spDevice As System.IO.Ports.SerialPort
End Class
