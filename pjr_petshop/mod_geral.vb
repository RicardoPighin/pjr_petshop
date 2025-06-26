Imports System.Net
Imports System.Security.Cryptography
Imports Guna.UI.WinForms
Imports Newtonsoft.Json

Module mod_geral
    Public sql, aux, aux_preco, cargo, aux_dataCompra, aux_idCompra, diretorio_cliente, diretorio_funcionario, diretorio_pet, nome_func As String
    Public id_compra As Integer
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public btnClick, emFoco, bloqueioAtualizacao As Boolean
    Public resp, cont
    Public Class Endereco
        Public Property cep As String
        Public Property logradouro As String
        Public Property complemento As String
        Public Property bairro As String
        Public Property localidade As String
        Public Property uf As String
        Public Property ibge As String
        Public Property gia As String
        Public Property ddd As String
        Public Property siafi As String
    End Class

    Public Class ViaCEP
        Public Shared Function ConsultarCEP(cep As String) As Endereco
            Dim url As String = $"https://viacep.com.br/ws/{cep}/json/"
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "GET"

            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using reader As New IO.StreamReader(response.GetResponseStream())
                    Dim jsonResponse As String = reader.ReadToEnd()
                    Return JsonConvert.DeserializeObject(Of Endereco)(jsonResponse)
                End Using
            End Using
        End Function
    End Class

    Public Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            'db.Open("Provider=SQLOLEDB;Data Source=Aluno27\SQLEXPRESS;Initial Catalog=petshop;trusted_connection=yes")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;DATABASE=petshop;UID=root;PWD=usbw;port=3307;option=3")
            frm_login.Text = "LOGIN - BANCO CONECTADO"
            frm_controle.Text = "CONTROLE - BANCO CONECTADO"
        Catch ex As Exception
            MsgBox("ERRO AO CONECTAR", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Public Sub limpa_funcionario()
        With frm_controle
            .txt_cpfFunc.Text = ""
            .txt_nomeFunc.Text = ""
            .txt_emailFunc.Text = ""
            .txt_celularFunc.Text = ""
            .cmb_cargo.StartIndex = -1
            .txt_senha.Text = ""
            .txt_senhaConfirma.Text = ""
            .txt_cepFunc.Text = ""
            .txt_ufFunc.Text = ""
            .txt_cidadeFunc.Text = ""
            .txt_bairroFunc.Text = ""
            .txt_logradouroFunc.Text = ""
            .txt_complementoFunc.Text = ""
            .txt_senha.BorderColor = Color.Silver
            .txt_senha.BaseColor = Color.White
            .txt_senhaConfirma.BorderColor = Color.Silver
            .txt_senhaConfirma.BaseColor = Color.White
            .btn_verSenha.BaseColor = Color.White
            .btn_verConfirmaSenha.BaseColor = Color.White
            .img_funcionario.Image = Nothing
            .txt_cpfFunc.Focus()
        End With
    End Sub
    Public Sub limpa_cliente()
        With frm_controle
            .txt_cpfClien.Text = ""
            .txt_nomeClien.Text = ""
            .txt_emailClien.Text = ""
            .txt_celularClien.Text = ""
            .txt_cepClien.Text = ""
            .txt_ufClien.Text = ""
            .txt_cidadeClien.Text = ""
            .txt_bairroClien.Text = ""
            .txt_logradouroClien.Text = ""
            .txt_complementoClien.Text = ""
            .GunaPictureBox1.Image = Nothing
            .txt_cpfClien.Focus()
        End With
    End Sub
    Public Sub limpa_pet()
        With frm_controle
            .txt_cpfTutor.Text = ""
            .txt_nomePet.Text = ""
            .txt_raca.Text = ""
            .txt_especie.Text = ""
            .txt_desc.Text = ""
            .img_pet.Image = Nothing
            .cmb_pets.Items.Clear()
            .txt_cpfTutor.Enabled = True
        End With
    End Sub
    Public Sub limpa_produto()
        With frm_controle
            .txt_idProd.Text = ""
            .txt_produto.Text = ""
            .cmb_tipoProduto.StartIndex = -1
            .txt_preco.Text = ""
            .txt_quantidade.Text = ""
            .txt_descProd.Text = ""
            .txt_idProd.Enabled = True
        End With
    End Sub

    Public Sub limpa_compra()
        With frm_controle
            .txt_cpfComprador.Text = ""
            .cmb_compraAnterior.Items.Clear()
            .txt_idProdComprado.Text = ""
            .dgv_compra.Rows.Clear()
            .txt_cpfComprador.Enabled = True
            .txt_idProdComprado.Enabled = True
            .lbl_valorTotal.Text = "VALOR TOTAL: "
        End With
    End Sub
    Public Sub cor_original()
        With frm_controle
            .pnl_prod.BackColor = Color.FromArgb(0, 184, 148)
            .pnl_cliente.BackColor = Color.FromArgb(0, 184, 148)
            .pnl_func.BackColor = Color.FromArgb(0, 184, 148)
            .pnl_pet.BackColor = Color.FromArgb(0, 184, 148)
            .pnl_caixa.BackColor = Color.FromArgb(0, 184, 148)
        End With
    End Sub
    Public Sub carregar_dados()
        sql = "select * from produto order by id asc"
        rs = db.Execute(sql)
        With frm_controle.dgv_produtos
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Public Sub funcionario()
        If cargo = "ATENDENTE" Then
            With frm_controle
                'negar acesso totalmente a aba de funcionarios
                .pnl_func.Enabled = False
                .pnl_func.Visible = False
                'não permitir criar usuario, apenas atualizar e consultar
                If .txt_cpfClien.Enabled = True Then
                    .btn_registrarClien.Enabled = False
                ElseIf .txt_cpfClien.Enabled = False Then
                    .btn_registrarClien.Enabled = True
                End If
                'não permitir cadastrar produtos, apenas atualizar e consultar
                If .txt_idProd.Enabled = True Then
                    .GunaAdvenceButton3.Enabled = False
                ElseIf .txt_idProd.Enabled = False Then
                    .GunaAdvenceButton3.Enabled = True
                End If
                'não permitir realizar compra apenas consultar
                .btn_finalizaCompra.Enabled = False
                .txt_idProdComprado.Enabled = False

            End With
        ElseIf cargo = "CAIXA" Then
            With frm_controle
                'negar acesso totalmente a aba de funcionarios
                .pnl_func.Enabled = False
                .pnl_func.Visible = False
                'negar acesso totalmente a aba de pets
                .pnl_pet.Enabled = False
                .pnl_pet.Visible = False
                'não permitir cadastrar produtos, apenas consultar
                .GunaAdvenceButton3.Enabled = False
            End With
        Else
            Exit Sub
        End If
    End Sub

    Public Function ultima_compra()
        Dim id_compra As Integer
        sql = $"select * from prodcomprado order by id_compra desc limit 1"
        rs = db.Execute(sql)
        id_compra = rs.Fields(1).Value
        Return id_compra
    End Function

    Public Sub atualiza_estoque(id_ultima_compra As Integer)
        Dim id, quant, novo_quant As Integer
        Dim rs0, rs1, rs2 As New ADODB.Recordset

        sql = $"select id_produto from prodcomprado where id_compra > '{id_ultima_compra}'"
        rs1 = db.Execute(sql)
        While Not rs1.EOF
            id = rs1.Fields(0).Value
            sql = $"select * from produto where id ='{id}'"
            rs2 = db.Execute(sql)
            If Not rs2.EOF Then
                quant = rs2.Fields(4).Value
                novo_quant = quant - 1
                sql = $"update produto set estoque='{novo_quant}' where id='{id}'"
                rs2 = db.Execute(sql)
            End If
            rs1.MoveNext()
        End While
    End Sub
End Module
