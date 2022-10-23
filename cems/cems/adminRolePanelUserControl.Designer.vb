<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminRolePanelUserControl
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
        Me.adminRolePanel = New System.Windows.Forms.Panel()
        Me.roleAddBtn = New System.Windows.Forms.Button()
        Me.confirmMsgR = New System.Windows.Forms.Label()
        Me.roleUpdateBtn = New System.Windows.Forms.Button()
        Me.searchErrorR = New System.Windows.Forms.Label()
        Me.PrintBtnR = New System.Windows.Forms.Button()
        Me.exportBtnR = New System.Windows.Forms.Button()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.Roles = New System.Windows.Forms.Label()
        Me.adminRolePanel.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'adminRolePanel
        '
        Me.adminRolePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.adminRolePanel.Controls.Add(Me.roleAddBtn)
        Me.adminRolePanel.Controls.Add(Me.confirmMsgR)
        Me.adminRolePanel.Controls.Add(Me.roleUpdateBtn)
        Me.adminRolePanel.Controls.Add(Me.searchErrorR)
        Me.adminRolePanel.Controls.Add(Me.PrintBtnR)
        Me.adminRolePanel.Controls.Add(Me.exportBtnR)
        Me.adminRolePanel.Controls.Add(Me.DataGridView5)
        Me.adminRolePanel.Controls.Add(Me.Roles)
        Me.adminRolePanel.Location = New System.Drawing.Point(0, 0)
        Me.adminRolePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.adminRolePanel.Name = "adminRolePanel"
        Me.adminRolePanel.Size = New System.Drawing.Size(726, 423)
        Me.adminRolePanel.TabIndex = 61
        Me.adminRolePanel.Visible = False
        '
        'roleAddBtn
        '
        Me.roleAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roleAddBtn.Image = Global.cems.My.Resources.Resources.plus
        Me.roleAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.roleAddBtn.Location = New System.Drawing.Point(447, 59)
        Me.roleAddBtn.Name = "roleAddBtn"
        Me.roleAddBtn.Size = New System.Drawing.Size(75, 23)
        Me.roleAddBtn.TabIndex = 43
        Me.roleAddBtn.Text = "Add"
        Me.roleAddBtn.UseVisualStyleBackColor = True
        '
        'confirmMsgR
        '
        Me.confirmMsgR.AutoSize = True
        Me.confirmMsgR.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.confirmMsgR.ForeColor = System.Drawing.Color.LimeGreen
        Me.confirmMsgR.Location = New System.Drawing.Point(520, 17)
        Me.confirmMsgR.Name = "confirmMsgR"
        Me.confirmMsgR.Size = New System.Drawing.Size(163, 16)
        Me.confirmMsgR.TabIndex = 41
        Me.confirmMsgR.Text = "Export successfull ✔"
        Me.confirmMsgR.Visible = False
        '
        'roleUpdateBtn
        '
        Me.roleUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roleUpdateBtn.Location = New System.Drawing.Point(609, 108)
        Me.roleUpdateBtn.Name = "roleUpdateBtn"
        Me.roleUpdateBtn.Size = New System.Drawing.Size(75, 23)
        Me.roleUpdateBtn.TabIndex = 38
        Me.roleUpdateBtn.Text = "Update"
        Me.roleUpdateBtn.UseVisualStyleBackColor = True
        Me.roleUpdateBtn.Visible = False
        '
        'searchErrorR
        '
        Me.searchErrorR.AutoSize = True
        Me.searchErrorR.Font = New System.Drawing.Font("MS Reference Sans Serif", 24.25!, System.Drawing.FontStyle.Bold)
        Me.searchErrorR.Location = New System.Drawing.Point(222, 225)
        Me.searchErrorR.Name = "searchErrorR"
        Me.searchErrorR.Size = New System.Drawing.Size(321, 40)
        Me.searchErrorR.TabIndex = 36
        Me.searchErrorR.Text = "No results found "
        Me.searchErrorR.Visible = False
        '
        'PrintBtnR
        '
        Me.PrintBtnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintBtnR.Image = Global.cems.My.Resources.Resources.print__1_
        Me.PrintBtnR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintBtnR.Location = New System.Drawing.Point(609, 59)
        Me.PrintBtnR.Name = "PrintBtnR"
        Me.PrintBtnR.Size = New System.Drawing.Size(75, 23)
        Me.PrintBtnR.TabIndex = 33
        Me.PrintBtnR.Text = "Print"
        Me.PrintBtnR.UseVisualStyleBackColor = True
        '
        'exportBtnR
        '
        Me.exportBtnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exportBtnR.Image = Global.cems.My.Resources.Resources.export
        Me.exportBtnR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exportBtnR.Location = New System.Drawing.Point(528, 59)
        Me.exportBtnR.Name = "exportBtnR"
        Me.exportBtnR.Size = New System.Drawing.Size(75, 23)
        Me.exportBtnR.TabIndex = 32
        Me.exportBtnR.Text = "Export"
        Me.exportBtnR.UseVisualStyleBackColor = True
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.AllowUserToDeleteRows = False
        Me.DataGridView5.AllowUserToResizeColumns = False
        Me.DataGridView5.AllowUserToResizeRows = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(61, 108)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView5.Size = New System.Drawing.Size(523, 236)
        Me.DataGridView5.TabIndex = 30
        '
        'Roles
        '
        Me.Roles.AutoSize = True
        Me.Roles.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roles.Location = New System.Drawing.Point(61, 42)
        Me.Roles.Name = "Roles"
        Me.Roles.Size = New System.Drawing.Size(67, 24)
        Me.Roles.TabIndex = 29
        Me.Roles.Text = "Roles"
        '
        'adminRolePanelUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.adminRolePanel)
        Me.Name = "adminRolePanelUserControl"
        Me.Size = New System.Drawing.Size(725, 422)
        Me.adminRolePanel.ResumeLayout(False)
        Me.adminRolePanel.PerformLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents adminRolePanel As Panel
    Friend WithEvents roleAddBtn As Button
    Friend WithEvents confirmMsgR As Label
    Friend WithEvents roleUpdateBtn As Button
    Friend WithEvents searchErrorR As Label
    Friend WithEvents PrintBtnR As Button
    Friend WithEvents exportBtnR As Button
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents Roles As Label
End Class
