<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSup2TandC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSup2TandC))
        Me.txtTandC = New System.Windows.Forms.RichTextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTandC
        '
        Me.txtTandC.Location = New System.Drawing.Point(13, 13)
        Me.txtTandC.Name = "txtTandC"
        Me.txtTandC.ReadOnly = True
        Me.txtTandC.Size = New System.Drawing.Size(567, 272)
        Me.txtTandC.TabIndex = 0
        Me.txtTandC.Text = resources.GetString("txtTandC.Text")
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(257, 311)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSup2TandC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 364)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtTandC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSup2TandC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Insurance Terms and Conditions"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtTandC As RichTextBox
    Friend WithEvents btnClose As Button
End Class
