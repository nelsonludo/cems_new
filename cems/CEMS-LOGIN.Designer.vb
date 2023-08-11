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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.userEmail = New System.Windows.Forms.Label()
        Me.userPwd = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.forgotPasswordMessage = New System.Windows.Forms.Label()
        Me.forgotPasswordBtn = New System.Windows.Forms.Button()
        Me.login = New System.Windows.Forms.Button()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.emailtxt = New System.Windows.Forms.TextBox()
        Me.connexionStringPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.connexionStringDatabase = New System.Windows.Forms.TextBox()
        Me.connexionStringServer = New System.Windows.Forms.TextBox()
        Me.connexionErrorMsg = New System.Windows.Forms.Label()
        Me.connectBtn = New System.Windows.Forms.Button()
        Me.connexionStringPwd = New System.Windows.Forms.TextBox()
        Me.connexionStringUserName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.userAddPanel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.addUserErrorMsg = New System.Windows.Forms.Label()
        Me.userUserAddTitleInput = New System.Windows.Forms.ComboBox()
        Me.userUserAddConfirmPwdInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userUserAddPwdInput = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.userUserAddPhoneInput = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.userUserAddEmailInput = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.userUserAddNameInput = New System.Windows.Forms.TextBox()
        Me.userAddvalidationBtn = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.connexionStringPanel.SuspendLayout()
        Me.userAddPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MintCream
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.userEmail)
        Me.Panel1.Controls.Add(Me.userPwd)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label51)
        Me.Panel1.Controls.Add(Me.forgotPasswordMessage)
        Me.Panel1.Controls.Add(Me.forgotPasswordBtn)
        Me.Panel1.Controls.Add(Me.login)
        Me.Panel1.Controls.Add(Me.passwordtxt)
        Me.Panel1.Controls.Add(Me.emailtxt)
        Me.Panel1.Location = New System.Drawing.Point(808, 300)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 385)
        Me.Panel1.TabIndex = 0
        '
        'userEmail
        '
        Me.userEmail.AutoSize = True
        Me.userEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.userEmail.Location = New System.Drawing.Point(55, 80)
        Me.userEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userEmail.Name = "userEmail"
        Me.userEmail.Size = New System.Drawing.Size(62, 20)
        Me.userEmail.TabIndex = 54
        Me.userEmail.Text = "Email "
        '
        'userPwd
        '
        Me.userPwd.AutoSize = True
        Me.userPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.userPwd.Location = New System.Drawing.Point(55, 140)
        Me.userPwd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userPwd.Name = "userPwd"
        Me.userPwd.Size = New System.Drawing.Size(97, 20)
        Me.userPwd.TabIndex = 53
        Me.userPwd.Text = "Password "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SeaGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.MintCream
        Me.Label1.Location = New System.Drawing.Point(240, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login"
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
        Me.Label51.TabIndex = 52
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'forgotPasswordMessage
        '
        Me.forgotPasswordMessage.AutoSize = True
        Me.forgotPasswordMessage.ForeColor = System.Drawing.Color.Red
        Me.forgotPasswordMessage.Location = New System.Drawing.Point(10, 342)
        Me.forgotPasswordMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.forgotPasswordMessage.Name = "forgotPasswordMessage"
        Me.forgotPasswordMessage.Size = New System.Drawing.Size(13, 16)
        Me.forgotPasswordMessage.TabIndex = 1
        Me.forgotPasswordMessage.Text = "  "
        '
        'forgotPasswordBtn
        '
        Me.forgotPasswordBtn.BackColor = System.Drawing.Color.Transparent
        Me.forgotPasswordBtn.FlatAppearance.BorderSize = 0
        Me.forgotPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.forgotPasswordBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline)
        Me.forgotPasswordBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.forgotPasswordBtn.Location = New System.Drawing.Point(182, 251)
        Me.forgotPasswordBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.forgotPasswordBtn.Name = "forgotPasswordBtn"
        Me.forgotPasswordBtn.Size = New System.Drawing.Size(200, 35)
        Me.forgotPasswordBtn.TabIndex = 6
        Me.forgotPasswordBtn.Text = "Forgot password ?"
        Me.forgotPasswordBtn.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.login.BackColor = System.Drawing.Color.SeaGreen
        Me.login.FlatAppearance.BorderSize = 0
        Me.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.login.ForeColor = System.Drawing.Color.Yellow
        Me.login.Location = New System.Drawing.Point(60, 210)
        Me.login.Margin = New System.Windows.Forms.Padding(4)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(420, 35)
        Me.login.TabIndex = 5
        Me.login.Text = "Login"
        Me.login.UseVisualStyleBackColor = False
        '
        'passwordtxt
        '
        Me.passwordtxt.Location = New System.Drawing.Point(60, 166)
        Me.passwordtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordtxt.Size = New System.Drawing.Size(420, 22)
        Me.passwordtxt.TabIndex = 3
        Me.passwordtxt.UseSystemPasswordChar = True
        '
        'emailtxt
        '
        Me.emailtxt.Location = New System.Drawing.Point(60, 106)
        Me.emailtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.Size = New System.Drawing.Size(420, 22)
        Me.emailtxt.TabIndex = 2
        '
        'connexionStringPanel
        '
        Me.connexionStringPanel.BackColor = System.Drawing.Color.MintCream
        Me.connexionStringPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.connexionStringPanel.Controls.Add(Me.Label3)
        Me.connexionStringPanel.Controls.Add(Me.Label7)
        Me.connexionStringPanel.Controls.Add(Me.Label6)
        Me.connexionStringPanel.Controls.Add(Me.Label5)
        Me.connexionStringPanel.Controls.Add(Me.Label4)
        Me.connexionStringPanel.Controls.Add(Me.connexionStringDatabase)
        Me.connexionStringPanel.Controls.Add(Me.connexionStringServer)
        Me.connexionStringPanel.Controls.Add(Me.connexionErrorMsg)
        Me.connexionStringPanel.Controls.Add(Me.connectBtn)
        Me.connexionStringPanel.Controls.Add(Me.connexionStringPwd)
        Me.connexionStringPanel.Controls.Add(Me.connexionStringUserName)
        Me.connexionStringPanel.Controls.Add(Me.Label9)
        Me.connexionStringPanel.Location = New System.Drawing.Point(808, 300)
        Me.connexionStringPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.connexionStringPanel.Name = "connexionStringPanel"
        Me.connexionStringPanel.Size = New System.Drawing.Size(552, 395)
        Me.connexionStringPanel.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SeaGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.MintCream
        Me.Label3.Location = New System.Drawing.Point(240, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Connexion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.MintCream
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(55, 200)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.MintCream
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(55, 80)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Server "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.MintCream
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(55, 260)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Database"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.MintCream
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(55, 140)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "User name"
        '
        'connexionStringDatabase
        '
        Me.connexionStringDatabase.Location = New System.Drawing.Point(60, 286)
        Me.connexionStringDatabase.Margin = New System.Windows.Forms.Padding(4)
        Me.connexionStringDatabase.Name = "connexionStringDatabase"
        Me.connexionStringDatabase.Size = New System.Drawing.Size(420, 22)
        Me.connexionStringDatabase.TabIndex = 8
        '
        'connexionStringServer
        '
        Me.connexionStringServer.Location = New System.Drawing.Point(60, 106)
        Me.connexionStringServer.Margin = New System.Windows.Forms.Padding(4)
        Me.connexionStringServer.Name = "connexionStringServer"
        Me.connexionStringServer.Size = New System.Drawing.Size(420, 22)
        Me.connexionStringServer.TabIndex = 5
        '
        'connexionErrorMsg
        '
        Me.connexionErrorMsg.AutoSize = True
        Me.connexionErrorMsg.Location = New System.Drawing.Point(60, 360)
        Me.connexionErrorMsg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.connexionErrorMsg.Name = "connexionErrorMsg"
        Me.connexionErrorMsg.Size = New System.Drawing.Size(13, 16)
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
        Me.connectBtn.Location = New System.Drawing.Point(60, 315)
        Me.connectBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.connectBtn.Name = "connectBtn"
        Me.connectBtn.Size = New System.Drawing.Size(420, 35)
        Me.connectBtn.TabIndex = 9
        Me.connectBtn.Text = "Connect"
        Me.connectBtn.UseVisualStyleBackColor = False
        '
        'connexionStringPwd
        '
        Me.connexionStringPwd.Location = New System.Drawing.Point(60, 226)
        Me.connexionStringPwd.Margin = New System.Windows.Forms.Padding(4)
        Me.connexionStringPwd.Name = "connexionStringPwd"
        Me.connexionStringPwd.Size = New System.Drawing.Size(420, 22)
        Me.connexionStringPwd.TabIndex = 7
        Me.connexionStringPwd.UseSystemPasswordChar = True
        '
        'connexionStringUserName
        '
        Me.connexionStringUserName.Location = New System.Drawing.Point(60, 166)
        Me.connexionStringUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.connexionStringUserName.Name = "connexionStringUserName"
        Me.connexionStringUserName.Size = New System.Drawing.Size(420, 22)
        Me.connexionStringUserName.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SeaGreen
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(550, 45)
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
        Me.userAddPanel.Controls.Add(Me.Label8)
        Me.userAddPanel.Controls.Add(Me.addUserErrorMsg)
        Me.userAddPanel.Controls.Add(Me.userUserAddTitleInput)
        Me.userAddPanel.Controls.Add(Me.userUserAddConfirmPwdInput)
        Me.userAddPanel.Controls.Add(Me.Label2)
        Me.userAddPanel.Controls.Add(Me.userUserAddPwdInput)
        Me.userAddPanel.Controls.Add(Me.Label14)
        Me.userAddPanel.Controls.Add(Me.Label15)
        Me.userAddPanel.Controls.Add(Me.userUserAddPhoneInput)
        Me.userAddPanel.Controls.Add(Me.Label16)
        Me.userAddPanel.Controls.Add(Me.userUserAddEmailInput)
        Me.userAddPanel.Controls.Add(Me.Label17)
        Me.userAddPanel.Controls.Add(Me.userUserAddNameInput)
        Me.userAddPanel.Controls.Add(Me.userAddvalidationBtn)
        Me.userAddPanel.Controls.Add(Me.Label18)
        Me.userAddPanel.Controls.Add(Me.Label10)
        Me.userAddPanel.Location = New System.Drawing.Point(808, 300)
        Me.userAddPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.userAddPanel.Name = "userAddPanel"
        Me.userAddPanel.Size = New System.Drawing.Size(552, 520)
        Me.userAddPanel.TabIndex = 11
        Me.userAddPanel.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.SeaGreen
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.MintCream
        Me.Label8.Location = New System.Drawing.Point(210, 9)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 22)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Create admin"
        '
        'addUserErrorMsg
        '
        Me.addUserErrorMsg.AutoSize = True
        Me.addUserErrorMsg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.addUserErrorMsg.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addUserErrorMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addUserErrorMsg.Location = New System.Drawing.Point(65, 486)
        Me.addUserErrorMsg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.addUserErrorMsg.Name = "addUserErrorMsg"
        Me.addUserErrorMsg.Size = New System.Drawing.Size(0, 19)
        Me.addUserErrorMsg.TabIndex = 58
        Me.addUserErrorMsg.Visible = False
        '
        'userUserAddTitleInput
        '
        Me.userUserAddTitleInput.FormattingEnabled = True
        Me.userUserAddTitleInput.Location = New System.Drawing.Point(60, 286)
        Me.userUserAddTitleInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userUserAddTitleInput.Name = "userUserAddTitleInput"
        Me.userUserAddTitleInput.Size = New System.Drawing.Size(420, 24)
        Me.userUserAddTitleInput.TabIndex = 3
        '
        'userUserAddConfirmPwdInput
        '
        Me.userUserAddConfirmPwdInput.Location = New System.Drawing.Point(60, 406)
        Me.userUserAddConfirmPwdInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userUserAddConfirmPwdInput.Name = "userUserAddConfirmPwdInput"
        Me.userUserAddConfirmPwdInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.userUserAddConfirmPwdInput.Size = New System.Drawing.Size(420, 22)
        Me.userUserAddConfirmPwdInput.TabIndex = 5
        Me.userUserAddConfirmPwdInput.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.MintCream
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(55, 380)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 20)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Confirm password"
        '
        'userUserAddPwdInput
        '
        Me.userUserAddPwdInput.Location = New System.Drawing.Point(60, 346)
        Me.userUserAddPwdInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userUserAddPwdInput.Name = "userUserAddPwdInput"
        Me.userUserAddPwdInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.userUserAddPwdInput.Size = New System.Drawing.Size(420, 22)
        Me.userUserAddPwdInput.TabIndex = 4
        Me.userUserAddPwdInput.UseSystemPasswordChar = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.MintCream
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(55, 320)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(135, 20)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "User password"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.MintCream
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(55, 260)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 20)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "User title"
        '
        'userUserAddPhoneInput
        '
        Me.userUserAddPhoneInput.Location = New System.Drawing.Point(60, 226)
        Me.userUserAddPhoneInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userUserAddPhoneInput.Name = "userUserAddPhoneInput"
        Me.userUserAddPhoneInput.Size = New System.Drawing.Size(420, 22)
        Me.userUserAddPhoneInput.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.MintCream
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(55, 200)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(173, 20)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "User phone number"
        '
        'userUserAddEmailInput
        '
        Me.userUserAddEmailInput.Location = New System.Drawing.Point(60, 166)
        Me.userUserAddEmailInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userUserAddEmailInput.Name = "userUserAddEmailInput"
        Me.userUserAddEmailInput.Size = New System.Drawing.Size(420, 22)
        Me.userUserAddEmailInput.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.MintCream
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(55, 140)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 20)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "User email"
        '
        'userUserAddNameInput
        '
        Me.userUserAddNameInput.Location = New System.Drawing.Point(60, 106)
        Me.userUserAddNameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userUserAddNameInput.Name = "userUserAddNameInput"
        Me.userUserAddNameInput.Size = New System.Drawing.Size(420, 22)
        Me.userUserAddNameInput.TabIndex = 0
        '
        'userAddvalidationBtn
        '
        Me.userAddvalidationBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.userAddvalidationBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.userAddvalidationBtn.FlatAppearance.BorderSize = 0
        Me.userAddvalidationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userAddvalidationBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.userAddvalidationBtn.ForeColor = System.Drawing.Color.Yellow
        Me.userAddvalidationBtn.Location = New System.Drawing.Point(60, 436)
        Me.userAddvalidationBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.userAddvalidationBtn.MaximumSize = New System.Drawing.Size(500, 62)
        Me.userAddvalidationBtn.Name = "userAddvalidationBtn"
        Me.userAddvalidationBtn.Size = New System.Drawing.Size(420, 35)
        Me.userAddvalidationBtn.TabIndex = 6
        Me.userAddvalidationBtn.Text = "Add"
        Me.userAddvalidationBtn.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.MintCream
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(55, 80)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 20)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "User name"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.SeaGreen
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(552, 45)
        Me.Label10.TabIndex = 60
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(1924, 859)
        Me.Controls.Add(Me.userAddPanel)
        Me.Controls.Add(Me.connexionStringPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CEMS-Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.connexionStringPanel.ResumeLayout(False)
        Me.connexionStringPanel.PerformLayout()
        Me.userAddPanel.ResumeLayout(False)
        Me.userAddPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents forgotPasswordBtn As Button
    Friend WithEvents login As Button
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents userAddPanel As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents addUserErrorMsg As Label
    Friend WithEvents userUserAddTitleInput As ComboBox
    Friend WithEvents userUserAddConfirmPwdInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents userUserAddPwdInput As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents userUserAddPhoneInput As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents userUserAddEmailInput As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents userUserAddNameInput As TextBox
    Friend WithEvents userAddvalidationBtn As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Label51 As Label
    Friend WithEvents userEmail As Label
    Friend WithEvents userPwd As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
