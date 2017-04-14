<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hurtigBestilling
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
        Me.lstBGTlf = New System.Windows.Forms.ListBox()
        Me.lblHurtig1 = New System.Windows.Forms.Label()
        Me.lblHurtigBType = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstBGTlf
        '
        Me.lstBGTlf.FormattingEnabled = True
        Me.lstBGTlf.ItemHeight = 16
        Me.lstBGTlf.Location = New System.Drawing.Point(65, 67)
        Me.lstBGTlf.Name = "lstBGTlf"
        Me.lstBGTlf.Size = New System.Drawing.Size(321, 324)
        Me.lstBGTlf.TabIndex = 0
        '
        'lblHurtig1
        '
        Me.lblHurtig1.AutoSize = True
        Me.lblHurtig1.Location = New System.Drawing.Point(157, 25)
        Me.lblHurtig1.Name = "lblHurtig1"
        Me.lblHurtig1.Size = New System.Drawing.Size(67, 17)
        Me.lblHurtig1.TabIndex = 1
        Me.lblHurtig1.Text = "Blodtype:"
        '
        'lblHurtigBType
        '
        Me.lblHurtigBType.AutoSize = True
        Me.lblHurtigBType.Location = New System.Drawing.Point(230, 25)
        Me.lblHurtigBType.Name = "lblHurtigBType"
        Me.lblHurtigBType.Size = New System.Drawing.Size(0, 17)
        Me.lblHurtigBType.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(184, 411)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Lukk"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'hurtigBestilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 446)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblHurtigBType)
        Me.Controls.Add(Me.lblHurtig1)
        Me.Controls.Add(Me.lstBGTlf)
        Me.Name = "hurtigBestilling"
        Me.Text = "Hurtigbestilling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBGTlf As ListBox
    Friend WithEvents lblHurtig1 As Label
    Friend WithEvents lblHurtigBType As Label
    Friend WithEvents btnClose As Button
End Class
