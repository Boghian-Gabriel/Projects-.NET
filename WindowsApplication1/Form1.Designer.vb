<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chose
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(103, 105)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(160, 36)
        Me.MaterialFlatButton1.TabIndex = 0
        Me.MaterialFlatButton1.Text = "1. Liste Autoturisme"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 235)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aplicatii:"
        '
        'Chose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(369, 323)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Chose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alege una din aplicatii"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
