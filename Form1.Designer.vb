<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Panel1 = New Panel()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        Text_user = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Text_pass = New TextBox()
        btn_login = New FontAwesome.Sharp.IconButton()
        check_code = New CheckBox()
        btn_exit = New FontAwesome.Sharp.IconButton()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(65), CByte(147), CByte(165))
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(322, 0)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(23, 559)
        Panel1.TabIndex = 1
        ' 
        ' IconButton1
        ' 
        IconButton1.BackColor = Color.Silver
        IconButton1.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        IconButton1.ForeColor = Color.Black
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        IconButton1.IconColor = Color.FromArgb(CByte(65), CByte(147), CByte(165))
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 200
        IconButton1.Location = New Point(55, 13)
        IconButton1.Margin = New Padding(4)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(215, 221)
        IconButton1.TabIndex = 2
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' Text_user
        ' 
        Text_user.BorderStyle = BorderStyle.FixedSingle
        Text_user.Location = New Point(55, 302)
        Text_user.Name = "Text_user"
        Text_user.Size = New Size(215, 29)
        Text_user.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(55, 278)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 19)
        Label1.TabIndex = 4
        Label1.Text = "Username :  slimaeda"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(55, 349)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 19)
        Label2.TabIndex = 6
        Label2.Text = "Password : 1234"
        ' 
        ' Text_pass
        ' 
        Text_pass.BorderStyle = BorderStyle.FixedSingle
        Text_pass.Location = New Point(55, 373)
        Text_pass.Name = "Text_pass"
        Text_pass.Size = New Size(215, 29)
        Text_pass.TabIndex = 5
        Text_pass.UseSystemPasswordChar = True
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = Color.FromArgb(CByte(65), CByte(147), CByte(165))
        btn_login.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btn_login.ForeColor = SystemColors.ButtonHighlight
        btn_login.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        btn_login.IconColor = Color.White
        btn_login.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_login.IconSize = 30
        btn_login.ImageAlign = ContentAlignment.MiddleLeft
        btn_login.Location = New Point(55, 463)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(214, 39)
        btn_login.TabIndex = 7
        btn_login.Text = "login"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' check_code
        ' 
        check_code.AutoSize = True
        check_code.Font = New Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point)
        check_code.Location = New Point(56, 409)
        check_code.Name = "check_code"
        check_code.Size = New Size(156, 20)
        check_code.TabIndex = 8
        check_code.Text = "Show Password"
        check_code.UseVisualStyleBackColor = True
        ' 
        ' btn_exit
        ' 
        btn_exit.BackColor = Color.FromArgb(CByte(65), CByte(147), CByte(165))
        btn_exit.Font = New Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btn_exit.ForeColor = SystemColors.ButtonHighlight
        btn_exit.IconChar = FontAwesome.Sharp.IconChar.ExternalLink
        btn_exit.IconColor = Color.White
        btn_exit.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_exit.IconSize = 30
        btn_exit.ImageAlign = ContentAlignment.MiddleLeft
        btn_exit.Location = New Point(55, 508)
        btn_exit.Name = "btn_exit"
        btn_exit.Size = New Size(214, 39)
        btn_exit.TabIndex = 9
        btn_exit.Text = "Exit"
        btn_exit.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(345, 559)
        Controls.Add(btn_exit)
        Controls.Add(check_code)
        Controls.Add(btn_login)
        Controls.Add(Label2)
        Controls.Add(Text_pass)
        Controls.Add(Label1)
        Controls.Add(Text_user)
        Controls.Add(IconButton1)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Text_user As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Text_pass As TextBox
    Friend WithEvents btn_login As FontAwesome.Sharp.IconButton
    Friend WithEvents check_code As CheckBox
    Friend WithEvents btn_exit As FontAwesome.Sharp.IconButton
End Class
