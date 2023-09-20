<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addPostPanel
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
        Me.postPostIdInput = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.postStateInput = New System.Windows.Forms.ComboBox()
        Me.addPostErrorMsg = New System.Windows.Forms.Label()
        Me.postHallInput = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.addPostCancelBtn = New System.Windows.Forms.Button()
        Me.addPostValidationBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.postPostIdInput)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.postStateInput)
        Me.Panel1.Controls.Add(Me.addPostErrorMsg)
        Me.Panel1.Controls.Add(Me.postHallInput)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.addPostCancelBtn)
        Me.Panel1.Controls.Add(Me.addPostValidationBtn)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 267)
        Me.Panel1.TabIndex = 63
        Me.Panel1.Visible = False
        '
        'postPostIdInput
        '
        Me.postPostIdInput.Location = New System.Drawing.Point(270, 35)
        Me.postPostIdInput.Name = "postPostIdInput"
        Me.postPostIdInput.Size = New System.Drawing.Size(179, 20)
        Me.postPostIdInput.TabIndex = 62
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(54, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 20)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "Post ID:"
        '
        'postStateInput
        '
        Me.postStateInput.FormattingEnabled = True
        Me.postStateInput.Items.AddRange(New Object() {"Good", "Bad", "In reparation"})
        Me.postStateInput.Location = New System.Drawing.Point(270, 74)
        Me.postStateInput.Name = "postStateInput"
        Me.postStateInput.Size = New System.Drawing.Size(180, 21)
        Me.postStateInput.TabIndex = 60
        '
        'addPostErrorMsg
        '
        Me.addPostErrorMsg.AutoSize = True
        Me.addPostErrorMsg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.addPostErrorMsg.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addPostErrorMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addPostErrorMsg.Location = New System.Drawing.Point(56, 236)
        Me.addPostErrorMsg.Name = "addPostErrorMsg"
        Me.addPostErrorMsg.Size = New System.Drawing.Size(0, 16)
        Me.addPostErrorMsg.TabIndex = 58
        Me.addPostErrorMsg.Visible = False
        '
        'postHallInput
        '
        Me.postHallInput.FormattingEnabled = True
        Me.postHallInput.Location = New System.Drawing.Point(270, 117)
        Me.postHallInput.Name = "postHallInput"
        Me.postHallInput.Size = New System.Drawing.Size(180, 21)
        Me.postHallInput.TabIndex = 47
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(54, 115)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 20)
        Me.Label20.TabIndex = 52
        Me.Label20.Text = "hall:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(54, 72)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(112, 20)
        Me.Label29.TabIndex = 48
        Me.Label29.Text = "Post state:"
        '
        'addPostCancelBtn
        '
        Me.addPostCancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.addPostCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.addPostCancelBtn.FlatAppearance.BorderSize = 0
        Me.addPostCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addPostCancelBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.addPostCancelBtn.Location = New System.Drawing.Point(370, 225)
        Me.addPostCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.addPostCancelBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.addPostCancelBtn.Name = "addPostCancelBtn"
        Me.addPostCancelBtn.Size = New System.Drawing.Size(79, 32)
        Me.addPostCancelBtn.TabIndex = 44
        Me.addPostCancelBtn.Text = "Cancel"
        Me.addPostCancelBtn.UseVisualStyleBackColor = False
        '
        'addPostValidationBtn
        '
        Me.addPostValidationBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.addPostValidationBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.addPostValidationBtn.FlatAppearance.BorderSize = 0
        Me.addPostValidationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addPostValidationBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.addPostValidationBtn.Location = New System.Drawing.Point(467, 225)
        Me.addPostValidationBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.addPostValidationBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.addPostValidationBtn.Name = "addPostValidationBtn"
        Me.addPostValidationBtn.Size = New System.Drawing.Size(95, 32)
        Me.addPostValidationBtn.TabIndex = 13
        Me.addPostValidationBtn.Text = "Add"
        Me.addPostValidationBtn.UseVisualStyleBackColor = False
        '
        'addPostPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "addPostPanel"
        Me.Size = New System.Drawing.Size(624, 267)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents postPostIdInput As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents postStateInput As ComboBox
    Friend WithEvents addPostErrorMsg As Label
    Friend WithEvents postHallInput As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents addPostCancelBtn As Button
    Friend WithEvents addPostValidationBtn As Button
End Class
