<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hallAddPanelUserControl
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
        Me.hallAddpanel = New System.Windows.Forms.Panel()
        Me.addHallErrorMsg = New System.Windows.Forms.Label()
        Me.HallAddCancelBtn = New System.Windows.Forms.Button()
        Me.adminAddHallNameInput = New System.Windows.Forms.TextBox()
        Me.HallAddValidateBtn = New System.Windows.Forms.Button()
        Me.adminAddHallNameLabel = New System.Windows.Forms.Label()
        Me.hallAddpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'hallAddpanel
        '
        Me.hallAddpanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.hallAddpanel.Controls.Add(Me.addHallErrorMsg)
        Me.hallAddpanel.Controls.Add(Me.HallAddCancelBtn)
        Me.hallAddpanel.Controls.Add(Me.adminAddHallNameInput)
        Me.hallAddpanel.Controls.Add(Me.HallAddValidateBtn)
        Me.hallAddpanel.Controls.Add(Me.adminAddHallNameLabel)
        Me.hallAddpanel.Location = New System.Drawing.Point(0, 0)
        Me.hallAddpanel.Name = "hallAddpanel"
        Me.hallAddpanel.Size = New System.Drawing.Size(623, 236)
        Me.hallAddpanel.TabIndex = 48
        Me.hallAddpanel.Visible = False
        '
        'addHallErrorMsg
        '
        Me.addHallErrorMsg.AutoSize = True
        Me.addHallErrorMsg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.addHallErrorMsg.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addHallErrorMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addHallErrorMsg.Location = New System.Drawing.Point(54, 204)
        Me.addHallErrorMsg.Name = "addHallErrorMsg"
        Me.addHallErrorMsg.Size = New System.Drawing.Size(0, 16)
        Me.addHallErrorMsg.TabIndex = 61
        Me.addHallErrorMsg.Visible = False
        '
        'HallAddCancelBtn
        '
        Me.HallAddCancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.HallAddCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.HallAddCancelBtn.FlatAppearance.BorderSize = 0
        Me.HallAddCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HallAddCancelBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.HallAddCancelBtn.Location = New System.Drawing.Point(370, 193)
        Me.HallAddCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.HallAddCancelBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.HallAddCancelBtn.Name = "HallAddCancelBtn"
        Me.HallAddCancelBtn.Size = New System.Drawing.Size(79, 32)
        Me.HallAddCancelBtn.TabIndex = 44
        Me.HallAddCancelBtn.Text = "Cancel"
        Me.HallAddCancelBtn.UseVisualStyleBackColor = False
        '
        'adminAddHallNameInput
        '
        Me.adminAddHallNameInput.Location = New System.Drawing.Point(233, 73)
        Me.adminAddHallNameInput.Name = "adminAddHallNameInput"
        Me.adminAddHallNameInput.Size = New System.Drawing.Size(180, 20)
        Me.adminAddHallNameInput.TabIndex = 19
        '
        'HallAddValidateBtn
        '
        Me.HallAddValidateBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.HallAddValidateBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.HallAddValidateBtn.FlatAppearance.BorderSize = 0
        Me.HallAddValidateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HallAddValidateBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.HallAddValidateBtn.Location = New System.Drawing.Point(467, 193)
        Me.HallAddValidateBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.HallAddValidateBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.HallAddValidateBtn.Name = "HallAddValidateBtn"
        Me.HallAddValidateBtn.Size = New System.Drawing.Size(95, 32)
        Me.HallAddValidateBtn.TabIndex = 13
        Me.HallAddValidateBtn.Text = "Add"
        Me.HallAddValidateBtn.UseVisualStyleBackColor = False
        '
        'adminAddHallNameLabel
        '
        Me.adminAddHallNameLabel.AutoSize = True
        Me.adminAddHallNameLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminAddHallNameLabel.Location = New System.Drawing.Point(53, 71)
        Me.adminAddHallNameLabel.Name = "adminAddHallNameLabel"
        Me.adminAddHallNameLabel.Size = New System.Drawing.Size(116, 20)
        Me.adminAddHallNameLabel.TabIndex = 11
        Me.adminAddHallNameLabel.Text = "Hall name :"
        '
        'hallAddPanelUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.hallAddpanel)
        Me.Name = "hallAddPanelUserControl"
        Me.Size = New System.Drawing.Size(624, 237)
        Me.hallAddpanel.ResumeLayout(False)
        Me.hallAddpanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents hallAddpanel As Panel
    Friend WithEvents addHallErrorMsg As Label
    Friend WithEvents HallAddCancelBtn As Button
    Friend WithEvents adminAddHallNameInput As TextBox
    Friend WithEvents HallAddValidateBtn As Button
    Friend WithEvents adminAddHallNameLabel As Label
End Class
