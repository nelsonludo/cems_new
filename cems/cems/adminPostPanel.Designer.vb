<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminPostPanel
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
        Me.adminHallsPanel = New System.Windows.Forms.Panel()
        Me.hallAddBtn = New System.Windows.Forms.Button()
        Me.confirmMsgH = New System.Windows.Forms.Label()
        Me.HallUpdateBtn = New System.Windows.Forms.Button()
        Me.hallSearchBoxH = New System.Windows.Forms.ComboBox()
        Me.searchErrorH = New System.Windows.Forms.Label()
        Me.PrintBtnH = New System.Windows.Forms.Button()
        Me.exportBtnH = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.HallDeleteBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.adminHallsPanel.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'adminHallsPanel
        '
        Me.adminHallsPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.adminHallsPanel.Controls.Add(Me.hallAddBtn)
        Me.adminHallsPanel.Controls.Add(Me.confirmMsgH)
        Me.adminHallsPanel.Controls.Add(Me.HallUpdateBtn)
        Me.adminHallsPanel.Controls.Add(Me.hallSearchBoxH)
        Me.adminHallsPanel.Controls.Add(Me.searchErrorH)
        Me.adminHallsPanel.Controls.Add(Me.PrintBtnH)
        Me.adminHallsPanel.Controls.Add(Me.exportBtnH)
        Me.adminHallsPanel.Controls.Add(Me.DataGridView3)
        Me.adminHallsPanel.Controls.Add(Me.Label21)
        Me.adminHallsPanel.Controls.Add(Me.HallDeleteBtn)
        Me.adminHallsPanel.Controls.Add(Me.Label4)
        Me.adminHallsPanel.Location = New System.Drawing.Point(0, 0)
        Me.adminHallsPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.adminHallsPanel.Name = "adminHallsPanel"
        Me.adminHallsPanel.Size = New System.Drawing.Size(725, 423)
        Me.adminHallsPanel.TabIndex = 41
        Me.adminHallsPanel.Visible = False
        '
        'hallAddBtn
        '
        Me.hallAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hallAddBtn.Image = Global.cems.My.Resources.Resources.plus
        Me.hallAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hallAddBtn.Location = New System.Drawing.Point(447, 59)
        Me.hallAddBtn.Name = "hallAddBtn"
        Me.hallAddBtn.Size = New System.Drawing.Size(75, 23)
        Me.hallAddBtn.TabIndex = 43
        Me.hallAddBtn.Text = "Add"
        Me.hallAddBtn.UseVisualStyleBackColor = True
        '
        'confirmMsgH
        '
        Me.confirmMsgH.AutoSize = True
        Me.confirmMsgH.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.confirmMsgH.ForeColor = System.Drawing.Color.LimeGreen
        Me.confirmMsgH.Location = New System.Drawing.Point(520, 17)
        Me.confirmMsgH.Name = "confirmMsgH"
        Me.confirmMsgH.Size = New System.Drawing.Size(163, 16)
        Me.confirmMsgH.TabIndex = 41
        Me.confirmMsgH.Text = "Export successfull ✔"
        Me.confirmMsgH.Visible = False
        '
        'HallUpdateBtn
        '
        Me.HallUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HallUpdateBtn.Location = New System.Drawing.Point(609, 108)
        Me.HallUpdateBtn.Name = "HallUpdateBtn"
        Me.HallUpdateBtn.Size = New System.Drawing.Size(75, 23)
        Me.HallUpdateBtn.TabIndex = 38
        Me.HallUpdateBtn.Text = "Update"
        Me.HallUpdateBtn.UseVisualStyleBackColor = True
        Me.HallUpdateBtn.Visible = False
        '
        'hallSearchBoxH
        '
        Me.hallSearchBoxH.FormattingEnabled = True
        Me.hallSearchBoxH.Location = New System.Drawing.Point(361, 59)
        Me.hallSearchBoxH.Name = "hallSearchBoxH"
        Me.hallSearchBoxH.Size = New System.Drawing.Size(80, 21)
        Me.hallSearchBoxH.TabIndex = 37
        '
        'searchErrorH
        '
        Me.searchErrorH.AutoSize = True
        Me.searchErrorH.Font = New System.Drawing.Font("MS Reference Sans Serif", 24.25!, System.Drawing.FontStyle.Bold)
        Me.searchErrorH.Location = New System.Drawing.Point(222, 225)
        Me.searchErrorH.Name = "searchErrorH"
        Me.searchErrorH.Size = New System.Drawing.Size(321, 40)
        Me.searchErrorH.TabIndex = 36
        Me.searchErrorH.Text = "No results found "
        Me.searchErrorH.Visible = False
        '
        'PrintBtnH
        '
        Me.PrintBtnH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintBtnH.Image = Global.cems.My.Resources.Resources.print__1_
        Me.PrintBtnH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintBtnH.Location = New System.Drawing.Point(609, 59)
        Me.PrintBtnH.Name = "PrintBtnH"
        Me.PrintBtnH.Size = New System.Drawing.Size(75, 23)
        Me.PrintBtnH.TabIndex = 33
        Me.PrintBtnH.Text = "Print"
        Me.PrintBtnH.UseVisualStyleBackColor = True
        '
        'exportBtnH
        '
        Me.exportBtnH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exportBtnH.Image = Global.cems.My.Resources.Resources.export
        Me.exportBtnH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exportBtnH.Location = New System.Drawing.Point(528, 59)
        Me.exportBtnH.Name = "exportBtnH"
        Me.exportBtnH.Size = New System.Drawing.Size(75, 23)
        Me.exportBtnH.TabIndex = 32
        Me.exportBtnH.Text = "Export"
        Me.exportBtnH.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(61, 108)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(523, 236)
        Me.DataGridView3.TabIndex = 30
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(61, 42)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 24)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "Halls"
        '
        'HallDeleteBtn
        '
        Me.HallDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HallDeleteBtn.Location = New System.Drawing.Point(609, 146)
        Me.HallDeleteBtn.Name = "HallDeleteBtn"
        Me.HallDeleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.HallDeleteBtn.TabIndex = 45
        Me.HallDeleteBtn.Text = "Delete"
        Me.HallDeleteBtn.UseVisualStyleBackColor = True
        Me.HallDeleteBtn.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(271, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(88, 19)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "select hall:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'adminPostPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.adminHallsPanel)
        Me.Name = "adminPostPanel"
        Me.Size = New System.Drawing.Size(724, 423)
        Me.adminHallsPanel.ResumeLayout(False)
        Me.adminHallsPanel.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents adminHallsPanel As Panel
    Friend WithEvents hallAddBtn As Button
    Friend WithEvents confirmMsgH As Label
    Friend WithEvents HallUpdateBtn As Button
    Friend WithEvents hallSearchBoxH As ComboBox
    Friend WithEvents searchErrorH As Label
    Friend WithEvents PrintBtnH As Button
    Friend WithEvents exportBtnH As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Label21 As Label
    Friend WithEvents HallDeleteBtn As Button
    Friend WithEvents Label4 As Label
End Class
