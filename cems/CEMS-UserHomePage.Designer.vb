﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.userHomePagePanel = New System.Windows.Forms.Panel()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.profile = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Posts = New System.Windows.Forms.Label()
        Me.Equipments = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.CPUs = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.IP = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.monitors = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.CPUsBtn2 = New System.Windows.Forms.Button()
        Me.IPsBtn2 = New System.Windows.Forms.Button()
        Me.monitorsBtn2 = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nonActiveMonitorNumber = New System.Windows.Forms.Label()
        Me.activeMonitorNumber = New System.Windows.Forms.Label()
        Me.nonActiveIPNumber = New System.Windows.Forms.Label()
        Me.activeIPNumber = New System.Windows.Forms.Label()
        Me.nonActiveCPUNumber = New System.Windows.Forms.Label()
        Me.activeCPUNumber = New System.Windows.Forms.Label()
        Me.monitorbuttoninactive = New System.Windows.Forms.Button()
        Me.IPbuttoninactive = New System.Windows.Forms.Button()
        Me.CPUbuttoninactive = New System.Windows.Forms.Button()
        Me.userProfilePanel = New System.Windows.Forms.Panel()
        Me.profileSubPanel1 = New System.Windows.Forms.Panel()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.adminEmailProfile = New System.Windows.Forms.Label()
        Me.adminTitleProfile = New System.Windows.Forms.Label()
        Me.adminPhoneNumberProfile = New System.Windows.Forms.Label()
        Me.adminNameProfile = New System.Windows.Forms.Label()
        Me.adminEmailProfileLabel = New System.Windows.Forms.Label()
        Me.adminPhoneNumberProfileLabel = New System.Windows.Forms.Label()
        Me.adminTitleProfileLabel = New System.Windows.Forms.Label()
        Me.adminNameProfileLabel = New System.Windows.Forms.Label()
        Me.updateProfileShowBtn = New System.Windows.Forms.Button()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.profileSubPanel2 = New System.Windows.Forms.Panel()
        Me.userPwdProfileInput = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.userConfirmPwdProfileInput = New System.Windows.Forms.TextBox()
        Me.userConfirmPwdProfileLabel = New System.Windows.Forms.Label()
        Me.updateProfileCancelBtn = New System.Windows.Forms.Button()
        Me.updateProfileErrorMsg = New System.Windows.Forms.Label()
        Me.userPhoneNumberProfileInput = New System.Windows.Forms.TextBox()
        Me.userEmailProfileInput = New System.Windows.Forms.TextBox()
        Me.userNameProfileInput = New System.Windows.Forms.TextBox()
        Me.updateProfileValidateBtn = New System.Windows.Forms.Button()
        Me.userEmailProfileLabel2 = New System.Windows.Forms.Label()
        Me.userPhoneNumberProfileLabel2 = New System.Windows.Forms.Label()
        Me.userPwdProfileLabel = New System.Windows.Forms.Label()
        Me.userNameProfileLabel2 = New System.Windows.Forms.Label()
        Me.profileTitle = New System.Windows.Forms.Label()
        Me.userHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.dropdown.SuspendLayout()
        Me.userHomePagePanel.SuspendLayout()
        Me.userProfilePanel.SuspendLayout()
        Me.profileSubPanel1.SuspendLayout()
        Me.profileSubPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'userHeader
        '
        Me.userHeader.BackColor = System.Drawing.Color.MintCream
        Me.userHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.userHeader.Controls.Add(Me.userLogout)
        Me.userHeader.Controls.Add(Me.PictureBox1)
        Me.userHeader.Controls.Add(Me.uName)
        Me.userHeader.Controls.Add(Me.FlowLayoutPanel1)
        Me.userHeader.Location = New System.Drawing.Point(231, 13)
        Me.userHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.userHeader.Name = "userHeader"
        Me.userHeader.Size = New System.Drawing.Size(932, 78)
        Me.userHeader.TabIndex = 0
        '
        'userLogout
        '
        Me.userLogout.BackColor = System.Drawing.Color.MintCream
        Me.userLogout.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.userLogout.FlatAppearance.BorderSize = 2
        Me.userLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.userLogout.ForeColor = System.Drawing.Color.SeaGreen
        Me.userLogout.Location = New System.Drawing.Point(803, 23)
        Me.userLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.userLogout.MaximumSize = New System.Drawing.Size(208, 62)
        Me.userLogout.Name = "userLogout"
        Me.userLogout.Size = New System.Drawing.Size(80, 30)
        Me.userLogout.TabIndex = 23
        Me.userLogout.Text = "logout"
        Me.userLogout.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.MintCream
        Me.Label2.Location = New System.Drawing.Point(55, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "User"
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
        'uName
        '
        Me.uName.AutoSize = True
        Me.uName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.uName.ForeColor = System.Drawing.Color.SeaGreen
        Me.uName.Location = New System.Drawing.Point(26, 54)
        Me.uName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.uName.Name = "uName"
        Me.uName.Size = New System.Drawing.Size(58, 24)
        Me.uName.TabIndex = 5
        Me.uName.Text = "******"
        Me.uName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(4, 119)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(267, 123)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label48)
        Me.Panel2.Controls.Add(Me.Posts)
        Me.Panel2.Controls.Add(Me.Label40)
        Me.Panel2.Controls.Add(Me.profile)
        Me.Panel2.Controls.Add(Me.Label39)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.profileBtn)
        Me.Panel2.Controls.Add(Me.postsBtn)
        Me.Panel2.Controls.Add(Me.Equipments)
        Me.Panel2.Controls.Add(Me.dropdown)
        Me.Panel2.ForeColor = System.Drawing.Color.MintCream
        Me.Panel2.Location = New System.Drawing.Point(13, 13)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.MaximumSize = New System.Drawing.Size(213, 615)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(209, 607)
        Me.Panel2.TabIndex = 2
        '
        'profileBtn
        '
        Me.profileBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.profileBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.profileBtn.FlatAppearance.BorderSize = 0
        Me.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.profileBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.profileBtn.Location = New System.Drawing.Point(0, 87)
        Me.profileBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.profileBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.profileBtn.Name = "profileBtn"
        Me.profileBtn.Size = New System.Drawing.Size(208, 58)
        Me.profileBtn.TabIndex = 10
        Me.profileBtn.UseVisualStyleBackColor = False
        '
        'postsBtn
        '
        Me.postsBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.postsBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.postsBtn.FlatAppearance.BorderSize = 0
        Me.postsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.postsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.postsBtn.Location = New System.Drawing.Point(0, 144)
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
        Me.dropdown.Controls.Add(Me.Label41)
        Me.dropdown.Controls.Add(Me.IP)
        Me.dropdown.Controls.Add(Me.Label42)
        Me.dropdown.Controls.Add(Me.CPUs)
        Me.dropdown.Controls.Add(Me.Label43)
        Me.dropdown.Controls.Add(Me.Label44)
        Me.dropdown.Controls.Add(Me.CPUsBtn)
        Me.dropdown.Controls.Add(Me.IPsBtn)
        Me.dropdown.Controls.Add(Me.equipmentsBtn)
        Me.dropdown.Controls.Add(Me.monitorsBtn)
        Me.dropdown.Location = New System.Drawing.Point(0, 202)
        Me.dropdown.Margin = New System.Windows.Forms.Padding(4)
        Me.dropdown.MaximumSize = New System.Drawing.Size(208, 230)
        Me.dropdown.MinimumSize = New System.Drawing.Size(208, 59)
        Me.dropdown.Name = "dropdown"
        Me.dropdown.Size = New System.Drawing.Size(208, 230)
        Me.dropdown.TabIndex = 7
        '
        'CPUsBtn
        '
        Me.CPUsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.CPUsBtn.FlatAppearance.BorderSize = 0
        Me.CPUsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CPUsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.CPUsBtn.Location = New System.Drawing.Point(0, 58)
        Me.CPUsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.CPUsBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.CPUsBtn.Name = "CPUsBtn"
        Me.CPUsBtn.Size = New System.Drawing.Size(208, 58)
        Me.CPUsBtn.TabIndex = 9
        Me.CPUsBtn.UseVisualStyleBackColor = False
        '
        'IPsBtn
        '
        Me.IPsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.IPsBtn.FlatAppearance.BorderSize = 0
        Me.IPsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IPsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.IPsBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IPsBtn.Location = New System.Drawing.Point(0, 114)
        Me.IPsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.IPsBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.IPsBtn.Name = "IPsBtn"
        Me.IPsBtn.Size = New System.Drawing.Size(208, 58)
        Me.IPsBtn.TabIndex = 7
        Me.IPsBtn.UseVisualStyleBackColor = False
        '
        'equipmentsBtn
        '
        Me.equipmentsBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.equipmentsBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.equipmentsBtn.FlatAppearance.BorderSize = 0
        Me.equipmentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.equipmentsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
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
        Me.monitorsBtn.Location = New System.Drawing.Point(0, 172)
        Me.monitorsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.monitorsBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.monitorsBtn.Name = "monitorsBtn"
        Me.monitorsBtn.Size = New System.Drawing.Size(208, 58)
        Me.monitorsBtn.TabIndex = 8
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(16, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 29)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "User Home Page"
        '
        'userHomePagePanel
        '
        Me.userHomePagePanel.BackColor = System.Drawing.Color.MintCream
        Me.userHomePagePanel.Controls.Add(Me.CPUsBtn2)
        Me.userHomePagePanel.Controls.Add(Me.IPsBtn2)
        Me.userHomePagePanel.Controls.Add(Me.monitorsBtn2)
        Me.userHomePagePanel.Controls.Add(Me.Label37)
        Me.userHomePagePanel.Controls.Add(Me.Label36)
        Me.userHomePagePanel.Controls.Add(Me.Label3)
        Me.userHomePagePanel.Controls.Add(Me.nonActiveMonitorNumber)
        Me.userHomePagePanel.Controls.Add(Me.activeMonitorNumber)
        Me.userHomePagePanel.Controls.Add(Me.nonActiveIPNumber)
        Me.userHomePagePanel.Controls.Add(Me.activeIPNumber)
        Me.userHomePagePanel.Controls.Add(Me.nonActiveCPUNumber)
        Me.userHomePagePanel.Controls.Add(Me.activeCPUNumber)
        Me.userHomePagePanel.Controls.Add(Me.monitorbuttoninactive)
        Me.userHomePagePanel.Controls.Add(Me.IPbuttoninactive)
        Me.userHomePagePanel.Controls.Add(Me.CPUbuttoninactive)
        Me.userHomePagePanel.Controls.Add(Me.Label1)
        Me.userHomePagePanel.Location = New System.Drawing.Point(229, 100)
        Me.userHomePagePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.userHomePagePanel.Name = "userHomePagePanel"
        Me.userHomePagePanel.Size = New System.Drawing.Size(934, 520)
        Me.userHomePagePanel.TabIndex = 4
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
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.MintCream
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Yellow
        Me.Label39.Location = New System.Drawing.Point(10, 82)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(190, 2)
        Me.Label39.TabIndex = 50
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
        Me.Label40.TabIndex = 52
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'profile
        '
        Me.profile.AutoSize = True
        Me.profile.BackColor = System.Drawing.Color.SeaGreen
        Me.profile.Enabled = False
        Me.profile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profile.ForeColor = System.Drawing.Color.MintCream
        Me.profile.Location = New System.Drawing.Point(77, 106)
        Me.profile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.profile.Name = "profile"
        Me.profile.Size = New System.Drawing.Size(64, 20)
        Me.profile.TabIndex = 51
        Me.profile.Text = "Profile"
        Me.profile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label48.TabIndex = 60
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Posts
        '
        Me.Posts.AutoSize = True
        Me.Posts.BackColor = System.Drawing.Color.SeaGreen
        Me.Posts.Enabled = False
        Me.Posts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Posts.ForeColor = System.Drawing.Color.MintCream
        Me.Posts.Location = New System.Drawing.Point(77, 163)
        Me.Posts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Posts.Name = "Posts"
        Me.Posts.Size = New System.Drawing.Size(57, 20)
        Me.Posts.TabIndex = 59
        Me.Posts.Text = "Posts"
        Me.Posts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Equipments
        '
        Me.Equipments.AutoSize = True
        Me.Equipments.BackColor = System.Drawing.Color.SeaGreen
        Me.Equipments.Enabled = False
        Me.Equipments.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Equipments.ForeColor = System.Drawing.Color.MintCream
        Me.Equipments.Location = New System.Drawing.Point(77, 219)
        Me.Equipments.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Equipments.Name = "Equipments"
        Me.Equipments.Size = New System.Drawing.Size(107, 20)
        Me.Equipments.TabIndex = 55
        Me.Equipments.Text = "Equipments"
        Me.Equipments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.SeaGreen
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.MintCream
        Me.Label44.Image = CType(resources.GetObject("Label44.Image"), System.Drawing.Image)
        Me.Label44.Location = New System.Drawing.Point(37, 17)
        Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(20, 20)
        Me.Label44.TabIndex = 56
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CPUs
        '
        Me.CPUs.AutoSize = True
        Me.CPUs.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.CPUs.Enabled = False
        Me.CPUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPUs.ForeColor = System.Drawing.Color.MintCream
        Me.CPUs.Location = New System.Drawing.Point(77, 82)
        Me.CPUs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CPUs.Name = "CPUs"
        Me.CPUs.Size = New System.Drawing.Size(64, 20)
        Me.CPUs.TabIndex = 57
        Me.CPUs.Text = "CPU'S"
        Me.CPUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label43.TabIndex = 58
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IP
        '
        Me.IP.AutoSize = True
        Me.IP.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.IP.Enabled = False
        Me.IP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP.ForeColor = System.Drawing.Color.MintCream
        Me.IP.Location = New System.Drawing.Point(77, 133)
        Me.IP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IP.Name = "IP"
        Me.IP.Size = New System.Drawing.Size(94, 20)
        Me.IP.TabIndex = 59
        Me.IP.Text = "IP Phones"
        Me.IP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label42.TabIndex = 60
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'monitors
        '
        Me.monitors.AutoSize = True
        Me.monitors.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.monitors.Enabled = False
        Me.monitors.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monitors.ForeColor = System.Drawing.Color.MintCream
        Me.monitors.Location = New System.Drawing.Point(77, 183)
        Me.monitors.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.monitors.Name = "monitors"
        Me.monitors.Size = New System.Drawing.Size(82, 20)
        Me.monitors.TabIndex = 61
        Me.monitors.Text = "Monitors"
        Me.monitors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.MintCream
        Me.Label41.Image = CType(resources.GetObject("Label41.Image"), System.Drawing.Image)
        Me.Label41.Location = New System.Drawing.Point(37, 183)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(20, 20)
        Me.Label41.TabIndex = 62
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CPUsBtn2
        '
        Me.CPUsBtn2.BackColor = System.Drawing.Color.Transparent
        Me.CPUsBtn2.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.CPUsBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CPUsBtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.CPUsBtn2.ForeColor = System.Drawing.Color.SeaGreen
        Me.CPUsBtn2.Location = New System.Drawing.Point(245, 226)
        Me.CPUsBtn2.Margin = New System.Windows.Forms.Padding(0)
        Me.CPUsBtn2.MaximumSize = New System.Drawing.Size(208, 62)
        Me.CPUsBtn2.Name = "CPUsBtn2"
        Me.CPUsBtn2.Size = New System.Drawing.Size(76, 27)
        Me.CPUsBtn2.TabIndex = 57
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
        Me.IPsBtn2.Location = New System.Drawing.Point(469, 226)
        Me.IPsBtn2.Margin = New System.Windows.Forms.Padding(0)
        Me.IPsBtn2.MaximumSize = New System.Drawing.Size(208, 62)
        Me.IPsBtn2.Name = "IPsBtn2"
        Me.IPsBtn2.Size = New System.Drawing.Size(76, 27)
        Me.IPsBtn2.TabIndex = 58
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
        Me.monitorsBtn2.Location = New System.Drawing.Point(706, 226)
        Me.monitorsBtn2.Margin = New System.Windows.Forms.Padding(0)
        Me.monitorsBtn2.MaximumSize = New System.Drawing.Size(208, 62)
        Me.monitorsBtn2.Name = "monitorsBtn2"
        Me.monitorsBtn2.Size = New System.Drawing.Size(76, 27)
        Me.monitorsBtn2.TabIndex = 59
        Me.monitorsBtn2.Text = "View"
        Me.monitorsBtn2.UseVisualStyleBackColor = False
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.SeaGreen
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Yellow
        Me.Label37.Location = New System.Drawing.Point(602, 189)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(192, 25)
        Me.Label37.TabIndex = 62
        Me.Label37.Text = "Monitors"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.SeaGreen
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Yellow
        Me.Label36.Location = New System.Drawing.Point(367, 188)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(192, 25)
        Me.Label36.TabIndex = 61
        Me.Label36.Text = "IP Phones"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SeaGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(141, 187)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 25)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "CPU'S"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nonActiveMonitorNumber
        '
        Me.nonActiveMonitorNumber.AutoSize = True
        Me.nonActiveMonitorNumber.BackColor = System.Drawing.Color.MintCream
        Me.nonActiveMonitorNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.nonActiveMonitorNumber.ForeColor = System.Drawing.Color.Red
        Me.nonActiveMonitorNumber.Location = New System.Drawing.Point(648, 239)
        Me.nonActiveMonitorNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nonActiveMonitorNumber.Name = "nonActiveMonitorNumber"
        Me.nonActiveMonitorNumber.Size = New System.Drawing.Size(31, 13)
        Me.nonActiveMonitorNumber.TabIndex = 56
        Me.nonActiveMonitorNumber.Text = "0000"
        '
        'activeMonitorNumber
        '
        Me.activeMonitorNumber.AutoSize = True
        Me.activeMonitorNumber.BackColor = System.Drawing.Color.MintCream
        Me.activeMonitorNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.activeMonitorNumber.ForeColor = System.Drawing.Color.SeaGreen
        Me.activeMonitorNumber.Location = New System.Drawing.Point(612, 239)
        Me.activeMonitorNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.activeMonitorNumber.Name = "activeMonitorNumber"
        Me.activeMonitorNumber.Size = New System.Drawing.Size(31, 13)
        Me.activeMonitorNumber.TabIndex = 55
        Me.activeMonitorNumber.Text = "0000"
        '
        'nonActiveIPNumber
        '
        Me.nonActiveIPNumber.AutoSize = True
        Me.nonActiveIPNumber.BackColor = System.Drawing.Color.MintCream
        Me.nonActiveIPNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.nonActiveIPNumber.ForeColor = System.Drawing.Color.Red
        Me.nonActiveIPNumber.Location = New System.Drawing.Point(414, 239)
        Me.nonActiveIPNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nonActiveIPNumber.Name = "nonActiveIPNumber"
        Me.nonActiveIPNumber.Size = New System.Drawing.Size(31, 13)
        Me.nonActiveIPNumber.TabIndex = 54
        Me.nonActiveIPNumber.Text = "0000"
        '
        'activeIPNumber
        '
        Me.activeIPNumber.AutoSize = True
        Me.activeIPNumber.BackColor = System.Drawing.Color.MintCream
        Me.activeIPNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.activeIPNumber.ForeColor = System.Drawing.Color.SeaGreen
        Me.activeIPNumber.Location = New System.Drawing.Point(377, 239)
        Me.activeIPNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.activeIPNumber.Name = "activeIPNumber"
        Me.activeIPNumber.Size = New System.Drawing.Size(31, 13)
        Me.activeIPNumber.TabIndex = 53
        Me.activeIPNumber.Text = "0000"
        '
        'nonActiveCPUNumber
        '
        Me.nonActiveCPUNumber.AutoSize = True
        Me.nonActiveCPUNumber.BackColor = System.Drawing.Color.Transparent
        Me.nonActiveCPUNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nonActiveCPUNumber.ForeColor = System.Drawing.Color.Red
        Me.nonActiveCPUNumber.Location = New System.Drawing.Point(191, 240)
        Me.nonActiveCPUNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nonActiveCPUNumber.Name = "nonActiveCPUNumber"
        Me.nonActiveCPUNumber.Size = New System.Drawing.Size(31, 13)
        Me.nonActiveCPUNumber.TabIndex = 52
        Me.nonActiveCPUNumber.Text = "0000"
        '
        'activeCPUNumber
        '
        Me.activeCPUNumber.AutoSize = True
        Me.activeCPUNumber.BackColor = System.Drawing.Color.Transparent
        Me.activeCPUNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activeCPUNumber.ForeColor = System.Drawing.Color.SeaGreen
        Me.activeCPUNumber.Location = New System.Drawing.Point(148, 240)
        Me.activeCPUNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.activeCPUNumber.Name = "activeCPUNumber"
        Me.activeCPUNumber.Size = New System.Drawing.Size(31, 13)
        Me.activeCPUNumber.TabIndex = 51
        Me.activeCPUNumber.Text = "0000"
        '
        'monitorbuttoninactive
        '
        Me.monitorbuttoninactive.BackColor = System.Drawing.Color.MintCream
        Me.monitorbuttoninactive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.monitorbuttoninactive.Enabled = False
        Me.monitorbuttoninactive.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.monitorbuttoninactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.monitorbuttoninactive.Image = Global.cems.My.Resources.Resources.monitor1
        Me.monitorbuttoninactive.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.monitorbuttoninactive.Location = New System.Drawing.Point(601, 62)
        Me.monitorbuttoninactive.Margin = New System.Windows.Forms.Padding(4)
        Me.monitorbuttoninactive.Name = "monitorbuttoninactive"
        Me.monitorbuttoninactive.Padding = New System.Windows.Forms.Padding(13, 0, 13, 0)
        Me.monitorbuttoninactive.Size = New System.Drawing.Size(194, 201)
        Me.monitorbuttoninactive.TabIndex = 50
        Me.monitorbuttoninactive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.monitorbuttoninactive.UseVisualStyleBackColor = False
        '
        'IPbuttoninactive
        '
        Me.IPbuttoninactive.BackColor = System.Drawing.Color.MintCream
        Me.IPbuttoninactive.Enabled = False
        Me.IPbuttoninactive.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.IPbuttoninactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IPbuttoninactive.Image = CType(resources.GetObject("IPbuttoninactive.Image"), System.Drawing.Image)
        Me.IPbuttoninactive.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.IPbuttoninactive.Location = New System.Drawing.Point(366, 62)
        Me.IPbuttoninactive.Margin = New System.Windows.Forms.Padding(4)
        Me.IPbuttoninactive.Name = "IPbuttoninactive"
        Me.IPbuttoninactive.Padding = New System.Windows.Forms.Padding(13, 0, 13, 0)
        Me.IPbuttoninactive.Size = New System.Drawing.Size(194, 201)
        Me.IPbuttoninactive.TabIndex = 49
        Me.IPbuttoninactive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IPbuttoninactive.UseVisualStyleBackColor = False
        '
        'CPUbuttoninactive
        '
        Me.CPUbuttoninactive.BackColor = System.Drawing.Color.MintCream
        Me.CPUbuttoninactive.Enabled = False
        Me.CPUbuttoninactive.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.CPUbuttoninactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CPUbuttoninactive.Image = Global.cems.My.Resources.Resources.cpu1
        Me.CPUbuttoninactive.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CPUbuttoninactive.Location = New System.Drawing.Point(140, 62)
        Me.CPUbuttoninactive.Margin = New System.Windows.Forms.Padding(4)
        Me.CPUbuttoninactive.Name = "CPUbuttoninactive"
        Me.CPUbuttoninactive.Padding = New System.Windows.Forms.Padding(13, 0, 13, 0)
        Me.CPUbuttoninactive.Size = New System.Drawing.Size(194, 201)
        Me.CPUbuttoninactive.TabIndex = 48
        Me.CPUbuttoninactive.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CPUbuttoninactive.UseVisualStyleBackColor = False
        '
        'userProfilePanel
        '
        Me.userProfilePanel.Controls.Add(Me.profileSubPanel1)
        Me.userProfilePanel.Controls.Add(Me.profileSubPanel2)
        Me.userProfilePanel.Controls.Add(Me.profileTitle)
        Me.userProfilePanel.Location = New System.Drawing.Point(229, 100)
        Me.userProfilePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.userProfilePanel.Name = "userProfilePanel"
        Me.userProfilePanel.Size = New System.Drawing.Size(935, 520)
        Me.userProfilePanel.TabIndex = 64
        '
        'profileSubPanel1
        '
        Me.profileSubPanel1.BackColor = System.Drawing.Color.Transparent
        Me.profileSubPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.profileSubPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.profileSubPanel1.Controls.Add(Me.Label50)
        Me.profileSubPanel1.Controls.Add(Me.adminEmailProfile)
        Me.profileSubPanel1.Controls.Add(Me.adminTitleProfile)
        Me.profileSubPanel1.Controls.Add(Me.adminPhoneNumberProfile)
        Me.profileSubPanel1.Controls.Add(Me.adminNameProfile)
        Me.profileSubPanel1.Controls.Add(Me.adminEmailProfileLabel)
        Me.profileSubPanel1.Controls.Add(Me.adminPhoneNumberProfileLabel)
        Me.profileSubPanel1.Controls.Add(Me.adminTitleProfileLabel)
        Me.profileSubPanel1.Controls.Add(Me.adminNameProfileLabel)
        Me.profileSubPanel1.Controls.Add(Me.updateProfileShowBtn)
        Me.profileSubPanel1.Controls.Add(Me.Label49)
        Me.profileSubPanel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.profileSubPanel1.ForeColor = System.Drawing.Color.Yellow
        Me.profileSubPanel1.Location = New System.Drawing.Point(242, 79)
        Me.profileSubPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.profileSubPanel1.Name = "profileSubPanel1"
        Me.profileSubPanel1.Size = New System.Drawing.Size(440, 320)
        Me.profileSubPanel1.TabIndex = 31
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Yellow
        Me.Label50.Image = Global.cems.My.Resources.Resources.user2
        Me.Label50.Location = New System.Drawing.Point(-1, -1)
        Me.Label50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(440, 162)
        Me.Label50.TabIndex = 51
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'adminEmailProfile
        '
        Me.adminEmailProfile.AutoSize = True
        Me.adminEmailProfile.BackColor = System.Drawing.Color.SeaGreen
        Me.adminEmailProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.adminEmailProfile.ForeColor = System.Drawing.Color.Yellow
        Me.adminEmailProfile.Location = New System.Drawing.Point(155, 192)
        Me.adminEmailProfile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adminEmailProfile.Name = "adminEmailProfile"
        Me.adminEmailProfile.Size = New System.Drawing.Size(51, 20)
        Me.adminEmailProfile.TabIndex = 14
        Me.adminEmailProfile.Text = "******"
        '
        'adminTitleProfile
        '
        Me.adminTitleProfile.AutoSize = True
        Me.adminTitleProfile.BackColor = System.Drawing.Color.SeaGreen
        Me.adminTitleProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.adminTitleProfile.ForeColor = System.Drawing.Color.Yellow
        Me.adminTitleProfile.Location = New System.Drawing.Point(148, 240)
        Me.adminTitleProfile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adminTitleProfile.Name = "adminTitleProfile"
        Me.adminTitleProfile.Size = New System.Drawing.Size(51, 20)
        Me.adminTitleProfile.TabIndex = 13
        Me.adminTitleProfile.Text = "******"
        '
        'adminPhoneNumberProfile
        '
        Me.adminPhoneNumberProfile.AutoSize = True
        Me.adminPhoneNumberProfile.BackColor = System.Drawing.Color.SeaGreen
        Me.adminPhoneNumberProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.adminPhoneNumberProfile.ForeColor = System.Drawing.Color.Yellow
        Me.adminPhoneNumberProfile.Location = New System.Drawing.Point(254, 216)
        Me.adminPhoneNumberProfile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adminPhoneNumberProfile.Name = "adminPhoneNumberProfile"
        Me.adminPhoneNumberProfile.Size = New System.Drawing.Size(51, 20)
        Me.adminPhoneNumberProfile.TabIndex = 12
        Me.adminPhoneNumberProfile.Text = "******"
        '
        'adminNameProfile
        '
        Me.adminNameProfile.AutoSize = True
        Me.adminNameProfile.BackColor = System.Drawing.Color.SeaGreen
        Me.adminNameProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.adminNameProfile.ForeColor = System.Drawing.Color.Yellow
        Me.adminNameProfile.Location = New System.Drawing.Point(159, 172)
        Me.adminNameProfile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adminNameProfile.Name = "adminNameProfile"
        Me.adminNameProfile.Size = New System.Drawing.Size(51, 20)
        Me.adminNameProfile.TabIndex = 7
        Me.adminNameProfile.Text = "******"
        '
        'adminEmailProfileLabel
        '
        Me.adminEmailProfileLabel.AutoSize = True
        Me.adminEmailProfileLabel.BackColor = System.Drawing.Color.SeaGreen
        Me.adminEmailProfileLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.adminEmailProfileLabel.ForeColor = System.Drawing.Color.Yellow
        Me.adminEmailProfileLabel.Location = New System.Drawing.Point(37, 192)
        Me.adminEmailProfileLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adminEmailProfileLabel.Name = "adminEmailProfileLabel"
        Me.adminEmailProfileLabel.Size = New System.Drawing.Size(112, 20)
        Me.adminEmailProfileLabel.TabIndex = 11
        Me.adminEmailProfileLabel.Text = "User email :"
        '
        'adminPhoneNumberProfileLabel
        '
        Me.adminPhoneNumberProfileLabel.AutoSize = True
        Me.adminPhoneNumberProfileLabel.BackColor = System.Drawing.Color.SeaGreen
        Me.adminPhoneNumberProfileLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.adminPhoneNumberProfileLabel.ForeColor = System.Drawing.Color.Yellow
        Me.adminPhoneNumberProfileLabel.Location = New System.Drawing.Point(37, 216)
        Me.adminPhoneNumberProfileLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adminPhoneNumberProfileLabel.Name = "adminPhoneNumberProfileLabel"
        Me.adminPhoneNumberProfileLabel.Size = New System.Drawing.Size(211, 20)
        Me.adminPhoneNumberProfileLabel.TabIndex = 10
        Me.adminPhoneNumberProfileLabel.Text = "User telephone nunber :"
        '
        'adminTitleProfileLabel
        '
        Me.adminTitleProfileLabel.AutoSize = True
        Me.adminTitleProfileLabel.BackColor = System.Drawing.Color.SeaGreen
        Me.adminTitleProfileLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.adminTitleProfileLabel.ForeColor = System.Drawing.Color.Yellow
        Me.adminTitleProfileLabel.Location = New System.Drawing.Point(37, 240)
        Me.adminTitleProfileLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adminTitleProfileLabel.Name = "adminTitleProfileLabel"
        Me.adminTitleProfileLabel.Size = New System.Drawing.Size(104, 20)
        Me.adminTitleProfileLabel.TabIndex = 9
        Me.adminTitleProfileLabel.Text = "User Title :"
        '
        'adminNameProfileLabel
        '
        Me.adminNameProfileLabel.AutoSize = True
        Me.adminNameProfileLabel.BackColor = System.Drawing.Color.SeaGreen
        Me.adminNameProfileLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.adminNameProfileLabel.ForeColor = System.Drawing.Color.Yellow
        Me.adminNameProfileLabel.Location = New System.Drawing.Point(38, 170)
        Me.adminNameProfileLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adminNameProfileLabel.Name = "adminNameProfileLabel"
        Me.adminNameProfileLabel.Size = New System.Drawing.Size(112, 20)
        Me.adminNameProfileLabel.TabIndex = 7
        Me.adminNameProfileLabel.Text = "User name :"
        '
        'updateProfileShowBtn
        '
        Me.updateProfileShowBtn.BackColor = System.Drawing.Color.Transparent
        Me.updateProfileShowBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.updateProfileShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateProfileShowBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.updateProfileShowBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.updateProfileShowBtn.Location = New System.Drawing.Point(324, 274)
        Me.updateProfileShowBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.updateProfileShowBtn.MaximumSize = New System.Drawing.Size(208, 62)
        Me.updateProfileShowBtn.Name = "updateProfileShowBtn"
        Me.updateProfileShowBtn.Size = New System.Drawing.Size(76, 27)
        Me.updateProfileShowBtn.TabIndex = 13
        Me.updateProfileShowBtn.Text = "Update"
        Me.updateProfileShowBtn.UseVisualStyleBackColor = False
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.SeaGreen
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Yellow
        Me.Label49.Location = New System.Drawing.Point(0, 156)
        Me.Label49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(440, 162)
        Me.Label49.TabIndex = 50
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'profileSubPanel2
        '
        Me.profileSubPanel2.BackColor = System.Drawing.Color.Transparent
        Me.profileSubPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.profileSubPanel2.Controls.Add(Me.userPwdProfileInput)
        Me.profileSubPanel2.Controls.Add(Me.Label52)
        Me.profileSubPanel2.Controls.Add(Me.Label53)
        Me.profileSubPanel2.Controls.Add(Me.Label51)
        Me.profileSubPanel2.Controls.Add(Me.userConfirmPwdProfileInput)
        Me.profileSubPanel2.Controls.Add(Me.userConfirmPwdProfileLabel)
        Me.profileSubPanel2.Controls.Add(Me.updateProfileCancelBtn)
        Me.profileSubPanel2.Controls.Add(Me.updateProfileErrorMsg)
        Me.profileSubPanel2.Controls.Add(Me.userPhoneNumberProfileInput)
        Me.profileSubPanel2.Controls.Add(Me.userEmailProfileInput)
        Me.profileSubPanel2.Controls.Add(Me.userNameProfileInput)
        Me.profileSubPanel2.Controls.Add(Me.updateProfileValidateBtn)
        Me.profileSubPanel2.Controls.Add(Me.userEmailProfileLabel2)
        Me.profileSubPanel2.Controls.Add(Me.userPhoneNumberProfileLabel2)
        Me.profileSubPanel2.Controls.Add(Me.userPwdProfileLabel)
        Me.profileSubPanel2.Controls.Add(Me.userNameProfileLabel2)
        Me.profileSubPanel2.Location = New System.Drawing.Point(188, 33)
        Me.profileSubPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.profileSubPanel2.Name = "profileSubPanel2"
        Me.profileSubPanel2.Size = New System.Drawing.Size(548, 466)
        Me.profileSubPanel2.TabIndex = 35
        Me.profileSubPanel2.Visible = False
        '
        'userPwdProfileInput
        '
        Me.userPwdProfileInput.Location = New System.Drawing.Point(70, 279)
        Me.userPwdProfileInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userPwdProfileInput.Name = "userPwdProfileInput"
        Me.userPwdProfileInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.userPwdProfileInput.Size = New System.Drawing.Size(420, 22)
        Me.userPwdProfileInput.TabIndex = 18
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.SeaGreen
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label52.ForeColor = System.Drawing.Color.Yellow
        Me.Label52.Location = New System.Drawing.Point(227, 13)
        Me.Label52.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(114, 20)
        Me.Label52.TabIndex = 52
        Me.Label52.Text = "Update User"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.SeaGreen
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label53.ForeColor = System.Drawing.Color.Yellow
        Me.Label53.Location = New System.Drawing.Point(216, 222)
        Me.Label53.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(114, 20)
        Me.Label53.TabIndex = 53
        Me.Label53.Text = "Update User"
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.SeaGreen
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Yellow
        Me.Label51.Location = New System.Drawing.Point(0, 0)
        Me.Label51.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(548, 45)
        Me.Label51.TabIndex = 51
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'userConfirmPwdProfileInput
        '
        Me.userConfirmPwdProfileInput.Location = New System.Drawing.Point(70, 339)
        Me.userConfirmPwdProfileInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userConfirmPwdProfileInput.Name = "userConfirmPwdProfileInput"
        Me.userConfirmPwdProfileInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.userConfirmPwdProfileInput.Size = New System.Drawing.Size(420, 22)
        Me.userConfirmPwdProfileInput.TabIndex = 22
        '
        'userConfirmPwdProfileLabel
        '
        Me.userConfirmPwdProfileLabel.AutoSize = True
        Me.userConfirmPwdProfileLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.userConfirmPwdProfileLabel.Location = New System.Drawing.Point(65, 309)
        Me.userConfirmPwdProfileLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userConfirmPwdProfileLabel.Name = "userConfirmPwdProfileLabel"
        Me.userConfirmPwdProfileLabel.Size = New System.Drawing.Size(161, 20)
        Me.userConfirmPwdProfileLabel.TabIndex = 21
        Me.userConfirmPwdProfileLabel.Text = "Confirm password"
        '
        'updateProfileCancelBtn
        '
        Me.updateProfileCancelBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.updateProfileCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.updateProfileCancelBtn.FlatAppearance.BorderSize = 0
        Me.updateProfileCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateProfileCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.updateProfileCancelBtn.ForeColor = System.Drawing.Color.Yellow
        Me.updateProfileCancelBtn.Location = New System.Drawing.Point(70, 417)
        Me.updateProfileCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.updateProfileCancelBtn.MaximumSize = New System.Drawing.Size(500, 62)
        Me.updateProfileCancelBtn.Name = "updateProfileCancelBtn"
        Me.updateProfileCancelBtn.Size = New System.Drawing.Size(420, 35)
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
        Me.updateProfileErrorMsg.Location = New System.Drawing.Point(70, 370)
        Me.updateProfileErrorMsg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.updateProfileErrorMsg.Name = "updateProfileErrorMsg"
        Me.updateProfileErrorMsg.Size = New System.Drawing.Size(0, 15)
        Me.updateProfileErrorMsg.TabIndex = 19
        Me.updateProfileErrorMsg.Visible = False
        '
        'userPhoneNumberProfileInput
        '
        Me.userPhoneNumberProfileInput.Location = New System.Drawing.Point(70, 219)
        Me.userPhoneNumberProfileInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userPhoneNumberProfileInput.Name = "userPhoneNumberProfileInput"
        Me.userPhoneNumberProfileInput.Size = New System.Drawing.Size(420, 22)
        Me.userPhoneNumberProfileInput.TabIndex = 17
        '
        'userEmailProfileInput
        '
        Me.userEmailProfileInput.Location = New System.Drawing.Point(70, 159)
        Me.userEmailProfileInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userEmailProfileInput.Name = "userEmailProfileInput"
        Me.userEmailProfileInput.Size = New System.Drawing.Size(420, 22)
        Me.userEmailProfileInput.TabIndex = 16
        '
        'userNameProfileInput
        '
        Me.userNameProfileInput.Location = New System.Drawing.Point(70, 99)
        Me.userNameProfileInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userNameProfileInput.Name = "userNameProfileInput"
        Me.userNameProfileInput.Size = New System.Drawing.Size(422, 22)
        Me.userNameProfileInput.TabIndex = 15
        '
        'updateProfileValidateBtn
        '
        Me.updateProfileValidateBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.updateProfileValidateBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.updateProfileValidateBtn.FlatAppearance.BorderSize = 0
        Me.updateProfileValidateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateProfileValidateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.updateProfileValidateBtn.ForeColor = System.Drawing.Color.Yellow
        Me.updateProfileValidateBtn.Location = New System.Drawing.Point(70, 376)
        Me.updateProfileValidateBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.updateProfileValidateBtn.MaximumSize = New System.Drawing.Size(500, 62)
        Me.updateProfileValidateBtn.Name = "updateProfileValidateBtn"
        Me.updateProfileValidateBtn.Size = New System.Drawing.Size(420, 35)
        Me.updateProfileValidateBtn.TabIndex = 13
        Me.updateProfileValidateBtn.Text = "Done"
        Me.updateProfileValidateBtn.UseVisualStyleBackColor = False
        '
        'userEmailProfileLabel2
        '
        Me.userEmailProfileLabel2.AutoSize = True
        Me.userEmailProfileLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.userEmailProfileLabel2.Location = New System.Drawing.Point(65, 129)
        Me.userEmailProfileLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userEmailProfileLabel2.Name = "userEmailProfileLabel2"
        Me.userEmailProfileLabel2.Size = New System.Drawing.Size(106, 20)
        Me.userEmailProfileLabel2.TabIndex = 11
        Me.userEmailProfileLabel2.Text = "User email "
        '
        'userPhoneNumberProfileLabel2
        '
        Me.userPhoneNumberProfileLabel2.AutoSize = True
        Me.userPhoneNumberProfileLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.userPhoneNumberProfileLabel2.Location = New System.Drawing.Point(65, 189)
        Me.userPhoneNumberProfileLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userPhoneNumberProfileLabel2.Name = "userPhoneNumberProfileLabel2"
        Me.userPhoneNumberProfileLabel2.Size = New System.Drawing.Size(205, 20)
        Me.userPhoneNumberProfileLabel2.TabIndex = 10
        Me.userPhoneNumberProfileLabel2.Text = "User telephone nunber "
        '
        'userPwdProfileLabel
        '
        Me.userPwdProfileLabel.AutoSize = True
        Me.userPwdProfileLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.userPwdProfileLabel.Location = New System.Drawing.Point(65, 249)
        Me.userPwdProfileLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userPwdProfileLabel.Name = "userPwdProfileLabel"
        Me.userPwdProfileLabel.Size = New System.Drawing.Size(179, 20)
        Me.userPwdProfileLabel.TabIndex = 9
        Me.userPwdProfileLabel.Text = "Enter new password"
        '
        'userNameProfileLabel2
        '
        Me.userNameProfileLabel2.AutoSize = True
        Me.userNameProfileLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.userNameProfileLabel2.Location = New System.Drawing.Point(65, 69)
        Me.userNameProfileLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userNameProfileLabel2.Name = "userNameProfileLabel2"
        Me.userNameProfileLabel2.Size = New System.Drawing.Size(106, 20)
        Me.userNameProfileLabel2.TabIndex = 7
        Me.userNameProfileLabel2.Text = "User name "
        '
        'profileTitle
        '
        Me.profileTitle.AutoSize = True
        Me.profileTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.profileTitle.ForeColor = System.Drawing.Color.Gray
        Me.profileTitle.Location = New System.Drawing.Point(16, 0)
        Me.profileTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.profileTitle.Name = "profileTitle"
        Me.profileTitle.Size = New System.Drawing.Size(73, 25)
        Me.profileTitle.TabIndex = 30
        Me.profileTitle.Text = "Profile"
        '
        'UserHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(1176, 633)
        Me.Controls.Add(Me.userProfilePanel)
        Me.Controls.Add(Me.userHeader)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.userHomePagePanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(300, 300)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1194, 700)
        Me.MinimumSize = New System.Drawing.Size(1194, 605)
        Me.Name = "UserHomePage"
        Me.Padding = New System.Windows.Forms.Padding(13, 0, 13, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Page"
        Me.userHeader.ResumeLayout(False)
        Me.userHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.dropdown.ResumeLayout(False)
        Me.dropdown.PerformLayout()
        Me.userHomePagePanel.ResumeLayout(False)
        Me.userHomePagePanel.PerformLayout()
        Me.userProfilePanel.ResumeLayout(False)
        Me.userProfilePanel.PerformLayout()
        Me.profileSubPanel1.ResumeLayout(False)
        Me.profileSubPanel1.PerformLayout()
        Me.profileSubPanel2.ResumeLayout(False)
        Me.profileSubPanel2.PerformLayout()
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
    Friend WithEvents userHomePagePanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents userLogout As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents profile As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Posts As Label
    Friend WithEvents Equipments As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents CPUs As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents IP As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents monitors As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents CPUsBtn2 As Button
    Friend WithEvents IPsBtn2 As Button
    Friend WithEvents monitorsBtn2 As Button
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nonActiveMonitorNumber As Label
    Friend WithEvents activeMonitorNumber As Label
    Friend WithEvents nonActiveIPNumber As Label
    Friend WithEvents activeIPNumber As Label
    Friend WithEvents nonActiveCPUNumber As Label
    Friend WithEvents activeCPUNumber As Label
    Friend WithEvents monitorbuttoninactive As Button
    Friend WithEvents IPbuttoninactive As Button
    Friend WithEvents CPUbuttoninactive As Button
    Friend WithEvents userProfilePanel As Panel
    Friend WithEvents profileSubPanel1 As Panel
    Friend WithEvents Label50 As Label
    Friend WithEvents adminEmailProfile As Label
    Friend WithEvents adminTitleProfile As Label
    Friend WithEvents adminPhoneNumberProfile As Label
    Friend WithEvents adminNameProfile As Label
    Friend WithEvents adminEmailProfileLabel As Label
    Friend WithEvents adminPhoneNumberProfileLabel As Label
    Friend WithEvents adminTitleProfileLabel As Label
    Friend WithEvents adminNameProfileLabel As Label
    Friend WithEvents updateProfileShowBtn As Button
    Friend WithEvents Label49 As Label
    Friend WithEvents profileSubPanel2 As Panel
    Friend WithEvents userPwdProfileInput As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents userConfirmPwdProfileInput As TextBox
    Friend WithEvents userConfirmPwdProfileLabel As Label
    Friend WithEvents updateProfileCancelBtn As Button
    Friend WithEvents updateProfileErrorMsg As Label
    Friend WithEvents userPhoneNumberProfileInput As TextBox
    Friend WithEvents userEmailProfileInput As TextBox
    Friend WithEvents userNameProfileInput As TextBox
    Friend WithEvents updateProfileValidateBtn As Button
    Friend WithEvents userEmailProfileLabel2 As Label
    Friend WithEvents userPhoneNumberProfileLabel2 As Label
    Friend WithEvents userPwdProfileLabel As Label
    Friend WithEvents userNameProfileLabel2 As Label
    Friend WithEvents profileTitle As Label
End Class
