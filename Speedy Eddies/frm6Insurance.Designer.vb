<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm6Insurance
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm6Insurance))
        Me.lblCDW = New System.Windows.Forms.Label()
        Me.lblTheft = New System.Windows.Forms.Label()
        Me.lblVehicleContents = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.imglogo = New System.Windows.Forms.PictureBox()
        Me.lblNotice1 = New System.Windows.Forms.Label()
        Me.lblNotice2 = New System.Windows.Forms.Label()
        Me.chkCDW = New System.Windows.Forms.CheckBox()
        Me.chkTheftInsurance = New System.Windows.Forms.CheckBox()
        Me.chkVehicleContents = New System.Windows.Forms.CheckBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnTandC = New System.Windows.Forms.Button()
        Me.lblStep4 = New System.Windows.Forms.Label()
        Me.lblAdvice = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.imglogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCDW
        '
        Me.lblCDW.AutoSize = True
        Me.lblCDW.Location = New System.Drawing.Point(12, 123)
        Me.lblCDW.Name = "lblCDW"
        Me.lblCDW.Size = New System.Drawing.Size(162, 13)
        Me.lblCDW.TabIndex = 0
        Me.lblCDW.Text = "Collision Damage Waiver €2/day"
        '
        'lblTheft
        '
        Me.lblTheft.AutoSize = True
        Me.lblTheft.Location = New System.Drawing.Point(12, 194)
        Me.lblTheft.Name = "lblTheft"
        Me.lblTheft.Size = New System.Drawing.Size(119, 13)
        Me.lblTheft.TabIndex = 3
        Me.lblTheft.Text = "Theft Insurance €3/day"
        '
        'lblVehicleContents
        '
        Me.lblVehicleContents.AutoSize = True
        Me.lblVehicleContents.Location = New System.Drawing.Point(12, 255)
        Me.lblVehicleContents.Name = "lblVehicleContents"
        Me.lblVehicleContents.Size = New System.Drawing.Size(188, 13)
        Me.lblVehicleContents.TabIndex = 6
        Me.lblVehicleContents.Text = "Vehicle Contents €5/day or €25/week"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.imglogo, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(-1, -1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(768, 89)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'imglogo
        '
        Me.imglogo.Image = CType(resources.GetObject("imglogo.Image"), System.Drawing.Image)
        Me.imglogo.Location = New System.Drawing.Point(4, 4)
        Me.imglogo.Name = "imglogo"
        Me.imglogo.Size = New System.Drawing.Size(158, 81)
        Me.imglogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imglogo.TabIndex = 2
        Me.imglogo.TabStop = False
        '
        'lblNotice1
        '
        Me.lblNotice1.AutoSize = True
        Me.lblNotice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotice1.Location = New System.Drawing.Point(12, 149)
        Me.lblNotice1.Name = "lblNotice1"
        Me.lblNotice1.Size = New System.Drawing.Size(718, 13)
        Me.lblNotice1.TabIndex = 2
        Me.lblNotice1.Text = "*If this policy is not taken a Collision Damage Waiver Deposit of €2000 will be c" &
    "harged to the customer and refunded apon return of an undamaged car."
        '
        'lblNotice2
        '
        Me.lblNotice2.AutoSize = True
        Me.lblNotice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotice2.Location = New System.Drawing.Point(12, 220)
        Me.lblNotice2.Name = "lblNotice2"
        Me.lblNotice2.Size = New System.Drawing.Size(625, 13)
        Me.lblNotice2.TabIndex = 5
        Me.lblNotice2.Text = "*If this policy is not taken a Theft Deposit of €3000 will be charged to the cust" &
    "omer and refunded apon return of an undamaged car."
        '
        'chkCDW
        '
        Me.chkCDW.AutoSize = True
        Me.chkCDW.Location = New System.Drawing.Point(231, 122)
        Me.chkCDW.Name = "chkCDW"
        Me.chkCDW.Size = New System.Drawing.Size(15, 14)
        Me.chkCDW.TabIndex = 0
        Me.chkCDW.UseVisualStyleBackColor = True
        '
        'chkTheftInsurance
        '
        Me.chkTheftInsurance.AutoSize = True
        Me.chkTheftInsurance.Location = New System.Drawing.Point(231, 193)
        Me.chkTheftInsurance.Name = "chkTheftInsurance"
        Me.chkTheftInsurance.Size = New System.Drawing.Size(15, 14)
        Me.chkTheftInsurance.TabIndex = 1
        Me.chkTheftInsurance.UseVisualStyleBackColor = True
        '
        'chkVehicleContents
        '
        Me.chkVehicleContents.AutoSize = True
        Me.chkVehicleContents.Location = New System.Drawing.Point(231, 255)
        Me.chkVehicleContents.Name = "chkVehicleContents"
        Me.chkVehicleContents.Size = New System.Drawing.Size(15, 14)
        Me.chkVehicleContents.TabIndex = 2
        Me.chkVehicleContents.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(632, 376)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(57, 376)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnTandC
        '
        Me.btnTandC.Location = New System.Drawing.Point(337, 295)
        Me.btnTandC.Name = "btnTandC"
        Me.btnTandC.Size = New System.Drawing.Size(91, 47)
        Me.btnTandC.TabIndex = 3
        Me.btnTandC.Text = "Insurance T's&C's"
        Me.btnTandC.UseVisualStyleBackColor = True
        '
        'lblStep4
        '
        Me.lblStep4.AutoSize = True
        Me.lblStep4.Location = New System.Drawing.Point(352, 381)
        Me.lblStep4.Name = "lblStep4"
        Me.lblStep4.Size = New System.Drawing.Size(59, 13)
        Me.lblStep4.TabIndex = 10
        Me.lblStep4.Text = "Step 4 of 6"
        '
        'lblAdvice
        '
        Me.lblAdvice.AutoSize = True
        Me.lblAdvice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvice.ForeColor = System.Drawing.Color.DarkRed
        Me.lblAdvice.Location = New System.Drawing.Point(12, 100)
        Me.lblAdvice.Name = "lblAdvice"
        Me.lblAdvice.Size = New System.Drawing.Size(702, 16)
        Me.lblAdvice.TabIndex = 12
        Me.lblAdvice.Text = "It is strongly recomended that the customer takes out collision damage insurance " &
    "and theft insurance."
        '
        'frm6Insurance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 427)
        Me.Controls.Add(Me.lblAdvice)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblStep4)
        Me.Controls.Add(Me.btnTandC)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.chkVehicleContents)
        Me.Controls.Add(Me.chkTheftInsurance)
        Me.Controls.Add(Me.chkCDW)
        Me.Controls.Add(Me.lblNotice2)
        Me.Controls.Add(Me.lblNotice1)
        Me.Controls.Add(Me.lblVehicleContents)
        Me.Controls.Add(Me.lblTheft)
        Me.Controls.Add(Me.lblCDW)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm6Insurance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insurance"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.imglogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCDW As Label
    Friend WithEvents lblTheft As Label
    Friend WithEvents lblVehicleContents As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents imglogo As PictureBox
    Friend WithEvents lblNotice1 As Label
    Friend WithEvents lblNotice2 As Label
    Friend WithEvents chkCDW As CheckBox
    Friend WithEvents chkTheftInsurance As CheckBox
    Friend WithEvents chkVehicleContents As CheckBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnTandC As Button
    Friend WithEvents lblStep4 As Label
    Friend WithEvents lblAdvice As Label
End Class
