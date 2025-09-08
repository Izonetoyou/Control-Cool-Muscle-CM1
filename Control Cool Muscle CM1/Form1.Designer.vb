<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnenable = New System.Windows.Forms.Button()
        Me.btnDisable = New System.Windows.Forms.Button()
        Me.txt_position = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.Timer_CM = New System.Windows.Forms.Timer(Me.components)
        Me.cbshowposition = New System.Windows.Forms.CheckBox()
        Me.lbPosition = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.txt_speed = New System.Windows.Forms.TextBox()
        Me.txt_acc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PositionBar = New System.Windows.Forms.TrackBar()
        Me.btnOrgSearch = New System.Windows.Forms.Button()
        CType(Me.PositionBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(258, 169)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(75, 23)
        Me.btnMove.TabIndex = 0
        Me.btnMove.Text = "Move"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(258, 198)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnenable
        '
        Me.btnenable.Location = New System.Drawing.Point(96, 23)
        Me.btnenable.Name = "btnenable"
        Me.btnenable.Size = New System.Drawing.Size(75, 23)
        Me.btnenable.TabIndex = 4
        Me.btnenable.Text = "Enable"
        Me.btnenable.UseVisualStyleBackColor = True
        '
        'btnDisable
        '
        Me.btnDisable.Location = New System.Drawing.Point(177, 23)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(75, 23)
        Me.btnDisable.TabIndex = 5
        Me.btnDisable.Text = "Disable"
        Me.btnDisable.UseVisualStyleBackColor = True
        '
        'txt_position
        '
        Me.txt_position.Location = New System.Drawing.Point(16, 172)
        Me.txt_position.Name = "txt_position"
        Me.txt_position.Size = New System.Drawing.Size(100, 20)
        Me.txt_position.TabIndex = 6
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(15, 23)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 7
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'Timer_CM
        '
        Me.Timer_CM.Interval = 50
        '
        'cbshowposition
        '
        Me.cbshowposition.AutoSize = True
        Me.cbshowposition.Location = New System.Drawing.Point(23, 72)
        Me.cbshowposition.Name = "cbshowposition"
        Me.cbshowposition.Size = New System.Drawing.Size(93, 17)
        Me.cbshowposition.TabIndex = 8
        Me.cbshowposition.Text = "Show Position"
        Me.cbshowposition.UseVisualStyleBackColor = True
        '
        'lbPosition
        '
        Me.lbPosition.AutoSize = True
        Me.lbPosition.Location = New System.Drawing.Point(122, 73)
        Me.lbPosition.Name = "lbPosition"
        Me.lbPosition.Size = New System.Drawing.Size(44, 13)
        Me.lbPosition.TabIndex = 9
        Me.lbPosition.Text = "Position"
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(258, 23)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 10
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'txt_speed
        '
        Me.txt_speed.Location = New System.Drawing.Point(122, 172)
        Me.txt_speed.Name = "txt_speed"
        Me.txt_speed.Size = New System.Drawing.Size(49, 20)
        Me.txt_speed.TabIndex = 11
        Me.txt_speed.Text = "80"
        '
        'txt_acc
        '
        Me.txt_acc.Location = New System.Drawing.Point(177, 172)
        Me.txt_acc.Name = "txt_acc"
        Me.txt_acc.Size = New System.Drawing.Size(48, 20)
        Me.txt_acc.TabIndex = 12
        Me.txt_acc.Text = "100"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Position"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Speed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(175, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Acc"
        '
        'PositionBar
        '
        Me.PositionBar.Location = New System.Drawing.Point(23, 107)
        Me.PositionBar.Maximum = 5000
        Me.PositionBar.Minimum = -5000
        Me.PositionBar.Name = "PositionBar"
        Me.PositionBar.Size = New System.Drawing.Size(305, 45)
        Me.PositionBar.TabIndex = 16
        '
        'btnOrgSearch
        '
        Me.btnOrgSearch.Location = New System.Drawing.Point(258, 52)
        Me.btnOrgSearch.Name = "btnOrgSearch"
        Me.btnOrgSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnOrgSearch.TabIndex = 17
        Me.btnOrgSearch.Text = "Org Search"
        Me.btnOrgSearch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 435)
        Me.Controls.Add(Me.btnOrgSearch)
        Me.Controls.Add(Me.PositionBar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_acc)
        Me.Controls.Add(Me.txt_speed)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lbPosition)
        Me.Controls.Add(Me.cbshowposition)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txt_position)
        Me.Controls.Add(Me.btnDisable)
        Me.Controls.Add(Me.btnenable)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnMove)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PositionBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMove As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnStop As Button
    Friend WithEvents btnenable As Button
    Friend WithEvents btnDisable As Button
    Friend WithEvents txt_position As TextBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents Timer_CM As Timer
    Friend WithEvents cbshowposition As CheckBox
    Friend WithEvents lbPosition As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents txt_speed As TextBox
    Friend WithEvents txt_acc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PositionBar As TrackBar
    Friend WithEvents btnOrgSearch As Button
End Class
