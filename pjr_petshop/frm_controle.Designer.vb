<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_controle
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_controle))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbc_controle = New System.Windows.Forms.TabControl()
        Me.tp_animais = New System.Windows.Forms.TabPage()
        Me.txt_nomePet = New Guna.UI.WinForms.GunaTextBox()
        Me.btn_consultarPet = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel15 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_desc = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel14 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_raca = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel37 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel13 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_especie = New Guna.UI.WinForms.GunaTextBox()
        Me.img_pet = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.cmb_pets = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_cpfTutor = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaShadowPanel3 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.btn_limpaPet = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lbl_statusPet = New Guna.UI.WinForms.GunaLabel()
        Me.btn_registrarPet = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.tp_funcionarios = New System.Windows.Forms.TabPage()
        Me.btn_verConfirmaSenha = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel35 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_ufFunc = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel34 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel17 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_verSenha = New Guna.UI.WinForms.GunaButton()
        Me.txt_complementoFunc = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_senhaConfirma = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel18 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel27 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_logradouroFunc = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel19 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel16 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_bairroFunc = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_senha = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel20 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel26 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_cidadeFunc = New Guna.UI.WinForms.GunaTextBox()
        Me.cmb_cargo = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel21 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_cepFunc = New Guna.UI.WinForms.GunaTextBox()
        Me.img_funcionario = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel22 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_celularFunc = New Guna.UI.WinForms.GunaTextBox()
        Me.btn_consultaFunc = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel23 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_emailFunc = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel24 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_nomeFunc = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel25 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_cpfFunc = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.lbl_statusFunc = New Guna.UI.WinForms.GunaLabel()
        Me.btn_limpaFunc = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_registrarFunc = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.tp_produtos = New System.Windows.Forms.TabPage()
        Me.dgv_produtos = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_buscaProd = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel32 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_descProd = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel31 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_quantidade = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel30 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_preco = New Guna.UI.WinForms.GunaTextBox()
        Me.cmb_tipoProduto = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel29 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel28 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_produto = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_idProduto = New Guna.UI.WinForms.GunaLabel()
        Me.txt_idProd = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.tp_compra = New System.Windows.Forms.TabPage()
        Me.lbl_valorTotal = New Guna.UI.WinForms.GunaLabel()
        Me.btn_consultaCompra = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel41 = New Guna.UI.WinForms.GunaLabel()
        Me.cmb_compraAnterior = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel40 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_idProdComprado = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel38 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_cpfComprador = New Guna.UI.WinForms.GunaTextBox()
        Me.dgv_compra = New Guna.UI.WinForms.GunaDataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PREÇO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaShadowPanel5 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.btn_limpaCompra = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_finalizaCompra = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.tp_cliente = New System.Windows.Forms.TabPage()
        Me.GunaLabel36 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_ufClien = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_complementoClien = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_logradouroClien = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_bairroClien = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_cidadeClien = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_cepClien = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_celularClien = New Guna.UI.WinForms.GunaTextBox()
        Me.btn_consultarClien = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_emailClien = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_nomeClien = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_cpfClien = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaShadowPanel4 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.lbl_status = New Guna.UI.WinForms.GunaLabel()
        Me.btn_limpaClien = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_registrarClien = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.tp_inicial = New System.Windows.Forms.TabPage()
        Me.lbl_nome = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel39 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaLabel33 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnl_caixa = New System.Windows.Forms.Panel()
        Me.pnl_sair = New System.Windows.Forms.Panel()
        Me.pnl_prod = New System.Windows.Forms.Panel()
        Me.pnl_func = New System.Windows.Forms.Panel()
        Me.pnl_pet = New System.Windows.Forms.Panel()
        Me.pnl_cliente = New System.Windows.Forms.Panel()
        Me.lbl_idPet = New System.Windows.Forms.Label()
        Me.tbc_controle.SuspendLayout()
        Me.tp_animais.SuspendLayout()
        CType(Me.img_pet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel3.SuspendLayout()
        Me.tp_funcionarios.SuspendLayout()
        CType(Me.img_funcionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel2.SuspendLayout()
        Me.tp_produtos.SuspendLayout()
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.tp_compra.SuspendLayout()
        CType(Me.dgv_compra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel5.SuspendLayout()
        Me.tp_cliente.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel4.SuspendLayout()
        Me.tp_inicial.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbc_controle
        '
        Me.tbc_controle.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tbc_controle.Controls.Add(Me.tp_animais)
        Me.tbc_controle.Controls.Add(Me.tp_funcionarios)
        Me.tbc_controle.Controls.Add(Me.tp_produtos)
        Me.tbc_controle.Controls.Add(Me.tp_compra)
        Me.tbc_controle.Controls.Add(Me.tp_cliente)
        Me.tbc_controle.Controls.Add(Me.tp_inicial)
        Me.tbc_controle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbc_controle.ItemSize = New System.Drawing.Size(100, 20)
        Me.tbc_controle.Location = New System.Drawing.Point(36, 36)
        Me.tbc_controle.Margin = New System.Windows.Forms.Padding(0)
        Me.tbc_controle.Multiline = True
        Me.tbc_controle.Name = "tbc_controle"
        Me.tbc_controle.SelectedIndex = 0
        Me.tbc_controle.Size = New System.Drawing.Size(985, 561)
        Me.tbc_controle.TabIndex = 0
        '
        'tp_animais
        '
        Me.tp_animais.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tp_animais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tp_animais.Controls.Add(Me.lbl_idPet)
        Me.tp_animais.Controls.Add(Me.txt_nomePet)
        Me.tp_animais.Controls.Add(Me.btn_consultarPet)
        Me.tp_animais.Controls.Add(Me.GunaLabel15)
        Me.tp_animais.Controls.Add(Me.txt_desc)
        Me.tp_animais.Controls.Add(Me.GunaLabel14)
        Me.tp_animais.Controls.Add(Me.txt_raca)
        Me.tp_animais.Controls.Add(Me.GunaLabel37)
        Me.tp_animais.Controls.Add(Me.GunaLabel13)
        Me.tp_animais.Controls.Add(Me.txt_especie)
        Me.tp_animais.Controls.Add(Me.img_pet)
        Me.tp_animais.Controls.Add(Me.GunaLabel12)
        Me.tp_animais.Controls.Add(Me.cmb_pets)
        Me.tp_animais.Controls.Add(Me.GunaLabel11)
        Me.tp_animais.Controls.Add(Me.txt_cpfTutor)
        Me.tp_animais.Controls.Add(Me.GunaShadowPanel3)
        Me.tp_animais.Location = New System.Drawing.Point(4, 24)
        Me.tp_animais.Margin = New System.Windows.Forms.Padding(2)
        Me.tp_animais.Name = "tp_animais"
        Me.tp_animais.Padding = New System.Windows.Forms.Padding(2)
        Me.tp_animais.Size = New System.Drawing.Size(977, 533)
        Me.tp_animais.TabIndex = 1
        Me.tp_animais.Text = "ANIMAIS"
        '
        'txt_nomePet
        '
        Me.txt_nomePet.BackColor = System.Drawing.Color.Transparent
        Me.txt_nomePet.BaseColor = System.Drawing.Color.White
        Me.txt_nomePet.BorderColor = System.Drawing.Color.Silver
        Me.txt_nomePet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nomePet.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_nomePet.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_nomePet.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_nomePet.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nomePet.Location = New System.Drawing.Point(261, 79)
        Me.txt_nomePet.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nomePet.Name = "txt_nomePet"
        Me.txt_nomePet.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nomePet.Radius = 5
        Me.txt_nomePet.SelectedText = ""
        Me.txt_nomePet.Size = New System.Drawing.Size(443, 26)
        Me.txt_nomePet.TabIndex = 62
        '
        'btn_consultarPet
        '
        Me.btn_consultarPet.AnimationHoverSpeed = 0.07!
        Me.btn_consultarPet.AnimationSpeed = 0.03!
        Me.btn_consultarPet.BackColor = System.Drawing.Color.Transparent
        Me.btn_consultarPet.BaseColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_consultarPet.BorderColor = System.Drawing.Color.SeaGreen
        Me.btn_consultarPet.BorderSize = 2
        Me.btn_consultarPet.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_consultarPet.FocusedColor = System.Drawing.Color.Empty
        Me.btn_consultarPet.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consultarPet.ForeColor = System.Drawing.Color.White
        Me.btn_consultarPet.Image = CType(resources.GetObject("btn_consultarPet.Image"), System.Drawing.Image)
        Me.btn_consultarPet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_consultarPet.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_consultarPet.Location = New System.Drawing.Point(229, 79)
        Me.btn_consultarPet.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_consultarPet.Name = "btn_consultarPet"
        Me.btn_consultarPet.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.btn_consultarPet.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_consultarPet.OnHoverForeColor = System.Drawing.Color.Honeydew
        Me.btn_consultarPet.OnHoverImage = Nothing
        Me.btn_consultarPet.OnPressedColor = System.Drawing.Color.Black
        Me.btn_consultarPet.Radius = 10
        Me.btn_consultarPet.Size = New System.Drawing.Size(28, 26)
        Me.btn_consultarPet.TabIndex = 61
        Me.btn_consultarPet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel15
        '
        Me.GunaLabel15.AutoSize = True
        Me.GunaLabel15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel15.Location = New System.Drawing.Point(13, 205)
        Me.GunaLabel15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel15.Name = "GunaLabel15"
        Me.GunaLabel15.Size = New System.Drawing.Size(98, 21)
        Me.GunaLabel15.TabIndex = 33
        Me.GunaLabel15.Text = "DESCRIÇÃO"
        '
        'txt_desc
        '
        Me.txt_desc.BackColor = System.Drawing.Color.Transparent
        Me.txt_desc.BaseColor = System.Drawing.Color.White
        Me.txt_desc.BorderColor = System.Drawing.Color.Silver
        Me.txt_desc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_desc.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_desc.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_desc.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_desc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_desc.Location = New System.Drawing.Point(17, 228)
        Me.txt_desc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_desc.Radius = 5
        Me.txt_desc.SelectedText = ""
        Me.txt_desc.Size = New System.Drawing.Size(687, 153)
        Me.txt_desc.TabIndex = 32
        '
        'GunaLabel14
        '
        Me.GunaLabel14.AutoSize = True
        Me.GunaLabel14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel14.Location = New System.Drawing.Point(13, 105)
        Me.GunaLabel14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel14.Name = "GunaLabel14"
        Me.GunaLabel14.Size = New System.Drawing.Size(52, 21)
        Me.GunaLabel14.TabIndex = 31
        Me.GunaLabel14.Text = "RAÇA"
        '
        'txt_raca
        '
        Me.txt_raca.BackColor = System.Drawing.Color.Transparent
        Me.txt_raca.BaseColor = System.Drawing.Color.White
        Me.txt_raca.BorderColor = System.Drawing.Color.Silver
        Me.txt_raca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_raca.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_raca.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_raca.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_raca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_raca.Location = New System.Drawing.Point(17, 128)
        Me.txt_raca.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_raca.Name = "txt_raca"
        Me.txt_raca.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_raca.Radius = 5
        Me.txt_raca.SelectedText = ""
        Me.txt_raca.Size = New System.Drawing.Size(335, 26)
        Me.txt_raca.TabIndex = 30
        '
        'GunaLabel37
        '
        Me.GunaLabel37.AutoSize = True
        Me.GunaLabel37.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel37.Location = New System.Drawing.Point(257, 56)
        Me.GunaLabel37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel37.Name = "GunaLabel37"
        Me.GunaLabel37.Size = New System.Drawing.Size(119, 21)
        Me.GunaLabel37.TabIndex = 29
        Me.GunaLabel37.Text = "NOME DO PET"
        '
        'GunaLabel13
        '
        Me.GunaLabel13.AutoSize = True
        Me.GunaLabel13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel13.Location = New System.Drawing.Point(352, 105)
        Me.GunaLabel13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel13.Name = "GunaLabel13"
        Me.GunaLabel13.Size = New System.Drawing.Size(71, 21)
        Me.GunaLabel13.TabIndex = 29
        Me.GunaLabel13.Text = "ESPECIE"
        '
        'txt_especie
        '
        Me.txt_especie.BackColor = System.Drawing.Color.Transparent
        Me.txt_especie.BaseColor = System.Drawing.Color.White
        Me.txt_especie.BorderColor = System.Drawing.Color.Silver
        Me.txt_especie.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_especie.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_especie.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_especie.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_especie.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_especie.Location = New System.Drawing.Point(356, 128)
        Me.txt_especie.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_especie.Name = "txt_especie"
        Me.txt_especie.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_especie.Radius = 5
        Me.txt_especie.SelectedText = ""
        Me.txt_especie.Size = New System.Drawing.Size(348, 26)
        Me.txt_especie.TabIndex = 28
        '
        'img_pet
        '
        Me.img_pet.BackColor = System.Drawing.Color.Transparent
        Me.img_pet.BaseColor = System.Drawing.Color.White
        Me.img_pet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_pet.Location = New System.Drawing.Point(739, 72)
        Me.img_pet.Margin = New System.Windows.Forms.Padding(2)
        Me.img_pet.Name = "img_pet"
        Me.img_pet.Radius = 5
        Me.img_pet.Size = New System.Drawing.Size(201, 201)
        Me.img_pet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_pet.TabIndex = 26
        Me.img_pet.TabStop = False
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel12.Location = New System.Drawing.Point(181, 158)
        Me.GunaLabel12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(47, 21)
        Me.GunaLabel12.TabIndex = 11
        Me.GunaLabel12.Text = "PETS"
        '
        'cmb_pets
        '
        Me.cmb_pets.BackColor = System.Drawing.Color.Transparent
        Me.cmb_pets.BaseColor = System.Drawing.Color.White
        Me.cmb_pets.BorderColor = System.Drawing.Color.Silver
        Me.cmb_pets.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_pets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pets.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_pets.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmb_pets.ForeColor = System.Drawing.Color.Black
        Me.cmb_pets.FormattingEnabled = True
        Me.cmb_pets.Location = New System.Drawing.Point(185, 181)
        Me.cmb_pets.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_pets.Name = "cmb_pets"
        Me.cmb_pets.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_pets.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_pets.Radius = 5
        Me.cmb_pets.Size = New System.Drawing.Size(348, 24)
        Me.cmb_pets.TabIndex = 10
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.Location = New System.Drawing.Point(12, 56)
        Me.GunaLabel11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(121, 21)
        Me.GunaLabel11.TabIndex = 9
        Me.GunaLabel11.Text = "CPF DO TUTOR"
        '
        'txt_cpfTutor
        '
        Me.txt_cpfTutor.BackColor = System.Drawing.Color.Transparent
        Me.txt_cpfTutor.BaseColor = System.Drawing.Color.White
        Me.txt_cpfTutor.BorderColor = System.Drawing.Color.Silver
        Me.txt_cpfTutor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpfTutor.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_cpfTutor.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_cpfTutor.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_cpfTutor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cpfTutor.Location = New System.Drawing.Point(16, 79)
        Me.txt_cpfTutor.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpfTutor.MaxLength = 11
        Me.txt_cpfTutor.Name = "txt_cpfTutor"
        Me.txt_cpfTutor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cpfTutor.Radius = 5
        Me.txt_cpfTutor.SelectedText = ""
        Me.txt_cpfTutor.Size = New System.Drawing.Size(209, 26)
        Me.txt_cpfTutor.TabIndex = 8
        '
        'GunaShadowPanel3
        '
        Me.GunaShadowPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaShadowPanel3.Controls.Add(Me.btn_limpaPet)
        Me.GunaShadowPanel3.Controls.Add(Me.lbl_statusPet)
        Me.GunaShadowPanel3.Controls.Add(Me.btn_registrarPet)
        Me.GunaShadowPanel3.Location = New System.Drawing.Point(336, 386)
        Me.GunaShadowPanel3.Name = "GunaShadowPanel3"
        Me.GunaShadowPanel3.Radius = 20
        Me.GunaShadowPanel3.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel3.ShadowDepth = 200
        Me.GunaShadowPanel3.ShadowShift = 6
        Me.GunaShadowPanel3.Size = New System.Drawing.Size(694, 200)
        Me.GunaShadowPanel3.TabIndex = 60
        '
        'btn_limpaPet
        '
        Me.btn_limpaPet.Animated = True
        Me.btn_limpaPet.AnimationHoverSpeed = 0.07!
        Me.btn_limpaPet.AnimationSpeed = 0.03!
        Me.btn_limpaPet.BackColor = System.Drawing.Color.Transparent
        Me.btn_limpaPet.BaseColor = System.Drawing.Color.Yellow
        Me.btn_limpaPet.BorderColor = System.Drawing.Color.Yellow
        Me.btn_limpaPet.BorderSize = 2
        Me.btn_limpaPet.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_limpaPet.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_limpaPet.CheckedForeColor = System.Drawing.Color.White
        Me.btn_limpaPet.CheckedImage = CType(resources.GetObject("btn_limpaPet.CheckedImage"), System.Drawing.Image)
        Me.btn_limpaPet.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_limpaPet.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_limpaPet.FocusedColor = System.Drawing.Color.Empty
        Me.btn_limpaPet.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpaPet.ForeColor = System.Drawing.Color.Black
        Me.btn_limpaPet.Image = CType(resources.GetObject("btn_limpaPet.Image"), System.Drawing.Image)
        Me.btn_limpaPet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_limpaPet.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_limpaPet.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_limpaPet.Location = New System.Drawing.Point(495, 30)
        Me.btn_limpaPet.Name = "btn_limpaPet"
        Me.btn_limpaPet.OnHoverBaseColor = System.Drawing.Color.Yellow
        Me.btn_limpaPet.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_limpaPet.OnHoverForeColor = System.Drawing.Color.Black
        Me.btn_limpaPet.OnHoverImage = Nothing
        Me.btn_limpaPet.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_limpaPet.OnPressedColor = System.Drawing.Color.Black
        Me.btn_limpaPet.Radius = 15
        Me.btn_limpaPet.Size = New System.Drawing.Size(57, 57)
        Me.btn_limpaPet.TabIndex = 66
        Me.btn_limpaPet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_statusPet
        '
        Me.lbl_statusPet.AutoSize = True
        Me.lbl_statusPet.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusPet.Location = New System.Drawing.Point(43, 40)
        Me.lbl_statusPet.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_statusPet.Name = "lbl_statusPet"
        Me.lbl_statusPet.Size = New System.Drawing.Size(0, 37)
        Me.lbl_statusPet.TabIndex = 65
        '
        'btn_registrarPet
        '
        Me.btn_registrarPet.Animated = True
        Me.btn_registrarPet.AnimationHoverSpeed = 0.07!
        Me.btn_registrarPet.AnimationSpeed = 0.03!
        Me.btn_registrarPet.BackColor = System.Drawing.Color.Transparent
        Me.btn_registrarPet.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_registrarPet.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_registrarPet.BorderSize = 2
        Me.btn_registrarPet.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_registrarPet.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_registrarPet.CheckedForeColor = System.Drawing.Color.White
        Me.btn_registrarPet.CheckedImage = CType(resources.GetObject("btn_registrarPet.CheckedImage"), System.Drawing.Image)
        Me.btn_registrarPet.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_registrarPet.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_registrarPet.FocusedColor = System.Drawing.Color.Empty
        Me.btn_registrarPet.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrarPet.ForeColor = System.Drawing.Color.White
        Me.btn_registrarPet.Image = CType(resources.GetObject("btn_registrarPet.Image"), System.Drawing.Image)
        Me.btn_registrarPet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_registrarPet.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_registrarPet.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_registrarPet.Location = New System.Drawing.Point(557, 30)
        Me.btn_registrarPet.Name = "btn_registrarPet"
        Me.btn_registrarPet.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_registrarPet.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_registrarPet.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_registrarPet.OnHoverImage = Nothing
        Me.btn_registrarPet.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_registrarPet.OnPressedColor = System.Drawing.Color.Black
        Me.btn_registrarPet.Radius = 15
        Me.btn_registrarPet.Size = New System.Drawing.Size(57, 57)
        Me.btn_registrarPet.TabIndex = 63
        Me.btn_registrarPet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tp_funcionarios
        '
        Me.tp_funcionarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tp_funcionarios.Controls.Add(Me.btn_verConfirmaSenha)
        Me.tp_funcionarios.Controls.Add(Me.GunaLabel35)
        Me.tp_funcionarios.Controls.Add(Me.txt_ufFunc)
        Me.tp_funcionarios.Controls.Add(Me.GunaLabel34)
        Me.tp_funcionarios.Controls.Add(Me.GunaLabel17)
        Me.tp_funcionarios.Controls.Add(Me.btn_verSenha)
        Me.tp_funcionarios.Controls.Add(Me.txt_complementoFunc)
        Me.tp_funcionarios.Controls.Add(Me.txt_senhaConfirma)
        Me.tp_funcionarios.Controls.Add(Me.GunaLabel18)
        Me.tp_funcionarios.Controls.Add(Me.GunaLabel27)
        Me.tp_funcionarios.Controls.Add(Me.txt_logradouroFunc)
        Me.tp_funcionarios.Controls.Add(Me.GunaLabel19)
        Me.tp_funcionarios.Controls.Add(Me.GunaLabel16)
        Me.tp_funcionarios.Controls.Add(Me.txt_bairroFunc)
        Me.tp_funcionarios.Controls.Add(Me.txt_senha)
        Me.tp_funcionarios.Controls.Add(Me.GunaLabel20)
        Me.tp_funcionarios.Controls.Add(Me.GunaLabel26)
        Me.tp_funcionarios.Controls.Add(Me.txt_cidadeFunc)
        Me.tp_funcionarios.Controls.Add(Me.cmb_cargo)
        Me.tp_funcionarios.Controls.Add(Me.GunaLabel21)
        Me.tp_funcionarios.Controls.Add(Me.txt_cepFunc)
        Me.tp_funcionarios.Controls.Add(Me.img_funcionario)
        Me.tp_funcionarios.Controls.Add(Me.GunaLabel22)
        Me.tp_funcionarios.Controls.Add(Me.txt_celularFunc)
        Me.tp_funcionarios.Controls.Add(Me.btn_consultaFunc)
        Me.tp_funcionarios.Controls.Add(Me.GunaLabel23)
        Me.tp_funcionarios.Controls.Add(Me.txt_emailFunc)
        Me.tp_funcionarios.Controls.Add(Me.GunaLabel24)
        Me.tp_funcionarios.Controls.Add(Me.txt_nomeFunc)
        Me.tp_funcionarios.Controls.Add(Me.GunaLabel25)
        Me.tp_funcionarios.Controls.Add(Me.txt_cpfFunc)
        Me.tp_funcionarios.Controls.Add(Me.GunaShadowPanel2)
        Me.tp_funcionarios.Location = New System.Drawing.Point(4, 24)
        Me.tp_funcionarios.Margin = New System.Windows.Forms.Padding(2)
        Me.tp_funcionarios.Name = "tp_funcionarios"
        Me.tp_funcionarios.Padding = New System.Windows.Forms.Padding(2)
        Me.tp_funcionarios.Size = New System.Drawing.Size(977, 533)
        Me.tp_funcionarios.TabIndex = 2
        Me.tp_funcionarios.Text = "FUNCIONÁRIOS"
        '
        'btn_verConfirmaSenha
        '
        Me.btn_verConfirmaSenha.AnimationHoverSpeed = 0.07!
        Me.btn_verConfirmaSenha.AnimationSpeed = 0.03!
        Me.btn_verConfirmaSenha.BackColor = System.Drawing.Color.Transparent
        Me.btn_verConfirmaSenha.BaseColor = System.Drawing.Color.White
        Me.btn_verConfirmaSenha.BorderColor = System.Drawing.Color.White
        Me.btn_verConfirmaSenha.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_verConfirmaSenha.FocusedColor = System.Drawing.Color.Empty
        Me.btn_verConfirmaSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_verConfirmaSenha.ForeColor = System.Drawing.Color.White
        Me.btn_verConfirmaSenha.Image = CType(resources.GetObject("btn_verConfirmaSenha.Image"), System.Drawing.Image)
        Me.btn_verConfirmaSenha.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_verConfirmaSenha.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_verConfirmaSenha.Location = New System.Drawing.Point(221, 453)
        Me.btn_verConfirmaSenha.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_verConfirmaSenha.Name = "btn_verConfirmaSenha"
        Me.btn_verConfirmaSenha.OnHoverBaseColor = System.Drawing.Color.White
        Me.btn_verConfirmaSenha.OnHoverBorderColor = System.Drawing.Color.White
        Me.btn_verConfirmaSenha.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_verConfirmaSenha.OnHoverImage = Nothing
        Me.btn_verConfirmaSenha.OnPressedColor = System.Drawing.Color.White
        Me.btn_verConfirmaSenha.Size = New System.Drawing.Size(26, 18)
        Me.btn_verConfirmaSenha.TabIndex = 63
        '
        'GunaLabel35
        '
        Me.GunaLabel35.AutoSize = True
        Me.GunaLabel35.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel35.Location = New System.Drawing.Point(139, 233)
        Me.GunaLabel35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel35.Name = "GunaLabel35"
        Me.GunaLabel35.Size = New System.Drawing.Size(30, 21)
        Me.GunaLabel35.TabIndex = 62
        Me.GunaLabel35.Text = "UF"
        '
        'txt_ufFunc
        '
        Me.txt_ufFunc.BackColor = System.Drawing.Color.Transparent
        Me.txt_ufFunc.BaseColor = System.Drawing.Color.White
        Me.txt_ufFunc.BorderColor = System.Drawing.Color.Silver
        Me.txt_ufFunc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_ufFunc.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_ufFunc.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_ufFunc.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_ufFunc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_ufFunc.Location = New System.Drawing.Point(127, 256)
        Me.txt_ufFunc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_ufFunc.MaxLength = 2
        Me.txt_ufFunc.Name = "txt_ufFunc"
        Me.txt_ufFunc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ufFunc.Radius = 5
        Me.txt_ufFunc.SelectedText = ""
        Me.txt_ufFunc.Size = New System.Drawing.Size(53, 26)
        Me.txt_ufFunc.TabIndex = 61
        Me.txt_ufFunc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel34
        '
        Me.GunaLabel34.AutoSize = True
        Me.GunaLabel34.Font = New System.Drawing.Font("Segoe UI", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel34.Location = New System.Drawing.Point(19, 197)
        Me.GunaLabel34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel34.Name = "GunaLabel34"
        Me.GunaLabel34.Size = New System.Drawing.Size(109, 25)
        Me.GunaLabel34.TabIndex = 60
        Me.GunaLabel34.Text = "ENDEREÇO"
        '
        'GunaLabel17
        '
        Me.GunaLabel17.AutoSize = True
        Me.GunaLabel17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel17.Location = New System.Drawing.Point(700, 294)
        Me.GunaLabel17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel17.Name = "GunaLabel17"
        Me.GunaLabel17.Size = New System.Drawing.Size(168, 21)
        Me.GunaLabel17.TabIndex = 46
        Me.GunaLabel17.Text = "Nº E COMPLEMENTO"
        '
        'btn_verSenha
        '
        Me.btn_verSenha.AnimationHoverSpeed = 0.07!
        Me.btn_verSenha.AnimationSpeed = 0.03!
        Me.btn_verSenha.BackColor = System.Drawing.Color.Transparent
        Me.btn_verSenha.BaseColor = System.Drawing.Color.White
        Me.btn_verSenha.BorderColor = System.Drawing.Color.White
        Me.btn_verSenha.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_verSenha.FocusedColor = System.Drawing.Color.Empty
        Me.btn_verSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_verSenha.ForeColor = System.Drawing.Color.White
        Me.btn_verSenha.Image = CType(resources.GetObject("btn_verSenha.Image"), System.Drawing.Image)
        Me.btn_verSenha.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_verSenha.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_verSenha.Location = New System.Drawing.Point(221, 392)
        Me.btn_verSenha.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_verSenha.Name = "btn_verSenha"
        Me.btn_verSenha.OnHoverBaseColor = System.Drawing.Color.White
        Me.btn_verSenha.OnHoverBorderColor = System.Drawing.Color.White
        Me.btn_verSenha.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_verSenha.OnHoverImage = Nothing
        Me.btn_verSenha.OnPressedColor = System.Drawing.Color.White
        Me.btn_verSenha.Size = New System.Drawing.Size(26, 18)
        Me.btn_verSenha.TabIndex = 58
        '
        'txt_complementoFunc
        '
        Me.txt_complementoFunc.BackColor = System.Drawing.Color.Transparent
        Me.txt_complementoFunc.BaseColor = System.Drawing.Color.White
        Me.txt_complementoFunc.BorderColor = System.Drawing.Color.Silver
        Me.txt_complementoFunc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_complementoFunc.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_complementoFunc.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_complementoFunc.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_complementoFunc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_complementoFunc.Location = New System.Drawing.Point(704, 317)
        Me.txt_complementoFunc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_complementoFunc.Name = "txt_complementoFunc"
        Me.txt_complementoFunc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_complementoFunc.Radius = 5
        Me.txt_complementoFunc.SelectedText = ""
        Me.txt_complementoFunc.Size = New System.Drawing.Size(186, 26)
        Me.txt_complementoFunc.TabIndex = 45
        '
        'txt_senhaConfirma
        '
        Me.txt_senhaConfirma.BackColor = System.Drawing.Color.Transparent
        Me.txt_senhaConfirma.BaseColor = System.Drawing.Color.White
        Me.txt_senhaConfirma.BorderColor = System.Drawing.Color.Silver
        Me.txt_senhaConfirma.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senhaConfirma.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_senhaConfirma.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_senhaConfirma.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_senhaConfirma.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_senhaConfirma.Location = New System.Drawing.Point(24, 449)
        Me.txt_senhaConfirma.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_senhaConfirma.Name = "txt_senhaConfirma"
        Me.txt_senhaConfirma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_senhaConfirma.Radius = 5
        Me.txt_senhaConfirma.SelectedText = ""
        Me.txt_senhaConfirma.Size = New System.Drawing.Size(229, 26)
        Me.txt_senhaConfirma.TabIndex = 57
        '
        'GunaLabel18
        '
        Me.GunaLabel18.AutoSize = True
        Me.GunaLabel18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel18.Location = New System.Drawing.Point(210, 294)
        Me.GunaLabel18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel18.Name = "GunaLabel18"
        Me.GunaLabel18.Size = New System.Drawing.Size(120, 21)
        Me.GunaLabel18.TabIndex = 44
        Me.GunaLabel18.Text = "LOGRADOURO"
        '
        'GunaLabel27
        '
        Me.GunaLabel27.AutoSize = True
        Me.GunaLabel27.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel27.Location = New System.Drawing.Point(20, 426)
        Me.GunaLabel27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel27.Name = "GunaLabel27"
        Me.GunaLabel27.Size = New System.Drawing.Size(162, 21)
        Me.GunaLabel27.TabIndex = 56
        Me.GunaLabel27.Text = "CONFIRMAR SENHA"
        '
        'txt_logradouroFunc
        '
        Me.txt_logradouroFunc.BackColor = System.Drawing.Color.Transparent
        Me.txt_logradouroFunc.BaseColor = System.Drawing.Color.White
        Me.txt_logradouroFunc.BorderColor = System.Drawing.Color.Silver
        Me.txt_logradouroFunc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_logradouroFunc.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_logradouroFunc.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_logradouroFunc.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_logradouroFunc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_logradouroFunc.Location = New System.Drawing.Point(214, 317)
        Me.txt_logradouroFunc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_logradouroFunc.Name = "txt_logradouroFunc"
        Me.txt_logradouroFunc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_logradouroFunc.Radius = 5
        Me.txt_logradouroFunc.SelectedText = ""
        Me.txt_logradouroFunc.Size = New System.Drawing.Size(486, 26)
        Me.txt_logradouroFunc.TabIndex = 43
        '
        'GunaLabel19
        '
        Me.GunaLabel19.AutoSize = True
        Me.GunaLabel19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel19.Location = New System.Drawing.Point(20, 294)
        Me.GunaLabel19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel19.Name = "GunaLabel19"
        Me.GunaLabel19.Size = New System.Drawing.Size(68, 21)
        Me.GunaLabel19.TabIndex = 42
        Me.GunaLabel19.Text = "BAIRRO"
        '
        'GunaLabel16
        '
        Me.GunaLabel16.AutoSize = True
        Me.GunaLabel16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel16.Location = New System.Drawing.Point(20, 365)
        Me.GunaLabel16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel16.Name = "GunaLabel16"
        Me.GunaLabel16.Size = New System.Drawing.Size(64, 21)
        Me.GunaLabel16.TabIndex = 54
        Me.GunaLabel16.Text = "SENHA"
        '
        'txt_bairroFunc
        '
        Me.txt_bairroFunc.BackColor = System.Drawing.Color.Transparent
        Me.txt_bairroFunc.BaseColor = System.Drawing.Color.White
        Me.txt_bairroFunc.BorderColor = System.Drawing.Color.Silver
        Me.txt_bairroFunc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_bairroFunc.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_bairroFunc.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_bairroFunc.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_bairroFunc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_bairroFunc.Location = New System.Drawing.Point(24, 317)
        Me.txt_bairroFunc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_bairroFunc.Name = "txt_bairroFunc"
        Me.txt_bairroFunc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_bairroFunc.Radius = 5
        Me.txt_bairroFunc.SelectedText = ""
        Me.txt_bairroFunc.Size = New System.Drawing.Size(186, 26)
        Me.txt_bairroFunc.TabIndex = 41
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
        Me.txt_senha.Location = New System.Drawing.Point(24, 388)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_senha.Radius = 5
        Me.txt_senha.SelectedText = ""
        Me.txt_senha.Size = New System.Drawing.Size(229, 26)
        Me.txt_senha.TabIndex = 53
        '
        'GunaLabel20
        '
        Me.GunaLabel20.AutoSize = True
        Me.GunaLabel20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel20.Location = New System.Drawing.Point(180, 233)
        Me.GunaLabel20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel20.Name = "GunaLabel20"
        Me.GunaLabel20.Size = New System.Drawing.Size(69, 21)
        Me.GunaLabel20.TabIndex = 40
        Me.GunaLabel20.Text = "CIDADE"
        '
        'GunaLabel26
        '
        Me.GunaLabel26.AutoSize = True
        Me.GunaLabel26.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel26.Location = New System.Drawing.Point(541, 132)
        Me.GunaLabel26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel26.Name = "GunaLabel26"
        Me.GunaLabel26.Size = New System.Drawing.Size(64, 21)
        Me.GunaLabel26.TabIndex = 51
        Me.GunaLabel26.Text = "CARGO"
        '
        'txt_cidadeFunc
        '
        Me.txt_cidadeFunc.BackColor = System.Drawing.Color.Transparent
        Me.txt_cidadeFunc.BaseColor = System.Drawing.Color.White
        Me.txt_cidadeFunc.BorderColor = System.Drawing.Color.Silver
        Me.txt_cidadeFunc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cidadeFunc.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_cidadeFunc.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_cidadeFunc.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_cidadeFunc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cidadeFunc.Location = New System.Drawing.Point(184, 256)
        Me.txt_cidadeFunc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cidadeFunc.Name = "txt_cidadeFunc"
        Me.txt_cidadeFunc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cidadeFunc.Radius = 5
        Me.txt_cidadeFunc.SelectedText = ""
        Me.txt_cidadeFunc.Size = New System.Drawing.Size(383, 26)
        Me.txt_cidadeFunc.TabIndex = 39
        '
        'cmb_cargo
        '
        Me.cmb_cargo.BackColor = System.Drawing.Color.Transparent
        Me.cmb_cargo.BaseColor = System.Drawing.Color.White
        Me.cmb_cargo.BorderColor = System.Drawing.Color.Silver
        Me.cmb_cargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cargo.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_cargo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmb_cargo.ForeColor = System.Drawing.Color.Black
        Me.cmb_cargo.FormattingEnabled = True
        Me.cmb_cargo.Items.AddRange(New Object() {"", "GERENTE", "ATENDENTE", "CAIXA"})
        Me.cmb_cargo.Location = New System.Drawing.Point(545, 155)
        Me.cmb_cargo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_cargo.Name = "cmb_cargo"
        Me.cmb_cargo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_cargo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_cargo.Radius = 5
        Me.cmb_cargo.Size = New System.Drawing.Size(160, 24)
        Me.cmb_cargo.TabIndex = 50
        '
        'GunaLabel21
        '
        Me.GunaLabel21.AutoSize = True
        Me.GunaLabel21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel21.Location = New System.Drawing.Point(20, 233)
        Me.GunaLabel21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel21.Name = "GunaLabel21"
        Me.GunaLabel21.Size = New System.Drawing.Size(39, 21)
        Me.GunaLabel21.TabIndex = 38
        Me.GunaLabel21.Text = "CEP"
        '
        'txt_cepFunc
        '
        Me.txt_cepFunc.BackColor = System.Drawing.Color.Transparent
        Me.txt_cepFunc.BaseColor = System.Drawing.Color.White
        Me.txt_cepFunc.BorderColor = System.Drawing.Color.Silver
        Me.txt_cepFunc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cepFunc.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_cepFunc.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_cepFunc.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_cepFunc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cepFunc.Location = New System.Drawing.Point(24, 256)
        Me.txt_cepFunc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cepFunc.MaxLength = 9
        Me.txt_cepFunc.Name = "txt_cepFunc"
        Me.txt_cepFunc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cepFunc.Radius = 5
        Me.txt_cepFunc.SelectedText = ""
        Me.txt_cepFunc.Size = New System.Drawing.Size(99, 26)
        Me.txt_cepFunc.TabIndex = 37
        '
        'img_funcionario
        '
        Me.img_funcionario.BackColor = System.Drawing.Color.Transparent
        Me.img_funcionario.BaseColor = System.Drawing.Color.White
        Me.img_funcionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_funcionario.Location = New System.Drawing.Point(784, 72)
        Me.img_funcionario.Margin = New System.Windows.Forms.Padding(2)
        Me.img_funcionario.Name = "img_funcionario"
        Me.img_funcionario.Radius = 5
        Me.img_funcionario.Size = New System.Drawing.Size(123, 150)
        Me.img_funcionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_funcionario.TabIndex = 47
        Me.img_funcionario.TabStop = False
        '
        'GunaLabel22
        '
        Me.GunaLabel22.AutoSize = True
        Me.GunaLabel22.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel22.Location = New System.Drawing.Point(542, 73)
        Me.GunaLabel22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel22.Name = "GunaLabel22"
        Me.GunaLabel22.Size = New System.Drawing.Size(78, 21)
        Me.GunaLabel22.TabIndex = 36
        Me.GunaLabel22.Text = "CELULAR"
        '
        'txt_celularFunc
        '
        Me.txt_celularFunc.BackColor = System.Drawing.Color.Transparent
        Me.txt_celularFunc.BaseColor = System.Drawing.Color.White
        Me.txt_celularFunc.BorderColor = System.Drawing.Color.Silver
        Me.txt_celularFunc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_celularFunc.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_celularFunc.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_celularFunc.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_celularFunc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_celularFunc.Location = New System.Drawing.Point(546, 96)
        Me.txt_celularFunc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_celularFunc.MaxLength = 10
        Me.txt_celularFunc.Name = "txt_celularFunc"
        Me.txt_celularFunc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_celularFunc.Radius = 5
        Me.txt_celularFunc.SelectedText = ""
        Me.txt_celularFunc.Size = New System.Drawing.Size(159, 26)
        Me.txt_celularFunc.TabIndex = 35
        '
        'btn_consultaFunc
        '
        Me.btn_consultaFunc.AnimationHoverSpeed = 0.07!
        Me.btn_consultaFunc.AnimationSpeed = 0.03!
        Me.btn_consultaFunc.BackColor = System.Drawing.Color.Transparent
        Me.btn_consultaFunc.BaseColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_consultaFunc.BorderColor = System.Drawing.Color.SeaGreen
        Me.btn_consultaFunc.BorderSize = 2
        Me.btn_consultaFunc.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_consultaFunc.FocusedColor = System.Drawing.Color.Empty
        Me.btn_consultaFunc.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consultaFunc.ForeColor = System.Drawing.Color.White
        Me.btn_consultaFunc.Image = CType(resources.GetObject("btn_consultaFunc.Image"), System.Drawing.Image)
        Me.btn_consultaFunc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_consultaFunc.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_consultaFunc.Location = New System.Drawing.Point(231, 96)
        Me.btn_consultaFunc.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_consultaFunc.Name = "btn_consultaFunc"
        Me.btn_consultaFunc.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.btn_consultaFunc.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_consultaFunc.OnHoverForeColor = System.Drawing.Color.Honeydew
        Me.btn_consultaFunc.OnHoverImage = Nothing
        Me.btn_consultaFunc.OnPressedColor = System.Drawing.Color.Black
        Me.btn_consultaFunc.Radius = 10
        Me.btn_consultaFunc.Size = New System.Drawing.Size(28, 26)
        Me.btn_consultaFunc.TabIndex = 34
        Me.btn_consultaFunc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel23
        '
        Me.GunaLabel23.AutoSize = True
        Me.GunaLabel23.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel23.Location = New System.Drawing.Point(266, 73)
        Me.GunaLabel23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel23.Name = "GunaLabel23"
        Me.GunaLabel23.Size = New System.Drawing.Size(207, 21)
        Me.GunaLabel23.TabIndex = 33
        Me.GunaLabel23.Text = "E-MAIL DO FUNCIONÁRIO"
        '
        'txt_emailFunc
        '
        Me.txt_emailFunc.BackColor = System.Drawing.Color.Transparent
        Me.txt_emailFunc.BaseColor = System.Drawing.Color.White
        Me.txt_emailFunc.BorderColor = System.Drawing.Color.Silver
        Me.txt_emailFunc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_emailFunc.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_emailFunc.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_emailFunc.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_emailFunc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_emailFunc.Location = New System.Drawing.Point(270, 96)
        Me.txt_emailFunc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_emailFunc.Name = "txt_emailFunc"
        Me.txt_emailFunc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_emailFunc.Radius = 5
        Me.txt_emailFunc.SelectedText = ""
        Me.txt_emailFunc.Size = New System.Drawing.Size(272, 26)
        Me.txt_emailFunc.TabIndex = 32
        '
        'GunaLabel24
        '
        Me.GunaLabel24.AutoSize = True
        Me.GunaLabel24.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel24.Location = New System.Drawing.Point(14, 130)
        Me.GunaLabel24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel24.Name = "GunaLabel24"
        Me.GunaLabel24.Size = New System.Drawing.Size(202, 21)
        Me.GunaLabel24.TabIndex = 31
        Me.GunaLabel24.Text = "NOME DO FUNCIONÁRIO"
        '
        'txt_nomeFunc
        '
        Me.txt_nomeFunc.BackColor = System.Drawing.Color.Transparent
        Me.txt_nomeFunc.BaseColor = System.Drawing.Color.White
        Me.txt_nomeFunc.BorderColor = System.Drawing.Color.Silver
        Me.txt_nomeFunc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nomeFunc.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_nomeFunc.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_nomeFunc.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_nomeFunc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nomeFunc.Location = New System.Drawing.Point(18, 153)
        Me.txt_nomeFunc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nomeFunc.Name = "txt_nomeFunc"
        Me.txt_nomeFunc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nomeFunc.Radius = 5
        Me.txt_nomeFunc.SelectedText = ""
        Me.txt_nomeFunc.Size = New System.Drawing.Size(523, 26)
        Me.txt_nomeFunc.TabIndex = 30
        '
        'GunaLabel25
        '
        Me.GunaLabel25.AutoSize = True
        Me.GunaLabel25.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel25.Location = New System.Drawing.Point(14, 73)
        Me.GunaLabel25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel25.Name = "GunaLabel25"
        Me.GunaLabel25.Size = New System.Drawing.Size(38, 21)
        Me.GunaLabel25.TabIndex = 29
        Me.GunaLabel25.Text = "CPF"
        '
        'txt_cpfFunc
        '
        Me.txt_cpfFunc.BackColor = System.Drawing.Color.Transparent
        Me.txt_cpfFunc.BaseColor = System.Drawing.Color.White
        Me.txt_cpfFunc.BorderColor = System.Drawing.Color.Silver
        Me.txt_cpfFunc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpfFunc.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_cpfFunc.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_cpfFunc.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_cpfFunc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cpfFunc.Location = New System.Drawing.Point(18, 96)
        Me.txt_cpfFunc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpfFunc.MaxLength = 11
        Me.txt_cpfFunc.Name = "txt_cpfFunc"
        Me.txt_cpfFunc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cpfFunc.Radius = 5
        Me.txt_cpfFunc.SelectedText = ""
        Me.txt_cpfFunc.Size = New System.Drawing.Size(209, 26)
        Me.txt_cpfFunc.TabIndex = 28
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaShadowPanel2.Controls.Add(Me.lbl_statusFunc)
        Me.GunaShadowPanel2.Controls.Add(Me.btn_limpaFunc)
        Me.GunaShadowPanel2.Controls.Add(Me.btn_registrarFunc)
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(338, 388)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.Radius = 20
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel2.ShadowDepth = 200
        Me.GunaShadowPanel2.ShadowShift = 6
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(694, 200)
        Me.GunaShadowPanel2.TabIndex = 59
        '
        'lbl_statusFunc
        '
        Me.lbl_statusFunc.AutoSize = True
        Me.lbl_statusFunc.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusFunc.Location = New System.Drawing.Point(43, 40)
        Me.lbl_statusFunc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_statusFunc.Name = "lbl_statusFunc"
        Me.lbl_statusFunc.Size = New System.Drawing.Size(0, 37)
        Me.lbl_statusFunc.TabIndex = 64
        '
        'btn_limpaFunc
        '
        Me.btn_limpaFunc.Animated = True
        Me.btn_limpaFunc.AnimationHoverSpeed = 0.07!
        Me.btn_limpaFunc.AnimationSpeed = 0.03!
        Me.btn_limpaFunc.BackColor = System.Drawing.Color.Transparent
        Me.btn_limpaFunc.BaseColor = System.Drawing.Color.Yellow
        Me.btn_limpaFunc.BorderColor = System.Drawing.Color.Yellow
        Me.btn_limpaFunc.BorderSize = 2
        Me.btn_limpaFunc.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_limpaFunc.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_limpaFunc.CheckedForeColor = System.Drawing.Color.White
        Me.btn_limpaFunc.CheckedImage = CType(resources.GetObject("btn_limpaFunc.CheckedImage"), System.Drawing.Image)
        Me.btn_limpaFunc.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_limpaFunc.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_limpaFunc.FocusedColor = System.Drawing.Color.Empty
        Me.btn_limpaFunc.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpaFunc.ForeColor = System.Drawing.Color.Black
        Me.btn_limpaFunc.Image = CType(resources.GetObject("btn_limpaFunc.Image"), System.Drawing.Image)
        Me.btn_limpaFunc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_limpaFunc.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_limpaFunc.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_limpaFunc.Location = New System.Drawing.Point(495, 30)
        Me.btn_limpaFunc.Name = "btn_limpaFunc"
        Me.btn_limpaFunc.OnHoverBaseColor = System.Drawing.Color.Yellow
        Me.btn_limpaFunc.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_limpaFunc.OnHoverForeColor = System.Drawing.Color.Black
        Me.btn_limpaFunc.OnHoverImage = Nothing
        Me.btn_limpaFunc.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_limpaFunc.OnPressedColor = System.Drawing.Color.Black
        Me.btn_limpaFunc.Radius = 15
        Me.btn_limpaFunc.Size = New System.Drawing.Size(57, 57)
        Me.btn_limpaFunc.TabIndex = 64
        Me.btn_limpaFunc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_registrarFunc
        '
        Me.btn_registrarFunc.Animated = True
        Me.btn_registrarFunc.AnimationHoverSpeed = 0.07!
        Me.btn_registrarFunc.AnimationSpeed = 0.03!
        Me.btn_registrarFunc.BackColor = System.Drawing.Color.Transparent
        Me.btn_registrarFunc.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_registrarFunc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_registrarFunc.BorderSize = 2
        Me.btn_registrarFunc.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_registrarFunc.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_registrarFunc.CheckedForeColor = System.Drawing.Color.White
        Me.btn_registrarFunc.CheckedImage = CType(resources.GetObject("btn_registrarFunc.CheckedImage"), System.Drawing.Image)
        Me.btn_registrarFunc.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_registrarFunc.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_registrarFunc.FocusedColor = System.Drawing.Color.Empty
        Me.btn_registrarFunc.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrarFunc.ForeColor = System.Drawing.Color.White
        Me.btn_registrarFunc.Image = CType(resources.GetObject("btn_registrarFunc.Image"), System.Drawing.Image)
        Me.btn_registrarFunc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_registrarFunc.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_registrarFunc.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_registrarFunc.Location = New System.Drawing.Point(557, 30)
        Me.btn_registrarFunc.Name = "btn_registrarFunc"
        Me.btn_registrarFunc.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_registrarFunc.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_registrarFunc.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_registrarFunc.OnHoverImage = Nothing
        Me.btn_registrarFunc.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_registrarFunc.OnPressedColor = System.Drawing.Color.Black
        Me.btn_registrarFunc.Radius = 15
        Me.btn_registrarFunc.Size = New System.Drawing.Size(57, 57)
        Me.btn_registrarFunc.TabIndex = 0
        Me.btn_registrarFunc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tp_produtos
        '
        Me.tp_produtos.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tp_produtos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tp_produtos.Controls.Add(Me.dgv_produtos)
        Me.tp_produtos.Controls.Add(Me.btn_buscaProd)
        Me.tp_produtos.Controls.Add(Me.GunaLabel32)
        Me.tp_produtos.Controls.Add(Me.txt_descProd)
        Me.tp_produtos.Controls.Add(Me.GunaLabel31)
        Me.tp_produtos.Controls.Add(Me.txt_quantidade)
        Me.tp_produtos.Controls.Add(Me.GunaLabel30)
        Me.tp_produtos.Controls.Add(Me.txt_preco)
        Me.tp_produtos.Controls.Add(Me.cmb_tipoProduto)
        Me.tp_produtos.Controls.Add(Me.GunaLabel29)
        Me.tp_produtos.Controls.Add(Me.GunaLabel28)
        Me.tp_produtos.Controls.Add(Me.txt_produto)
        Me.tp_produtos.Controls.Add(Me.txt_idProduto)
        Me.tp_produtos.Controls.Add(Me.txt_idProd)
        Me.tp_produtos.Controls.Add(Me.GunaShadowPanel1)
        Me.tp_produtos.Location = New System.Drawing.Point(4, 24)
        Me.tp_produtos.Margin = New System.Windows.Forms.Padding(2)
        Me.tp_produtos.Name = "tp_produtos"
        Me.tp_produtos.Padding = New System.Windows.Forms.Padding(2)
        Me.tp_produtos.Size = New System.Drawing.Size(977, 533)
        Me.tp_produtos.TabIndex = 3
        Me.tp_produtos.Text = "PRODUTOS"
        '
        'dgv_produtos
        '
        Me.dgv_produtos.AllowUserToAddRows = False
        Me.dgv_produtos.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.dgv_produtos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_produtos.BackgroundColor = System.Drawing.Color.White
        Me.dgv_produtos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_produtos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_produtos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_produtos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_produtos.ColumnHeadersHeight = 21
        Me.dgv_produtos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(226, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(160, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_produtos.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_produtos.EnableHeadersVisualStyles = False
        Me.dgv_produtos.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dgv_produtos.Location = New System.Drawing.Point(33, 214)
        Me.dgv_produtos.Name = "dgv_produtos"
        Me.dgv_produtos.ReadOnly = True
        Me.dgv_produtos.RowHeadersVisible = False
        Me.dgv_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_produtos.Size = New System.Drawing.Size(881, 150)
        Me.dgv_produtos.TabIndex = 54
        Me.dgv_produtos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Emerald
        Me.dgv_produtos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.dgv_produtos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv_produtos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv_produtos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv_produtos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv_produtos.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv_produtos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dgv_produtos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.dgv_produtos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_produtos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_produtos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_produtos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv_produtos.ThemeStyle.HeaderStyle.Height = 21
        Me.dgv_produtos.ThemeStyle.ReadOnly = True
        Me.dgv_produtos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.dgv_produtos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_produtos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_produtos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv_produtos.ThemeStyle.RowsStyle.Height = 22
        Me.dgv_produtos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.dgv_produtos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "PRODUTO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "TIPO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "PREÇO"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "ESTOQUE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'btn_buscaProd
        '
        Me.btn_buscaProd.AnimationHoverSpeed = 0.07!
        Me.btn_buscaProd.AnimationSpeed = 0.03!
        Me.btn_buscaProd.BackColor = System.Drawing.Color.Transparent
        Me.btn_buscaProd.BaseColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_buscaProd.BorderColor = System.Drawing.Color.SeaGreen
        Me.btn_buscaProd.BorderSize = 2
        Me.btn_buscaProd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_buscaProd.FocusedColor = System.Drawing.Color.Empty
        Me.btn_buscaProd.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscaProd.ForeColor = System.Drawing.Color.White
        Me.btn_buscaProd.Image = CType(resources.GetObject("btn_buscaProd.Image"), System.Drawing.Image)
        Me.btn_buscaProd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_buscaProd.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_buscaProd.Location = New System.Drawing.Point(126, 36)
        Me.btn_buscaProd.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_buscaProd.Name = "btn_buscaProd"
        Me.btn_buscaProd.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.btn_buscaProd.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_buscaProd.OnHoverForeColor = System.Drawing.Color.Honeydew
        Me.btn_buscaProd.OnHoverImage = Nothing
        Me.btn_buscaProd.OnPressedColor = System.Drawing.Color.Black
        Me.btn_buscaProd.Radius = 10
        Me.btn_buscaProd.Size = New System.Drawing.Size(28, 26)
        Me.btn_buscaProd.TabIndex = 53
        Me.btn_buscaProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel32
        '
        Me.GunaLabel32.AutoSize = True
        Me.GunaLabel32.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel32.Location = New System.Drawing.Point(615, 69)
        Me.GunaLabel32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel32.Name = "GunaLabel32"
        Me.GunaLabel32.Size = New System.Drawing.Size(98, 21)
        Me.GunaLabel32.TabIndex = 51
        Me.GunaLabel32.Text = "DESCRIÇÃO"
        '
        'txt_descProd
        '
        Me.txt_descProd.BackColor = System.Drawing.Color.Transparent
        Me.txt_descProd.BaseColor = System.Drawing.Color.White
        Me.txt_descProd.BorderColor = System.Drawing.Color.Silver
        Me.txt_descProd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_descProd.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_descProd.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_descProd.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_descProd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_descProd.Location = New System.Drawing.Point(619, 92)
        Me.txt_descProd.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_descProd.Multiline = True
        Me.txt_descProd.Name = "txt_descProd"
        Me.txt_descProd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_descProd.Radius = 5
        Me.txt_descProd.SelectedText = ""
        Me.txt_descProd.Size = New System.Drawing.Size(295, 95)
        Me.txt_descProd.TabIndex = 50
        '
        'GunaLabel31
        '
        Me.GunaLabel31.AutoSize = True
        Me.GunaLabel31.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel31.Location = New System.Drawing.Point(311, 138)
        Me.GunaLabel31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel31.Name = "GunaLabel31"
        Me.GunaLabel31.Size = New System.Drawing.Size(116, 21)
        Me.GunaLabel31.TabIndex = 40
        Me.GunaLabel31.Text = "QUANTIDADE"
        '
        'txt_quantidade
        '
        Me.txt_quantidade.BackColor = System.Drawing.Color.Transparent
        Me.txt_quantidade.BaseColor = System.Drawing.Color.White
        Me.txt_quantidade.BorderColor = System.Drawing.Color.Silver
        Me.txt_quantidade.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_quantidade.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_quantidade.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_quantidade.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_quantidade.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_quantidade.Location = New System.Drawing.Point(315, 161)
        Me.txt_quantidade.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_quantidade.Name = "txt_quantidade"
        Me.txt_quantidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_quantidade.Radius = 5
        Me.txt_quantidade.SelectedText = ""
        Me.txt_quantidade.Size = New System.Drawing.Size(224, 26)
        Me.txt_quantidade.TabIndex = 39
        '
        'GunaLabel30
        '
        Me.GunaLabel30.AutoSize = True
        Me.GunaLabel30.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel30.Location = New System.Drawing.Point(29, 138)
        Me.GunaLabel30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel30.Name = "GunaLabel30"
        Me.GunaLabel30.Size = New System.Drawing.Size(61, 21)
        Me.GunaLabel30.TabIndex = 38
        Me.GunaLabel30.Text = "PREÇO"
        '
        'txt_preco
        '
        Me.txt_preco.BackColor = System.Drawing.Color.Transparent
        Me.txt_preco.BaseColor = System.Drawing.Color.White
        Me.txt_preco.BorderColor = System.Drawing.Color.Silver
        Me.txt_preco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_preco.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_preco.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_preco.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_preco.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_preco.Location = New System.Drawing.Point(33, 161)
        Me.txt_preco.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_preco.Radius = 5
        Me.txt_preco.SelectedText = ""
        Me.txt_preco.Size = New System.Drawing.Size(249, 26)
        Me.txt_preco.TabIndex = 37
        '
        'cmb_tipoProduto
        '
        Me.cmb_tipoProduto.BackColor = System.Drawing.Color.Transparent
        Me.cmb_tipoProduto.BaseColor = System.Drawing.Color.White
        Me.cmb_tipoProduto.BorderColor = System.Drawing.Color.Silver
        Me.cmb_tipoProduto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_tipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipoProduto.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_tipoProduto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmb_tipoProduto.ForeColor = System.Drawing.Color.Black
        Me.cmb_tipoProduto.FormattingEnabled = True
        Me.cmb_tipoProduto.Items.AddRange(New Object() {"ALIMENTAÇÃO", "HIGIENE", "ACESSÓRIO", "RECINTO", "OUTROS"})
        Me.cmb_tipoProduto.Location = New System.Drawing.Point(315, 95)
        Me.cmb_tipoProduto.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_tipoProduto.Name = "cmb_tipoProduto"
        Me.cmb_tipoProduto.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_tipoProduto.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_tipoProduto.Radius = 5
        Me.cmb_tipoProduto.Size = New System.Drawing.Size(225, 24)
        Me.cmb_tipoProduto.TabIndex = 36
        '
        'GunaLabel29
        '
        Me.GunaLabel29.AutoSize = True
        Me.GunaLabel29.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel29.Location = New System.Drawing.Point(311, 70)
        Me.GunaLabel29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel29.Name = "GunaLabel29"
        Me.GunaLabel29.Size = New System.Drawing.Size(151, 21)
        Me.GunaLabel29.TabIndex = 35
        Me.GunaLabel29.Text = "TIPO DE PRODUTO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GunaLabel28
        '
        Me.GunaLabel28.AutoSize = True
        Me.GunaLabel28.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel28.Location = New System.Drawing.Point(29, 70)
        Me.GunaLabel28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel28.Name = "GunaLabel28"
        Me.GunaLabel28.Size = New System.Drawing.Size(86, 21)
        Me.GunaLabel28.TabIndex = 33
        Me.GunaLabel28.Text = "PRODUTO"
        '
        'txt_produto
        '
        Me.txt_produto.BackColor = System.Drawing.Color.Transparent
        Me.txt_produto.BaseColor = System.Drawing.Color.White
        Me.txt_produto.BorderColor = System.Drawing.Color.Silver
        Me.txt_produto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_produto.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_produto.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_produto.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_produto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_produto.Location = New System.Drawing.Point(33, 92)
        Me.txt_produto.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_produto.Name = "txt_produto"
        Me.txt_produto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_produto.Radius = 5
        Me.txt_produto.SelectedText = ""
        Me.txt_produto.Size = New System.Drawing.Size(249, 26)
        Me.txt_produto.TabIndex = 32
        '
        'txt_idProduto
        '
        Me.txt_idProduto.AutoSize = True
        Me.txt_idProduto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idProduto.Location = New System.Drawing.Point(29, 14)
        Me.txt_idProduto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txt_idProduto.Name = "txt_idProduto"
        Me.txt_idProduto.Size = New System.Drawing.Size(27, 21)
        Me.txt_idProduto.TabIndex = 31
        Me.txt_idProduto.Text = "ID"
        '
        'txt_idProd
        '
        Me.txt_idProd.BackColor = System.Drawing.Color.Transparent
        Me.txt_idProd.BaseColor = System.Drawing.Color.White
        Me.txt_idProd.BorderColor = System.Drawing.Color.Silver
        Me.txt_idProd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_idProd.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_idProd.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_idProd.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_idProd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_idProd.Location = New System.Drawing.Point(33, 36)
        Me.txt_idProd.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_idProd.Name = "txt_idProd"
        Me.txt_idProd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_idProd.Radius = 5
        Me.txt_idProd.SelectedText = ""
        Me.txt_idProd.Size = New System.Drawing.Size(89, 26)
        Me.txt_idProd.TabIndex = 30
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaShadowPanel1.Controls.Add(Me.GunaAdvenceButton1)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaAdvenceButton3)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(336, 386)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 20
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowDepth = 200
        Me.GunaShadowPanel1.ShadowShift = 6
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(694, 200)
        Me.GunaShadowPanel1.TabIndex = 52
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Animated = True
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.Yellow
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Yellow
        Me.GunaAdvenceButton1.BorderSize = 2
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(495, 30)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Yellow
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 15
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(57, 57)
        Me.GunaAdvenceButton1.TabIndex = 65
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton3
        '
        Me.GunaAdvenceButton3.Animated = True
        Me.GunaAdvenceButton3.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton3.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton3.BorderSize = 2
        Me.GunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.CheckedImage = CType(resources.GetObject("GunaAdvenceButton3.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton3.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.Image = CType(resources.GetObject("GunaAdvenceButton3.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(557, 30)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Radius = 15
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(57, 57)
        Me.GunaAdvenceButton3.TabIndex = 63
        Me.GunaAdvenceButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tp_compra
        '
        Me.tp_compra.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tp_compra.Controls.Add(Me.lbl_valorTotal)
        Me.tp_compra.Controls.Add(Me.btn_consultaCompra)
        Me.tp_compra.Controls.Add(Me.GunaLabel41)
        Me.tp_compra.Controls.Add(Me.cmb_compraAnterior)
        Me.tp_compra.Controls.Add(Me.GunaLabel40)
        Me.tp_compra.Controls.Add(Me.txt_idProdComprado)
        Me.tp_compra.Controls.Add(Me.GunaLabel38)
        Me.tp_compra.Controls.Add(Me.txt_cpfComprador)
        Me.tp_compra.Controls.Add(Me.dgv_compra)
        Me.tp_compra.Controls.Add(Me.GunaShadowPanel5)
        Me.tp_compra.Location = New System.Drawing.Point(4, 24)
        Me.tp_compra.Name = "tp_compra"
        Me.tp_compra.Size = New System.Drawing.Size(977, 533)
        Me.tp_compra.TabIndex = 4
        Me.tp_compra.Text = "COMPRA"
        '
        'lbl_valorTotal
        '
        Me.lbl_valorTotal.AutoSize = True
        Me.lbl_valorTotal.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valorTotal.Location = New System.Drawing.Point(394, 348)
        Me.lbl_valorTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_valorTotal.Name = "lbl_valorTotal"
        Me.lbl_valorTotal.Size = New System.Drawing.Size(206, 37)
        Me.lbl_valorTotal.TabIndex = 65
        Me.lbl_valorTotal.Text = "VALOR TOTAL: "
        '
        'btn_consultaCompra
        '
        Me.btn_consultaCompra.AnimationHoverSpeed = 0.07!
        Me.btn_consultaCompra.AnimationSpeed = 0.03!
        Me.btn_consultaCompra.BackColor = System.Drawing.Color.Transparent
        Me.btn_consultaCompra.BaseColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_consultaCompra.BorderColor = System.Drawing.Color.SeaGreen
        Me.btn_consultaCompra.BorderSize = 2
        Me.btn_consultaCompra.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_consultaCompra.FocusedColor = System.Drawing.Color.Empty
        Me.btn_consultaCompra.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consultaCompra.ForeColor = System.Drawing.Color.White
        Me.btn_consultaCompra.Image = CType(resources.GetObject("btn_consultaCompra.Image"), System.Drawing.Image)
        Me.btn_consultaCompra.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_consultaCompra.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_consultaCompra.Location = New System.Drawing.Point(628, 61)
        Me.btn_consultaCompra.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_consultaCompra.Name = "btn_consultaCompra"
        Me.btn_consultaCompra.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.btn_consultaCompra.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_consultaCompra.OnHoverForeColor = System.Drawing.Color.Honeydew
        Me.btn_consultaCompra.OnHoverImage = Nothing
        Me.btn_consultaCompra.OnPressedColor = System.Drawing.Color.Black
        Me.btn_consultaCompra.Radius = 10
        Me.btn_consultaCompra.Size = New System.Drawing.Size(28, 26)
        Me.btn_consultaCompra.TabIndex = 63
        Me.btn_consultaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel41
        '
        Me.GunaLabel41.AutoSize = True
        Me.GunaLabel41.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel41.Location = New System.Drawing.Point(684, 40)
        Me.GunaLabel41.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel41.Name = "GunaLabel41"
        Me.GunaLabel41.Size = New System.Drawing.Size(188, 21)
        Me.GunaLabel41.TabIndex = 62
        Me.GunaLabel41.Text = "COMPRAS ANTERIORES"
        '
        'cmb_compraAnterior
        '
        Me.cmb_compraAnterior.BackColor = System.Drawing.Color.Transparent
        Me.cmb_compraAnterior.BaseColor = System.Drawing.Color.White
        Me.cmb_compraAnterior.BorderColor = System.Drawing.Color.Silver
        Me.cmb_compraAnterior.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_compraAnterior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_compraAnterior.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_compraAnterior.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmb_compraAnterior.ForeColor = System.Drawing.Color.Black
        Me.cmb_compraAnterior.FormattingEnabled = True
        Me.cmb_compraAnterior.Location = New System.Drawing.Point(688, 63)
        Me.cmb_compraAnterior.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_compraAnterior.Name = "cmb_compraAnterior"
        Me.cmb_compraAnterior.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_compraAnterior.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_compraAnterior.Radius = 5
        Me.cmb_compraAnterior.Size = New System.Drawing.Size(263, 24)
        Me.cmb_compraAnterior.TabIndex = 61
        '
        'GunaLabel40
        '
        Me.GunaLabel40.AutoSize = True
        Me.GunaLabel40.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel40.Location = New System.Drawing.Point(397, 144)
        Me.GunaLabel40.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel40.Name = "GunaLabel40"
        Me.GunaLabel40.Size = New System.Drawing.Size(107, 21)
        Me.GunaLabel40.TabIndex = 60
        Me.GunaLabel40.Text = "ID PRODUTO"
        '
        'txt_idProdComprado
        '
        Me.txt_idProdComprado.BackColor = System.Drawing.Color.Transparent
        Me.txt_idProdComprado.BaseColor = System.Drawing.Color.White
        Me.txt_idProdComprado.BorderColor = System.Drawing.Color.Silver
        Me.txt_idProdComprado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_idProdComprado.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_idProdComprado.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_idProdComprado.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_idProdComprado.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_idProdComprado.Location = New System.Drawing.Point(401, 167)
        Me.txt_idProdComprado.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_idProdComprado.MaxLength = 11
        Me.txt_idProdComprado.Name = "txt_idProdComprado"
        Me.txt_idProdComprado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_idProdComprado.Radius = 5
        Me.txt_idProdComprado.SelectedText = ""
        Me.txt_idProdComprado.Size = New System.Drawing.Size(223, 26)
        Me.txt_idProdComprado.TabIndex = 59
        '
        'GunaLabel38
        '
        Me.GunaLabel38.AutoSize = True
        Me.GunaLabel38.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel38.Location = New System.Drawing.Point(397, 38)
        Me.GunaLabel38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel38.Name = "GunaLabel38"
        Me.GunaLabel38.Size = New System.Drawing.Size(144, 21)
        Me.GunaLabel38.TabIndex = 56
        Me.GunaLabel38.Text = "CPF COMPRADOR"
        '
        'txt_cpfComprador
        '
        Me.txt_cpfComprador.BackColor = System.Drawing.Color.Transparent
        Me.txt_cpfComprador.BaseColor = System.Drawing.Color.White
        Me.txt_cpfComprador.BorderColor = System.Drawing.Color.Silver
        Me.txt_cpfComprador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpfComprador.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_cpfComprador.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_cpfComprador.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_cpfComprador.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cpfComprador.Location = New System.Drawing.Point(401, 61)
        Me.txt_cpfComprador.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpfComprador.MaxLength = 11
        Me.txt_cpfComprador.Name = "txt_cpfComprador"
        Me.txt_cpfComprador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cpfComprador.Radius = 5
        Me.txt_cpfComprador.SelectedText = ""
        Me.txt_cpfComprador.Size = New System.Drawing.Size(223, 26)
        Me.txt_cpfComprador.TabIndex = 55
        '
        'dgv_compra
        '
        Me.dgv_compra.AllowUserToAddRows = False
        Me.dgv_compra.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.dgv_compra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_compra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_compra.BackgroundColor = System.Drawing.Color.White
        Me.dgv_compra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_compra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_compra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_compra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_compra.ColumnHeadersHeight = 21
        Me.dgv_compra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.PRODUTO, Me.PREÇO})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(226, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(160, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_compra.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_compra.EnableHeadersVisualStyles = False
        Me.dgv_compra.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dgv_compra.Location = New System.Drawing.Point(19, 40)
        Me.dgv_compra.Name = "dgv_compra"
        Me.dgv_compra.ReadOnly = True
        Me.dgv_compra.RowHeadersVisible = False
        Me.dgv_compra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_compra.Size = New System.Drawing.Size(373, 348)
        Me.dgv_compra.TabIndex = 54
        Me.dgv_compra.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Emerald
        Me.dgv_compra.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.dgv_compra.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv_compra.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv_compra.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv_compra.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv_compra.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv_compra.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dgv_compra.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.dgv_compra.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_compra.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_compra.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_compra.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv_compra.ThemeStyle.HeaderStyle.Height = 21
        Me.dgv_compra.ThemeStyle.ReadOnly = True
        Me.dgv_compra.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.dgv_compra.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_compra.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_compra.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv_compra.ThemeStyle.RowsStyle.Height = 22
        Me.dgv_compra.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.dgv_compra.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'PRODUTO
        '
        Me.PRODUTO.FillWeight = 158.3756!
        Me.PRODUTO.HeaderText = "PRODUTO"
        Me.PRODUTO.Name = "PRODUTO"
        Me.PRODUTO.ReadOnly = True
        '
        'PREÇO
        '
        Me.PREÇO.FillWeight = 41.62436!
        Me.PREÇO.HeaderText = "PREÇO"
        Me.PREÇO.Name = "PREÇO"
        Me.PREÇO.ReadOnly = True
        '
        'GunaShadowPanel5
        '
        Me.GunaShadowPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaShadowPanel5.Controls.Add(Me.btn_limpaCompra)
        Me.GunaShadowPanel5.Controls.Add(Me.btn_finalizaCompra)
        Me.GunaShadowPanel5.Location = New System.Drawing.Point(338, 388)
        Me.GunaShadowPanel5.Name = "GunaShadowPanel5"
        Me.GunaShadowPanel5.Radius = 20
        Me.GunaShadowPanel5.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel5.ShadowDepth = 200
        Me.GunaShadowPanel5.ShadowShift = 6
        Me.GunaShadowPanel5.Size = New System.Drawing.Size(694, 200)
        Me.GunaShadowPanel5.TabIndex = 53
        '
        'btn_limpaCompra
        '
        Me.btn_limpaCompra.Animated = True
        Me.btn_limpaCompra.AnimationHoverSpeed = 0.07!
        Me.btn_limpaCompra.AnimationSpeed = 0.03!
        Me.btn_limpaCompra.BackColor = System.Drawing.Color.Transparent
        Me.btn_limpaCompra.BaseColor = System.Drawing.Color.Yellow
        Me.btn_limpaCompra.BorderColor = System.Drawing.Color.Yellow
        Me.btn_limpaCompra.BorderSize = 2
        Me.btn_limpaCompra.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_limpaCompra.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_limpaCompra.CheckedForeColor = System.Drawing.Color.White
        Me.btn_limpaCompra.CheckedImage = CType(resources.GetObject("btn_limpaCompra.CheckedImage"), System.Drawing.Image)
        Me.btn_limpaCompra.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_limpaCompra.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_limpaCompra.FocusedColor = System.Drawing.Color.Empty
        Me.btn_limpaCompra.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpaCompra.ForeColor = System.Drawing.Color.Black
        Me.btn_limpaCompra.Image = CType(resources.GetObject("btn_limpaCompra.Image"), System.Drawing.Image)
        Me.btn_limpaCompra.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_limpaCompra.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_limpaCompra.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_limpaCompra.Location = New System.Drawing.Point(424, 30)
        Me.btn_limpaCompra.Name = "btn_limpaCompra"
        Me.btn_limpaCompra.OnHoverBaseColor = System.Drawing.Color.Yellow
        Me.btn_limpaCompra.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_limpaCompra.OnHoverForeColor = System.Drawing.Color.Black
        Me.btn_limpaCompra.OnHoverImage = Nothing
        Me.btn_limpaCompra.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_limpaCompra.OnPressedColor = System.Drawing.Color.Black
        Me.btn_limpaCompra.Radius = 15
        Me.btn_limpaCompra.Size = New System.Drawing.Size(57, 57)
        Me.btn_limpaCompra.TabIndex = 66
        Me.btn_limpaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_finalizaCompra
        '
        Me.btn_finalizaCompra.Animated = True
        Me.btn_finalizaCompra.AnimationHoverSpeed = 0.07!
        Me.btn_finalizaCompra.AnimationSpeed = 0.03!
        Me.btn_finalizaCompra.BackColor = System.Drawing.Color.Transparent
        Me.btn_finalizaCompra.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_finalizaCompra.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_finalizaCompra.BorderSize = 2
        Me.btn_finalizaCompra.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_finalizaCompra.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_finalizaCompra.CheckedForeColor = System.Drawing.Color.White
        Me.btn_finalizaCompra.CheckedImage = CType(resources.GetObject("btn_finalizaCompra.CheckedImage"), System.Drawing.Image)
        Me.btn_finalizaCompra.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_finalizaCompra.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_finalizaCompra.FocusedColor = System.Drawing.Color.Empty
        Me.btn_finalizaCompra.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finalizaCompra.ForeColor = System.Drawing.Color.Black
        Me.btn_finalizaCompra.Image = CType(resources.GetObject("btn_finalizaCompra.Image"), System.Drawing.Image)
        Me.btn_finalizaCompra.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btn_finalizaCompra.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_finalizaCompra.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_finalizaCompra.Location = New System.Drawing.Point(487, 30)
        Me.btn_finalizaCompra.Name = "btn_finalizaCompra"
        Me.btn_finalizaCompra.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_finalizaCompra.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_finalizaCompra.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_finalizaCompra.OnHoverImage = Nothing
        Me.btn_finalizaCompra.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_finalizaCompra.OnPressedColor = System.Drawing.Color.Black
        Me.btn_finalizaCompra.Radius = 15
        Me.btn_finalizaCompra.Size = New System.Drawing.Size(131, 57)
        Me.btn_finalizaCompra.TabIndex = 64
        Me.btn_finalizaCompra.Text = "COMPRA"
        '
        'tp_cliente
        '
        Me.tp_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tp_cliente.Controls.Add(Me.GunaLabel36)
        Me.tp_cliente.Controls.Add(Me.txt_ufClien)
        Me.tp_cliente.Controls.Add(Me.GunaLabel10)
        Me.tp_cliente.Controls.Add(Me.GunaPictureBox1)
        Me.tp_cliente.Controls.Add(Me.GunaLabel9)
        Me.tp_cliente.Controls.Add(Me.txt_complementoClien)
        Me.tp_cliente.Controls.Add(Me.GunaLabel8)
        Me.tp_cliente.Controls.Add(Me.txt_logradouroClien)
        Me.tp_cliente.Controls.Add(Me.GunaLabel7)
        Me.tp_cliente.Controls.Add(Me.txt_bairroClien)
        Me.tp_cliente.Controls.Add(Me.GunaLabel6)
        Me.tp_cliente.Controls.Add(Me.txt_cidadeClien)
        Me.tp_cliente.Controls.Add(Me.GunaLabel5)
        Me.tp_cliente.Controls.Add(Me.txt_cepClien)
        Me.tp_cliente.Controls.Add(Me.GunaLabel4)
        Me.tp_cliente.Controls.Add(Me.txt_celularClien)
        Me.tp_cliente.Controls.Add(Me.btn_consultarClien)
        Me.tp_cliente.Controls.Add(Me.GunaLabel3)
        Me.tp_cliente.Controls.Add(Me.txt_emailClien)
        Me.tp_cliente.Controls.Add(Me.GunaLabel2)
        Me.tp_cliente.Controls.Add(Me.txt_nomeClien)
        Me.tp_cliente.Controls.Add(Me.GunaLabel1)
        Me.tp_cliente.Controls.Add(Me.txt_cpfClien)
        Me.tp_cliente.Controls.Add(Me.GunaShadowPanel4)
        Me.tp_cliente.ForeColor = System.Drawing.Color.Black
        Me.tp_cliente.Location = New System.Drawing.Point(4, 24)
        Me.tp_cliente.Margin = New System.Windows.Forms.Padding(2)
        Me.tp_cliente.Name = "tp_cliente"
        Me.tp_cliente.Padding = New System.Windows.Forms.Padding(2)
        Me.tp_cliente.Size = New System.Drawing.Size(977, 533)
        Me.tp_cliente.TabIndex = 0
        Me.tp_cliente.Text = "CLIENTES"
        '
        'GunaLabel36
        '
        Me.GunaLabel36.AutoSize = True
        Me.GunaLabel36.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel36.Location = New System.Drawing.Point(136, 233)
        Me.GunaLabel36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel36.Name = "GunaLabel36"
        Me.GunaLabel36.Size = New System.Drawing.Size(30, 21)
        Me.GunaLabel36.TabIndex = 63
        Me.GunaLabel36.Text = "UF"
        '
        'txt_ufClien
        '
        Me.txt_ufClien.BackColor = System.Drawing.Color.Transparent
        Me.txt_ufClien.BaseColor = System.Drawing.Color.White
        Me.txt_ufClien.BorderColor = System.Drawing.Color.Silver
        Me.txt_ufClien.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_ufClien.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_ufClien.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_ufClien.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_ufClien.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_ufClien.Location = New System.Drawing.Point(122, 256)
        Me.txt_ufClien.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_ufClien.MaxLength = 2
        Me.txt_ufClien.Name = "txt_ufClien"
        Me.txt_ufClien.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ufClien.Radius = 5
        Me.txt_ufClien.SelectedText = ""
        Me.txt_ufClien.Size = New System.Drawing.Size(53, 26)
        Me.txt_ufClien.TabIndex = 62
        Me.txt_ufClien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.Location = New System.Drawing.Point(14, 197)
        Me.GunaLabel10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(109, 25)
        Me.GunaLabel10.TabIndex = 27
        Me.GunaLabel10.Text = "ENDEREÇO"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaPictureBox1.Location = New System.Drawing.Point(784, 72)
        Me.GunaPictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Radius = 5
        Me.GunaPictureBox1.Size = New System.Drawing.Size(123, 150)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 25
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(671, 282)
        Me.GunaLabel9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(168, 21)
        Me.GunaLabel9.TabIndex = 24
        Me.GunaLabel9.Text = "Nº E COMPLEMENTO"
        '
        'txt_complementoClien
        '
        Me.txt_complementoClien.BackColor = System.Drawing.Color.Transparent
        Me.txt_complementoClien.BaseColor = System.Drawing.Color.White
        Me.txt_complementoClien.BorderColor = System.Drawing.Color.Silver
        Me.txt_complementoClien.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_complementoClien.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_complementoClien.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_complementoClien.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_complementoClien.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_complementoClien.Location = New System.Drawing.Point(675, 305)
        Me.txt_complementoClien.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_complementoClien.Name = "txt_complementoClien"
        Me.txt_complementoClien.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_complementoClien.Radius = 5
        Me.txt_complementoClien.SelectedText = ""
        Me.txt_complementoClien.Size = New System.Drawing.Size(197, 26)
        Me.txt_complementoClien.TabIndex = 23
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(216, 282)
        Me.GunaLabel8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(120, 21)
        Me.GunaLabel8.TabIndex = 22
        Me.GunaLabel8.Text = "LOGRADOURO"
        '
        'txt_logradouroClien
        '
        Me.txt_logradouroClien.BackColor = System.Drawing.Color.Transparent
        Me.txt_logradouroClien.BaseColor = System.Drawing.Color.White
        Me.txt_logradouroClien.BorderColor = System.Drawing.Color.Silver
        Me.txt_logradouroClien.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_logradouroClien.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_logradouroClien.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_logradouroClien.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_logradouroClien.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_logradouroClien.Location = New System.Drawing.Point(220, 305)
        Me.txt_logradouroClien.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_logradouroClien.Name = "txt_logradouroClien"
        Me.txt_logradouroClien.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_logradouroClien.Radius = 5
        Me.txt_logradouroClien.SelectedText = ""
        Me.txt_logradouroClien.Size = New System.Drawing.Size(450, 26)
        Me.txt_logradouroClien.TabIndex = 21
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(15, 284)
        Me.GunaLabel7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(68, 21)
        Me.GunaLabel7.TabIndex = 20
        Me.GunaLabel7.Text = "BAIRRO"
        '
        'txt_bairroClien
        '
        Me.txt_bairroClien.BackColor = System.Drawing.Color.Transparent
        Me.txt_bairroClien.BaseColor = System.Drawing.Color.White
        Me.txt_bairroClien.BorderColor = System.Drawing.Color.Silver
        Me.txt_bairroClien.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_bairroClien.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_bairroClien.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_bairroClien.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_bairroClien.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_bairroClien.Location = New System.Drawing.Point(19, 305)
        Me.txt_bairroClien.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_bairroClien.Name = "txt_bairroClien"
        Me.txt_bairroClien.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_bairroClien.Radius = 5
        Me.txt_bairroClien.SelectedText = ""
        Me.txt_bairroClien.Size = New System.Drawing.Size(197, 26)
        Me.txt_bairroClien.TabIndex = 19
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(175, 233)
        Me.GunaLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(69, 21)
        Me.GunaLabel6.TabIndex = 18
        Me.GunaLabel6.Text = "CIDADE"
        '
        'txt_cidadeClien
        '
        Me.txt_cidadeClien.BackColor = System.Drawing.Color.Transparent
        Me.txt_cidadeClien.BaseColor = System.Drawing.Color.White
        Me.txt_cidadeClien.BorderColor = System.Drawing.Color.Silver
        Me.txt_cidadeClien.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cidadeClien.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_cidadeClien.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_cidadeClien.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_cidadeClien.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cidadeClien.Location = New System.Drawing.Point(179, 256)
        Me.txt_cidadeClien.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cidadeClien.Name = "txt_cidadeClien"
        Me.txt_cidadeClien.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cidadeClien.Radius = 5
        Me.txt_cidadeClien.SelectedText = ""
        Me.txt_cidadeClien.Size = New System.Drawing.Size(347, 26)
        Me.txt_cidadeClien.TabIndex = 17
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(15, 233)
        Me.GunaLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(39, 21)
        Me.GunaLabel5.TabIndex = 16
        Me.GunaLabel5.Text = "CEP"
        '
        'txt_cepClien
        '
        Me.txt_cepClien.BackColor = System.Drawing.Color.Transparent
        Me.txt_cepClien.BaseColor = System.Drawing.Color.White
        Me.txt_cepClien.BorderColor = System.Drawing.Color.Silver
        Me.txt_cepClien.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cepClien.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_cepClien.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_cepClien.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_cepClien.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cepClien.Location = New System.Drawing.Point(19, 256)
        Me.txt_cepClien.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cepClien.MaxLength = 9
        Me.txt_cepClien.Name = "txt_cepClien"
        Me.txt_cepClien.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cepClien.Radius = 5
        Me.txt_cepClien.SelectedText = ""
        Me.txt_cepClien.Size = New System.Drawing.Size(99, 26)
        Me.txt_cepClien.TabIndex = 15
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(507, 125)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(78, 21)
        Me.GunaLabel4.TabIndex = 14
        Me.GunaLabel4.Text = "CELULAR"
        '
        'txt_celularClien
        '
        Me.txt_celularClien.BackColor = System.Drawing.Color.Transparent
        Me.txt_celularClien.BaseColor = System.Drawing.Color.White
        Me.txt_celularClien.BorderColor = System.Drawing.Color.Silver
        Me.txt_celularClien.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_celularClien.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_celularClien.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_celularClien.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_celularClien.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_celularClien.Location = New System.Drawing.Point(511, 148)
        Me.txt_celularClien.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_celularClien.MaxLength = 10
        Me.txt_celularClien.Name = "txt_celularClien"
        Me.txt_celularClien.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_celularClien.Radius = 5
        Me.txt_celularClien.SelectedText = ""
        Me.txt_celularClien.Size = New System.Drawing.Size(159, 26)
        Me.txt_celularClien.TabIndex = 13
        '
        'btn_consultarClien
        '
        Me.btn_consultarClien.AnimationHoverSpeed = 0.07!
        Me.btn_consultarClien.AnimationSpeed = 0.03!
        Me.btn_consultarClien.BackColor = System.Drawing.Color.Transparent
        Me.btn_consultarClien.BaseColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_consultarClien.BorderColor = System.Drawing.Color.SeaGreen
        Me.btn_consultarClien.BorderSize = 2
        Me.btn_consultarClien.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_consultarClien.FocusedColor = System.Drawing.Color.Empty
        Me.btn_consultarClien.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consultarClien.ForeColor = System.Drawing.Color.White
        Me.btn_consultarClien.Image = CType(resources.GetObject("btn_consultarClien.Image"), System.Drawing.Image)
        Me.btn_consultarClien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_consultarClien.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_consultarClien.Location = New System.Drawing.Point(232, 95)
        Me.btn_consultarClien.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_consultarClien.Name = "btn_consultarClien"
        Me.btn_consultarClien.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.btn_consultarClien.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_consultarClien.OnHoverForeColor = System.Drawing.Color.Honeydew
        Me.btn_consultarClien.OnHoverImage = Nothing
        Me.btn_consultarClien.OnPressedColor = System.Drawing.Color.Black
        Me.btn_consultarClien.Radius = 10
        Me.btn_consultarClien.Size = New System.Drawing.Size(28, 26)
        Me.btn_consultarClien.TabIndex = 12
        Me.btn_consultarClien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(260, 72)
        Me.GunaLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(159, 21)
        Me.GunaLabel3.TabIndex = 11
        Me.GunaLabel3.Text = "E-MAIL DO CLIENTE"
        '
        'txt_emailClien
        '
        Me.txt_emailClien.BackColor = System.Drawing.Color.Transparent
        Me.txt_emailClien.BaseColor = System.Drawing.Color.White
        Me.txt_emailClien.BorderColor = System.Drawing.Color.Silver
        Me.txt_emailClien.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_emailClien.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_emailClien.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_emailClien.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_emailClien.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_emailClien.Location = New System.Drawing.Point(264, 95)
        Me.txt_emailClien.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_emailClien.Name = "txt_emailClien"
        Me.txt_emailClien.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_emailClien.Radius = 5
        Me.txt_emailClien.SelectedText = ""
        Me.txt_emailClien.Size = New System.Drawing.Size(406, 26)
        Me.txt_emailClien.TabIndex = 10
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(15, 125)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(154, 21)
        Me.GunaLabel2.TabIndex = 9
        Me.GunaLabel2.Text = "NOME DO CLIENTE"
        '
        'txt_nomeClien
        '
        Me.txt_nomeClien.BackColor = System.Drawing.Color.Transparent
        Me.txt_nomeClien.BaseColor = System.Drawing.Color.White
        Me.txt_nomeClien.BorderColor = System.Drawing.Color.Silver
        Me.txt_nomeClien.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nomeClien.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_nomeClien.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_nomeClien.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_nomeClien.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nomeClien.Location = New System.Drawing.Point(19, 148)
        Me.txt_nomeClien.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nomeClien.Name = "txt_nomeClien"
        Me.txt_nomeClien.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nomeClien.Radius = 5
        Me.txt_nomeClien.SelectedText = ""
        Me.txt_nomeClien.Size = New System.Drawing.Size(488, 26)
        Me.txt_nomeClien.TabIndex = 8
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(15, 72)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(38, 21)
        Me.GunaLabel1.TabIndex = 7
        Me.GunaLabel1.Text = "CPF"
        '
        'txt_cpfClien
        '
        Me.txt_cpfClien.BackColor = System.Drawing.Color.Transparent
        Me.txt_cpfClien.BaseColor = System.Drawing.Color.White
        Me.txt_cpfClien.BorderColor = System.Drawing.Color.Silver
        Me.txt_cpfClien.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpfClien.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_cpfClien.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_cpfClien.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_cpfClien.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cpfClien.Location = New System.Drawing.Point(19, 95)
        Me.txt_cpfClien.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpfClien.MaxLength = 11
        Me.txt_cpfClien.Name = "txt_cpfClien"
        Me.txt_cpfClien.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cpfClien.Radius = 5
        Me.txt_cpfClien.SelectedText = ""
        Me.txt_cpfClien.Size = New System.Drawing.Size(209, 26)
        Me.txt_cpfClien.TabIndex = 5
        '
        'GunaShadowPanel4
        '
        Me.GunaShadowPanel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaShadowPanel4.Controls.Add(Me.lbl_status)
        Me.GunaShadowPanel4.Controls.Add(Me.btn_limpaClien)
        Me.GunaShadowPanel4.Controls.Add(Me.btn_registrarClien)
        Me.GunaShadowPanel4.Location = New System.Drawing.Point(338, 388)
        Me.GunaShadowPanel4.Name = "GunaShadowPanel4"
        Me.GunaShadowPanel4.Radius = 20
        Me.GunaShadowPanel4.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel4.ShadowDepth = 200
        Me.GunaShadowPanel4.ShadowShift = 6
        Me.GunaShadowPanel4.Size = New System.Drawing.Size(694, 200)
        Me.GunaShadowPanel4.TabIndex = 61
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.Location = New System.Drawing.Point(43, 40)
        Me.lbl_status.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(0, 37)
        Me.lbl_status.TabIndex = 64
        '
        'btn_limpaClien
        '
        Me.btn_limpaClien.Animated = True
        Me.btn_limpaClien.AnimationHoverSpeed = 0.07!
        Me.btn_limpaClien.AnimationSpeed = 0.03!
        Me.btn_limpaClien.BackColor = System.Drawing.Color.Transparent
        Me.btn_limpaClien.BaseColor = System.Drawing.Color.Yellow
        Me.btn_limpaClien.BorderColor = System.Drawing.Color.Yellow
        Me.btn_limpaClien.BorderSize = 2
        Me.btn_limpaClien.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_limpaClien.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_limpaClien.CheckedForeColor = System.Drawing.Color.White
        Me.btn_limpaClien.CheckedImage = CType(resources.GetObject("btn_limpaClien.CheckedImage"), System.Drawing.Image)
        Me.btn_limpaClien.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_limpaClien.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_limpaClien.FocusedColor = System.Drawing.Color.Empty
        Me.btn_limpaClien.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpaClien.ForeColor = System.Drawing.Color.Black
        Me.btn_limpaClien.Image = CType(resources.GetObject("btn_limpaClien.Image"), System.Drawing.Image)
        Me.btn_limpaClien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_limpaClien.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_limpaClien.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_limpaClien.Location = New System.Drawing.Point(495, 30)
        Me.btn_limpaClien.Name = "btn_limpaClien"
        Me.btn_limpaClien.OnHoverBaseColor = System.Drawing.Color.Yellow
        Me.btn_limpaClien.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_limpaClien.OnHoverForeColor = System.Drawing.Color.Black
        Me.btn_limpaClien.OnHoverImage = Nothing
        Me.btn_limpaClien.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_limpaClien.OnPressedColor = System.Drawing.Color.Black
        Me.btn_limpaClien.Radius = 15
        Me.btn_limpaClien.Size = New System.Drawing.Size(57, 57)
        Me.btn_limpaClien.TabIndex = 63
        Me.btn_limpaClien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_registrarClien
        '
        Me.btn_registrarClien.Animated = True
        Me.btn_registrarClien.AnimationHoverSpeed = 0.07!
        Me.btn_registrarClien.AnimationSpeed = 0.03!
        Me.btn_registrarClien.BackColor = System.Drawing.Color.Transparent
        Me.btn_registrarClien.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_registrarClien.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_registrarClien.BorderSize = 2
        Me.btn_registrarClien.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_registrarClien.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_registrarClien.CheckedForeColor = System.Drawing.Color.White
        Me.btn_registrarClien.CheckedImage = CType(resources.GetObject("btn_registrarClien.CheckedImage"), System.Drawing.Image)
        Me.btn_registrarClien.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_registrarClien.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_registrarClien.FocusedColor = System.Drawing.Color.Empty
        Me.btn_registrarClien.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrarClien.ForeColor = System.Drawing.Color.White
        Me.btn_registrarClien.Image = CType(resources.GetObject("btn_registrarClien.Image"), System.Drawing.Image)
        Me.btn_registrarClien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_registrarClien.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_registrarClien.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_registrarClien.Location = New System.Drawing.Point(557, 30)
        Me.btn_registrarClien.Name = "btn_registrarClien"
        Me.btn_registrarClien.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_registrarClien.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_registrarClien.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_registrarClien.OnHoverImage = Nothing
        Me.btn_registrarClien.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_registrarClien.OnPressedColor = System.Drawing.Color.Black
        Me.btn_registrarClien.Radius = 15
        Me.btn_registrarClien.Size = New System.Drawing.Size(57, 57)
        Me.btn_registrarClien.TabIndex = 62
        Me.btn_registrarClien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tp_inicial
        '
        Me.tp_inicial.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tp_inicial.Controls.Add(Me.lbl_nome)
        Me.tp_inicial.Controls.Add(Me.GunaLabel39)
        Me.tp_inicial.Location = New System.Drawing.Point(4, 24)
        Me.tp_inicial.Name = "tp_inicial"
        Me.tp_inicial.Size = New System.Drawing.Size(977, 533)
        Me.tp_inicial.TabIndex = 5
        Me.tp_inicial.Text = "INICIO"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.Location = New System.Drawing.Point(415, 229)
        Me.lbl_nome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(173, 37)
        Me.lbl_nome.TabIndex = 13
        Me.lbl_nome.Text = "BEM-VINDO"
        '
        'GunaLabel39
        '
        Me.GunaLabel39.AutoSize = True
        Me.GunaLabel39.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel39.Location = New System.Drawing.Point(415, 192)
        Me.GunaLabel39.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel39.Name = "GunaLabel39"
        Me.GunaLabel39.Size = New System.Drawing.Size(173, 37)
        Me.GunaLabel39.TabIndex = 12
        Me.GunaLabel39.Text = "BEM-VINDO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaLabel33)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1049, 47)
        Me.Panel1.TabIndex = 1
        '
        'GunaLabel33
        '
        Me.GunaLabel33.AutoSize = True
        Me.GunaLabel33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GunaLabel33.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel33.Location = New System.Drawing.Point(54, 10)
        Me.GunaLabel33.Name = "GunaLabel33"
        Me.GunaLabel33.Size = New System.Drawing.Size(297, 32)
        Me.GunaLabel33.TabIndex = 0
        Me.GunaLabel33.Text = " CONTROLE DE PETSHOP"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Panel2.Controls.Add(Me.pnl_caixa)
        Me.Panel2.Controls.Add(Me.pnl_sair)
        Me.Panel2.Controls.Add(Me.pnl_prod)
        Me.Panel2.Controls.Add(Me.pnl_func)
        Me.Panel2.Controls.Add(Me.pnl_pet)
        Me.Panel2.Controls.Add(Me.pnl_cliente)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(51, 600)
        Me.Panel2.TabIndex = 0
        '
        'pnl_caixa
        '
        Me.pnl_caixa.BackgroundImage = CType(resources.GetObject("pnl_caixa.BackgroundImage"), System.Drawing.Image)
        Me.pnl_caixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnl_caixa.Location = New System.Drawing.Point(0, 259)
        Me.pnl_caixa.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_caixa.Name = "pnl_caixa"
        Me.pnl_caixa.Size = New System.Drawing.Size(53, 48)
        Me.pnl_caixa.TabIndex = 4
        '
        'pnl_sair
        '
        Me.pnl_sair.BackgroundImage = CType(resources.GetObject("pnl_sair.BackgroundImage"), System.Drawing.Image)
        Me.pnl_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnl_sair.Location = New System.Drawing.Point(0, 505)
        Me.pnl_sair.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_sair.Name = "pnl_sair"
        Me.pnl_sair.Size = New System.Drawing.Size(53, 48)
        Me.pnl_sair.TabIndex = 4
        '
        'pnl_prod
        '
        Me.pnl_prod.BackgroundImage = CType(resources.GetObject("pnl_prod.BackgroundImage"), System.Drawing.Image)
        Me.pnl_prod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnl_prod.Location = New System.Drawing.Point(0, 206)
        Me.pnl_prod.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_prod.Name = "pnl_prod"
        Me.pnl_prod.Size = New System.Drawing.Size(53, 48)
        Me.pnl_prod.TabIndex = 3
        '
        'pnl_func
        '
        Me.pnl_func.BackgroundImage = CType(resources.GetObject("pnl_func.BackgroundImage"), System.Drawing.Image)
        Me.pnl_func.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnl_func.Location = New System.Drawing.Point(0, 153)
        Me.pnl_func.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_func.Name = "pnl_func"
        Me.pnl_func.Size = New System.Drawing.Size(51, 48)
        Me.pnl_func.TabIndex = 2
        '
        'pnl_pet
        '
        Me.pnl_pet.BackgroundImage = CType(resources.GetObject("pnl_pet.BackgroundImage"), System.Drawing.Image)
        Me.pnl_pet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnl_pet.Location = New System.Drawing.Point(0, 100)
        Me.pnl_pet.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_pet.Name = "pnl_pet"
        Me.pnl_pet.Size = New System.Drawing.Size(51, 48)
        Me.pnl_pet.TabIndex = 1
        '
        'pnl_cliente
        '
        Me.pnl_cliente.BackgroundImage = CType(resources.GetObject("pnl_cliente.BackgroundImage"), System.Drawing.Image)
        Me.pnl_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnl_cliente.Location = New System.Drawing.Point(0, 47)
        Me.pnl_cliente.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_cliente.Name = "pnl_cliente"
        Me.pnl_cliente.Size = New System.Drawing.Size(51, 48)
        Me.pnl_cliente.TabIndex = 0
        '
        'lbl_idPet
        '
        Me.lbl_idPet.AutoSize = True
        Me.lbl_idPet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.lbl_idPet.Location = New System.Drawing.Point(889, 349)
        Me.lbl_idPet.Name = "lbl_idPet"
        Me.lbl_idPet.Size = New System.Drawing.Size(48, 19)
        Me.lbl_idPet.TabIndex = 63
        Me.lbl_idPet.Text = "Label1"
        '
        'frm_controle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.tbc_controle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_controle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTROLE"
        Me.tbc_controle.ResumeLayout(False)
        Me.tp_animais.ResumeLayout(False)
        Me.tp_animais.PerformLayout()
        CType(Me.img_pet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel3.ResumeLayout(False)
        Me.GunaShadowPanel3.PerformLayout()
        Me.tp_funcionarios.ResumeLayout(False)
        Me.tp_funcionarios.PerformLayout()
        CType(Me.img_funcionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel2.ResumeLayout(False)
        Me.GunaShadowPanel2.PerformLayout()
        Me.tp_produtos.ResumeLayout(False)
        Me.tp_produtos.PerformLayout()
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.tp_compra.ResumeLayout(False)
        Me.tp_compra.PerformLayout()
        CType(Me.dgv_compra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel5.ResumeLayout(False)
        Me.tp_cliente.ResumeLayout(False)
        Me.tp_cliente.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel4.ResumeLayout(False)
        Me.GunaShadowPanel4.PerformLayout()
        Me.tp_inicial.ResumeLayout(False)
        Me.tp_inicial.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbc_controle As TabControl
    Friend WithEvents tp_cliente As TabPage
    Friend WithEvents tp_animais As TabPage
    Friend WithEvents tp_funcionarios As TabPage
    Friend WithEvents tp_produtos As TabPage
    Friend WithEvents txt_cpfClien As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_emailClien As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_nomeClien As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btn_consultarClien As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_logradouroClien As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_bairroClien As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_cidadeClien As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_cepClien As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_celularClien As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_complementoClien As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_cpfTutor As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmb_pets As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents img_pet As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel15 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_desc As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel14 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_raca As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel13 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_especie As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cmb_cargo As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents img_funcionario As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel22 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_celularFunc As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btn_consultaFunc As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel23 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_emailFunc As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel24 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_nomeFunc As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel25 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_cpfFunc As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel26 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_senhaConfirma As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel27 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel16 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_senha As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel17 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_complementoFunc As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel18 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_logradouroFunc As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel19 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_bairroFunc As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel20 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_cidadeFunc As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel21 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_cepFunc As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_idProduto As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_idProd As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel29 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel28 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_produto As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel31 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_quantidade As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel30 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_preco As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cmb_tipoProduto As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btn_verSenha As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GunaLabel32 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_descProd As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents pnl_cliente As Panel
    Friend WithEvents pnl_pet As Panel
    Friend WithEvents pnl_prod As Panel
    Friend WithEvents pnl_func As Panel
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaShadowPanel3 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaShadowPanel4 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents btn_registrarFunc As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_registrarClien As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_registrarPet As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel33 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_consultarPet As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel34 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel36 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_ufClien As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel35 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_ufFunc As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btn_verConfirmaSenha As Guna.UI.WinForms.GunaButton
    Friend WithEvents pnl_sair As Panel
    Friend WithEvents txt_nomePet As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel37 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_limpaClien As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_limpaFunc As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_buscaProd As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgv_produtos As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents lbl_status As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_statusFunc As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_statusPet As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_limpaPet As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents tp_compra As TabPage
    Friend WithEvents GunaShadowPanel5 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents pnl_caixa As Panel
    Friend WithEvents dgv_compra As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaLabel38 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_cpfComprador As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel41 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmb_compraAnterior As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel40 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_idProdComprado As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btn_consultaCompra As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_finalizaCompra As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents PRODUTO As DataGridViewTextBoxColumn
    Friend WithEvents PREÇO As DataGridViewTextBoxColumn
    Friend WithEvents btn_limpaCompra As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lbl_valorTotal As Guna.UI.WinForms.GunaLabel
    Friend WithEvents tp_inicial As TabPage
    Friend WithEvents lbl_nome As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel39 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_idPet As Label
End Class
