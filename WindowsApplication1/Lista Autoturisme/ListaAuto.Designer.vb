<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListaAuto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaAuto))
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton4 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton5 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.chklstbox_Auto = New System.Windows.Forms.CheckedListBox()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.lstBoxAuto = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCauta = New System.Windows.Forms.RichTextBox()
        Me.btnCauta = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblInfoNeselectate = New MaterialSkin.Controls.MaterialLabel()
        Me.lblInfoSelectate = New MaterialSkin.Controls.MaterialLabel()
        Me.lblNrTotalInfo = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCheckBox1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtModel = New System.Windows.Forms.RichTextBox()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtMarca = New System.Windows.Forms.RichTextBox()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(499, 74)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(147, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Lista cu autoturisme"
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MaterialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.FlatAppearance.BorderSize = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(336, 313)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(241, 33)
        Me.MaterialRaisedButton1.TabIndex = 1
        Me.MaterialRaisedButton1.Text = "Afiseaza lista cu autoturisme"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton3
        '
        Me.MaterialRaisedButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MaterialRaisedButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialRaisedButton3.Depth = 0
        Me.MaterialRaisedButton3.FlatAppearance.BorderSize = 0
        Me.MaterialRaisedButton3.Location = New System.Drawing.Point(583, 313)
        Me.MaterialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton3.Name = "MaterialRaisedButton3"
        Me.MaterialRaisedButton3.Primary = True
        Me.MaterialRaisedButton3.Size = New System.Drawing.Size(200, 33)
        Me.MaterialRaisedButton3.TabIndex = 3
        Me.MaterialRaisedButton3.Text = "Adauga in lista favorita"
        Me.MaterialRaisedButton3.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton4
        '
        Me.MaterialRaisedButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MaterialRaisedButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialRaisedButton4.Depth = 0
        Me.MaterialRaisedButton4.FlatAppearance.BorderSize = 0
        Me.MaterialRaisedButton4.Location = New System.Drawing.Point(583, 563)
        Me.MaterialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton4.Name = "MaterialRaisedButton4"
        Me.MaterialRaisedButton4.Primary = True
        Me.MaterialRaisedButton4.Size = New System.Drawing.Size(200, 33)
        Me.MaterialRaisedButton4.TabIndex = 4
        Me.MaterialRaisedButton4.Text = "Sterge toate informatiile"
        Me.MaterialRaisedButton4.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton5
        '
        Me.MaterialRaisedButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MaterialRaisedButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialRaisedButton5.Depth = 0
        Me.MaterialRaisedButton5.FlatAppearance.BorderSize = 0
        Me.MaterialRaisedButton5.Location = New System.Drawing.Point(336, 563)
        Me.MaterialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton5.Name = "MaterialRaisedButton5"
        Me.MaterialRaisedButton5.Primary = True
        Me.MaterialRaisedButton5.Size = New System.Drawing.Size(241, 33)
        Me.MaterialRaisedButton5.TabIndex = 5
        Me.MaterialRaisedButton5.Text = "Sterge informatiile selectate"
        Me.MaterialRaisedButton5.UseVisualStyleBackColor = True
        '
        'chklstbox_Auto
        '
        Me.chklstbox_Auto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chklstbox_Auto.CheckOnClick = True
        Me.chklstbox_Auto.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklstbox_Auto.FormattingEnabled = True
        Me.chklstbox_Auto.Location = New System.Drawing.Point(336, 103)
        Me.chklstbox_Auto.Name = "chklstbox_Auto"
        Me.chklstbox_Auto.Size = New System.Drawing.Size(451, 204)
        Me.chklstbox_Auto.TabIndex = 6
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(468, 364)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(202, 19)
        Me.MaterialLabel4.TabIndex = 9
        Me.MaterialLabel4.Text = "Lista cu autoturisme favorite"
        '
        'lstBoxAuto
        '
        Me.lstBoxAuto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstBoxAuto.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxAuto.FormattingEnabled = True
        Me.lstBoxAuto.ItemHeight = 21
        Me.lstBoxAuto.Location = New System.Drawing.Point(336, 394)
        Me.lstBoxAuto.Name = "lstBoxAuto"
        Me.lstBoxAuto.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstBoxAuto.Size = New System.Drawing.Size(451, 151)
        Me.lstBoxAuto.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(315, 541)
        Me.Panel1.TabIndex = 13
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtCauta)
        Me.GroupBox4.Controls.Add(Me.btnCauta)
        Me.GroupBox4.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(25, 103)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(270, 118)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cauta un autoturism"
        '
        'txtCauta
        '
        Me.txtCauta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCauta.Location = New System.Drawing.Point(18, 30)
        Me.txtCauta.Name = "txtCauta"
        Me.txtCauta.Size = New System.Drawing.Size(241, 22)
        Me.txtCauta.TabIndex = 0
        Me.txtCauta.Text = ""
        '
        'btnCauta
        '
        Me.btnCauta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCauta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCauta.Depth = 0
        Me.btnCauta.Location = New System.Drawing.Point(18, 67)
        Me.btnCauta.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCauta.Name = "btnCauta"
        Me.btnCauta.Primary = True
        Me.btnCauta.Size = New System.Drawing.Size(241, 33)
        Me.btnCauta.TabIndex = 2
        Me.btnCauta.Text = "Cauta un autoturism"
        Me.btnCauta.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblInfoNeselectate)
        Me.GroupBox2.Controls.Add(Me.lblInfoSelectate)
        Me.GroupBox2.Controls.Add(Me.lblNrTotalInfo)
        Me.GroupBox2.Controls.Add(Me.MaterialLabel7)
        Me.GroupBox2.Controls.Add(Me.MaterialLabel6)
        Me.GroupBox2.Controls.Add(Me.MaterialLabel5)
        Me.GroupBox2.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(25, 450)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 146)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informatii despre Lista cu Autoturisme"
        '
        'lblInfoNeselectate
        '
        Me.lblInfoNeselectate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblInfoNeselectate.AutoSize = True
        Me.lblInfoNeselectate.Depth = 0
        Me.lblInfoNeselectate.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblInfoNeselectate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInfoNeselectate.Location = New System.Drawing.Point(176, 102)
        Me.lblInfoNeselectate.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblInfoNeselectate.Name = "lblInfoNeselectate"
        Me.lblInfoNeselectate.Size = New System.Drawing.Size(13, 19)
        Me.lblInfoNeselectate.TabIndex = 17
        Me.lblInfoNeselectate.Text = "-"
        '
        'lblInfoSelectate
        '
        Me.lblInfoSelectate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblInfoSelectate.AutoSize = True
        Me.lblInfoSelectate.Depth = 0
        Me.lblInfoSelectate.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblInfoSelectate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInfoSelectate.Location = New System.Drawing.Point(157, 70)
        Me.lblInfoSelectate.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblInfoSelectate.Name = "lblInfoSelectate"
        Me.lblInfoSelectate.Size = New System.Drawing.Size(13, 19)
        Me.lblInfoSelectate.TabIndex = 16
        Me.lblInfoSelectate.Text = "-"
        '
        'lblNrTotalInfo
        '
        Me.lblNrTotalInfo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNrTotalInfo.AutoSize = True
        Me.lblNrTotalInfo.Depth = 0
        Me.lblNrTotalInfo.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblNrTotalInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNrTotalInfo.Location = New System.Drawing.Point(210, 39)
        Me.lblNrTotalInfo.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNrTotalInfo.Name = "lblNrTotalInfo"
        Me.lblNrTotalInfo.Size = New System.Drawing.Size(13, 19)
        Me.lblNrTotalInfo.TabIndex = 15
        Me.lblNrTotalInfo.Text = "-"
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(6, 102)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(164, 19)
        Me.MaterialLabel7.TabIndex = 14
        Me.MaterialLabel7.Text = "Informatii neselectate: "
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(6, 70)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(148, 19)
        Me.MaterialLabel6.TabIndex = 13
        Me.MaterialLabel6.Text = "Informatii selectate: "
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(6, 39)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(198, 19)
        Me.MaterialLabel5.TabIndex = 12
        Me.MaterialLabel5.Text = "Numarul total de informatii: "
        '
        'MaterialCheckBox1
        '
        Me.MaterialCheckBox1.Depth = 0
        Me.MaterialCheckBox1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox1.Location = New System.Drawing.Point(25, 395)
        Me.MaterialCheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox1.Name = "MaterialCheckBox1"
        Me.MaterialCheckBox1.Ripple = True
        Me.MaterialCheckBox1.Size = New System.Drawing.Size(270, 33)
        Me.MaterialCheckBox1.TabIndex = 17
        Me.MaterialCheckBox1.Text = "Selecteaza/Deselecteaza (Tot)"
        Me.MaterialCheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaterialLabel3)
        Me.GroupBox1.Controls.Add(Me.txtModel)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel2)
        Me.GroupBox1.Controls.Add(Me.txtMarca)
        Me.GroupBox1.Controls.Add(Me.MaterialRaisedButton2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 240)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 143)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adauga"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
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
        Me.txtModel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtModel.Location = New System.Drawing.Point(74, 66)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(185, 22)
        Me.txtModel.TabIndex = 8
        Me.txtModel.Text = ""
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
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
        'txtMarca
        '
        Me.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMarca.Location = New System.Drawing.Point(74, 30)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(185, 22)
        Me.txtMarca.TabIndex = 0
        Me.txtMarca.Text = ""
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MaterialRaisedButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(74, 100)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(185, 33)
        Me.MaterialRaisedButton2.TabIndex = 2
        Me.MaterialRaisedButton2.Text = "Adauga un autoturism"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'ListaAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 604)
        Me.Controls.Add(Me.MaterialCheckBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lstBoxAuto)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.chklstbox_Auto)
        Me.Controls.Add(Me.MaterialRaisedButton5)
        Me.Controls.Add(Me.MaterialRaisedButton4)
        Me.Controls.Add(Me.MaterialRaisedButton3)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(795, 530)
        Me.Name = "ListaAuto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Autoturisme"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton4 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton5 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents chklstbox_Auto As CheckedListBox
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lstBoxAuto As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtCauta As RichTextBox
    Friend WithEvents btnCauta As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblInfoNeselectate As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblInfoSelectate As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblNrTotalInfo As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCheckBox1 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtModel As RichTextBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtMarca As RichTextBox
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
End Class
