<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm5DriverDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm5DriverDetails))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.imglogo = New System.Windows.Forms.PictureBox()
        Me.lblDriverNO = New System.Windows.Forms.Label()
        Me.lblYearsDrving = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblPenaltyPoints = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblStep3 = New System.Windows.Forms.Label()
        Me.mtbYears = New System.Windows.Forms.MaskedTextBox()
        Me.lblExpYears = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.mtbPoints = New System.Windows.Forms.MaskedTextBox()
        Me.lblPenPoints = New System.Windows.Forms.Label()
        Me.mtbLicense = New System.Windows.Forms.MaskedTextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.imglogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.imglogo, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(-4, -4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(567, 104)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'imglogo
        '
        Me.imglogo.Image = CType(resources.GetObject("imglogo.Image"), System.Drawing.Image)
        Me.imglogo.Location = New System.Drawing.Point(4, 4)
        Me.imglogo.Name = "imglogo"
        Me.imglogo.Size = New System.Drawing.Size(172, 96)
        Me.imglogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imglogo.TabIndex = 3
        Me.imglogo.TabStop = False
        '
        'lblDriverNO
        '
        Me.lblDriverNO.AutoSize = True
        Me.lblDriverNO.Location = New System.Drawing.Point(12, 117)
        Me.lblDriverNO.Name = "lblDriverNO"
        Me.lblDriverNO.Size = New System.Drawing.Size(118, 13)
        Me.lblDriverNO.TabIndex = 0
        Me.lblDriverNO.Text = "Driver License Number:"
        '
        'lblYearsDrving
        '
        Me.lblYearsDrving.AutoSize = True
        Me.lblYearsDrving.Location = New System.Drawing.Point(12, 155)
        Me.lblYearsDrving.Name = "lblYearsDrving"
        Me.lblYearsDrving.Size = New System.Drawing.Size(137, 13)
        Me.lblYearsDrving.TabIndex = 2
        Me.lblYearsDrving.Text = "Years of Driving Expirience:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(12, 198)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(45, 13)
        Me.lblGender.TabIndex = 5
        Me.lblGender.Text = "Gender:"
        '
        'lblPenaltyPoints
        '
        Me.lblPenaltyPoints.AutoSize = True
        Me.lblPenaltyPoints.Location = New System.Drawing.Point(12, 248)
        Me.lblPenaltyPoints.Name = "lblPenaltyPoints"
        Me.lblPenaltyPoints.Size = New System.Drawing.Size(123, 13)
        Me.lblPenaltyPoints.TabIndex = 7
        Me.lblPenaltyPoints.Text = "Number of Penlty Points:"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(459, 410)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(15, 410)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblStep3
        '
        Me.lblStep3.AutoSize = True
        Me.lblStep3.Location = New System.Drawing.Point(249, 415)
        Me.lblStep3.Name = "lblStep3"
        Me.lblStep3.Size = New System.Drawing.Size(59, 13)
        Me.lblStep3.TabIndex = 11
        Me.lblStep3.Text = "Step 3 of 6"
        '
        'mtbYears
        '
        Me.mtbYears.Location = New System.Drawing.Point(230, 152)
        Me.mtbYears.Mask = "00"
        Me.mtbYears.Name = "mtbYears"
        Me.mtbYears.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbYears.Size = New System.Drawing.Size(35, 20)
        Me.mtbYears.TabIndex = 1
        '
        'lblExpYears
        '
        Me.lblExpYears.AutoSize = True
        Me.lblExpYears.Location = New System.Drawing.Point(286, 155)
        Me.lblExpYears.Name = "lblExpYears"
        Me.lblExpYears.Size = New System.Drawing.Size(34, 13)
        Me.lblExpYears.TabIndex = 4
        Me.lblExpYears.Text = "Years"
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female", "Not Specified"})
        Me.cboGender.Location = New System.Drawing.Point(230, 190)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(121, 21)
        Me.cboGender.TabIndex = 2
        '
        'mtbPoints
        '
        Me.mtbPoints.Location = New System.Drawing.Point(230, 241)
        Me.mtbPoints.Mask = "000"
        Me.mtbPoints.Name = "mtbPoints"
        Me.mtbPoints.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbPoints.Size = New System.Drawing.Size(35, 20)
        Me.mtbPoints.TabIndex = 3
        '
        'lblPenPoints
        '
        Me.lblPenPoints.AutoSize = True
        Me.lblPenPoints.Location = New System.Drawing.Point(286, 244)
        Me.lblPenPoints.Name = "lblPenPoints"
        Me.lblPenPoints.Size = New System.Drawing.Size(36, 13)
        Me.lblPenPoints.TabIndex = 9
        Me.lblPenPoints.Text = "Points"
        '
        'mtbLicense
        '
        Me.mtbLicense.Location = New System.Drawing.Point(230, 114)
        Me.mtbLicense.Mask = "L0000000"
        Me.mtbLicense.Name = "mtbLicense"
        Me.mtbLicense.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbLicense.Size = New System.Drawing.Size(121, 20)
        Me.mtbLicense.TabIndex = 0
        '
        'frm5DriverDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 445)
        Me.Controls.Add(Me.mtbLicense)
        Me.Controls.Add(Me.lblPenPoints)
        Me.Controls.Add(Me.mtbPoints)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.lblExpYears)
        Me.Controls.Add(Me.mtbYears)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblStep3)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblPenaltyPoints)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblYearsDrving)
        Me.Controls.Add(Me.lblDriverNO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm5DriverDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Driver Details"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.imglogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents imglogo As PictureBox
    Friend WithEvents lblDriverNO As Label
    Friend WithEvents lblYearsDrving As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblPenaltyPoints As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblStep3 As Label
    Friend WithEvents mtbYears As MaskedTextBox
    Friend WithEvents lblExpYears As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents mtbPoints As MaskedTextBox
    Friend WithEvents lblPenPoints As Label
    Friend WithEvents mtbLicense As MaskedTextBox
End Class
