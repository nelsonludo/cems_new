<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminEquipmentPanelUserControl
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
        Me.adminEquipmentPanel = New System.Windows.Forms.Panel()
        Me.confirmMsgE = New System.Windows.Forms.Label()
        Me.hallSearchBoxE = New System.Windows.Forms.ComboBox()
        Me.searchErrorE = New System.Windows.Forms.Label()
        Me.printBtnE = New System.Windows.Forms.Button()
        Me.exportBtnE = New System.Windows.Forms.Button()
        Me.equipmentSearchBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EquipmentTitle = New System.Windows.Forms.Label()
        Me.statePanel = New System.Windows.Forms.Panel()
        Me.stateChangeBtn = New System.Windows.Forms.Button()
        Me.equipmentDeleteBtn = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.equipmentState = New System.Windows.Forms.ComboBox()
        Me.addEquipmentBtn = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.userSearchBoxE = New System.Windows.Forms.ComboBox()
        Me.adminEquipmentPanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'adminEquipmentPanel
        '
        Me.adminEquipmentPanel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.adminEquipmentPanel.Controls.Add(Me.confirmMsgE)
        Me.adminEquipmentPanel.Controls.Add(Me.hallSearchBoxE)
        Me.adminEquipmentPanel.Controls.Add(Me.searchErrorE)
        Me.adminEquipmentPanel.Controls.Add(Me.printBtnE)
        Me.adminEquipmentPanel.Controls.Add(Me.exportBtnE)
        Me.adminEquipmentPanel.Controls.Add(Me.equipmentSearchBox)
        Me.adminEquipmentPanel.Controls.Add(Me.DataGridView1)
        Me.adminEquipmentPanel.Controls.Add(Me.EquipmentTitle)
        Me.adminEquipmentPanel.Controls.Add(Me.statePanel)
        Me.adminEquipmentPanel.Controls.Add(Me.addEquipmentBtn)
        Me.adminEquipmentPanel.Controls.Add(Me.Label33)
        Me.adminEquipmentPanel.Controls.Add(Me.Label34)
        Me.adminEquipmentPanel.Controls.Add(Me.Label35)
        Me.adminEquipmentPanel.Controls.Add(Me.userSearchBoxE)
        Me.adminEquipmentPanel.Location = New System.Drawing.Point(0, 0)
        Me.adminEquipmentPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.adminEquipmentPanel.Name = "adminEquipmentPanel"
        Me.adminEquipmentPanel.Size = New System.Drawing.Size(725, 423)
        Me.adminEquipmentPanel.TabIndex = 35
        Me.adminEquipmentPanel.Visible = False
        '
        'confirmMsgE
        '
        Me.confirmMsgE.AutoSize = True
        Me.confirmMsgE.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.confirmMsgE.ForeColor = System.Drawing.Color.LimeGreen
        Me.confirmMsgE.Location = New System.Drawing.Point(517, 17)
        Me.confirmMsgE.Name = "confirmMsgE"
        Me.confirmMsgE.Size = New System.Drawing.Size(163, 16)
        Me.confirmMsgE.TabIndex = 41
        Me.confirmMsgE.Text = "Export successfull ✔"
        Me.confirmMsgE.Visible = False
        '
        'hallSearchBoxE
        '
        Me.hallSearchBoxE.FormattingEnabled = True
        Me.hallSearchBoxE.Location = New System.Drawing.Point(222, 62)
        Me.hallSearchBoxE.Name = "hallSearchBoxE"
        Me.hallSearchBoxE.Size = New System.Drawing.Size(80, 21)
        Me.hallSearchBoxE.TabIndex = 38
        '
        'searchErrorE
        '
        Me.searchErrorE.AutoSize = True
        Me.searchErrorE.Font = New System.Drawing.Font("MS Reference Sans Serif", 24.25!, System.Drawing.FontStyle.Bold)
        Me.searchErrorE.Location = New System.Drawing.Point(204, 199)
        Me.searchErrorE.Name = "searchErrorE"
        Me.searchErrorE.Size = New System.Drawing.Size(321, 40)
        Me.searchErrorE.TabIndex = 35
        Me.searchErrorE.Text = "No results found "
        Me.searchErrorE.Visible = False
        '
        'printBtnE
        '
        Me.printBtnE.Image = Global.cems.My.Resources.Resources.print__1_
        Me.printBtnE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.printBtnE.Location = New System.Drawing.Point(606, 59)
        Me.printBtnE.Name = "printBtnE"
        Me.printBtnE.Size = New System.Drawing.Size(75, 23)
        Me.printBtnE.TabIndex = 34
        Me.printBtnE.Text = "Print"
        Me.printBtnE.UseVisualStyleBackColor = True
        '
        'exportBtnE
        '
        Me.exportBtnE.Image = Global.cems.My.Resources.Resources.export
        Me.exportBtnE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exportBtnE.Location = New System.Drawing.Point(525, 59)
        Me.exportBtnE.Name = "exportBtnE"
        Me.exportBtnE.Size = New System.Drawing.Size(75, 23)
        Me.exportBtnE.TabIndex = 33
        Me.exportBtnE.Text = "Export"
        Me.exportBtnE.UseVisualStyleBackColor = True
        '
        'equipmentSearchBox
        '
        Me.equipmentSearchBox.ForeColor = System.Drawing.Color.DarkGray
        Me.equipmentSearchBox.Location = New System.Drawing.Point(142, 62)
        Me.equipmentSearchBox.Name = "equipmentSearchBox"
        Me.equipmentSearchBox.Size = New System.Drawing.Size(38, 20)
        Me.equipmentSearchBox.TabIndex = 32
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(50, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(499, 236)
        Me.DataGridView1.TabIndex = 31
        '
        'EquipmentTitle
        '
        Me.EquipmentTitle.AutoSize = True
        Me.EquipmentTitle.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipmentTitle.Location = New System.Drawing.Point(53, 26)
        Me.EquipmentTitle.Name = "EquipmentTitle"
        Me.EquipmentTitle.Size = New System.Drawing.Size(62, 24)
        Me.EquipmentTitle.TabIndex = 30
        Me.EquipmentTitle.Text = "CPUs"
        '
        'statePanel
        '
        Me.statePanel.Controls.Add(Me.stateChangeBtn)
        Me.statePanel.Controls.Add(Me.equipmentDeleteBtn)
        Me.statePanel.Controls.Add(Me.Label13)
        Me.statePanel.Controls.Add(Me.equipmentState)
        Me.statePanel.Location = New System.Drawing.Point(562, 111)
        Me.statePanel.Name = "statePanel"
        Me.statePanel.Size = New System.Drawing.Size(146, 128)
        Me.statePanel.TabIndex = 44
        Me.statePanel.Visible = False
        '
        'stateChangeBtn
        '
        Me.stateChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stateChangeBtn.Location = New System.Drawing.Point(14, 70)
        Me.stateChangeBtn.Name = "stateChangeBtn"
        Me.stateChangeBtn.Size = New System.Drawing.Size(121, 23)
        Me.stateChangeBtn.TabIndex = 67
        Me.stateChangeBtn.Text = "Change"
        Me.stateChangeBtn.UseVisualStyleBackColor = True
        '
        'equipmentDeleteBtn
        '
        Me.equipmentDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.equipmentDeleteBtn.Location = New System.Drawing.Point(14, 99)
        Me.equipmentDeleteBtn.Name = "equipmentDeleteBtn"
        Me.equipmentDeleteBtn.Size = New System.Drawing.Size(121, 23)
        Me.equipmentDeleteBtn.TabIndex = 66
        Me.equipmentDeleteBtn.Text = "Delete"
        Me.equipmentDeleteBtn.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(0, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 19)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "state:"
        '
        'equipmentState
        '
        Me.equipmentState.FormattingEnabled = True
        Me.equipmentState.Items.AddRange(New Object() {"Good", "Bad", "In reparation"})
        Me.equipmentState.Location = New System.Drawing.Point(66, 26)
        Me.equipmentState.Name = "equipmentState"
        Me.equipmentState.Size = New System.Drawing.Size(80, 21)
        Me.equipmentState.TabIndex = 42
        '
        'addEquipmentBtn
        '
        Me.addEquipmentBtn.Image = Global.cems.My.Resources.Resources.plus
        Me.addEquipmentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addEquipmentBtn.Location = New System.Drawing.Point(447, 59)
        Me.addEquipmentBtn.Name = "addEquipmentBtn"
        Me.addEquipmentBtn.Size = New System.Drawing.Size(75, 23)
        Me.addEquipmentBtn.TabIndex = 60
        Me.addEquipmentBtn.Text = "Add"
        Me.addEquipmentBtn.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(305, 62)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(54, 19)
        Me.Label33.TabIndex = 68
        Me.Label33.Text = "state:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(182, 64)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(40, 19)
        Me.Label34.TabIndex = 69
        Me.Label34.Text = "hall:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(70, 62)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(66, 19)
        Me.Label35.TabIndex = 67
        Me.Label35.Text = "post id:"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'userSearchBoxE
        '
        Me.userSearchBoxE.FormattingEnabled = True
        Me.userSearchBoxE.Location = New System.Drawing.Point(363, 61)
        Me.userSearchBoxE.Name = "userSearchBoxE"
        Me.userSearchBoxE.Size = New System.Drawing.Size(79, 21)
        Me.userSearchBoxE.TabIndex = 66
        '
        'adminEquipmentPanelUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.adminEquipmentPanel)
        Me.Name = "adminEquipmentPanelUserControl"
        Me.Size = New System.Drawing.Size(724, 424)
        Me.adminEquipmentPanel.ResumeLayout(False)
        Me.adminEquipmentPanel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statePanel.ResumeLayout(False)
        Me.statePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents adminEquipmentPanel As Panel
    Friend WithEvents confirmMsgE As Label
    Friend WithEvents hallSearchBoxE As ComboBox
    Friend WithEvents searchErrorE As Label
    Friend WithEvents printBtnE As Button
    Friend WithEvents exportBtnE As Button
    Friend WithEvents equipmentSearchBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EquipmentTitle As Label
    Friend WithEvents statePanel As Panel
    Friend WithEvents stateChangeBtn As Button
    Friend WithEvents equipmentDeleteBtn As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents equipmentState As ComboBox
    Friend WithEvents addEquipmentBtn As Button
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents userSearchBoxE As ComboBox
End Class
