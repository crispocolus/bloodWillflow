<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class brukerSide
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(brukerSide))
        Me.mndKal1 = New System.Windows.Forms.MonthCalendar()
        Me.lblVelgLedigTime = New System.Windows.Forms.Label()
        Me.datoInkallLst = New System.Windows.Forms.ListBox()
        Me.btnSokTime = New System.Windows.Forms.Button()
        Me.lstLabsvar = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.innkallingLst = New System.Windows.Forms.ListBox()
        Me.btnAvbestillTime = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnEndrePersinfo = New System.Windows.Forms.Button()
        Me.btnLoggUt = New System.Windows.Forms.Button()
        Me.fornavnTxt = New System.Windows.Forms.TextBox()
        Me.etternavnTxt = New System.Windows.Forms.TextBox()
        Me.telefonTxt = New System.Windows.Forms.TextBox()
        Me.epostTxt = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.timeLst = New System.Windows.Forms.ListBox()
        Me.btnSvarInkalling = New System.Windows.Forms.Button()
        Me.btnLagrePInfo = New System.Windows.Forms.Button()
        Me.lblPostnr = New System.Windows.Forms.Label()
        Me.postnrTxt = New System.Windows.Forms.TextBox()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.adresseTxt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblEpost = New System.Windows.Forms.Label()
        Me.lblTlf = New System.Windows.Forms.Label()
        Me.lblEtternavn = New System.Windows.Forms.Label()
        Me.lblFornavn = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEgenErk = New System.Windows.Forms.Button()
        Me.lblKolon = New System.Windows.Forms.Label()
        Me.lblKlokkeslett = New System.Windows.Forms.Label()
        Me.cmbMin = New System.Windows.Forms.ComboBox()
        Me.cmbTime = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnEndrePw = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mndKal1
        '
        Me.mndKal1.Location = New System.Drawing.Point(27, 42)
        Me.mndKal1.Name = "mndKal1"
        Me.mndKal1.TabIndex = 0
        '
        'lblVelgLedigTime
        '
        Me.lblVelgLedigTime.AutoSize = True
        Me.lblVelgLedigTime.Location = New System.Drawing.Point(87, 22)
        Me.lblVelgLedigTime.Name = "lblVelgLedigTime"
        Me.lblVelgLedigTime.Size = New System.Drawing.Size(198, 13)
        Me.lblVelgLedigTime.TabIndex = 1
        Me.lblVelgLedigTime.Text = "Velg en ledig time (minst 2 uker frem i tid)"
        '
        'datoInkallLst
        '
        Me.datoInkallLst.FormattingEnabled = True
        Me.datoInkallLst.Location = New System.Drawing.Point(315, 42)
        Me.datoInkallLst.Name = "datoInkallLst"
        Me.datoInkallLst.Size = New System.Drawing.Size(160, 147)
        Me.datoInkallLst.TabIndex = 2
        '
        'btnSokTime
        '
        Me.btnSokTime.Location = New System.Drawing.Point(90, 278)
        Me.btnSokTime.Name = "btnSokTime"
        Me.btnSokTime.Size = New System.Drawing.Size(130, 23)
        Me.btnSokTime.TabIndex = 3
        Me.btnSokTime.Text = "Send inn ønsket time"
        Me.btnSokTime.UseVisualStyleBackColor = True
        '
        'lstLabsvar
        '
        Me.lstLabsvar.FormattingEnabled = True
        Me.lstLabsvar.Location = New System.Drawing.Point(575, 56)
        Me.lstLabsvar.Name = "lstLabsvar"
        Me.lstLabsvar.Size = New System.Drawing.Size(158, 225)
        Me.lstLabsvar.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(612, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Giverinfo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(432, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Personlig info"
        '
        'innkallingLst
        '
        Me.innkallingLst.FormattingEnabled = True
        Me.innkallingLst.Location = New System.Drawing.Point(12, 50)
        Me.innkallingLst.Name = "innkallingLst"
        Me.innkallingLst.Size = New System.Drawing.Size(119, 173)
        Me.innkallingLst.TabIndex = 8
        '
        'btnAvbestillTime
        '
        Me.btnAvbestillTime.Location = New System.Drawing.Point(215, 247)
        Me.btnAvbestillTime.Name = "btnAvbestillTime"
        Me.btnAvbestillTime.Size = New System.Drawing.Size(112, 23)
        Me.btnAvbestillTime.TabIndex = 9
        Me.btnAvbestillTime.Text = "Avbestill valgt time"
        Me.btnAvbestillTime.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Aktive innkallinger"
        '
        'btnEndrePersinfo
        '
        Me.btnEndrePersinfo.Location = New System.Drawing.Point(419, 223)
        Me.btnEndrePersinfo.Name = "btnEndrePersinfo"
        Me.btnEndrePersinfo.Size = New System.Drawing.Size(103, 23)
        Me.btnEndrePersinfo.TabIndex = 11
        Me.btnEndrePersinfo.Text = "Endre personinfo"
        Me.btnEndrePersinfo.UseVisualStyleBackColor = True
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
        'fornavnTxt
        '
        Me.fornavnTxt.Location = New System.Drawing.Point(419, 57)
        Me.fornavnTxt.Name = "fornavnTxt"
        Me.fornavnTxt.Size = New System.Drawing.Size(100, 20)
        Me.fornavnTxt.TabIndex = 13
        Me.fornavnTxt.Visible = False
        '
        'etternavnTxt
        '
        Me.etternavnTxt.Location = New System.Drawing.Point(419, 85)
        Me.etternavnTxt.Name = "etternavnTxt"
        Me.etternavnTxt.Size = New System.Drawing.Size(100, 20)
        Me.etternavnTxt.TabIndex = 14
        Me.etternavnTxt.Visible = False
        '
        'telefonTxt
        '
        Me.telefonTxt.Location = New System.Drawing.Point(419, 113)
        Me.telefonTxt.Name = "telefonTxt"
        Me.telefonTxt.Size = New System.Drawing.Size(100, 20)
        Me.telefonTxt.TabIndex = 15
        Me.telefonTxt.Visible = False
        '
        'epostTxt
        '
        Me.epostTxt.Location = New System.Drawing.Point(419, 141)
        Me.epostTxt.Name = "epostTxt"
        Me.epostTxt.Size = New System.Drawing.Size(100, 20)
        Me.epostTxt.TabIndex = 16
        Me.epostTxt.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 61)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 494)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.timeLst)
        Me.TabPage1.Controls.Add(Me.btnSvarInkalling)
        Me.TabPage1.Controls.Add(Me.btnLagrePInfo)
        Me.TabPage1.Controls.Add(Me.lblPostnr)
        Me.TabPage1.Controls.Add(Me.postnrTxt)
        Me.TabPage1.Controls.Add(Me.lblAdresse)
        Me.TabPage1.Controls.Add(Me.adresseTxt)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.lblEpost)
        Me.TabPage1.Controls.Add(Me.lblTlf)
        Me.TabPage1.Controls.Add(Me.lblEtternavn)
        Me.TabPage1.Controls.Add(Me.lblFornavn)
        Me.TabPage1.Controls.Add(Me.btnEndrePersinfo)
        Me.TabPage1.Controls.Add(Me.fornavnTxt)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.etternavnTxt)
        Me.TabPage1.Controls.Add(Me.btnAvbestillTime)
        Me.TabPage1.Controls.Add(Me.telefonTxt)
        Me.TabPage1.Controls.Add(Me.innkallingLst)
        Me.TabPage1.Controls.Add(Me.epostTxt)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.lstLabsvar)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.ShapeContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(752, 468)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Min side"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(246, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Timeliste"
        '
        'timeLst
        '
        Me.timeLst.FormattingEnabled = True
        Me.timeLst.Location = New System.Drawing.Point(189, 52)
        Me.timeLst.Name = "timeLst"
        Me.timeLst.Size = New System.Drawing.Size(196, 173)
        Me.timeLst.TabIndex = 20
        '
        'btnSvarInkalling
        '
        Me.btnSvarInkalling.Location = New System.Drawing.Point(12, 245)
        Me.btnSvarInkalling.Name = "btnSvarInkalling"
        Me.btnSvarInkalling.Size = New System.Drawing.Size(119, 23)
        Me.btnSvarInkalling.TabIndex = 31
        Me.btnSvarInkalling.Text = "Svar på innkalling"
        Me.btnSvarInkalling.UseVisualStyleBackColor = True
        '
        'btnLagrePInfo
        '
        Me.btnLagrePInfo.Location = New System.Drawing.Point(419, 252)
        Me.btnLagrePInfo.Name = "btnLagrePInfo"
        Me.btnLagrePInfo.Size = New System.Drawing.Size(103, 23)
        Me.btnLagrePInfo.TabIndex = 30
        Me.btnLagrePInfo.Text = "Lagre personinfo"
        Me.btnLagrePInfo.UseVisualStyleBackColor = True
        '
        'lblPostnr
        '
        Me.lblPostnr.AutoSize = True
        Me.lblPostnr.Location = New System.Drawing.Point(443, 200)
        Me.lblPostnr.Name = "lblPostnr"
        Me.lblPostnr.Size = New System.Drawing.Size(45, 13)
        Me.lblPostnr.TabIndex = 29
        Me.lblPostnr.Text = "Label14"
        '
        'postnrTxt
        '
        Me.postnrTxt.Location = New System.Drawing.Point(419, 197)
        Me.postnrTxt.Name = "postnrTxt"
        Me.postnrTxt.Size = New System.Drawing.Size(100, 20)
        Me.postnrTxt.TabIndex = 28
        Me.postnrTxt.Visible = False
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(443, 172)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(45, 13)
        Me.lblAdresse.TabIndex = 27
        Me.lblAdresse.Text = "Label13"
        '
        'adresseTxt
        '
        Me.adresseTxt.Location = New System.Drawing.Point(419, 169)
        Me.adresseTxt.Name = "adresseTxt"
        Me.adresseTxt.Size = New System.Drawing.Size(100, 20)
        Me.adresseTxt.TabIndex = 26
        Me.adresseTxt.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 400)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 65)
        Me.Panel1.TabIndex = 25
        '
        'lblEpost
        '
        Me.lblEpost.AutoSize = True
        Me.lblEpost.Location = New System.Drawing.Point(443, 144)
        Me.lblEpost.Name = "lblEpost"
        Me.lblEpost.Size = New System.Drawing.Size(45, 13)
        Me.lblEpost.TabIndex = 21
        Me.lblEpost.Text = "Label12"
        '
        'lblTlf
        '
        Me.lblTlf.AutoSize = True
        Me.lblTlf.Location = New System.Drawing.Point(443, 116)
        Me.lblTlf.Name = "lblTlf"
        Me.lblTlf.Size = New System.Drawing.Size(45, 13)
        Me.lblTlf.TabIndex = 20
        Me.lblTlf.Text = "Label11"
        '
        'lblEtternavn
        '
        Me.lblEtternavn.AutoSize = True
        Me.lblEtternavn.Location = New System.Drawing.Point(443, 88)
        Me.lblEtternavn.Name = "lblEtternavn"
        Me.lblEtternavn.Size = New System.Drawing.Size(45, 13)
        Me.lblEtternavn.TabIndex = 19
        Me.lblEtternavn.Text = "Label10"
        '
        'lblFornavn
        '
        Me.lblFornavn.AutoSize = True
        Me.lblFornavn.Location = New System.Drawing.Point(443, 60)
        Me.lblFornavn.Name = "lblFornavn"
        Me.lblFornavn.Size = New System.Drawing.Size(39, 13)
        Me.lblFornavn.TabIndex = 18
        Me.lblFornavn.Text = "Label9"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(746, 462)
        Me.ShapeContainer1.TabIndex = 32
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 413
        Me.LineShape5.X2 = 519
        Me.LineShape5.Y1 = 53
        Me.LineShape5.Y2 = 53
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 519
        Me.LineShape4.X2 = 519
        Me.LineShape4.Y1 = 53
        Me.LineShape4.Y2 = 216
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 412
        Me.LineShape3.X2 = 518
        Me.LineShape3.Y1 = 216
        Me.LineShape3.Y2 = 216
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 412
        Me.LineShape2.X2 = 412
        Me.LineShape2.Y1 = 53
        Me.LineShape2.Y2 = 216
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 394
        Me.LineShape1.X2 = 394
        Me.LineShape1.Y1 = -4
        Me.LineShape1.Y2 = 399
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.btnEgenErk)
        Me.TabPage2.Controls.Add(Me.lblKolon)
        Me.TabPage2.Controls.Add(Me.lblKlokkeslett)
        Me.TabPage2.Controls.Add(Me.cmbMin)
        Me.TabPage2.Controls.Add(Me.cmbTime)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Controls.Add(Me.mndKal1)
        Me.TabPage2.Controls.Add(Me.lblVelgLedigTime)
        Me.TabPage2.Controls.Add(Me.datoInkallLst)
        Me.TabPage2.Controls.Add(Me.btnSokTime)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(752, 468)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Bestill time"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(312, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(334, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "En egenerklæring må leveres inn for hver gang du har tenkt å gi blod:"
        '
        'btnEgenErk
        '
        Me.btnEgenErk.Location = New System.Drawing.Point(402, 298)
        Me.btnEgenErk.Name = "btnEgenErk"
        Me.btnEgenErk.Size = New System.Drawing.Size(131, 22)
        Me.btnEgenErk.TabIndex = 34
        Me.btnEgenErk.Text = "Lever egenerklæring"
        Me.btnEgenErk.UseVisualStyleBackColor = True
        '
        'lblKolon
        '
        Me.lblKolon.AutoSize = True
        Me.lblKolon.Location = New System.Drawing.Point(167, 222)
        Me.lblKolon.Name = "lblKolon"
        Me.lblKolon.Size = New System.Drawing.Size(10, 13)
        Me.lblKolon.TabIndex = 30
        Me.lblKolon.Text = ":"
        '
        'lblKlokkeslett
        '
        Me.lblKlokkeslett.AutoSize = True
        Me.lblKlokkeslett.Location = New System.Drawing.Point(56, 222)
        Me.lblKlokkeslett.Name = "lblKlokkeslett"
        Me.lblKlokkeslett.Size = New System.Drawing.Size(62, 13)
        Me.lblKlokkeslett.TabIndex = 29
        Me.lblKlokkeslett.Text = "Klokkeslett:"
        '
        'cmbMin
        '
        Me.cmbMin.FormattingEnabled = True
        Me.cmbMin.Items.AddRange(New Object() {"00", "15", "30", "45"})
        Me.cmbMin.Location = New System.Drawing.Point(183, 219)
        Me.cmbMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbMin.Name = "cmbMin"
        Me.cmbMin.Size = New System.Drawing.Size(37, 21)
        Me.cmbMin.TabIndex = 28
        '
        'cmbTime
        '
        Me.cmbTime.FormattingEnabled = True
        Me.cmbTime.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.cmbTime.Location = New System.Drawing.Point(124, 219)
        Me.cmbTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbTime.Name = "cmbTime"
        Me.cmbTime.Size = New System.Drawing.Size(41, 21)
        Me.cmbTime.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 400)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(746, 65)
        Me.Panel3.TabIndex = 25
        '
        'btnEndrePw
        '
        Me.btnEndrePw.Location = New System.Drawing.Point(513, 12)
        Me.btnEndrePw.Name = "btnEndrePw"
        Me.btnEndrePw.Size = New System.Drawing.Size(104, 23)
        Me.btnEndrePw.TabIndex = 22
        Me.btnEndrePw.Text = "Endre passord"
        Me.btnEndrePw.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.btnLoggUt)
        Me.Panel2.Controls.Add(Me.btnEndrePw)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 55)
        Me.Panel2.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'brukerSide
        '
        Me.ClientSize = New System.Drawing.Size(760, 554)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "brukerSide"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents mndKal1 As MonthCalendar
    Friend WithEvents lblVelgLedigTime As Label
    Friend WithEvents datoInkallLst As ListBox
    Friend WithEvents btnSokTime As Button
    Friend WithEvents lstLabsvar As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents innkallingLst As ListBox
    Friend WithEvents btnAvbestillTime As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnEndrePersinfo As Button
    Friend WithEvents btnLoggUt As Button
    Friend WithEvents fornavnTxt As TextBox
    Friend WithEvents etternavnTxt As TextBox
    Friend WithEvents telefonTxt As TextBox
    Friend WithEvents epostTxt As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblEpost As Label
    Friend WithEvents lblTlf As Label
    Friend WithEvents lblEtternavn As Label
    Friend WithEvents lblFornavn As Label
    Friend WithEvents btnEndrePw As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblPostnr As Label
    Friend WithEvents postnrTxt As TextBox
    Friend WithEvents lblAdresse As Label
    Friend WithEvents adresseTxt As TextBox
    Friend WithEvents btnLagrePInfo As Button
    Friend WithEvents btnSvarInkalling As Button
    Friend WithEvents timeLst As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbTime As ComboBox
    Friend WithEvents cmbMin As ComboBox
    Friend WithEvents lblKolon As Label
    Friend WithEvents lblKlokkeslett As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LineShape5 As PowerPacks.LineShape
    Friend WithEvents LineShape4 As PowerPacks.LineShape
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEgenErk As Button
End Class
