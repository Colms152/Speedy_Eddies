<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCard_End
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCard_End))
        Me.lblCardNO = New System.Windows.Forms.Label()
        Me.lblCVC = New System.Windows.Forms.Label()
        Me.lblCardName = New System.Windows.Forms.Label()
        Me.lblExpDate = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.imglogo = New System.Windows.Forms.PictureBox()
        Me.mtbCardNo = New System.Windows.Forms.MaskedTextBox()
        Me.mtbNameonCard = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCVC = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCardExp = New System.Windows.Forms.MaskedTextBox()
        Me.lblCardType = New System.Windows.Forms.Label()
        Me.cboCardType = New System.Windows.Forms.ComboBox()
        Me.lbl6of6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.imglogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCardNO
        '
        Me.lblCardNO.AutoSize = True
        Me.lblCardNO.Location = New System.Drawing.Point(24, 135)
        Me.lblCardNO.Name = "lblCardNO"
        Me.lblCardNO.Size = New System.Drawing.Size(124, 13)
        Me.lblCardNO.TabIndex = 0
        Me.lblCardNO.Text = "Customers Card Number:"
        '
        'lblCVC
        '
        Me.lblCVC.AutoSize = True
        Me.lblCVC.Location = New System.Drawing.Point(24, 187)
        Me.lblCVC.Name = "lblCVC"
        Me.lblCVC.Size = New System.Drawing.Size(146, 13)
        Me.lblCVC.TabIndex = 4
        Me.lblCVC.Text = "CVC(Number on back of car):"
        '
        'lblCardName
        '
        Me.lblCardName.AutoSize = True
        Me.lblCardName.Location = New System.Drawing.Point(24, 160)
        Me.lblCardName.Name = "lblCardName"
        Me.lblCardName.Size = New System.Drawing.Size(78, 13)
        Me.lblCardName.TabIndex = 2
        Me.lblCardName.Text = "Name on Card:"
        '
        'lblExpDate
        '
        Me.lblExpDate.AutoSize = True
        Me.lblExpDate.Location = New System.Drawing.Point(24, 211)
        Me.lblExpDate.Name = "lblExpDate"
        Me.lblExpDate.Size = New System.Drawing.Size(99, 13)
        Me.lblExpDate.TabIndex = 6
        Me.lblExpDate.Text = "Expiry date of Card:"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(27, 357)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(224, 348)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(131, 41)
        Me.btnConfirm.TabIndex = 6
        Me.btnConfirm.Text = "Confirm Details & Return to Log In"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.imglogo, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(-3, -1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(577, 97)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'imglogo
        '
        Me.imglogo.Image = CType(resources.GetObject("imglogo.Image"), System.Drawing.Image)
        Me.imglogo.Location = New System.Drawing.Point(4, 4)
        Me.imglogo.Name = "imglogo"
        Me.imglogo.Size = New System.Drawing.Size(158, 89)
        Me.imglogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imglogo.TabIndex = 4
        Me.imglogo.TabStop = False
        '
        'mtbCardNo
        '
        Me.mtbCardNo.Location = New System.Drawing.Point(224, 132)
        Me.mtbCardNo.Mask = "0000-0000-0000-0000"
        Me.mtbCardNo.Name = "mtbCardNo"
        Me.mtbCardNo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbCardNo.Size = New System.Drawing.Size(121, 20)
        Me.mtbCardNo.TabIndex = 2
        '
        'mtbNameonCard
        '
        Me.mtbNameonCard.Location = New System.Drawing.Point(224, 157)
        Me.mtbNameonCard.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLL"
        Me.mtbNameonCard.Name = "mtbNameonCard"
        Me.mtbNameonCard.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbNameonCard.Size = New System.Drawing.Size(121, 20)
        Me.mtbNameonCard.TabIndex = 3
        '
        'mtbCVC
        '
        Me.mtbCVC.Location = New System.Drawing.Point(224, 180)
        Me.mtbCVC.Mask = "000"
        Me.mtbCVC.Name = "mtbCVC"
        Me.mtbCVC.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbCVC.Size = New System.Drawing.Size(121, 20)
        Me.mtbCVC.TabIndex = 4
        '
        'mtbCardExp
        '
        Me.mtbCardExp.Location = New System.Drawing.Point(224, 208)
        Me.mtbCardExp.Mask = "00/00"
        Me.mtbCardExp.Name = "mtbCardExp"
        Me.mtbCardExp.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbCardExp.Size = New System.Drawing.Size(121, 20)
        Me.mtbCardExp.TabIndex = 5
        '
        'lblCardType
        '
        Me.lblCardType.AutoSize = True
        Me.lblCardType.Location = New System.Drawing.Point(24, 110)
        Me.lblCardType.Name = "lblCardType"
        Me.lblCardType.Size = New System.Drawing.Size(59, 13)
        Me.lblCardType.TabIndex = 0
        Me.lblCardType.Text = "Card Type:"
        '
        'cboCardType
        '
        Me.cboCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCardType.FormattingEnabled = True
        Me.cboCardType.Items.AddRange(New Object() {"Mastercard", "Visa", "Laser"})
        Me.cboCardType.Location = New System.Drawing.Point(224, 102)
        Me.cboCardType.Name = "cboCardType"
        Me.cboCardType.Size = New System.Drawing.Size(121, 21)
        Me.cboCardType.TabIndex = 1
        '
        'lbl6of6
        '
        Me.lbl6of6.AutoSize = True
        Me.lbl6of6.Location = New System.Drawing.Point(257, 332)
        Me.lbl6of6.Name = "lbl6of6"
        Me.lbl6of6.Size = New System.Drawing.Size(59, 13)
        Me.lbl6of6.TabIndex = 12
        Me.lbl6of6.Text = "Step 6 of 6"
        '
        'frmCard_End
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 410)
        Me.Controls.Add(Me.lbl6of6)
        Me.Controls.Add(Me.cboCardType)
        Me.Controls.Add(Me.lblCardType)
        Me.Controls.Add(Me.mtbCardExp)
        Me.Controls.Add(Me.mtbCVC)
        Me.Controls.Add(Me.mtbNameonCard)
        Me.Controls.Add(Me.mtbCardNo)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblExpDate)
        Me.Controls.Add(Me.lblCardName)
        Me.Controls.Add(Me.lblCVC)
        Me.Controls.Add(Me.lblCardNO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCard_End"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Card Details"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.imglogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCardNO As Label
    Friend WithEvents lblCVC As Label
    Friend WithEvents lblCardName As Label
    Friend WithEvents lblExpDate As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents imglogo As PictureBox
    Friend WithEvents mtbCardNo As MaskedTextBox
    Friend WithEvents mtbNameonCard As MaskedTextBox
    Friend WithEvents mtbCVC As MaskedTextBox
    Friend WithEvents mtbCardExp As MaskedTextBox
    Friend WithEvents lblCardType As Label
    Friend WithEvents cboCardType As ComboBox
    Friend WithEvents lbl6of6 As Label
End Class
