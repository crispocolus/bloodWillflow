﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ansattSide
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBehov = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnInnkalling = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tappeKalender = New System.Windows.Forms.MonthCalendar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstKandidater = New System.Windows.Forms.ListBox()
        Me.CBoxBlodtype = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chkBekreft = New System.Windows.Forms.CheckBox()
        Me.btnRetur = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtTidspunkt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMengde = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBlodtype = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstBestillinger = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(590, 414)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.btnBehov)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.btnInnkalling)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.tappeKalender)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lstKandidater)
        Me.TabPage1.Controls.Add(Me.CBoxBlodtype)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(582, 388)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Innkalling"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Du trenger minst: 0 blodgivere"
        '
        'btnBehov
        '
        Me.btnBehov.Location = New System.Drawing.Point(6, 126)
        Me.btnBehov.Name = "btnBehov"
        Me.btnBehov.Size = New System.Drawing.Size(74, 22)
        Me.btnBehov.TabIndex = 9
        Me.btnBehov.Text = "Regn ut innkallingsbehov"
        Me.btnBehov.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Literbehov:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 100)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(74, 20)
        Me.TextBox1.TabIndex = 7
        '
        'btnInnkalling
        '
        Me.btnInnkalling.Location = New System.Drawing.Point(374, 227)
        Me.btnInnkalling.Name = "btnInnkalling"
        Me.btnInnkalling.Size = New System.Drawing.Size(129, 51)
        Me.btnInnkalling.TabIndex = 6
        Me.btnInnkalling.Text = "Send innkalling"
        Me.btnInnkalling.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(318, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tappedato"
        '
        'tappeKalender
        '
        Me.tappeKalender.Location = New System.Drawing.Point(321, 44)
        Me.tappeKalender.Name = "tappeKalender"
        Me.tappeKalender.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kandidater"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Velg blodtype:"
        '
        'lstKandidater
        '
        Me.lstKandidater.FormattingEnabled = True
        Me.lstKandidater.Location = New System.Drawing.Point(201, 44)
        Me.lstKandidater.Name = "lstKandidater"
        Me.lstKandidater.Size = New System.Drawing.Size(108, 264)
        Me.lstKandidater.TabIndex = 1
        '
        'CBoxBlodtype
        '
        Me.CBoxBlodtype.FormattingEnabled = True
        Me.CBoxBlodtype.Items.AddRange(New Object() {"O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-"})
        Me.CBoxBlodtype.Location = New System.Drawing.Point(6, 44)
        Me.CBoxBlodtype.Name = "CBoxBlodtype"
        Me.CBoxBlodtype.Size = New System.Drawing.Size(74, 21)
        Me.CBoxBlodtype.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chkBekreft)
        Me.TabPage2.Controls.Add(Me.btnRetur)
        Me.TabPage2.Controls.Add(Me.btnSend)
        Me.TabPage2.Controls.Add(Me.txtTidspunkt)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtMengde)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtBlodtype)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.lstBestillinger)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(582, 388)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Bestillinger"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chkBekreft
        '
        Me.chkBekreft.AutoSize = True
        Me.chkBekreft.Location = New System.Drawing.Point(263, 185)
        Me.chkBekreft.Name = "chkBekreft"
        Me.chkBekreft.Size = New System.Drawing.Size(103, 17)
        Me.chkBekreft.TabIndex = 12
        Me.chkBekreft.Text = "Bekreft bestilling"
        Me.chkBekreft.UseVisualStyleBackColor = True
        '
        'btnRetur
        '
        Me.btnRetur.Location = New System.Drawing.Point(263, 237)
        Me.btnRetur.Name = "btnRetur"
        Me.btnRetur.Size = New System.Drawing.Size(100, 23)
        Me.btnRetur.TabIndex = 11
        Me.btnRetur.Text = "Send retur"
        Me.btnRetur.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Enabled = False
        Me.btnSend.Location = New System.Drawing.Point(263, 208)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(100, 23)
        Me.btnSend.TabIndex = 10
        Me.btnSend.Text = "Send bestilling"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtTidspunkt
        '
        Me.txtTidspunkt.Location = New System.Drawing.Point(263, 157)
        Me.txtTidspunkt.Name = "txtTidspunkt"
        Me.txtTidspunkt.Size = New System.Drawing.Size(100, 20)
        Me.txtTidspunkt.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(260, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Tidspunkt mottatt:"
        '
        'txtMengde
        '
        Me.txtMengde.Location = New System.Drawing.Point(263, 97)
        Me.txtMengde.Name = "txtMengde"
        Me.txtMengde.Size = New System.Drawing.Size(100, 20)
        Me.txtMengde.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(260, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Mengde:"
        '
        'txtBlodtype
        '
        Me.txtBlodtype.Location = New System.Drawing.Point(263, 36)
        Me.txtBlodtype.Name = "txtBlodtype"
        Me.txtBlodtype.Size = New System.Drawing.Size(100, 20)
        Me.txtBlodtype.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(260, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Blodtype:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Alle bestillinger"
        '
        'lstBestillinger
        '
        Me.lstBestillinger.FormattingEnabled = True
        Me.lstBestillinger.Location = New System.Drawing.Point(24, 35)
        Me.lstBestillinger.Name = "lstBestillinger"
        Me.lstBestillinger.Size = New System.Drawing.Size(184, 225)
        Me.lstBestillinger.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ListBox1)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.ComboBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(582, 388)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Oversikt blodbank"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(26, 46)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Søk antall liter"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(177, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(174, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Resultat"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Full oversikt"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(27, 122)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(529, 251)
        Me.ListBox1.TabIndex = 5
        '
        'ansattSide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ansattSide"
        Me.Text = "ansattSide"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnInnkalling As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tappeKalender As MonthCalendar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstKandidater As ListBox
    Friend WithEvents CBoxBlodtype As ComboBox
    Friend WithEvents btnSend As Button
    Friend WithEvents txtTidspunkt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMengde As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBlodtype As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lstBestillinger As ListBox
    Friend WithEvents btnRetur As Button
    Friend WithEvents chkBekreft As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBehov As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
