<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hallUpdatePanel
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
        Me.hallUpdateCancelBtn = New System.Windows.Forms.Button()
        Me.adminUpdateHallNameInput = New System.Windows.Forms.TextBox()
        Me.hallUpdateValidateBtn = New System.Windows.Forms.Button()
        Me.adminUpdateHallNameLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.hallUpdateCancelBtn)
        Me.Panel1.Controls.Add(Me.adminUpdateHallNameInput)
        Me.Panel1.Controls.Add(Me.hallUpdateValidateBtn)
        Me.Panel1.Controls.Add(Me.adminUpdateHallNameLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(623, 236)
        Me.Panel1.TabIndex = 47
        Me.Panel1.Visible = False
        '
        'hallUpdateCancelBtn
        '
        Me.hallUpdateCancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.hallUpdateCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.hallUpdateCancelBtn.FlatAppearance.BorderSize = 0
        Me.hallUpdateCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hallUpdateCancelBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.hallUpdateCancelBtn.Location = New System.Drawing.Point(370, 193)
        Me.hallUpdateCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.hallUpdateCancelBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.hallUpdateCancelBtn.Name = "hallUpdateCancelBtn"
        Me.hallUpdateCancelBtn.Size = New System.Drawing.Size(79, 32)
        Me.hallUpdateCancelBtn.TabIndex = 44
        Me.hallUpdateCancelBtn.Text = "Cancel"
        Me.hallUpdateCancelBtn.UseVisualStyleBackColor = False
        '
        'adminUpdateHallNameInput
        '
        Me.adminUpdateHallNameInput.Location = New System.Drawing.Point(233, 73)
        Me.adminUpdateHallNameInput.Name = "adminUpdateHallNameInput"
        Me.adminUpdateHallNameInput.Size = New System.Drawing.Size(180, 20)
        Me.adminUpdateHallNameInput.TabIndex = 19
        '
        'hallUpdateValidateBtn
        '
        Me.hallUpdateValidateBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.hallUpdateValidateBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.hallUpdateValidateBtn.FlatAppearance.BorderSize = 0
        Me.hallUpdateValidateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hallUpdateValidateBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.hallUpdateValidateBtn.Location = New System.Drawing.Point(467, 193)
        Me.hallUpdateValidateBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.hallUpdateValidateBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.hallUpdateValidateBtn.Name = "hallUpdateValidateBtn"
        Me.hallUpdateValidateBtn.Size = New System.Drawing.Size(95, 32)
        Me.hallUpdateValidateBtn.TabIndex = 13
        Me.hallUpdateValidateBtn.Text = "Update"
        Me.hallUpdateValidateBtn.UseVisualStyleBackColor = False
        '
        'adminUpdateHallNameLabel
        '
        Me.adminUpdateHallNameLabel.AutoSize = True
        Me.adminUpdateHallNameLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminUpdateHallNameLabel.Location = New System.Drawing.Point(53, 71)
        Me.adminUpdateHallNameLabel.Name = "adminUpdateHallNameLabel"
        Me.adminUpdateHallNameLabel.Size = New System.Drawing.Size(116, 20)
        Me.adminUpdateHallNameLabel.TabIndex = 11
        Me.adminUpdateHallNameLabel.Text = "Hall name :"
        '
        'hallUpdatePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "hallUpdatePanel"
        Me.Size = New System.Drawing.Size(622, 236)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents hallUpdateCancelBtn As Button
    Friend WithEvents adminUpdateHallNameInput As TextBox
    Friend WithEvents hallUpdateValidateBtn As Button
    Friend WithEvents adminUpdateHallNameLabel As Label
End Class
