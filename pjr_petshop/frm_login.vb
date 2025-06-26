Public Class frm_login
    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click

    End Sub

    Private Sub gtxt_login_TextChanged(sender As Object, e As EventArgs) Handles txt_login.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbx_novaSenha.Visible = False
        conectar_banco()
        cargo = ""
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If txt_login.Text = "" Or txt_senha.Text = "" Then
            MsgBox("NÃO PODEM HAVER CAMPOS VAZIOS", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "FALHA")
            txt_login.Text = ""
            txt_senha.Text = ""
            txt_login.Focus()
        ElseIf txt_login.Text = "admin" And txt_senha.Text = "admin" Then
            txt_login.Text = ""
            txt_senha.Text = ""
            frm_controle.Show()
            Me.Close()
        ElseIf txt_login.Text <> "admin" And txt_senha.Text <> "admin" Then
            sql = $"select * from funcionario where cpf='{txt_login.Text}' and senha='{txt_senha.Text}'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                MsgBox($"Bem Vindo {rs.Fields(2).Value}.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "LOGIN")
                txt_login.Text = ""
                txt_senha.Text = ""
                cargo = rs.Fields(6).Value
                nome_func = rs.Fields(2).Value
                frm_controle.Show()
                Me.Close()
            Else
                MsgBox("LOGIN OU SENHA INCORRETOS", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "FALHA")
                txt_login.Text = ""
                txt_senha.Text = ""
                txt_login.Focus()
            End If
        End If
    End Sub

    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked
        If btnClick = False Then
            gbx_novaSenha.Visible = True
            txt_cpfSenha.Focus()
            btnClick = True
        Else
            gbx_novaSenha.Visible = False
            btnClick = False
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If txt_novaSenha.Text <> txt_repetirSenha.Text Then
            MsgBox("SENHA DIGITADA ESTA INCORRETA", vbCritical + vbOKOnly, "NOVA SENHA")
        Else
            sql = $"select * from funcionario where cpf='{txt_cpfSenha.Text}'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = $"update funcionario set senha='{txt_novaSenha.Text}' where cpf='{txt_cpfSenha.Text}'"
                rs = db.Execute(sql)
                MsgBox("Senha atualizada com sucesso!", vbInformation + vbOKOnly, "NOVA SENHA")
                gbx_novaSenha.Visible = False
            End If
        End If
    End Sub
End Class
