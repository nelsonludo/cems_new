<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.loginPanel = New System.Windows.Forms.Panel()
        Me.loginUserEmailLabel = New System.Windows.Forms.Label()
        Me.loginUserPwdLabel = New System.Windows.Forms.Label()
        Me.loginTitle = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.forgotPasswordMessage = New System.Windows.Forms.Label()
        Me.forgotPwdBtn = New System.Windows.Forms.Button()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.emailtxt = New System.Windows.Forms.TextBox()
        Me.connexionStringPanel = New System.Windows.Forms.Panel()
        Me.connexionTitle = New System.Windows.Forms.Label()
        Me.connexionPwdLabel = New System.Windows.Forms.Label()
        Me.connexionServerLabel = New System.Windows.Forms.Label()
        Me.connexionDatabaseLabel = New System.Windows.Forms.Label()
        Me.connexionUserNameLabel = New System.Windows.Forms.Label()
        Me.connexionStringDatabase = New System.Windows.Forms.TextBox()
        Me.connexionStringServer = New System.Windows.Forms.TextBox()
        Me.connexionErrorMsg = New System.Windows.Forms.Label()
        Me.connectBtn = New System.Windows.Forms.Button()
        Me.connexionStringPwd = New System.Windows.Forms.TextBox()
        Me.connexionStringUserName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.userAddPanel = New System.Windows.Forms.Panel()
        Me.createAdminTitle = New System.Windows.Forms.Label()
        Me.addUserErrorMsg = New System.Windows.Forms.Label()
        Me.userUserAddConfirmPwdInput = New System.Windows.Forms.TextBox()
        Me.userConfirmPwdLabel = New System.Windows.Forms.Label()
        Me.userUserAddPwdInput = New System.Windows.Forms.TextBox()
        Me.adminPwdLabel = New System.Windows.Forms.Label()
        Me.userUserAddPhoneInput = New System.Windows.Forms.TextBox()
        Me.adminPhoneNumberLabel = New System.Windows.Forms.Label()
        Me.userUserAddEmailInput = New System.Windows.Forms.TextBox()
        Me.adminEmailLabel = New System.Windows.Forms.Label()
        Me.userUserAddNameInput = New System.Windows.Forms.TextBox()
        Me.userAddValidationBtn = New System.Windows.Forms.Button()
        Me.adminNameLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.englishBtn = New System.Windows.Forms.Button()
        Me.frenchBtn = New System.Windows.Forms.Button()
        Me.errorProviderEmail = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.loginPanel.SuspendLayout()
        Me.connexionStringPanel.SuspendLayout()
        Me.userAddPanel.SuspendLayout()
        CType(Me.errorProviderEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginPanel
        '
        Me.loginPanel.BackColor = System.Drawing.Color.MintCream
        Me.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.loginPanel.Controls.Add(Me.loginUserEmailLabel)
        Me.loginPanel.Controls.Add(Me.loginUserPwdLabel)
        Me.loginPanel.Controls.Add(Me.loginTitle)
        Me.loginPanel.Controls.Add(Me.Label51)
        Me.loginPanel.Controls.Add(Me.forgotPasswordMessage)
        Me.loginPanel.Controls.Add(Me.forgotPwdBtn)
        Me.loginPanel.Controls.Add(Me.loginBtn)
        Me.loginPanel.Controls.Add(Me.passwordtxt)
        Me.loginPanel.Controls.Add(Me.emailtxt)
        Me.loginPanel.Location = New System.Drawing.Point(606, 244)
        Me.loginPanel.Name = "loginPanel"
        Me.loginPanel.Size = New System.Drawing.Size(412, 313)
        Me.loginPanel.TabIndex = 0
        Me.loginPanel.Visible = False
        '
        'loginUserEmailLabel
        '
        Me.loginUserEmailLabel.AutoSize = True
        Me.loginUserEmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.loginUserEmailLabel.Location = New System.Drawing.Point(41, 65)
        Me.loginUserEmailLabel.Name = "loginUserEmailLabel"
        Me.loginUserEmailLabel.Size = New System.Drawing.Size(52, 17)
        Me.loginUserEmailLabel.TabIndex = 54
        Me.loginUserEmailLabel.Text = "Email "
        '
        'loginUserPwdLabel
        '
        Me.loginUserPwdLabel.AutoSize = True
        Me.loginUserPwdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.loginUserPwdLabel.Location = New System.Drawing.Point(41, 114)
        Me.loginUserPwdLabel.Name = "loginUserPwdLabel"
        Me.loginUserPwdLabel.Size = New System.Drawing.Size(82, 17)
        Me.loginUserPwdLabel.TabIndex = 53
        Me.loginUserPwdLabel.Text = "Password "
        '
        'loginTitle
        '
        Me.loginTitle.AutoSize = True
        Me.loginTitle.BackColor = System.Drawing.Color.SeaGreen
        Me.loginTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.loginTitle.ForeColor = System.Drawing.Color.MintCream
        Me.loginTitle.Location = New System.Drawing.Point(41, 7)
        Me.loginTitle.Name = "loginTitle"
        Me.loginTitle.Size = New System.Drawing.Size(48, 17)
        Me.loginTitle.TabIndex = 1
        Me.loginTitle.Text = "Login"
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.SeaGreen
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Yellow
        Me.Label51.Location = New System.Drawing.Point(0, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(411, 37)
        Me.Label51.TabIndex = 52
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'forgotPasswordMessage
        '
        Me.forgotPasswordMessage.AutoSize = True
        Me.forgotPasswordMessage.ForeColor = System.Drawing.Color.Red
        Me.forgotPasswordMessage.Location = New System.Drawing.Point(8, 278)
        Me.forgotPasswordMessage.Name = "forgotPasswordMessage"
        Me.forgotPasswordMessage.Size = New System.Drawing.Size(13, 13)
        Me.forgotPasswordMessage.TabIndex = 1
        Me.forgotPasswordMessage.Text = "  "
        '
        'forgotPwdBtn
        '
        Me.forgotPwdBtn.AutoSize = True
        Me.forgotPwdBtn.BackColor = System.Drawing.Color.Transparent
        Me.forgotPwdBtn.FlatAppearance.BorderSize = 0
        Me.forgotPwdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.forgotPwdBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline)
        Me.forgotPwdBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.forgotPwdBtn.Location = New System.Drawing.Point(136, 204)
        Me.forgotPwdBtn.Name = "forgotPwdBtn"
        Me.forgotPwdBtn.Size = New System.Drawing.Size(150, 28)
        Me.forgotPwdBtn.TabIndex = 6
        Me.forgotPwdBtn.Text = "Forgot password ?"
        Me.forgotPwdBtn.UseVisualStyleBackColor = False
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.loginBtn.FlatAppearance.BorderSize = 0
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.loginBtn.ForeColor = System.Drawing.Color.Yellow
        Me.loginBtn.Location = New System.Drawing.Point(45, 171)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(315, 28)
        Me.loginBtn.TabIndex = 5
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'passwordtxt
        '
        Me.passwordtxt.Location = New System.Drawing.Point(45, 135)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordtxt.Size = New System.Drawing.Size(316, 20)
        Me.passwordtxt.TabIndex = 3
        Me.passwordtxt.UseSystemPasswordChar = True
        '
        'emailtxt
        '
        Me.emailtxt.Location = New System.Drawing.Point(45, 86)
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.Size = New System.Drawing.Size(316, 20)
        Me.emailtxt.TabIndex = 2
        '
        'connexionStringPanel
        '
        Me.connexionStringPanel.BackColor = System.Drawing.Color.MintCream
        Me.connexionStringPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.connexionStringPanel.Controls.Add(Me.connexionTitle)
        Me.connexionStringPanel.Controls.Add(Me.connexionPwdLabel)
        Me.connexionStringPanel.Controls.Add(Me.connexionServerLabel)
        Me.connexionStringPanel.Controls.Add(Me.connexionDatabaseLabel)
        Me.connexionStringPanel.Controls.Add(Me.connexionUserNameLabel)
        Me.connexionStringPanel.Controls.Add(Me.connexionStringDatabase)
        Me.connexionStringPanel.Controls.Add(Me.connexionStringServer)
        Me.connexionStringPanel.Controls.Add(Me.connexionErrorMsg)
        Me.connexionStringPanel.Controls.Add(Me.connectBtn)
        Me.connexionStringPanel.Controls.Add(Me.connexionStringPwd)
        Me.connexionStringPanel.Controls.Add(Me.connexionStringUserName)
        Me.connexionStringPanel.Controls.Add(Me.Label9)
        Me.connexionStringPanel.Location = New System.Drawing.Point(606, 244)
        Me.connexionStringPanel.Name = "connexionStringPanel"
        Me.connexionStringPanel.Size = New System.Drawing.Size(414, 321)
        Me.connexionStringPanel.TabIndex = 8
        '
        'connexionTitle
        '
        Me.connexionTitle.AutoSize = True
        Me.connexionTitle.BackColor = System.Drawing.Color.SeaGreen
        Me.connexionTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.connexionTitle.ForeColor = System.Drawing.Color.MintCream
        Me.connexionTitle.Location = New System.Drawing.Point(41, 7)
        Me.connexionTitle.Name = "connexionTitle"
        Me.connexionTitle.Size = New System.Drawing.Size(83, 17)
        Me.connexionTitle.TabIndex = 0
        Me.connexionTitle.Text = "Connexion"
        '
        'connexionPwdLabel
        '
        Me.connexionPwdLabel.AutoSize = True
        Me.connexionPwdLabel.BackColor = System.Drawing.Color.MintCream
        Me.connexionPwdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.connexionPwdLabel.Location = New System.Drawing.Point(41, 162)
        Me.connexionPwdLabel.Name = "connexionPwdLabel"
        Me.connexionPwdLabel.Size = New System.Drawing.Size(77, 17)
        Me.connexionPwdLabel.TabIndex = 3
        Me.connexionPwdLabel.Text = "Password"
        '
        'connexionServerLabel
        '
        Me.connexionServerLabel.AutoSize = True
        Me.connexionServerLabel.BackColor = System.Drawing.Color.MintCream
        Me.connexionServerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.connexionServerLabel.Location = New System.Drawing.Point(41, 65)
        Me.connexionServerLabel.Name = "connexionServerLabel"
        Me.connexionServerLabel.Size = New System.Drawing.Size(61, 17)
        Me.connexionServerLabel.TabIndex = 1
        Me.connexionServerLabel.Text = "Server "
        '
        'connexionDatabaseLabel
        '
        Me.connexionDatabaseLabel.AutoSize = True
        Me.connexionDatabaseLabel.BackColor = System.Drawing.Color.MintCream
        Me.connexionDatabaseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.connexionDatabaseLabel.Location = New System.Drawing.Point(41, 211)
        Me.connexionDatabaseLabel.Name = "connexionDatabaseLabel"
        Me.connexionDatabaseLabel.Size = New System.Drawing.Size(77, 17)
        Me.connexionDatabaseLabel.TabIndex = 4
        Me.connexionDatabaseLabel.Text = "Database"
        '
        'connexionUserNameLabel
        '
        Me.connexionUserNameLabel.AutoSize = True
        Me.connexionUserNameLabel.BackColor = System.Drawing.Color.MintCream
        Me.connexionUserNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.connexionUserNameLabel.Location = New System.Drawing.Point(41, 114)
        Me.connexionUserNameLabel.Name = "connexionUserNameLabel"
        Me.connexionUserNameLabel.Size = New System.Drawing.Size(86, 17)
        Me.connexionUserNameLabel.TabIndex = 2
        Me.connexionUserNameLabel.Text = "User name"
        '
        'connexionStringDatabase
        '
        Me.connexionStringDatabase.Location = New System.Drawing.Point(45, 232)
        Me.connexionStringDatabase.Name = "connexionStringDatabase"
        Me.connexionStringDatabase.Size = New System.Drawing.Size(316, 20)
        Me.connexionStringDatabase.TabIndex = 8
        '
        'connexionStringServer
        '
        Me.connexionStringServer.Location = New System.Drawing.Point(45, 86)
        Me.connexionStringServer.Name = "connexionStringServer"
        Me.connexionStringServer.Size = New System.Drawing.Size(316, 20)
        Me.connexionStringServer.TabIndex = 5
        '
        'connexionErrorMsg
        '
        Me.connexionErrorMsg.AutoSize = True
        Me.connexionErrorMsg.Location = New System.Drawing.Point(45, 292)
        Me.connexionErrorMsg.Name = "connexionErrorMsg"
        Me.connexionErrorMsg.Size = New System.Drawing.Size(13, 13)
        Me.connexionErrorMsg.TabIndex = 10
        Me.connexionErrorMsg.Text = "  "
        '
        'connectBtn
        '
        Me.connectBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.connectBtn.FlatAppearance.BorderSize = 0
        Me.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.connectBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.connectBtn.ForeColor = System.Drawing.Color.Yellow
        Me.connectBtn.Location = New System.Drawing.Point(45, 256)
        Me.connectBtn.Name = "connectBtn"
        Me.connectBtn.Size = New System.Drawing.Size(315, 28)
        Me.connectBtn.TabIndex = 9
        Me.connectBtn.Text = "Connect"
        Me.connectBtn.UseVisualStyleBackColor = False
        '
        'connexionStringPwd
        '
        Me.connexionStringPwd.Location = New System.Drawing.Point(45, 184)
        Me.connexionStringPwd.Name = "connexionStringPwd"
        Me.connexionStringPwd.Size = New System.Drawing.Size(316, 20)
        Me.connexionStringPwd.TabIndex = 7
        Me.connexionStringPwd.UseSystemPasswordChar = True
        '
        'connexionStringUserName
        '
        Me.connexionStringUserName.Location = New System.Drawing.Point(45, 135)
        Me.connexionStringUserName.Name = "connexionStringUserName"
        Me.connexionStringUserName.Size = New System.Drawing.Size(316, 20)
        Me.connexionStringUserName.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SeaGreen
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(412, 37)
        Me.Label9.TabIndex = 53
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'userAddPanel
        '
        Me.userAddPanel.BackColor = System.Drawing.Color.MintCream
        Me.userAddPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.userAddPanel.Controls.Add(Me.createAdminTitle)
        Me.userAddPanel.Controls.Add(Me.addUserErrorMsg)
        Me.userAddPanel.Controls.Add(Me.userUserAddConfirmPwdInput)
        Me.userAddPanel.Controls.Add(Me.userConfirmPwdLabel)
        Me.userAddPanel.Controls.Add(Me.userUserAddPwdInput)
        Me.userAddPanel.Controls.Add(Me.adminPwdLabel)
        Me.userAddPanel.Controls.Add(Me.userUserAddPhoneInput)
        Me.userAddPanel.Controls.Add(Me.adminPhoneNumberLabel)
        Me.userAddPanel.Controls.Add(Me.userUserAddEmailInput)
        Me.userAddPanel.Controls.Add(Me.adminEmailLabel)
        Me.userAddPanel.Controls.Add(Me.userUserAddNameInput)
        Me.userAddPanel.Controls.Add(Me.userAddValidationBtn)
        Me.userAddPanel.Controls.Add(Me.adminNameLabel)
        Me.userAddPanel.Controls.Add(Me.Label10)
        Me.userAddPanel.Location = New System.Drawing.Point(606, 244)
        Me.userAddPanel.Name = "userAddPanel"
        Me.userAddPanel.Size = New System.Drawing.Size(414, 423)
        Me.userAddPanel.TabIndex = 11
        Me.userAddPanel.Visible = False
        '
        'createAdminTitle
        '
        Me.createAdminTitle.AutoSize = True
        Me.createAdminTitle.BackColor = System.Drawing.Color.SeaGreen
        Me.createAdminTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.createAdminTitle.ForeColor = System.Drawing.Color.MintCream
        Me.createAdminTitle.Location = New System.Drawing.Point(41, 7)
        Me.createAdminTitle.Name = "createAdminTitle"
        Me.createAdminTitle.Size = New System.Drawing.Size(104, 17)
        Me.createAdminTitle.TabIndex = 59
        Me.createAdminTitle.Text = "Create admin"
        '
        'addUserErrorMsg
        '
        Me.addUserErrorMsg.AutoSize = True
        Me.addUserErrorMsg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.addUserErrorMsg.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addUserErrorMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addUserErrorMsg.Location = New System.Drawing.Point(49, 395)
        Me.addUserErrorMsg.Name = "addUserErrorMsg"
        Me.addUserErrorMsg.Size = New System.Drawing.Size(0, 16)
        Me.addUserErrorMsg.TabIndex = 58
        Me.addUserErrorMsg.Visible = False
        '
        'userUserAddConfirmPwdInput
        '
        Me.userUserAddConfirmPwdInput.Location = New System.Drawing.Point(45, 295)
        Me.userUserAddConfirmPwdInput.Name = "userUserAddConfirmPwdInput"
        Me.userUserAddConfirmPwdInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.userUserAddConfirmPwdInput.Size = New System.Drawing.Size(316, 20)
        Me.userUserAddConfirmPwdInput.TabIndex = 5
        Me.userUserAddConfirmPwdInput.UseSystemPasswordChar = True
        '
        'userConfirmPwdLabel
        '
        Me.userConfirmPwdLabel.AutoSize = True
        Me.userConfirmPwdLabel.BackColor = System.Drawing.Color.MintCream
        Me.userConfirmPwdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.userConfirmPwdLabel.Location = New System.Drawing.Point(41, 274)
        Me.userConfirmPwdLabel.Name = "userConfirmPwdLabel"
        Me.userConfirmPwdLabel.Size = New System.Drawing.Size(136, 20)
        Me.userConfirmPwdLabel.TabIndex = 56
        Me.userConfirmPwdLabel.Text = "Confirm password"
        '
        'userUserAddPwdInput
        '
        Me.userUserAddPwdInput.Location = New System.Drawing.Point(45, 246)
        Me.userUserAddPwdInput.Name = "userUserAddPwdInput"
        Me.userUserAddPwdInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.userUserAddPwdInput.Size = New System.Drawing.Size(316, 20)
        Me.userUserAddPwdInput.TabIndex = 4
        Me.userUserAddPwdInput.UseSystemPasswordChar = True
        '
        'adminPwdLabel
        '
        Me.adminPwdLabel.AutoSize = True
        Me.adminPwdLabel.BackColor = System.Drawing.Color.MintCream
        Me.adminPwdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.adminPwdLabel.Location = New System.Drawing.Point(41, 225)
        Me.adminPwdLabel.Name = "adminPwdLabel"
        Me.adminPwdLabel.Size = New System.Drawing.Size(126, 20)
        Me.adminPwdLabel.TabIndex = 54
        Me.adminPwdLabel.Text = "Admin password"
        '
        'userUserAddPhoneInput
        '
        Me.userUserAddPhoneInput.Location = New System.Drawing.Point(45, 184)
        Me.userUserAddPhoneInput.Name = "userUserAddPhoneInput"
        Me.userUserAddPhoneInput.Size = New System.Drawing.Size(316, 20)
        Me.userUserAddPhoneInput.TabIndex = 2
        '
        'adminPhoneNumberLabel
        '
        Me.adminPhoneNumberLabel.AutoSize = True
        Me.adminPhoneNumberLabel.BackColor = System.Drawing.Color.MintCream
        Me.adminPhoneNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.adminPhoneNumberLabel.Location = New System.Drawing.Point(41, 162)
        Me.adminPhoneNumberLabel.Name = "adminPhoneNumberLabel"
        Me.adminPhoneNumberLabel.Size = New System.Drawing.Size(161, 20)
        Me.adminPhoneNumberLabel.TabIndex = 50
        Me.adminPhoneNumberLabel.Text = "Admin phone number"
        '
        'userUserAddEmailInput
        '
        Me.userUserAddEmailInput.Location = New System.Drawing.Point(45, 135)
        Me.userUserAddEmailInput.Name = "userUserAddEmailInput"
        Me.userUserAddEmailInput.Size = New System.Drawing.Size(316, 20)
        Me.userUserAddEmailInput.TabIndex = 1
        '
        'adminEmailLabel
        '
        Me.adminEmailLabel.AutoSize = True
        Me.adminEmailLabel.BackColor = System.Drawing.Color.MintCream
        Me.adminEmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.adminEmailLabel.Location = New System.Drawing.Point(41, 114)
        Me.adminEmailLabel.Name = "adminEmailLabel"
        Me.adminEmailLabel.Size = New System.Drawing.Size(95, 20)
        Me.adminEmailLabel.TabIndex = 48
        Me.adminEmailLabel.Text = "Admin email"
        '
        'userUserAddNameInput
        '
        Me.userUserAddNameInput.Location = New System.Drawing.Point(45, 86)
        Me.userUserAddNameInput.Name = "userUserAddNameInput"
        Me.userUserAddNameInput.Size = New System.Drawing.Size(316, 20)
        Me.userUserAddNameInput.TabIndex = 0
        '
        'userAddValidationBtn
        '
        Me.userAddValidationBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.userAddValidationBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.userAddValidationBtn.FlatAppearance.BorderSize = 0
        Me.userAddValidationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userAddValidationBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.userAddValidationBtn.ForeColor = System.Drawing.Color.Yellow
        Me.userAddValidationBtn.Location = New System.Drawing.Point(45, 354)
        Me.userAddValidationBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.userAddValidationBtn.MaximumSize = New System.Drawing.Size(375, 50)
        Me.userAddValidationBtn.Name = "userAddValidationBtn"
        Me.userAddValidationBtn.Size = New System.Drawing.Size(315, 28)
        Me.userAddValidationBtn.TabIndex = 6
        Me.userAddValidationBtn.Text = "Add"
        Me.userAddValidationBtn.UseVisualStyleBackColor = False
        '
        'adminNameLabel
        '
        Me.adminNameLabel.AutoSize = True
        Me.adminNameLabel.BackColor = System.Drawing.Color.MintCream
        Me.adminNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.adminNameLabel.Location = New System.Drawing.Point(41, 65)
        Me.adminNameLabel.Name = "adminNameLabel"
        Me.adminNameLabel.Size = New System.Drawing.Size(98, 20)
        Me.adminNameLabel.TabIndex = 11
        Me.adminNameLabel.Text = "Admin name"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.SeaGreen
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(414, 37)
        Me.Label10.TabIndex = 60
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer2
        '
        '
        'englishBtn
        '
        Me.englishBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.englishBtn.AutoSize = True
        Me.englishBtn.BackColor = System.Drawing.Color.Transparent
        Me.englishBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.englishBtn.FlatAppearance.BorderSize = 0
        Me.englishBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.englishBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.englishBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.englishBtn.Image = Global.cems.My.Resources.Resources.englishFlag
        Me.englishBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.englishBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.englishBtn.Location = New System.Drawing.Point(868, 207)
        Me.englishBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.englishBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.englishBtn.Name = "englishBtn"
        Me.englishBtn.Size = New System.Drawing.Size(68, 29)
        Me.englishBtn.TabIndex = 38
        Me.englishBtn.Text = "En"
        Me.englishBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.englishBtn.UseVisualStyleBackColor = False
        '
        'frenchBtn
        '
        Me.frenchBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frenchBtn.AutoSize = True
        Me.frenchBtn.BackColor = System.Drawing.Color.Transparent
        Me.frenchBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.frenchBtn.FlatAppearance.BorderSize = 0
        Me.frenchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frenchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.frenchBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.frenchBtn.Image = Global.cems.My.Resources.Resources.frenchFlag
        Me.frenchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.frenchBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.frenchBtn.Location = New System.Drawing.Point(868, 207)
        Me.frenchBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.frenchBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.frenchBtn.Name = "frenchBtn"
        Me.frenchBtn.Size = New System.Drawing.Size(68, 29)
        Me.frenchBtn.TabIndex = 39
        Me.frenchBtn.Text = "Fr"
        Me.frenchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.frenchBtn.UseVisualStyleBackColor = False
        Me.frenchBtn.Visible = False
        '
        'errorProviderEmail
        '
        Me.errorProviderEmail.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(1443, 698)
        Me.Controls.Add(Me.userAddPanel)
        Me.Controls.Add(Me.englishBtn)
        Me.Controls.Add(Me.frenchBtn)
        Me.Controls.Add(Me.loginPanel)
        Me.Controls.Add(Me.connexionStringPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CEMS-Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.loginPanel.ResumeLayout(False)
        Me.loginPanel.PerformLayout()
        Me.connexionStringPanel.ResumeLayout(False)
        Me.connexionStringPanel.PerformLayout()
        Me.userAddPanel.ResumeLayout(False)
        Me.userAddPanel.PerformLayout()
        CType(Me.errorProviderEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginPanel As Panel
    Friend WithEvents loginTitle As Label
    Friend WithEvents forgotPwdBtn As Button
    Friend WithEvents loginBtn As Button
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents emailtxt As TextBox
    Friend WithEvents forgotPasswordMessage As Label
    Friend WithEvents connexionStringPanel As Panel
    Friend WithEvents connexionStringDatabase As TextBox
    Friend WithEvents connexionStringServer As TextBox
    Friend WithEvents connexionErrorMsg As Label
    Friend WithEvents connectBtn As Button
    Friend WithEvents connexionStringPwd As TextBox
    Friend WithEvents connexionStringUserName As TextBox
    Friend WithEvents connexionTitle As Label
    Friend WithEvents connexionPwdLabel As Label
    Friend WithEvents connexionServerLabel As Label
    Friend WithEvents connexionDatabaseLabel As Label
    Friend WithEvents connexionUserNameLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents userAddPanel As Panel
    Friend WithEvents createAdminTitle As Label
    Friend WithEvents addUserErrorMsg As Label
    Friend WithEvents userUserAddConfirmPwdInput As TextBox
    Friend WithEvents userConfirmPwdLabel As Label
    Friend WithEvents userUserAddPwdInput As TextBox
    Friend WithEvents adminPwdLabel As Label
    Friend WithEvents userUserAddPhoneInput As TextBox
    Friend WithEvents adminPhoneNumberLabel As Label
    Friend WithEvents userUserAddEmailInput As TextBox
    Friend WithEvents adminEmailLabel As Label
    Friend WithEvents userUserAddNameInput As TextBox
    Friend WithEvents userAddValidationBtn As Button
    Friend WithEvents adminNameLabel As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Label51 As Label
    Friend WithEvents loginUserEmailLabel As Label
    Friend WithEvents loginUserPwdLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents englishBtn As Button
    Friend WithEvents frenchBtn As Button
    Friend WithEvents errorProviderEmail As ErrorProvider
End Class
