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
        Me.connexionStringPanel = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.connexionStringDatabase = New System.Windows.Forms.TextBox()
        Me.connexionStringServer = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.connexionErrorMsg = New System.Windows.Forms.Label()
        Me.connectBtn = New System.Windows.Forms.Button()
        Me.connexionStringPwd = New System.Windows.Forms.TextBox()
        Me.connexionStringUserName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.forgotPasswordMessage = New System.Windows.Forms.Label()
        Me.forgotPasswordBtn = New System.Windows.Forms.Button()
        Me.login = New System.Windows.Forms.Button()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.emailtxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.userAddPanel = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
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
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.connexionStringPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.userAddPanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.Controls.Add(Me.connexionStringPanel)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.forgotPasswordMessage)
        Me.Panel1.Controls.Add(Me.forgotPasswordBtn)
        Me.Panel1.Controls.Add(Me.login)
        Me.Panel1.Controls.Add(Me.passwordtxt)
        Me.Panel1.Controls.Add(Me.emailtxt)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(109, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 313)
        Me.Panel1.TabIndex = 0
        '
        'connexionStringPanel
        '
        Me.connexionStringPanel.BackColor = System.Drawing.Color.LightSlateGray
        Me.connexionStringPanel.Controls.Add(Me.Label7)
        Me.connexionStringPanel.Controls.Add(Me.Label6)
        Me.connexionStringPanel.Controls.Add(Me.Label5)
        Me.connexionStringPanel.Controls.Add(Me.Label4)
        Me.connexionStringPanel.Controls.Add(Me.connexionStringDatabase)
        Me.connexionStringPanel.Controls.Add(Me.connexionStringServer)
        Me.connexionStringPanel.Controls.Add(Me.PictureBox1)
        Me.connexionStringPanel.Controls.Add(Me.connexionErrorMsg)
        Me.connexionStringPanel.Controls.Add(Me.connectBtn)
        Me.connexionStringPanel.Controls.Add(Me.connexionStringPwd)
        Me.connexionStringPanel.Controls.Add(Me.connexionStringUserName)
        Me.connexionStringPanel.Controls.Add(Me.Label3)
        Me.connexionStringPanel.Location = New System.Drawing.Point(0, 0)
        Me.connexionStringPanel.Name = "connexionStringPanel"
        Me.connexionStringPanel.Size = New System.Drawing.Size(488, 313)
        Me.connexionStringPanel.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(73, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "password: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(73, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "server: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "database: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "user name: "
        '
        'connexionStringDatabase
        '
        Me.connexionStringDatabase.Location = New System.Drawing.Point(196, 180)
        Me.connexionStringDatabase.Name = "connexionStringDatabase"
        Me.connexionStringDatabase.Size = New System.Drawing.Size(170, 20)
        Me.connexionStringDatabase.TabIndex = 9
        '
        'connexionStringServer
        '
        Me.connexionStringServer.Location = New System.Drawing.Point(196, 72)
        Me.connexionStringServer.Name = "connexionStringServer"
        Me.connexionStringServer.Size = New System.Drawing.Size(170, 20)
        Me.connexionStringServer.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cems.My.Resources.Resources.logo_light
        Me.PictureBox1.Location = New System.Drawing.Point(30, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'connexionErrorMsg
        '
        Me.connexionErrorMsg.AutoSize = True
        Me.connexionErrorMsg.Location = New System.Drawing.Point(27, 278)
        Me.connexionErrorMsg.Name = "connexionErrorMsg"
        Me.connexionErrorMsg.Size = New System.Drawing.Size(13, 13)
        Me.connexionErrorMsg.TabIndex = 1
        Me.connexionErrorMsg.Text = "  "
        '
        'connectBtn
        '
        Me.connectBtn.Location = New System.Drawing.Point(305, 238)
        Me.connectBtn.Name = "connectBtn"
        Me.connectBtn.Size = New System.Drawing.Size(75, 23)
        Me.connectBtn.TabIndex = 5
        Me.connectBtn.Text = "Connect"
        Me.connectBtn.UseVisualStyleBackColor = True
        '
        'connexionStringPwd
        '
        Me.connexionStringPwd.Location = New System.Drawing.Point(196, 144)
        Me.connexionStringPwd.Name = "connexionStringPwd"
        Me.connexionStringPwd.Size = New System.Drawing.Size(170, 20)
        Me.connexionStringPwd.TabIndex = 3
        '
        'connexionStringUserName
        '
        Me.connexionStringUserName.Location = New System.Drawing.Point(196, 107)
        Me.connexionStringUserName.Name = "connexionStringUserName"
        Me.connexionStringUserName.Size = New System.Drawing.Size(170, 20)
        Me.connexionStringUserName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Enter your connexion string"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cems.My.Resources.Resources.logo_light
        Me.PictureBox2.Location = New System.Drawing.Point(196, 50)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(78, 68)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'forgotPasswordMessage
        '
        Me.forgotPasswordMessage.AutoSize = True
        Me.forgotPasswordMessage.ForeColor = System.Drawing.Color.Red
        Me.forgotPasswordMessage.Location = New System.Drawing.Point(27, 278)
        Me.forgotPasswordMessage.Name = "forgotPasswordMessage"
        Me.forgotPasswordMessage.Size = New System.Drawing.Size(13, 13)
        Me.forgotPasswordMessage.TabIndex = 1
        Me.forgotPasswordMessage.Text = "  "
        '
        'forgotPasswordBtn
        '
        Me.forgotPasswordBtn.BackColor = System.Drawing.Color.Transparent
        Me.forgotPasswordBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.forgotPasswordBtn.Location = New System.Drawing.Point(114, 238)
        Me.forgotPasswordBtn.Name = "forgotPasswordBtn"
        Me.forgotPasswordBtn.Size = New System.Drawing.Size(103, 23)
        Me.forgotPasswordBtn.TabIndex = 6
        Me.forgotPasswordBtn.Text = "Forgot password ?"
        Me.forgotPasswordBtn.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.login.Location = New System.Drawing.Point(305, 238)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(75, 23)
        Me.login.TabIndex = 5
        Me.login.Text = "Login"
        Me.login.UseVisualStyleBackColor = True
        '
        'passwordtxt
        '
        Me.passwordtxt.Location = New System.Drawing.Point(114, 206)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordtxt.Size = New System.Drawing.Size(266, 20)
        Me.passwordtxt.TabIndex = 3
        Me.passwordtxt.Text = "password"
        '
        'emailtxt
        '
        Me.emailtxt.Location = New System.Drawing.Point(114, 169)
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.Size = New System.Drawing.Size(266, 20)
        Me.emailtxt.TabIndex = 2
        Me.emailtxt.Text = "email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login to start session"
        '
        'Timer1
        '
        '
        'userAddPanel
        '
        Me.userAddPanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.userAddPanel.Controls.Add(Me.PictureBox3)
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
        Me.userAddPanel.Location = New System.Drawing.Point(109, 50)
        Me.userAddPanel.Name = "userAddPanel"
        Me.userAddPanel.Size = New System.Drawing.Size(488, 313)
        Me.userAddPanel.TabIndex = 59
        Me.userAddPanel.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.cems.My.Resources.Resources.logo_light
        Me.PictureBox3.Location = New System.Drawing.Point(30, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(39, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 60
        Me.PictureBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(96, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(199, 20)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Create your admin account"
        '
        'addUserErrorMsg
        '
        Me.addUserErrorMsg.AutoSize = True
        Me.addUserErrorMsg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.addUserErrorMsg.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addUserErrorMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addUserErrorMsg.Location = New System.Drawing.Point(49, 277)
        Me.addUserErrorMsg.Name = "addUserErrorMsg"
        Me.addUserErrorMsg.Size = New System.Drawing.Size(0, 16)
        Me.addUserErrorMsg.TabIndex = 58
        Me.addUserErrorMsg.Visible = False
        '
        'userUserAddTitleInput
        '
        Me.userUserAddTitleInput.FormattingEnabled = True
        Me.userUserAddTitleInput.Location = New System.Drawing.Point(262, 156)
        Me.userUserAddTitleInput.Name = "userUserAddTitleInput"
        Me.userUserAddTitleInput.Size = New System.Drawing.Size(180, 21)
        Me.userUserAddTitleInput.TabIndex = 47
        '
        'userUserAddConfirmPwdInput
        '
        Me.userUserAddConfirmPwdInput.Location = New System.Drawing.Point(262, 224)
        Me.userUserAddConfirmPwdInput.Name = "userUserAddConfirmPwdInput"
        Me.userUserAddConfirmPwdInput.Size = New System.Drawing.Size(180, 20)
        Me.userUserAddConfirmPwdInput.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 20)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "confirm password:"
        '
        'userUserAddPwdInput
        '
        Me.userUserAddPwdInput.Location = New System.Drawing.Point(262, 198)
        Me.userUserAddPwdInput.Name = "userUserAddPwdInput"
        Me.userUserAddPwdInput.Size = New System.Drawing.Size(180, 20)
        Me.userUserAddPwdInput.TabIndex = 55
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(46, 197)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(155, 20)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "user password :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(46, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 20)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "user title :"
        '
        'userUserAddPhoneInput
        '
        Me.userUserAddPhoneInput.Location = New System.Drawing.Point(262, 129)
        Me.userUserAddPhoneInput.Name = "userUserAddPhoneInput"
        Me.userUserAddPhoneInput.Size = New System.Drawing.Size(180, 20)
        Me.userUserAddPhoneInput.TabIndex = 51
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(46, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(199, 20)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "user phone number :"
        '
        'userUserAddEmailInput
        '
        Me.userUserAddEmailInput.Location = New System.Drawing.Point(262, 100)
        Me.userUserAddEmailInput.Name = "userUserAddEmailInput"
        Me.userUserAddEmailInput.Size = New System.Drawing.Size(180, 20)
        Me.userUserAddEmailInput.TabIndex = 49
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(46, 99)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 20)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "user email :"
        '
        'userUserAddNameInput
        '
        Me.userUserAddNameInput.Location = New System.Drawing.Point(262, 71)
        Me.userUserAddNameInput.Name = "userUserAddNameInput"
        Me.userUserAddNameInput.Size = New System.Drawing.Size(180, 20)
        Me.userUserAddNameInput.TabIndex = 19
        '
        'userAddvalidationBtn
        '
        Me.userAddvalidationBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.userAddvalidationBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.userAddvalidationBtn.FlatAppearance.BorderSize = 0
        Me.userAddvalidationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userAddvalidationBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.userAddvalidationBtn.Location = New System.Drawing.Point(359, 266)
        Me.userAddvalidationBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.userAddvalidationBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.userAddvalidationBtn.Name = "userAddvalidationBtn"
        Me.userAddvalidationBtn.Size = New System.Drawing.Size(82, 32)
        Me.userAddvalidationBtn.TabIndex = 13
        Me.userAddvalidationBtn.Text = "Add"
        Me.userAddvalidationBtn.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(46, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(119, 20)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "user name :"
        '
        'Timer2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(713, 391)
        Me.Controls.Add(Me.userAddPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CEMS-Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.connexionStringPanel.ResumeLayout(False)
        Me.connexionStringPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.userAddPanel.ResumeLayout(False)
        Me.userAddPanel.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents forgotPasswordBtn As Button
    Friend WithEvents login As Button
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents emailtxt As TextBox
    Friend WithEvents forgotPasswordMessage As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents connexionStringPanel As Panel
    Friend WithEvents connexionStringDatabase As TextBox
    Friend WithEvents connexionStringServer As TextBox
    Friend WithEvents PictureBox1 As PictureBox
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
    Friend WithEvents PictureBox3 As PictureBox
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
End Class
