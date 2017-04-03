<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminSide
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.endrePwBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sokSpesCmb = New System.Windows.Forms.ComboBox()
        Me.btnFjernBruker = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEndrePersoninfo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sokTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnSokBruker = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.brkStatLbl = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.stdnavnLbl = New System.Windows.Forms.Label()
        Me.stdnavnTxt = New System.Windows.Forms.TextBox()
        Me.postnrLbl = New System.Windows.Forms.Label()
        Me.postnrTxt = New System.Windows.Forms.TextBox()
        Me.adresseLbl = New System.Windows.Forms.Label()
        Me.adresseTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.passordcTxt = New System.Windows.Forms.TextBox()
        Me.passordTxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnummerTxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tlfTxt = New System.Windows.Forms.TextBox()
        Me.etternavnTxt = New System.Windows.Forms.TextBox()
        Me.fornavnTxt = New System.Windows.Forms.TextBox()
        Me.epostTxt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLoggUt = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 61)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(737, 416)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.endrePwBtn)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.sokSpesCmb)
        Me.TabPage1.Controls.Add(Me.btnFjernBruker)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.btnEndrePersoninfo)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.sokTxt)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.btnSokBruker)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(729, 390)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Brukeradministrasjon"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'endrePwBtn
        '
        Me.endrePwBtn.Location = New System.Drawing.Point(271, 266)
        Me.endrePwBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.endrePwBtn.Name = "endrePwBtn"
        Me.endrePwBtn.Size = New System.Drawing.Size(90, 33)
        Me.endrePwBtn.TabIndex = 22
        Me.endrePwBtn.Text = "Endre passord"
        Me.endrePwBtn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 218)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Velg rolle"
        '
        'sokSpesCmb
        '
        Me.sokSpesCmb.FormattingEnabled = True
        Me.sokSpesCmb.Items.AddRange(New Object() {"fornavn", "etternavn", "e-post"})
        Me.sokSpesCmb.Location = New System.Drawing.Point(65, 215)
        Me.sokSpesCmb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.sokSpesCmb.Name = "sokSpesCmb"
        Me.sokSpesCmb.Size = New System.Drawing.Size(92, 21)
        Me.sokSpesCmb.TabIndex = 20
        '
        'btnFjernBruker
        '
        Me.btnFjernBruker.Location = New System.Drawing.Point(186, 144)
        Me.btnFjernBruker.Name = "btnFjernBruker"
        Me.btnFjernBruker.Size = New System.Drawing.Size(133, 23)
        Me.btnFjernBruker.TabIndex = 19
        Me.btnFjernBruker.Text = "Fjern bruker fra database"
        Me.btnFjernBruker.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(186, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Fjerne valgt bruker"
        '
        'btnEndrePersoninfo
        '
        Me.btnEndrePersoninfo.Location = New System.Drawing.Point(186, 85)
        Me.btnEndrePersoninfo.Name = "btnEndrePersoninfo"
        Me.btnEndrePersoninfo.Size = New System.Drawing.Size(121, 23)
        Me.btnEndrePersoninfo.TabIndex = 17
        Me.btnEndrePersoninfo.Text = "Personinformasjon"
        Me.btnEndrePersoninfo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Endre brukerinfo"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(313, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Endre"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(186, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Endre brukerstatus"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Ansatt", "Blodgiver", "Leder", "IT"})
        Me.ComboBox1.Location = New System.Drawing.Point(186, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Søk etter bruker"
        '
        'sokTxt
        '
        Me.sokTxt.Location = New System.Drawing.Point(6, 246)
        Me.sokTxt.Name = "sokTxt"
        Me.sokTxt.Size = New System.Drawing.Size(102, 20)
        Me.sokTxt.TabIndex = 11
        Me.sokTxt.Text = "Søk etter navn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Velg en bruker å redigere"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(8, 25)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(160, 160)
        Me.ListBox1.TabIndex = 9
        '
        'btnSokBruker
        '
        Me.btnSokBruker.Location = New System.Drawing.Point(113, 244)
        Me.btnSokBruker.Name = "btnSokBruker"
        Me.btnSokBruker.Size = New System.Drawing.Size(52, 23)
        Me.btnSokBruker.TabIndex = 8
        Me.btnSokBruker.Text = "Søk"
        Me.btnSokBruker.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.brkStatLbl)
        Me.TabPage2.Controls.Add(Me.ComboBox2)
        Me.TabPage2.Controls.Add(Me.stdnavnLbl)
        Me.TabPage2.Controls.Add(Me.stdnavnTxt)
        Me.TabPage2.Controls.Add(Me.postnrLbl)
        Me.TabPage2.Controls.Add(Me.postnrTxt)
        Me.TabPage2.Controls.Add(Me.adresseLbl)
        Me.TabPage2.Controls.Add(Me.adresseTxt)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.passordcTxt)
        Me.TabPage2.Controls.Add(Me.passordTxt)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.pnummerTxt)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.tlfTxt)
        Me.TabPage2.Controls.Add(Me.etternavnTxt)
        Me.TabPage2.Controls.Add(Me.fornavnTxt)
        Me.TabPage2.Controls.Add(Me.epostTxt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(399, 381)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Legg til ny bruker"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'brkStatLbl
        '
        Me.brkStatLbl.AutoSize = True
        Me.brkStatLbl.Location = New System.Drawing.Point(95, 228)
        Me.brkStatLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.brkStatLbl.Name = "brkStatLbl"
        Me.brkStatLbl.Size = New System.Drawing.Size(69, 13)
        Me.brkStatLbl.TabIndex = 53
        Me.brkStatLbl.Text = "Brukerstatus:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"blodgiver", "ansatt", "leder", "admin"})
        Me.ComboBox2.Location = New System.Drawing.Point(169, 225)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox2.TabIndex = 52
        '
        'stdnavnLbl
        '
        Me.stdnavnLbl.AutoSize = True
        Me.stdnavnLbl.Location = New System.Drawing.Point(214, 85)
        Me.stdnavnLbl.Name = "stdnavnLbl"
        Me.stdnavnLbl.Size = New System.Drawing.Size(58, 13)
        Me.stdnavnLbl.TabIndex = 49
        Me.stdnavnLbl.Text = "Stedsnavn"
        '
        'stdnavnTxt
        '
        Me.stdnavnTxt.Location = New System.Drawing.Point(217, 102)
        Me.stdnavnTxt.Name = "stdnavnTxt"
        Me.stdnavnTxt.Size = New System.Drawing.Size(100, 20)
        Me.stdnavnTxt.TabIndex = 48
        '
        'postnrLbl
        '
        Me.postnrLbl.AutoSize = True
        Me.postnrLbl.Location = New System.Drawing.Point(214, 48)
        Me.postnrLbl.Name = "postnrLbl"
        Me.postnrLbl.Size = New System.Drawing.Size(71, 13)
        Me.postnrLbl.TabIndex = 47
        Me.postnrLbl.Text = "Postnunmmer"
        '
        'postnrTxt
        '
        Me.postnrTxt.Location = New System.Drawing.Point(217, 63)
        Me.postnrTxt.Name = "postnrTxt"
        Me.postnrTxt.Size = New System.Drawing.Size(100, 20)
        Me.postnrTxt.TabIndex = 46
        '
        'adresseLbl
        '
        Me.adresseLbl.AutoSize = True
        Me.adresseLbl.Location = New System.Drawing.Point(214, 6)
        Me.adresseLbl.Name = "adresseLbl"
        Me.adresseLbl.Size = New System.Drawing.Size(45, 13)
        Me.adresseLbl.TabIndex = 45
        Me.adresseLbl.Text = "Adresse"
        '
        'adresseTxt
        '
        Me.adresseTxt.Location = New System.Drawing.Point(217, 23)
        Me.adresseTxt.Name = "adresseTxt"
        Me.adresseTxt.Size = New System.Drawing.Size(100, 20)
        Me.adresseTxt.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(214, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Bekreft passord:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(62, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Passord"
        '
        'passordcTxt
        '
        Me.passordcTxt.Location = New System.Drawing.Point(217, 188)
        Me.passordcTxt.Name = "passordcTxt"
        Me.passordcTxt.Size = New System.Drawing.Size(100, 20)
        Me.passordcTxt.TabIndex = 39
        '
        'passordTxt
        '
        Me.passordTxt.Location = New System.Drawing.Point(65, 188)
        Me.passordTxt.Name = "passordTxt"
        Me.passordTxt.Size = New System.Drawing.Size(100, 20)
        Me.passordTxt.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(62, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Personnummer:"
        '
        'pnummerTxt
        '
        Me.pnummerTxt.Location = New System.Drawing.Point(65, 102)
        Me.pnummerTxt.Name = "pnummerTxt"
        Me.pnummerTxt.Size = New System.Drawing.Size(100, 20)
        Me.pnummerTxt.TabIndex = 36
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(151, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 36)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Registrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(214, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Telefon"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(62, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Etternavn"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(62, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Fornavn"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(63, 127)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Epost"
        '
        'tlfTxt
        '
        Me.tlfTxt.Location = New System.Drawing.Point(217, 143)
        Me.tlfTxt.Name = "tlfTxt"
        Me.tlfTxt.Size = New System.Drawing.Size(100, 20)
        Me.tlfTxt.TabIndex = 30
        '
        'etternavnTxt
        '
        Me.etternavnTxt.Location = New System.Drawing.Point(65, 63)
        Me.etternavnTxt.Name = "etternavnTxt"
        Me.etternavnTxt.Size = New System.Drawing.Size(100, 20)
        Me.etternavnTxt.TabIndex = 29
        '
        'fornavnTxt
        '
        Me.fornavnTxt.Location = New System.Drawing.Point(65, 22)
        Me.fornavnTxt.Name = "fornavnTxt"
        Me.fornavnTxt.Size = New System.Drawing.Size(100, 20)
        Me.fornavnTxt.TabIndex = 28
        '
        'epostTxt
        '
        Me.epostTxt.Location = New System.Drawing.Point(65, 143)
        Me.epostTxt.Name = "epostTxt"
        Me.epostTxt.Size = New System.Drawing.Size(100, 20)
        Me.epostTxt.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Image = Global.blodapp.My.Resources.Resources.testbloodflow1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnLoggUt
        '
        Me.btnLoggUt.Location = New System.Drawing.Point(634, 12)
        Me.btnLoggUt.Name = "btnLoggUt"
        Me.btnLoggUt.Size = New System.Drawing.Size(103, 23)
        Me.btnLoggUt.TabIndex = 12
        Me.btnLoggUt.Text = "Logg ut"
        Me.btnLoggUt.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.btnLoggUt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(739, 55)
        Me.Panel2.TabIndex = 20
        '
        'adminSide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 439)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "adminSide"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnFjernBruker As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEndrePersoninfo As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents sokTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnSokBruker As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents sokSpesCmb As ComboBox
    Friend WithEvents brkStatLbl As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents stdnavnLbl As Label
    Friend WithEvents stdnavnTxt As TextBox
    Friend WithEvents postnrLbl As Label
    Friend WithEvents postnrTxt As TextBox
    Friend WithEvents adresseLbl As Label
    Friend WithEvents adresseTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents passordcTxt As TextBox
    Friend WithEvents passordTxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents pnummerTxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tlfTxt As TextBox
    Friend WithEvents etternavnTxt As TextBox
    Friend WithEvents fornavnTxt As TextBox
    Friend WithEvents epostTxt As TextBox
    Friend WithEvents endrePwBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLoggUt As Button
    Friend WithEvents Panel2 As Panel
End Class
