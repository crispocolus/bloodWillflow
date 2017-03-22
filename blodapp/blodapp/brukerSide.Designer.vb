<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class brukerSide
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.btnSokBlodgiving = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEndrePersoninfo = New System.Windows.Forms.Button()
        Me.lstLedigeTimer = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAvbestill = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(202, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Personinfo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(361, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Giverinfo"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(328, 257)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 121)
        Me.ListBox2.TabIndex = 4
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(172, 257)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 121)
        Me.ListBox3.TabIndex = 5
        '
        'btnSokBlodgiving
        '
        Me.btnSokBlodgiving.Location = New System.Drawing.Point(157, 199)
        Me.btnSokBlodgiving.Name = "btnSokBlodgiving"
        Me.btnSokBlodgiving.Size = New System.Drawing.Size(102, 23)
        Me.btnSokBlodgiving.TabIndex = 6
        Me.btnSokBlodgiving.Text = "Søk om å gi blod"
        Me.btnSokBlodgiving.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(18, 25)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(169, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Velg en ledig time"
        '
        'btnEndrePersoninfo
        '
        Me.btnEndrePersoninfo.Location = New System.Drawing.Point(181, 384)
        Me.btnEndrePersoninfo.Name = "btnEndrePersoninfo"
        Me.btnEndrePersoninfo.Size = New System.Drawing.Size(102, 23)
        Me.btnEndrePersoninfo.TabIndex = 9
        Me.btnEndrePersoninfo.Text = "Endre personinfo"
        Me.btnEndrePersoninfo.UseVisualStyleBackColor = True
        '
        'lstLedigeTimer
        '
        Me.lstLedigeTimer.FormattingEnabled = True
        Me.lstLedigeTimer.Location = New System.Drawing.Point(257, 25)
        Me.lstLedigeTimer.Name = "lstLedigeTimer"
        Me.lstLedigeTimer.Size = New System.Drawing.Size(191, 160)
        Me.lstLedigeTimer.TabIndex = 10
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 257)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 121)
        Me.ListBox1.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Timer du er registrert for"
        '
        'btnAvbestill
        '
        Me.btnAvbestill.Location = New System.Drawing.Point(11, 384)
        Me.btnAvbestill.Name = "btnAvbestill"
        Me.btnAvbestill.Size = New System.Drawing.Size(121, 23)
        Me.btnAvbestill.TabIndex = 13
        Me.btnAvbestill.Text = "Avbestill valgt time"
        Me.btnAvbestill.UseVisualStyleBackColor = True
        '
        'brukerSide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 431)
        Me.Controls.Add(Me.btnAvbestill)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lstLedigeTimer)
        Me.Controls.Add(Me.btnEndrePersoninfo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.btnSokBlodgiving)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "brukerSide"
        Me.Text = "brukerSide"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents btnSokBlodgiving As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEndrePersoninfo As Button
    Friend WithEvents lstLedigeTimer As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAvbestill As Button
End Class
