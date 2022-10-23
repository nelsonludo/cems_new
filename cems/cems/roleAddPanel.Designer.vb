<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class roleAddPanel
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
        Me.addRoleErrorMsg = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.roleAddCancelBtn = New System.Windows.Forms.Button()
        Me.titleAddNameInput = New System.Windows.Forms.TextBox()
        Me.roleAddValidationBtn = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.addRoleErrorMsg)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.roleAddCancelBtn)
        Me.Panel1.Controls.Add(Me.titleAddNameInput)
        Me.Panel1.Controls.Add(Me.roleAddValidationBtn)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(623, 268)
        Me.Panel1.TabIndex = 59
        Me.Panel1.Visible = False
        '
        'addRoleErrorMsg
        '
        Me.addRoleErrorMsg.AutoSize = True
        Me.addRoleErrorMsg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.addRoleErrorMsg.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addRoleErrorMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addRoleErrorMsg.Location = New System.Drawing.Point(64, 225)
        Me.addRoleErrorMsg.Name = "addRoleErrorMsg"
        Me.addRoleErrorMsg.Size = New System.Drawing.Size(0, 16)
        Me.addRoleErrorMsg.TabIndex = 59
        Me.addRoleErrorMsg.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label12.Font = New System.Drawing.Font("MS Reference Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(56, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 12)
        Me.Label12.TabIndex = 58
        Me.Label12.Visible = False
        '
        'roleAddCancelBtn
        '
        Me.roleAddCancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.roleAddCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.roleAddCancelBtn.FlatAppearance.BorderSize = 0
        Me.roleAddCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roleAddCancelBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.roleAddCancelBtn.Location = New System.Drawing.Point(370, 225)
        Me.roleAddCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.roleAddCancelBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.roleAddCancelBtn.Name = "roleAddCancelBtn"
        Me.roleAddCancelBtn.Size = New System.Drawing.Size(79, 32)
        Me.roleAddCancelBtn.TabIndex = 44
        Me.roleAddCancelBtn.Text = "Cancel"
        Me.roleAddCancelBtn.UseVisualStyleBackColor = False
        '
        'titleAddNameInput
        '
        Me.titleAddNameInput.Location = New System.Drawing.Point(278, 91)
        Me.titleAddNameInput.Name = "titleAddNameInput"
        Me.titleAddNameInput.Size = New System.Drawing.Size(180, 20)
        Me.titleAddNameInput.TabIndex = 19
        '
        'roleAddValidationBtn
        '
        Me.roleAddValidationBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.roleAddValidationBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.roleAddValidationBtn.FlatAppearance.BorderSize = 0
        Me.roleAddValidationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roleAddValidationBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.roleAddValidationBtn.Location = New System.Drawing.Point(467, 225)
        Me.roleAddValidationBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.roleAddValidationBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.roleAddValidationBtn.Name = "roleAddValidationBtn"
        Me.roleAddValidationBtn.Size = New System.Drawing.Size(95, 32)
        Me.roleAddValidationBtn.TabIndex = 13
        Me.roleAddValidationBtn.Text = "Add"
        Me.roleAddValidationBtn.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(62, 90)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(120, 20)
        Me.Label24.TabIndex = 11
        Me.Label24.Text = "Role name :"
        '
        'roleAddPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "roleAddPanel"
        Me.Size = New System.Drawing.Size(623, 266)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents addRoleErrorMsg As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents roleAddCancelBtn As Button
    Friend WithEvents titleAddNameInput As TextBox
    Friend WithEvents roleAddValidationBtn As Button
    Friend WithEvents Label24 As Label
End Class
