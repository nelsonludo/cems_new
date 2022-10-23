<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addEquipmentPanelUserControl
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
        Me.addEquipmentPanel = New System.Windows.Forms.Panel()
        Me.postIdInput = New System.Windows.Forms.ComboBox()
        Me.equipmentStateInput = New System.Windows.Forms.ComboBox()
        Me.equipmentTypeInput = New System.Windows.Forms.ComboBox()
        Me.addEquipmentErrorMsg = New System.Windows.Forms.Label()
        Me.hallInput = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.addEquipmentCancelBtn = New System.Windows.Forms.Button()
        Me.addEquipmentValidationBtn = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.addEquipmentPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'addEquipmentPanel
        '
        Me.addEquipmentPanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.addEquipmentPanel.Controls.Add(Me.postIdInput)
        Me.addEquipmentPanel.Controls.Add(Me.equipmentStateInput)
        Me.addEquipmentPanel.Controls.Add(Me.equipmentTypeInput)
        Me.addEquipmentPanel.Controls.Add(Me.addEquipmentErrorMsg)
        Me.addEquipmentPanel.Controls.Add(Me.hallInput)
        Me.addEquipmentPanel.Controls.Add(Me.Label23)
        Me.addEquipmentPanel.Controls.Add(Me.Label25)
        Me.addEquipmentPanel.Controls.Add(Me.Label26)
        Me.addEquipmentPanel.Controls.Add(Me.addEquipmentCancelBtn)
        Me.addEquipmentPanel.Controls.Add(Me.addEquipmentValidationBtn)
        Me.addEquipmentPanel.Controls.Add(Me.Label27)
        Me.addEquipmentPanel.Location = New System.Drawing.Point(0, 0)
        Me.addEquipmentPanel.Name = "addEquipmentPanel"
        Me.addEquipmentPanel.Size = New System.Drawing.Size(634, 281)
        Me.addEquipmentPanel.TabIndex = 60
        Me.addEquipmentPanel.Visible = False
        '
        'postIdInput
        '
        Me.postIdInput.FormattingEnabled = True
        Me.postIdInput.Location = New System.Drawing.Point(269, 89)
        Me.postIdInput.Name = "postIdInput"
        Me.postIdInput.Size = New System.Drawing.Size(180, 21)
        Me.postIdInput.TabIndex = 61
        '
        'equipmentStateInput
        '
        Me.equipmentStateInput.FormattingEnabled = True
        Me.equipmentStateInput.Items.AddRange(New Object() {"Good", "Bad", "In reparation"})
        Me.equipmentStateInput.Location = New System.Drawing.Point(269, 60)
        Me.equipmentStateInput.Name = "equipmentStateInput"
        Me.equipmentStateInput.Size = New System.Drawing.Size(180, 21)
        Me.equipmentStateInput.TabIndex = 60
        '
        'equipmentTypeInput
        '
        Me.equipmentTypeInput.FormattingEnabled = True
        Me.equipmentTypeInput.Items.AddRange(New Object() {"IP_Phone", "Monitor", "CPU"})
        Me.equipmentTypeInput.Location = New System.Drawing.Point(269, 31)
        Me.equipmentTypeInput.Name = "equipmentTypeInput"
        Me.equipmentTypeInput.Size = New System.Drawing.Size(180, 21)
        Me.equipmentTypeInput.TabIndex = 59
        '
        'addEquipmentErrorMsg
        '
        Me.addEquipmentErrorMsg.AutoSize = True
        Me.addEquipmentErrorMsg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.addEquipmentErrorMsg.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEquipmentErrorMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addEquipmentErrorMsg.Location = New System.Drawing.Point(56, 236)
        Me.addEquipmentErrorMsg.Name = "addEquipmentErrorMsg"
        Me.addEquipmentErrorMsg.Size = New System.Drawing.Size(0, 16)
        Me.addEquipmentErrorMsg.TabIndex = 58
        Me.addEquipmentErrorMsg.Visible = False
        '
        'hallInput
        '
        Me.hallInput.FormattingEnabled = True
        Me.hallInput.Location = New System.Drawing.Point(269, 117)
        Me.hallInput.Name = "hallInput"
        Me.hallInput.Size = New System.Drawing.Size(180, 21)
        Me.hallInput.TabIndex = 47
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(53, 115)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(51, 20)
        Me.Label23.TabIndex = 52
        Me.Label23.Text = "hall:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(53, 87)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(81, 20)
        Me.Label25.TabIndex = 50
        Me.Label25.Text = "post id:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(53, 58)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(168, 20)
        Me.Label26.TabIndex = 48
        Me.Label26.Text = "equipment state:"
        '
        'addEquipmentCancelBtn
        '
        Me.addEquipmentCancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.addEquipmentCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.addEquipmentCancelBtn.FlatAppearance.BorderSize = 0
        Me.addEquipmentCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addEquipmentCancelBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.addEquipmentCancelBtn.Location = New System.Drawing.Point(370, 225)
        Me.addEquipmentCancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.addEquipmentCancelBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.addEquipmentCancelBtn.Name = "addEquipmentCancelBtn"
        Me.addEquipmentCancelBtn.Size = New System.Drawing.Size(79, 32)
        Me.addEquipmentCancelBtn.TabIndex = 44
        Me.addEquipmentCancelBtn.Text = "Cancel"
        Me.addEquipmentCancelBtn.UseVisualStyleBackColor = False
        '
        'addEquipmentValidationBtn
        '
        Me.addEquipmentValidationBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.addEquipmentValidationBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.addEquipmentValidationBtn.FlatAppearance.BorderSize = 0
        Me.addEquipmentValidationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addEquipmentValidationBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.addEquipmentValidationBtn.Location = New System.Drawing.Point(467, 225)
        Me.addEquipmentValidationBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.addEquipmentValidationBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.addEquipmentValidationBtn.Name = "addEquipmentValidationBtn"
        Me.addEquipmentValidationBtn.Size = New System.Drawing.Size(95, 32)
        Me.addEquipmentValidationBtn.TabIndex = 13
        Me.addEquipmentValidationBtn.Text = "Add"
        Me.addEquipmentValidationBtn.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(53, 29)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(160, 20)
        Me.Label27.TabIndex = 11
        Me.Label27.Text = "equipment type:"
        '
        'addEquipmentPanelUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.addEquipmentPanel)
        Me.Name = "addEquipmentPanelUserControl"
        Me.Size = New System.Drawing.Size(634, 281)
        Me.addEquipmentPanel.ResumeLayout(False)
        Me.addEquipmentPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addEquipmentPanel As Panel
    Friend WithEvents postIdInput As ComboBox
    Friend WithEvents equipmentStateInput As ComboBox
    Friend WithEvents equipmentTypeInput As ComboBox
    Friend WithEvents addEquipmentErrorMsg As Label
    Friend WithEvents hallInput As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents addEquipmentCancelBtn As Button
    Friend WithEvents addEquipmentValidationBtn As Button
    Friend WithEvents Label27 As Label
End Class
