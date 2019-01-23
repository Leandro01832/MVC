using System.Windows.Forms;

namespace View.form.cadastro
{
    partial class frm_cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.text_cep = new System.Windows.Forms.TextBox();
            this.listBox_status = new System.Windows.Forms.ListBox();
            this.mask_ano_batismo = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.mask_data_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.mask_tel3 = new System.Windows.Forms.MaskedTextBox();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.text_cidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listestado_civil = new System.Windows.Forms.ListBox();
            this.radioButton_feminino = new System.Windows.Forms.RadioButton();
            this.radioButton_masculino = new System.Windows.Forms.RadioButton();
            this.nome = new System.Windows.Forms.Label();
            this.mask_tel2 = new System.Windows.Forms.MaskedTextBox();
            this.mask_tel1 = new System.Windows.Forms.MaskedTextBox();
            this.cadastrar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text_numero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_complemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_rua = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.text_bairro = new System.Windows.Forms.TextBox();
            this.text_estado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textpais = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_rg = new System.Windows.Forms.TextBox();
            this.text_cpf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1395, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 403);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 222;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(480, 330);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 30);
            this.button2.TabIndex = 221;
            this.button2.Text = "buscar CEP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // text_cep
            // 
            this.text_cep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_cep.Location = new System.Drawing.Point(237, 328);
            this.text_cep.Margin = new System.Windows.Forms.Padding(4);
            this.text_cep.Name = "text_cep";
            this.text_cep.Size = new System.Drawing.Size(217, 29);
            this.text_cep.TabIndex = 185;
            this.text_cep.TextChanged += new System.EventHandler(this.text_cep_TextChanged);
            // 
            // listBox_status
            // 
            this.listBox_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_status.FormattingEnabled = true;
            this.listBox_status.ItemHeight = 16;
            this.listBox_status.Items.AddRange(new object[] {
            "residente em Cataguases",
            "residente em outra cidade de Minas Gerais",
            "residente em outro estado do Brasil",
            "residente em outro país"});
            this.listBox_status.Location = new System.Drawing.Point(737, 37);
            this.listBox_status.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_status.Name = "listBox_status";
            this.listBox_status.Size = new System.Drawing.Size(291, 68);
            this.listBox_status.TabIndex = 201;
            this.listBox_status.SelectedIndexChanged += new System.EventHandler(this.listBox_status_SelectedIndexChanged);
            // 
            // mask_ano_batismo
            // 
            this.mask_ano_batismo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mask_ano_batismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mask_ano_batismo.Location = new System.Drawing.Point(886, 273);
            this.mask_ano_batismo.Margin = new System.Windows.Forms.Padding(4);
            this.mask_ano_batismo.Mask = "0000";
            this.mask_ano_batismo.Name = "mask_ano_batismo";
            this.mask_ano_batismo.Size = new System.Drawing.Size(87, 29);
            this.mask_ano_batismo.TabIndex = 204;
            this.mask_ano_batismo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mask_ano_batismo_MaskInputRejected);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(668, 278);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(154, 25);
            this.label17.TabIndex = 218;
            this.label17.Text = "Ano de batismo:";
            // 
            // mask_data_nascimento
            // 
            this.mask_data_nascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mask_data_nascimento.BeepOnError = true;
            this.mask_data_nascimento.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mask_data_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mask_data_nascimento.Location = new System.Drawing.Point(886, 183);
            this.mask_data_nascimento.Margin = new System.Windows.Forms.Padding(4);
            this.mask_data_nascimento.Mask = "00/00/0000";
            this.mask_data_nascimento.Name = "mask_data_nascimento";
            this.mask_data_nascimento.RejectInputOnFirstFailure = true;
            this.mask_data_nascimento.Size = new System.Drawing.Size(204, 29);
            this.mask_data_nascimento.TabIndex = 202;
            this.mask_data_nascimento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mask_data_nascimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mask_data_nascimento_MaskInputRejected);
            this.mask_data_nascimento.Leave += new System.EventHandler(this.mask_data_nascimento_Leave);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1395, 592);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 25);
            this.button1.TabIndex = 210;
            this.button1.Text = "imprimir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1065, 771);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 25);
            this.label19.TabIndex = 220;
            this.label19.Text = "whatsapp";
            // 
            // mask_tel3
            // 
            this.mask_tel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mask_tel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_tel3.Location = new System.Drawing.Point(1209, 766);
            this.mask_tel3.Margin = new System.Windows.Forms.Padding(4);
            this.mask_tel3.Mask = "(999) 00000-0000";
            this.mask_tel3.Name = "mask_tel3";
            this.mask_tel3.Size = new System.Drawing.Size(243, 29);
            this.mask_tel3.TabIndex = 199;
            this.mask_tel3.TextChanged += new System.EventHandler(this.mask_tel3_TextChanged);
            // 
            // btn_procurar
            // 
            this.btn_procurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_procurar.Location = new System.Drawing.Point(1701, 430);
            this.btn_procurar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(100, 28);
            this.btn_procurar.TabIndex = 208;
            this.btn_procurar.Text = "procurar";
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(572, 771);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 25);
            this.label18.TabIndex = 219;
            this.label18.Text = "celular";
            // 
            // textemail
            // 
            this.textemail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textemail.Location = new System.Drawing.Point(237, 708);
            this.textemail.Margin = new System.Windows.Forms.Padding(4);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(365, 29);
            this.textemail.TabIndex = 195;
            this.textemail.TextChanged += new System.EventHandler(this.textemail_TextChanged);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(48, 706);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 25);
            this.label16.TabIndex = 217;
            this.label16.Text = "email";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // text_cidade
            // 
            this.text_cidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_cidade.Location = new System.Drawing.Point(237, 452);
            this.text_cidade.Margin = new System.Windows.Forms.Padding(4);
            this.text_cidade.Name = "text_cidade";
            this.text_cidade.Size = new System.Drawing.Size(365, 29);
            this.text_cidade.TabIndex = 188;
            this.text_cidade.TextChanged += new System.EventHandler(this.text_cidade_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 452);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 216;
            this.label6.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 215;
            this.label5.Text = "estado civil";
            // 
            // listestado_civil
            // 
            this.listestado_civil.FormattingEnabled = true;
            this.listestado_civil.ItemHeight = 16;
            this.listestado_civil.Items.AddRange(new object[] {
            "casado(a)",
            "separado(a)",
            "solteiro(a)",
            "viuvo(a)"});
            this.listestado_civil.Location = new System.Drawing.Point(221, 189);
            this.listestado_civil.Margin = new System.Windows.Forms.Padding(4);
            this.listestado_civil.Name = "listestado_civil";
            this.listestado_civil.Size = new System.Drawing.Size(365, 36);
            this.listestado_civil.TabIndex = 182;
            this.listestado_civil.SelectedIndexChanged += new System.EventHandler(this.listestado_civil_SelectedIndexChanged);
            // 
            // radioButton_feminino
            // 
            this.radioButton_feminino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_feminino.AutoSize = true;
            this.radioButton_feminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_feminino.Location = new System.Drawing.Point(976, 362);
            this.radioButton_feminino.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_feminino.Name = "radioButton_feminino";
            this.radioButton_feminino.Size = new System.Drawing.Size(106, 29);
            this.radioButton_feminino.TabIndex = 207;
            this.radioButton_feminino.TabStop = true;
            this.radioButton_feminino.Text = "feminino";
            this.radioButton_feminino.UseVisualStyleBackColor = true;
            this.radioButton_feminino.CheckedChanged += new System.EventHandler(this.radioButton_feminino_CheckedChanged);
            // 
            // radioButton_masculino
            // 
            this.radioButton_masculino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_masculino.AutoSize = true;
            this.radioButton_masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_masculino.Location = new System.Drawing.Point(811, 362);
            this.radioButton_masculino.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_masculino.Name = "radioButton_masculino";
            this.radioButton_masculino.Size = new System.Drawing.Size(121, 29);
            this.radioButton_masculino.TabIndex = 206;
            this.radioButton_masculino.TabStop = true;
            this.radioButton_masculino.Text = "masculino";
            this.radioButton_masculino.UseVisualStyleBackColor = true;
            this.radioButton_masculino.CheckedChanged += new System.EventHandler(this.radioButton_masculino_CheckedChanged);
            // 
            // nome
            // 
            this.nome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(670, 367);
            this.nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(60, 25);
            this.nome.TabIndex = 214;
            this.nome.Text = "sexo:";
            // 
            // mask_tel2
            // 
            this.mask_tel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mask_tel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_tel2.Location = new System.Drawing.Point(716, 766);
            this.mask_tel2.Margin = new System.Windows.Forms.Padding(4);
            this.mask_tel2.Mask = "(999) 00000-0000";
            this.mask_tel2.Name = "mask_tel2";
            this.mask_tel2.Size = new System.Drawing.Size(243, 29);
            this.mask_tel2.TabIndex = 198;
            this.mask_tel2.TextChanged += new System.EventHandler(this.mask_tel2_TextChanged);
            // 
            // mask_tel1
            // 
            this.mask_tel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mask_tel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_tel1.Location = new System.Drawing.Point(237, 766);
            this.mask_tel1.Margin = new System.Windows.Forms.Padding(4);
            this.mask_tel1.Mask = "(999) 0000-0000";
            this.mask_tel1.Name = "mask_tel1";
            this.mask_tel1.Size = new System.Drawing.Size(243, 29);
            this.mask_tel1.TabIndex = 196;
            this.mask_tel1.TextChanged += new System.EventHandler(this.mask_tel1_TextChanged);
            // 
            // cadastrar
            // 
            this.cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cadastrar.Location = new System.Drawing.Point(1062, 562);
            this.cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(180, 52);
            this.cadastrar.TabIndex = 209;
            this.cadastrar.Text = "cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(30, 74);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 25);
            this.label14.TabIndex = 213;
            this.label14.Text = "RG";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 133);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 25);
            this.label13.TabIndex = 212;
            this.label13.Text = "CPF";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(668, 188);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 25);
            this.label11.TabIndex = 211;
            this.label11.Text = "data de nascimento";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 771);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 205;
            this.label10.Text = "telefone";
            // 
            // text_numero
            // 
            this.text_numero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_numero.Location = new System.Drawing.Point(737, 584);
            this.text_numero.Margin = new System.Windows.Forms.Padding(4);
            this.text_numero.Name = "text_numero";
            this.text_numero.Size = new System.Drawing.Size(132, 29);
            this.text_numero.TabIndex = 192;
            this.text_numero.TextChanged += new System.EventHandler(this.text_numero_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(652, 589);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 25);
            this.label9.TabIndex = 203;
            this.label9.Text = "nº";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 333);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 25);
            this.label8.TabIndex = 200;
            this.label8.Text = "cep";
            // 
            // text_complemento
            // 
            this.text_complemento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_complemento.Location = new System.Drawing.Point(237, 644);
            this.text_complemento.Margin = new System.Windows.Forms.Padding(4);
            this.text_complemento.Name = "text_complemento";
            this.text_complemento.Size = new System.Drawing.Size(365, 29);
            this.text_complemento.TabIndex = 194;
            this.text_complemento.TextChanged += new System.EventHandler(this.text_complemento_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 649);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 197;
            this.label7.Text = "complemento";
            // 
            // text_rua
            // 
            this.text_rua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_rua.Location = new System.Drawing.Point(237, 584);
            this.text_rua.Margin = new System.Windows.Forms.Padding(4);
            this.text_rua.Name = "text_rua";
            this.text_rua.Size = new System.Drawing.Size(365, 29);
            this.text_rua.TabIndex = 191;
            this.text_rua.TextChanged += new System.EventHandler(this.text_rua_TextChanged);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(41, 586);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 25);
            this.label15.TabIndex = 193;
            this.label15.Text = "rua";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 522);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 25);
            this.label12.TabIndex = 190;
            this.label12.Text = "bairro";
            // 
            // text_bairro
            // 
            this.text_bairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_bairro.Location = new System.Drawing.Point(237, 517);
            this.text_bairro.Margin = new System.Windows.Forms.Padding(4);
            this.text_bairro.Name = "text_bairro";
            this.text_bairro.Size = new System.Drawing.Size(365, 29);
            this.text_bairro.TabIndex = 189;
            this.text_bairro.TextChanged += new System.EventHandler(this.text_bairro_TextChanged);
            // 
            // text_estado
            // 
            this.text_estado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_estado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_estado.Location = new System.Drawing.Point(237, 392);
            this.text_estado.Margin = new System.Windows.Forms.Padding(4);
            this.text_estado.MaxLength = 2;
            this.text_estado.Name = "text_estado";
            this.text_estado.Size = new System.Drawing.Size(60, 29);
            this.text_estado.TabIndex = 186;
            this.text_estado.TextChanged += new System.EventHandler(this.text_estado_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 397);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 187;
            this.label4.Text = "estado";
            // 
            // textpais
            // 
            this.textpais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpais.Location = new System.Drawing.Point(237, 265);
            this.textpais.Margin = new System.Windows.Forms.Padding(4);
            this.textpais.Name = "textpais";
            this.textpais.Size = new System.Drawing.Size(217, 29);
            this.textpais.TabIndex = 183;
            this.textpais.TextChanged += new System.EventHandler(this.textpais_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 184;
            this.label3.Text = "país";
            // 
            // text_nome
            // 
            this.text_nome.AllowDrop = true;
            this.text_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nome.Location = new System.Drawing.Point(236, 13);
            this.text_nome.Margin = new System.Windows.Forms.Padding(4);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(366, 29);
            this.text_nome.TabIndex = 177;
            this.text_nome.TextChanged += new System.EventHandler(this.text_nome_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(634, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 181;
            this.label2.Text = "status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 178;
            this.label1.Text = "nome";
            // 
            // text_rg
            // 
            this.text_rg.AllowDrop = true;
            this.text_rg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_rg.Location = new System.Drawing.Point(236, 68);
            this.text_rg.Margin = new System.Windows.Forms.Padding(4);
            this.text_rg.Name = "text_rg";
            this.text_rg.Size = new System.Drawing.Size(366, 29);
            this.text_rg.TabIndex = 223;
            this.text_rg.TextChanged += new System.EventHandler(this.text_rg_TextChanged);
            // 
            // text_cpf
            // 
            this.text_cpf.AllowDrop = true;
            this.text_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_cpf.Location = new System.Drawing.Point(236, 129);
            this.text_cpf.Margin = new System.Windows.Forms.Padding(4);
            this.text_cpf.Name = "text_cpf";
            this.text_cpf.Size = new System.Drawing.Size(366, 29);
            this.text_cpf.TabIndex = 224;
            this.text_cpf.TextChanged += new System.EventHandler(this.text_cpf_TextChanged);
            // 
            // frm_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.text_cpf);
            this.Controls.Add(this.text_rg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.text_cep);
            this.Controls.Add(this.listBox_status);
            this.Controls.Add(this.mask_ano_batismo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.mask_data_nascimento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.mask_tel3);
            this.Controls.Add(this.btn_procurar);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.text_cidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listestado_civil);
            this.Controls.Add(this.radioButton_feminino);
            this.Controls.Add(this.radioButton_masculino);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.mask_tel2);
            this.Controls.Add(this.mask_tel1);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text_numero);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_complemento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_rua);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.text_bairro);
            this.Controls.Add(this.text_estado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textpais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_cadastro";
            this.Text = "Form_cadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox text_cep;
        private System.Windows.Forms.ListBox listBox_status;
        private System.Windows.Forms.MaskedTextBox mask_ano_batismo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox mask_data_nascimento;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox mask_tel3;
        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox text_cidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listestado_civil;
        private System.Windows.Forms.RadioButton radioButton_feminino;
        private System.Windows.Forms.RadioButton radioButton_masculino;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.MaskedTextBox mask_tel2;
        private System.Windows.Forms.MaskedTextBox mask_tel1;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_numero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_complemento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_rua;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox text_bairro;
        private System.Windows.Forms.TextBox text_estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textpais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_rg;
        private System.Windows.Forms.TextBox text_cpf;
    }
}