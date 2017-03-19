<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class egenerklaering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(egenerklaering))
        Me.lblEgenFyllut = New System.Windows.Forms.Label()
        Me.ChkSomFor = New System.Windows.Forms.CheckBox()
        Me.txtEgenFornavn = New System.Windows.Forms.TextBox()
        Me.txtEgenEtternavn = New System.Windows.Forms.TextBox()
        Me.txtEgenPerson_nr = New System.Windows.Forms.TextBox()
        Me.lblEgenFornavn = New System.Windows.Forms.Label()
        Me.lblEgenEtternavn = New System.Windows.Forms.Label()
        Me.lblEgenPerson_nr = New System.Windows.Forms.Label()
        Me.lblEgenPrivatadresse = New System.Windows.Forms.Label()
        Me.txtEgenPrivatadresse = New System.Windows.Forms.TextBox()
        Me.lblEgenPost_nr = New System.Windows.Forms.Label()
        Me.txtEgenPost_nr = New System.Windows.Forms.TextBox()
        Me.lblEgenTlf = New System.Windows.Forms.Label()
        Me.txtEgenTlf = New System.Windows.Forms.TextBox()
        Me.lblEgenEpost = New System.Windows.Forms.Label()
        Me.txtEgenEpost = New System.Windows.Forms.TextBox()
        Me.lblEgenTillatEpost = New System.Windows.Forms.Label()
        Me.radEgenEpostJa = New System.Windows.Forms.RadioButton()
        Me.radEgenEpostNei = New System.Windows.Forms.RadioButton()
        Me.lblEgenTillatSMS = New System.Windows.Forms.Label()
        Me.radEgenSMSNei = New System.Windows.Forms.RadioButton()
        Me.radEgenSMSJa = New System.Windows.Forms.RadioButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnEgenNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEgenFyllut
        '
        Me.lblEgenFyllut.AutoSize = True
        Me.lblEgenFyllut.Location = New System.Drawing.Point(16, 13)
        Me.lblEgenFyllut.Name = "lblEgenFyllut"
        Me.lblEgenFyllut.Size = New System.Drawing.Size(91, 13)
        Me.lblEgenFyllut.TabIndex = 0
        Me.lblEgenFyllut.Text = "Fyll ut alle feltene:"
        '
        'ChkSomFor
        '
        Me.ChkSomFor.AutoSize = True
        Me.ChkSomFor.Location = New System.Drawing.Point(506, 9)
        Me.ChkSomFor.Name = "ChkSomFor"
        Me.ChkSomFor.Size = New System.Drawing.Size(62, 17)
        Me.ChkSomFor.TabIndex = 1
        Me.ChkSomFor.Text = "Som før"
        Me.ChkSomFor.UseVisualStyleBackColor = True
        '
        'txtEgenFornavn
        '
        Me.txtEgenFornavn.Location = New System.Drawing.Point(16, 61)
        Me.txtEgenFornavn.Name = "txtEgenFornavn"
        Me.txtEgenFornavn.Size = New System.Drawing.Size(100, 20)
        Me.txtEgenFornavn.TabIndex = 2
        '
        'txtEgenEtternavn
        '
        Me.txtEgenEtternavn.Location = New System.Drawing.Point(122, 61)
        Me.txtEgenEtternavn.Name = "txtEgenEtternavn"
        Me.txtEgenEtternavn.Size = New System.Drawing.Size(100, 20)
        Me.txtEgenEtternavn.TabIndex = 3
        '
        'txtEgenPerson_nr
        '
        Me.txtEgenPerson_nr.Location = New System.Drawing.Point(228, 61)
        Me.txtEgenPerson_nr.Name = "txtEgenPerson_nr"
        Me.txtEgenPerson_nr.Size = New System.Drawing.Size(100, 20)
        Me.txtEgenPerson_nr.TabIndex = 4
        '
        'lblEgenFornavn
        '
        Me.lblEgenFornavn.AutoSize = True
        Me.lblEgenFornavn.Location = New System.Drawing.Point(16, 42)
        Me.lblEgenFornavn.Name = "lblEgenFornavn"
        Me.lblEgenFornavn.Size = New System.Drawing.Size(46, 13)
        Me.lblEgenFornavn.TabIndex = 5
        Me.lblEgenFornavn.Text = "Fornavn"
        '
        'lblEgenEtternavn
        '
        Me.lblEgenEtternavn.AutoSize = True
        Me.lblEgenEtternavn.Location = New System.Drawing.Point(119, 45)
        Me.lblEgenEtternavn.Name = "lblEgenEtternavn"
        Me.lblEgenEtternavn.Size = New System.Drawing.Size(53, 13)
        Me.lblEgenEtternavn.TabIndex = 6
        Me.lblEgenEtternavn.Text = "Etternavn"
        '
        'lblEgenPerson_nr
        '
        Me.lblEgenPerson_nr.AutoSize = True
        Me.lblEgenPerson_nr.Location = New System.Drawing.Point(225, 42)
        Me.lblEgenPerson_nr.Name = "lblEgenPerson_nr"
        Me.lblEgenPerson_nr.Size = New System.Drawing.Size(77, 13)
        Me.lblEgenPerson_nr.TabIndex = 7
        Me.lblEgenPerson_nr.Text = "Personnummer"
        '
        'lblEgenPrivatadresse
        '
        Me.lblEgenPrivatadresse.AutoSize = True
        Me.lblEgenPrivatadresse.Location = New System.Drawing.Point(16, 84)
        Me.lblEgenPrivatadresse.Name = "lblEgenPrivatadresse"
        Me.lblEgenPrivatadresse.Size = New System.Drawing.Size(71, 13)
        Me.lblEgenPrivatadresse.TabIndex = 8
        Me.lblEgenPrivatadresse.Text = "Privatadresse"
        '
        'txtEgenPrivatadresse
        '
        Me.txtEgenPrivatadresse.Location = New System.Drawing.Point(16, 100)
        Me.txtEgenPrivatadresse.Name = "txtEgenPrivatadresse"
        Me.txtEgenPrivatadresse.Size = New System.Drawing.Size(100, 20)
        Me.txtEgenPrivatadresse.TabIndex = 5
        '
        'lblEgenPost_nr
        '
        Me.lblEgenPost_nr.AutoSize = True
        Me.lblEgenPost_nr.Location = New System.Drawing.Point(119, 84)
        Me.lblEgenPost_nr.Name = "lblEgenPost_nr"
        Me.lblEgenPost_nr.Size = New System.Drawing.Size(65, 13)
        Me.lblEgenPost_nr.TabIndex = 10
        Me.lblEgenPost_nr.Text = "Postnummer"
        '
        'txtEgenPost_nr
        '
        Me.txtEgenPost_nr.Location = New System.Drawing.Point(122, 100)
        Me.txtEgenPost_nr.Name = "txtEgenPost_nr"
        Me.txtEgenPost_nr.Size = New System.Drawing.Size(100, 20)
        Me.txtEgenPost_nr.TabIndex = 6
        '
        'lblEgenTlf
        '
        Me.lblEgenTlf.AutoSize = True
        Me.lblEgenTlf.Location = New System.Drawing.Point(228, 84)
        Me.lblEgenTlf.Name = "lblEgenTlf"
        Me.lblEgenTlf.Size = New System.Drawing.Size(51, 13)
        Me.lblEgenTlf.TabIndex = 12
        Me.lblEgenTlf.Text = "Tlf privat:"
        '
        'txtEgenTlf
        '
        Me.txtEgenTlf.Location = New System.Drawing.Point(228, 100)
        Me.txtEgenTlf.Name = "txtEgenTlf"
        Me.txtEgenTlf.Size = New System.Drawing.Size(100, 20)
        Me.txtEgenTlf.TabIndex = 13
        '
        'lblEgenEpost
        '
        Me.lblEgenEpost.AutoSize = True
        Me.lblEgenEpost.Location = New System.Drawing.Point(333, 84)
        Me.lblEgenEpost.Name = "lblEgenEpost"
        Me.lblEgenEpost.Size = New System.Drawing.Size(37, 13)
        Me.lblEgenEpost.TabIndex = 14
        Me.lblEgenEpost.Text = "Epost:"
        '
        'txtEgenEpost
        '
        Me.txtEgenEpost.Location = New System.Drawing.Point(336, 100)
        Me.txtEgenEpost.Name = "txtEgenEpost"
        Me.txtEgenEpost.Size = New System.Drawing.Size(100, 20)
        Me.txtEgenEpost.TabIndex = 15
        '
        'lblEgenTillatEpost
        '
        Me.lblEgenTillatEpost.AutoSize = True
        Me.lblEgenTillatEpost.Location = New System.Drawing.Point(13, 139)
        Me.lblEgenTillatEpost.Name = "lblEgenTillatEpost"
        Me.lblEgenTillatEpost.Size = New System.Drawing.Size(505, 13)
        Me.lblEgenTillatEpost.TabIndex = 16
        Me.lblEgenTillatEpost.Text = "Tillater du at blodbanken sender deg epos (innkalling, timepåminning, eventuelt a" &
    "nnen viktig informasjon)?"
        '
        'radEgenEpostJa
        '
        Me.radEgenEpostJa.AutoSize = True
        Me.radEgenEpostJa.Location = New System.Drawing.Point(16, 155)
        Me.radEgenEpostJa.Name = "radEgenEpostJa"
        Me.radEgenEpostJa.Size = New System.Drawing.Size(33, 17)
        Me.radEgenEpostJa.TabIndex = 17
        Me.radEgenEpostJa.TabStop = True
        Me.radEgenEpostJa.Text = "ja"
        Me.radEgenEpostJa.UseVisualStyleBackColor = True
        '
        'radEgenEpostNei
        '
        Me.radEgenEpostNei.AutoSize = True
        Me.radEgenEpostNei.Location = New System.Drawing.Point(48, 155)
        Me.radEgenEpostNei.Name = "radEgenEpostNei"
        Me.radEgenEpostNei.Size = New System.Drawing.Size(39, 17)
        Me.radEgenEpostNei.TabIndex = 18
        Me.radEgenEpostNei.TabStop = True
        Me.radEgenEpostNei.Text = "nei"
        Me.radEgenEpostNei.UseVisualStyleBackColor = True
        '
        'lblEgenTillatSMS
        '
        Me.lblEgenTillatSMS.AutoSize = True
        Me.lblEgenTillatSMS.Location = New System.Drawing.Point(13, 179)
        Me.lblEgenTillatSMS.Name = "lblEgenTillatSMS"
        Me.lblEgenTillatSMS.Size = New System.Drawing.Size(505, 13)
        Me.lblEgenTillatSMS.TabIndex = 19
        Me.lblEgenTillatSMS.Text = "Tillater du at blodbanken sender deg SMS (innkalling, timepåminning, eventuelt an" &
    "nen viktig informasjon)?"
        '
        'radEgenSMSNei
        '
        Me.radEgenSMSNei.AutoSize = True
        Me.radEgenSMSNei.Location = New System.Drawing.Point(48, 195)
        Me.radEgenSMSNei.Name = "radEgenSMSNei"
        Me.radEgenSMSNei.Size = New System.Drawing.Size(39, 17)
        Me.radEgenSMSNei.TabIndex = 21
        Me.radEgenSMSNei.TabStop = True
        Me.radEgenSMSNei.Text = "nei"
        Me.radEgenSMSNei.UseVisualStyleBackColor = True
        '
        'radEgenSMSJa
        '
        Me.radEgenSMSJa.AutoSize = True
        Me.radEgenSMSJa.Location = New System.Drawing.Point(16, 195)
        Me.radEgenSMSJa.Name = "radEgenSMSJa"
        Me.radEgenSMSJa.Size = New System.Drawing.Size(33, 17)
        Me.radEgenSMSJa.TabIndex = 20
        Me.radEgenSMSJa.TabStop = True
        Me.radEgenSMSJa.Text = "ja"
        Me.radEgenSMSJa.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(16, 219)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(552, 145)
        Me.RichTextBox1.TabIndex = 22
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'btnEgenNext
        '
        Me.btnEgenNext.Location = New System.Drawing.Point(322, 368)
        Me.btnEgenNext.Name = "btnEgenNext"
        Me.btnEgenNext.Size = New System.Drawing.Size(237, 23)
        Me.btnEgenNext.TabIndex = 23
        Me.btnEgenNext.Text = "Jeg har lest og vil vidre til neste side."
        Me.btnEgenNext.UseVisualStyleBackColor = True
        '
        'egenerklaering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 403)
        Me.Controls.Add(Me.btnEgenNext)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.radEgenSMSNei)
        Me.Controls.Add(Me.radEgenSMSJa)
        Me.Controls.Add(Me.lblEgenTillatSMS)
        Me.Controls.Add(Me.radEgenEpostNei)
        Me.Controls.Add(Me.radEgenEpostJa)
        Me.Controls.Add(Me.lblEgenTillatEpost)
        Me.Controls.Add(Me.txtEgenEpost)
        Me.Controls.Add(Me.lblEgenEpost)
        Me.Controls.Add(Me.txtEgenTlf)
        Me.Controls.Add(Me.lblEgenTlf)
        Me.Controls.Add(Me.txtEgenPost_nr)
        Me.Controls.Add(Me.lblEgenPost_nr)
        Me.Controls.Add(Me.txtEgenPrivatadresse)
        Me.Controls.Add(Me.lblEgenPrivatadresse)
        Me.Controls.Add(Me.lblEgenPerson_nr)
        Me.Controls.Add(Me.lblEgenEtternavn)
        Me.Controls.Add(Me.lblEgenFornavn)
        Me.Controls.Add(Me.txtEgenPerson_nr)
        Me.Controls.Add(Me.txtEgenEtternavn)
        Me.Controls.Add(Me.txtEgenFornavn)
        Me.Controls.Add(Me.ChkSomFor)
        Me.Controls.Add(Me.lblEgenFyllut)
        Me.Name = "egenerklaering"
        Me.Text = "egenerklaering"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEgenFyllut As Label
    Friend WithEvents ChkSomFor As CheckBox
    Friend WithEvents txtEgenFornavn As TextBox
    Friend WithEvents txtEgenEtternavn As TextBox
    Friend WithEvents txtEgenPerson_nr As TextBox
    Friend WithEvents lblEgenFornavn As Label
    Friend WithEvents lblEgenEtternavn As Label
    Friend WithEvents lblEgenPerson_nr As Label
    Friend WithEvents lblEgenPrivatadresse As Label
    Friend WithEvents txtEgenPrivatadresse As TextBox
    Friend WithEvents lblEgenPost_nr As Label
    Friend WithEvents txtEgenPost_nr As TextBox
    Friend WithEvents lblEgenTlf As Label
    Friend WithEvents txtEgenTlf As TextBox
    Friend WithEvents lblEgenEpost As Label
    Friend WithEvents txtEgenEpost As TextBox
    Friend WithEvents lblEgenTillatEpost As Label
    Friend WithEvents radEgenEpostJa As RadioButton
    Friend WithEvents radEgenEpostNei As RadioButton
    Friend WithEvents lblEgenTillatSMS As Label
    Friend WithEvents radEgenSMSNei As RadioButton
    Friend WithEvents radEgenSMSJa As RadioButton
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btnEgenNext As Button
End Class
