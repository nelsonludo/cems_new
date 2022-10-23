<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminPostPanelUserControl
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
        Me.adminPostPanel = New System.Windows.Forms.Panel()
        Me.confirmMsgP = New System.Windows.Forms.Label()
        Me.hallSearchBoxP = New System.Windows.Forms.ComboBox()
        Me.searchErrorP = New System.Windows.Forms.Label()
        Me.printBtnP = New System.Windows.Forms.Button()
        Me.exportBtnP = New System.Windows.Forms.Button()
        Me.postSearchBox = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.postTitle = New System.Windows.Forms.Label()
        Me.postChangeStatePanel = New System.Windows.Forms.Panel()
        Me.postDeleteBtn = New System.Windows.Forms.Button()
        Me.postChangeBtn = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.postChangeStateInput = New System.Windows.Forms.ComboBox()
        Me.addPostBtn = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.stateSearchBoxP = New System.Windows.Forms.ComboBox()
        Me.AddPostPanelUserControl1 = New cems.addPostPanelUserControl()
        Me.adminPostPanel.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.postChangeStatePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'adminPostPanel
        '
        Me.adminPostPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.adminPostPanel.Controls.Add(Me.AddPostPanelUserControl1)
        Me.adminPostPanel.Controls.Add(Me.confirmMsgP)
        Me.adminPostPanel.Controls.Add(Me.hallSearchBoxP)
        Me.adminPostPanel.Controls.Add(Me.searchErrorP)
        Me.adminPostPanel.Controls.Add(Me.printBtnP)
        Me.adminPostPanel.Controls.Add(Me.exportBtnP)
        Me.adminPostPanel.Controls.Add(Me.postSearchBox)
        Me.adminPostPanel.Controls.Add(Me.DataGridView2)
        Me.adminPostPanel.Controls.Add(Me.postTitle)
        Me.adminPostPanel.Controls.Add(Me.postChangeStatePanel)
        Me.adminPostPanel.Controls.Add(Me.addPostBtn)
        Me.adminPostPanel.Controls.Add(Me.Label32)
        Me.adminPostPanel.Controls.Add(Me.Label30)
        Me.adminPostPanel.Controls.Add(Me.Label22)
        Me.adminPostPanel.Controls.Add(Me.stateSearchBoxP)
        Me.adminPostPanel.Location = New System.Drawing.Point(0, 0)
        Me.adminPostPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.adminPostPanel.Name = "adminPostPanel"
        Me.adminPostPanel.Size = New System.Drawing.Size(725, 423)
        Me.adminPostPanel.TabIndex = 40
        Me.adminPostPanel.Visible = False
        '
        'confirmMsgP
        '
        Me.confirmMsgP.AutoSize = True
        Me.confirmMsgP.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.confirmMsgP.ForeColor = System.Drawing.Color.LimeGreen
        Me.confirmMsgP.Location = New System.Drawing.Point(520, 17)
        Me.confirmMsgP.Name = "confirmMsgP"
        Me.confirmMsgP.Size = New System.Drawing.Size(163, 16)
        Me.confirmMsgP.TabIndex = 41
        Me.confirmMsgP.Text = "Export successfull ✔"
        Me.confirmMsgP.Visible = False
        '
        'hallSearchBoxP
        '
        Me.hallSearchBoxP.FormattingEnabled = True
        Me.hallSearchBoxP.Location = New System.Drawing.Point(255, 55)
        Me.hallSearchBoxP.Name = "hallSearchBoxP"
        Me.hallSearchBoxP.Size = New System.Drawing.Size(79, 21)
        Me.hallSearchBoxP.TabIndex = 37
        '
        'searchErrorP
        '
        Me.searchErrorP.AutoSize = True
        Me.searchErrorP.Font = New System.Drawing.Font("MS Reference Sans Serif", 24.25!, System.Drawing.FontStyle.Bold)
        Me.searchErrorP.Location = New System.Drawing.Point(222, 225)
        Me.searchErrorP.Name = "searchErrorP"
        Me.searchErrorP.Size = New System.Drawing.Size(321, 40)
        Me.searchErrorP.TabIndex = 36
        Me.searchErrorP.Text = "No results found "
        Me.searchErrorP.Visible = False
        '
        'printBtnP
        '
        Me.printBtnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printBtnP.Image = Global.cems.My.Resources.Resources.print__1_
        Me.printBtnP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.printBtnP.Location = New System.Drawing.Point(645, 55)
        Me.printBtnP.Name = "printBtnP"
        Me.printBtnP.Size = New System.Drawing.Size(75, 23)
        Me.printBtnP.TabIndex = 33
        Me.printBtnP.Text = "Print"
        Me.printBtnP.UseVisualStyleBackColor = True
        '
        'exportBtnP
        '
        Me.exportBtnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exportBtnP.Image = Global.cems.My.Resources.Resources.export
        Me.exportBtnP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exportBtnP.Location = New System.Drawing.Point(562, 55)
        Me.exportBtnP.Name = "exportBtnP"
        Me.exportBtnP.Size = New System.Drawing.Size(75, 23)
        Me.exportBtnP.TabIndex = 32
        Me.exportBtnP.Text = "Export"
        Me.exportBtnP.UseVisualStyleBackColor = True
        '
        'postSearchBox
        '
        Me.postSearchBox.ForeColor = System.Drawing.Color.DarkGray
        Me.postSearchBox.Location = New System.Drawing.Point(169, 55)
        Me.postSearchBox.Name = "postSearchBox"
        Me.postSearchBox.Size = New System.Drawing.Size(48, 20)
        Me.postSearchBox.TabIndex = 31
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(61, 108)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(495, 236)
        Me.DataGridView2.TabIndex = 30
        '
        'postTitle
        '
        Me.postTitle.AutoSize = True
        Me.postTitle.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.postTitle.Location = New System.Drawing.Point(60, 26)
        Me.postTitle.Name = "postTitle"
        Me.postTitle.Size = New System.Drawing.Size(65, 24)
        Me.postTitle.TabIndex = 29
        Me.postTitle.Text = "Posts"
        '
        'postChangeStatePanel
        '
        Me.postChangeStatePanel.Controls.Add(Me.postDeleteBtn)
        Me.postChangeStatePanel.Controls.Add(Me.postChangeBtn)
        Me.postChangeStatePanel.Controls.Add(Me.Label31)
        Me.postChangeStatePanel.Controls.Add(Me.postChangeStateInput)
        Me.postChangeStatePanel.Location = New System.Drawing.Point(572, 124)
        Me.postChangeStatePanel.Name = "postChangeStatePanel"
        Me.postChangeStatePanel.Size = New System.Drawing.Size(146, 128)
        Me.postChangeStatePanel.TabIndex = 61
        Me.postChangeStatePanel.Visible = False
        '
        'postDeleteBtn
        '
        Me.postDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.postDeleteBtn.Location = New System.Drawing.Point(12, 96)
        Me.postDeleteBtn.Name = "postDeleteBtn"
        Me.postDeleteBtn.Size = New System.Drawing.Size(121, 23)
        Me.postDeleteBtn.TabIndex = 65
        Me.postDeleteBtn.Text = "Delete"
        Me.postDeleteBtn.UseVisualStyleBackColor = True
        '
        'postChangeBtn
        '
        Me.postChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.postChangeBtn.Location = New System.Drawing.Point(12, 66)
        Me.postChangeBtn.Name = "postChangeBtn"
        Me.postChangeBtn.Size = New System.Drawing.Size(121, 23)
        Me.postChangeBtn.TabIndex = 64
        Me.postChangeBtn.Text = "Change"
        Me.postChangeBtn.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label31.Location = New System.Drawing.Point(0, 28)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(60, 19)
        Me.Label31.TabIndex = 38
        Me.Label31.Text = "state:"
        '
        'postChangeStateInput
        '
        Me.postChangeStateInput.FormattingEnabled = True
        Me.postChangeStateInput.Items.AddRange(New Object() {"Good", "Bad", "In reparation"})
        Me.postChangeStateInput.Location = New System.Drawing.Point(66, 26)
        Me.postChangeStateInput.Name = "postChangeStateInput"
        Me.postChangeStateInput.Size = New System.Drawing.Size(80, 21)
        Me.postChangeStateInput.TabIndex = 42
        '
        'addPostBtn
        '
        Me.addPostBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addPostBtn.Image = Global.cems.My.Resources.Resources.plus
        Me.addPostBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addPostBtn.Location = New System.Drawing.Point(482, 56)
        Me.addPostBtn.Name = "addPostBtn"
        Me.addPostBtn.Size = New System.Drawing.Size(75, 23)
        Me.addPostBtn.TabIndex = 63
        Me.addPostBtn.Text = "Add"
        Me.addPostBtn.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(335, 57)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(54, 19)
        Me.Label32.TabIndex = 65
        Me.Label32.Text = "state:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(214, 56)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(40, 19)
        Me.Label30.TabIndex = 65
        Me.Label30.Text = "hall:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(100, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(66, 19)
        Me.Label22.TabIndex = 64
        Me.Label22.Text = "post id:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'stateSearchBoxP
        '
        Me.stateSearchBoxP.FormattingEnabled = True
        Me.stateSearchBoxP.Location = New System.Drawing.Point(395, 56)
        Me.stateSearchBoxP.Name = "stateSearchBoxP"
        Me.stateSearchBoxP.Size = New System.Drawing.Size(79, 21)
        Me.stateSearchBoxP.TabIndex = 37
        '
        'AddPostPanelUserControl1
        '
        Me.AddPostPanelUserControl1.Location = New System.Drawing.Point(61, 108)
        Me.AddPostPanelUserControl1.Name = "AddPostPanelUserControl1"
        Me.AddPostPanelUserControl1.Size = New System.Drawing.Size(625, 268)
        Me.AddPostPanelUserControl1.TabIndex = 66
        '
        'adminPostPanelUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.adminPostPanel)
        Me.Name = "adminPostPanelUserControl"
        Me.Size = New System.Drawing.Size(725, 423)
        Me.adminPostPanel.ResumeLayout(False)
        Me.adminPostPanel.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.postChangeStatePanel.ResumeLayout(False)
        Me.postChangeStatePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents adminPostPanel As Panel
    Friend WithEvents confirmMsgP As Label
    Friend WithEvents hallSearchBoxP As ComboBox
    Friend WithEvents searchErrorP As Label
    Friend WithEvents printBtnP As Button
    Friend WithEvents exportBtnP As Button
    Friend WithEvents postSearchBox As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents postTitle As Label
    Friend WithEvents postChangeStatePanel As Panel
    Friend WithEvents postDeleteBtn As Button
    Friend WithEvents postChangeBtn As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents postChangeStateInput As ComboBox
    Friend WithEvents addPostBtn As Button
    Friend WithEvents Label32 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents stateSearchBoxP As ComboBox
    Friend WithEvents AddPostPanelUserControl1 As addPostPanelUserControl
End Class
