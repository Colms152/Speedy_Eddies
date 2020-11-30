<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm2LogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm2LogIn))
        Me.imglogo = New System.Windows.Forms.PictureBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        CType(Me.imglogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imglogo
        '
        Me.imglogo.Image = CType(resources.GetObject("imglogo.Image"), System.Drawing.Image)
        Me.imglogo.Location = New System.Drawing.Point(157, 12)
        Me.imglogo.Name = "imglogo"
        Me.imglogo.Size = New System.Drawing.Size(174, 98)
        Me.imglogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imglogo.TabIndex = 0
        Me.imglogo.TabStop = False
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Location = New System.Drawing.Point(86, 144)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(46, 13)
        Me.lblUserID.TabIndex = 1
        Me.lblUserID.Text = "User ID:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(86, 200)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password:"
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(189, 141)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(100, 20)
        Me.txtUserID.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(189, 197)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 4
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(198, 252)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(75, 23)
        Me.btnLogIn.TabIndex = 5
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(357, 141)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(36, 13)
        Me.lblUsername.TabIndex = 6
        Me.lblUsername.Text = "Admin"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(357, 200)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(36, 13)
        Me.lblPass.TabIndex = 7
        Me.lblPass.Text = "Admin"
        '
        'frm2LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 305)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.imglogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm2LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogIn"
        CType(Me.imglogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imglogo As PictureBox
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPass As Label
End Class
