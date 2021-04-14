<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblArrayTwoDimensi = New System.Windows.Forms.Label()
        Me.btnPaparTwoDimensi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblArrayTwoDimensi
        '
        Me.lblArrayTwoDimensi.AutoSize = True
        Me.lblArrayTwoDimensi.Location = New System.Drawing.Point(321, 184)
        Me.lblArrayTwoDimensi.Name = "lblArrayTwoDimensi"
        Me.lblArrayTwoDimensi.Size = New System.Drawing.Size(51, 17)
        Me.lblArrayTwoDimensi.TabIndex = 0
        Me.lblArrayTwoDimensi.Text = "Label1"
        '
        'btnPaparTwoDimensi
        '
        Me.btnPaparTwoDimensi.Location = New System.Drawing.Point(118, 184)
        Me.btnPaparTwoDimensi.Name = "btnPaparTwoDimensi"
        Me.btnPaparTwoDimensi.Size = New System.Drawing.Size(167, 40)
        Me.btnPaparTwoDimensi.TabIndex = 1
        Me.btnPaparTwoDimensi.Text = "Papar Array 2 Dimensi"
        Me.btnPaparTwoDimensi.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPaparTwoDimensi)
        Me.Controls.Add(Me.lblArrayTwoDimensi)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblArrayTwoDimensi As Label
    Friend WithEvents btnPaparTwoDimensi As Button
End Class
