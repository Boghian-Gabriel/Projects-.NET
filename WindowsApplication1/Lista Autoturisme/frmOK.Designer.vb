<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Informatii
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
        Me.mlblInfoFrmOK = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'mlblInfoFrmOK
        '
        Me.mlblInfoFrmOK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mlblInfoFrmOK.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mlblInfoFrmOK.Depth = 0
        Me.mlblInfoFrmOK.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.mlblInfoFrmOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mlblInfoFrmOK.Location = New System.Drawing.Point(12, 75)
        Me.mlblInfoFrmOK.MouseState = MaterialSkin.MouseState.HOVER
        Me.mlblInfoFrmOK.Name = "mlblInfoFrmOK"
        Me.mlblInfoFrmOK.Size = New System.Drawing.Size(360, 101)
        Me.mlblInfoFrmOK.TabIndex = 1
        Me.mlblInfoFrmOK.Text = "MaterialLabel1"
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(282, 180)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(90, 36)
        Me.MaterialRaisedButton1.TabIndex = 2
        Me.MaterialRaisedButton1.Text = "ok"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'Informatii
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 223)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.mlblInfoFrmOK)
        Me.MinimumSize = New System.Drawing.Size(386, 223)
        Me.Name = "Informatii"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informatii"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mlblInfoFrmOK As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
End Class
