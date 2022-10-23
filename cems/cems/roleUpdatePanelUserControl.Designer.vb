<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class roleUpdatePanelUserControl
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
        Me.roleUpdatePanel = New System.Windows.Forms.Panel()
        Me.roleUpdateCancelBtn = New System.Windows.Forms.Button()
        Me.titleNameInput = New System.Windows.Forms.TextBox()
        Me.roleUpdateValidationBtn = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.roleUpdatePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'roleUpdatePanel
        '
        Me.roleUpdatePanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.roleUpdatePanel.Controls.Add(Me.roleUpdateCancelBtn)
        Me.roleUpdatePanel.Controls.Add(Me.titleNameInput)
        Me.roleUpdatePanel.Controls.Add(Me.roleUpdateValidationBtn)
        Me.roleUpdatePanel.Controls.Add(Me.Label28)
        Me.roleUpdatePanel.Location = New System.Drawing.Point(0, 0)
        Me.roleUpdatePanel.Name = "roleUpdatePanel"
        Me.roleUpdatePanel.Size = New System.Drawing.Size(623, 267)
        Me.roleUpdatePanel.TabIndex = 47
        Me.roleUpdatePanel.Visible = False
        '
        'roleUpdateCancelBtn
        '
        Me.roleUpdateCancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.roleUpdateCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.roleUpdateCancelBtn.FlatAppearance.BorderSize = 0
        Me.roleUpdateCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roleUpdateCancelBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.roleUpdateCancelBtn.Location = New System.Drawing.Point(370, 225)
        Me.roleUpdateCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.roleUpdateCancelBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.roleUpdateCancelBtn.Name = "roleUpdateCancelBtn"
        Me.roleUpdateCancelBtn.Size = New System.Drawing.Size(79, 32)
        Me.roleUpdateCancelBtn.TabIndex = 44
        Me.roleUpdateCancelBtn.Text = "Cancel"
        Me.roleUpdateCancelBtn.UseVisualStyleBackColor = False
        '
        'titleNameInput
        '
        Me.titleNameInput.Location = New System.Drawing.Point(269, 91)
        Me.titleNameInput.Name = "titleNameInput"
        Me.titleNameInput.Size = New System.Drawing.Size(180, 20)
        Me.titleNameInput.TabIndex = 19
        '
        'roleUpdateValidationBtn
        '
        Me.roleUpdateValidationBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.roleUpdateValidationBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.roleUpdateValidationBtn.FlatAppearance.BorderSize = 0
        Me.roleUpdateValidationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roleUpdateValidationBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.roleUpdateValidationBtn.Location = New System.Drawing.Point(467, 225)
        Me.roleUpdateValidationBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.roleUpdateValidationBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.roleUpdateValidationBtn.Name = "roleUpdateValidationBtn"
        Me.roleUpdateValidationBtn.Size = New System.Drawing.Size(95, 32)
        Me.roleUpdateValidationBtn.TabIndex = 13
        Me.roleUpdateValidationBtn.Text = "Update"
        Me.roleUpdateValidationBtn.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(53, 90)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(120, 20)
        Me.Label28.TabIndex = 11
        Me.Label28.Text = "Role name :"
        '
        'roleUpdatePanelUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.roleUpdatePanel)
        Me.Name = "roleUpdatePanelUserControl"
        Me.Size = New System.Drawing.Size(624, 268)
        Me.roleUpdatePanel.ResumeLayout(False)
        Me.roleUpdatePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents roleUpdatePanel As Panel
    Friend WithEvents roleUpdateCancelBtn As Button
    Friend WithEvents titleNameInput As TextBox
    Friend WithEvents roleUpdateValidationBtn As Button
    Friend WithEvents Label28 As Label
End Class
