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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ansattSide))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblKolon = New System.Windows.Forms.Label()
        Me.cmbMin = New System.Windows.Forms.ComboBox()
        Me.cmbTime = New System.Windows.Forms.ComboBox()
        Me.lblKlokkeslett = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBehov = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnInnkalling = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tappeKalender = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstKandidater = New System.Windows.Forms.ListBox()
        Me.CBoxBlodtype = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblLevert = New System.Windows.Forms.Label()
        Me.txtLevering = New System.Windows.Forms.TextBox()
        Me.lblPlater = New System.Windows.Forms.Label()
        Me.txtPlater = New System.Windows.Forms.TextBox()
        Me.chkBekreft = New System.Windows.Forms.CheckBox()
        Me.btnRetur = New System.Windows.Forms.Button()
        Me.btnGodkjenn = New System.Windows.Forms.Button()
        Me.txtPlasma = New System.Windows.Forms.TextBox()
        Me.lblPlasma = New System.Windows.Forms.Label()
        Me.txtLegemer = New System.Windows.Forms.TextBox()
        Me.lblLegemer = New System.Windows.Forms.Label()
        Me.txtBlodtype = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstBestillinger = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblResultat = New System.Windows.Forms.Label()
        Me.cBoxProdukt = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cBoxOversikt = New System.Windows.Forms.ComboBox()
        Me.btnHurtigB = New System.Windows.Forms.Button()
        Me.btnLoggUt = New System.Windows.Forms.Button()
        Me.endrePwBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.loggutBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.svarInnLst = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(0, 75)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1004, 537)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.lblKolon)
        Me.TabPage1.Controls.Add(Me.cmbMin)
        Me.TabPage1.Controls.Add(Me.cmbTime)
        Me.TabPage1.Controls.Add(Me.lblKlokkeslett)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.btnBehov)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.btnInnkalling)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.tappeKalender)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lstKandidater)
        Me.TabPage1.Controls.Add(Me.CBoxBlodtype)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(996, 508)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Innkalling"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(415, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Kandidater"
        '
        'lblKolon
        '
        Me.lblKolon.AutoSize = True
        Me.lblKolon.Location = New System.Drawing.Point(781, 267)
        Me.lblKolon.Name = "lblKolon"
        Me.lblKolon.Size = New System.Drawing.Size(12, 17)
        Me.lblKolon.TabIndex = 28
        Me.lblKolon.Text = ":"
        '
        'cmbMin
        '
        Me.cmbMin.FormattingEnabled = True
        Me.cmbMin.Items.AddRange(New Object() {"00", "15", "30", "45"})
        Me.cmbMin.Location = New System.Drawing.Point(799, 263)
        Me.cmbMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbMin.Name = "cmbMin"
        Me.cmbMin.Size = New System.Drawing.Size(37, 24)
        Me.cmbMin.TabIndex = 27
        '
        'cmbTime
        '
        Me.cmbTime.FormattingEnabled = True
        Me.cmbTime.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.cmbTime.Location = New System.Drawing.Point(735, 263)
        Me.cmbTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbTime.Name = "cmbTime"
        Me.cmbTime.Size = New System.Drawing.Size(41, 24)
        Me.cmbTime.TabIndex = 26
        '
        'lblKlokkeslett
        '
        Me.lblKlokkeslett.AutoSize = True
        Me.lblKlokkeslett.Location = New System.Drawing.Point(649, 267)
        Me.lblKlokkeslett.Name = "lblKlokkeslett"
        Me.lblKlokkeslett.Size = New System.Drawing.Size(80, 17)
        Me.lblKlokkeslett.TabIndex = 25
        Me.lblKlokkeslett.Text = "Klokkeslett:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(75, 112)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(199, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Du trenger minst: 0 blodgivere"
        '
        'btnBehov
        '
        Me.btnBehov.Location = New System.Drawing.Point(112, 79)
        Me.btnBehov.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBehov.Name = "btnBehov"
        Me.btnBehov.Size = New System.Drawing.Size(99, 27)
        Me.btnBehov.TabIndex = 9
        Me.btnBehov.Text = "Regn ut innkallingsbehov"
        Me.btnBehov.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(112, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Literbehov:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(112, 49)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(97, 22)
        Me.TextBox1.TabIndex = 7
        '
        'btnInnkalling
        '
        Me.btnInnkalling.Location = New System.Drawing.Point(735, 310)
        Me.btnInnkalling.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInnkalling.Name = "btnInnkalling"
        Me.btnInnkalling.Size = New System.Drawing.Size(115, 48)
        Me.btnInnkalling.TabIndex = 6
        Me.btnInnkalling.Text = "Send innkalling"
        Me.btnInnkalling.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(639, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tappedato"
        '
        'tappeKalender
        '
        Me.tappeKalender.Location = New System.Drawing.Point(643, 37)
        Me.tappeKalender.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.tappeKalender.Name = "tappeKalender"
        Me.tappeKalender.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(431, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Velg blodtype:"
        '
        'lstKandidater
        '
        Me.lstKandidater.FormattingEnabled = True
        Me.lstKandidater.ItemHeight = 16
        Me.lstKandidater.Location = New System.Drawing.Point(419, 110)
        Me.lstKandidater.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstKandidater.Name = "lstKandidater"
        Me.lstKandidater.Size = New System.Drawing.Size(143, 324)
        Me.lstKandidater.TabIndex = 1
        '
        'CBoxBlodtype
        '
        Me.CBoxBlodtype.FormattingEnabled = True
        Me.CBoxBlodtype.Location = New System.Drawing.Point(435, 47)
        Me.CBoxBlodtype.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBoxBlodtype.Name = "CBoxBlodtype"
        Me.CBoxBlodtype.Size = New System.Drawing.Size(97, 24)
        Me.CBoxBlodtype.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblLevert)
        Me.TabPage2.Controls.Add(Me.txtLevering)
        Me.TabPage2.Controls.Add(Me.lblPlater)
        Me.TabPage2.Controls.Add(Me.txtPlater)
        Me.TabPage2.Controls.Add(Me.chkBekreft)
        Me.TabPage2.Controls.Add(Me.btnRetur)
        Me.TabPage2.Controls.Add(Me.btnGodkjenn)
        Me.TabPage2.Controls.Add(Me.txtPlasma)
        Me.TabPage2.Controls.Add(Me.lblPlasma)
        Me.TabPage2.Controls.Add(Me.txtLegemer)
        Me.TabPage2.Controls.Add(Me.lblLegemer)
        Me.TabPage2.Controls.Add(Me.txtBlodtype)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.lstBestillinger)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(996, 508)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Bestillinger"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblLevert
        '
        Me.lblLevert.AutoSize = True
        Me.lblLevert.Location = New System.Drawing.Point(307, 266)
        Me.lblLevert.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLevert.Name = "lblLevert"
        Me.lblLevert.Size = New System.Drawing.Size(63, 17)
        Me.lblLevert.TabIndex = 16
        Me.lblLevert.Text = "Levering"
        '
        'txtLevering
        '
        Me.txtLevering.Location = New System.Drawing.Point(309, 287)
        Me.txtLevering.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLevering.Name = "txtLevering"
        Me.txtLevering.Size = New System.Drawing.Size(132, 22)
        Me.txtLevering.TabIndex = 15
        '
        'lblPlater
        '
        Me.lblPlater.AutoSize = True
        Me.lblPlater.Location = New System.Drawing.Point(307, 210)
        Me.lblPlater.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlater.Name = "lblPlater"
        Me.lblPlater.Size = New System.Drawing.Size(45, 17)
        Me.lblPlater.TabIndex = 14
        Me.lblPlater.Text = "Plater"
        '
        'txtPlater
        '
        Me.txtPlater.Location = New System.Drawing.Point(309, 231)
        Me.txtPlater.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPlater.Name = "txtPlater"
        Me.txtPlater.Size = New System.Drawing.Size(132, 22)
        Me.txtPlater.TabIndex = 13
        '
        'chkBekreft
        '
        Me.chkBekreft.AutoSize = True
        Me.chkBekreft.Location = New System.Drawing.Point(309, 327)
        Me.chkBekreft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkBekreft.Name = "chkBekreft"
        Me.chkBekreft.Size = New System.Drawing.Size(134, 21)
        Me.chkBekreft.TabIndex = 12
        Me.chkBekreft.Text = "Bekreft bestilling"
        Me.chkBekreft.UseVisualStyleBackColor = True
        '
        'btnRetur
        '
        Me.btnRetur.Location = New System.Drawing.Point(309, 395)
        Me.btnRetur.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRetur.Name = "btnRetur"
        Me.btnRetur.Size = New System.Drawing.Size(133, 28)
        Me.btnRetur.TabIndex = 11
        Me.btnRetur.Text = "Send retur"
        Me.btnRetur.UseVisualStyleBackColor = True
        '
        'btnGodkjenn
        '
        Me.btnGodkjenn.Enabled = False
        Me.btnGodkjenn.Location = New System.Drawing.Point(309, 356)
        Me.btnGodkjenn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGodkjenn.Name = "btnGodkjenn"
        Me.btnGodkjenn.Size = New System.Drawing.Size(133, 28)
        Me.btnGodkjenn.TabIndex = 10
        Me.btnGodkjenn.Text = "Godkjenn"
        Me.btnGodkjenn.UseVisualStyleBackColor = True
        '
        'txtPlasma
        '
        Me.txtPlasma.Location = New System.Drawing.Point(309, 171)
        Me.txtPlasma.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPlasma.Name = "txtPlasma"
        Me.txtPlasma.Size = New System.Drawing.Size(132, 22)
        Me.txtPlasma.TabIndex = 8
        '
        'lblPlasma
        '
        Me.lblPlasma.AutoSize = True
        Me.lblPlasma.Location = New System.Drawing.Point(307, 150)
        Me.lblPlasma.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlasma.Name = "lblPlasma"
        Me.lblPlasma.Size = New System.Drawing.Size(54, 17)
        Me.lblPlasma.TabIndex = 7
        Me.lblPlasma.Text = "Plasma"
        '
        'txtLegemer
        '
        Me.txtLegemer.Location = New System.Drawing.Point(309, 113)
        Me.txtLegemer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLegemer.Name = "txtLegemer"
        Me.txtLegemer.Size = New System.Drawing.Size(132, 22)
        Me.txtLegemer.TabIndex = 6
        '
        'lblLegemer
        '
        Me.lblLegemer.AutoSize = True
        Me.lblLegemer.Location = New System.Drawing.Point(307, 92)
        Me.lblLegemer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLegemer.Name = "lblLegemer"
        Me.lblLegemer.Size = New System.Drawing.Size(64, 17)
        Me.lblLegemer.TabIndex = 5
        Me.lblLegemer.Text = "Legemer"
        '
        'txtBlodtype
        '
        Me.txtBlodtype.Location = New System.Drawing.Point(309, 57)
        Me.txtBlodtype.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBlodtype.Name = "txtBlodtype"
        Me.txtBlodtype.Size = New System.Drawing.Size(132, 22)
        Me.txtBlodtype.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(307, 36)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Blodtype:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Alle bestillinger"
        '
        'lstBestillinger
        '
        Me.lstBestillinger.FormattingEnabled = True
        Me.lstBestillinger.ItemHeight = 16
        Me.lstBestillinger.Location = New System.Drawing.Point(45, 50)
        Me.lstBestillinger.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstBestillinger.Name = "lstBestillinger"
        Me.lstBestillinger.Size = New System.Drawing.Size(244, 372)
        Me.lstBestillinger.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lblResultat)
        Me.TabPage3.Controls.Add(Me.cBoxProdukt)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.ListBox1)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.cBoxOversikt)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage3.Size = New System.Drawing.Size(996, 508)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Oversikt blodbank"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lblResultat
        '
        Me.lblResultat.AutoSize = True
        Me.lblResultat.Location = New System.Drawing.Point(417, 46)
        Me.lblResultat.Name = "lblResultat"
        Me.lblResultat.Size = New System.Drawing.Size(0, 17)
        Me.lblResultat.TabIndex = 29
        '
        'cBoxProdukt
        '
        Me.cBoxProdukt.FormattingEnabled = True
        Me.cBoxProdukt.Items.AddRange(New Object() {"blodplasma", "blodlegemer", "blodplater"})
        Me.cBoxProdukt.Location = New System.Drawing.Point(233, 42)
        Me.cBoxProdukt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cBoxProdukt.Name = "cBoxProdukt"
        Me.cBoxProdukt.Size = New System.Drawing.Size(160, 24)
        Me.cBoxProdukt.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(229, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 17)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Blodprodukt"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(35, 116)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(509, 308)
        Me.ListBox1.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 85)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 17)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Full oversikt"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(417, 20)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Resultat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 21)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Blodtype"
        '
        'cBoxOversikt
        '
        Me.cBoxOversikt.FormattingEnabled = True
        Me.cBoxOversikt.Items.AddRange(New Object() {"O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-"})
        Me.cBoxOversikt.Location = New System.Drawing.Point(35, 42)
        Me.cBoxOversikt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cBoxOversikt.Name = "cBoxOversikt"
        Me.cBoxOversikt.Size = New System.Drawing.Size(160, 24)
        Me.cBoxOversikt.TabIndex = 0
        '
        'btnHurtigB
        '
        Me.btnHurtigB.Location = New System.Drawing.Point(445, 18)
        Me.btnHurtigB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHurtigB.Name = "btnHurtigB"
        Me.btnHurtigB.Size = New System.Drawing.Size(123, 39)
        Me.btnHurtigB.TabIndex = 29
        Me.btnHurtigB.Text = "Hurtigbestilling"
        Me.btnHurtigB.UseVisualStyleBackColor = True
        '
        'btnLoggUt
        '
        Me.btnLoggUt.Location = New System.Drawing.Point(881, 17)
        Me.btnLoggUt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoggUt.Name = "btnLoggUt"
        Me.btnLoggUt.Size = New System.Drawing.Size(101, 39)
        Me.btnLoggUt.TabIndex = 14
        Me.btnLoggUt.Text = "Logg ut"
        Me.btnLoggUt.UseVisualStyleBackColor = True
        '
        'endrePwBtn
        '
        Me.endrePwBtn.Location = New System.Drawing.Point(12, 18)
        Me.endrePwBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.endrePwBtn.Name = "endrePwBtn"
        Me.endrePwBtn.Size = New System.Drawing.Size(121, 39)
        Me.endrePwBtn.TabIndex = 13
        Me.endrePwBtn.Text = "Endre passord"
        Me.endrePwBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'loggutBtn
        '
        Me.loggutBtn.Location = New System.Drawing.Point(845, 15)
        Me.loggutBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.loggutBtn.Name = "loggutBtn"
        Me.loggutBtn.Size = New System.Drawing.Size(137, 28)
        Me.loggutBtn.TabIndex = 12
        Me.loggutBtn.Text = "Logg ut"
        Me.loggutBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.loggutBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1004, 68)
        Me.Panel2.TabIndex = 20
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnHurtigB)
        Me.Panel3.Controls.Add(Me.endrePwBtn)
        Me.Panel3.Controls.Add(Me.btnLoggUt)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 620)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1004, 70)
        Me.Panel3.TabIndex = 26
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(Me.svarInnLst)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(996, 508)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Svar innkallinger"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'svarInnLst
        '
        Me.svarInnLst.FormattingEnabled = True
        Me.svarInnLst.ItemHeight = 16
        Me.svarInnLst.Location = New System.Drawing.Point(74, 23)
        Me.svarInnLst.Name = "svarInnLst"
        Me.svarInnLst.Size = New System.Drawing.Size(176, 292)
        Me.svarInnLst.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(281, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 58)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Behandle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ansattSide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 690)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ansattSide"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ansattSide"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnInnkalling As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tappeKalender As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents lstKandidater As ListBox
    Friend WithEvents CBoxBlodtype As ComboBox
    Friend WithEvents btnGodkjenn As Button
    Friend WithEvents txtPlasma As TextBox
    Friend WithEvents lblPlasma As Label
    Friend WithEvents txtLegemer As TextBox
    Friend WithEvents lblLegemer As Label
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
    Friend WithEvents Label10 As Label
    Friend WithEvents cBoxOversikt As ComboBox
    Friend WithEvents endrePwBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents loggutBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents cBoxProdukt As ComboBox
    Friend WithEvents lblResultat As Label
    Friend WithEvents lblKolon As Label
    Friend WithEvents cmbMin As ComboBox
    Friend WithEvents cmbTime As ComboBox
    Friend WithEvents lblKlokkeslett As Label
    Friend WithEvents btnHurtigB As Button
    Friend WithEvents btnLoggUt As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblLevert As Label
    Friend WithEvents txtLevering As TextBox
    Friend WithEvents lblPlater As Label
    Friend WithEvents txtPlater As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents svarInnLst As ListBox
End Class
