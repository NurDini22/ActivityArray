<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lbl
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
        Me.lblNamaHari = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnPapar = New System.Windows.Forms.Button()
        Me.lblNamaHariInitialize = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNamaHari
        '
        Me.lblNamaHari.AutoSize = True
        Me.lblNamaHari.Location = New System.Drawing.Point(158, 75)
        Me.lblNamaHari.Name = "lblNamaHari"
        Me.lblNamaHari.Size = New System.Drawing.Size(75, 17)
        Me.lblNamaHari.TabIndex = 0
        Me.lblNamaHari.Text = "Nama Hari"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(237, 217)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 132)
        Me.ListBox1.TabIndex = 2
        '
        'btnPapar
        '
        Me.btnPapar.Location = New System.Drawing.Point(129, 256)
        Me.btnPapar.Name = "btnPapar"
        Me.btnPapar.Size = New System.Drawing.Size(75, 23)
        Me.btnPapar.TabIndex = 3
        Me.btnPapar.Text = "Papar"
        Me.btnPapar.UseVisualStyleBackColor = True
        '
        'lblNamaHariInitialize
        '
        Me.lblNamaHariInitialize.AutoSize = True
        Me.lblNamaHariInitialize.Location = New System.Drawing.Point(515, 101)
        Me.lblNamaHariInitialize.Name = "lblNamaHariInitialize"
        Me.lblNamaHariInitialize.Size = New System.Drawing.Size(58, 17)
        Me.lblNamaHariInitialize.TabIndex = 4
        Me.lblNamaHariInitialize.Text = "Initialize"
        '
        'lbl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblNamaHariInitialize)
        Me.Controls.Add(Me.btnPapar)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblNamaHari)
        Me.Name = "lbl"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNamaHari As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnPapar As Button
    Friend WithEvents lblNamaHariInitialize As Label
End Class
