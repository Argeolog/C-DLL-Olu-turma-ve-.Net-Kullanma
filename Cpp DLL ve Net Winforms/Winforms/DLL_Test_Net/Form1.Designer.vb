<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.Test_Buton = New System.Windows.Forms.Button()
		Me.Fonks_Buton = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'Test_Buton
		'
		Me.Test_Buton.Location = New System.Drawing.Point(228, 79)
		Me.Test_Buton.Name = "Test_Buton"
		Me.Test_Buton.Size = New System.Drawing.Size(95, 52)
		Me.Test_Buton.TabIndex = 0
		Me.Test_Buton.Text = "Test"
		Me.Test_Buton.UseVisualStyleBackColor = True
		'
		'Fonks_Buton
		'
		Me.Fonks_Buton.Location = New System.Drawing.Point(228, 137)
		Me.Fonks_Buton.Name = "Fonks_Buton"
		Me.Fonks_Buton.Size = New System.Drawing.Size(95, 52)
		Me.Fonks_Buton.TabIndex = 1
		Me.Fonks_Buton.Text = "Fonks"
		Me.Fonks_Buton.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(228, 53)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(100, 20)
		Me.TextBox1.TabIndex = 2
		Me.TextBox1.Text = "10"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Fonks_Buton)
		Me.Controls.Add(Me.Test_Buton)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Test_Buton As Button
	Friend WithEvents Fonks_Buton As Button
	Friend WithEvents TextBox1 As TextBox
End Class
