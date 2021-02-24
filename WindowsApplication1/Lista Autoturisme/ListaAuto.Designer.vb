<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaAuto
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton4 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton5 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.chklstbox_Auto = New System.Windows.Forms.CheckedListBox()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMarca = New System.Windows.Forms.RichTextBox()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtModel = New System.Windows.Forms.RichTextBox()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.lstBoxAuto = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblNrTotalInfo = New MaterialSkin.Controls.MaterialLabel()
        Me.lblInfoSelectate = New MaterialSkin.Controls.MaterialLabel()
        Me.lblInfoNeselectate = New MaterialSkin.Controls.MaterialLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(497, 74)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(147, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Lista cu autoturisme"
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(336, 263)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(241, 33)
        Me.MaterialRaisedButton1.TabIndex = 1
        Me.MaterialRaisedButton1.Text = "Afiseaza lista cu autoturisme"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(74, 115)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(185, 33)
        Me.MaterialRaisedButton2.TabIndex = 2
        Me.MaterialRaisedButton2.Text = "Adauga un autoturism"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton3
        '
        Me.MaterialRaisedButton3.Depth = 0
        Me.MaterialRaisedButton3.Location = New System.Drawing.Point(583, 263)
        Me.MaterialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton3.Name = "MaterialRaisedButton3"
        Me.MaterialRaisedButton3.Primary = True
        Me.MaterialRaisedButton3.Size = New System.Drawing.Size(200, 33)
        Me.MaterialRaisedButton3.TabIndex = 3
        Me.MaterialRaisedButton3.Text = "Adauga auto favorite"
        Me.MaterialRaisedButton3.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton4
        '
        Me.MaterialRaisedButton4.Depth = 0
        Me.MaterialRaisedButton4.Location = New System.Drawing.Point(336, 496)
        Me.MaterialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton4.Name = "MaterialRaisedButton4"
        Me.MaterialRaisedButton4.Primary = True
        Me.MaterialRaisedButton4.Size = New System.Drawing.Size(196, 33)
        Me.MaterialRaisedButton4.TabIndex = 4
        Me.MaterialRaisedButton4.Text = "Sterge toate informatiile"
        Me.MaterialRaisedButton4.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton5
        '
        Me.MaterialRaisedButton5.Depth = 0
        Me.MaterialRaisedButton5.Location = New System.Drawing.Point(538, 496)
        Me.MaterialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton5.Name = "MaterialRaisedButton5"
        Me.MaterialRaisedButton5.Primary = True
        Me.MaterialRaisedButton5.Size = New System.Drawing.Size(245, 33)
        Me.MaterialRaisedButton5.TabIndex = 5
        Me.MaterialRaisedButton5.Text = "Sterge informatiile selectate"
        Me.MaterialRaisedButton5.UseVisualStyleBackColor = True
        '
        'chklstbox_Auto
        '
        Me.chklstbox_Auto.FormattingEnabled = True
        Me.chklstbox_Auto.Location = New System.Drawing.Point(336, 103)
        Me.chklstbox_Auto.Name = "chklstbox_Auto"
        Me.chklstbox_Auto.Size = New System.Drawing.Size(447, 154)
        Me.chklstbox_Auto.TabIndex = 6
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(14, 31)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(51, 19)
        Me.MaterialLabel2.TabIndex = 7
        Me.MaterialLabel2.Text = "Marca"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaterialLabel3)
        Me.GroupBox1.Controls.Add(Me.txtModel)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel2)
        Me.GroupBox1.Controls.Add(Me.txtMarca)
        Me.GroupBox1.Controls.Add(Me.MaterialRaisedButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 154)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adauga"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(74, 30)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(185, 22)
        Me.txtMarca.TabIndex = 0
        Me.txtMarca.Text = ""
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(14, 67)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(51, 19)
        Me.MaterialLabel3.TabIndex = 9
        Me.MaterialLabel3.Text = "Model"
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(74, 66)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(185, 22)
        Me.txtModel.TabIndex = 8
        Me.txtModel.Text = ""
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(469, 312)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(202, 19)
        Me.MaterialLabel4.TabIndex = 9
        Me.MaterialLabel4.Text = "Lista cu autoturisme favorite"
        '
        'lstBoxAuto
        '
        Me.lstBoxAuto.FormattingEnabled = True
        Me.lstBoxAuto.Location = New System.Drawing.Point(336, 343)
        Me.lstBoxAuto.Name = "lstBoxAuto"
        Me.lstBoxAuto.Size = New System.Drawing.Size(447, 147)
        Me.lstBoxAuto.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblInfoNeselectate)
        Me.GroupBox2.Controls.Add(Me.lblInfoSelectate)
        Me.GroupBox2.Controls.Add(Me.lblNrTotalInfo)
        Me.GroupBox2.Controls.Add(Me.MaterialLabel7)
        Me.GroupBox2.Controls.Add(Me.MaterialLabel6)
        Me.GroupBox2.Controls.Add(Me.MaterialLabel5)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 343)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 128)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informatii despre Lista cu Autoturisme"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(6, 37)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(198, 19)
        Me.MaterialLabel5.TabIndex = 12
        Me.MaterialLabel5.Text = "Numarul total de informatii: "
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(6, 68)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(148, 19)
        Me.MaterialLabel6.TabIndex = 13
        Me.MaterialLabel6.Text = "Informatii selectate: "
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(6, 99)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(164, 19)
        Me.MaterialLabel7.TabIndex = 14
        Me.MaterialLabel7.Text = "Informatii neselectate: "
        '
        'lblNrTotalInfo
        '
        Me.lblNrTotalInfo.AutoSize = True
        Me.lblNrTotalInfo.Depth = 0
        Me.lblNrTotalInfo.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblNrTotalInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNrTotalInfo.Location = New System.Drawing.Point(210, 37)
        Me.lblNrTotalInfo.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNrTotalInfo.Name = "lblNrTotalInfo"
        Me.lblNrTotalInfo.Size = New System.Drawing.Size(13, 19)
        Me.lblNrTotalInfo.TabIndex = 15
        Me.lblNrTotalInfo.Text = "-"
        '
        'lblInfoSelectate
        '
        Me.lblInfoSelectate.AutoSize = True
        Me.lblInfoSelectate.Depth = 0
        Me.lblInfoSelectate.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblInfoSelectate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInfoSelectate.Location = New System.Drawing.Point(157, 68)
        Me.lblInfoSelectate.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblInfoSelectate.Name = "lblInfoSelectate"
        Me.lblInfoSelectate.Size = New System.Drawing.Size(13, 19)
        Me.lblInfoSelectate.TabIndex = 16
        Me.lblInfoSelectate.Text = "-"
        '
        'lblInfoNeselectate
        '
        Me.lblInfoNeselectate.AutoSize = True
        Me.lblInfoNeselectate.Depth = 0
        Me.lblInfoNeselectate.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblInfoNeselectate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInfoNeselectate.Location = New System.Drawing.Point(176, 99)
        Me.lblInfoNeselectate.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblInfoNeselectate.Name = "lblInfoNeselectate"
        Me.lblInfoNeselectate.Size = New System.Drawing.Size(13, 19)
        Me.lblInfoNeselectate.TabIndex = 17
        Me.lblInfoNeselectate.Text = "-"
        '
        'ListaAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 550)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lstBoxAuto)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.chklstbox_Auto)
        Me.Controls.Add(Me.MaterialRaisedButton5)
        Me.Controls.Add(Me.MaterialRaisedButton4)
        Me.Controls.Add(Me.MaterialRaisedButton3)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ListaAuto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Autoturisme"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton4 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton5 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents chklstbox_Auto As CheckedListBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtModel As RichTextBox
    Friend WithEvents txtMarca As RichTextBox
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lstBoxAuto As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblInfoNeselectate As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblInfoSelectate As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblNrTotalInfo As MaterialSkin.Controls.MaterialLabel
End Class
