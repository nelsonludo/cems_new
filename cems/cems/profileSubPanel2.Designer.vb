<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profileSubPanel2
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
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.userConfirmPwdProfileInput)
        Me.Panel1.Controls.Add(Me.userConfirmPwdProfileLabel)
        Me.Panel1.Controls.Add(Me.updateProfileCancelBtn)
        Me.Panel1.Controls.Add(Me.updateProfileErrorMsg)
        Me.Panel1.Controls.Add(Me.userPwdProfileInput)
        Me.Panel1.Controls.Add(Me.userPhoneNumberProfileInput)
        Me.Panel1.Controls.Add(Me.userEmailProfileInput)
        Me.Panel1.Controls.Add(Me.userNameProfileInput)
        Me.Panel1.Controls.Add(Me.updateProfileValidateBtn)
        Me.Panel1.Controls.Add(Me.userEmailProfileLabel2)
        Me.Panel1.Controls.Add(Me.userPhoneNumberProfileLabel2)
        Me.Panel1.Controls.Add(Me.userPwdProfileLabel)
        Me.Panel1.Controls.Add(Me.userNameProfileLabel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(587, 252)
        Me.Panel1.TabIndex = 34
        Me.Panel1.Visible = False
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
        'profileSubPanel2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "profileSubPanel2"
        Me.Size = New System.Drawing.Size(585, 250)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
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
End Class
