<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_login = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_senha = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_entrar = New Guna.UI.WinForms.GunaButton()
        Me.img_login = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLinkLabel1 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.gbx_novaSenha = New System.Windows.Forms.GroupBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_repetirSenha = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_novaSenha = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_cpfSenha = New Guna.UI.WinForms.GunaTextBox()
        CType(Me.img_login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_novaSenha.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_login
        '
        Me.txt_login.BackColor = System.Drawing.Color.Transparent
        Me.txt_login.BaseColor = System.Drawing.Color.White
        Me.txt_login.BorderColor = System.Drawing.Color.Silver
        Me.txt_login.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_login.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_login.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_login.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_login.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_login.Location = New System.Drawing.Point(49, 60)
        Me.txt_login.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_login.MaxLength = 11
        Me.txt_login.Name = "txt_login"
        Me.txt_login.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_login.Radius = 5
        Me.txt_login.SelectedText = ""
        Me.txt_login.Size = New System.Drawing.Size(173, 26)
        Me.txt_login.TabIndex = 4
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.Transparent
        Me.txt_senha.BaseColor = System.Drawing.Color.White
        Me.txt_senha.BorderColor = System.Drawing.Color.Silver
        Me.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_senha.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_senha.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_senha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_senha.Location = New System.Drawing.Point(49, 190)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_senha.Radius = 5
        Me.txt_senha.SelectedText = ""
        Me.txt_senha.Size = New System.Drawing.Size(173, 26)
        Me.txt_senha.TabIndex = 5
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(49, 35)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(59, 21)
        Me.GunaLabel1.TabIndex = 6
        Me.GunaLabel1.Text = "LOGIN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(49, 168)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(64, 21)
        Me.GunaLabel2.TabIndex = 7
        Me.GunaLabel2.Text = "SENHA"
        '
        'btn_entrar
        '
        Me.btn_entrar.AnimationHoverSpeed = 0.07!
        Me.btn_entrar.AnimationSpeed = 0.03!
        Me.btn_entrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_entrar.BaseColor = System.Drawing.Color.LimeGreen
        Me.btn_entrar.BorderColor = System.Drawing.Color.LimeGreen
        Me.btn_entrar.BorderSize = 2
        Me.btn_entrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_entrar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_entrar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.Color.White
        Me.btn_entrar.Image = Nothing
        Me.btn_entrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_entrar.Location = New System.Drawing.Point(67, 357)
        Me.btn_entrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.OnHoverBaseColor = System.Drawing.Color.Green
        Me.btn_entrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_entrar.OnHoverForeColor = System.Drawing.Color.GreenYellow
        Me.btn_entrar.OnHoverImage = Nothing
        Me.btn_entrar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_entrar.Radius = 10
        Me.btn_entrar.Size = New System.Drawing.Size(118, 39)
        Me.btn_entrar.TabIndex = 8
        Me.btn_entrar.Text = "ENTRAR"
        Me.btn_entrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'img_login
        '
        Me.img_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.img_login.BaseColor = System.Drawing.Color.White
        Me.img_login.Location = New System.Drawing.Point(277, -1)
        Me.img_login.Margin = New System.Windows.Forms.Padding(2)
        Me.img_login.Name = "img_login"
        Me.img_login.Size = New System.Drawing.Size(560, 434)
        Me.img_login.TabIndex = 9
        Me.img_login.TabStop = False
        '
        'GunaLinkLabel1
        '
        Me.GunaLinkLabel1.AutoSize = True
        Me.GunaLinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLinkLabel1.Location = New System.Drawing.Point(49, 218)
        Me.GunaLinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLinkLabel1.Name = "GunaLinkLabel1"
        Me.GunaLinkLabel1.Size = New System.Drawing.Size(117, 15)
        Me.GunaLinkLabel1.TabIndex = 10
        Me.GunaLinkLabel1.TabStop = True
        Me.GunaLinkLabel1.Text = "Esqueceu sua senha?"
        '
        'gbx_novaSenha
        '
        Me.gbx_novaSenha.BackColor = System.Drawing.Color.White
        Me.gbx_novaSenha.Controls.Add(Me.GunaButton1)
        Me.gbx_novaSenha.Controls.Add(Me.GunaLabel5)
        Me.gbx_novaSenha.Controls.Add(Me.txt_repetirSenha)
        Me.gbx_novaSenha.Controls.Add(Me.GunaLabel4)
        Me.gbx_novaSenha.Controls.Add(Me.GunaLabel3)
        Me.gbx_novaSenha.Controls.Add(Me.txt_novaSenha)
        Me.gbx_novaSenha.Controls.Add(Me.txt_cpfSenha)
        Me.gbx_novaSenha.Location = New System.Drawing.Point(277, -12)
        Me.gbx_novaSenha.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_novaSenha.Name = "gbx_novaSenha"
        Me.gbx_novaSenha.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_novaSenha.Size = New System.Drawing.Size(570, 464)
        Me.gbx_novaSenha.TabIndex = 11
        Me.gbx_novaSenha.TabStop = False
        Me.gbx_novaSenha.Visible = False
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.LimeGreen
        Me.GunaButton1.BorderColor = System.Drawing.Color.LimeGreen
        Me.GunaButton1.BorderSize = 2
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(211, 258)
        Me.GunaButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.Green
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.GreenYellow
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 10
        Me.GunaButton1.Size = New System.Drawing.Size(133, 39)
        Me.GunaButton1.TabIndex = 12
        Me.GunaButton1.Text = "CONFIRMAR"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(196, 178)
        Me.GunaLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(130, 21)
        Me.GunaLabel5.TabIndex = 15
        Me.GunaLabel5.Text = "REPETIR SENHA"
        '
        'txt_repetirSenha
        '
        Me.txt_repetirSenha.BackColor = System.Drawing.Color.Transparent
        Me.txt_repetirSenha.BaseColor = System.Drawing.Color.White
        Me.txt_repetirSenha.BorderColor = System.Drawing.Color.Silver
        Me.txt_repetirSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_repetirSenha.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_repetirSenha.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_repetirSenha.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_repetirSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_repetirSenha.Location = New System.Drawing.Point(196, 201)
        Me.txt_repetirSenha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_repetirSenha.Name = "txt_repetirSenha"
        Me.txt_repetirSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_repetirSenha.Radius = 5
        Me.txt_repetirSenha.SelectedText = ""
        Me.txt_repetirSenha.Size = New System.Drawing.Size(173, 26)
        Me.txt_repetirSenha.TabIndex = 14
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(196, 105)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(114, 21)
        Me.GunaLabel4.TabIndex = 13
        Me.GunaLabel4.Text = "NOVA SENHA"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(196, 36)
        Me.GunaLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(38, 21)
        Me.GunaLabel3.TabIndex = 13
        Me.GunaLabel3.Text = "CPF"
        '
        'txt_novaSenha
        '
        Me.txt_novaSenha.AcceptsReturn = True
        Me.txt_novaSenha.BackColor = System.Drawing.Color.Transparent
        Me.txt_novaSenha.BaseColor = System.Drawing.Color.White
        Me.txt_novaSenha.BorderColor = System.Drawing.Color.Silver
        Me.txt_novaSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_novaSenha.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_novaSenha.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_novaSenha.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_novaSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_novaSenha.Location = New System.Drawing.Point(196, 127)
        Me.txt_novaSenha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_novaSenha.Name = "txt_novaSenha"
        Me.txt_novaSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_novaSenha.Radius = 5
        Me.txt_novaSenha.SelectedText = ""
        Me.txt_novaSenha.Size = New System.Drawing.Size(173, 26)
        Me.txt_novaSenha.TabIndex = 12
        '
        'txt_cpfSenha
        '
        Me.txt_cpfSenha.BackColor = System.Drawing.Color.Transparent
        Me.txt_cpfSenha.BaseColor = System.Drawing.Color.White
        Me.txt_cpfSenha.BorderColor = System.Drawing.Color.Silver
        Me.txt_cpfSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpfSenha.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_cpfSenha.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_cpfSenha.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_cpfSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cpfSenha.Location = New System.Drawing.Point(196, 61)
        Me.txt_cpfSenha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpfSenha.MaxLength = 11
        Me.txt_cpfSenha.Name = "txt_cpfSenha"
        Me.txt_cpfSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cpfSenha.Radius = 5
        Me.txt_cpfSenha.SelectedText = ""
        Me.txt_cpfSenha.Size = New System.Drawing.Size(173, 26)
        Me.txt_cpfSenha.TabIndex = 12
        '
        'frm_login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(839, 432)
        Me.Controls.Add(Me.GunaLinkLabel1)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.gbx_novaSenha)
        Me.Controls.Add(Me.img_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.img_login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_novaSenha.ResumeLayout(False)
        Me.gbx_novaSenha.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_login As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_senha As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_entrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents img_login As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLinkLabel1 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents gbx_novaSenha As GroupBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_repetirSenha As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_novaSenha As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_cpfSenha As Guna.UI.WinForms.GunaTextBox
End Class
