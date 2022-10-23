<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminProfilePanelUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.adminProfilePanel = New System.Windows.Forms.Panel()
        Me.profileSubPanel1 = New System.Windows.Forms.Panel()
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
        Me.adminProfilePanel.SuspendLayout()
        Me.profileSubPanel1.SuspendLayout()
        Me.profileSubPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'adminProfilePanel
        '
        Me.adminProfilePanel.Controls.Add(Me.profileSubPanel1)
        Me.adminProfilePanel.Controls.Add(Me.profileTitle)
        Me.adminProfilePanel.Location = New System.Drawing.Point(0, 0)
        Me.adminProfilePanel.Name = "adminProfilePanel"
        Me.adminProfilePanel.Size = New System.Drawing.Size(725, 423)
        Me.adminProfilePanel.TabIndex = 40
        '
        'profileSubPanel1
        '
        Me.profileSubPanel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.profileSubPanel1.Controls.Add(Me.profileSubPanel2)
        Me.profileSubPanel1.Controls.Add(Me.updateProfileShowBtn)
        Me.profileSubPanel1.Controls.Add(Me.adminEmailProfile)
        Me.profileSubPanel1.Controls.Add(Me.adminTitleProfile)
        Me.profileSubPanel1.Controls.Add(Me.adminPhoneNumberProfile)
        Me.profileSubPanel1.Controls.Add(Me.adminNameProfile)
        Me.profileSubPanel1.Controls.Add(Me.adminEmailProfileLabel)
        Me.profileSubPanel1.Controls.Add(Me.adminPhoneNumberProfileLabel)
        Me.profileSubPanel1.Controls.Add(Me.adminTitleProfileLabel)
        Me.profileSubPanel1.Controls.Add(Me.adminNameProfileLabel)
        Me.profileSubPanel1.Location = New System.Drawing.Point(66, 93)
        Me.profileSubPanel1.Name = "profileSubPanel1"
        Me.profileSubPanel1.Size = New System.Drawing.Size(587, 252)
        Me.profileSubPanel1.TabIndex = 31
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
        Me.profileSubPanel2.Location = New System.Drawing.Point(0, 0)
        Me.profileSubPanel2.Name = "profileSubPanel2"
        Me.profileSubPanel2.Size = New System.Drawing.Size(587, 252)
        Me.profileSubPanel2.TabIndex = 33
        Me.profileSubPanel2.Visible = False
        '
        'userConfirmPwdProfileInput
        '
        Me.userConfirmPwdProfileInput.Location = New System.Drawing.Point(299, 182)
        Me.userConfirmPwdProfileInput.Name = "userConfirmPwdProfileInput"
        Me.userConfirmPwdProfileInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
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
        Me.userPwdProfileInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
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
        'adminEmailProfile
        '
        Me.adminEmailProfile.AutoSize = True
        Me.adminEmailProfile.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.adminEmailProfile.Location = New System.Drawing.Point(295, 118)
        Me.adminEmailProfile.Name = "adminEmailProfile"
        Me.adminEmailProfile.Size = New System.Drawing.Size(75, 19)
        Me.adminEmailProfile.TabIndex = 14
        Me.adminEmailProfile.Text = "******"
        '
        'adminTitleProfile
        '
        Me.adminTitleProfile.AutoSize = True
        Me.adminTitleProfile.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.adminTitleProfile.Location = New System.Drawing.Point(295, 190)
        Me.adminTitleProfile.Name = "adminTitleProfile"
        Me.adminTitleProfile.Size = New System.Drawing.Size(75, 19)
        Me.adminTitleProfile.TabIndex = 13
        Me.adminTitleProfile.Text = "******"
        '
        'adminPhoneNumberProfile
        '
        Me.adminPhoneNumberProfile.AutoSize = True
        Me.adminPhoneNumberProfile.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.adminPhoneNumberProfile.Location = New System.Drawing.Point(295, 153)
        Me.adminPhoneNumberProfile.Name = "adminPhoneNumberProfile"
        Me.adminPhoneNumberProfile.Size = New System.Drawing.Size(75, 19)
        Me.adminPhoneNumberProfile.TabIndex = 12
        Me.adminPhoneNumberProfile.Text = "******"
        '
        'adminNameProfile
        '
        Me.adminNameProfile.AutoSize = True
        Me.adminNameProfile.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.adminNameProfile.Location = New System.Drawing.Point(295, 84)
        Me.adminNameProfile.Name = "adminNameProfile"
        Me.adminNameProfile.Size = New System.Drawing.Size(75, 19)
        Me.adminNameProfile.TabIndex = 7
        Me.adminNameProfile.Text = "******"
        '
        'adminEmailProfileLabel
        '
        Me.adminEmailProfileLabel.AutoSize = True
        Me.adminEmailProfileLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminEmailProfileLabel.Location = New System.Drawing.Point(47, 117)
        Me.adminEmailProfileLabel.Name = "adminEmailProfileLabel"
        Me.adminEmailProfileLabel.Size = New System.Drawing.Size(122, 20)
        Me.adminEmailProfileLabel.TabIndex = 11
        Me.adminEmailProfileLabel.Text = "User email :"
        '
        'adminPhoneNumberProfileLabel
        '
        Me.adminPhoneNumberProfileLabel.AutoSize = True
        Me.adminPhoneNumberProfileLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminPhoneNumberProfileLabel.Location = New System.Drawing.Point(47, 152)
        Me.adminPhoneNumberProfileLabel.Name = "adminPhoneNumberProfileLabel"
        Me.adminPhoneNumberProfileLabel.Size = New System.Drawing.Size(232, 20)
        Me.adminPhoneNumberProfileLabel.TabIndex = 10
        Me.adminPhoneNumberProfileLabel.Text = "User telephone nunber :"
        '
        'adminTitleProfileLabel
        '
        Me.adminTitleProfileLabel.AutoSize = True
        Me.adminTitleProfileLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminTitleProfileLabel.Location = New System.Drawing.Point(47, 186)
        Me.adminTitleProfileLabel.Name = "adminTitleProfileLabel"
        Me.adminTitleProfileLabel.Size = New System.Drawing.Size(114, 20)
        Me.adminTitleProfileLabel.TabIndex = 9
        Me.adminTitleProfileLabel.Text = "User Title :"
        '
        'adminNameProfileLabel
        '
        Me.adminNameProfileLabel.AutoSize = True
        Me.adminNameProfileLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminNameProfileLabel.Location = New System.Drawing.Point(47, 83)
        Me.adminNameProfileLabel.Name = "adminNameProfileLabel"
        Me.adminNameProfileLabel.Size = New System.Drawing.Size(121, 20)
        Me.adminNameProfileLabel.TabIndex = 7
        Me.adminNameProfileLabel.Text = "User name :"
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
        'profileSubPanel2UserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.adminProfilePanel)
        Me.Name = "profileSubPanel2UserControl"
        Me.Size = New System.Drawing.Size(725, 424)
        Me.adminProfilePanel.ResumeLayout(False)
        Me.adminProfilePanel.PerformLayout()
        Me.profileSubPanel1.ResumeLayout(False)
        Me.profileSubPanel1.PerformLayout()
        Me.profileSubPanel2.ResumeLayout(False)
        Me.profileSubPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents adminProfilePanel As Panel
    Friend WithEvents profileSubPanel1 As Panel
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
End Class
