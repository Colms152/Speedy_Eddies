<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm3CustomerDetails
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm3CustomerDetails))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.imlogo = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblStreetA = New System.Windows.Forms.Label()
        Me.lblTorC = New System.Windows.Forms.Label()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.lblPhoneNo = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.mtbDOB = New System.Windows.Forms.MaskedTextBox()
        Me.cboCounty = New System.Windows.Forms.ComboBox()
        Me.mtbPhoneNo = New System.Windows.Forms.MaskedTextBox()
        Me.btnNext1 = New System.Windows.Forms.Button()
        Me.lblStep1 = New System.Windows.Forms.Label()
        Me.mtbName = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCity = New System.Windows.Forms.MaskedTextBox()
        Me.txtStAd = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtStAdLine2 = New System.Windows.Forms.TextBox()
        CType(Me.imlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(-43, -2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(514, 93)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'imlogo
        '
        Me.imlogo.Image = CType(resources.GetObject("imlogo.Image"), System.Drawing.Image)
        Me.imlogo.Location = New System.Drawing.Point(0, 0)
        Me.imlogo.Name = "imlogo"
        Me.imlogo.Size = New System.Drawing.Size(158, 91)
        Me.imlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imlogo.TabIndex = 1
        Me.imlogo.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 112)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblStreetA
        '
        Me.lblStreetA.AutoSize = True
        Me.lblStreetA.Location = New System.Drawing.Point(12, 142)
        Me.lblStreetA.Name = "lblStreetA"
        Me.lblStreetA.Size = New System.Drawing.Size(79, 13)
        Me.lblStreetA.TabIndex = 2
        Me.lblStreetA.Text = "Street Address:"
        '
        'lblTorC
        '
        Me.lblTorC.AutoSize = True
        Me.lblTorC.Location = New System.Drawing.Point(12, 199)
        Me.lblTorC.Name = "lblTorC"
        Me.lblTorC.Size = New System.Drawing.Size(59, 13)
        Me.lblTorC.TabIndex = 5
        Me.lblTorC.Text = "Town/City:"
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Location = New System.Drawing.Point(12, 230)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(43, 13)
        Me.lblCounty.TabIndex = 6
        Me.lblCounty.Text = "County:"
        '
        'lblPhoneNo
        '
        Me.lblPhoneNo.AutoSize = True
        Me.lblPhoneNo.Location = New System.Drawing.Point(12, 259)
        Me.lblPhoneNo.Name = "lblPhoneNo"
        Me.lblPhoneNo.Size = New System.Drawing.Size(97, 13)
        Me.lblPhoneNo.TabIndex = 8
        Me.lblPhoneNo.Text = "Irish Moblie Phone:"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(12, 290)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(69, 13)
        Me.lblDOB.TabIndex = 10
        Me.lblDOB.Text = "Date of Birth:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(12, 329)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 12
        Me.lblEmail.Text = "Email:"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(142, 326)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(138, 20)
        Me.txtemail.TabIndex = 7
        '
        'mtbDOB
        '
        Me.mtbDOB.Location = New System.Drawing.Point(142, 287)
        Me.mtbDOB.Mask = "00/00/0000"
        Me.mtbDOB.Name = "mtbDOB"
        Me.mtbDOB.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbDOB.Size = New System.Drawing.Size(138, 20)
        Me.mtbDOB.TabIndex = 6
        Me.mtbDOB.ValidatingType = GetType(Date)
        '
        'cboCounty
        '
        Me.cboCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCounty.FormattingEnabled = True
        Me.cboCounty.Items.AddRange(New Object() {"Carlow", "Cavan", "Clare", "Cork", "Donegal", "Dublin", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick", "Longford", "Louth ", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Waterford", "Westmeath", "Wexford", "Wicklow"})
        Me.cboCounty.Location = New System.Drawing.Point(142, 222)
        Me.cboCounty.Name = "cboCounty"
        Me.cboCounty.Size = New System.Drawing.Size(138, 21)
        Me.cboCounty.TabIndex = 4
        '
        'mtbPhoneNo
        '
        Me.mtbPhoneNo.Location = New System.Drawing.Point(142, 256)
        Me.mtbPhoneNo.Mask = "(999) 000-0000"
        Me.mtbPhoneNo.Name = "mtbPhoneNo"
        Me.mtbPhoneNo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbPhoneNo.Size = New System.Drawing.Size(138, 20)
        Me.mtbPhoneNo.TabIndex = 5
        '
        'btnNext1
        '
        Me.btnNext1.Location = New System.Drawing.Point(302, 405)
        Me.btnNext1.Name = "btnNext1"
        Me.btnNext1.Size = New System.Drawing.Size(75, 23)
        Me.btnNext1.TabIndex = 8
        Me.btnNext1.Text = "Next"
        Me.btnNext1.UseVisualStyleBackColor = True
        '
        'lblStep1
        '
        Me.lblStep1.AutoSize = True
        Me.lblStep1.Location = New System.Drawing.Point(139, 405)
        Me.lblStep1.Name = "lblStep1"
        Me.lblStep1.Size = New System.Drawing.Size(59, 13)
        Me.lblStep1.TabIndex = 14
        Me.lblStep1.Text = "Step 1 of 6"
        '
        'mtbName
        '
        Me.mtbName.Location = New System.Drawing.Point(142, 109)
        Me.mtbName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLL"
        Me.mtbName.Name = "mtbName"
        Me.mtbName.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbName.Size = New System.Drawing.Size(138, 20)
        Me.mtbName.TabIndex = 0
        '
        'mtbCity
        '
        Me.mtbCity.Location = New System.Drawing.Point(142, 196)
        Me.mtbCity.Mask = "LLLLLLLLLLLLLLLLLLLL"
        Me.mtbCity.Name = "mtbCity"
        Me.mtbCity.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbCity.Size = New System.Drawing.Size(138, 20)
        Me.mtbCity.TabIndex = 3
        '
        'txtStAd
        '
        Me.txtStAd.Location = New System.Drawing.Point(142, 135)
        Me.txtStAd.Name = "txtStAd"
        Me.txtStAd.Size = New System.Drawing.Size(138, 20)
        Me.txtStAd.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtStAdLine2
        '
        Me.txtStAdLine2.Location = New System.Drawing.Point(142, 161)
        Me.txtStAdLine2.Name = "txtStAdLine2"
        Me.txtStAdLine2.Size = New System.Drawing.Size(138, 20)
        Me.txtStAdLine2.TabIndex = 2
        '
        'frm3CustomerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 440)
        Me.Controls.Add(Me.txtStAdLine2)
        Me.Controls.Add(Me.txtStAd)
        Me.Controls.Add(Me.mtbCity)
        Me.Controls.Add(Me.mtbName)
        Me.Controls.Add(Me.lblStep1)
        Me.Controls.Add(Me.btnNext1)
        Me.Controls.Add(Me.mtbPhoneNo)
        Me.Controls.Add(Me.cboCounty)
        Me.Controls.Add(Me.mtbDOB)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblPhoneNo)
        Me.Controls.Add(Me.lblCounty)
        Me.Controls.Add(Me.lblTorC)
        Me.Controls.Add(Me.lblStreetA)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.imlogo)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm3CustomerDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Details"
        CType(Me.imlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents imlogo As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblStreetA As Label
    Friend WithEvents lblTorC As Label
    Friend WithEvents lblCounty As Label
    Friend WithEvents lblPhoneNo As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents mtbDOB As MaskedTextBox
    Friend WithEvents cboCounty As ComboBox
    Friend WithEvents mtbPhoneNo As MaskedTextBox
    Friend WithEvents btnNext1 As Button
    Friend WithEvents lblStep1 As Label
    Friend WithEvents mtbName As MaskedTextBox
    Friend WithEvents mtbCity As MaskedTextBox
    Friend WithEvents txtStAd As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtStAdLine2 As TextBox
End Class
