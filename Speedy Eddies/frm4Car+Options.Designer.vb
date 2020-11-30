<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCar_Options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCar_Options))
        Me.imglogo = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblVType = New System.Windows.Forms.Label()
        Me.lblDates = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblextras = New System.Windows.Forms.Label()
        Me.grbVtype = New System.Windows.Forms.GroupBox()
        Me.btnPricing = New System.Windows.Forms.Button()
        Me.rdbVan = New System.Windows.Forms.RadioButton()
        Me.rdbCar = New System.Windows.Forms.RadioButton()
        Me.lblStDate = New System.Windows.Forms.Label()
        Me.lblNDDate = New System.Windows.Forms.Label()
        Me.cboCars = New System.Windows.Forms.ComboBox()
        Me.cboVans = New System.Windows.Forms.ComboBox()
        Me.grbExtras = New System.Windows.Forms.GroupBox()
        Me.chkSkiEq = New System.Windows.Forms.CheckBox()
        Me.chkSatNav = New System.Windows.Forms.CheckBox()
        Me.chkLuggageRack = New System.Windows.Forms.CheckBox()
        Me.chkChildSeat = New System.Windows.Forms.CheckBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblStep2 = New System.Windows.Forms.Label()
        Me.DtpStart = New System.Windows.Forms.DateTimePicker()
        Me.DtpReturn = New System.Windows.Forms.DateTimePicker()
        Me.lblcollection = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblPickupNotice = New System.Windows.Forms.Label()
        CType(Me.imglogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbVtype.SuspendLayout()
        Me.grbExtras.SuspendLayout()
        Me.SuspendLayout()
        '
        'imglogo
        '
        Me.imglogo.Image = CType(resources.GetObject("imglogo.Image"), System.Drawing.Image)
        Me.imglogo.Location = New System.Drawing.Point(1, 1)
        Me.imglogo.Name = "imglogo"
        Me.imglogo.Size = New System.Drawing.Size(158, 91)
        Me.imglogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imglogo.TabIndex = 3
        Me.imglogo.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(-42, -1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(668, 93)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'lblVType
        '
        Me.lblVType.AutoSize = True
        Me.lblVType.Location = New System.Drawing.Point(12, 110)
        Me.lblVType.Name = "lblVType"
        Me.lblVType.Size = New System.Drawing.Size(72, 13)
        Me.lblVType.TabIndex = 0
        Me.lblVType.Text = "Vehicle Type:"
        '
        'lblDates
        '
        Me.lblDates.AutoSize = True
        Me.lblDates.Location = New System.Drawing.Point(12, 170)
        Me.lblDates.Name = "lblDates"
        Me.lblDates.Size = New System.Drawing.Size(80, 13)
        Me.lblDates.TabIndex = 3
        Me.lblDates.Text = "Booking Dates:"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(12, 217)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(39, 13)
        Me.lblModel.TabIndex = 8
        Me.lblModel.Text = "Model:"
        '
        'lblextras
        '
        Me.lblextras.AutoSize = True
        Me.lblextras.Location = New System.Drawing.Point(12, 265)
        Me.lblextras.Name = "lblextras"
        Me.lblextras.Size = New System.Drawing.Size(39, 13)
        Me.lblextras.TabIndex = 11
        Me.lblextras.Text = "Extras:"
        '
        'grbVtype
        '
        Me.grbVtype.Controls.Add(Me.btnPricing)
        Me.grbVtype.Controls.Add(Me.rdbVan)
        Me.grbVtype.Controls.Add(Me.rdbCar)
        Me.grbVtype.Location = New System.Drawing.Point(90, 98)
        Me.grbVtype.Name = "grbVtype"
        Me.grbVtype.Size = New System.Drawing.Size(465, 38)
        Me.grbVtype.TabIndex = 0
        Me.grbVtype.TabStop = False
        '
        'btnPricing
        '
        Me.btnPricing.Location = New System.Drawing.Point(369, 10)
        Me.btnPricing.Name = "btnPricing"
        Me.btnPricing.Size = New System.Drawing.Size(75, 23)
        Me.btnPricing.TabIndex = 2
        Me.btnPricing.Text = "Pricing"
        Me.btnPricing.UseVisualStyleBackColor = True
        '
        'rdbVan
        '
        Me.rdbVan.AutoSize = True
        Me.rdbVan.Location = New System.Drawing.Point(279, 10)
        Me.rdbVan.Name = "rdbVan"
        Me.rdbVan.Size = New System.Drawing.Size(44, 17)
        Me.rdbVan.TabIndex = 1
        Me.rdbVan.TabStop = True
        Me.rdbVan.Text = "Van"
        Me.rdbVan.UseVisualStyleBackColor = True
        '
        'rdbCar
        '
        Me.rdbCar.AutoSize = True
        Me.rdbCar.Location = New System.Drawing.Point(65, 14)
        Me.rdbCar.Name = "rdbCar"
        Me.rdbCar.Size = New System.Drawing.Size(41, 17)
        Me.rdbCar.TabIndex = 0
        Me.rdbCar.TabStop = True
        Me.rdbCar.Text = "Car"
        Me.rdbCar.UseVisualStyleBackColor = True
        '
        'lblStDate
        '
        Me.lblStDate.AutoSize = True
        Me.lblStDate.Location = New System.Drawing.Point(101, 170)
        Me.lblStDate.Name = "lblStDate"
        Me.lblStDate.Size = New System.Drawing.Size(58, 13)
        Me.lblStDate.TabIndex = 4
        Me.lblStDate.Text = "Start Date:"
        '
        'lblNDDate
        '
        Me.lblNDDate.AutoSize = True
        Me.lblNDDate.Location = New System.Drawing.Point(323, 168)
        Me.lblNDDate.Name = "lblNDDate"
        Me.lblNDDate.Size = New System.Drawing.Size(55, 13)
        Me.lblNDDate.TabIndex = 6
        Me.lblNDDate.Text = "End Date:"
        '
        'cboCars
        '
        Me.cboCars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCars.Items.AddRange(New Object() {"VW Polo 1.0 Lt (or equivalent)", "Opel Corsa 1.2 Lt (or equivalent)", "Skoda Octavia 1.4 Lt (or equivalent)", "Alfa Romeo 1.6 Lt (or equivalent)", "Opel Zafira 8 Seater 2.0 Lt (or equivalent)"})
        Me.cboCars.Location = New System.Drawing.Point(113, 214)
        Me.cboCars.Name = "cboCars"
        Me.cboCars.Size = New System.Drawing.Size(197, 21)
        Me.cboCars.TabIndex = 3
        '
        'cboVans
        '
        Me.cboVans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVans.FormattingEnabled = True
        Me.cboVans.Items.AddRange(New Object() {"Opel Corsa Van", "Toyota Hiace", "Ford Transit", "Ford Transit Minibus (26 Seater)", "Mercedes Runner", "Nissan Patrol"})
        Me.cboVans.Location = New System.Drawing.Point(348, 217)
        Me.cboVans.Name = "cboVans"
        Me.cboVans.Size = New System.Drawing.Size(186, 21)
        Me.cboVans.TabIndex = 4
        '
        'grbExtras
        '
        Me.grbExtras.Controls.Add(Me.chkSkiEq)
        Me.grbExtras.Controls.Add(Me.chkSatNav)
        Me.grbExtras.Controls.Add(Me.chkLuggageRack)
        Me.grbExtras.Controls.Add(Me.chkChildSeat)
        Me.grbExtras.Location = New System.Drawing.Point(90, 265)
        Me.grbExtras.Name = "grbExtras"
        Me.grbExtras.Size = New System.Drawing.Size(385, 105)
        Me.grbExtras.TabIndex = 5
        Me.grbExtras.TabStop = False
        '
        'chkSkiEq
        '
        Me.chkSkiEq.AutoSize = True
        Me.chkSkiEq.Location = New System.Drawing.Point(178, 71)
        Me.chkSkiEq.Name = "chkSkiEq"
        Me.chkSkiEq.Size = New System.Drawing.Size(110, 17)
        Me.chkSkiEq.TabIndex = 2
        Me.chkSkiEq.Text = "Ski Equipped €78"
        Me.chkSkiEq.UseVisualStyleBackColor = True
        Me.chkSkiEq.Visible = False
        '
        'chkSatNav
        '
        Me.chkSatNav.AutoSize = True
        Me.chkSatNav.Location = New System.Drawing.Point(0, 71)
        Me.chkSatNav.Name = "chkSatNav"
        Me.chkSatNav.Size = New System.Drawing.Size(102, 17)
        Me.chkSatNav.TabIndex = 1
        Me.chkSatNav.Text = "Sat-Nav €5/day"
        Me.chkSatNav.UseVisualStyleBackColor = True
        '
        'chkLuggageRack
        '
        Me.chkLuggageRack.AutoSize = True
        Me.chkLuggageRack.Location = New System.Drawing.Point(178, 16)
        Me.chkLuggageRack.Name = "chkLuggageRack"
        Me.chkLuggageRack.Size = New System.Drawing.Size(189, 17)
        Me.chkLuggageRack.TabIndex = 3
        Me.chkLuggageRack.Text = "Roof-Mounted Luggage Rack €45"
        Me.chkLuggageRack.UseVisualStyleBackColor = True
        Me.chkLuggageRack.Visible = False
        '
        'chkChildSeat
        '
        Me.chkChildSeat.AutoSize = True
        Me.chkChildSeat.Location = New System.Drawing.Point(3, 16)
        Me.chkChildSeat.Name = "chkChildSeat"
        Me.chkChildSeat.Size = New System.Drawing.Size(95, 17)
        Me.chkChildSeat.TabIndex = 0
        Me.chkChildSeat.Text = "Child Seat €22"
        Me.chkChildSeat.UseVisualStyleBackColor = True
        Me.chkChildSeat.Visible = False
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.Location = New System.Drawing.Point(90, 139)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(199, 13)
        Me.lblNote.TabIndex = 2
        Me.lblNote.Text = "*Note total Cost Compiled on final screen"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(459, 431)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(31, 431)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblStep2
        '
        Me.lblStep2.AutoSize = True
        Me.lblStep2.Location = New System.Drawing.Point(250, 436)
        Me.lblStep2.Name = "lblStep2"
        Me.lblStep2.Size = New System.Drawing.Size(59, 13)
        Me.lblStep2.TabIndex = 14
        Me.lblStep2.Text = "Step 2 of 6"
        '
        'DtpStart
        '
        Me.DtpStart.Location = New System.Drawing.Point(170, 164)
        Me.DtpStart.Name = "DtpStart"
        Me.DtpStart.Size = New System.Drawing.Size(119, 20)
        Me.DtpStart.TabIndex = 1
        '
        'DtpReturn
        '
        Me.DtpReturn.Location = New System.Drawing.Point(391, 162)
        Me.DtpReturn.Name = "DtpReturn"
        Me.DtpReturn.Size = New System.Drawing.Size(119, 20)
        Me.DtpReturn.TabIndex = 2
        '
        'lblcollection
        '
        Me.lblcollection.AutoSize = True
        Me.lblcollection.Location = New System.Drawing.Point(12, 383)
        Me.lblcollection.Name = "lblcollection"
        Me.lblcollection.Size = New System.Drawing.Size(81, 13)
        Me.lblcollection.TabIndex = 16
        Me.lblcollection.Text = "Vehicle Pickup:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Aiport", "Train Station", "etc."})
        Me.ComboBox1.Location = New System.Drawing.Point(125, 380)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(174, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'lblPickupNotice
        '
        Me.lblPickupNotice.AutoSize = True
        Me.lblPickupNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPickupNotice.ForeColor = System.Drawing.Color.DarkRed
        Me.lblPickupNotice.Location = New System.Drawing.Point(122, 404)
        Me.lblPickupNotice.Name = "lblPickupNotice"
        Me.lblPickupNotice.Size = New System.Drawing.Size(302, 13)
        Me.lblPickupNotice.TabIndex = 18
        Me.lblPickupNotice.Text = "*There is no extra charge for deliver to vehicle pick up location"
        '
        'frmCar_Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 464)
        Me.Controls.Add(Me.lblPickupNotice)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblcollection)
        Me.Controls.Add(Me.DtpReturn)
        Me.Controls.Add(Me.DtpStart)
        Me.Controls.Add(Me.lblStep2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.grbExtras)
        Me.Controls.Add(Me.cboVans)
        Me.Controls.Add(Me.cboCars)
        Me.Controls.Add(Me.lblNDDate)
        Me.Controls.Add(Me.lblStDate)
        Me.Controls.Add(Me.grbVtype)
        Me.Controls.Add(Me.lblextras)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblDates)
        Me.Controls.Add(Me.lblVType)
        Me.Controls.Add(Me.imglogo)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCar_Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Options"
        CType(Me.imglogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbVtype.ResumeLayout(False)
        Me.grbVtype.PerformLayout()
        Me.grbExtras.ResumeLayout(False)
        Me.grbExtras.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imglogo As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblVType As Label
    Friend WithEvents lblDates As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblextras As Label
    Friend WithEvents grbVtype As GroupBox
    Friend WithEvents rdbVan As RadioButton
    Friend WithEvents rdbCar As RadioButton
    Friend WithEvents lblStDate As Label
    Friend WithEvents lblNDDate As Label
    Friend WithEvents cboCars As ComboBox
    Friend WithEvents cboVans As ComboBox
    Friend WithEvents grbExtras As GroupBox
    Friend WithEvents chkSkiEq As CheckBox
    Friend WithEvents chkSatNav As CheckBox
    Friend WithEvents chkLuggageRack As CheckBox
    Friend WithEvents chkChildSeat As CheckBox
    Friend WithEvents btnPricing As Button
    Friend WithEvents lblNote As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblStep2 As Label
    Friend WithEvents DtpStart As DateTimePicker
    Friend WithEvents DtpReturn As DateTimePicker
    Friend WithEvents lblcollection As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblPickupNotice As Label
End Class
