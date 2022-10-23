<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminUserPanelUserControl
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
        Me.adminUsersPanel = New System.Windows.Forms.Panel()
        Me.userSearchBox = New System.Windows.Forms.TextBox()
        Me.userAddBtn = New System.Windows.Forms.Button()
        Me.confirmMsgU = New System.Windows.Forms.Label()
        Me.userUpdateBtn = New System.Windows.Forms.Button()
        Me.searchErrorU = New System.Windows.Forms.Label()
        Me.PrintBtnU = New System.Windows.Forms.Button()
        Me.exportBtnU = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.userDeleteBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.adminUsersPanel.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'adminUsersPanel
        '
        Me.adminUsersPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.adminUsersPanel.Controls.Add(Me.userSearchBox)
        Me.adminUsersPanel.Controls.Add(Me.userAddBtn)
        Me.adminUsersPanel.Controls.Add(Me.confirmMsgU)
        Me.adminUsersPanel.Controls.Add(Me.userUpdateBtn)
        Me.adminUsersPanel.Controls.Add(Me.searchErrorU)
        Me.adminUsersPanel.Controls.Add(Me.PrintBtnU)
        Me.adminUsersPanel.Controls.Add(Me.exportBtnU)
        Me.adminUsersPanel.Controls.Add(Me.DataGridView4)
        Me.adminUsersPanel.Controls.Add(Me.Label10)
        Me.adminUsersPanel.Controls.Add(Me.userDeleteBtn)
        Me.adminUsersPanel.Controls.Add(Me.Label3)
        Me.adminUsersPanel.Location = New System.Drawing.Point(0, 0)
        Me.adminUsersPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.adminUsersPanel.Name = "adminUsersPanel"
        Me.adminUsersPanel.Size = New System.Drawing.Size(726, 421)
        Me.adminUsersPanel.TabIndex = 48
        Me.adminUsersPanel.Visible = False
        '
        'userSearchBox
        '
        Me.userSearchBox.Location = New System.Drawing.Point(330, 62)
        Me.userSearchBox.Name = "userSearchBox"
        Me.userSearchBox.Size = New System.Drawing.Size(112, 20)
        Me.userSearchBox.TabIndex = 59
        '
        'userAddBtn
        '
        Me.userAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userAddBtn.Location = New System.Drawing.Point(447, 59)
        Me.userAddBtn.Name = "userAddBtn"
        Me.userAddBtn.Size = New System.Drawing.Size(75, 23)
        Me.userAddBtn.TabIndex = 43
        Me.userAddBtn.Text = "Add"
        Me.userAddBtn.UseVisualStyleBackColor = True
        '
        'confirmMsgU
        '
        Me.confirmMsgU.AutoSize = True
        Me.confirmMsgU.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.confirmMsgU.ForeColor = System.Drawing.Color.LimeGreen
        Me.confirmMsgU.Location = New System.Drawing.Point(520, 17)
        Me.confirmMsgU.Name = "confirmMsgU"
        Me.confirmMsgU.Size = New System.Drawing.Size(163, 16)
        Me.confirmMsgU.TabIndex = 41
        Me.confirmMsgU.Text = "Export successfull ✔"
        Me.confirmMsgU.Visible = False
        '
        'userUpdateBtn
        '
        Me.userUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userUpdateBtn.Location = New System.Drawing.Point(609, 108)
        Me.userUpdateBtn.Name = "userUpdateBtn"
        Me.userUpdateBtn.Size = New System.Drawing.Size(75, 23)
        Me.userUpdateBtn.TabIndex = 38
        Me.userUpdateBtn.Text = "Update"
        Me.userUpdateBtn.UseVisualStyleBackColor = True
        Me.userUpdateBtn.Visible = False
        '
        'searchErrorU
        '
        Me.searchErrorU.AutoSize = True
        Me.searchErrorU.Font = New System.Drawing.Font("MS Reference Sans Serif", 24.25!, System.Drawing.FontStyle.Bold)
        Me.searchErrorU.Location = New System.Drawing.Point(222, 225)
        Me.searchErrorU.Name = "searchErrorU"
        Me.searchErrorU.Size = New System.Drawing.Size(321, 40)
        Me.searchErrorU.TabIndex = 36
        Me.searchErrorU.Text = "No results found "
        Me.searchErrorU.Visible = False
        '
        'PrintBtnU
        '
        Me.PrintBtnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintBtnU.Image = Global.cems.My.Resources.Resources.print__1_
        Me.PrintBtnU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintBtnU.Location = New System.Drawing.Point(609, 59)
        Me.PrintBtnU.Name = "PrintBtnU"
        Me.PrintBtnU.Size = New System.Drawing.Size(75, 23)
        Me.PrintBtnU.TabIndex = 33
        Me.PrintBtnU.Text = "Print"
        Me.PrintBtnU.UseVisualStyleBackColor = True
        '
        'exportBtnU
        '
        Me.exportBtnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exportBtnU.Image = Global.cems.My.Resources.Resources.export
        Me.exportBtnU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exportBtnU.Location = New System.Drawing.Point(528, 59)
        Me.exportBtnU.Name = "exportBtnU"
        Me.exportBtnU.Size = New System.Drawing.Size(75, 23)
        Me.exportBtnU.TabIndex = 32
        Me.exportBtnU.Text = "Export"
        Me.exportBtnU.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(61, 108)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView4.Size = New System.Drawing.Size(523, 236)
        Me.DataGridView4.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(61, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 24)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Users"
        '
        'userDeleteBtn
        '
        Me.userDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userDeleteBtn.Location = New System.Drawing.Point(609, 146)
        Me.userDeleteBtn.Name = "userDeleteBtn"
        Me.userDeleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.userDeleteBtn.TabIndex = 45
        Me.userDeleteBtn.Text = "Delete"
        Me.userDeleteBtn.UseVisualStyleBackColor = True
        Me.userDeleteBtn.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(195, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(134, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "enter username:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'adminUserPanelUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.adminUsersPanel)
        Me.Name = "adminUserPanelUserControl"
        Me.Size = New System.Drawing.Size(726, 421)
        Me.adminUsersPanel.ResumeLayout(False)
        Me.adminUsersPanel.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents adminUsersPanel As Panel
    Friend WithEvents userSearchBox As TextBox
    Friend WithEvents userAddBtn As Button
    Friend WithEvents confirmMsgU As Label
    Friend WithEvents userUpdateBtn As Button
    Friend WithEvents searchErrorU As Label
    Friend WithEvents PrintBtnU As Button
    Friend WithEvents exportBtnU As Button
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents userDeleteBtn As Button
    Friend WithEvents Label3 As Label
End Class
