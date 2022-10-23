<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userAddPanelUserControl
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
        Me.userAddPanel.SuspendLayout()
        Me.SuspendLayout()
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
        Me.userAddPanel.Location = New System.Drawing.Point(0, 0)
        Me.userAddPanel.Name = "userAddPanel"
        Me.userAddPanel.Size = New System.Drawing.Size(623, 266)
        Me.userAddPanel.TabIndex = 59
        Me.userAddPanel.Visible = False
        '
        'addUserErrorMsg
        '
        Me.addUserErrorMsg.AutoSize = True
        Me.addUserErrorMsg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.addUserErrorMsg.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addUserErrorMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addUserErrorMsg.Location = New System.Drawing.Point(56, 236)
        Me.addUserErrorMsg.Name = "addUserErrorMsg"
        Me.addUserErrorMsg.Size = New System.Drawing.Size(0, 16)
        Me.addUserErrorMsg.TabIndex = 58
        Me.addUserErrorMsg.Visible = False
        '
        'userUserAddTitleInput
        '
        Me.userUserAddTitleInput.FormattingEnabled = True
        Me.userUserAddTitleInput.Location = New System.Drawing.Point(269, 115)
        Me.userUserAddTitleInput.Name = "userUserAddTitleInput"
        Me.userUserAddTitleInput.Size = New System.Drawing.Size(180, 21)
        Me.userUserAddTitleInput.TabIndex = 47
        '
        'userUserAddConfirmPwdInput
        '
        Me.userUserAddConfirmPwdInput.Location = New System.Drawing.Point(269, 183)
        Me.userUserAddConfirmPwdInput.Name = "userUserAddConfirmPwdInput"
        Me.userUserAddConfirmPwdInput.Size = New System.Drawing.Size(180, 20)
        Me.userUserAddConfirmPwdInput.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 20)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "confirm password:"
        '
        'userUserAddPwdInput
        '
        Me.userUserAddPwdInput.Location = New System.Drawing.Point(269, 157)
        Me.userUserAddPwdInput.Name = "userUserAddPwdInput"
        Me.userUserAddPwdInput.Size = New System.Drawing.Size(180, 20)
        Me.userUserAddPwdInput.TabIndex = 55
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(53, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(155, 20)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "user password :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(53, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 20)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "user title :"
        '
        'userUserAddPhoneInput
        '
        Me.userUserAddPhoneInput.Location = New System.Drawing.Point(269, 88)
        Me.userUserAddPhoneInput.Name = "userUserAddPhoneInput"
        Me.userUserAddPhoneInput.Size = New System.Drawing.Size(180, 20)
        Me.userUserAddPhoneInput.TabIndex = 51
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(53, 87)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(199, 20)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "user phone number :"
        '
        'userUserAddEmailInput
        '
        Me.userUserAddEmailInput.Location = New System.Drawing.Point(269, 59)
        Me.userUserAddEmailInput.Name = "userUserAddEmailInput"
        Me.userUserAddEmailInput.Size = New System.Drawing.Size(180, 20)
        Me.userUserAddEmailInput.TabIndex = 49
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(53, 58)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 20)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "user email :"
        '
        'userAddCancelBtn
        '
        Me.userAddCancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.userAddCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.userAddCancelBtn.FlatAppearance.BorderSize = 0
        Me.userAddCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userAddCancelBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.userAddCancelBtn.Location = New System.Drawing.Point(370, 225)
        Me.userAddCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.userAddCancelBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.userAddCancelBtn.Name = "userAddCancelBtn"
        Me.userAddCancelBtn.Size = New System.Drawing.Size(79, 32)
        Me.userAddCancelBtn.TabIndex = 44
        Me.userAddCancelBtn.Text = "Cancel"
        Me.userAddCancelBtn.UseVisualStyleBackColor = False
        '
        'userUserAddNameInput
        '
        Me.userUserAddNameInput.Location = New System.Drawing.Point(269, 30)
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
        Me.userAddvalidationBtn.Location = New System.Drawing.Point(467, 225)
        Me.userAddvalidationBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.userAddvalidationBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.userAddvalidationBtn.Name = "userAddvalidationBtn"
        Me.userAddvalidationBtn.Size = New System.Drawing.Size(95, 32)
        Me.userAddvalidationBtn.TabIndex = 13
        Me.userAddvalidationBtn.Text = "Add"
        Me.userAddvalidationBtn.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(53, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(119, 20)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "user name :"
        '
        'userAddPanelUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.userAddPanel)
        Me.Name = "userAddPanelUserControl"
        Me.Size = New System.Drawing.Size(624, 267)
        Me.userAddPanel.ResumeLayout(False)
        Me.userAddPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

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
End Class
