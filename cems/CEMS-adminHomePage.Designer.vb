<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminhomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminhomePage))
        Me.IPsBtn = New System.Windows.Forms.Button()
        Me.postsBtn = New System.Windows.Forms.Button()
        Me.dropdown = New System.Windows.Forms.Panel()
        Me.monitors = New System.Windows.Forms.Label()
        Me.IP = New System.Windows.Forms.Label()
        Me.CPUs = New System.Windows.Forms.Label()
        Me.Equipments = New System.Windows.Forms.Label()
        Me.CPUsBtn = New System.Windows.Forms.Button()
        Me.equipmentsBtn = New System.Windows.Forms.Button()
        Me.monitorsBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Posts = New System.Windows.Forms.Label()
        Me.Halls = New System.Windows.Forms.Label()
        Me.Users = New System.Windows.Forms.Label()
        Me.Roleslabel = New System.Windows.Forms.Label()
        Me.profile = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rolesBtn = New System.Windows.Forms.Button()
        Me.hallsBtn = New System.Windows.Forms.Button()
        Me.userBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.profileBtn = New System.Windows.Forms.Button()
        Me.aName = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.adminHeader = New System.Windows.Forms.Panel()
        Me.adminLogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.adminHomePagePanel = New System.Windows.Forms.Panel()
        Me.userNumber = New System.Windows.Forms.Label()
        Me.userbuttoninactive = New System.Windows.Forms.Button()
        Me.nonActiveMonitorNumber = New System.Windows.Forms.Label()
        Me.activeMonitorNumber = New System.Windows.Forms.Label()
        Me.nonActiveIPNumber = New System.Windows.Forms.Label()
        Me.activeIPNumber = New System.Windows.Forms.Label()
        Me.nonActiveCPUNumber = New System.Windows.Forms.Label()
        Me.activeCPUNumber = New System.Windows.Forms.Label()
        Me.monitorbuttoninactive = New System.Windows.Forms.Button()
        Me.IPbuttoninactive = New System.Windows.Forms.Button()
        Me.CPUbuttoninactive = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.adminEquipmentPanel = New System.Windows.Forms.Panel()
        Me.addEquipmentPanel = New System.Windows.Forms.Panel()
        Me.postIdInput = New System.Windows.Forms.ComboBox()
        Me.equipmentStateInput = New System.Windows.Forms.ComboBox()
        Me.equipmentTypeInput = New System.Windows.Forms.ComboBox()
        Me.addEquipmentErrorMsg = New System.Windows.Forms.Label()
        Me.hallInput = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.addEquipmentCancelBtn = New System.Windows.Forms.Button()
        Me.addEquipmentValidationBtn = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.confirmMsgE = New System.Windows.Forms.Label()
        Me.hallSearchBoxE = New System.Windows.Forms.ComboBox()
        Me.searchErrorE = New System.Windows.Forms.Label()
        Me.printBtnE = New System.Windows.Forms.Button()
        Me.exportBtnE = New System.Windows.Forms.Button()
        Me.equipmentSearchBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EquipmentTitle = New System.Windows.Forms.Label()
        Me.statePanel = New System.Windows.Forms.Panel()
        Me.stateChangeBtn = New System.Windows.Forms.Button()
        Me.equipmentDeleteBtn = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.equipmentState = New System.Windows.Forms.ComboBox()
        Me.addEquipmentBtn = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.userSearchBoxE = New System.Windows.Forms.ComboBox()
        Me.adminPostPanel = New System.Windows.Forms.Panel()
        Me.addPostPanel = New System.Windows.Forms.Panel()
        Me.postPostIdInput = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.postStateInput = New System.Windows.Forms.ComboBox()
        Me.addPostErrorMsg = New System.Windows.Forms.Label()
        Me.postHallInput = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.addPostCancelBtn = New System.Windows.Forms.Button()
        Me.addPostValidationBtn = New System.Windows.Forms.Button()
        Me.confirmMsgP = New System.Windows.Forms.Label()
        Me.hallSearchBoxP = New System.Windows.Forms.ComboBox()
        Me.searchErrorP = New System.Windows.Forms.Label()
        Me.printBtnP = New System.Windows.Forms.Button()
        Me.exportBtnP = New System.Windows.Forms.Button()
        Me.postSearchBox = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.postTitle = New System.Windows.Forms.Label()
        Me.postChangeStatePanel = New System.Windows.Forms.Panel()
        Me.postDeleteBtn = New System.Windows.Forms.Button()
        Me.postChangeBtn = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.postChangeStateInput = New System.Windows.Forms.ComboBox()
        Me.addPostBtn = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.stateSearchBoxP = New System.Windows.Forms.ComboBox()
        Me.adminProfilePanel = New System.Windows.Forms.Panel()
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
        Me.adminEmailProfile = New System.Windows.Forms.Label()
        Me.adminTitleProfile = New System.Windows.Forms.Label()
        Me.adminPhoneNumberProfile = New System.Windows.Forms.Label()
        Me.adminNameProfile = New System.Windows.Forms.Label()
        Me.adminEmailProfileLabel = New System.Windows.Forms.Label()
        Me.adminPhoneNumberProfileLabel = New System.Windows.Forms.Label()
        Me.adminTitleProfileLabel = New System.Windows.Forms.Label()
        Me.adminNameProfileLabel = New System.Windows.Forms.Label()
        Me.profileTitle = New System.Windows.Forms.Label()
        Me.adminHallsPanel = New System.Windows.Forms.Panel()
        Me.hallUpdatePanel = New System.Windows.Forms.Panel()
        Me.hallUpdateCancelBtn = New System.Windows.Forms.Button()
        Me.adminUpdateHallNameInput = New System.Windows.Forms.TextBox()
        Me.hallUpdateValidateBtn = New System.Windows.Forms.Button()
        Me.adminUpdateHallNameLabel = New System.Windows.Forms.Label()
        Me.hallAddpanel = New System.Windows.Forms.Panel()
        Me.addHallErrorMsg = New System.Windows.Forms.Label()
        Me.HallAddCancelBtn = New System.Windows.Forms.Button()
        Me.adminAddHallNameInput = New System.Windows.Forms.TextBox()
        Me.HallAddValidateBtn = New System.Windows.Forms.Button()
        Me.adminAddHallNameLabel = New System.Windows.Forms.Label()
        Me.hallAddBtn = New System.Windows.Forms.Button()
        Me.confirmMsgH = New System.Windows.Forms.Label()
        Me.HallUpdateBtn = New System.Windows.Forms.Button()
        Me.hallSearchBoxH = New System.Windows.Forms.ComboBox()
        Me.searchErrorH = New System.Windows.Forms.Label()
        Me.PrintBtnH = New System.Windows.Forms.Button()
        Me.exportBtnH = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.HallDeleteBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.adminUsersPanel = New System.Windows.Forms.Panel()
        Me.userUpdatePanel = New System.Windows.Forms.Panel()
        Me.userUserTitleInput = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.userUserPhoneInput = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.userUserEmailInput = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.userCancelBtn = New System.Windows.Forms.Button()
        Me.userUserNameInput = New System.Windows.Forms.TextBox()
        Me.userUpdateValidationBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.userAddPanel = New System.Windows.Forms.Panel()
        Me.addUserErrorMsg = New System.Windows.Forms.Label()
        Me.userUserAddTitleInput = New System.Windows.Forms.ComboBox()
        Me.userUserAddConfirmPwdInput = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.userUserAddPwdInput = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.userUserAddPhoneInput = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.userUserAddEmailInput = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.userAddCancelBtn = New System.Windows.Forms.Button()
        Me.userUserAddNameInput = New System.Windows.Forms.TextBox()
        Me.userAddvalidationBtn = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.userSearchBox = New System.Windows.Forms.TextBox()
        Me.userAddBtn = New System.Windows.Forms.Button()
        Me.confirmMsgU = New System.Windows.Forms.Label()
        Me.userUpdateBtn = New System.Windows.Forms.Button()
        Me.searchErrorU = New System.Windows.Forms.Label()
        Me.PrintBtnU = New System.Windows.Forms.Button()
        Me.exportBtnU = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.userDeleteBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.adminRolePanel = New System.Windows.Forms.Panel()
        Me.roleUpdatePanel = New System.Windows.Forms.Panel()
        Me.roleUpdateCancelBtn = New System.Windows.Forms.Button()
        Me.titleNameInput = New System.Windows.Forms.TextBox()
        Me.roleUpdateValidationBtn = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.roleAddPanel = New System.Windows.Forms.Panel()
        Me.addRoleErrorMsg = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.roleAddCancelBtn = New System.Windows.Forms.Button()
        Me.titleAddNameInput = New System.Windows.Forms.TextBox()
        Me.roleAddValidationBtn = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.roleDeleteBtn = New System.Windows.Forms.Button()
        Me.roleAddBtn = New System.Windows.Forms.Button()
        Me.confirmMsgR = New System.Windows.Forms.Label()
        Me.roleUpdateBtn = New System.Windows.Forms.Button()
        Me.searchErrorR = New System.Windows.Forms.Label()
        Me.PrintBtnR = New System.Windows.Forms.Button()
        Me.exportBtnR = New System.Windows.Forms.Button()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.Roles = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.CPUsBtn2 = New System.Windows.Forms.Button()
        Me.IPsBtn2 = New System.Windows.Forms.Button()
        Me.monitorsBtn2 = New System.Windows.Forms.Button()
        Me.usersBtn2 = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.dropdown.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.adminHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.adminHomePagePanel.SuspendLayout()
        Me.adminEquipmentPanel.SuspendLayout()
        Me.addEquipmentPanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statePanel.SuspendLayout()
        Me.adminPostPanel.SuspendLayout()
        Me.addPostPanel.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.postChangeStatePanel.SuspendLayout()
        Me.adminProfilePanel.SuspendLayout()
        Me.profileSubPanel2.SuspendLayout()
        Me.profileSubPanel1.SuspendLayout()
        Me.adminHallsPanel.SuspendLayout()
        Me.hallUpdatePanel.SuspendLayout()
        Me.hallAddpanel.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.adminUsersPanel.SuspendLayout()
        Me.userUpdatePanel.SuspendLayout()
        Me.userAddPanel.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.adminRolePanel.SuspendLayout()
        Me.roleUpdatePanel.SuspendLayout()
        Me.roleAddPanel.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IPsBtn
        '
        Me.IPsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.IPsBtn.FlatAppearance.BorderSize = 0
        Me.IPsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IPsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.IPsBtn.ForeColor = System.Drawing.Color.MintCream
        Me.IPsBtn.Location = New System.Drawing.Point(-1, 114)
        Me.IPsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.IPsBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.IPsBtn.Name = "IPsBtn"
        Me.IPsBtn.Size = New System.Drawing.Size(208, 58)
        Me.IPsBtn.TabIndex = 7
        Me.IPsBtn.UseVisualStyleBackColor = False
        '
        'postsBtn
        '
        Me.postsBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.postsBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.postsBtn.FlatAppearance.BorderSize = 0
        Me.postsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.postsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.postsBtn.ForeColor = System.Drawing.Color.MintCream
        Me.postsBtn.Location = New System.Drawing.Point(-1, 144)
        Me.postsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.postsBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.postsBtn.Name = "postsBtn"
        Me.postsBtn.Size = New System.Drawing.Size(208, 58)
        Me.postsBtn.TabIndex = 12
        Me.postsBtn.UseVisualStyleBackColor = False
        '
        'dropdown
        '
        Me.dropdown.BackColor = System.Drawing.Color.LightSlateGray
        Me.dropdown.Controls.Add(Me.monitors)
        Me.dropdown.Controls.Add(Me.IP)
        Me.dropdown.Controls.Add(Me.CPUs)
        Me.dropdown.Controls.Add(Me.Equipments)
        Me.dropdown.Controls.Add(Me.Label41)
        Me.dropdown.Controls.Add(Me.Label42)
        Me.dropdown.Controls.Add(Me.Label43)
        Me.dropdown.Controls.Add(Me.Label44)
        Me.dropdown.Controls.Add(Me.CPUsBtn)
        Me.dropdown.Controls.Add(Me.IPsBtn)
        Me.dropdown.Controls.Add(Me.equipmentsBtn)
        Me.dropdown.Controls.Add(Me.monitorsBtn)
        Me.dropdown.Location = New System.Drawing.Point(0, 375)
        Me.dropdown.Margin = New System.Windows.Forms.Padding(0)
        Me.dropdown.MaximumSize = New System.Drawing.Size(208, 230)
        Me.dropdown.MinimumSize = New System.Drawing.Size(208, 57)
        Me.dropdown.Name = "dropdown"
        Me.dropdown.Size = New System.Drawing.Size(208, 230)
        Me.dropdown.TabIndex = 7
        '
        'monitors
        '
        Me.monitors.AutoSize = True
        Me.monitors.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.monitors.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monitors.ForeColor = System.Drawing.Color.MintCream
        Me.monitors.Location = New System.Drawing.Point(77, 191)
        Me.monitors.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.monitors.Name = "monitors"
        Me.monitors.Size = New System.Drawing.Size(82, 20)
        Me.monitors.TabIndex = 37
        Me.monitors.Text = "Monitors"
        Me.monitors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IP
        '
        Me.IP.AutoSize = True
        Me.IP.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.IP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP.ForeColor = System.Drawing.Color.MintCream
        Me.IP.Location = New System.Drawing.Point(77, 133)
        Me.IP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IP.Name = "IP"
        Me.IP.Size = New System.Drawing.Size(94, 20)
        Me.IP.TabIndex = 38
        Me.IP.Text = "IP Phones"
        Me.IP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CPUs
        '
        Me.CPUs.AutoSize = True
        Me.CPUs.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.CPUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPUs.ForeColor = System.Drawing.Color.MintCream
        Me.CPUs.Location = New System.Drawing.Point(77, 82)
        Me.CPUs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CPUs.Name = "CPUs"
        Me.CPUs.Size = New System.Drawing.Size(64, 20)
        Me.CPUs.TabIndex = 39
        Me.CPUs.Text = "CPU'S"
        Me.CPUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Equipments
        '
        Me.Equipments.AutoSize = True
        Me.Equipments.BackColor = System.Drawing.Color.SeaGreen
        Me.Equipments.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Equipments.ForeColor = System.Drawing.Color.MintCream
        Me.Equipments.Location = New System.Drawing.Point(77, 19)
        Me.Equipments.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Equipments.Name = "Equipments"
        Me.Equipments.Size = New System.Drawing.Size(107, 20)
        Me.Equipments.TabIndex = 40
        Me.Equipments.Text = "Equipments"
        Me.Equipments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CPUsBtn
        '
        Me.CPUsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.CPUsBtn.FlatAppearance.BorderSize = 0
        Me.CPUsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CPUsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.CPUsBtn.ForeColor = System.Drawing.Color.MintCream
        Me.CPUsBtn.Location = New System.Drawing.Point(-1, 58)
        Me.CPUsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.CPUsBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.CPUsBtn.Name = "CPUsBtn"
        Me.CPUsBtn.Size = New System.Drawing.Size(208, 58)
        Me.CPUsBtn.TabIndex = 9
        Me.CPUsBtn.UseVisualStyleBackColor = False
        '
        'equipmentsBtn
        '
        Me.equipmentsBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.equipmentsBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.equipmentsBtn.FlatAppearance.BorderSize = 0
        Me.equipmentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.equipmentsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.equipmentsBtn.ForeColor = System.Drawing.Color.MintCream
        Me.equipmentsBtn.Image = Global.cems.My.Resources.Resources.drop_left_arrow1
        Me.equipmentsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.equipmentsBtn.Location = New System.Drawing.Point(0, 0)
        Me.equipmentsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.equipmentsBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.equipmentsBtn.Name = "equipmentsBtn"
        Me.equipmentsBtn.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.equipmentsBtn.Size = New System.Drawing.Size(208, 58)
        Me.equipmentsBtn.TabIndex = 6
        Me.equipmentsBtn.UseVisualStyleBackColor = False
        '
        'monitorsBtn
        '
        Me.monitorsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.monitorsBtn.FlatAppearance.BorderSize = 0
        Me.monitorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.monitorsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.monitorsBtn.Location = New System.Drawing.Point(-1, 172)
        Me.monitorsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.monitorsBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.monitorsBtn.Name = "monitorsBtn"
        Me.monitorsBtn.Size = New System.Drawing.Size(208, 58)
        Me.monitorsBtn.TabIndex = 8
        Me.monitorsBtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Controls.Add(Me.Label48)
        Me.Panel2.Controls.Add(Me.Label47)
        Me.Panel2.Controls.Add(Me.Label46)
        Me.Panel2.Controls.Add(Me.Label45)
        Me.Panel2.Controls.Add(Me.Label40)
        Me.Panel2.Controls.Add(Me.Label39)
        Me.Panel2.Controls.Add(Me.Posts)
        Me.Panel2.Controls.Add(Me.Halls)
        Me.Panel2.Controls.Add(Me.Users)
        Me.Panel2.Controls.Add(Me.Roleslabel)
        Me.Panel2.Controls.Add(Me.profile)
        Me.Panel2.Controls.Add(Me.dropdown)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.rolesBtn)
        Me.Panel2.Controls.Add(Me.hallsBtn)
        Me.Panel2.Controls.Add(Me.userBtn)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.profileBtn)
        Me.Panel2.Controls.Add(Me.postsBtn)
        Me.Panel2.Location = New System.Drawing.Point(13, 13)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.MaximumSize = New System.Drawing.Size(226, 652)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(209, 607)
        Me.Panel2.TabIndex = 6
        '
        'Posts
        '
        Me.Posts.AutoSize = True
        Me.Posts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Posts.ForeColor = System.Drawing.Color.MintCream
        Me.Posts.Location = New System.Drawing.Point(77, 163)
        Me.Posts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Posts.Name = "Posts"
        Me.Posts.Size = New System.Drawing.Size(57, 20)
        Me.Posts.TabIndex = 44
        Me.Posts.Text = "Posts"
        Me.Posts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Halls
        '
        Me.Halls.AutoSize = True
        Me.Halls.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Halls.ForeColor = System.Drawing.Color.MintCream
        Me.Halls.Location = New System.Drawing.Point(77, 221)
        Me.Halls.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Halls.Name = "Halls"
        Me.Halls.Size = New System.Drawing.Size(53, 20)
        Me.Halls.TabIndex = 43
        Me.Halls.Text = "Halls"
        Me.Halls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Users
        '
        Me.Users.AutoSize = True
        Me.Users.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Users.ForeColor = System.Drawing.Color.MintCream
        Me.Users.Location = New System.Drawing.Point(77, 279)
        Me.Users.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Users.Name = "Users"
        Me.Users.Size = New System.Drawing.Size(59, 20)
        Me.Users.TabIndex = 42
        Me.Users.Text = "Users"
        Me.Users.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Roleslabel
        '
        Me.Roleslabel.AutoSize = True
        Me.Roleslabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roleslabel.ForeColor = System.Drawing.Color.MintCream
        Me.Roleslabel.Location = New System.Drawing.Point(77, 337)
        Me.Roleslabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Roleslabel.Name = "Roleslabel"
        Me.Roleslabel.Size = New System.Drawing.Size(57, 20)
        Me.Roleslabel.TabIndex = 41
        Me.Roleslabel.Text = "Roles"
        Me.Roleslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'profile
        '
        Me.profile.AutoSize = True
        Me.profile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profile.ForeColor = System.Drawing.Color.MintCream
        Me.profile.Location = New System.Drawing.Point(77, 108)
        Me.profile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.profile.Name = "profile"
        Me.profile.Size = New System.Drawing.Size(64, 20)
        Me.profile.TabIndex = 36
        Me.profile.Text = "Profile"
        Me.profile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.MintCream
        Me.Label5.Location = New System.Drawing.Point(55, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 29)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Admin"
        '
        'rolesBtn
        '
        Me.rolesBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.rolesBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.rolesBtn.FlatAppearance.BorderSize = 0
        Me.rolesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rolesBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.rolesBtn.ForeColor = System.Drawing.Color.MintCream
        Me.rolesBtn.Location = New System.Drawing.Point(0, 318)
        Me.rolesBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.rolesBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.rolesBtn.Name = "rolesBtn"
        Me.rolesBtn.Size = New System.Drawing.Size(208, 58)
        Me.rolesBtn.TabIndex = 16
        Me.rolesBtn.UseVisualStyleBackColor = False
        '
        'hallsBtn
        '
        Me.hallsBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.hallsBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.hallsBtn.FlatAppearance.BorderSize = 0
        Me.hallsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hallsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.hallsBtn.ForeColor = System.Drawing.Color.MintCream
        Me.hallsBtn.Location = New System.Drawing.Point(1, 202)
        Me.hallsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.hallsBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.hallsBtn.Name = "hallsBtn"
        Me.hallsBtn.Size = New System.Drawing.Size(208, 58)
        Me.hallsBtn.TabIndex = 15
        Me.hallsBtn.UseVisualStyleBackColor = False
        '
        'userBtn
        '
        Me.userBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.userBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.userBtn.FlatAppearance.BorderSize = 0
        Me.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.userBtn.ForeColor = System.Drawing.Color.MintCream
        Me.userBtn.Location = New System.Drawing.Point(0, 260)
        Me.userBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.userBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.userBtn.Name = "userBtn"
        Me.userBtn.Size = New System.Drawing.Size(208, 58)
        Me.userBtn.TabIndex = 14
        Me.userBtn.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(-1, 267)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.MaximumSize = New System.Drawing.Size(208, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(208, 58)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Posts"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'profileBtn
        '
        Me.profileBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.profileBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.profileBtn.FlatAppearance.BorderSize = 0
        Me.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.profileBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.profileBtn.ForeColor = System.Drawing.Color.MintCream
        Me.profileBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.profileBtn.Location = New System.Drawing.Point(0, 87)
        Me.profileBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.profileBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.profileBtn.Name = "profileBtn"
        Me.profileBtn.Size = New System.Drawing.Size(208, 58)
        Me.profileBtn.TabIndex = 10
        Me.profileBtn.UseVisualStyleBackColor = False
        '
        'aName
        '
        Me.aName.AutoSize = True
        Me.aName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.aName.ForeColor = System.Drawing.Color.SeaGreen
        Me.aName.Location = New System.Drawing.Point(32, 54)
        Me.aName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.aName.Name = "aName"
        Me.aName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.aName.Size = New System.Drawing.Size(58, 24)
        Me.aName.TabIndex = 5
        Me.aName.Text = "******"
        Me.aName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(4, 119)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(267, 123)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'adminHeader
        '
        Me.adminHeader.BackColor = System.Drawing.Color.Transparent
        Me.adminHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adminHeader.Controls.Add(Me.adminLogout)
        Me.adminHeader.Controls.Add(Me.PictureBox1)
        Me.adminHeader.Controls.Add(Me.aName)
        Me.adminHeader.Controls.Add(Me.FlowLayoutPanel1)
        Me.adminHeader.Location = New System.Drawing.Point(231, 13)
        Me.adminHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.adminHeader.Name = "adminHeader"
        Me.adminHeader.Size = New System.Drawing.Size(932, 78)
        Me.adminHeader.TabIndex = 5
        '
        'adminLogout
        '
        Me.adminLogout.BackColor = System.Drawing.Color.Transparent
        Me.adminLogout.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.adminLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.adminLogout.ForeColor = System.Drawing.Color.SeaGreen
        Me.adminLogout.Location = New System.Drawing.Point(803, 23)
        Me.adminLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.adminLogout.MaximumSize = New System.Drawing.Size(208, 62)
        Me.adminLogout.Name = "adminLogout"
        Me.adminLogout.Size = New System.Drawing.Size(76, 27)
        Me.adminLogout.TabIndex = 37
        Me.adminLogout.Text = "Logout"
        Me.adminLogout.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cems.My.Resources.Resources.logo_light
        Me.PictureBox1.Location = New System.Drawing.Point(30, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'Timer2
        '
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
        'adminHomePagePanel
        '
        Me.adminHomePagePanel.BackColor = System.Drawing.Color.Transparent
        Me.adminHomePagePanel.Controls.Add(Me.CPUsBtn2)
        Me.adminHomePagePanel.Controls.Add(Me.IPsBtn2)
        Me.adminHomePagePanel.Controls.Add(Me.monitorsBtn2)
        Me.adminHomePagePanel.Controls.Add(Me.usersBtn2)
        Me.adminHomePagePanel.Controls.Add(Me.Label38)
        Me.adminHomePagePanel.Controls.Add(Me.Label37)
        Me.adminHomePagePanel.Controls.Add(Me.Label36)
        Me.adminHomePagePanel.Controls.Add(Me.Label2)
        Me.adminHomePagePanel.Controls.Add(Me.userNumber)
        Me.adminHomePagePanel.Controls.Add(Me.userbuttoninactive)
        Me.adminHomePagePanel.Controls.Add(Me.nonActiveMonitorNumber)
        Me.adminHomePagePanel.Controls.Add(Me.activeMonitorNumber)
        Me.adminHomePagePanel.Controls.Add(Me.nonActiveIPNumber)
        Me.adminHomePagePanel.Controls.Add(Me.activeIPNumber)
        Me.adminHomePagePanel.Controls.Add(Me.nonActiveCPUNumber)
        Me.adminHomePagePanel.Controls.Add(Me.activeCPUNumber)
        Me.adminHomePagePanel.Controls.Add(Me.monitorbuttoninactive)
        Me.adminHomePagePanel.Controls.Add(Me.IPbuttoninactive)
        Me.adminHomePagePanel.Controls.Add(Me.CPUbuttoninactive)
        Me.adminHomePagePanel.Controls.Add(Me.Label1)
        Me.adminHomePagePanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminHomePagePanel.ForeColor = System.Drawing.Color.Yellow
        Me.adminHomePagePanel.Location = New System.Drawing.Point(229, 100)
        Me.adminHomePagePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.adminHomePagePanel.Name = "adminHomePagePanel"
        Me.adminHomePagePanel.Size = New System.Drawing.Size(934, 507)
        Me.adminHomePagePanel.TabIndex = 9
        '
        'userNumber
        '
        Me.userNumber.AutoSize = True
        Me.userNumber.BackColor = System.Drawing.Color.MintCream
        Me.userNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.userNumber.ForeColor = System.Drawing.Color.SeaGreen
        Me.userNumber.Location = New System.Drawing.Point(724, 234)
        Me.userNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userNumber.Name = "userNumber"
        Me.userNumber.Size = New System.Drawing.Size(31, 13)
        Me.userNumber.TabIndex = 35
        Me.userNumber.Text = "0000"
        '
        'userbuttoninactive
        '
        Me.userbuttoninactive.BackColor = System.Drawing.Color.MintCream
        Me.userbuttoninactive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.userbuttoninactive.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.userbuttoninactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userbuttoninactive.Image = Global.cems.My.Resources.Resources.user1
        Me.userbuttoninactive.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.userbuttoninactive.Location = New System.Drawing.Point(716, 57)
        Me.userbuttoninactive.Margin = New System.Windows.Forms.Padding(4)
        Me.userbuttoninactive.Name = "userbuttoninactive"
        Me.userbuttoninactive.Padding = New System.Windows.Forms.Padding(13, 0, 13, 0)
        Me.userbuttoninactive.Size = New System.Drawing.Size(194, 201)
        Me.userbuttoninactive.TabIndex = 33
        Me.userbuttoninactive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.userbuttoninactive.UseVisualStyleBackColor = False
        '
        'nonActiveMonitorNumber
        '
        Me.nonActiveMonitorNumber.AutoSize = True
        Me.nonActiveMonitorNumber.BackColor = System.Drawing.Color.MintCream
        Me.nonActiveMonitorNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.nonActiveMonitorNumber.ForeColor = System.Drawing.Color.Red
        Me.nonActiveMonitorNumber.Location = New System.Drawing.Point(529, 234)
        Me.nonActiveMonitorNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nonActiveMonitorNumber.Name = "nonActiveMonitorNumber"
        Me.nonActiveMonitorNumber.Size = New System.Drawing.Size(31, 13)
        Me.nonActiveMonitorNumber.TabIndex = 32
        Me.nonActiveMonitorNumber.Text = "0000"
        '
        'activeMonitorNumber
        '
        Me.activeMonitorNumber.AutoSize = True
        Me.activeMonitorNumber.BackColor = System.Drawing.Color.MintCream
        Me.activeMonitorNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.activeMonitorNumber.ForeColor = System.Drawing.Color.SeaGreen
        Me.activeMonitorNumber.Location = New System.Drawing.Point(493, 234)
        Me.activeMonitorNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.activeMonitorNumber.Name = "activeMonitorNumber"
        Me.activeMonitorNumber.Size = New System.Drawing.Size(31, 13)
        Me.activeMonitorNumber.TabIndex = 31
        Me.activeMonitorNumber.Text = "0000"
        '
        'nonActiveIPNumber
        '
        Me.nonActiveIPNumber.AutoSize = True
        Me.nonActiveIPNumber.BackColor = System.Drawing.Color.MintCream
        Me.nonActiveIPNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.nonActiveIPNumber.ForeColor = System.Drawing.Color.Red
        Me.nonActiveIPNumber.Location = New System.Drawing.Point(295, 234)
        Me.nonActiveIPNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nonActiveIPNumber.Name = "nonActiveIPNumber"
        Me.nonActiveIPNumber.Size = New System.Drawing.Size(31, 13)
        Me.nonActiveIPNumber.TabIndex = 30
        Me.nonActiveIPNumber.Text = "0000"
        '
        'activeIPNumber
        '
        Me.activeIPNumber.AutoSize = True
        Me.activeIPNumber.BackColor = System.Drawing.Color.MintCream
        Me.activeIPNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.activeIPNumber.ForeColor = System.Drawing.Color.SeaGreen
        Me.activeIPNumber.Location = New System.Drawing.Point(258, 234)
        Me.activeIPNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.activeIPNumber.Name = "activeIPNumber"
        Me.activeIPNumber.Size = New System.Drawing.Size(31, 13)
        Me.activeIPNumber.TabIndex = 29
        Me.activeIPNumber.Text = "0000"
        '
        'nonActiveCPUNumber
        '
        Me.nonActiveCPUNumber.AutoSize = True
        Me.nonActiveCPUNumber.BackColor = System.Drawing.Color.Transparent
        Me.nonActiveCPUNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nonActiveCPUNumber.ForeColor = System.Drawing.Color.Red
        Me.nonActiveCPUNumber.Location = New System.Drawing.Point(72, 235)
        Me.nonActiveCPUNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nonActiveCPUNumber.Name = "nonActiveCPUNumber"
        Me.nonActiveCPUNumber.Size = New System.Drawing.Size(31, 13)
        Me.nonActiveCPUNumber.TabIndex = 28
        Me.nonActiveCPUNumber.Text = "0000"
        '
        'activeCPUNumber
        '
        Me.activeCPUNumber.AutoSize = True
        Me.activeCPUNumber.BackColor = System.Drawing.Color.Transparent
        Me.activeCPUNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activeCPUNumber.ForeColor = System.Drawing.Color.SeaGreen
        Me.activeCPUNumber.Location = New System.Drawing.Point(29, 235)
        Me.activeCPUNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.activeCPUNumber.Name = "activeCPUNumber"
        Me.activeCPUNumber.Size = New System.Drawing.Size(31, 13)
        Me.activeCPUNumber.TabIndex = 27
        Me.activeCPUNumber.Text = "0000"
        '
        'monitorbuttoninactive
        '
        Me.monitorbuttoninactive.BackColor = System.Drawing.Color.MintCream
        Me.monitorbuttoninactive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.monitorbuttoninactive.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.monitorbuttoninactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.monitorbuttoninactive.Image = Global.cems.My.Resources.Resources.computer
        Me.monitorbuttoninactive.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.monitorbuttoninactive.Location = New System.Drawing.Point(482, 57)
        Me.monitorbuttoninactive.Margin = New System.Windows.Forms.Padding(4)
        Me.monitorbuttoninactive.Name = "monitorbuttoninactive"
        Me.monitorbuttoninactive.Padding = New System.Windows.Forms.Padding(13, 0, 13, 0)
        Me.monitorbuttoninactive.Size = New System.Drawing.Size(194, 201)
        Me.monitorbuttoninactive.TabIndex = 26
        Me.monitorbuttoninactive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.monitorbuttoninactive.UseVisualStyleBackColor = False
        '
        'IPbuttoninactive
        '
        Me.IPbuttoninactive.BackColor = System.Drawing.Color.MintCream
        Me.IPbuttoninactive.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.IPbuttoninactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IPbuttoninactive.Image = Global.cems.My.Resources.Resources.landline
        Me.IPbuttoninactive.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.IPbuttoninactive.Location = New System.Drawing.Point(247, 57)
        Me.IPbuttoninactive.Margin = New System.Windows.Forms.Padding(4)
        Me.IPbuttoninactive.Name = "IPbuttoninactive"
        Me.IPbuttoninactive.Padding = New System.Windows.Forms.Padding(13, 0, 13, 0)
        Me.IPbuttoninactive.Size = New System.Drawing.Size(194, 201)
        Me.IPbuttoninactive.TabIndex = 25
        Me.IPbuttoninactive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IPbuttoninactive.UseVisualStyleBackColor = False
        '
        'CPUbuttoninactive
        '
        Me.CPUbuttoninactive.BackColor = System.Drawing.Color.MintCream
        Me.CPUbuttoninactive.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.CPUbuttoninactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CPUbuttoninactive.Image = Global.cems.My.Resources.Resources.unit
        Me.CPUbuttoninactive.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CPUbuttoninactive.Location = New System.Drawing.Point(21, 57)
        Me.CPUbuttoninactive.Margin = New System.Windows.Forms.Padding(4)
        Me.CPUbuttoninactive.Name = "CPUbuttoninactive"
        Me.CPUbuttoninactive.Padding = New System.Windows.Forms.Padding(13, 0, 13, 0)
        Me.CPUbuttoninactive.Size = New System.Drawing.Size(194, 201)
        Me.CPUbuttoninactive.TabIndex = 24
        Me.CPUbuttoninactive.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CPUbuttoninactive.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(16, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Categories of all equipments"
        '
        'adminEquipmentPanel
        '
        Me.adminEquipmentPanel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.adminEquipmentPanel.Controls.Add(Me.addEquipmentPanel)
        Me.adminEquipmentPanel.Controls.Add(Me.confirmMsgE)
        Me.adminEquipmentPanel.Controls.Add(Me.hallSearchBoxE)
        Me.adminEquipmentPanel.Controls.Add(Me.searchErrorE)
        Me.adminEquipmentPanel.Controls.Add(Me.printBtnE)
        Me.adminEquipmentPanel.Controls.Add(Me.exportBtnE)
        Me.adminEquipmentPanel.Controls.Add(Me.equipmentSearchBox)
        Me.adminEquipmentPanel.Controls.Add(Me.DataGridView1)
        Me.adminEquipmentPanel.Controls.Add(Me.EquipmentTitle)
        Me.adminEquipmentPanel.Controls.Add(Me.statePanel)
        Me.adminEquipmentPanel.Controls.Add(Me.addEquipmentBtn)
        Me.adminEquipmentPanel.Controls.Add(Me.Label33)
        Me.adminEquipmentPanel.Controls.Add(Me.Label34)
        Me.adminEquipmentPanel.Controls.Add(Me.Label35)
        Me.adminEquipmentPanel.Controls.Add(Me.userSearchBoxE)
        Me.adminEquipmentPanel.Location = New System.Drawing.Point(208, 569)
        Me.adminEquipmentPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.adminEquipmentPanel.Name = "adminEquipmentPanel"
        Me.adminEquipmentPanel.Size = New System.Drawing.Size(967, 40)
        Me.adminEquipmentPanel.TabIndex = 38
        Me.adminEquipmentPanel.Visible = False
        '
        'addEquipmentPanel
        '
        Me.addEquipmentPanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.addEquipmentPanel.Controls.Add(Me.postIdInput)
        Me.addEquipmentPanel.Controls.Add(Me.equipmentStateInput)
        Me.addEquipmentPanel.Controls.Add(Me.equipmentTypeInput)
        Me.addEquipmentPanel.Controls.Add(Me.addEquipmentErrorMsg)
        Me.addEquipmentPanel.Controls.Add(Me.hallInput)
        Me.addEquipmentPanel.Controls.Add(Me.Label23)
        Me.addEquipmentPanel.Controls.Add(Me.Label25)
        Me.addEquipmentPanel.Controls.Add(Me.Label26)
        Me.addEquipmentPanel.Controls.Add(Me.addEquipmentCancelBtn)
        Me.addEquipmentPanel.Controls.Add(Me.addEquipmentValidationBtn)
        Me.addEquipmentPanel.Controls.Add(Me.Label27)
        Me.addEquipmentPanel.Location = New System.Drawing.Point(67, 133)
        Me.addEquipmentPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.addEquipmentPanel.Name = "addEquipmentPanel"
        Me.addEquipmentPanel.Size = New System.Drawing.Size(845, 346)
        Me.addEquipmentPanel.TabIndex = 70
        Me.addEquipmentPanel.Visible = False
        '
        'postIdInput
        '
        Me.postIdInput.FormattingEnabled = True
        Me.postIdInput.Location = New System.Drawing.Point(359, 110)
        Me.postIdInput.Margin = New System.Windows.Forms.Padding(4)
        Me.postIdInput.Name = "postIdInput"
        Me.postIdInput.Size = New System.Drawing.Size(239, 24)
        Me.postIdInput.TabIndex = 61
        '
        'equipmentStateInput
        '
        Me.equipmentStateInput.FormattingEnabled = True
        Me.equipmentStateInput.Items.AddRange(New Object() {"Good", "Bad", "In reparation"})
        Me.equipmentStateInput.Location = New System.Drawing.Point(359, 74)
        Me.equipmentStateInput.Margin = New System.Windows.Forms.Padding(4)
        Me.equipmentStateInput.Name = "equipmentStateInput"
        Me.equipmentStateInput.Size = New System.Drawing.Size(239, 24)
        Me.equipmentStateInput.TabIndex = 60
        '
        'equipmentTypeInput
        '
        Me.equipmentTypeInput.FormattingEnabled = True
        Me.equipmentTypeInput.Items.AddRange(New Object() {"IP_Phone", "Monitor", "CPU"})
        Me.equipmentTypeInput.Location = New System.Drawing.Point(359, 38)
        Me.equipmentTypeInput.Margin = New System.Windows.Forms.Padding(4)
        Me.equipmentTypeInput.Name = "equipmentTypeInput"
        Me.equipmentTypeInput.Size = New System.Drawing.Size(239, 24)
        Me.equipmentTypeInput.TabIndex = 59
        '
        'addEquipmentErrorMsg
        '
        Me.addEquipmentErrorMsg.AutoSize = True
        Me.addEquipmentErrorMsg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.addEquipmentErrorMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEquipmentErrorMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addEquipmentErrorMsg.Location = New System.Drawing.Point(75, 290)
        Me.addEquipmentErrorMsg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.addEquipmentErrorMsg.Name = "addEquipmentErrorMsg"
        Me.addEquipmentErrorMsg.Size = New System.Drawing.Size(0, 18)
        Me.addEquipmentErrorMsg.TabIndex = 58
        Me.addEquipmentErrorMsg.Visible = False
        '
        'hallInput
        '
        Me.hallInput.FormattingEnabled = True
        Me.hallInput.Location = New System.Drawing.Point(359, 144)
        Me.hallInput.Margin = New System.Windows.Forms.Padding(4)
        Me.hallInput.Name = "hallInput"
        Me.hallInput.Size = New System.Drawing.Size(239, 24)
        Me.hallInput.TabIndex = 47
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(71, 142)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 25)
        Me.Label23.TabIndex = 52
        Me.Label23.Text = "hall:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(71, 107)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(83, 25)
        Me.Label25.TabIndex = 50
        Me.Label25.Text = "post id:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(71, 71)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(172, 25)
        Me.Label26.TabIndex = 48
        Me.Label26.Text = "equipment state:"
        '
        'addEquipmentCancelBtn
        '
        Me.addEquipmentCancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.addEquipmentCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.addEquipmentCancelBtn.FlatAppearance.BorderSize = 0
        Me.addEquipmentCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addEquipmentCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.addEquipmentCancelBtn.Location = New System.Drawing.Point(493, 277)
        Me.addEquipmentCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.addEquipmentCancelBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.addEquipmentCancelBtn.Name = "addEquipmentCancelBtn"
        Me.addEquipmentCancelBtn.Size = New System.Drawing.Size(105, 39)
        Me.addEquipmentCancelBtn.TabIndex = 44
        Me.addEquipmentCancelBtn.Text = "Cancel"
        Me.addEquipmentCancelBtn.UseVisualStyleBackColor = False
        '
        'addEquipmentValidationBtn
        '
        Me.addEquipmentValidationBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.addEquipmentValidationBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.addEquipmentValidationBtn.FlatAppearance.BorderSize = 0
        Me.addEquipmentValidationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addEquipmentValidationBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.addEquipmentValidationBtn.Location = New System.Drawing.Point(623, 277)
        Me.addEquipmentValidationBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.addEquipmentValidationBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.addEquipmentValidationBtn.Name = "addEquipmentValidationBtn"
        Me.addEquipmentValidationBtn.Size = New System.Drawing.Size(127, 39)
        Me.addEquipmentValidationBtn.TabIndex = 13
        Me.addEquipmentValidationBtn.Text = "Add"
        Me.addEquipmentValidationBtn.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(71, 36)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(166, 25)
        Me.Label27.TabIndex = 11
        Me.Label27.Text = "equipment type:"
        '
        'confirmMsgE
        '
        Me.confirmMsgE.AutoSize = True
        Me.confirmMsgE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.confirmMsgE.ForeColor = System.Drawing.Color.LimeGreen
        Me.confirmMsgE.Location = New System.Drawing.Point(689, 21)
        Me.confirmMsgE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.confirmMsgE.Name = "confirmMsgE"
        Me.confirmMsgE.Size = New System.Drawing.Size(177, 20)
        Me.confirmMsgE.TabIndex = 41
        Me.confirmMsgE.Text = "Export successfull ✔"
        Me.confirmMsgE.Visible = False
        '
        'hallSearchBoxE
        '
        Me.hallSearchBoxE.FormattingEnabled = True
        Me.hallSearchBoxE.Location = New System.Drawing.Point(296, 76)
        Me.hallSearchBoxE.Margin = New System.Windows.Forms.Padding(4)
        Me.hallSearchBoxE.Name = "hallSearchBoxE"
        Me.hallSearchBoxE.Size = New System.Drawing.Size(105, 24)
        Me.hallSearchBoxE.TabIndex = 38
        '
        'searchErrorE
        '
        Me.searchErrorE.AutoSize = True
        Me.searchErrorE.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.25!, System.Drawing.FontStyle.Bold)
        Me.searchErrorE.Location = New System.Drawing.Point(272, 245)
        Me.searchErrorE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.searchErrorE.Name = "searchErrorE"
        Me.searchErrorE.Size = New System.Drawing.Size(349, 47)
        Me.searchErrorE.TabIndex = 35
        Me.searchErrorE.Text = "No results found "
        Me.searchErrorE.Visible = False
        '
        'printBtnE
        '
        Me.printBtnE.Image = Global.cems.My.Resources.Resources.print__1_
        Me.printBtnE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.printBtnE.Location = New System.Drawing.Point(808, 73)
        Me.printBtnE.Margin = New System.Windows.Forms.Padding(4)
        Me.printBtnE.Name = "printBtnE"
        Me.printBtnE.Size = New System.Drawing.Size(100, 28)
        Me.printBtnE.TabIndex = 34
        Me.printBtnE.Text = "Print"
        Me.printBtnE.UseVisualStyleBackColor = True
        '
        'exportBtnE
        '
        Me.exportBtnE.Image = Global.cems.My.Resources.Resources.export
        Me.exportBtnE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exportBtnE.Location = New System.Drawing.Point(700, 73)
        Me.exportBtnE.Margin = New System.Windows.Forms.Padding(4)
        Me.exportBtnE.Name = "exportBtnE"
        Me.exportBtnE.Size = New System.Drawing.Size(100, 28)
        Me.exportBtnE.TabIndex = 33
        Me.exportBtnE.Text = "Export"
        Me.exportBtnE.UseVisualStyleBackColor = True
        '
        'equipmentSearchBox
        '
        Me.equipmentSearchBox.ForeColor = System.Drawing.Color.DarkGray
        Me.equipmentSearchBox.Location = New System.Drawing.Point(189, 76)
        Me.equipmentSearchBox.Margin = New System.Windows.Forms.Padding(4)
        Me.equipmentSearchBox.Name = "equipmentSearchBox"
        Me.equipmentSearchBox.Size = New System.Drawing.Size(49, 22)
        Me.equipmentSearchBox.TabIndex = 32
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(67, 133)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(665, 290)
        Me.DataGridView1.TabIndex = 31
        '
        'EquipmentTitle
        '
        Me.EquipmentTitle.AutoSize = True
        Me.EquipmentTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipmentTitle.Location = New System.Drawing.Point(71, 32)
        Me.EquipmentTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EquipmentTitle.Name = "EquipmentTitle"
        Me.EquipmentTitle.Size = New System.Drawing.Size(79, 29)
        Me.EquipmentTitle.TabIndex = 30
        Me.EquipmentTitle.Text = "CPUs"
        '
        'statePanel
        '
        Me.statePanel.Controls.Add(Me.stateChangeBtn)
        Me.statePanel.Controls.Add(Me.equipmentDeleteBtn)
        Me.statePanel.Controls.Add(Me.Label13)
        Me.statePanel.Controls.Add(Me.equipmentState)
        Me.statePanel.Location = New System.Drawing.Point(749, 137)
        Me.statePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.statePanel.Name = "statePanel"
        Me.statePanel.Size = New System.Drawing.Size(195, 158)
        Me.statePanel.TabIndex = 44
        Me.statePanel.Visible = False
        '
        'stateChangeBtn
        '
        Me.stateChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stateChangeBtn.Location = New System.Drawing.Point(19, 86)
        Me.stateChangeBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.stateChangeBtn.Name = "stateChangeBtn"
        Me.stateChangeBtn.Size = New System.Drawing.Size(161, 28)
        Me.stateChangeBtn.TabIndex = 67
        Me.stateChangeBtn.Text = "Change"
        Me.stateChangeBtn.UseVisualStyleBackColor = True
        '
        'equipmentDeleteBtn
        '
        Me.equipmentDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.equipmentDeleteBtn.Location = New System.Drawing.Point(19, 122)
        Me.equipmentDeleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.equipmentDeleteBtn.Name = "equipmentDeleteBtn"
        Me.equipmentDeleteBtn.Size = New System.Drawing.Size(161, 28)
        Me.equipmentDeleteBtn.TabIndex = 66
        Me.equipmentDeleteBtn.Text = "Delete"
        Me.equipmentDeleteBtn.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(0, 34)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 24)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "state:"
        '
        'equipmentState
        '
        Me.equipmentState.FormattingEnabled = True
        Me.equipmentState.Items.AddRange(New Object() {"Good", "Bad", "In reparation"})
        Me.equipmentState.Location = New System.Drawing.Point(88, 32)
        Me.equipmentState.Margin = New System.Windows.Forms.Padding(4)
        Me.equipmentState.Name = "equipmentState"
        Me.equipmentState.Size = New System.Drawing.Size(105, 24)
        Me.equipmentState.TabIndex = 42
        '
        'addEquipmentBtn
        '
        Me.addEquipmentBtn.Image = Global.cems.My.Resources.Resources.plus
        Me.addEquipmentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addEquipmentBtn.Location = New System.Drawing.Point(596, 73)
        Me.addEquipmentBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.addEquipmentBtn.Name = "addEquipmentBtn"
        Me.addEquipmentBtn.Size = New System.Drawing.Size(100, 28)
        Me.addEquipmentBtn.TabIndex = 60
        Me.addEquipmentBtn.Text = "Add"
        Me.addEquipmentBtn.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(407, 76)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(53, 24)
        Me.Label33.TabIndex = 68
        Me.Label33.Text = "state:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(243, 79)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(44, 24)
        Me.Label34.TabIndex = 69
        Me.Label34.Text = "hall:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(93, 76)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(70, 24)
        Me.Label35.TabIndex = 67
        Me.Label35.Text = "post id:"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'userSearchBoxE
        '
        Me.userSearchBoxE.FormattingEnabled = True
        Me.userSearchBoxE.Location = New System.Drawing.Point(484, 75)
        Me.userSearchBoxE.Margin = New System.Windows.Forms.Padding(4)
        Me.userSearchBoxE.Name = "userSearchBoxE"
        Me.userSearchBoxE.Size = New System.Drawing.Size(104, 24)
        Me.userSearchBoxE.TabIndex = 66
        '
        'adminPostPanel
        '
        Me.adminPostPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.adminPostPanel.Controls.Add(Me.addPostPanel)
        Me.adminPostPanel.Controls.Add(Me.confirmMsgP)
        Me.adminPostPanel.Controls.Add(Me.hallSearchBoxP)
        Me.adminPostPanel.Controls.Add(Me.searchErrorP)
        Me.adminPostPanel.Controls.Add(Me.printBtnP)
        Me.adminPostPanel.Controls.Add(Me.exportBtnP)
        Me.adminPostPanel.Controls.Add(Me.postSearchBox)
        Me.adminPostPanel.Controls.Add(Me.DataGridView2)
        Me.adminPostPanel.Controls.Add(Me.postTitle)
        Me.adminPostPanel.Controls.Add(Me.postChangeStatePanel)
        Me.adminPostPanel.Controls.Add(Me.addPostBtn)
        Me.adminPostPanel.Controls.Add(Me.Label32)
        Me.adminPostPanel.Controls.Add(Me.Label30)
        Me.adminPostPanel.Controls.Add(Me.Label22)
        Me.adminPostPanel.Controls.Add(Me.stateSearchBoxP)
        Me.adminPostPanel.Location = New System.Drawing.Point(208, 590)
        Me.adminPostPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.adminPostPanel.Name = "adminPostPanel"
        Me.adminPostPanel.Size = New System.Drawing.Size(967, 19)
        Me.adminPostPanel.TabIndex = 62
        Me.adminPostPanel.Visible = False
        '
        'addPostPanel
        '
        Me.addPostPanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.addPostPanel.Controls.Add(Me.postPostIdInput)
        Me.addPostPanel.Controls.Add(Me.Label19)
        Me.addPostPanel.Controls.Add(Me.postStateInput)
        Me.addPostPanel.Controls.Add(Me.addPostErrorMsg)
        Me.addPostPanel.Controls.Add(Me.postHallInput)
        Me.addPostPanel.Controls.Add(Me.Label20)
        Me.addPostPanel.Controls.Add(Me.Label29)
        Me.addPostPanel.Controls.Add(Me.addPostCancelBtn)
        Me.addPostPanel.Controls.Add(Me.addPostValidationBtn)
        Me.addPostPanel.Location = New System.Drawing.Point(81, 130)
        Me.addPostPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.addPostPanel.Name = "addPostPanel"
        Me.addPostPanel.Size = New System.Drawing.Size(832, 329)
        Me.addPostPanel.TabIndex = 66
        Me.addPostPanel.Visible = False
        '
        'postPostIdInput
        '
        Me.postPostIdInput.Location = New System.Drawing.Point(360, 43)
        Me.postPostIdInput.Margin = New System.Windows.Forms.Padding(4)
        Me.postPostIdInput.Name = "postPostIdInput"
        Me.postPostIdInput.Size = New System.Drawing.Size(237, 22)
        Me.postPostIdInput.TabIndex = 62
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(72, 37)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 25)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "Post ID:"
        '
        'postStateInput
        '
        Me.postStateInput.FormattingEnabled = True
        Me.postStateInput.Items.AddRange(New Object() {"Good", "Bad", "In reparation"})
        Me.postStateInput.Location = New System.Drawing.Point(360, 91)
        Me.postStateInput.Margin = New System.Windows.Forms.Padding(4)
        Me.postStateInput.Name = "postStateInput"
        Me.postStateInput.Size = New System.Drawing.Size(239, 24)
        Me.postStateInput.TabIndex = 60
        '
        'addPostErrorMsg
        '
        Me.addPostErrorMsg.AutoSize = True
        Me.addPostErrorMsg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.addPostErrorMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addPostErrorMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addPostErrorMsg.Location = New System.Drawing.Point(75, 290)
        Me.addPostErrorMsg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.addPostErrorMsg.Name = "addPostErrorMsg"
        Me.addPostErrorMsg.Size = New System.Drawing.Size(0, 18)
        Me.addPostErrorMsg.TabIndex = 58
        Me.addPostErrorMsg.Visible = False
        '
        'postHallInput
        '
        Me.postHallInput.FormattingEnabled = True
        Me.postHallInput.Location = New System.Drawing.Point(360, 144)
        Me.postHallInput.Margin = New System.Windows.Forms.Padding(4)
        Me.postHallInput.Name = "postHallInput"
        Me.postHallInput.Size = New System.Drawing.Size(239, 24)
        Me.postHallInput.TabIndex = 47
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(72, 142)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 25)
        Me.Label20.TabIndex = 52
        Me.Label20.Text = "hall:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(72, 89)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(115, 25)
        Me.Label29.TabIndex = 48
        Me.Label29.Text = "Post state:"
        '
        'addPostCancelBtn
        '
        Me.addPostCancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.addPostCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.addPostCancelBtn.FlatAppearance.BorderSize = 0
        Me.addPostCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addPostCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.addPostCancelBtn.Location = New System.Drawing.Point(493, 277)
        Me.addPostCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.addPostCancelBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.addPostCancelBtn.Name = "addPostCancelBtn"
        Me.addPostCancelBtn.Size = New System.Drawing.Size(105, 39)
        Me.addPostCancelBtn.TabIndex = 44
        Me.addPostCancelBtn.Text = "Cancel"
        Me.addPostCancelBtn.UseVisualStyleBackColor = False
        '
        'addPostValidationBtn
        '
        Me.addPostValidationBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.addPostValidationBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.addPostValidationBtn.FlatAppearance.BorderSize = 0
        Me.addPostValidationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addPostValidationBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.addPostValidationBtn.Location = New System.Drawing.Point(623, 277)
        Me.addPostValidationBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.addPostValidationBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.addPostValidationBtn.Name = "addPostValidationBtn"
        Me.addPostValidationBtn.Size = New System.Drawing.Size(127, 39)
        Me.addPostValidationBtn.TabIndex = 13
        Me.addPostValidationBtn.Text = "Add"
        Me.addPostValidationBtn.UseVisualStyleBackColor = False
        '
        'confirmMsgP
        '
        Me.confirmMsgP.AutoSize = True
        Me.confirmMsgP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.confirmMsgP.ForeColor = System.Drawing.Color.LimeGreen
        Me.confirmMsgP.Location = New System.Drawing.Point(693, 21)
        Me.confirmMsgP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.confirmMsgP.Name = "confirmMsgP"
        Me.confirmMsgP.Size = New System.Drawing.Size(177, 20)
        Me.confirmMsgP.TabIndex = 41
        Me.confirmMsgP.Text = "Export successfull ✔"
        Me.confirmMsgP.Visible = False
        '
        'hallSearchBoxP
        '
        Me.hallSearchBoxP.FormattingEnabled = True
        Me.hallSearchBoxP.Location = New System.Drawing.Point(340, 68)
        Me.hallSearchBoxP.Margin = New System.Windows.Forms.Padding(4)
        Me.hallSearchBoxP.Name = "hallSearchBoxP"
        Me.hallSearchBoxP.Size = New System.Drawing.Size(104, 24)
        Me.hallSearchBoxP.TabIndex = 37
        '
        'searchErrorP
        '
        Me.searchErrorP.AutoSize = True
        Me.searchErrorP.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.25!, System.Drawing.FontStyle.Bold)
        Me.searchErrorP.Location = New System.Drawing.Point(296, 277)
        Me.searchErrorP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.searchErrorP.Name = "searchErrorP"
        Me.searchErrorP.Size = New System.Drawing.Size(349, 47)
        Me.searchErrorP.TabIndex = 36
        Me.searchErrorP.Text = "No results found "
        Me.searchErrorP.Visible = False
        '
        'printBtnP
        '
        Me.printBtnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printBtnP.Image = Global.cems.My.Resources.Resources.print__1_
        Me.printBtnP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.printBtnP.Location = New System.Drawing.Point(860, 68)
        Me.printBtnP.Margin = New System.Windows.Forms.Padding(4)
        Me.printBtnP.Name = "printBtnP"
        Me.printBtnP.Size = New System.Drawing.Size(100, 28)
        Me.printBtnP.TabIndex = 33
        Me.printBtnP.Text = "Print"
        Me.printBtnP.UseVisualStyleBackColor = True
        '
        'exportBtnP
        '
        Me.exportBtnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exportBtnP.Image = Global.cems.My.Resources.Resources.export
        Me.exportBtnP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exportBtnP.Location = New System.Drawing.Point(749, 68)
        Me.exportBtnP.Margin = New System.Windows.Forms.Padding(4)
        Me.exportBtnP.Name = "exportBtnP"
        Me.exportBtnP.Size = New System.Drawing.Size(100, 28)
        Me.exportBtnP.TabIndex = 32
        Me.exportBtnP.Text = "Export"
        Me.exportBtnP.UseVisualStyleBackColor = True
        '
        'postSearchBox
        '
        Me.postSearchBox.ForeColor = System.Drawing.Color.DarkGray
        Me.postSearchBox.Location = New System.Drawing.Point(225, 68)
        Me.postSearchBox.Margin = New System.Windows.Forms.Padding(4)
        Me.postSearchBox.Name = "postSearchBox"
        Me.postSearchBox.Size = New System.Drawing.Size(63, 22)
        Me.postSearchBox.TabIndex = 31
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(81, 133)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(660, 290)
        Me.DataGridView2.TabIndex = 30
        '
        'postTitle
        '
        Me.postTitle.AutoSize = True
        Me.postTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.postTitle.Location = New System.Drawing.Point(80, 32)
        Me.postTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.postTitle.Name = "postTitle"
        Me.postTitle.Size = New System.Drawing.Size(78, 29)
        Me.postTitle.TabIndex = 29
        Me.postTitle.Text = "Posts"
        '
        'postChangeStatePanel
        '
        Me.postChangeStatePanel.Controls.Add(Me.postDeleteBtn)
        Me.postChangeStatePanel.Controls.Add(Me.postChangeBtn)
        Me.postChangeStatePanel.Controls.Add(Me.Label31)
        Me.postChangeStatePanel.Controls.Add(Me.postChangeStateInput)
        Me.postChangeStatePanel.Location = New System.Drawing.Point(763, 153)
        Me.postChangeStatePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.postChangeStatePanel.Name = "postChangeStatePanel"
        Me.postChangeStatePanel.Size = New System.Drawing.Size(195, 158)
        Me.postChangeStatePanel.TabIndex = 61
        Me.postChangeStatePanel.Visible = False
        '
        'postDeleteBtn
        '
        Me.postDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.postDeleteBtn.Location = New System.Drawing.Point(16, 118)
        Me.postDeleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.postDeleteBtn.Name = "postDeleteBtn"
        Me.postDeleteBtn.Size = New System.Drawing.Size(161, 28)
        Me.postDeleteBtn.TabIndex = 65
        Me.postDeleteBtn.Text = "Delete"
        Me.postDeleteBtn.UseVisualStyleBackColor = True
        '
        'postChangeBtn
        '
        Me.postChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.postChangeBtn.Location = New System.Drawing.Point(16, 81)
        Me.postChangeBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.postChangeBtn.Name = "postChangeBtn"
        Me.postChangeBtn.Size = New System.Drawing.Size(161, 28)
        Me.postChangeBtn.TabIndex = 64
        Me.postChangeBtn.Text = "Change"
        Me.postChangeBtn.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label31.Location = New System.Drawing.Point(0, 34)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(59, 24)
        Me.Label31.TabIndex = 38
        Me.Label31.Text = "state:"
        '
        'postChangeStateInput
        '
        Me.postChangeStateInput.FormattingEnabled = True
        Me.postChangeStateInput.Items.AddRange(New Object() {"Good", "Bad", "In reparation"})
        Me.postChangeStateInput.Location = New System.Drawing.Point(88, 32)
        Me.postChangeStateInput.Margin = New System.Windows.Forms.Padding(4)
        Me.postChangeStateInput.Name = "postChangeStateInput"
        Me.postChangeStateInput.Size = New System.Drawing.Size(105, 24)
        Me.postChangeStateInput.TabIndex = 42
        '
        'addPostBtn
        '
        Me.addPostBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addPostBtn.Image = Global.cems.My.Resources.Resources.plus
        Me.addPostBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addPostBtn.Location = New System.Drawing.Point(643, 69)
        Me.addPostBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.addPostBtn.Name = "addPostBtn"
        Me.addPostBtn.Size = New System.Drawing.Size(100, 28)
        Me.addPostBtn.TabIndex = 63
        Me.addPostBtn.Text = "Add"
        Me.addPostBtn.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(447, 70)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(53, 24)
        Me.Label32.TabIndex = 65
        Me.Label32.Text = "state:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(285, 69)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(44, 24)
        Me.Label30.TabIndex = 65
        Me.Label30.Text = "hall:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(133, 69)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(70, 24)
        Me.Label22.TabIndex = 64
        Me.Label22.Text = "post id:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'stateSearchBoxP
        '
        Me.stateSearchBoxP.FormattingEnabled = True
        Me.stateSearchBoxP.Location = New System.Drawing.Point(527, 69)
        Me.stateSearchBoxP.Margin = New System.Windows.Forms.Padding(4)
        Me.stateSearchBoxP.Name = "stateSearchBoxP"
        Me.stateSearchBoxP.Size = New System.Drawing.Size(104, 24)
        Me.stateSearchBoxP.TabIndex = 37
        '
        'adminProfilePanel
        '
        Me.adminProfilePanel.Controls.Add(Me.profileSubPanel2)
        Me.adminProfilePanel.Controls.Add(Me.profileSubPanel1)
        Me.adminProfilePanel.Controls.Add(Me.profileTitle)
        Me.adminProfilePanel.Location = New System.Drawing.Point(211, 490)
        Me.adminProfilePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.adminProfilePanel.Name = "adminProfilePanel"
        Me.adminProfilePanel.Size = New System.Drawing.Size(967, 120)
        Me.adminProfilePanel.TabIndex = 63
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
        Me.profileSubPanel2.Location = New System.Drawing.Point(89, 114)
        Me.profileSubPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.profileSubPanel2.Name = "profileSubPanel2"
        Me.profileSubPanel2.Size = New System.Drawing.Size(783, 310)
        Me.profileSubPanel2.TabIndex = 35
        Me.profileSubPanel2.Visible = False
        '
        'userConfirmPwdProfileInput
        '
        Me.userConfirmPwdProfileInput.Location = New System.Drawing.Point(399, 224)
        Me.userConfirmPwdProfileInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userConfirmPwdProfileInput.Name = "userConfirmPwdProfileInput"
        Me.userConfirmPwdProfileInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.userConfirmPwdProfileInput.Size = New System.Drawing.Size(239, 22)
        Me.userConfirmPwdProfileInput.TabIndex = 22
        '
        'userConfirmPwdProfileLabel
        '
        Me.userConfirmPwdProfileLabel.AutoSize = True
        Me.userConfirmPwdProfileLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userConfirmPwdProfileLabel.Location = New System.Drawing.Point(64, 222)
        Me.userConfirmPwdProfileLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userConfirmPwdProfileLabel.Name = "userConfirmPwdProfileLabel"
        Me.userConfirmPwdProfileLabel.Size = New System.Drawing.Size(192, 25)
        Me.userConfirmPwdProfileLabel.TabIndex = 21
        Me.userConfirmPwdProfileLabel.Text = "Confirm password:"
        '
        'updateProfileCancelBtn
        '
        Me.updateProfileCancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.updateProfileCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.updateProfileCancelBtn.FlatAppearance.BorderSize = 0
        Me.updateProfileCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateProfileCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.updateProfileCancelBtn.Location = New System.Drawing.Point(555, 265)
        Me.updateProfileCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.updateProfileCancelBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.updateProfileCancelBtn.Name = "updateProfileCancelBtn"
        Me.updateProfileCancelBtn.Size = New System.Drawing.Size(89, 27)
        Me.updateProfileCancelBtn.TabIndex = 20
        Me.updateProfileCancelBtn.Text = "Cancel"
        Me.updateProfileCancelBtn.UseVisualStyleBackColor = False
        '
        'updateProfileErrorMsg
        '
        Me.updateProfileErrorMsg.AutoSize = True
        Me.updateProfileErrorMsg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.updateProfileErrorMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateProfileErrorMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.updateProfileErrorMsg.Location = New System.Drawing.Point(200, 277)
        Me.updateProfileErrorMsg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.updateProfileErrorMsg.Name = "updateProfileErrorMsg"
        Me.updateProfileErrorMsg.Size = New System.Drawing.Size(0, 15)
        Me.updateProfileErrorMsg.TabIndex = 19
        Me.updateProfileErrorMsg.Visible = False
        '
        'userPwdProfileInput
        '
        Me.userPwdProfileInput.Location = New System.Drawing.Point(399, 185)
        Me.userPwdProfileInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userPwdProfileInput.Name = "userPwdProfileInput"
        Me.userPwdProfileInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.userPwdProfileInput.Size = New System.Drawing.Size(239, 22)
        Me.userPwdProfileInput.TabIndex = 18
        '
        'userPhoneNumberProfileInput
        '
        Me.userPhoneNumberProfileInput.Location = New System.Drawing.Point(399, 105)
        Me.userPhoneNumberProfileInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userPhoneNumberProfileInput.Name = "userPhoneNumberProfileInput"
        Me.userPhoneNumberProfileInput.Size = New System.Drawing.Size(239, 22)
        Me.userPhoneNumberProfileInput.TabIndex = 17
        '
        'userEmailProfileInput
        '
        Me.userEmailProfileInput.Location = New System.Drawing.Point(399, 63)
        Me.userEmailProfileInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userEmailProfileInput.Name = "userEmailProfileInput"
        Me.userEmailProfileInput.Size = New System.Drawing.Size(239, 22)
        Me.userEmailProfileInput.TabIndex = 16
        '
        'userNameProfileInput
        '
        Me.userNameProfileInput.Location = New System.Drawing.Point(399, 20)
        Me.userNameProfileInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userNameProfileInput.Name = "userNameProfileInput"
        Me.userNameProfileInput.Size = New System.Drawing.Size(239, 22)
        Me.userNameProfileInput.TabIndex = 15
        '
        'updateProfileValidateBtn
        '
        Me.updateProfileValidateBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.updateProfileValidateBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.updateProfileValidateBtn.FlatAppearance.BorderSize = 0
        Me.updateProfileValidateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateProfileValidateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.updateProfileValidateBtn.Location = New System.Drawing.Point(667, 265)
        Me.updateProfileValidateBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.updateProfileValidateBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.updateProfileValidateBtn.Name = "updateProfileValidateBtn"
        Me.updateProfileValidateBtn.Size = New System.Drawing.Size(89, 27)
        Me.updateProfileValidateBtn.TabIndex = 13
        Me.updateProfileValidateBtn.Text = "Done"
        Me.updateProfileValidateBtn.UseVisualStyleBackColor = False
        '
        'userEmailProfileLabel2
        '
        Me.userEmailProfileLabel2.AutoSize = True
        Me.userEmailProfileLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userEmailProfileLabel2.Location = New System.Drawing.Point(65, 59)
        Me.userEmailProfileLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userEmailProfileLabel2.Name = "userEmailProfileLabel2"
        Me.userEmailProfileLabel2.Size = New System.Drawing.Size(127, 25)
        Me.userEmailProfileLabel2.TabIndex = 11
        Me.userEmailProfileLabel2.Text = "User email :"
        '
        'userPhoneNumberProfileLabel2
        '
        Me.userPhoneNumberProfileLabel2.AutoSize = True
        Me.userPhoneNumberProfileLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userPhoneNumberProfileLabel2.Location = New System.Drawing.Point(65, 102)
        Me.userPhoneNumberProfileLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userPhoneNumberProfileLabel2.Name = "userPhoneNumberProfileLabel2"
        Me.userPhoneNumberProfileLabel2.Size = New System.Drawing.Size(244, 25)
        Me.userPhoneNumberProfileLabel2.TabIndex = 10
        Me.userPhoneNumberProfileLabel2.Text = "User telephone nunber :"
        '
        'userPwdProfileLabel
        '
        Me.userPwdProfileLabel.AutoSize = True
        Me.userPwdProfileLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userPwdProfileLabel.Location = New System.Drawing.Point(65, 182)
        Me.userPwdProfileLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userPwdProfileLabel.Name = "userPwdProfileLabel"
        Me.userPwdProfileLabel.Size = New System.Drawing.Size(213, 25)
        Me.userPwdProfileLabel.TabIndex = 9
        Me.userPwdProfileLabel.Text = "Enter new password:"
        '
        'userNameProfileLabel2
        '
        Me.userNameProfileLabel2.AutoSize = True
        Me.userNameProfileLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userNameProfileLabel2.Location = New System.Drawing.Point(65, 17)
        Me.userNameProfileLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userNameProfileLabel2.Name = "userNameProfileLabel2"
        Me.userNameProfileLabel2.Size = New System.Drawing.Size(129, 25)
        Me.userNameProfileLabel2.TabIndex = 7
        Me.userNameProfileLabel2.Text = "User name :"
        '
        'profileSubPanel1
        '
        Me.profileSubPanel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.profileSubPanel1.Controls.Add(Me.updateProfileShowBtn)
        Me.profileSubPanel1.Controls.Add(Me.adminEmailProfile)
        Me.profileSubPanel1.Controls.Add(Me.adminTitleProfile)
        Me.profileSubPanel1.Controls.Add(Me.adminPhoneNumberProfile)
        Me.profileSubPanel1.Controls.Add(Me.adminNameProfile)
        Me.profileSubPanel1.Controls.Add(Me.adminEmailProfileLabel)
        Me.profileSubPanel1.Controls.Add(Me.adminPhoneNumberProfileLabel)
        Me.profileSubPanel1.Controls.Add(Me.adminTitleProfileLabel)
        Me.profileSubPanel1.Controls.Add(Me.adminNameProfileLabel)
        Me.profileSubPanel1.Location = New System.Drawing.Point(88, 114)
        Me.profileSubPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.profileSubPanel1.Name = "profileSubPanel1"
        Me.profileSubPanel1.Size = New System.Drawing.Size(783, 310)
        Me.profileSubPanel1.TabIndex = 31
        '
        'updateProfileShowBtn
        '
        Me.updateProfileShowBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.updateProfileShowBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.updateProfileShowBtn.FlatAppearance.BorderSize = 0
        Me.updateProfileShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateProfileShowBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.updateProfileShowBtn.Location = New System.Drawing.Point(629, 252)
        Me.updateProfileShowBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.updateProfileShowBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.updateProfileShowBtn.Name = "updateProfileShowBtn"
        Me.updateProfileShowBtn.Size = New System.Drawing.Size(127, 39)
        Me.updateProfileShowBtn.TabIndex = 13
        Me.updateProfileShowBtn.Text = "Update"
        Me.updateProfileShowBtn.UseVisualStyleBackColor = False
        '
        'adminEmailProfile
        '
        Me.adminEmailProfile.AutoSize = True
        Me.adminEmailProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.adminEmailProfile.Location = New System.Drawing.Point(393, 145)
        Me.adminEmailProfile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adminEmailProfile.Name = "adminEmailProfile"
        Me.adminEmailProfile.Size = New System.Drawing.Size(58, 24)
        Me.adminEmailProfile.TabIndex = 14
        Me.adminEmailProfile.Text = "******"
        '
        'adminTitleProfile
        '
        Me.adminTitleProfile.AutoSize = True
        Me.adminTitleProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.adminTitleProfile.Location = New System.Drawing.Point(393, 234)
        Me.adminTitleProfile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adminTitleProfile.Name = "adminTitleProfile"
        Me.adminTitleProfile.Size = New System.Drawing.Size(58, 24)
        Me.adminTitleProfile.TabIndex = 13
        Me.adminTitleProfile.Text = "******"
        '
        'adminPhoneNumberProfile
        '
        Me.adminPhoneNumberProfile.AutoSize = True
        Me.adminPhoneNumberProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.adminPhoneNumberProfile.Location = New System.Drawing.Point(393, 188)
        Me.adminPhoneNumberProfile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adminPhoneNumberProfile.Name = "adminPhoneNumberProfile"
        Me.adminPhoneNumberProfile.Size = New System.Drawing.Size(58, 24)
        Me.adminPhoneNumberProfile.TabIndex = 12
        Me.adminPhoneNumberProfile.Text = "******"
        '
        'adminNameProfile
        '
        Me.adminNameProfile.AutoSize = True
        Me.adminNameProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.adminNameProfile.Location = New System.Drawing.Point(393, 103)
        Me.adminNameProfile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adminNameProfile.Name = "adminNameProfile"
        Me.adminNameProfile.Size = New System.Drawing.Size(58, 24)
        Me.adminNameProfile.TabIndex = 7
        Me.adminNameProfile.Text = "******"
        '
        'adminEmailProfileLabel
        '
        Me.adminEmailProfileLabel.AutoSize = True
        Me.adminEmailProfileLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminEmailProfileLabel.Location = New System.Drawing.Point(63, 144)
        Me.adminEmailProfileLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adminEmailProfileLabel.Name = "adminEmailProfileLabel"
        Me.adminEmailProfileLabel.Size = New System.Drawing.Size(127, 25)
        Me.adminEmailProfileLabel.TabIndex = 11
        Me.adminEmailProfileLabel.Text = "User email :"
        '
        'adminPhoneNumberProfileLabel
        '
        Me.adminPhoneNumberProfileLabel.AutoSize = True
        Me.adminPhoneNumberProfileLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminPhoneNumberProfileLabel.Location = New System.Drawing.Point(63, 187)
        Me.adminPhoneNumberProfileLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adminPhoneNumberProfileLabel.Name = "adminPhoneNumberProfileLabel"
        Me.adminPhoneNumberProfileLabel.Size = New System.Drawing.Size(244, 25)
        Me.adminPhoneNumberProfileLabel.TabIndex = 10
        Me.adminPhoneNumberProfileLabel.Text = "User telephone nunber :"
        '
        'adminTitleProfileLabel
        '
        Me.adminTitleProfileLabel.AutoSize = True
        Me.adminTitleProfileLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminTitleProfileLabel.Location = New System.Drawing.Point(63, 229)
        Me.adminTitleProfileLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adminTitleProfileLabel.Name = "adminTitleProfileLabel"
        Me.adminTitleProfileLabel.Size = New System.Drawing.Size(118, 25)
        Me.adminTitleProfileLabel.TabIndex = 9
        Me.adminTitleProfileLabel.Text = "User Title :"
        '
        'adminNameProfileLabel
        '
        Me.adminNameProfileLabel.AutoSize = True
        Me.adminNameProfileLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminNameProfileLabel.Location = New System.Drawing.Point(63, 102)
        Me.adminNameProfileLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adminNameProfileLabel.Name = "adminNameProfileLabel"
        Me.adminNameProfileLabel.Size = New System.Drawing.Size(129, 25)
        Me.adminNameProfileLabel.TabIndex = 7
        Me.adminNameProfileLabel.Text = "User name :"
        '
        'profileTitle
        '
        Me.profileTitle.AutoSize = True
        Me.profileTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Bold)
        Me.profileTitle.Location = New System.Drawing.Point(81, 66)
        Me.profileTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.profileTitle.Name = "profileTitle"
        Me.profileTitle.Size = New System.Drawing.Size(93, 30)
        Me.profileTitle.TabIndex = 30
        Me.profileTitle.Text = "Profile"
        '
        'adminHallsPanel
        '
        Me.adminHallsPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.adminHallsPanel.Controls.Add(Me.hallUpdatePanel)
        Me.adminHallsPanel.Controls.Add(Me.hallAddpanel)
        Me.adminHallsPanel.Controls.Add(Me.hallAddBtn)
        Me.adminHallsPanel.Controls.Add(Me.confirmMsgH)
        Me.adminHallsPanel.Controls.Add(Me.HallUpdateBtn)
        Me.adminHallsPanel.Controls.Add(Me.hallSearchBoxH)
        Me.adminHallsPanel.Controls.Add(Me.searchErrorH)
        Me.adminHallsPanel.Controls.Add(Me.PrintBtnH)
        Me.adminHallsPanel.Controls.Add(Me.exportBtnH)
        Me.adminHallsPanel.Controls.Add(Me.DataGridView3)
        Me.adminHallsPanel.Controls.Add(Me.Label21)
        Me.adminHallsPanel.Controls.Add(Me.HallDeleteBtn)
        Me.adminHallsPanel.Controls.Add(Me.Label4)
        Me.adminHallsPanel.Location = New System.Drawing.Point(208, 509)
        Me.adminHallsPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.adminHallsPanel.Name = "adminHallsPanel"
        Me.adminHallsPanel.Size = New System.Drawing.Size(967, 100)
        Me.adminHallsPanel.TabIndex = 42
        Me.adminHallsPanel.Visible = False
        '
        'hallUpdatePanel
        '
        Me.hallUpdatePanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.hallUpdatePanel.Controls.Add(Me.hallUpdateCancelBtn)
        Me.hallUpdatePanel.Controls.Add(Me.adminUpdateHallNameInput)
        Me.hallUpdatePanel.Controls.Add(Me.hallUpdateValidateBtn)
        Me.hallUpdatePanel.Controls.Add(Me.adminUpdateHallNameLabel)
        Me.hallUpdatePanel.Location = New System.Drawing.Point(78, 137)
        Me.hallUpdatePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.hallUpdatePanel.Name = "hallUpdatePanel"
        Me.hallUpdatePanel.Size = New System.Drawing.Size(831, 290)
        Me.hallUpdatePanel.TabIndex = 62
        Me.hallUpdatePanel.Visible = False
        '
        'hallUpdateCancelBtn
        '
        Me.hallUpdateCancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.hallUpdateCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.hallUpdateCancelBtn.FlatAppearance.BorderSize = 0
        Me.hallUpdateCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hallUpdateCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.hallUpdateCancelBtn.Location = New System.Drawing.Point(493, 238)
        Me.hallUpdateCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.hallUpdateCancelBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.hallUpdateCancelBtn.Name = "hallUpdateCancelBtn"
        Me.hallUpdateCancelBtn.Size = New System.Drawing.Size(105, 39)
        Me.hallUpdateCancelBtn.TabIndex = 44
        Me.hallUpdateCancelBtn.Text = "Cancel"
        Me.hallUpdateCancelBtn.UseVisualStyleBackColor = False
        '
        'adminUpdateHallNameInput
        '
        Me.adminUpdateHallNameInput.Location = New System.Drawing.Point(311, 90)
        Me.adminUpdateHallNameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.adminUpdateHallNameInput.Name = "adminUpdateHallNameInput"
        Me.adminUpdateHallNameInput.Size = New System.Drawing.Size(239, 22)
        Me.adminUpdateHallNameInput.TabIndex = 19
        '
        'hallUpdateValidateBtn
        '
        Me.hallUpdateValidateBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.hallUpdateValidateBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.hallUpdateValidateBtn.FlatAppearance.BorderSize = 0
        Me.hallUpdateValidateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hallUpdateValidateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.hallUpdateValidateBtn.Location = New System.Drawing.Point(623, 238)
        Me.hallUpdateValidateBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.hallUpdateValidateBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.hallUpdateValidateBtn.Name = "hallUpdateValidateBtn"
        Me.hallUpdateValidateBtn.Size = New System.Drawing.Size(127, 39)
        Me.hallUpdateValidateBtn.TabIndex = 13
        Me.hallUpdateValidateBtn.Text = "Update"
        Me.hallUpdateValidateBtn.UseVisualStyleBackColor = False
        '
        'adminUpdateHallNameLabel
        '
        Me.adminUpdateHallNameLabel.AutoSize = True
        Me.adminUpdateHallNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminUpdateHallNameLabel.Location = New System.Drawing.Point(71, 87)
        Me.adminUpdateHallNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adminUpdateHallNameLabel.Name = "adminUpdateHallNameLabel"
        Me.adminUpdateHallNameLabel.Size = New System.Drawing.Size(121, 25)
        Me.adminUpdateHallNameLabel.TabIndex = 11
        Me.adminUpdateHallNameLabel.Text = "Hall name :"
        '
        'hallAddpanel
        '
        Me.hallAddpanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.hallAddpanel.Controls.Add(Me.addHallErrorMsg)
        Me.hallAddpanel.Controls.Add(Me.HallAddCancelBtn)
        Me.hallAddpanel.Controls.Add(Me.adminAddHallNameInput)
        Me.hallAddpanel.Controls.Add(Me.HallAddValidateBtn)
        Me.hallAddpanel.Controls.Add(Me.adminAddHallNameLabel)
        Me.hallAddpanel.Location = New System.Drawing.Point(81, 133)
        Me.hallAddpanel.Margin = New System.Windows.Forms.Padding(4)
        Me.hallAddpanel.Name = "hallAddpanel"
        Me.hallAddpanel.Size = New System.Drawing.Size(831, 290)
        Me.hallAddpanel.TabIndex = 49
        Me.hallAddpanel.Visible = False
        '
        'addHallErrorMsg
        '
        Me.addHallErrorMsg.AutoSize = True
        Me.addHallErrorMsg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.addHallErrorMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addHallErrorMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addHallErrorMsg.Location = New System.Drawing.Point(72, 251)
        Me.addHallErrorMsg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.addHallErrorMsg.Name = "addHallErrorMsg"
        Me.addHallErrorMsg.Size = New System.Drawing.Size(0, 18)
        Me.addHallErrorMsg.TabIndex = 61
        Me.addHallErrorMsg.Visible = False
        '
        'HallAddCancelBtn
        '
        Me.HallAddCancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.HallAddCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.HallAddCancelBtn.FlatAppearance.BorderSize = 0
        Me.HallAddCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HallAddCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.HallAddCancelBtn.Location = New System.Drawing.Point(493, 238)
        Me.HallAddCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.HallAddCancelBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.HallAddCancelBtn.Name = "HallAddCancelBtn"
        Me.HallAddCancelBtn.Size = New System.Drawing.Size(105, 39)
        Me.HallAddCancelBtn.TabIndex = 44
        Me.HallAddCancelBtn.Text = "Cancel"
        Me.HallAddCancelBtn.UseVisualStyleBackColor = False
        '
        'adminAddHallNameInput
        '
        Me.adminAddHallNameInput.Location = New System.Drawing.Point(311, 90)
        Me.adminAddHallNameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.adminAddHallNameInput.Name = "adminAddHallNameInput"
        Me.adminAddHallNameInput.Size = New System.Drawing.Size(239, 22)
        Me.adminAddHallNameInput.TabIndex = 19
        '
        'HallAddValidateBtn
        '
        Me.HallAddValidateBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.HallAddValidateBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.HallAddValidateBtn.FlatAppearance.BorderSize = 0
        Me.HallAddValidateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HallAddValidateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.HallAddValidateBtn.Location = New System.Drawing.Point(623, 238)
        Me.HallAddValidateBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.HallAddValidateBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.HallAddValidateBtn.Name = "HallAddValidateBtn"
        Me.HallAddValidateBtn.Size = New System.Drawing.Size(127, 39)
        Me.HallAddValidateBtn.TabIndex = 13
        Me.HallAddValidateBtn.Text = "Add"
        Me.HallAddValidateBtn.UseVisualStyleBackColor = False
        '
        'adminAddHallNameLabel
        '
        Me.adminAddHallNameLabel.AutoSize = True
        Me.adminAddHallNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminAddHallNameLabel.Location = New System.Drawing.Point(71, 87)
        Me.adminAddHallNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adminAddHallNameLabel.Name = "adminAddHallNameLabel"
        Me.adminAddHallNameLabel.Size = New System.Drawing.Size(121, 25)
        Me.adminAddHallNameLabel.TabIndex = 11
        Me.adminAddHallNameLabel.Text = "Hall name :"
        '
        'hallAddBtn
        '
        Me.hallAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hallAddBtn.Image = Global.cems.My.Resources.Resources.plus
        Me.hallAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hallAddBtn.Location = New System.Drawing.Point(596, 73)
        Me.hallAddBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.hallAddBtn.Name = "hallAddBtn"
        Me.hallAddBtn.Size = New System.Drawing.Size(100, 28)
        Me.hallAddBtn.TabIndex = 43
        Me.hallAddBtn.Text = "Add"
        Me.hallAddBtn.UseVisualStyleBackColor = True
        '
        'confirmMsgH
        '
        Me.confirmMsgH.AutoSize = True
        Me.confirmMsgH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.confirmMsgH.ForeColor = System.Drawing.Color.LimeGreen
        Me.confirmMsgH.Location = New System.Drawing.Point(693, 21)
        Me.confirmMsgH.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.confirmMsgH.Name = "confirmMsgH"
        Me.confirmMsgH.Size = New System.Drawing.Size(177, 20)
        Me.confirmMsgH.TabIndex = 41
        Me.confirmMsgH.Text = "Export successfull ✔"
        Me.confirmMsgH.Visible = False
        '
        'HallUpdateBtn
        '
        Me.HallUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HallUpdateBtn.Location = New System.Drawing.Point(812, 133)
        Me.HallUpdateBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.HallUpdateBtn.Name = "HallUpdateBtn"
        Me.HallUpdateBtn.Size = New System.Drawing.Size(100, 28)
        Me.HallUpdateBtn.TabIndex = 38
        Me.HallUpdateBtn.Text = "Update"
        Me.HallUpdateBtn.UseVisualStyleBackColor = True
        Me.HallUpdateBtn.Visible = False
        '
        'hallSearchBoxH
        '
        Me.hallSearchBoxH.FormattingEnabled = True
        Me.hallSearchBoxH.Location = New System.Drawing.Point(481, 73)
        Me.hallSearchBoxH.Margin = New System.Windows.Forms.Padding(4)
        Me.hallSearchBoxH.Name = "hallSearchBoxH"
        Me.hallSearchBoxH.Size = New System.Drawing.Size(105, 24)
        Me.hallSearchBoxH.TabIndex = 37
        '
        'searchErrorH
        '
        Me.searchErrorH.AutoSize = True
        Me.searchErrorH.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.25!, System.Drawing.FontStyle.Bold)
        Me.searchErrorH.Location = New System.Drawing.Point(296, 277)
        Me.searchErrorH.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.searchErrorH.Name = "searchErrorH"
        Me.searchErrorH.Size = New System.Drawing.Size(349, 47)
        Me.searchErrorH.TabIndex = 36
        Me.searchErrorH.Text = "No results found "
        Me.searchErrorH.Visible = False
        '
        'PrintBtnH
        '
        Me.PrintBtnH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintBtnH.Image = Global.cems.My.Resources.Resources.print__1_
        Me.PrintBtnH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintBtnH.Location = New System.Drawing.Point(812, 73)
        Me.PrintBtnH.Margin = New System.Windows.Forms.Padding(4)
        Me.PrintBtnH.Name = "PrintBtnH"
        Me.PrintBtnH.Size = New System.Drawing.Size(100, 28)
        Me.PrintBtnH.TabIndex = 33
        Me.PrintBtnH.Text = "Print"
        Me.PrintBtnH.UseVisualStyleBackColor = True
        '
        'exportBtnH
        '
        Me.exportBtnH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exportBtnH.Image = Global.cems.My.Resources.Resources.export
        Me.exportBtnH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exportBtnH.Location = New System.Drawing.Point(704, 73)
        Me.exportBtnH.Margin = New System.Windows.Forms.Padding(4)
        Me.exportBtnH.Name = "exportBtnH"
        Me.exportBtnH.Size = New System.Drawing.Size(100, 28)
        Me.exportBtnH.TabIndex = 32
        Me.exportBtnH.Text = "Export"
        Me.exportBtnH.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(81, 133)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(697, 290)
        Me.DataGridView3.TabIndex = 30
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(81, 52)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 29)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "Halls"
        '
        'HallDeleteBtn
        '
        Me.HallDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HallDeleteBtn.Location = New System.Drawing.Point(812, 180)
        Me.HallDeleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.HallDeleteBtn.Name = "HallDeleteBtn"
        Me.HallDeleteBtn.Size = New System.Drawing.Size(100, 28)
        Me.HallDeleteBtn.TabIndex = 45
        Me.HallDeleteBtn.Text = "Delete"
        Me.HallDeleteBtn.UseVisualStyleBackColor = True
        Me.HallDeleteBtn.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(361, 75)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(98, 24)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "select hall:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'adminUsersPanel
        '
        Me.adminUsersPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.adminUsersPanel.Controls.Add(Me.userUpdatePanel)
        Me.adminUsersPanel.Controls.Add(Me.userAddPanel)
        Me.adminUsersPanel.Controls.Add(Me.userSearchBox)
        Me.adminUsersPanel.Controls.Add(Me.userAddBtn)
        Me.adminUsersPanel.Controls.Add(Me.confirmMsgU)
        Me.adminUsersPanel.Controls.Add(Me.userUpdateBtn)
        Me.adminUsersPanel.Controls.Add(Me.searchErrorU)
        Me.adminUsersPanel.Controls.Add(Me.PrintBtnU)
        Me.adminUsersPanel.Controls.Add(Me.exportBtnU)
        Me.adminUsersPanel.Controls.Add(Me.DataGridView4)
        Me.adminUsersPanel.Controls.Add(Me.Label10)
        Me.adminUsersPanel.Controls.Add(Me.userDeleteBtn)
        Me.adminUsersPanel.Controls.Add(Me.Label3)
        Me.adminUsersPanel.Location = New System.Drawing.Point(209, 530)
        Me.adminUsersPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.adminUsersPanel.Name = "adminUsersPanel"
        Me.adminUsersPanel.Size = New System.Drawing.Size(968, 76)
        Me.adminUsersPanel.TabIndex = 49
        Me.adminUsersPanel.Visible = False
        '
        'userUpdatePanel
        '
        Me.userUpdatePanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.userUpdatePanel.Controls.Add(Me.userUserTitleInput)
        Me.userUpdatePanel.Controls.Add(Me.Label11)
        Me.userUpdatePanel.Controls.Add(Me.userUserPhoneInput)
        Me.userUpdatePanel.Controls.Add(Me.Label9)
        Me.userUpdatePanel.Controls.Add(Me.userUserEmailInput)
        Me.userUpdatePanel.Controls.Add(Me.Label8)
        Me.userUpdatePanel.Controls.Add(Me.userCancelBtn)
        Me.userUpdatePanel.Controls.Add(Me.userUserNameInput)
        Me.userUpdatePanel.Controls.Add(Me.userUpdateValidationBtn)
        Me.userUpdatePanel.Controls.Add(Me.Label7)
        Me.userUpdatePanel.Location = New System.Drawing.Point(77, 131)
        Me.userUpdatePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.userUpdatePanel.Name = "userUpdatePanel"
        Me.userUpdatePanel.Size = New System.Drawing.Size(831, 327)
        Me.userUpdatePanel.TabIndex = 59
        Me.userUpdatePanel.Visible = False
        '
        'userUserTitleInput
        '
        Me.userUserTitleInput.FormattingEnabled = True
        Me.userUserTitleInput.Location = New System.Drawing.Point(359, 142)
        Me.userUserTitleInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userUserTitleInput.Name = "userUserTitleInput"
        Me.userUserTitleInput.Size = New System.Drawing.Size(239, 24)
        Me.userUserTitleInput.TabIndex = 47
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(71, 142)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 25)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "user title :"
        '
        'userUserPhoneInput
        '
        Me.userUserPhoneInput.Location = New System.Drawing.Point(359, 108)
        Me.userUserPhoneInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userUserPhoneInput.Name = "userUserPhoneInput"
        Me.userUserPhoneInput.Size = New System.Drawing.Size(239, 22)
        Me.userUserPhoneInput.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(71, 107)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(211, 25)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "user phone number :"
        '
        'userUserEmailInput
        '
        Me.userUserEmailInput.Location = New System.Drawing.Point(359, 73)
        Me.userUserEmailInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userUserEmailInput.Name = "userUserEmailInput"
        Me.userUserEmailInput.Size = New System.Drawing.Size(239, 22)
        Me.userUserEmailInput.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(71, 71)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 25)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "user email :"
        '
        'userCancelBtn
        '
        Me.userCancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.userCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.userCancelBtn.FlatAppearance.BorderSize = 0
        Me.userCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.userCancelBtn.Location = New System.Drawing.Point(493, 277)
        Me.userCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.userCancelBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.userCancelBtn.Name = "userCancelBtn"
        Me.userCancelBtn.Size = New System.Drawing.Size(105, 39)
        Me.userCancelBtn.TabIndex = 44
        Me.userCancelBtn.Text = "Cancel"
        Me.userCancelBtn.UseVisualStyleBackColor = False
        '
        'userUserNameInput
        '
        Me.userUserNameInput.Location = New System.Drawing.Point(359, 37)
        Me.userUserNameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userUserNameInput.Name = "userUserNameInput"
        Me.userUserNameInput.Size = New System.Drawing.Size(239, 22)
        Me.userUserNameInput.TabIndex = 19
        '
        'userUpdateValidationBtn
        '
        Me.userUpdateValidationBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.userUpdateValidationBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.userUpdateValidationBtn.FlatAppearance.BorderSize = 0
        Me.userUpdateValidationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userUpdateValidationBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.userUpdateValidationBtn.Location = New System.Drawing.Point(623, 277)
        Me.userUpdateValidationBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.userUpdateValidationBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.userUpdateValidationBtn.Name = "userUpdateValidationBtn"
        Me.userUpdateValidationBtn.Size = New System.Drawing.Size(127, 39)
        Me.userUpdateValidationBtn.TabIndex = 13
        Me.userUpdateValidationBtn.Text = "Update"
        Me.userUpdateValidationBtn.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(71, 36)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "user name :"
        '
        'userAddPanel
        '
        Me.userAddPanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.userAddPanel.Controls.Add(Me.addUserErrorMsg)
        Me.userAddPanel.Controls.Add(Me.userUserAddTitleInput)
        Me.userAddPanel.Controls.Add(Me.userUserAddConfirmPwdInput)
        Me.userAddPanel.Controls.Add(Me.Label6)
        Me.userAddPanel.Controls.Add(Me.userUserAddPwdInput)
        Me.userAddPanel.Controls.Add(Me.Label14)
        Me.userAddPanel.Controls.Add(Me.Label15)
        Me.userAddPanel.Controls.Add(Me.userUserAddPhoneInput)
        Me.userAddPanel.Controls.Add(Me.Label16)
        Me.userAddPanel.Controls.Add(Me.userUserAddEmailInput)
        Me.userAddPanel.Controls.Add(Me.Label17)
        Me.userAddPanel.Controls.Add(Me.userAddCancelBtn)
        Me.userAddPanel.Controls.Add(Me.userUserAddNameInput)
        Me.userAddPanel.Controls.Add(Me.userAddvalidationBtn)
        Me.userAddPanel.Controls.Add(Me.Label18)
        Me.userAddPanel.Location = New System.Drawing.Point(81, 132)
        Me.userAddPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.userAddPanel.Name = "userAddPanel"
        Me.userAddPanel.Size = New System.Drawing.Size(831, 327)
        Me.userAddPanel.TabIndex = 60
        Me.userAddPanel.Visible = False
        '
        'addUserErrorMsg
        '
        Me.addUserErrorMsg.AutoSize = True
        Me.addUserErrorMsg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.addUserErrorMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addUserErrorMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addUserErrorMsg.Location = New System.Drawing.Point(75, 290)
        Me.addUserErrorMsg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.addUserErrorMsg.Name = "addUserErrorMsg"
        Me.addUserErrorMsg.Size = New System.Drawing.Size(0, 18)
        Me.addUserErrorMsg.TabIndex = 58
        Me.addUserErrorMsg.Visible = False
        '
        'userUserAddTitleInput
        '
        Me.userUserAddTitleInput.FormattingEnabled = True
        Me.userUserAddTitleInput.Location = New System.Drawing.Point(359, 142)
        Me.userUserAddTitleInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userUserAddTitleInput.Name = "userUserAddTitleInput"
        Me.userUserAddTitleInput.Size = New System.Drawing.Size(239, 24)
        Me.userUserAddTitleInput.TabIndex = 47
        '
        'userUserAddConfirmPwdInput
        '
        Me.userUserAddConfirmPwdInput.Location = New System.Drawing.Point(359, 225)
        Me.userUserAddConfirmPwdInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userUserAddConfirmPwdInput.Name = "userUserAddConfirmPwdInput"
        Me.userUserAddConfirmPwdInput.Size = New System.Drawing.Size(239, 22)
        Me.userUserAddConfirmPwdInput.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(71, 224)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 25)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "confirm password:"
        '
        'userUserAddPwdInput
        '
        Me.userUserAddPwdInput.Location = New System.Drawing.Point(359, 193)
        Me.userUserAddPwdInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userUserAddPwdInput.Name = "userUserAddPwdInput"
        Me.userUserAddPwdInput.Size = New System.Drawing.Size(239, 22)
        Me.userUserAddPwdInput.TabIndex = 55
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(71, 192)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(165, 25)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "user password :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(71, 142)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 25)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "user title :"
        '
        'userUserAddPhoneInput
        '
        Me.userUserAddPhoneInput.Location = New System.Drawing.Point(359, 108)
        Me.userUserAddPhoneInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userUserAddPhoneInput.Name = "userUserAddPhoneInput"
        Me.userUserAddPhoneInput.Size = New System.Drawing.Size(239, 22)
        Me.userUserAddPhoneInput.TabIndex = 51
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(71, 107)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(211, 25)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "user phone number :"
        '
        'userUserAddEmailInput
        '
        Me.userUserAddEmailInput.Location = New System.Drawing.Point(359, 73)
        Me.userUserAddEmailInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userUserAddEmailInput.Name = "userUserAddEmailInput"
        Me.userUserAddEmailInput.Size = New System.Drawing.Size(239, 22)
        Me.userUserAddEmailInput.TabIndex = 49
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(71, 71)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(124, 25)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "user email :"
        '
        'userAddCancelBtn
        '
        Me.userAddCancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.userAddCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.userAddCancelBtn.FlatAppearance.BorderSize = 0
        Me.userAddCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userAddCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.userAddCancelBtn.Location = New System.Drawing.Point(493, 277)
        Me.userAddCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.userAddCancelBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.userAddCancelBtn.Name = "userAddCancelBtn"
        Me.userAddCancelBtn.Size = New System.Drawing.Size(105, 39)
        Me.userAddCancelBtn.TabIndex = 44
        Me.userAddCancelBtn.Text = "Cancel"
        Me.userAddCancelBtn.UseVisualStyleBackColor = False
        '
        'userUserAddNameInput
        '
        Me.userUserAddNameInput.Location = New System.Drawing.Point(359, 37)
        Me.userUserAddNameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userUserAddNameInput.Name = "userUserAddNameInput"
        Me.userUserAddNameInput.Size = New System.Drawing.Size(239, 22)
        Me.userUserAddNameInput.TabIndex = 19
        '
        'userAddvalidationBtn
        '
        Me.userAddvalidationBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.userAddvalidationBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.userAddvalidationBtn.FlatAppearance.BorderSize = 0
        Me.userAddvalidationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userAddvalidationBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.userAddvalidationBtn.Location = New System.Drawing.Point(623, 277)
        Me.userAddvalidationBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.userAddvalidationBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.userAddvalidationBtn.Name = "userAddvalidationBtn"
        Me.userAddvalidationBtn.Size = New System.Drawing.Size(127, 39)
        Me.userAddvalidationBtn.TabIndex = 13
        Me.userAddvalidationBtn.Text = "Add"
        Me.userAddvalidationBtn.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(71, 36)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(126, 25)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "user name :"
        '
        'userSearchBox
        '
        Me.userSearchBox.Location = New System.Drawing.Point(440, 76)
        Me.userSearchBox.Margin = New System.Windows.Forms.Padding(4)
        Me.userSearchBox.Name = "userSearchBox"
        Me.userSearchBox.Size = New System.Drawing.Size(148, 22)
        Me.userSearchBox.TabIndex = 59
        '
        'userAddBtn
        '
        Me.userAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userAddBtn.Location = New System.Drawing.Point(596, 73)
        Me.userAddBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.userAddBtn.Name = "userAddBtn"
        Me.userAddBtn.Size = New System.Drawing.Size(100, 28)
        Me.userAddBtn.TabIndex = 43
        Me.userAddBtn.Text = "Add"
        Me.userAddBtn.UseVisualStyleBackColor = True
        '
        'confirmMsgU
        '
        Me.confirmMsgU.AutoSize = True
        Me.confirmMsgU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.confirmMsgU.ForeColor = System.Drawing.Color.LimeGreen
        Me.confirmMsgU.Location = New System.Drawing.Point(693, 21)
        Me.confirmMsgU.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.confirmMsgU.Name = "confirmMsgU"
        Me.confirmMsgU.Size = New System.Drawing.Size(177, 20)
        Me.confirmMsgU.TabIndex = 41
        Me.confirmMsgU.Text = "Export successfull ✔"
        Me.confirmMsgU.Visible = False
        '
        'userUpdateBtn
        '
        Me.userUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userUpdateBtn.Location = New System.Drawing.Point(812, 133)
        Me.userUpdateBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.userUpdateBtn.Name = "userUpdateBtn"
        Me.userUpdateBtn.Size = New System.Drawing.Size(100, 28)
        Me.userUpdateBtn.TabIndex = 38
        Me.userUpdateBtn.Text = "Update"
        Me.userUpdateBtn.UseVisualStyleBackColor = True
        Me.userUpdateBtn.Visible = False
        '
        'searchErrorU
        '
        Me.searchErrorU.AutoSize = True
        Me.searchErrorU.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.25!, System.Drawing.FontStyle.Bold)
        Me.searchErrorU.Location = New System.Drawing.Point(296, 277)
        Me.searchErrorU.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.searchErrorU.Name = "searchErrorU"
        Me.searchErrorU.Size = New System.Drawing.Size(349, 47)
        Me.searchErrorU.TabIndex = 36
        Me.searchErrorU.Text = "No results found "
        Me.searchErrorU.Visible = False
        '
        'PrintBtnU
        '
        Me.PrintBtnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintBtnU.Image = Global.cems.My.Resources.Resources.print__1_
        Me.PrintBtnU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintBtnU.Location = New System.Drawing.Point(812, 73)
        Me.PrintBtnU.Margin = New System.Windows.Forms.Padding(4)
        Me.PrintBtnU.Name = "PrintBtnU"
        Me.PrintBtnU.Size = New System.Drawing.Size(100, 28)
        Me.PrintBtnU.TabIndex = 33
        Me.PrintBtnU.Text = "Print"
        Me.PrintBtnU.UseVisualStyleBackColor = True
        '
        'exportBtnU
        '
        Me.exportBtnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exportBtnU.Image = Global.cems.My.Resources.Resources.export
        Me.exportBtnU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exportBtnU.Location = New System.Drawing.Point(704, 73)
        Me.exportBtnU.Margin = New System.Windows.Forms.Padding(4)
        Me.exportBtnU.Name = "exportBtnU"
        Me.exportBtnU.Size = New System.Drawing.Size(100, 28)
        Me.exportBtnU.TabIndex = 32
        Me.exportBtnU.Text = "Export"
        Me.exportBtnU.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(81, 133)
        Me.DataGridView4.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView4.Size = New System.Drawing.Size(697, 290)
        Me.DataGridView4.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(81, 52)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 29)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Users"
        '
        'userDeleteBtn
        '
        Me.userDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userDeleteBtn.Location = New System.Drawing.Point(812, 180)
        Me.userDeleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.userDeleteBtn.Name = "userDeleteBtn"
        Me.userDeleteBtn.Size = New System.Drawing.Size(100, 28)
        Me.userDeleteBtn.TabIndex = 45
        Me.userDeleteBtn.Text = "Delete"
        Me.userDeleteBtn.UseVisualStyleBackColor = True
        Me.userDeleteBtn.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(260, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(148, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "enter username:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'adminRolePanel
        '
        Me.adminRolePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.adminRolePanel.Controls.Add(Me.roleUpdatePanel)
        Me.adminRolePanel.Controls.Add(Me.roleAddPanel)
        Me.adminRolePanel.Controls.Add(Me.roleDeleteBtn)
        Me.adminRolePanel.Controls.Add(Me.roleAddBtn)
        Me.adminRolePanel.Controls.Add(Me.confirmMsgR)
        Me.adminRolePanel.Controls.Add(Me.roleUpdateBtn)
        Me.adminRolePanel.Controls.Add(Me.searchErrorR)
        Me.adminRolePanel.Controls.Add(Me.PrintBtnR)
        Me.adminRolePanel.Controls.Add(Me.exportBtnR)
        Me.adminRolePanel.Controls.Add(Me.DataGridView5)
        Me.adminRolePanel.Controls.Add(Me.Roles)
        Me.adminRolePanel.Location = New System.Drawing.Point(210, 548)
        Me.adminRolePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.adminRolePanel.Name = "adminRolePanel"
        Me.adminRolePanel.Size = New System.Drawing.Size(968, 61)
        Me.adminRolePanel.TabIndex = 62
        Me.adminRolePanel.Visible = False
        '
        'roleUpdatePanel
        '
        Me.roleUpdatePanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.roleUpdatePanel.Controls.Add(Me.roleUpdateCancelBtn)
        Me.roleUpdatePanel.Controls.Add(Me.titleNameInput)
        Me.roleUpdatePanel.Controls.Add(Me.roleUpdateValidationBtn)
        Me.roleUpdatePanel.Controls.Add(Me.Label28)
        Me.roleUpdatePanel.Location = New System.Drawing.Point(80, 133)
        Me.roleUpdatePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.roleUpdatePanel.Name = "roleUpdatePanel"
        Me.roleUpdatePanel.Size = New System.Drawing.Size(831, 329)
        Me.roleUpdatePanel.TabIndex = 60
        Me.roleUpdatePanel.Visible = False
        '
        'roleUpdateCancelBtn
        '
        Me.roleUpdateCancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.roleUpdateCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.roleUpdateCancelBtn.FlatAppearance.BorderSize = 0
        Me.roleUpdateCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roleUpdateCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.roleUpdateCancelBtn.Location = New System.Drawing.Point(493, 277)
        Me.roleUpdateCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.roleUpdateCancelBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.roleUpdateCancelBtn.Name = "roleUpdateCancelBtn"
        Me.roleUpdateCancelBtn.Size = New System.Drawing.Size(105, 39)
        Me.roleUpdateCancelBtn.TabIndex = 44
        Me.roleUpdateCancelBtn.Text = "Cancel"
        Me.roleUpdateCancelBtn.UseVisualStyleBackColor = False
        '
        'titleNameInput
        '
        Me.titleNameInput.Location = New System.Drawing.Point(359, 112)
        Me.titleNameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.titleNameInput.Name = "titleNameInput"
        Me.titleNameInput.Size = New System.Drawing.Size(239, 22)
        Me.titleNameInput.TabIndex = 19
        '
        'roleUpdateValidationBtn
        '
        Me.roleUpdateValidationBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.roleUpdateValidationBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.roleUpdateValidationBtn.FlatAppearance.BorderSize = 0
        Me.roleUpdateValidationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roleUpdateValidationBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.roleUpdateValidationBtn.Location = New System.Drawing.Point(623, 277)
        Me.roleUpdateValidationBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.roleUpdateValidationBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.roleUpdateValidationBtn.Name = "roleUpdateValidationBtn"
        Me.roleUpdateValidationBtn.Size = New System.Drawing.Size(127, 39)
        Me.roleUpdateValidationBtn.TabIndex = 13
        Me.roleUpdateValidationBtn.Text = "Update"
        Me.roleUpdateValidationBtn.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(71, 111)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(127, 25)
        Me.Label28.TabIndex = 11
        Me.Label28.Text = "Role name :"
        '
        'roleAddPanel
        '
        Me.roleAddPanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.roleAddPanel.Controls.Add(Me.addRoleErrorMsg)
        Me.roleAddPanel.Controls.Add(Me.Label12)
        Me.roleAddPanel.Controls.Add(Me.roleAddCancelBtn)
        Me.roleAddPanel.Controls.Add(Me.titleAddNameInput)
        Me.roleAddPanel.Controls.Add(Me.roleAddValidationBtn)
        Me.roleAddPanel.Controls.Add(Me.Label24)
        Me.roleAddPanel.Location = New System.Drawing.Point(81, 133)
        Me.roleAddPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.roleAddPanel.Name = "roleAddPanel"
        Me.roleAddPanel.Size = New System.Drawing.Size(831, 330)
        Me.roleAddPanel.TabIndex = 60
        Me.roleAddPanel.Visible = False
        '
        'addRoleErrorMsg
        '
        Me.addRoleErrorMsg.AutoSize = True
        Me.addRoleErrorMsg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.addRoleErrorMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addRoleErrorMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addRoleErrorMsg.Location = New System.Drawing.Point(85, 277)
        Me.addRoleErrorMsg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.addRoleErrorMsg.Name = "addRoleErrorMsg"
        Me.addRoleErrorMsg.Size = New System.Drawing.Size(0, 18)
        Me.addRoleErrorMsg.TabIndex = 59
        Me.addRoleErrorMsg.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(75, 290)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 15)
        Me.Label12.TabIndex = 58
        Me.Label12.Visible = False
        '
        'roleAddCancelBtn
        '
        Me.roleAddCancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.roleAddCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.roleAddCancelBtn.FlatAppearance.BorderSize = 0
        Me.roleAddCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roleAddCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.roleAddCancelBtn.Location = New System.Drawing.Point(493, 277)
        Me.roleAddCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.roleAddCancelBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.roleAddCancelBtn.Name = "roleAddCancelBtn"
        Me.roleAddCancelBtn.Size = New System.Drawing.Size(105, 39)
        Me.roleAddCancelBtn.TabIndex = 44
        Me.roleAddCancelBtn.Text = "Cancel"
        Me.roleAddCancelBtn.UseVisualStyleBackColor = False
        '
        'titleAddNameInput
        '
        Me.titleAddNameInput.Location = New System.Drawing.Point(371, 112)
        Me.titleAddNameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.titleAddNameInput.Name = "titleAddNameInput"
        Me.titleAddNameInput.Size = New System.Drawing.Size(239, 22)
        Me.titleAddNameInput.TabIndex = 19
        '
        'roleAddValidationBtn
        '
        Me.roleAddValidationBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.roleAddValidationBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.roleAddValidationBtn.FlatAppearance.BorderSize = 0
        Me.roleAddValidationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roleAddValidationBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.roleAddValidationBtn.Location = New System.Drawing.Point(623, 277)
        Me.roleAddValidationBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.roleAddValidationBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.roleAddValidationBtn.Name = "roleAddValidationBtn"
        Me.roleAddValidationBtn.Size = New System.Drawing.Size(127, 39)
        Me.roleAddValidationBtn.TabIndex = 13
        Me.roleAddValidationBtn.Text = "Add"
        Me.roleAddValidationBtn.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(83, 111)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(127, 25)
        Me.Label24.TabIndex = 11
        Me.Label24.Text = "Role name :"
        '
        'roleDeleteBtn
        '
        Me.roleDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roleDeleteBtn.Location = New System.Drawing.Point(811, 169)
        Me.roleDeleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.roleDeleteBtn.Name = "roleDeleteBtn"
        Me.roleDeleteBtn.Size = New System.Drawing.Size(100, 28)
        Me.roleDeleteBtn.TabIndex = 46
        Me.roleDeleteBtn.Text = "Delete"
        Me.roleDeleteBtn.UseVisualStyleBackColor = True
        Me.roleDeleteBtn.Visible = False
        '
        'roleAddBtn
        '
        Me.roleAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roleAddBtn.Image = Global.cems.My.Resources.Resources.plus
        Me.roleAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.roleAddBtn.Location = New System.Drawing.Point(596, 73)
        Me.roleAddBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.roleAddBtn.Name = "roleAddBtn"
        Me.roleAddBtn.Size = New System.Drawing.Size(100, 28)
        Me.roleAddBtn.TabIndex = 43
        Me.roleAddBtn.Text = "Add"
        Me.roleAddBtn.UseVisualStyleBackColor = True
        '
        'confirmMsgR
        '
        Me.confirmMsgR.AutoSize = True
        Me.confirmMsgR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.confirmMsgR.ForeColor = System.Drawing.Color.LimeGreen
        Me.confirmMsgR.Location = New System.Drawing.Point(693, 21)
        Me.confirmMsgR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.confirmMsgR.Name = "confirmMsgR"
        Me.confirmMsgR.Size = New System.Drawing.Size(177, 20)
        Me.confirmMsgR.TabIndex = 41
        Me.confirmMsgR.Text = "Export successfull ✔"
        Me.confirmMsgR.Visible = False
        '
        'roleUpdateBtn
        '
        Me.roleUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roleUpdateBtn.Location = New System.Drawing.Point(812, 133)
        Me.roleUpdateBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.roleUpdateBtn.Name = "roleUpdateBtn"
        Me.roleUpdateBtn.Size = New System.Drawing.Size(100, 28)
        Me.roleUpdateBtn.TabIndex = 38
        Me.roleUpdateBtn.Text = "Update"
        Me.roleUpdateBtn.UseVisualStyleBackColor = True
        Me.roleUpdateBtn.Visible = False
        '
        'searchErrorR
        '
        Me.searchErrorR.AutoSize = True
        Me.searchErrorR.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.25!, System.Drawing.FontStyle.Bold)
        Me.searchErrorR.Location = New System.Drawing.Point(296, 277)
        Me.searchErrorR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.searchErrorR.Name = "searchErrorR"
        Me.searchErrorR.Size = New System.Drawing.Size(349, 47)
        Me.searchErrorR.TabIndex = 36
        Me.searchErrorR.Text = "No results found "
        Me.searchErrorR.Visible = False
        '
        'PrintBtnR
        '
        Me.PrintBtnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintBtnR.Image = Global.cems.My.Resources.Resources.print__1_
        Me.PrintBtnR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintBtnR.Location = New System.Drawing.Point(812, 73)
        Me.PrintBtnR.Margin = New System.Windows.Forms.Padding(4)
        Me.PrintBtnR.Name = "PrintBtnR"
        Me.PrintBtnR.Size = New System.Drawing.Size(100, 28)
        Me.PrintBtnR.TabIndex = 33
        Me.PrintBtnR.Text = "Print"
        Me.PrintBtnR.UseVisualStyleBackColor = True
        '
        'exportBtnR
        '
        Me.exportBtnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exportBtnR.Image = Global.cems.My.Resources.Resources.export
        Me.exportBtnR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exportBtnR.Location = New System.Drawing.Point(704, 73)
        Me.exportBtnR.Margin = New System.Windows.Forms.Padding(4)
        Me.exportBtnR.Name = "exportBtnR"
        Me.exportBtnR.Size = New System.Drawing.Size(100, 28)
        Me.exportBtnR.TabIndex = 32
        Me.exportBtnR.Text = "Export"
        Me.exportBtnR.UseVisualStyleBackColor = True
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.AllowUserToDeleteRows = False
        Me.DataGridView5.AllowUserToResizeColumns = False
        Me.DataGridView5.AllowUserToResizeRows = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(81, 133)
        Me.DataGridView5.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.RowHeadersWidth = 51
        Me.DataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView5.Size = New System.Drawing.Size(697, 290)
        Me.DataGridView5.TabIndex = 30
        '
        'Roles
        '
        Me.Roles.AutoSize = True
        Me.Roles.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roles.Location = New System.Drawing.Point(81, 52)
        Me.Roles.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Roles.Name = "Roles"
        Me.Roles.Size = New System.Drawing.Size(81, 29)
        Me.Roles.TabIndex = 29
        Me.Roles.Text = "Roles"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SeaGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(22, 182)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 25)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "CPU'S"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.SeaGreen
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Yellow
        Me.Label36.Location = New System.Drawing.Point(248, 183)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(192, 25)
        Me.Label36.TabIndex = 46
        Me.Label36.Text = "IP Phones"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.SeaGreen
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Yellow
        Me.Label37.Location = New System.Drawing.Point(483, 184)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(192, 25)
        Me.Label37.TabIndex = 47
        Me.Label37.Text = "Monitors"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.SeaGreen
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Yellow
        Me.Label38.Location = New System.Drawing.Point(717, 184)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(192, 25)
        Me.Label38.TabIndex = 48
        Me.Label38.Text = "Users"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CPUsBtn2
        '
        Me.CPUsBtn2.BackColor = System.Drawing.Color.Transparent
        Me.CPUsBtn2.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.CPUsBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CPUsBtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.CPUsBtn2.ForeColor = System.Drawing.Color.SeaGreen
        Me.CPUsBtn2.Location = New System.Drawing.Point(126, 221)
        Me.CPUsBtn2.Margin = New System.Windows.Forms.Padding(0)
        Me.CPUsBtn2.MaximumSize = New System.Drawing.Size(208, 62)
        Me.CPUsBtn2.Name = "CPUsBtn2"
        Me.CPUsBtn2.Size = New System.Drawing.Size(76, 27)
        Me.CPUsBtn2.TabIndex = 38
        Me.CPUsBtn2.Text = "View"
        Me.CPUsBtn2.UseVisualStyleBackColor = False
        '
        'IPsBtn2
        '
        Me.IPsBtn2.BackColor = System.Drawing.Color.Transparent
        Me.IPsBtn2.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.IPsBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IPsBtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.IPsBtn2.ForeColor = System.Drawing.Color.SeaGreen
        Me.IPsBtn2.Location = New System.Drawing.Point(350, 221)
        Me.IPsBtn2.Margin = New System.Windows.Forms.Padding(0)
        Me.IPsBtn2.MaximumSize = New System.Drawing.Size(208, 62)
        Me.IPsBtn2.Name = "IPsBtn2"
        Me.IPsBtn2.Size = New System.Drawing.Size(76, 27)
        Me.IPsBtn2.TabIndex = 39
        Me.IPsBtn2.Text = "View"
        Me.IPsBtn2.UseVisualStyleBackColor = False
        '
        'monitorsBtn2
        '
        Me.monitorsBtn2.BackColor = System.Drawing.Color.Transparent
        Me.monitorsBtn2.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.monitorsBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.monitorsBtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.monitorsBtn2.ForeColor = System.Drawing.Color.SeaGreen
        Me.monitorsBtn2.Location = New System.Drawing.Point(587, 221)
        Me.monitorsBtn2.Margin = New System.Windows.Forms.Padding(0)
        Me.monitorsBtn2.MaximumSize = New System.Drawing.Size(208, 62)
        Me.monitorsBtn2.Name = "monitorsBtn2"
        Me.monitorsBtn2.Size = New System.Drawing.Size(76, 27)
        Me.monitorsBtn2.TabIndex = 40
        Me.monitorsBtn2.Text = "View"
        Me.monitorsBtn2.UseVisualStyleBackColor = False
        '
        'usersBtn2
        '
        Me.usersBtn2.BackColor = System.Drawing.Color.Transparent
        Me.usersBtn2.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.usersBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usersBtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.usersBtn2.ForeColor = System.Drawing.Color.SeaGreen
        Me.usersBtn2.Location = New System.Drawing.Point(819, 221)
        Me.usersBtn2.Margin = New System.Windows.Forms.Padding(0)
        Me.usersBtn2.MaximumSize = New System.Drawing.Size(208, 62)
        Me.usersBtn2.Name = "usersBtn2"
        Me.usersBtn2.Size = New System.Drawing.Size(76, 27)
        Me.usersBtn2.TabIndex = 41
        Me.usersBtn2.Text = "View"
        Me.usersBtn2.UseVisualStyleBackColor = False
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.MintCream
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Yellow
        Me.Label39.Location = New System.Drawing.Point(10, 82)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(190, 2)
        Me.Label39.TabIndex = 49
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.SeaGreen
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.MintCream
        Me.Label40.Image = CType(resources.GetObject("Label40.Image"), System.Drawing.Image)
        Me.Label40.Location = New System.Drawing.Point(37, 106)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(20, 20)
        Me.Label40.TabIndex = 50
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.MintCream
        Me.Label41.Image = CType(resources.GetObject("Label41.Image"), System.Drawing.Image)
        Me.Label41.Location = New System.Drawing.Point(37, 191)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(20, 20)
        Me.Label41.TabIndex = 51
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.MintCream
        Me.Label42.Image = CType(resources.GetObject("Label42.Image"), System.Drawing.Image)
        Me.Label42.Location = New System.Drawing.Point(37, 133)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(20, 20)
        Me.Label42.TabIndex = 52
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.MintCream
        Me.Label43.Image = CType(resources.GetObject("Label43.Image"), System.Drawing.Image)
        Me.Label43.Location = New System.Drawing.Point(37, 82)
        Me.Label43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(20, 20)
        Me.Label43.TabIndex = 53
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.SeaGreen
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.MintCream
        Me.Label44.Image = CType(resources.GetObject("Label44.Image"), System.Drawing.Image)
        Me.Label44.Location = New System.Drawing.Point(37, 19)
        Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(20, 20)
        Me.Label44.TabIndex = 54
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.SeaGreen
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.MintCream
        Me.Label45.Image = CType(resources.GetObject("Label45.Image"), System.Drawing.Image)
        Me.Label45.Location = New System.Drawing.Point(37, 337)
        Me.Label45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(20, 20)
        Me.Label45.TabIndex = 55
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.SeaGreen
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.MintCream
        Me.Label46.Image = CType(resources.GetObject("Label46.Image"), System.Drawing.Image)
        Me.Label46.Location = New System.Drawing.Point(37, 279)
        Me.Label46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(20, 20)
        Me.Label46.TabIndex = 56
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.SeaGreen
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.MintCream
        Me.Label47.Image = CType(resources.GetObject("Label47.Image"), System.Drawing.Image)
        Me.Label47.Location = New System.Drawing.Point(37, 221)
        Me.Label47.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(20, 20)
        Me.Label47.TabIndex = 57
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.SeaGreen
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.MintCream
        Me.Label48.Image = CType(resources.GetObject("Label48.Image"), System.Drawing.Image)
        Me.Label48.Location = New System.Drawing.Point(37, 163)
        Me.Label48.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(20, 20)
        Me.Label48.TabIndex = 58
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'adminhomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(1176, 633)
        Me.Controls.Add(Me.adminPostPanel)
        Me.Controls.Add(Me.adminEquipmentPanel)
        Me.Controls.Add(Me.adminRolePanel)
        Me.Controls.Add(Me.adminUsersPanel)
        Me.Controls.Add(Me.adminHallsPanel)
        Me.Controls.Add(Me.adminProfilePanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.adminHeader)
        Me.Controls.Add(Me.adminHomePagePanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(300, 300)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1194, 680)
        Me.MinimumSize = New System.Drawing.Size(1194, 605)
        Me.Name = "adminhomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Page"
        Me.dropdown.ResumeLayout(False)
        Me.dropdown.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.adminHeader.ResumeLayout(False)
        Me.adminHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.adminHomePagePanel.ResumeLayout(False)
        Me.adminHomePagePanel.PerformLayout()
        Me.adminEquipmentPanel.ResumeLayout(False)
        Me.adminEquipmentPanel.PerformLayout()
        Me.addEquipmentPanel.ResumeLayout(False)
        Me.addEquipmentPanel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statePanel.ResumeLayout(False)
        Me.statePanel.PerformLayout()
        Me.adminPostPanel.ResumeLayout(False)
        Me.adminPostPanel.PerformLayout()
        Me.addPostPanel.ResumeLayout(False)
        Me.addPostPanel.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.postChangeStatePanel.ResumeLayout(False)
        Me.postChangeStatePanel.PerformLayout()
        Me.adminProfilePanel.ResumeLayout(False)
        Me.adminProfilePanel.PerformLayout()
        Me.profileSubPanel2.ResumeLayout(False)
        Me.profileSubPanel2.PerformLayout()
        Me.profileSubPanel1.ResumeLayout(False)
        Me.profileSubPanel1.PerformLayout()
        Me.adminHallsPanel.ResumeLayout(False)
        Me.adminHallsPanel.PerformLayout()
        Me.hallUpdatePanel.ResumeLayout(False)
        Me.hallUpdatePanel.PerformLayout()
        Me.hallAddpanel.ResumeLayout(False)
        Me.hallAddpanel.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.adminUsersPanel.ResumeLayout(False)
        Me.adminUsersPanel.PerformLayout()
        Me.userUpdatePanel.ResumeLayout(False)
        Me.userUpdatePanel.PerformLayout()
        Me.userAddPanel.ResumeLayout(False)
        Me.userAddPanel.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.adminRolePanel.ResumeLayout(False)
        Me.adminRolePanel.PerformLayout()
        Me.roleUpdatePanel.ResumeLayout(False)
        Me.roleUpdatePanel.PerformLayout()
        Me.roleAddPanel.ResumeLayout(False)
        Me.roleAddPanel.PerformLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IPsBtn As Button
    Friend WithEvents postsBtn As Button
    Friend WithEvents dropdown As Panel
    Friend WithEvents CPUsBtn As Button
    Friend WithEvents equipmentsBtn As Button
    Friend WithEvents monitorsBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents profileBtn As Button
    Friend WithEvents aName As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents adminHeader As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents rolesBtn As Button
    Friend WithEvents hallsBtn As Button
    Friend WithEvents userBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents adminLogout As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents adminHomePagePanel As Panel
    Friend WithEvents userNumber As Label
    Friend WithEvents userbuttoninactive As Button
    Friend WithEvents nonActiveMonitorNumber As Label
    Friend WithEvents activeMonitorNumber As Label
    Friend WithEvents nonActiveIPNumber As Label
    Friend WithEvents activeIPNumber As Label
    Friend WithEvents nonActiveCPUNumber As Label
    Friend WithEvents activeCPUNumber As Label
    Friend WithEvents monitorbuttoninactive As Button
    Friend WithEvents IPbuttoninactive As Button
    Friend WithEvents CPUbuttoninactive As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents adminEquipmentPanel As Panel
    Friend WithEvents confirmMsgE As Label
    Friend WithEvents hallSearchBoxE As ComboBox
    Friend WithEvents searchErrorE As Label
    Friend WithEvents printBtnE As Button
    Friend WithEvents exportBtnE As Button
    Friend WithEvents equipmentSearchBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EquipmentTitle As Label
    Friend WithEvents statePanel As Panel
    Friend WithEvents stateChangeBtn As Button
    Friend WithEvents equipmentDeleteBtn As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents equipmentState As ComboBox
    Friend WithEvents addEquipmentBtn As Button
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents userSearchBoxE As ComboBox
    Friend WithEvents addEquipmentPanel As Panel
    Friend WithEvents postIdInput As ComboBox
    Friend WithEvents equipmentStateInput As ComboBox
    Friend WithEvents equipmentTypeInput As ComboBox
    Friend WithEvents addEquipmentErrorMsg As Label
    Friend WithEvents hallInput As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents addEquipmentCancelBtn As Button
    Friend WithEvents addEquipmentValidationBtn As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents adminPostPanel As Panel
    Friend WithEvents confirmMsgP As Label
    Friend WithEvents hallSearchBoxP As ComboBox
    Friend WithEvents searchErrorP As Label
    Friend WithEvents printBtnP As Button
    Friend WithEvents exportBtnP As Button
    Friend WithEvents postSearchBox As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents postTitle As Label
    Friend WithEvents postChangeStatePanel As Panel
    Friend WithEvents postDeleteBtn As Button
    Friend WithEvents postChangeBtn As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents postChangeStateInput As ComboBox
    Friend WithEvents addPostBtn As Button
    Friend WithEvents Label32 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents stateSearchBoxP As ComboBox
    Friend WithEvents addPostPanel As Panel
    Friend WithEvents postPostIdInput As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents postStateInput As ComboBox
    Friend WithEvents addPostErrorMsg As Label
    Friend WithEvents postHallInput As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents addPostCancelBtn As Button
    Friend WithEvents addPostValidationBtn As Button
    Friend WithEvents adminProfilePanel As Panel
    Friend WithEvents profileSubPanel1 As Panel
    Friend WithEvents updateProfileShowBtn As Button
    Friend WithEvents adminEmailProfile As Label
    Friend WithEvents adminTitleProfile As Label
    Friend WithEvents adminPhoneNumberProfile As Label
    Friend WithEvents adminNameProfile As Label
    Friend WithEvents adminEmailProfileLabel As Label
    Friend WithEvents adminPhoneNumberProfileLabel As Label
    Friend WithEvents adminTitleProfileLabel As Label
    Friend WithEvents adminNameProfileLabel As Label
    Friend WithEvents profileTitle As Label
    Friend WithEvents profileSubPanel2 As Panel
    Friend WithEvents userConfirmPwdProfileInput As TextBox
    Friend WithEvents userConfirmPwdProfileLabel As Label
    Friend WithEvents updateProfileCancelBtn As Button
    Friend WithEvents updateProfileErrorMsg As Label
    Friend WithEvents userPwdProfileInput As TextBox
    Friend WithEvents userPhoneNumberProfileInput As TextBox
    Friend WithEvents userEmailProfileInput As TextBox
    Friend WithEvents userNameProfileInput As TextBox
    Friend WithEvents updateProfileValidateBtn As Button
    Friend WithEvents userEmailProfileLabel2 As Label
    Friend WithEvents userPhoneNumberProfileLabel2 As Label
    Friend WithEvents userPwdProfileLabel As Label
    Friend WithEvents userNameProfileLabel2 As Label
    Friend WithEvents adminHallsPanel As Panel
    Friend WithEvents hallAddBtn As Button
    Friend WithEvents confirmMsgH As Label
    Friend WithEvents HallUpdateBtn As Button
    Friend WithEvents hallSearchBoxH As ComboBox
    Friend WithEvents searchErrorH As Label
    Friend WithEvents PrintBtnH As Button
    Friend WithEvents exportBtnH As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Label21 As Label
    Friend WithEvents HallDeleteBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents hallAddpanel As Panel
    Friend WithEvents addHallErrorMsg As Label
    Friend WithEvents HallAddCancelBtn As Button
    Friend WithEvents adminAddHallNameInput As TextBox
    Friend WithEvents HallAddValidateBtn As Button
    Friend WithEvents adminAddHallNameLabel As Label
    Friend WithEvents hallUpdatePanel As Panel
    Friend WithEvents hallUpdateCancelBtn As Button
    Friend WithEvents adminUpdateHallNameInput As TextBox
    Friend WithEvents hallUpdateValidateBtn As Button
    Friend WithEvents adminUpdateHallNameLabel As Label
    Friend WithEvents adminUsersPanel As Panel
    Friend WithEvents userSearchBox As TextBox
    Friend WithEvents userAddBtn As Button
    Friend WithEvents confirmMsgU As Label
    Friend WithEvents userUpdateBtn As Button
    Friend WithEvents searchErrorU As Label
    Friend WithEvents PrintBtnU As Button
    Friend WithEvents exportBtnU As Button
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents userDeleteBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents userAddPanel As Panel
    Friend WithEvents addUserErrorMsg As Label
    Friend WithEvents userUserAddTitleInput As ComboBox
    Friend WithEvents userUserAddConfirmPwdInput As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents userUserAddPwdInput As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents userUserAddPhoneInput As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents userUserAddEmailInput As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents userAddCancelBtn As Button
    Friend WithEvents userUserAddNameInput As TextBox
    Friend WithEvents userAddvalidationBtn As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents userUpdatePanel As Panel
    Friend WithEvents userUserTitleInput As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents userUserPhoneInput As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents userUserEmailInput As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents userCancelBtn As Button
    Friend WithEvents userUserNameInput As TextBox
    Friend WithEvents userUpdateValidationBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents adminRolePanel As Panel
    Friend WithEvents roleDeleteBtn As Button
    Friend WithEvents roleAddBtn As Button
    Friend WithEvents confirmMsgR As Label
    Friend WithEvents roleUpdateBtn As Button
    Friend WithEvents searchErrorR As Label
    Friend WithEvents PrintBtnR As Button
    Friend WithEvents exportBtnR As Button
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents Roles As Label
    Friend WithEvents roleAddPanel As Panel
    Friend WithEvents addRoleErrorMsg As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents roleAddCancelBtn As Button
    Friend WithEvents titleAddNameInput As TextBox
    Friend WithEvents roleAddValidationBtn As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents roleUpdatePanel As Panel
    Friend WithEvents roleUpdateCancelBtn As Button
    Friend WithEvents titleNameInput As TextBox
    Friend WithEvents roleUpdateValidationBtn As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents monitors As Label
    Friend WithEvents IP As Label
    Friend WithEvents CPUs As Label
    Friend WithEvents Equipments As Label
    Friend WithEvents Posts As Label
    Friend WithEvents Halls As Label
    Friend WithEvents Users As Label
    Friend WithEvents Roleslabel As Label
    Friend WithEvents profile As Label
    Friend WithEvents CPUsBtn2 As Button
    Friend WithEvents IPsBtn2 As Button
    Friend WithEvents monitorsBtn2 As Button
    Friend WithEvents usersBtn2 As Button
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label39 As Label
End Class
