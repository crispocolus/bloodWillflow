<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrerForm
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
        Me.epostTxt = New System.Windows.Forms.TextBox()
        Me.fornavnTxt = New System.Windows.Forms.TextBox()
        Me.etternavnTxt = New System.Windows.Forms.TextBox()
        Me.tlfTxt = New System.Windows.Forms.TextBox()
        Me.lblEpost = New System.Windows.Forms.Label()
        Me.lblFornavn = New System.Windows.Forms.Label()
        Me.lblEtternavn = New System.Windows.Forms.Label()
        Me.lblTelefon = New System.Windows.Forms.Label()
        Me.btnRegistrer = New System.Windows.Forms.Button()
        Me.lblPnummer = New System.Windows.Forms.Label()
        Me.pnummerTxt = New System.Windows.Forms.TextBox()
        Me.lblBekreftPW = New System.Windows.Forms.Label()
        Me.lblPassord = New System.Windows.Forms.Label()
        Me.passordcTxt = New System.Windows.Forms.TextBox()
        Me.passordTxt = New System.Windows.Forms.TextBox()
        Me.chkJegHarLest = New System.Windows.Forms.CheckBox()
        Me.lblJegHar = New System.Windows.Forms.Label()
        Me.adresseTxt = New System.Windows.Forms.TextBox()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.postnrTxt = New System.Windows.Forms.TextBox()
        Me.lblPostnr = New System.Windows.Forms.Label()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'epostTxt
        '
        Me.epostTxt.Location = New System.Drawing.Point(38, 156)
        Me.epostTxt.Name = "epostTxt"
        Me.epostTxt.Size = New System.Drawing.Size(100, 20)
        Me.epostTxt.TabIndex = 4
        '
        'fornavnTxt
        '
        Me.fornavnTxt.Location = New System.Drawing.Point(37, 25)
        Me.fornavnTxt.Name = "fornavnTxt"
        Me.fornavnTxt.Size = New System.Drawing.Size(100, 20)
        Me.fornavnTxt.TabIndex = 1
        '
        'etternavnTxt
        '
        Me.etternavnTxt.Location = New System.Drawing.Point(37, 67)
        Me.etternavnTxt.Name = "etternavnTxt"
        Me.etternavnTxt.Size = New System.Drawing.Size(100, 20)
        Me.etternavnTxt.TabIndex = 2
        '
        'tlfTxt
        '
        Me.tlfTxt.Location = New System.Drawing.Point(38, 200)
        Me.tlfTxt.Name = "tlfTxt"
        Me.tlfTxt.Size = New System.Drawing.Size(100, 20)
        Me.tlfTxt.TabIndex = 5
        '
        'lblEpost
        '
        Me.lblEpost.AutoSize = True
        Me.lblEpost.BackColor = System.Drawing.Color.Transparent
        Me.lblEpost.ForeColor = System.Drawing.SystemColors.Control
        Me.lblEpost.Location = New System.Drawing.Point(34, 140)
        Me.lblEpost.Name = "lblEpost"
        Me.lblEpost.Size = New System.Drawing.Size(34, 13)
        Me.lblEpost.TabIndex = 5
        Me.lblEpost.Text = "Epost"
        '
        'lblFornavn
        '
        Me.lblFornavn.AutoSize = True
        Me.lblFornavn.BackColor = System.Drawing.Color.Transparent
        Me.lblFornavn.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFornavn.Location = New System.Drawing.Point(34, 9)
        Me.lblFornavn.Name = "lblFornavn"
        Me.lblFornavn.Size = New System.Drawing.Size(46, 13)
        Me.lblFornavn.TabIndex = 6
        Me.lblFornavn.Text = "Fornavn"
        '
        'lblEtternavn
        '
        Me.lblEtternavn.AutoSize = True
        Me.lblEtternavn.BackColor = System.Drawing.Color.Transparent
        Me.lblEtternavn.ForeColor = System.Drawing.SystemColors.Control
        Me.lblEtternavn.Location = New System.Drawing.Point(34, 51)
        Me.lblEtternavn.Name = "lblEtternavn"
        Me.lblEtternavn.Size = New System.Drawing.Size(53, 13)
        Me.lblEtternavn.TabIndex = 7
        Me.lblEtternavn.Text = "Etternavn"
        '
        'lblTelefon
        '
        Me.lblTelefon.AutoSize = True
        Me.lblTelefon.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefon.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTelefon.Location = New System.Drawing.Point(34, 183)
        Me.lblTelefon.Name = "lblTelefon"
        Me.lblTelefon.Size = New System.Drawing.Size(43, 13)
        Me.lblTelefon.TabIndex = 8
        Me.lblTelefon.Text = "Telefon"
        '
        'btnRegistrer
        '
        Me.btnRegistrer.Enabled = False
        Me.btnRegistrer.Location = New System.Drawing.Point(177, 261)
        Me.btnRegistrer.Name = "btnRegistrer"
        Me.btnRegistrer.Size = New System.Drawing.Size(112, 36)
        Me.btnRegistrer.TabIndex = 11
        Me.btnRegistrer.Text = "Registrer"
        Me.btnRegistrer.UseVisualStyleBackColor = True
        '
        'lblPnummer
        '
        Me.lblPnummer.AutoSize = True
        Me.lblPnummer.BackColor = System.Drawing.Color.Transparent
        Me.lblPnummer.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPnummer.Location = New System.Drawing.Point(34, 90)
        Me.lblPnummer.Name = "lblPnummer"
        Me.lblPnummer.Size = New System.Drawing.Size(80, 13)
        Me.lblPnummer.TabIndex = 12
        Me.lblPnummer.Text = "Personnummer:"
        '
        'pnummerTxt
        '
        Me.pnummerTxt.Location = New System.Drawing.Point(38, 106)
        Me.pnummerTxt.Name = "pnummerTxt"
        Me.pnummerTxt.Size = New System.Drawing.Size(100, 20)
        Me.pnummerTxt.TabIndex = 3
        '
        'lblBekreftPW
        '
        Me.lblBekreftPW.AutoSize = True
        Me.lblBekreftPW.BackColor = System.Drawing.Color.Transparent
        Me.lblBekreftPW.ForeColor = System.Drawing.SystemColors.Control
        Me.lblBekreftPW.Location = New System.Drawing.Point(174, 183)
        Me.lblBekreftPW.Name = "lblBekreftPW"
        Me.lblBekreftPW.Size = New System.Drawing.Size(84, 13)
        Me.lblBekreftPW.TabIndex = 16
        Me.lblBekreftPW.Text = "Bekreft passord:"
        '
        'lblPassord
        '
        Me.lblPassord.AutoSize = True
        Me.lblPassord.BackColor = System.Drawing.Color.Transparent
        Me.lblPassord.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPassord.Location = New System.Drawing.Point(174, 140)
        Me.lblPassord.Name = "lblPassord"
        Me.lblPassord.Size = New System.Drawing.Size(45, 13)
        Me.lblPassord.TabIndex = 15
        Me.lblPassord.Text = "Passord"
        '
        'passordcTxt
        '
        Me.passordcTxt.Location = New System.Drawing.Point(177, 200)
        Me.passordcTxt.Name = "passordcTxt"
        Me.passordcTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passordcTxt.Size = New System.Drawing.Size(100, 20)
        Me.passordcTxt.TabIndex = 9
        '
        'passordTxt
        '
        Me.passordTxt.Location = New System.Drawing.Point(177, 156)
        Me.passordTxt.Name = "passordTxt"
        Me.passordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passordTxt.Size = New System.Drawing.Size(100, 20)
        Me.passordTxt.TabIndex = 8
        '
        'chkJegHarLest
        '
        Me.chkJegHarLest.AutoSize = True
        Me.chkJegHarLest.Location = New System.Drawing.Point(38, 234)
        Me.chkJegHarLest.Name = "chkJegHarLest"
        Me.chkJegHarLest.Size = New System.Drawing.Size(15, 14)
        Me.chkJegHarLest.TabIndex = 10
        Me.chkJegHarLest.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkJegHarLest.UseVisualStyleBackColor = True
        '
        'lblJegHar
        '
        Me.lblJegHar.AutoSize = True
        Me.lblJegHar.BackColor = System.Drawing.Color.Transparent
        Me.lblJegHar.ForeColor = System.Drawing.SystemColors.Control
        Me.lblJegHar.Location = New System.Drawing.Point(66, 234)
        Me.lblJegHar.Name = "lblJegHar"
        Me.lblJegHar.Size = New System.Drawing.Size(247, 13)
        Me.lblJegHar.TabIndex = 18
        Me.lblJegHar.Text = "Jeg har lest og godkjent brukervilkår for registrering"
        '
        'adresseTxt
        '
        Me.adresseTxt.Location = New System.Drawing.Point(177, 25)
        Me.adresseTxt.Name = "adresseTxt"
        Me.adresseTxt.Size = New System.Drawing.Size(100, 20)
        Me.adresseTxt.TabIndex = 6
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.BackColor = System.Drawing.Color.Transparent
        Me.lblAdresse.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAdresse.Location = New System.Drawing.Point(174, 9)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(45, 13)
        Me.lblAdresse.TabIndex = 20
        Me.lblAdresse.Text = "Adresse"
        '
        'postnrTxt
        '
        Me.postnrTxt.Location = New System.Drawing.Point(177, 67)
        Me.postnrTxt.Name = "postnrTxt"
        Me.postnrTxt.Size = New System.Drawing.Size(100, 20)
        Me.postnrTxt.TabIndex = 7
        '
        'lblPostnr
        '
        Me.lblPostnr.AutoSize = True
        Me.lblPostnr.BackColor = System.Drawing.Color.Transparent
        Me.lblPostnr.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPostnr.Location = New System.Drawing.Point(174, 51)
        Me.lblPostnr.Name = "lblPostnr"
        Me.lblPostnr.Size = New System.Drawing.Size(71, 13)
        Me.lblPostnr.TabIndex = 22
        Me.lblPostnr.Text = "Postnunmmer"
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(31, 261)
        Me.btnTilbake.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(106, 36)
        Me.btnTilbake.TabIndex = 23
        Me.btnTilbake.Text = "Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'RegistrerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(325, 325)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.lblPostnr)
        Me.Controls.Add(Me.postnrTxt)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.adresseTxt)
        Me.Controls.Add(Me.lblJegHar)
        Me.Controls.Add(Me.chkJegHarLest)
        Me.Controls.Add(Me.lblBekreftPW)
        Me.Controls.Add(Me.lblPassord)
        Me.Controls.Add(Me.passordcTxt)
        Me.Controls.Add(Me.passordTxt)
        Me.Controls.Add(Me.lblPnummer)
        Me.Controls.Add(Me.pnummerTxt)
        Me.Controls.Add(Me.btnRegistrer)
        Me.Controls.Add(Me.lblTelefon)
        Me.Controls.Add(Me.lblEtternavn)
        Me.Controls.Add(Me.lblFornavn)
        Me.Controls.Add(Me.lblEpost)
        Me.Controls.Add(Me.tlfTxt)
        Me.Controls.Add(Me.etternavnTxt)
        Me.Controls.Add(Me.fornavnTxt)
        Me.Controls.Add(Me.epostTxt)
        Me.Name = "RegistrerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RegistrerForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents epostTxt As TextBox
    Friend WithEvents fornavnTxt As TextBox
    Friend WithEvents etternavnTxt As TextBox
    Friend WithEvents tlfTxt As TextBox
    Friend WithEvents lblEpost As Label
    Friend WithEvents lblFornavn As Label
    Friend WithEvents lblEtternavn As Label
    Friend WithEvents lblTelefon As Label
    Friend WithEvents btnRegistrer As Button
    Friend WithEvents lblPnummer As Label
    Friend WithEvents pnummerTxt As TextBox
    Friend WithEvents lblBekreftPW As Label
    Friend WithEvents lblPassord As Label
    Friend WithEvents passordcTxt As TextBox
    Friend WithEvents passordTxt As TextBox
    Friend WithEvents chkJegHarLest As CheckBox
    Friend WithEvents lblJegHar As Label
    Friend WithEvents adresseTxt As TextBox
    Friend WithEvents lblAdresse As Label
    Friend WithEvents postnrTxt As TextBox
    Friend WithEvents lblPostnr As Label
    Friend WithEvents btnTilbake As Button
End Class
