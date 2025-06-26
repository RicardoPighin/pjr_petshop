Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates

Public Class frm_controle

    Private Sub frm_controle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClick = False
        tbc_controle.Appearance = TabAppearance.FlatButtons
        tbc_controle.ItemSize = New Size(0, 1)
        tbc_controle.SizeMode = TabSizeMode.Fixed
        lbl_nome.Text = nome_func
        conectar_banco()
        carregar_dados()
        funcionario()
        tbc_controle.SelectedTab = tp_inicial
        id_compra = ultima_compra()
    End Sub

    Private Sub btn_consultaFunc_Click(sender As Object, e As EventArgs) Handles btn_consultaFunc.Click
        sql = $"select * from funcionario where cpf = {txt_cpfFunc.Text}"
        rs = db.Execute(sql)

        If rs.EOF = False Then
            txt_cpfFunc.Text = rs.Fields(1).Value
            txt_cpfFunc.Enabled = False
            txt_nomeFunc.Text = rs.Fields(2).Value
            txt_emailFunc.Text = rs.Fields(3).Value
            txt_celularFunc.Text = rs.Fields(4).Value
            cmb_cargo.Text = rs.Fields(6).Value
            txt_cepFunc.Text = rs.Fields(7).Value
            txt_ufFunc.Text = rs.Fields(8).Value
            txt_cidadeFunc.Text = rs.Fields(9).Value
            txt_bairroFunc.Text = rs.Fields(10).Value
            txt_logradouroFunc.Text = rs.Fields(11).Value
            txt_complementoFunc.Text = rs.Fields(12).Value
            If rs.Fields(13).Value <> "" Then
                img_funcionario.Load(rs.Fields(13).Value)
            Else
                img_funcionario.Image = Nothing
            End If
            txt_senha.Enabled = False
                txt_senhaConfirma.Enabled = False
                txt_senha.BorderColor = Color.Red
                txt_senha.BaseColor = Color.LightPink
                txt_senhaConfirma.BorderColor = Color.Red
                txt_senhaConfirma.BaseColor = Color.LightPink
                btn_verSenha.BaseColor = Color.LightPink
                btn_verConfirmaSenha.BaseColor = Color.LightPink
            End If
    End Sub

    Private Sub btn_verSenha_Click_1(sender As Object, e As EventArgs) Handles btn_verSenha.Click
        If btnClick = False Then
            txt_senha.PasswordChar = ""
            btnClick = True
        Else
            txt_senha.PasswordChar = "●"
            btnClick = False
        End If
    End Sub

    Private Sub btn_consultarClien_Click(sender As Object, e As EventArgs) Handles btn_consultarClien.Click
        sql = $"select * from cliente where cpf='{txt_cpfClien.Text}'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_cpfClien.Enabled = False
            txt_nomeClien.Text = rs.Fields(1).Value
            txt_emailClien.Text = rs.Fields(2).Value
            txt_celularClien.Text = rs.Fields(3).Value
            txt_cepClien.Text = rs.Fields(4).Value
            txt_ufClien.Text = rs.Fields(5).Value
            txt_cidadeClien.Text = rs.Fields(6).Value
            txt_bairroClien.Text = rs.Fields(7).Value
            txt_logradouroClien.Text = rs.Fields(8).Value
            txt_complementoClien.Text = rs.Fields(9).Value
            If rs.Fields(10).Value <> "" Then
                GunaPictureBox1.Load(rs.Fields(10).Value)
            Else
                GunaPictureBox1.Image = Nothing
            End If
        End If
        funcionario()
    End Sub

    Private Sub pnl_cliente_Click(sender As Object, e As EventArgs) Handles pnl_cliente.Click
        cor_original()
        pnl_cliente.BackColor = Color.FromArgb(167, 252, 228)
        tbc_controle.SelectedTab = tp_cliente
    End Sub

    Private Sub pnl_func_Click(sender As Object, e As EventArgs) Handles pnl_func.Click
        cor_original()
        pnl_func.BackColor = Color.FromArgb(167, 252, 228)
        tbc_controle.SelectedTab = tp_funcionarios
    End Sub
    Private Sub pnl_pet_Click(sender As Object, e As EventArgs) Handles pnl_pet.Click
        cor_original()
        pnl_pet.BackColor = Color.FromArgb(167, 252, 228)
        tbc_controle.SelectedTab = tp_animais
    End Sub
    Private Sub pnl_prod_Click(sender As Object, e As EventArgs) Handles pnl_prod.Click
        cor_original()
        pnl_prod.BackColor = Color.FromArgb(167, 252, 228)
        tbc_controle.SelectedTab = tp_produtos
    End Sub

    Private Sub btn_registrarFunc_Click_1(sender As Object, e As EventArgs) Handles btn_registrarFunc.Click
        Dim aux_cpf As String = txt_cpfFunc.Text
        If txt_cpfFunc.Text = "" Or txt_nomeFunc.Text = "" Or txt_emailFunc.Text = "" Or txt_celularFunc.Text = "" Or cmb_cargo.Text = "" Or txt_senha.Enabled = True And txt_senha.Text = "" Or txt_senhaConfirma.Enabled = True And txt_senhaConfirma.Text = "" Then
            MsgBox("NÃO PODEM HAVER CAMPOS VAZIOS", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "FALHA")
        ElseIf txt_senhaConfirma.Text <> txt_senha.Text Then
            MsgBox("ERRO NA DIGITAÇÃO DA SENHA", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "FALHA")
            txt_senha.Text = ""
            txt_senhaConfirma.Text = ""
            txt_senha.Focus()
        ElseIf txt_cpfFunc.Enabled = False And txt_cpfFunc.TextLength > 0 Then
            sql = $"select * from funcionario where cpf='{txt_cpfFunc.Text}'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                sql = UCase($"update funcionario set nome='{txt_nomeFunc.Text}',email='{txt_emailFunc.Text}',cargo='{cmb_cargo.SelectedItem}',celular='{txt_celularFunc.Text}',cep='{txt_cepFunc.Text}',uf='{txt_ufFunc.Text}',cidade='{txt_cidadeFunc.Text}',bairro='{txt_bairroFunc.Text}',logradouro='{txt_logradouroFunc.Text}',numero_casa='{txt_complementoFunc.Text}' where cpf='{txt_cpfFunc.Text}'")
                rs = db.Execute(sql)
                sql = $"update funcionario set foto='{diretorio_funcionario}' where cpf='{aux_cpf}'"
                rs = db.Execute(sql)
                MsgBox("Dados atualizados com sucesso!", vbInformation + vbOKOnly, "SUCESSO")
                limpa_funcionario()
                txt_cpfFunc.Enabled = True
                txt_cpfFunc.Focus()
            Else
                MsgBox("Erro na atualização do cadastro!", vbCritical + vbOKOnly, "FALHA")
            End If
        Else
            sql = $"select * from funcionario where cpf = '{txt_cpfFunc.Text}'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = UCase($"insert into funcionario (cpf,nome,email,celular,cargo,cep,uf,cidade,bairro,logradouro,numero_casa) values('{txt_cpfFunc.Text}','{txt_nomeFunc.Text}','{txt_emailFunc.Text}','{txt_celularFunc.Text}','{cmb_cargo.SelectedItem}','{txt_cepFunc.Text}','{txt_ufFunc.Text}','{txt_cidadeFunc.Text}','{txt_bairroFunc.Text}','{txt_logradouroFunc.Text}','{txt_complementoFunc.Text}')")
                rs = db.Execute(sql)
                sql = $"update funcionario set senha='{txt_senha.Text}', foto='{diretorio_funcionario}' where cpf='{aux_cpf}'"
                rs = db.Execute(sql)
                MsgBox("Dados Cadastratados com sucesso!", vbInformation + vbOKOnly, "SUCESSO")
                limpa_funcionario()
            Else
                MsgBox("CPF já cadastrado", vbExclamation + vbOKOnly, "ERRO")
            End If
        End If
    End Sub

    Private Sub btn_registrarClien_Click_1(sender As Object, e As EventArgs) Handles btn_registrarClien.Click
        Dim aux_cpf As String = txt_cpfClien.Text
        If txt_cpfClien.Text = "" Or txt_nomeClien.Text = "" Or txt_emailClien.Text = "" Or txt_celularClien.Text = "" Or txt_cepClien.Text = "" Or txt_cidadeClien.Text = "" Or txt_bairroClien.Text = "" Or txt_logradouroClien.Text = "" Or txt_complementoClien.Text = "" Or diretorio_cliente = "" Then
            MsgBox("NÃO PODEM HAVER CAMPOS VAZIOS", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "FALHA")
        Else
            sql = $"select * from cliente where cpf='{txt_cpfClien.Text}'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = UCase($"insert into cliente (cpf,nome,email,celular,cep,uf,cidade,bairro,logradouro,numero_casa) values ('{txt_cpfClien.Text}','{txt_nomeClien.Text}','{txt_emailClien.Text}','{txt_celularClien.Text}','{txt_cepClien.Text}','{txt_ufClien.Text}','{txt_cidadeClien.Text}','{txt_bairroClien.Text}','{txt_logradouroClien.Text}','{txt_complementoClien.Text}')")
                rs = db.Execute(sql)
                sql = $"update cliente set foto ='{diretorio_cliente}' where cpf='{aux_cpf}'"
                rs = db.Execute(sql)
                MsgBox("Dados Cadastratados com sucesso!", vbInformation + vbOKOnly, "SUCESSO")
                limpa_cliente()
            ElseIf rs.EOF = False And txt_cpfClien.Enabled = False Then
                sql = UCase($"update cliente set nome='{txt_nomeClien.Text}',email='{txt_emailClien.Text}',celular='{txt_celularClien.Text}',cep='{txt_cepClien.Text}',uf='{txt_ufClien.Text}',cidade='{txt_cidadeClien.Text}',bairro='{txt_bairroClien.Text}',logradouro='{txt_logradouroClien.Text}',numero_casa='{txt_complementoClien.Text}',foto='' where cpf='{txt_cpfClien.Text}'")
                rs = db.Execute(sql)
                sql = $"update cliente set foto ='{diretorio_cliente}' where cpf='{aux_cpf}'"
                rs = db.Execute(sql)
                MsgBox("Dados atualizados com sucesso!", vbInformation + vbOKOnly, "SUCESSO")
                limpa_cliente()
                txt_cpfClien.Enabled = True
                txt_cpfClien.Focus()
            Else
                MsgBox("CPF já cadastrado", vbExclamation + vbOKOnly, "AVISO")
            End If
        End If
    End Sub

    Private Sub btn_consultarPet_Click(sender As Object, e As EventArgs) Handles btn_consultarPet.Click
        cmb_pets.Items.Clear()
        aux = txt_cpfTutor.Text
        If txt_cpfTutor.Text = "" Then
            MsgBox("O campo de CPF esta vazio, insira um CPF.", vbInformation + vbOKOnly, "AVISO")
            txt_cpfTutor.Focus()
        ElseIf txt_cpfTutor.Text <> "" Then
            sql = $"select * from cliente where cpf='{txt_cpfTutor.Text}'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                resp = MsgBox("O CPF consultado não esta cadastrado no sistema. Deseja cadastra-lo?", vbInformation + vbYesNo, "AVISO")
                If resp = vbYes Then
                    tbc_controle.SelectedTab = tp_cliente
                    cor_original()
                    pnl_cliente.BackColor = Color.FromArgb(167, 252, 228)
                    txt_cpfTutor.Text = ""
                    txt_cpfClien.Text = aux
                    txt_nomeClien.Focus()
                End If
            Else
                sql = $"select * from pet where cpf_tutor='{txt_cpfTutor.Text}'"
                rs = db.Execute(sql)
                While Not rs.EOF
                    cmb_pets.Items.Add(rs.Fields(1).Value.ToString())
                    rs.MoveNext()
                End While
                cmb_pets.SelectedIndex = -1
                cmb_pets.Focus()
                txt_cpfTutor.Enabled = False
            End If
        End If
    End Sub

    Private Sub txt_cepClien_LostFocus(sender As Object, e As EventArgs) Handles txt_cepClien.LostFocus
        Dim cep As String = txt_cepClien.Text.Trim()
        If Not String.IsNullOrEmpty(cep) Then
            Dim endereco As Endereco = ViaCEP.ConsultarCEP(cep)
            If endereco IsNot Nothing And endereco.cep IsNot Nothing Then
                txt_ufClien.Text = endereco.uf
                txt_cidadeClien.Text = endereco.localidade
                txt_bairroClien.Text = endereco.bairro
                txt_logradouroClien.Text = endereco.logradouro
            End If
        End If
    End Sub
    Private Sub txt_cepClien_TextChanged(sender As Object, e As EventArgs) Handles txt_cepClien.TextChanged
        If bloqueioAtualizacao Then Exit Sub
        bloqueioAtualizacao = True

        Dim txt As Guna.UI.WinForms.GunaTextBox = CType(sender, Guna.UI.WinForms.GunaTextBox)
        Dim cep As String = New String(txt.Text.Where(AddressOf Char.IsDigit).ToArray())

        If cep.Length > 5 Then
            cep = cep.Insert(5, "-")
        End If

        txt.Text = cep
        txt.SelectionStart = txt.Text.Length

        bloqueioAtualizacao = False
    End Sub

    Private Sub txt_cepFunc_TextChanged(sender As Object, e As EventArgs) Handles txt_cepFunc.TextChanged
        If bloqueioAtualizacao Then Exit Sub
        bloqueioAtualizacao = True

        Dim txt As Guna.UI.WinForms.GunaTextBox = CType(sender, Guna.UI.WinForms.GunaTextBox)
        Dim cep As String = New String(txt.Text.Where(AddressOf Char.IsDigit).ToArray())

        If cep.Length > 5 Then
            cep = cep.Insert(5, "-")
        End If

        txt.Text = cep
        txt.SelectionStart = txt.Text.Length

        bloqueioAtualizacao = False
    End Sub

    Private Sub btn_verConfirmaSenha_Click(sender As Object, e As EventArgs) Handles btn_verConfirmaSenha.Click
        If btnClick = False Then
            txt_senhaConfirma.PasswordChar = ""
            btnClick = True
        Else
            txt_senhaConfirma.PasswordChar = "●"
            btnClick = False
        End If
    End Sub

    Private Sub txt_cepFunc_LostFocus(sender As Object, e As EventArgs) Handles txt_cepFunc.LostFocus
        Dim cep As String = txt_cepFunc.Text.Trim()
        If Not String.IsNullOrEmpty(cep) Then
            Dim endereco As Endereco = ViaCEP.ConsultarCEP(cep)
            If endereco IsNot Nothing And endereco.cep IsNot Nothing Then
                txt_ufFunc.Text = endereco.uf
                txt_cidadeFunc.Text = endereco.localidade
                txt_bairroFunc.Text = endereco.bairro
                txt_logradouroFunc.Text = endereco.logradouro
            End If
        End If
    End Sub

    Private Sub pnl_sair_Click(sender As Object, e As EventArgs) Handles pnl_sair.Click
        resp = MsgBox("Deseja sair do sistema?", vbQuestion + vbYesNo, "SAIR")
        If resp = vbYes Then
            frm_login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btn_registrarPet_Click(sender As Object, e As EventArgs) Handles btn_registrarPet.Click
        If txt_cpfTutor.TextLength > 0 And txt_cpfTutor.Enabled = True Then
            sql = $"select * from cliente where cpf={txt_cpfTutor.Text}"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                Dim aux_cpf As String = txt_cpfTutor.Text
                Dim aux_nome As String = txt_nomePet.Text
                sql = UCase($"insert into pet(nome_pet,especie,raca,descricao,cpf_tutor) values('{txt_nomePet.Text}','{txt_especie.Text}','{txt_raca.Text}','{txt_desc.Text}','{txt_cpfTutor.Text}')")
                rs = db.Execute(sql)
                sql = $"update pet set foto='{diretorio_pet}' where nome_pet='{aux_nome}' and cpf_tutor='{aux_cpf}'"
                rs = db.Execute(sql)
                MsgBox($"{cmb_pets.Text} foi cadastrado com sucesso.", vbOKOnly + vbInformation, "SUCESSO")
                limpa_pet()
            End If
        ElseIf txt_cpfTutor.TextLength > 0 And txt_cpfTutor.Enabled = False Then
            sql = $"update pet set nome_pet='{txt_nomePet.Text}',especie='{txt_especie.Text}',raca='{txt_raca.Text}',descricao='{txt_desc.Text}',foto='{diretorio_pet}' where id='{lbl_idPet.Text}'"
            rs = db.Execute(sql)
            MsgBox($"{cmb_pets.Text} foi atualizado com sucesso.", vbOKOnly + vbInformation, "SUCESSO")
            limpa_pet()
        End If
    End Sub

    Private Sub cmb_pets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_pets.SelectedIndexChanged
        sql = $"select * from pet where nome_pet='{cmb_pets.SelectedItem}' and cpf_tutor='{txt_cpfTutor.Text}'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_nomePet.Text = rs.Fields(1).Value
            txt_raca.Text = rs.Fields(3).Value
            txt_especie.Text = rs.Fields(2).Value
            txt_desc.Text = rs.Fields(4).Value
            If rs.Fields(6).Value <> "" Then
                img_pet.Load(rs.Fields(6).Value)
            Else
                img_pet.Image = Nothing
            End If
            lbl_idPet.Text = rs.Fields(0).Value
        End If
    End Sub

    Private Sub btn_limpaClien_Click(sender As Object, e As EventArgs) Handles btn_limpaClien.Click
        limpa_cliente()
        txt_cpfClien.Enabled = True
        txt_cpfClien.Focus()
        funcionario()
    End Sub

    Private Sub btn_limpaFunc_Click(sender As Object, e As EventArgs) Handles btn_limpaFunc.Click
        limpa_funcionario()
        txt_cpfFunc.Enabled = True
        txt_senha.Enabled = True
        txt_senhaConfirma.Enabled = True
        txt_cpfFunc.Focus()
    End Sub

    Private Sub txt_celularFunc_TextChanged(sender As Object, e As EventArgs) Handles txt_celularFunc.TextChanged
        If bloqueioAtualizacao Then Exit Sub
        bloqueioAtualizacao = True

        Dim txt As Guna.UI.WinForms.GunaTextBox = CType(sender, Guna.UI.WinForms.GunaTextBox)
        Dim cel As String = New String(txt.Text.Where(AddressOf Char.IsDigit).ToArray())

        If cel.Length > 5 Then
            cel = cel.Insert(5, "-")
        End If

        txt.Text = cel
        txt.SelectionStart = txt.Text.Length

        bloqueioAtualizacao = False
    End Sub

    Private Sub txt_celularClien_TextChanged(sender As Object, e As EventArgs) Handles txt_celularClien.TextChanged
        If bloqueioAtualizacao Then Exit Sub
        bloqueioAtualizacao = True

        Dim txt As Guna.UI.WinForms.GunaTextBox = CType(sender, Guna.UI.WinForms.GunaTextBox)
        Dim cel As String = New String(txt.Text.Where(AddressOf Char.IsDigit).ToArray())

        If cel.Length > 5 Then
            cel = cel.Insert(5, "-")
        End If

        txt.Text = cel
        txt.SelectionStart = txt.Text.Length

        bloqueioAtualizacao = False
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        aux = txt_preco.Text
        aux_preco = aux.Replace(","c, "."c)
        If txt_produto.Text = "" Or cmb_tipoProduto.SelectedItem = "" Or txt_preco.Text = "" Or txt_quantidade.Text = "" Or txt_descProd.Text = "" Then
            MsgBox("NÃO PODEM HAVER CAMPOS VAZIOS", vbCritical + vbOKOnly, "ATENÇÃO")
        Else
            sql = $"select * from produto where id={txt_idProd.Text}"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = UCase($"insert into produto(nome,tipo,preco,estoque,descricao) values('{txt_produto.Text}','{cmb_tipoProduto.SelectedItem}',{aux_preco},{txt_quantidade.Text},'{txt_descProd.Text}')")
                rs = db.Execute(sql)
                MsgBox("Produto cadastrado com sucesso", vbInformation + vbOKOnly, "SUCESSO")
                limpa_produto()
                carregar_dados()
            ElseIf rs.EOF = False And txt_idProd.Enabled = False Then
                sql = $"update produto set nome='{txt_produto.Text}', tipo='{cmb_tipoProduto.SelectedItem}', preco={aux_preco}, estoque={txt_quantidade.Text}, descricao='{txt_descProd.Text}' where id={txt_idProd.Text}"
                rs = db.Execute(sql)
                MsgBox("Produto atualizado com sucesso", vbInformation + vbOKOnly, "SUCESSO")
                limpa_produto()
                carregar_dados()
            End If
        End If
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        limpa_produto()
        txt_idProd.Enabled = True
        txt_produto.Focus()
        funcionario()
    End Sub

    Private Sub btn_registrarClien_MouseHover(sender As Object, e As EventArgs) Handles btn_registrarClien.MouseHover
        lbl_status.Text = "CADASTRAR"
        If txt_cpfClien.Enabled = False Then
            lbl_status.Text = "ATUALIZAR"
        End If
    End Sub
    Private Sub btn_registrarClien_MouseLeave(sender As Object, e As EventArgs) Handles btn_registrarClien.MouseLeave
        lbl_status.Text = ""
    End Sub

    Private Sub btn_registrarFunc_MouseHover(sender As Object, e As EventArgs) Handles btn_registrarFunc.MouseHover
        lbl_statusFunc.Text = "CADASTRAR"
        If txt_cpfFunc.Enabled = False Then
            lbl_statusFunc.Text = "ATUALIZAR"
        End If
    End Sub

    Private Sub btn_registrarFunc_MouseLeave(sender As Object, e As EventArgs) Handles btn_registrarFunc.MouseLeave
        lbl_statusFunc.Text = ""
    End Sub

    Private Sub btn_registrarPet_MouseHover(sender As Object, e As EventArgs) Handles btn_registrarPet.MouseHover
        lbl_statusPet.Text = "CADASTRAR"
        If txt_cpfTutor.Enabled = False Then
            lbl_statusPet.Text = "ATUALIZAR"
        End If
    End Sub
    Private Sub btn_registrarPet_MouseLeave(sender As Object, e As EventArgs) Handles btn_registrarPet.MouseLeave
        lbl_statusPet.Text = ""
    End Sub

    Private Sub btn_limpaPet_Click(sender As Object, e As EventArgs) Handles btn_limpaPet.Click
        limpa_pet()
    End Sub

    Private Sub btn_buscaProd_Click(sender As Object, e As EventArgs) Handles btn_buscaProd.Click
        aux = txt_idProd.Text
        sql = $"select * from produto where id={aux}"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_idProd.Enabled = False
            txt_produto.Text = rs.Fields(1).Value
            txt_preco.Text = rs.Fields(3).Value
            txt_quantidade.Text = rs.Fields(4).Value
            txt_descProd.Text = rs.Fields(5).Value
        Else
            MsgBox("Produto digitado ainda não cadastrado.", vbInformation + vbOKOnly, "ATENÇÃO")
        End If
        funcionario()
    End Sub

    Private Sub pnl_caixa_Click(sender As Object, e As EventArgs) Handles pnl_caixa.Click
        cor_original()
        pnl_caixa.BackColor = Color.FromArgb(167, 252, 228)
        tbc_controle.SelectedTab = tp_compra
    End Sub

    Private Sub btn_finalizaCompra_Click(sender As Object, e As EventArgs) Handles btn_finalizaCompra.Click
        Dim data_hora As Date = Date.Now
        aux_dataCompra = data_hora.ToString
        sql = $"insert into compra (data_compra,cpf_cliente) values('{aux_dataCompra}','{txt_cpfComprador.Text}')"
        rs = db.Execute(sql)
        MsgBox("COMPRA FINALIZADA", vbInformation + vbOKOnly, "CONCLUIDO")
        'pegando id da compra
        sql = $"select * from compra where data_compra='{aux_dataCompra}' and cpf_cliente='{txt_cpfComprador.Text}'"
        rs = db.Execute(sql)
        aux_idCompra = rs.Fields(0).Value
        'registrando itens da compra
        For Each row As DataGridViewRow In dgv_compra.Rows
            Dim id_compra As Integer = aux_idCompra
            Dim id_produto As Integer = Convert.ToInt32(row.Cells("ID").Value)
            Dim nome_prod As String = row.Cells("PRODUTO").Value.ToString()
            Dim preco_prod As Decimal = Convert.ToDecimal(row.Cells("PREÇO").Value)

            preco_prod.ToString.Replace(","c, "."c)

            sql = $"insert into prodcomprado (id_compra,id_produto,nome_prod,preco_produto) VALUES ('{id_compra}','{id_produto}','{nome_prod}','{preco_prod}')"
            rs = db.Execute(sql)
        Next
        limpa_compra()
        atualiza_estoque(id_compra)
        id_compra = ultima_compra()
        carregar_dados()
    End Sub

    Private Sub btn_consultaCompra_Click(sender As Object, e As EventArgs) Handles btn_consultaCompra.Click
        cmb_compraAnterior.Items.Clear()
        aux = txt_cpfComprador.Text
        sql = $"select * from cliente where cpf = '{aux}'"
        rs = db.Execute(sql)
        If rs.EOF = True Then
            resp = MsgBox("Cliente não cadastrado ainda. Deseja realizar cadastro?", vbInformation + vbYesNo, "INFORMÇÃO")
            If resp = vbYes Then
                cor_original()
                tbc_controle.SelectedTab = tp_cliente
                txt_cpfClien.Text = aux
                txt_nomeClien.Focus()
            End If
        Else
            sql = $"select * from compra where cpf_cliente='{aux}'"
            rs = db.Execute(sql)
            While Not rs.EOF
                cmb_compraAnterior.Items.Add(rs.Fields(0).Value.ToString())
                rs.MoveNext()
            End While
            cmb_compraAnterior.Focus()
            txt_cpfComprador.Enabled = False
            txt_idProdComprado.Enabled = False
        End If
    End Sub

    Private Sub cmb_compraAnterior_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_compraAnterior.SelectedIndexChanged
        sql = $"select * from prodcomprado where id_compra='{cmb_compraAnterior.SelectedItem}'"
        rs = db.Execute(sql)
        dgv_compra.Rows.Clear()
        Do While rs.EOF = False
            dgv_compra.Rows.Add(rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub btn_limpaCompra_Click(sender As Object, e As EventArgs) Handles btn_limpaCompra.Click
        limpa_compra()
    End Sub
    Private Sub dgv_compra_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgv_compra.RowsAdded
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgv_compra.Rows
            Dim valor As Decimal
            If Decimal.TryParse(row.Cells("PREÇO").Value?.ToString(), valor) Then
                total += valor
            End If
        Next

        lbl_valorTotal.Text = $"VALOR TOTAL: {total}"
    End Sub

    Private Sub txt_idProdComprado_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_idProdComprado.KeyDown
        Dim quant As Integer
        If e.KeyCode = Keys.Enter Then
            sql = $"select * from produto where id={txt_idProdComprado.Text}"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                quant = rs.Fields(4).Value
                If quant > 0 Then
                    dgv_compra.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value)
                Else
                    MsgBox("Produto não esta disponivel.", vbExclamation + vbOKOnly, "ALERTA")
                End If
            End If
                e.SuppressKeyPress = True
            txt_idProdComprado.Text = ""
        End If
    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Title = "Selecione uma foto do Cliente"
            .InitialDirectory = Application.StartupPath & "\fotos_clientes"
            .ShowDialog()
            diretorio_cliente = .FileName
            diretorio_cliente = diretorio_cliente.Replace("\", "/")
            GunaPictureBox1.Load(diretorio_cliente)
        End With
    End Sub

    Private Sub img_funcionario_Click(sender As Object, e As EventArgs) Handles img_funcionario.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Title = "Selecione uma foto do Funcionario"
            .InitialDirectory = Application.StartupPath & "\fotos_funcionarios"
            .ShowDialog()
            diretorio_funcionario = .FileName
            diretorio_funcionario = diretorio_funcionario.Replace("\", "/")
            img_funcionario.Load(diretorio_funcionario)
        End With
    End Sub

    Private Sub img_pet_Click(sender As Object, e As EventArgs) Handles img_pet.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Title = "Selecione uma foto do Pet"
            .InitialDirectory = Application.StartupPath & "\fotos_pets"
            .ShowDialog()
            diretorio_pet = .FileName
            diretorio_pet = diretorio_pet.Replace("\", "/")
            img_pet.Load(diretorio_pet)
        End With
    End Sub
End Class