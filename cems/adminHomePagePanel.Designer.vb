<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminHomePagePanel
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.userNumber = New System.Windows.Forms.Label()
        Me.usersBtn2 = New System.Windows.Forms.Button()
        Me.nonActiveMonitorNumber = New System.Windows.Forms.Label()
        Me.activeMonitorNumber = New System.Windows.Forms.Label()
        Me.nonActiveIPNumber = New System.Windows.Forms.Label()
        Me.activeIPNumber = New System.Windows.Forms.Label()
        Me.nonActiveCPUNumber = New System.Windows.Forms.Label()
        Me.activeCPUNumber = New System.Windows.Forms.Label()
        Me.monitorsBtn2 = New System.Windows.Forms.Button()
        Me.IPsBtn2 = New System.Windows.Forms.Button()
        Me.CPUsBtn2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.userNumber)
        Me.Panel1.Controls.Add(Me.usersBtn2)
        Me.Panel1.Controls.Add(Me.nonActiveMonitorNumber)
        Me.Panel1.Controls.Add(Me.activeMonitorNumber)
        Me.Panel1.Controls.Add(Me.nonActiveIPNumber)
        Me.Panel1.Controls.Add(Me.activeIPNumber)
        Me.Panel1.Controls.Add(Me.nonActiveCPUNumber)
        Me.Panel1.Controls.Add(Me.activeCPUNumber)
        Me.Panel1.Controls.Add(Me.monitorsBtn2)
        Me.Panel1.Controls.Add(Me.IPsBtn2)
        Me.Panel1.Controls.Add(Me.CPUsBtn2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(725, 421)
        Me.Panel1.TabIndex = 8
        '
        'userNumber
        '
        Me.userNumber.AutoSize = True
        Me.userNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.userNumber.Location = New System.Drawing.Point(664, 163)
        Me.userNumber.Name = "userNumber"
        Me.userNumber.Size = New System.Drawing.Size(31, 13)
        Me.userNumber.TabIndex = 35
        Me.userNumber.Text = "0000"
        '
        'usersBtn2
        '
        Me.usersBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.usersBtn2.Image = Global.cems.My.Resources.Resources.user1
        Me.usersBtn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.usersBtn2.Location = New System.Drawing.Point(538, 95)
        Me.usersBtn2.Name = "usersBtn2"
        Me.usersBtn2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.usersBtn2.Size = New System.Drawing.Size(170, 103)
        Me.usersBtn2.TabIndex = 33
        Me.usersBtn2.Text = "Users"
        Me.usersBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.usersBtn2.UseVisualStyleBackColor = True
        '
        'nonActiveMonitorNumber
        '
        Me.nonActiveMonitorNumber.AutoSize = True
        Me.nonActiveMonitorNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nonActiveMonitorNumber.Location = New System.Drawing.Point(488, 163)
        Me.nonActiveMonitorNumber.Name = "nonActiveMonitorNumber"
        Me.nonActiveMonitorNumber.Size = New System.Drawing.Size(31, 13)
        Me.nonActiveMonitorNumber.TabIndex = 32
        Me.nonActiveMonitorNumber.Text = "0000"
        '
        'activeMonitorNumber
        '
        Me.activeMonitorNumber.AutoSize = True
        Me.activeMonitorNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.activeMonitorNumber.Location = New System.Drawing.Point(443, 163)
        Me.activeMonitorNumber.Name = "activeMonitorNumber"
        Me.activeMonitorNumber.Size = New System.Drawing.Size(31, 13)
        Me.activeMonitorNumber.TabIndex = 31
        Me.activeMonitorNumber.Text = "0000"
        '
        'nonActiveIPNumber
        '
        Me.nonActiveIPNumber.AutoSize = True
        Me.nonActiveIPNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nonActiveIPNumber.Location = New System.Drawing.Point(304, 163)
        Me.nonActiveIPNumber.Name = "nonActiveIPNumber"
        Me.nonActiveIPNumber.Size = New System.Drawing.Size(31, 13)
        Me.nonActiveIPNumber.TabIndex = 30
        Me.nonActiveIPNumber.Text = "0000"
        '
        'activeIPNumber
        '
        Me.activeIPNumber.AutoSize = True
        Me.activeIPNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.activeIPNumber.Location = New System.Drawing.Point(267, 163)
        Me.activeIPNumber.Name = "activeIPNumber"
        Me.activeIPNumber.Size = New System.Drawing.Size(31, 13)
        Me.activeIPNumber.TabIndex = 29
        Me.activeIPNumber.Text = "0000"
        '
        'nonActiveCPUNumber
        '
        Me.nonActiveCPUNumber.AutoSize = True
        Me.nonActiveCPUNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nonActiveCPUNumber.Location = New System.Drawing.Point(135, 163)
        Me.nonActiveCPUNumber.Name = "nonActiveCPUNumber"
        Me.nonActiveCPUNumber.Size = New System.Drawing.Size(31, 13)
        Me.nonActiveCPUNumber.TabIndex = 28
        Me.nonActiveCPUNumber.Text = "0000"
        '
        'activeCPUNumber
        '
        Me.activeCPUNumber.AutoSize = True
        Me.activeCPUNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.activeCPUNumber.Location = New System.Drawing.Point(90, 163)
        Me.activeCPUNumber.Name = "activeCPUNumber"
        Me.activeCPUNumber.Size = New System.Drawing.Size(31, 13)
        Me.activeCPUNumber.TabIndex = 27
        Me.activeCPUNumber.Text = "0000"
        '
        'monitorsBtn2
        '
        Me.monitorsBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.monitorsBtn2.Image = Global.cems.My.Resources.Resources.computer
        Me.monitorsBtn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.monitorsBtn2.Location = New System.Drawing.Point(362, 95)
        Me.monitorsBtn2.Name = "monitorsBtn2"
        Me.monitorsBtn2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.monitorsBtn2.Size = New System.Drawing.Size(170, 103)
        Me.monitorsBtn2.TabIndex = 26
        Me.monitorsBtn2.Text = "Monitors"
        Me.monitorsBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.monitorsBtn2.UseVisualStyleBackColor = True
        '
        'IPsBtn2
        '
        Me.IPsBtn2.Image = Global.cems.My.Resources.Resources.landline
        Me.IPsBtn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IPsBtn2.Location = New System.Drawing.Point(186, 95)
        Me.IPsBtn2.Name = "IPsBtn2"
        Me.IPsBtn2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.IPsBtn2.Size = New System.Drawing.Size(161, 103)
        Me.IPsBtn2.TabIndex = 25
        Me.IPsBtn2.Text = "IP Phones"
        Me.IPsBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IPsBtn2.UseVisualStyleBackColor = True
        '
        'CPUsBtn2
        '
        Me.CPUsBtn2.Image = Global.cems.My.Resources.Resources.unit
        Me.CPUsBtn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CPUsBtn2.Location = New System.Drawing.Point(15, 95)
        Me.CPUsBtn2.Name = "CPUsBtn2"
        Me.CPUsBtn2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.CPUsBtn2.Size = New System.Drawing.Size(165, 103)
        Me.CPUsBtn2.TabIndex = 24
        Me.CPUsBtn2.Text = "CPUs"
        Me.CPUsBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CPUsBtn2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 24)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Admin Home Page"
        '
        'adminHomePagePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "adminHomePagePanel"
        Me.Size = New System.Drawing.Size(725, 418)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents userNumber As Label
    Friend WithEvents usersBtn2 As Button
    Friend WithEvents nonActiveMonitorNumber As Label
    Friend WithEvents activeMonitorNumber As Label
    Friend WithEvents nonActiveIPNumber As Label
    Friend WithEvents activeIPNumber As Label
    Friend WithEvents nonActiveCPUNumber As Label
    Friend WithEvents activeCPUNumber As Label
    Friend WithEvents monitorsBtn2 As Button
    Friend WithEvents IPsBtn2 As Button
    Friend WithEvents CPUsBtn2 As Button
    Friend WithEvents Label1 As Label
End Class
