<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserHomePage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserHomePage))
        Me.userHeader = New System.Windows.Forms.Panel()
        Me.userLogout = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.uName = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.profileBtn = New System.Windows.Forms.Button()
        Me.postsBtn = New System.Windows.Forms.Button()
        Me.dropdown = New System.Windows.Forms.Panel()
        Me.CPUsBtn = New System.Windows.Forms.Button()
        Me.IPsBtn = New System.Windows.Forms.Button()
        Me.equipmentsBtn = New System.Windows.Forms.Button()
        Me.monitorsBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CPUsBtn2 = New System.Windows.Forms.Button()
        Me.IPsBtn2 = New System.Windows.Forms.Button()
        Me.monitorsBtn2 = New System.Windows.Forms.Button()
        Me.activeCPUNumber = New System.Windows.Forms.Label()
        Me.nonActiveCPUNumber = New System.Windows.Forms.Label()
        Me.activeIPNumber = New System.Windows.Forms.Label()
        Me.nonActiveIPNumber = New System.Windows.Forms.Label()
        Me.activeMonitorNumber = New System.Windows.Forms.Label()
        Me.nonActiveMonitorNumber = New System.Windows.Forms.Label()
        Me.userPostPanel = New System.Windows.Forms.Panel()
        Me.confirmMsgP = New System.Windows.Forms.Label()
        Me.userProfilePanel = New System.Windows.Forms.Panel()
        Me.profileSubPanel2 = New System.Windows.Forms.Panel()
        Me.userConfirmPwdProfileInput = New System.Windows.Forms.TextBox()
        Me.userConfirmPwdProfileLabel = New System.Windows.Forms.Label()
        Me.updateProfileCancelBtn = New System.Windows.Forms.Button()
        Me.updateProfileErrorMsg = New System.Windows.Forms.Label()
        Me.userPwdProfileInput = New System.Windows.Forms.TextBox()
        Me.userPhoneNumberProfileInput = New System.Windows.Forms.TextBox()
        Me.userEmailProfileInput = New System.Windows.Forms.TextBox()
        Me.userNameProfileInput = New System.Windows.Forms.TextBox()
        Me.updateProfileValidateBtn = New System.Windows.Forms.Button()
        Me.userEmailProfileLabel2 = New System.Windows.Forms.Label()
        Me.userPhoneNumberProfileLabel2 = New System.Windows.Forms.Label()
        Me.userPwdProfileLabel = New System.Windows.Forms.Label()
        Me.userNameProfileLabel2 = New System.Windows.Forms.Label()
        Me.profileSubPanel1 = New System.Windows.Forms.Panel()
        Me.updateProfileShowBtn = New System.Windows.Forms.Button()
        Me.userEmailProfile = New System.Windows.Forms.Label()
        Me.userTitleProfile = New System.Windows.Forms.Label()
        Me.userPhoneNumberProfile = New System.Windows.Forms.Label()
        Me.userNameProfile = New System.Windows.Forms.Label()
        Me.userEmailProfileLabel = New System.Windows.Forms.Label()
        Me.userPhoneNumberProfileLabel = New System.Windows.Forms.Label()
        Me.userTitleProfileLabel = New System.Windows.Forms.Label()
        Me.userNameProfileLabel = New System.Windows.Forms.Label()
        Me.profileTitle = New System.Windows.Forms.Label()
        Me.hallSearchBoxP = New System.Windows.Forms.ComboBox()
        Me.searchErrorP = New System.Windows.Forms.Label()
        Me.printBtnP = New System.Windows.Forms.Button()
        Me.exportBtnP = New System.Windows.Forms.Button()
        Me.postSearchBox = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.postTitle = New System.Windows.Forms.Label()
        Me.userHomePagePanel = New System.Windows.Forms.Panel()
        Me.userEquipmentPanel = New System.Windows.Forms.Panel()
        Me.confirmMsgE = New System.Windows.Forms.Label()
        Me.hallSearchBoxE = New System.Windows.Forms.ComboBox()
        Me.searchErrorE = New System.Windows.Forms.Label()
        Me.printBtnE = New System.Windows.Forms.Button()
        Me.exportBtnE = New System.Windows.Forms.Button()
        Me.equipmentSearchBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EquipmentTitle = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.userHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.dropdown.SuspendLayout()
        Me.userPostPanel.SuspendLayout()
        Me.userProfilePanel.SuspendLayout()
        Me.profileSubPanel2.SuspendLayout()
        Me.profileSubPanel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.userHomePagePanel.SuspendLayout()
        Me.userEquipmentPanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'userHeader
        '
        Me.userHeader.BackColor = System.Drawing.Color.LightSlateGray
        Me.userHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.userHeader.Controls.Add(Me.userLogout)
        Me.userHeader.Controls.Add(Me.Label2)
        Me.userHeader.Controls.Add(Me.PictureBox1)
        Me.userHeader.Controls.Add(Me.uName)
        Me.userHeader.Controls.Add(Me.FlowLayoutPanel1)
        Me.userHeader.Location = New System.Drawing.Point(1, 0)
        Me.userHeader.Name = "userHeader"
        Me.userHeader.Size = New System.Drawing.Size(883, 73)
        Me.userHeader.TabIndex = 0
        '
        'userLogout
        '
        Me.userLogout.BackColor = System.Drawing.Color.Transparent
        Me.userLogout.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.userLogout.FlatAppearance.BorderSize = 0
        Me.userLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userLogout.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.userLogout.Location = New System.Drawing.Point(802, 27)
        Me.userLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.userLogout.MaximumSize = New System.Drawing.Size(156, 50)
        Me.userLogout.Name = "userLogout"
        Me.userLogout.Size = New System.Drawing.Size(57, 22)
        Me.userLogout.TabIndex = 23
        Me.userLogout.Text = "logout"
        Me.userLogout.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "User"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cems.My.Resources.Resources.logo_light
        Me.PictureBox1.Location = New System.Drawing.Point(174, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'uName
        '
        Me.uName.AutoSize = True
        Me.uName.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.uName.Location = New System.Drawing.Point(721, 30)
        Me.uName.Name = "uName"
        Me.uName.Size = New System.Drawing.Size(75, 19)
        Me.uName.TabIndex = 5
        Me.uName.Text = "******"
        Me.uName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 97)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.profileBtn)
        Me.Panel2.Controls.Add(Me.postsBtn)
        Me.Panel2.Controls.Add(Me.dropdown)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.MaximumSize = New System.Drawing.Size(160, 500)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(157, 500)
        Me.Panel2.TabIndex = 2
        '
        'profileBtn
        '
        Me.profileBtn.BackColor = System.Drawing.Color.LightSlateGray
        Me.profileBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.profileBtn.FlatAppearance.BorderSize = 0
        Me.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.profileBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.profileBtn.Location = New System.Drawing.Point(0, 71)
        Me.profileBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.profileBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.profileBtn.Name = "profileBtn"
        Me.profileBtn.Size = New System.Drawing.Size(156, 47)
        Me.profileBtn.TabIndex = 10
        Me.profileBtn.Text = "Profile"
        Me.profileBtn.UseVisualStyleBackColor = False
        '
        'postsBtn
        '
        Me.postsBtn.BackColor = System.Drawing.Color.LightSlateGray
        Me.postsBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.postsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.postsBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.postsBtn.Location = New System.Drawing.Point(-1, 117)
        Me.postsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.postsBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.postsBtn.Name = "postsBtn"
        Me.postsBtn.Size = New System.Drawing.Size(156, 47)
        Me.postsBtn.TabIndex = 12
        Me.postsBtn.Text = "Posts"
        Me.postsBtn.UseVisualStyleBackColor = False
        '
        'dropdown
        '
        Me.dropdown.BackColor = System.Drawing.Color.LightSlateGray
        Me.dropdown.Controls.Add(Me.CPUsBtn)
        Me.dropdown.Controls.Add(Me.IPsBtn)
        Me.dropdown.Controls.Add(Me.equipmentsBtn)
        Me.dropdown.Controls.Add(Me.monitorsBtn)
        Me.dropdown.Location = New System.Drawing.Point(0, 164)
        Me.dropdown.MaximumSize = New System.Drawing.Size(156, 187)
        Me.dropdown.MinimumSize = New System.Drawing.Size(156, 48)
        Me.dropdown.Name = "dropdown"
        Me.dropdown.Size = New System.Drawing.Size(156, 187)
        Me.dropdown.TabIndex = 7
        '
        'CPUsBtn
        '
        Me.CPUsBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.CPUsBtn.FlatAppearance.BorderSize = 0
        Me.CPUsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CPUsBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.CPUsBtn.Location = New System.Drawing.Point(-1, 47)
        Me.CPUsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.CPUsBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.CPUsBtn.Name = "CPUsBtn"
        Me.CPUsBtn.Size = New System.Drawing.Size(156, 47)
        Me.CPUsBtn.TabIndex = 9
        Me.CPUsBtn.Text = "CPUs"
        Me.CPUsBtn.UseVisualStyleBackColor = False
        '
        'IPsBtn
        '
        Me.IPsBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.IPsBtn.FlatAppearance.BorderSize = 0
        Me.IPsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IPsBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.IPsBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IPsBtn.Location = New System.Drawing.Point(-1, 93)
        Me.IPsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.IPsBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.IPsBtn.Name = "IPsBtn"
        Me.IPsBtn.Size = New System.Drawing.Size(156, 47)
        Me.IPsBtn.TabIndex = 7
        Me.IPsBtn.Text = "IP Phones"
        Me.IPsBtn.UseVisualStyleBackColor = False
        '
        'equipmentsBtn
        '
        Me.equipmentsBtn.BackColor = System.Drawing.Color.LightSlateGray
        Me.equipmentsBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.equipmentsBtn.FlatAppearance.BorderSize = 0
        Me.equipmentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.equipmentsBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.equipmentsBtn.Image = Global.cems.My.Resources.Resources.drop_left_arrow1
        Me.equipmentsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.equipmentsBtn.Location = New System.Drawing.Point(0, 0)
        Me.equipmentsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.equipmentsBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.equipmentsBtn.Name = "equipmentsBtn"
        Me.equipmentsBtn.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.equipmentsBtn.Size = New System.Drawing.Size(156, 47)
        Me.equipmentsBtn.TabIndex = 6
        Me.equipmentsBtn.Text = "Equipments"
        Me.equipmentsBtn.UseVisualStyleBackColor = False
        '
        'monitorsBtn
        '
        Me.monitorsBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.monitorsBtn.FlatAppearance.BorderSize = 0
        Me.monitorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.monitorsBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.monitorsBtn.Location = New System.Drawing.Point(-1, 140)
        Me.monitorsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.monitorsBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.monitorsBtn.Name = "monitorsBtn"
        Me.monitorsBtn.Size = New System.Drawing.Size(156, 47)
        Me.monitorsBtn.TabIndex = 8
        Me.monitorsBtn.Text = "Monitors"
        Me.monitorsBtn.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'Timer2
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 24)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "User Home Page"
        '
        'CPUsBtn2
        '
        Me.CPUsBtn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CPUsBtn2.Location = New System.Drawing.Point(117, 93)
        Me.CPUsBtn2.Name = "CPUsBtn2"
        Me.CPUsBtn2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.CPUsBtn2.Size = New System.Drawing.Size(165, 103)
        Me.CPUsBtn2.TabIndex = 24
        Me.CPUsBtn2.Text = "CPUs"
        Me.CPUsBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CPUsBtn2.UseVisualStyleBackColor = True
        '
        'IPsBtn2
        '
        Me.IPsBtn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IPsBtn2.Location = New System.Drawing.Point(303, 93)
        Me.IPsBtn2.Name = "IPsBtn2"
        Me.IPsBtn2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.IPsBtn2.Size = New System.Drawing.Size(161, 103)
        Me.IPsBtn2.TabIndex = 25
        Me.IPsBtn2.Text = "IP Phones"
        Me.IPsBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IPsBtn2.UseVisualStyleBackColor = True
        '
        'monitorsBtn2
        '
        Me.monitorsBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.monitorsBtn2.Image = Global.cems.My.Resources.Resources.menu
        Me.monitorsBtn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.monitorsBtn2.Location = New System.Drawing.Point(483, 93)
        Me.monitorsBtn2.Name = "monitorsBtn2"
        Me.monitorsBtn2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.monitorsBtn2.Size = New System.Drawing.Size(170, 103)
        Me.monitorsBtn2.TabIndex = 26
        Me.monitorsBtn2.Text = "Monitors"
        Me.monitorsBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.monitorsBtn2.UseVisualStyleBackColor = True
        '
        'activeCPUNumber
        '
        Me.activeCPUNumber.AutoSize = True
        Me.activeCPUNumber.Location = New System.Drawing.Point(192, 161)
        Me.activeCPUNumber.Name = "activeCPUNumber"
        Me.activeCPUNumber.Size = New System.Drawing.Size(31, 13)
        Me.activeCPUNumber.TabIndex = 27
        Me.activeCPUNumber.Text = "0000"
        '
        'nonActiveCPUNumber
        '
        Me.nonActiveCPUNumber.AutoSize = True
        Me.nonActiveCPUNumber.Location = New System.Drawing.Point(237, 161)
        Me.nonActiveCPUNumber.Name = "nonActiveCPUNumber"
        Me.nonActiveCPUNumber.Size = New System.Drawing.Size(31, 13)
        Me.nonActiveCPUNumber.TabIndex = 28
        Me.nonActiveCPUNumber.Text = "0000"
        '
        'activeIPNumber
        '
        Me.activeIPNumber.AutoSize = True
        Me.activeIPNumber.Location = New System.Drawing.Point(376, 161)
        Me.activeIPNumber.Name = "activeIPNumber"
        Me.activeIPNumber.Size = New System.Drawing.Size(31, 13)
        Me.activeIPNumber.TabIndex = 29
        Me.activeIPNumber.Text = "0000"
        '
        'nonActiveIPNumber
        '
        Me.nonActiveIPNumber.AutoSize = True
        Me.nonActiveIPNumber.Location = New System.Drawing.Point(421, 161)
        Me.nonActiveIPNumber.Name = "nonActiveIPNumber"
        Me.nonActiveIPNumber.Size = New System.Drawing.Size(31, 13)
        Me.nonActiveIPNumber.TabIndex = 30
        Me.nonActiveIPNumber.Text = "0000"
        '
        'activeMonitorNumber
        '
        Me.activeMonitorNumber.AutoSize = True
        Me.activeMonitorNumber.Location = New System.Drawing.Point(564, 161)
        Me.activeMonitorNumber.Name = "activeMonitorNumber"
        Me.activeMonitorNumber.Size = New System.Drawing.Size(31, 13)
        Me.activeMonitorNumber.TabIndex = 31
        Me.activeMonitorNumber.Text = "0000"
        '
        'nonActiveMonitorNumber
        '
        Me.nonActiveMonitorNumber.AutoSize = True
        Me.nonActiveMonitorNumber.Location = New System.Drawing.Point(609, 161)
        Me.nonActiveMonitorNumber.Name = "nonActiveMonitorNumber"
        Me.nonActiveMonitorNumber.Size = New System.Drawing.Size(31, 13)
        Me.nonActiveMonitorNumber.TabIndex = 32
        Me.nonActiveMonitorNumber.Text = "0000"
        '
        'userPostPanel
        '
        Me.userPostPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.userPostPanel.Controls.Add(Me.confirmMsgP)
        Me.userPostPanel.Controls.Add(Me.userProfilePanel)
        Me.userPostPanel.Controls.Add(Me.hallSearchBoxP)
        Me.userPostPanel.Controls.Add(Me.searchErrorP)
        Me.userPostPanel.Controls.Add(Me.printBtnP)
        Me.userPostPanel.Controls.Add(Me.exportBtnP)
        Me.userPostPanel.Controls.Add(Me.postSearchBox)
        Me.userPostPanel.Controls.Add(Me.DataGridView2)
        Me.userPostPanel.Controls.Add(Me.postTitle)
        Me.userPostPanel.Location = New System.Drawing.Point(0, 0)
        Me.userPostPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.userPostPanel.Name = "userPostPanel"
        Me.userPostPanel.Size = New System.Drawing.Size(725, 392)
        Me.userPostPanel.TabIndex = 13
        Me.userPostPanel.Visible = False
        '
        'confirmMsgP
        '
        Me.confirmMsgP.AutoSize = True
        Me.confirmMsgP.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.confirmMsgP.ForeColor = System.Drawing.Color.LimeGreen
        Me.confirmMsgP.Location = New System.Drawing.Point(523, 14)
        Me.confirmMsgP.Name = "confirmMsgP"
        Me.confirmMsgP.Size = New System.Drawing.Size(164, 16)
        Me.confirmMsgP.TabIndex = 39
        Me.confirmMsgP.Text = "Export successfull ✔"
        Me.confirmMsgP.Visible = False
        '
        'userProfilePanel
        '
        Me.userProfilePanel.Controls.Add(Me.profileSubPanel2)
        Me.userProfilePanel.Controls.Add(Me.profileSubPanel1)
        Me.userProfilePanel.Controls.Add(Me.profileTitle)
        Me.userProfilePanel.Location = New System.Drawing.Point(0, -1)
        Me.userProfilePanel.Name = "userProfilePanel"
        Me.userProfilePanel.Size = New System.Drawing.Size(725, 393)
        Me.userProfilePanel.TabIndex = 38
        '
        'profileSubPanel2
        '
        Me.profileSubPanel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.profileSubPanel2.Controls.Add(Me.userConfirmPwdProfileInput)
        Me.profileSubPanel2.Controls.Add(Me.userConfirmPwdProfileLabel)
        Me.profileSubPanel2.Controls.Add(Me.updateProfileCancelBtn)
        Me.profileSubPanel2.Controls.Add(Me.updateProfileErrorMsg)
        Me.profileSubPanel2.Controls.Add(Me.userPwdProfileInput)
        Me.profileSubPanel2.Controls.Add(Me.userPhoneNumberProfileInput)
        Me.profileSubPanel2.Controls.Add(Me.userEmailProfileInput)
        Me.profileSubPanel2.Controls.Add(Me.userNameProfileInput)
        Me.profileSubPanel2.Controls.Add(Me.updateProfileValidateBtn)
        Me.profileSubPanel2.Controls.Add(Me.userEmailProfileLabel2)
        Me.profileSubPanel2.Controls.Add(Me.userPhoneNumberProfileLabel2)
        Me.profileSubPanel2.Controls.Add(Me.userPwdProfileLabel)
        Me.profileSubPanel2.Controls.Add(Me.userNameProfileLabel2)
        Me.profileSubPanel2.Location = New System.Drawing.Point(66, 93)
        Me.profileSubPanel2.Name = "profileSubPanel2"
        Me.profileSubPanel2.Size = New System.Drawing.Size(587, 252)
        Me.profileSubPanel2.TabIndex = 32
        Me.profileSubPanel2.Visible = False
        '
        'userConfirmPwdProfileInput
        '
        Me.userConfirmPwdProfileInput.Location = New System.Drawing.Point(299, 182)
        Me.userConfirmPwdProfileInput.Name = "userConfirmPwdProfileInput"
        Me.userConfirmPwdProfileInput.Size = New System.Drawing.Size(180, 20)
        Me.userConfirmPwdProfileInput.TabIndex = 22
        '
        'userConfirmPwdProfileLabel
        '
        Me.userConfirmPwdProfileLabel.AutoSize = True
        Me.userConfirmPwdProfileLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userConfirmPwdProfileLabel.Location = New System.Drawing.Point(48, 180)
        Me.userConfirmPwdProfileLabel.Name = "userConfirmPwdProfileLabel"
        Me.userConfirmPwdProfileLabel.Size = New System.Drawing.Size(179, 20)
        Me.userConfirmPwdProfileLabel.TabIndex = 21
        Me.userConfirmPwdProfileLabel.Text = "Confirm password:"
        '
        'updateProfileCancelBtn
        '
        Me.updateProfileCancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.updateProfileCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.updateProfileCancelBtn.FlatAppearance.BorderSize = 0
        Me.updateProfileCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateProfileCancelBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.updateProfileCancelBtn.Location = New System.Drawing.Point(416, 215)
        Me.updateProfileCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.updateProfileCancelBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.updateProfileCancelBtn.Name = "updateProfileCancelBtn"
        Me.updateProfileCancelBtn.Size = New System.Drawing.Size(67, 22)
        Me.updateProfileCancelBtn.TabIndex = 20
        Me.updateProfileCancelBtn.Text = "Cancel"
        Me.updateProfileCancelBtn.UseVisualStyleBackColor = False
        '
        'updateProfileErrorMsg
        '
        Me.updateProfileErrorMsg.AutoSize = True
        Me.updateProfileErrorMsg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.updateProfileErrorMsg.Font = New System.Drawing.Font("MS Reference Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateProfileErrorMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.updateProfileErrorMsg.Location = New System.Drawing.Point(150, 225)
        Me.updateProfileErrorMsg.Name = "updateProfileErrorMsg"
        Me.updateProfileErrorMsg.Size = New System.Drawing.Size(0, 12)
        Me.updateProfileErrorMsg.TabIndex = 19
        Me.updateProfileErrorMsg.Visible = False
        '
        'userPwdProfileInput
        '
        Me.userPwdProfileInput.Location = New System.Drawing.Point(299, 150)
        Me.userPwdProfileInput.Name = "userPwdProfileInput"
        Me.userPwdProfileInput.Size = New System.Drawing.Size(180, 20)
        Me.userPwdProfileInput.TabIndex = 18
        '
        'userPhoneNumberProfileInput
        '
        Me.userPhoneNumberProfileInput.Location = New System.Drawing.Point(299, 85)
        Me.userPhoneNumberProfileInput.Name = "userPhoneNumberProfileInput"
        Me.userPhoneNumberProfileInput.Size = New System.Drawing.Size(180, 20)
        Me.userPhoneNumberProfileInput.TabIndex = 17
        '
        'userEmailProfileInput
        '
        Me.userEmailProfileInput.Location = New System.Drawing.Point(299, 51)
        Me.userEmailProfileInput.Name = "userEmailProfileInput"
        Me.userEmailProfileInput.Size = New System.Drawing.Size(180, 20)
        Me.userEmailProfileInput.TabIndex = 16
        '
        'userNameProfileInput
        '
        Me.userNameProfileInput.Location = New System.Drawing.Point(299, 16)
        Me.userNameProfileInput.Name = "userNameProfileInput"
        Me.userNameProfileInput.Size = New System.Drawing.Size(180, 20)
        Me.userNameProfileInput.TabIndex = 15
        '
        'updateProfileValidateBtn
        '
        Me.updateProfileValidateBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.updateProfileValidateBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.updateProfileValidateBtn.FlatAppearance.BorderSize = 0
        Me.updateProfileValidateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateProfileValidateBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.updateProfileValidateBtn.Location = New System.Drawing.Point(500, 215)
        Me.updateProfileValidateBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.updateProfileValidateBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.updateProfileValidateBtn.Name = "updateProfileValidateBtn"
        Me.updateProfileValidateBtn.Size = New System.Drawing.Size(67, 22)
        Me.updateProfileValidateBtn.TabIndex = 13
        Me.updateProfileValidateBtn.Text = "Done"
        Me.updateProfileValidateBtn.UseVisualStyleBackColor = False
        '
        'userEmailProfileLabel2
        '
        Me.userEmailProfileLabel2.AutoSize = True
        Me.userEmailProfileLabel2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userEmailProfileLabel2.Location = New System.Drawing.Point(49, 48)
        Me.userEmailProfileLabel2.Name = "userEmailProfileLabel2"
        Me.userEmailProfileLabel2.Size = New System.Drawing.Size(122, 20)
        Me.userEmailProfileLabel2.TabIndex = 11
        Me.userEmailProfileLabel2.Text = "User email :"
        '
        'userPhoneNumberProfileLabel2
        '
        Me.userPhoneNumberProfileLabel2.AutoSize = True
        Me.userPhoneNumberProfileLabel2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userPhoneNumberProfileLabel2.Location = New System.Drawing.Point(49, 83)
        Me.userPhoneNumberProfileLabel2.Name = "userPhoneNumberProfileLabel2"
        Me.userPhoneNumberProfileLabel2.Size = New System.Drawing.Size(232, 20)
        Me.userPhoneNumberProfileLabel2.TabIndex = 10
        Me.userPhoneNumberProfileLabel2.Text = "User telephone nunber :"
        '
        'userPwdProfileLabel
        '
        Me.userPwdProfileLabel.AutoSize = True
        Me.userPwdProfileLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userPwdProfileLabel.Location = New System.Drawing.Point(49, 148)
        Me.userPwdProfileLabel.Name = "userPwdProfileLabel"
        Me.userPwdProfileLabel.Size = New System.Drawing.Size(200, 20)
        Me.userPwdProfileLabel.TabIndex = 9
        Me.userPwdProfileLabel.Text = "Enter new password:"
        '
        'userNameProfileLabel2
        '
        Me.userNameProfileLabel2.AutoSize = True
        Me.userNameProfileLabel2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userNameProfileLabel2.Location = New System.Drawing.Point(49, 14)
        Me.userNameProfileLabel2.Name = "userNameProfileLabel2"
        Me.userNameProfileLabel2.Size = New System.Drawing.Size(121, 20)
        Me.userNameProfileLabel2.TabIndex = 7
        Me.userNameProfileLabel2.Text = "User name :"
        '
        'profileSubPanel1
        '
        Me.profileSubPanel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.profileSubPanel1.Controls.Add(Me.updateProfileShowBtn)
        Me.profileSubPanel1.Controls.Add(Me.userEmailProfile)
        Me.profileSubPanel1.Controls.Add(Me.userTitleProfile)
        Me.profileSubPanel1.Controls.Add(Me.userPhoneNumberProfile)
        Me.profileSubPanel1.Controls.Add(Me.userNameProfile)
        Me.profileSubPanel1.Controls.Add(Me.userEmailProfileLabel)
        Me.profileSubPanel1.Controls.Add(Me.userPhoneNumberProfileLabel)
        Me.profileSubPanel1.Controls.Add(Me.userTitleProfileLabel)
        Me.profileSubPanel1.Controls.Add(Me.userNameProfileLabel)
        Me.profileSubPanel1.Location = New System.Drawing.Point(66, 93)
        Me.profileSubPanel1.Name = "profileSubPanel1"
        Me.profileSubPanel1.Size = New System.Drawing.Size(587, 252)
        Me.profileSubPanel1.TabIndex = 31
        '
        'updateProfileShowBtn
        '
        Me.updateProfileShowBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.updateProfileShowBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.updateProfileShowBtn.FlatAppearance.BorderSize = 0
        Me.updateProfileShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateProfileShowBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.updateProfileShowBtn.Location = New System.Drawing.Point(472, 205)
        Me.updateProfileShowBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.updateProfileShowBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.updateProfileShowBtn.Name = "updateProfileShowBtn"
        Me.updateProfileShowBtn.Size = New System.Drawing.Size(95, 32)
        Me.updateProfileShowBtn.TabIndex = 13
        Me.updateProfileShowBtn.Text = "Update"
        Me.updateProfileShowBtn.UseVisualStyleBackColor = False
        '
        'userEmailProfile
        '
        Me.userEmailProfile.AutoSize = True
        Me.userEmailProfile.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.userEmailProfile.Location = New System.Drawing.Point(295, 118)
        Me.userEmailProfile.Name = "userEmailProfile"
        Me.userEmailProfile.Size = New System.Drawing.Size(75, 19)
        Me.userEmailProfile.TabIndex = 14
        Me.userEmailProfile.Text = "******"
        '
        'userTitleProfile
        '
        Me.userTitleProfile.AutoSize = True
        Me.userTitleProfile.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.userTitleProfile.Location = New System.Drawing.Point(295, 190)
        Me.userTitleProfile.Name = "userTitleProfile"
        Me.userTitleProfile.Size = New System.Drawing.Size(75, 19)
        Me.userTitleProfile.TabIndex = 13
        Me.userTitleProfile.Text = "******"
        '
        'userPhoneNumberProfile
        '
        Me.userPhoneNumberProfile.AutoSize = True
        Me.userPhoneNumberProfile.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.userPhoneNumberProfile.Location = New System.Drawing.Point(295, 153)
        Me.userPhoneNumberProfile.Name = "userPhoneNumberProfile"
        Me.userPhoneNumberProfile.Size = New System.Drawing.Size(75, 19)
        Me.userPhoneNumberProfile.TabIndex = 12
        Me.userPhoneNumberProfile.Text = "******"
        '
        'userNameProfile
        '
        Me.userNameProfile.AutoSize = True
        Me.userNameProfile.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.userNameProfile.Location = New System.Drawing.Point(295, 84)
        Me.userNameProfile.Name = "userNameProfile"
        Me.userNameProfile.Size = New System.Drawing.Size(75, 19)
        Me.userNameProfile.TabIndex = 7
        Me.userNameProfile.Text = "******"
        '
        'userEmailProfileLabel
        '
        Me.userEmailProfileLabel.AutoSize = True
        Me.userEmailProfileLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userEmailProfileLabel.Location = New System.Drawing.Point(47, 117)
        Me.userEmailProfileLabel.Name = "userEmailProfileLabel"
        Me.userEmailProfileLabel.Size = New System.Drawing.Size(122, 20)
        Me.userEmailProfileLabel.TabIndex = 11
        Me.userEmailProfileLabel.Text = "User email :"
        '
        'userPhoneNumberProfileLabel
        '
        Me.userPhoneNumberProfileLabel.AutoSize = True
        Me.userPhoneNumberProfileLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userPhoneNumberProfileLabel.Location = New System.Drawing.Point(47, 152)
        Me.userPhoneNumberProfileLabel.Name = "userPhoneNumberProfileLabel"
        Me.userPhoneNumberProfileLabel.Size = New System.Drawing.Size(232, 20)
        Me.userPhoneNumberProfileLabel.TabIndex = 10
        Me.userPhoneNumberProfileLabel.Text = "User telephone nunber :"
        '
        'userTitleProfileLabel
        '
        Me.userTitleProfileLabel.AutoSize = True
        Me.userTitleProfileLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userTitleProfileLabel.Location = New System.Drawing.Point(47, 186)
        Me.userTitleProfileLabel.Name = "userTitleProfileLabel"
        Me.userTitleProfileLabel.Size = New System.Drawing.Size(114, 20)
        Me.userTitleProfileLabel.TabIndex = 9
        Me.userTitleProfileLabel.Text = "User Title :"
        '
        'userNameProfileLabel
        '
        Me.userNameProfileLabel.AutoSize = True
        Me.userNameProfileLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userNameProfileLabel.Location = New System.Drawing.Point(47, 83)
        Me.userNameProfileLabel.Name = "userNameProfileLabel"
        Me.userNameProfileLabel.Size = New System.Drawing.Size(121, 20)
        Me.userNameProfileLabel.TabIndex = 7
        Me.userNameProfileLabel.Text = "User name :"
        '
        'profileTitle
        '
        Me.profileTitle.AutoSize = True
        Me.profileTitle.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.25!, System.Drawing.FontStyle.Bold)
        Me.profileTitle.Location = New System.Drawing.Point(61, 54)
        Me.profileTitle.Name = "profileTitle"
        Me.profileTitle.Size = New System.Drawing.Size(86, 26)
        Me.profileTitle.TabIndex = 30
        Me.profileTitle.Text = "Profile"
        '
        'hallSearchBoxP
        '
        Me.hallSearchBoxP.FormattingEnabled = True
        Me.hallSearchBoxP.Location = New System.Drawing.Point(442, 60)
        Me.hallSearchBoxP.Name = "hallSearchBoxP"
        Me.hallSearchBoxP.Size = New System.Drawing.Size(80, 21)
        Me.hallSearchBoxP.TabIndex = 37
        '
        'searchErrorP
        '
        Me.searchErrorP.AutoSize = True
        Me.searchErrorP.Font = New System.Drawing.Font("MS Reference Sans Serif", 24.25!, System.Drawing.FontStyle.Bold)
        Me.searchErrorP.Location = New System.Drawing.Point(222, 225)
        Me.searchErrorP.Name = "searchErrorP"
        Me.searchErrorP.Size = New System.Drawing.Size(321, 40)
        Me.searchErrorP.TabIndex = 36
        Me.searchErrorP.Text = "No results found "
        Me.searchErrorP.Visible = False
        '
        'printBtnP
        '
        Me.printBtnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printBtnP.Location = New System.Drawing.Point(609, 59)
        Me.printBtnP.Name = "printBtnP"
        Me.printBtnP.Size = New System.Drawing.Size(75, 23)
        Me.printBtnP.TabIndex = 33
        Me.printBtnP.Text = "Print"
        Me.printBtnP.UseVisualStyleBackColor = True
        '
        'exportBtnP
        '
        Me.exportBtnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exportBtnP.Location = New System.Drawing.Point(526, 59)
        Me.exportBtnP.Name = "exportBtnP"
        Me.exportBtnP.Size = New System.Drawing.Size(75, 23)
        Me.exportBtnP.TabIndex = 32
        Me.exportBtnP.Text = "Export"
        Me.exportBtnP.UseVisualStyleBackColor = True
        '
        'postSearchBox
        '
        Me.postSearchBox.ForeColor = System.Drawing.Color.DarkGray
        Me.postSearchBox.Location = New System.Drawing.Point(276, 61)
        Me.postSearchBox.Name = "postSearchBox"
        Me.postSearchBox.Size = New System.Drawing.Size(160, 20)
        Me.postSearchBox.TabIndex = 31
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(61, 108)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(623, 236)
        Me.DataGridView2.TabIndex = 30
        '
        'postTitle
        '
        Me.postTitle.AutoSize = True
        Me.postTitle.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.postTitle.Location = New System.Drawing.Point(61, 42)
        Me.postTitle.Name = "postTitle"
        Me.postTitle.Size = New System.Drawing.Size(65, 24)
        Me.postTitle.TabIndex = 29
        Me.postTitle.Text = "Posts"
        '
        'userHomePagePanel
        '
        Me.userHomePagePanel.BackColor = System.Drawing.Color.LightSkyBlue
        Me.userHomePagePanel.Controls.Add(Me.userEquipmentPanel)
        Me.userHomePagePanel.Controls.Add(Me.nonActiveMonitorNumber)
        Me.userHomePagePanel.Controls.Add(Me.activeMonitorNumber)
        Me.userHomePagePanel.Controls.Add(Me.nonActiveIPNumber)
        Me.userHomePagePanel.Controls.Add(Me.activeIPNumber)
        Me.userHomePagePanel.Controls.Add(Me.nonActiveCPUNumber)
        Me.userHomePagePanel.Controls.Add(Me.activeCPUNumber)
        Me.userHomePagePanel.Controls.Add(Me.monitorsBtn2)
        Me.userHomePagePanel.Controls.Add(Me.IPsBtn2)
        Me.userHomePagePanel.Controls.Add(Me.CPUsBtn2)
        Me.userHomePagePanel.Controls.Add(Me.Label1)
        Me.userHomePagePanel.Location = New System.Drawing.Point(158, 70)
        Me.userHomePagePanel.Name = "userHomePagePanel"
        Me.userHomePagePanel.Size = New System.Drawing.Size(725, 392)
        Me.userHomePagePanel.TabIndex = 4
        '
        'userEquipmentPanel
        '
        Me.userEquipmentPanel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.userEquipmentPanel.Controls.Add(Me.confirmMsgE)
        Me.userEquipmentPanel.Controls.Add(Me.userPostPanel)
        Me.userEquipmentPanel.Controls.Add(Me.hallSearchBoxE)
        Me.userEquipmentPanel.Controls.Add(Me.searchErrorE)
        Me.userEquipmentPanel.Controls.Add(Me.printBtnE)
        Me.userEquipmentPanel.Controls.Add(Me.exportBtnE)
        Me.userEquipmentPanel.Controls.Add(Me.equipmentSearchBox)
        Me.userEquipmentPanel.Controls.Add(Me.DataGridView1)
        Me.userEquipmentPanel.Controls.Add(Me.EquipmentTitle)
        Me.userEquipmentPanel.Location = New System.Drawing.Point(1, 3)
        Me.userEquipmentPanel.Name = "userEquipmentPanel"
        Me.userEquipmentPanel.Size = New System.Drawing.Size(725, 392)
        Me.userEquipmentPanel.TabIndex = 33
        Me.userEquipmentPanel.Visible = False
        '
        'confirmMsgE
        '
        Me.confirmMsgE.AutoSize = True
        Me.confirmMsgE.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.confirmMsgE.ForeColor = System.Drawing.Color.LimeGreen
        Me.confirmMsgE.Location = New System.Drawing.Point(517, 14)
        Me.confirmMsgE.Name = "confirmMsgE"
        Me.confirmMsgE.Size = New System.Drawing.Size(164, 16)
        Me.confirmMsgE.TabIndex = 40
        Me.confirmMsgE.Text = "Export successfull ✔"
        Me.confirmMsgE.Visible = False
        '
        'hallSearchBoxE
        '
        Me.hallSearchBoxE.FormattingEnabled = True
        Me.hallSearchBoxE.Location = New System.Drawing.Point(441, 61)
        Me.hallSearchBoxE.Name = "hallSearchBoxE"
        Me.hallSearchBoxE.Size = New System.Drawing.Size(80, 21)
        Me.hallSearchBoxE.TabIndex = 38
        '
        'searchErrorE
        '
        Me.searchErrorE.AutoSize = True
        Me.searchErrorE.Font = New System.Drawing.Font("MS Reference Sans Serif", 24.25!, System.Drawing.FontStyle.Bold)
        Me.searchErrorE.Location = New System.Drawing.Point(204, 199)
        Me.searchErrorE.Name = "searchErrorE"
        Me.searchErrorE.Size = New System.Drawing.Size(321, 40)
        Me.searchErrorE.TabIndex = 35
        Me.searchErrorE.Text = "No results found "
        Me.searchErrorE.Visible = False
        '
        'printBtnE
        '
        Me.printBtnE.Location = New System.Drawing.Point(606, 59)
        Me.printBtnE.Name = "printBtnE"
        Me.printBtnE.Size = New System.Drawing.Size(75, 23)
        Me.printBtnE.TabIndex = 34
        Me.printBtnE.Text = "Print"
        Me.printBtnE.UseVisualStyleBackColor = True
        '
        'exportBtnE
        '
        Me.exportBtnE.Location = New System.Drawing.Point(525, 59)
        Me.exportBtnE.Name = "exportBtnE"
        Me.exportBtnE.Size = New System.Drawing.Size(75, 23)
        Me.exportBtnE.TabIndex = 33
        Me.exportBtnE.Text = "Export"
        Me.exportBtnE.UseVisualStyleBackColor = True
        '
        'equipmentSearchBox
        '
        Me.equipmentSearchBox.ForeColor = System.Drawing.Color.DarkGray
        Me.equipmentSearchBox.Location = New System.Drawing.Point(275, 61)
        Me.equipmentSearchBox.Name = "equipmentSearchBox"
        Me.equipmentSearchBox.Size = New System.Drawing.Size(160, 20)
        Me.equipmentSearchBox.TabIndex = 32
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(50, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(623, 236)
        Me.DataGridView1.TabIndex = 31
        '
        'EquipmentTitle
        '
        Me.EquipmentTitle.AutoSize = True
        Me.EquipmentTitle.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipmentTitle.Location = New System.Drawing.Point(50, 42)
        Me.EquipmentTitle.Name = "EquipmentTitle"
        Me.EquipmentTitle.Size = New System.Drawing.Size(62, 24)
        Me.EquipmentTitle.TabIndex = 30
        Me.EquipmentTitle.Text = "CPUs"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'UserHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.userHeader)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.userHomePagePanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(300, 300)
        Me.MaximumSize = New System.Drawing.Size(900, 500)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "UserHomePage"
        Me.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Page"
        Me.userHeader.ResumeLayout(False)
        Me.userHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.dropdown.ResumeLayout(False)
        Me.userPostPanel.ResumeLayout(False)
        Me.userPostPanel.PerformLayout()
        Me.userProfilePanel.ResumeLayout(False)
        Me.userProfilePanel.PerformLayout()
        Me.profileSubPanel2.ResumeLayout(False)
        Me.profileSubPanel2.PerformLayout()
        Me.profileSubPanel1.ResumeLayout(False)
        Me.profileSubPanel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.userHomePagePanel.ResumeLayout(False)
        Me.userHomePagePanel.PerformLayout()
        Me.userEquipmentPanel.ResumeLayout(False)
        Me.userEquipmentPanel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents userHeader As Panel
    Friend WithEvents uName As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents equipmentsBtn As Button
    Friend WithEvents dropdown As Panel
    Friend WithEvents CPUsBtn As Button
    Friend WithEvents IPsBtn As Button
    Friend WithEvents monitorsBtn As Button
    Friend WithEvents profileBtn As Button
    Friend WithEvents postsBtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents EquipmentTitle As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents equipmentSearchBox As TextBox
    Friend WithEvents exportBtnE As Button
    Friend WithEvents printBtnE As Button
    Friend WithEvents searchErrorE As Label
    Friend WithEvents userEquipmentPanel As Panel
    Friend WithEvents userHomePagePanel As Panel
    Friend WithEvents postTitle As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents postSearchBox As TextBox
    Friend WithEvents exportBtnP As Button
    Friend WithEvents printBtnP As Button
    Friend WithEvents searchErrorP As Label
    Friend WithEvents hallSearchBoxP As ComboBox
    Friend WithEvents userPostPanel As Panel
    Friend WithEvents nonActiveMonitorNumber As Label
    Friend WithEvents activeMonitorNumber As Label
    Friend WithEvents nonActiveIPNumber As Label
    Friend WithEvents activeIPNumber As Label
    Friend WithEvents nonActiveCPUNumber As Label
    Friend WithEvents activeCPUNumber As Label
    Friend WithEvents monitorsBtn2 As Button
    Friend WithEvents IPsBtn2 As Button
    Friend WithEvents CPUsBtn2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents hallSearchBoxE As ComboBox
    Friend WithEvents userProfilePanel As Panel
    Friend WithEvents profileTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents profileSubPanel1 As Panel
    Friend WithEvents userEmailProfile As Label
    Friend WithEvents userTitleProfile As Label
    Friend WithEvents userPhoneNumberProfile As Label
    Friend WithEvents userEmailProfileLabel As Label
    Friend WithEvents userPhoneNumberProfileLabel As Label
    Friend WithEvents userTitleProfileLabel As Label
    Friend WithEvents userNameProfileLabel As Label
    Friend WithEvents userNameProfile As Label
    Friend WithEvents updateProfileShowBtn As Button
    Friend WithEvents profileSubPanel2 As Panel
    Friend WithEvents userPhoneNumberProfileInput As TextBox
    Friend WithEvents userEmailProfileInput As TextBox
    Friend WithEvents userNameProfileInput As TextBox
    Friend WithEvents updateProfileValidateBtn As Button
    Friend WithEvents userEmailProfileLabel2 As Label
    Friend WithEvents userPhoneNumberProfileLabel2 As Label
    Friend WithEvents userNameProfileLabel2 As Label
    Friend WithEvents updateProfileErrorMsg As Label
    Friend WithEvents updateProfileCancelBtn As Button
    Friend WithEvents userConfirmPwdProfileInput As TextBox
    Friend WithEvents userConfirmPwdProfileLabel As Label
    Friend WithEvents userPwdProfileInput As TextBox
    Friend WithEvents userPwdProfileLabel As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents confirmMsgP As Label
    Friend WithEvents confirmMsgE As Label
    Friend WithEvents userLogout As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
