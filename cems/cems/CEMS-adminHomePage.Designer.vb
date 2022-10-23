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
        Me.CPUsBtn = New System.Windows.Forms.Button()
        Me.monitorsBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rolesBtn = New System.Windows.Forms.Button()
        Me.hallsBtn = New System.Windows.Forms.Button()
        Me.userBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.profileBtn = New System.Windows.Forms.Button()
        Me.aName = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.adminHeader = New System.Windows.Forms.Panel()
        Me.adminLogout = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.equipmentsBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AdminHomePagePanelUserControl1 = New cems.adminHomePagePanelUserControl()
        Me.AdminEquipmentPanelUserControl1 = New cems.adminEquipmentPanelUserControl()
        Me.AmdinPostPanelUserControl1 = New cems.amdinPostPanelUserControl()
        Me.AdminProfilePanelUserControl1 = New cems.adminProfilePanelUserControl()
        Me.AdminHallsPanelUserControl1 = New cems.adminHallsPanelUserControl()
        Me.HallUpdatePanelUserControl1 = New cems.hallUpdatePanelUserControl()
        Me.HallAddPanelUserControl1 = New cems.hallAddPanelUserControl()
        Me.AdminUserPanelUserControl1 = New cems.adminUserPanelUserControl()
        Me.UserUpdatePanelUserControl1 = New cems.userUpdatePanelUserControl()
        Me.UserAddPanelUserControl1 = New cems.userAddPanelUserControl()
        Me.RoleUpdatePanelUserControl1 = New cems.roleUpdatePanelUserControl()
        Me.RoleAddPanelUserControl1 = New cems.roleAddPanelUserControl()
        Me.AdminRolePanelUserControl1 = New cems.adminRolePanelUserControl()
        Me.AddPostPanelUserControl1 = New cems.addPostPanelUserControl()
        Me.AddEquipmentPanelUserControl1 = New cems.addEquipmentPanelUserControl()
        Me.dropdown.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.adminHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.dropdown.Location = New System.Drawing.Point(0, 305)
        Me.dropdown.Margin = New System.Windows.Forms.Padding(0)
        Me.dropdown.MaximumSize = New System.Drawing.Size(156, 187)
        Me.dropdown.MinimumSize = New System.Drawing.Size(156, 46)
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
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.dropdown)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.rolesBtn)
        Me.Panel2.Controls.Add(Me.hallsBtn)
        Me.Panel2.Controls.Add(Me.userBtn)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.profileBtn)
        Me.Panel2.Controls.Add(Me.postsBtn)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.MaximumSize = New System.Drawing.Size(170, 530)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(157, 530)
        Me.Panel2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(41, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Admin"
        '
        'rolesBtn
        '
        Me.rolesBtn.BackColor = System.Drawing.Color.LightSlateGray
        Me.rolesBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.rolesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rolesBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.rolesBtn.Location = New System.Drawing.Point(0, 258)
        Me.rolesBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.rolesBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.rolesBtn.Name = "rolesBtn"
        Me.rolesBtn.Size = New System.Drawing.Size(156, 47)
        Me.rolesBtn.TabIndex = 16
        Me.rolesBtn.Text = "Roles"
        Me.rolesBtn.UseVisualStyleBackColor = False
        '
        'hallsBtn
        '
        Me.hallsBtn.BackColor = System.Drawing.Color.LightSlateGray
        Me.hallsBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.hallsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hallsBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.hallsBtn.Location = New System.Drawing.Point(0, 164)
        Me.hallsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.hallsBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.hallsBtn.Name = "hallsBtn"
        Me.hallsBtn.Size = New System.Drawing.Size(156, 47)
        Me.hallsBtn.TabIndex = 15
        Me.hallsBtn.Text = "Halls"
        Me.hallsBtn.UseVisualStyleBackColor = False
        '
        'userBtn
        '
        Me.userBtn.BackColor = System.Drawing.Color.LightSlateGray
        Me.userBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.userBtn.Location = New System.Drawing.Point(0, 211)
        Me.userBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.userBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.userBtn.Name = "userBtn"
        Me.userBtn.Size = New System.Drawing.Size(156, 47)
        Me.userBtn.TabIndex = 14
        Me.userBtn.Text = "Users"
        Me.userBtn.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(-1, 217)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.MaximumSize = New System.Drawing.Size(156, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 47)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Posts"
        Me.Button2.UseVisualStyleBackColor = False
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
        'aName
        '
        Me.aName.AutoSize = True
        Me.aName.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.aName.Location = New System.Drawing.Point(162, 49)
        Me.aName.Name = "aName"
        Me.aName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.aName.Size = New System.Drawing.Size(75, 19)
        Me.aName.TabIndex = 5
        Me.aName.Text = "******"
        Me.aName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 97)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.FlowLayoutPanel1.TabIndex = 1
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
        'adminHeader
        '
        Me.adminHeader.BackColor = System.Drawing.Color.LightSlateGray
        Me.adminHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adminHeader.Controls.Add(Me.adminLogout)
        Me.adminHeader.Controls.Add(Me.Label2)
        Me.adminHeader.Controls.Add(Me.PictureBox1)
        Me.adminHeader.Controls.Add(Me.aName)
        Me.adminHeader.Controls.Add(Me.FlowLayoutPanel1)
        Me.adminHeader.Location = New System.Drawing.Point(1, 0)
        Me.adminHeader.Name = "adminHeader"
        Me.adminHeader.Size = New System.Drawing.Size(883, 73)
        Me.adminHeader.TabIndex = 5
        '
        'adminLogout
        '
        Me.adminLogout.BackColor = System.Drawing.Color.Transparent
        Me.adminLogout.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.adminLogout.FlatAppearance.BorderSize = 0
        Me.adminLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminLogout.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.adminLogout.Location = New System.Drawing.Point(794, 27)
        Me.adminLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.adminLogout.MaximumSize = New System.Drawing.Size(156, 50)
        Me.adminLogout.Name = "adminLogout"
        Me.adminLogout.Size = New System.Drawing.Size(57, 22)
        Me.adminLogout.TabIndex = 37
        Me.adminLogout.Text = "logout"
        Me.adminLogout.UseVisualStyleBackColor = False
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cems.My.Resources.Resources.logo_light
        Me.PictureBox1.Location = New System.Drawing.Point(171, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'AdminHomePagePanelUserControl1
        '
        Me.AdminHomePagePanelUserControl1.Location = New System.Drawing.Point(160, 72)
        Me.AdminHomePagePanelUserControl1.Name = "AdminHomePagePanelUserControl1"
        Me.AdminHomePagePanelUserControl1.Size = New System.Drawing.Size(723, 421)
        Me.AdminHomePagePanelUserControl1.TabIndex = 7
        '
        'AdminEquipmentPanelUserControl1
        '
        Me.AdminEquipmentPanelUserControl1.Location = New System.Drawing.Point(160, 72)
        Me.AdminEquipmentPanelUserControl1.Name = "AdminEquipmentPanelUserControl1"
        Me.AdminEquipmentPanelUserControl1.Size = New System.Drawing.Size(724, 424)
        Me.AdminEquipmentPanelUserControl1.TabIndex = 8
        '
        'AmdinPostPanelUserControl1
        '
        Me.AmdinPostPanelUserControl1.Location = New System.Drawing.Point(160, 72)
        Me.AmdinPostPanelUserControl1.Name = "AmdinPostPanelUserControl1"
        Me.AmdinPostPanelUserControl1.Size = New System.Drawing.Size(725, 423)
        Me.AmdinPostPanelUserControl1.TabIndex = 9
        '
        'AdminProfilePanelUserControl1
        '
        Me.AdminProfilePanelUserControl1.Location = New System.Drawing.Point(158, 72)
        Me.AdminProfilePanelUserControl1.Name = "AdminProfilePanelUserControl1"
        Me.AdminProfilePanelUserControl1.Size = New System.Drawing.Size(725, 424)
        Me.AdminProfilePanelUserControl1.TabIndex = 10
        '
        'AdminHallsPanelUserControl1
        '
        Me.AdminHallsPanelUserControl1.Location = New System.Drawing.Point(158, 72)
        Me.AdminHallsPanelUserControl1.Name = "AdminHallsPanelUserControl1"
        Me.AdminHallsPanelUserControl1.Size = New System.Drawing.Size(723, 422)
        Me.AdminHallsPanelUserControl1.TabIndex = 11
        '
        'HallUpdatePanelUserControl1
        '
        Me.HallUpdatePanelUserControl1.Location = New System.Drawing.Point(231, 201)
        Me.HallUpdatePanelUserControl1.Name = "HallUpdatePanelUserControl1"
        Me.HallUpdatePanelUserControl1.Size = New System.Drawing.Size(622, 235)
        Me.HallUpdatePanelUserControl1.TabIndex = 12
        '
        'HallAddPanelUserControl1
        '
        Me.HallAddPanelUserControl1.Location = New System.Drawing.Point(231, 201)
        Me.HallAddPanelUserControl1.Name = "HallAddPanelUserControl1"
        Me.HallAddPanelUserControl1.Size = New System.Drawing.Size(624, 237)
        Me.HallAddPanelUserControl1.TabIndex = 13
        '
        'AdminUserPanelUserControl1
        '
        Me.AdminUserPanelUserControl1.Location = New System.Drawing.Point(158, 73)
        Me.AdminUserPanelUserControl1.Name = "AdminUserPanelUserControl1"
        Me.AdminUserPanelUserControl1.Size = New System.Drawing.Size(726, 421)
        Me.AdminUserPanelUserControl1.TabIndex = 14
        '
        'UserUpdatePanelUserControl1
        '
        Me.UserUpdatePanelUserControl1.Location = New System.Drawing.Point(232, 201)
        Me.UserUpdatePanelUserControl1.Name = "UserUpdatePanelUserControl1"
        Me.UserUpdatePanelUserControl1.Size = New System.Drawing.Size(623, 265)
        Me.UserUpdatePanelUserControl1.TabIndex = 15
        '
        'UserAddPanelUserControl1
        '
        Me.UserAddPanelUserControl1.Location = New System.Drawing.Point(232, 201)
        Me.UserAddPanelUserControl1.Name = "UserAddPanelUserControl1"
        Me.UserAddPanelUserControl1.Size = New System.Drawing.Size(624, 267)
        Me.UserAddPanelUserControl1.TabIndex = 16
        '
        'RoleUpdatePanelUserControl1
        '
        Me.RoleUpdatePanelUserControl1.Location = New System.Drawing.Point(232, 201)
        Me.RoleUpdatePanelUserControl1.Name = "RoleUpdatePanelUserControl1"
        Me.RoleUpdatePanelUserControl1.Size = New System.Drawing.Size(624, 268)
        Me.RoleUpdatePanelUserControl1.TabIndex = 17
        '
        'RoleAddPanelUserControl1
        '
        Me.RoleAddPanelUserControl1.Location = New System.Drawing.Point(232, 201)
        Me.RoleAddPanelUserControl1.Name = "RoleAddPanelUserControl1"
        Me.RoleAddPanelUserControl1.Size = New System.Drawing.Size(624, 267)
        Me.RoleAddPanelUserControl1.TabIndex = 18
        '
        'AdminRolePanelUserControl1
        '
        Me.AdminRolePanelUserControl1.Location = New System.Drawing.Point(158, 72)
        Me.AdminRolePanelUserControl1.Name = "AdminRolePanelUserControl1"
        Me.AdminRolePanelUserControl1.Size = New System.Drawing.Size(725, 422)
        Me.AdminRolePanelUserControl1.TabIndex = 19
        '
        'AddPostPanelUserControl1
        '
        Me.AddPostPanelUserControl1.Location = New System.Drawing.Point(228, 201)
        Me.AddPostPanelUserControl1.Name = "AddPostPanelUserControl1"
        Me.AddPostPanelUserControl1.Size = New System.Drawing.Size(625, 268)
        Me.AddPostPanelUserControl1.TabIndex = 20
        '
        'AddEquipmentPanelUserControl1
        '
        Me.AddEquipmentPanelUserControl1.Location = New System.Drawing.Point(232, 201)
        Me.AddEquipmentPanelUserControl1.Name = "AddEquipmentPanelUserControl1"
        Me.AddEquipmentPanelUserControl1.Size = New System.Drawing.Size(634, 281)
        Me.AddEquipmentPanelUserControl1.TabIndex = 21
        '
        'adminhomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(884, 494)
        Me.Controls.Add(Me.AddEquipmentPanelUserControl1)
        Me.Controls.Add(Me.AddPostPanelUserControl1)
        Me.Controls.Add(Me.AdminRolePanelUserControl1)
        Me.Controls.Add(Me.RoleAddPanelUserControl1)
        Me.Controls.Add(Me.RoleUpdatePanelUserControl1)
        Me.Controls.Add(Me.UserAddPanelUserControl1)
        Me.Controls.Add(Me.UserUpdatePanelUserControl1)
        Me.Controls.Add(Me.AdminUserPanelUserControl1)
        Me.Controls.Add(Me.HallAddPanelUserControl1)
        Me.Controls.Add(Me.HallUpdatePanelUserControl1)
        Me.Controls.Add(Me.AdminHallsPanelUserControl1)
        Me.Controls.Add(Me.AdminProfilePanelUserControl1)
        Me.Controls.Add(Me.AmdinPostPanelUserControl1)
        Me.Controls.Add(Me.AdminEquipmentPanelUserControl1)
        Me.Controls.Add(Me.AdminHomePagePanelUserControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.adminHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(300, 300)
        Me.MaximumSize = New System.Drawing.Size(900, 550)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "adminhomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Page"
        Me.dropdown.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.adminHeader.ResumeLayout(False)
        Me.adminHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label2 As Label
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
    Friend WithEvents AdminHomePagePanelUserControl1 As adminHomePagePanelUserControl
    Friend WithEvents AdminEquipmentPanelUserControl1 As adminEquipmentPanelUserControl
    Friend WithEvents AmdinPostPanelUserControl1 As amdinPostPanelUserControl
    Friend WithEvents AdminProfilePanelUserControl1 As adminProfilePanelUserControl
    Friend WithEvents AdminHallsPanelUserControl1 As adminHallsPanelUserControl
    Friend WithEvents HallUpdatePanelUserControl1 As hallUpdatePanelUserControl
    Friend WithEvents HallAddPanelUserControl1 As hallAddPanelUserControl
    Friend WithEvents AdminUserPanelUserControl1 As adminUserPanelUserControl
    Friend WithEvents UserUpdatePanelUserControl1 As userUpdatePanelUserControl
    Friend WithEvents UserAddPanelUserControl1 As userAddPanelUserControl
    Friend WithEvents RoleUpdatePanelUserControl1 As roleUpdatePanelUserControl
    Friend WithEvents RoleAddPanelUserControl1 As roleAddPanelUserControl
    Friend WithEvents AdminRolePanelUserControl1 As adminRolePanelUserControl
    Friend WithEvents AddPostPanelUserControl1 As addPostPanelUserControl
    Friend WithEvents AddEquipmentPanelUserControl1 As addEquipmentPanelUserControl
End Class
