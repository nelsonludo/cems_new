<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userUpdatePanel
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
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.userUserTitleInput)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.userUserPhoneInput)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.userUserEmailInput)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.userCancelBtn)
        Me.Panel1.Controls.Add(Me.userUserNameInput)
        Me.Panel1.Controls.Add(Me.userUpdateValidationBtn)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(623, 266)
        Me.Panel1.TabIndex = 47
        Me.Panel1.Visible = False
        '
        'userUserTitleInput
        '
        Me.userUserTitleInput.FormattingEnabled = True
        Me.userUserTitleInput.Location = New System.Drawing.Point(269, 115)
        Me.userUserTitleInput.Name = "userUserTitleInput"
        Me.userUserTitleInput.Size = New System.Drawing.Size(180, 21)
        Me.userUserTitleInput.TabIndex = 47
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(53, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 20)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "user title :"
        '
        'userUserPhoneInput
        '
        Me.userUserPhoneInput.Location = New System.Drawing.Point(269, 88)
        Me.userUserPhoneInput.Name = "userUserPhoneInput"
        Me.userUserPhoneInput.Size = New System.Drawing.Size(180, 20)
        Me.userUserPhoneInput.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(53, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(199, 20)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "user phone number :"
        '
        'userUserEmailInput
        '
        Me.userUserEmailInput.Location = New System.Drawing.Point(269, 59)
        Me.userUserEmailInput.Name = "userUserEmailInput"
        Me.userUserEmailInput.Size = New System.Drawing.Size(180, 20)
        Me.userUserEmailInput.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 20)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "user email :"
        '
        'userCancelBtn
        '
        Me.userCancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.userCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.userCancelBtn.FlatAppearance.BorderSize = 0
        Me.userCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userCancelBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.userCancelBtn.Location = New System.Drawing.Point(370, 225)
        Me.userCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.userCancelBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.userCancelBtn.Name = "userCancelBtn"
        Me.userCancelBtn.Size = New System.Drawing.Size(79, 32)
        Me.userCancelBtn.TabIndex = 44
        Me.userCancelBtn.Text = "Cancel"
        Me.userCancelBtn.UseVisualStyleBackColor = False
        '
        'userUserNameInput
        '
        Me.userUserNameInput.Location = New System.Drawing.Point(269, 30)
        Me.userUserNameInput.Name = "userUserNameInput"
        Me.userUserNameInput.Size = New System.Drawing.Size(180, 20)
        Me.userUserNameInput.TabIndex = 19
        '
        'userUpdateValidationBtn
        '
        Me.userUpdateValidationBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.userUpdateValidationBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.userUpdateValidationBtn.FlatAppearance.BorderSize = 0
        Me.userUpdateValidationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userUpdateValidationBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.userUpdateValidationBtn.Location = New System.Drawing.Point(467, 225)
        Me.userUpdateValidationBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.userUpdateValidationBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.userUpdateValidationBtn.Name = "userUpdateValidationBtn"
        Me.userUpdateValidationBtn.Size = New System.Drawing.Size(95, 32)
        Me.userUpdateValidationBtn.TabIndex = 13
        Me.userUpdateValidationBtn.Text = "Update"
        Me.userUpdateValidationBtn.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(53, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "user name :"
        '
        'userUpdatePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "userUpdatePanel"
        Me.Size = New System.Drawing.Size(625, 267)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
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
End Class
