<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminProfilePanelUserControl
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
        Me.adminProfilePanel = New System.Windows.Forms.Panel()
        Me.profileSubPanel1 = New System.Windows.Forms.Panel()
        Me.Profileupdatepanelusercontrol1 = New cems.profileupdatepanelusercontrol()
        Me.updateProfileShowBtn = New System.Windows.Forms.Button()
        Me.adminEmailProfile = New System.Windows.Forms.Label()
        Me.adminTitleProfile = New System.Windows.Forms.Label()
        Me.adminPhoneNumberProfile = New System.Windows.Forms.Label()
        Me.adminNameProfile = New System.Windows.Forms.Label()
        Me.adminEmailProfileLabel = New System.Windows.Forms.Label()
        Me.adminPhoneNumberProfileLabel = New System.Windows.Forms.Label()
        Me.adminTitleProfileLabel = New System.Windows.Forms.Label()
        Me.adminNameProfileLabel = New System.Windows.Forms.Label()
        Me.profileTitle = New System.Windows.Forms.Label()
        Me.adminProfilePanel.SuspendLayout()
        Me.profileSubPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'adminProfilePanel
        '
        Me.adminProfilePanel.Controls.Add(Me.profileSubPanel1)
        Me.adminProfilePanel.Controls.Add(Me.profileTitle)
        Me.adminProfilePanel.Location = New System.Drawing.Point(0, 0)
        Me.adminProfilePanel.Name = "adminProfilePanel"
        Me.adminProfilePanel.Size = New System.Drawing.Size(725, 423)
        Me.adminProfilePanel.TabIndex = 40
        '
        'profileSubPanel1
        '
        Me.profileSubPanel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.profileSubPanel1.Controls.Add(Me.Profileupdatepanelusercontrol1)
        Me.profileSubPanel1.Controls.Add(Me.updateProfileShowBtn)
        Me.profileSubPanel1.Controls.Add(Me.adminEmailProfile)
        Me.profileSubPanel1.Controls.Add(Me.adminTitleProfile)
        Me.profileSubPanel1.Controls.Add(Me.adminPhoneNumberProfile)
        Me.profileSubPanel1.Controls.Add(Me.adminNameProfile)
        Me.profileSubPanel1.Controls.Add(Me.adminEmailProfileLabel)
        Me.profileSubPanel1.Controls.Add(Me.adminPhoneNumberProfileLabel)
        Me.profileSubPanel1.Controls.Add(Me.adminTitleProfileLabel)
        Me.profileSubPanel1.Controls.Add(Me.adminNameProfileLabel)
        Me.profileSubPanel1.Location = New System.Drawing.Point(66, 93)
        Me.profileSubPanel1.Name = "profileSubPanel1"
        Me.profileSubPanel1.Size = New System.Drawing.Size(587, 252)
        Me.profileSubPanel1.TabIndex = 31
        '
        'Profileupdatepanelusercontrol1
        '
        Me.Profileupdatepanelusercontrol1.Location = New System.Drawing.Point(0, 0)
        Me.Profileupdatepanelusercontrol1.Name = "Profileupdatepanelusercontrol1"
        Me.Profileupdatepanelusercontrol1.Size = New System.Drawing.Size(586, 252)
        Me.Profileupdatepanelusercontrol1.TabIndex = 15
        '
        'updateProfileShowBtn
        '
        Me.updateProfileShowBtn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.updateProfileShowBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.updateProfileShowBtn.FlatAppearance.BorderSize = 0
        Me.updateProfileShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateProfileShowBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.updateProfileShowBtn.Location = New System.Drawing.Point(472, 205)
        Me.updateProfileShowBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.updateProfileShowBtn.MaximumSize = New System.Drawing.Size(156, 50)
        Me.updateProfileShowBtn.Name = "updateProfileShowBtn"
        Me.updateProfileShowBtn.Size = New System.Drawing.Size(95, 32)
        Me.updateProfileShowBtn.TabIndex = 13
        Me.updateProfileShowBtn.Text = "Update"
        Me.updateProfileShowBtn.UseVisualStyleBackColor = False
        '
        'adminEmailProfile
        '
        Me.adminEmailProfile.AutoSize = True
        Me.adminEmailProfile.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.adminEmailProfile.Location = New System.Drawing.Point(295, 118)
        Me.adminEmailProfile.Name = "adminEmailProfile"
        Me.adminEmailProfile.Size = New System.Drawing.Size(75, 19)
        Me.adminEmailProfile.TabIndex = 14
        Me.adminEmailProfile.Text = "******"
        '
        'adminTitleProfile
        '
        Me.adminTitleProfile.AutoSize = True
        Me.adminTitleProfile.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.adminTitleProfile.Location = New System.Drawing.Point(295, 190)
        Me.adminTitleProfile.Name = "adminTitleProfile"
        Me.adminTitleProfile.Size = New System.Drawing.Size(75, 19)
        Me.adminTitleProfile.TabIndex = 13
        Me.adminTitleProfile.Text = "******"
        '
        'adminPhoneNumberProfile
        '
        Me.adminPhoneNumberProfile.AutoSize = True
        Me.adminPhoneNumberProfile.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.adminPhoneNumberProfile.Location = New System.Drawing.Point(295, 153)
        Me.adminPhoneNumberProfile.Name = "adminPhoneNumberProfile"
        Me.adminPhoneNumberProfile.Size = New System.Drawing.Size(75, 19)
        Me.adminPhoneNumberProfile.TabIndex = 12
        Me.adminPhoneNumberProfile.Text = "******"
        '
        'adminNameProfile
        '
        Me.adminNameProfile.AutoSize = True
        Me.adminNameProfile.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.adminNameProfile.Location = New System.Drawing.Point(295, 84)
        Me.adminNameProfile.Name = "adminNameProfile"
        Me.adminNameProfile.Size = New System.Drawing.Size(75, 19)
        Me.adminNameProfile.TabIndex = 7
        Me.adminNameProfile.Text = "******"
        '
        'adminEmailProfileLabel
        '
        Me.adminEmailProfileLabel.AutoSize = True
        Me.adminEmailProfileLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminEmailProfileLabel.Location = New System.Drawing.Point(47, 117)
        Me.adminEmailProfileLabel.Name = "adminEmailProfileLabel"
        Me.adminEmailProfileLabel.Size = New System.Drawing.Size(122, 20)
        Me.adminEmailProfileLabel.TabIndex = 11
        Me.adminEmailProfileLabel.Text = "User email :"
        '
        'adminPhoneNumberProfileLabel
        '
        Me.adminPhoneNumberProfileLabel.AutoSize = True
        Me.adminPhoneNumberProfileLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminPhoneNumberProfileLabel.Location = New System.Drawing.Point(47, 152)
        Me.adminPhoneNumberProfileLabel.Name = "adminPhoneNumberProfileLabel"
        Me.adminPhoneNumberProfileLabel.Size = New System.Drawing.Size(232, 20)
        Me.adminPhoneNumberProfileLabel.TabIndex = 10
        Me.adminPhoneNumberProfileLabel.Text = "User telephone nunber :"
        '
        'adminTitleProfileLabel
        '
        Me.adminTitleProfileLabel.AutoSize = True
        Me.adminTitleProfileLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminTitleProfileLabel.Location = New System.Drawing.Point(47, 186)
        Me.adminTitleProfileLabel.Name = "adminTitleProfileLabel"
        Me.adminTitleProfileLabel.Size = New System.Drawing.Size(114, 20)
        Me.adminTitleProfileLabel.TabIndex = 9
        Me.adminTitleProfileLabel.Text = "User Title :"
        '
        'adminNameProfileLabel
        '
        Me.adminNameProfileLabel.AutoSize = True
        Me.adminNameProfileLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminNameProfileLabel.Location = New System.Drawing.Point(47, 83)
        Me.adminNameProfileLabel.Name = "adminNameProfileLabel"
        Me.adminNameProfileLabel.Size = New System.Drawing.Size(121, 20)
        Me.adminNameProfileLabel.TabIndex = 7
        Me.adminNameProfileLabel.Text = "User name :"
        '
        'profileTitle
        '
        Me.profileTitle.AutoSize = True
        Me.profileTitle.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.25!, System.Drawing.FontStyle.Bold)
        Me.profileTitle.Location = New System.Drawing.Point(61, 54)
        Me.profileTitle.Name = "profileTitle"
        Me.profileTitle.Size = New System.Drawing.Size(86, 26)
        Me.profileTitle.TabIndex = 30
        Me.profileTitle.Text = "Profile"
        '
        'adminProfilePanelUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.adminProfilePanel)
        Me.Name = "adminProfilePanelUserControl"
        Me.Size = New System.Drawing.Size(725, 424)
        Me.adminProfilePanel.ResumeLayout(False)
        Me.adminProfilePanel.PerformLayout()
        Me.profileSubPanel1.ResumeLayout(False)
        Me.profileSubPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents adminProfilePanel As Panel
    Friend WithEvents profileSubPanel1 As Panel
    Friend WithEvents updateProfileShowBtn As Button
    Friend WithEvents adminEmailProfile As Label
    Friend WithEvents adminTitleProfile As Label
    Friend WithEvents adminPhoneNumberProfile As Label
    Friend WithEvents adminNameProfile As Label
    Friend WithEvents adminEmailProfileLabel As Label
    Friend WithEvents adminPhoneNumberProfileLabel As Label
    Friend WithEvents adminTitleProfileLabel As Label
    Friend WithEvents adminNameProfileLabel As Label
    Friend WithEvents profileTitle As Label
    Friend WithEvents Profileupdatepanelusercontrol1 As profileupdatepanelusercontrol
End Class
