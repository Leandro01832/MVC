namespace View.form.cadastro
{
    partial class Form_celula
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.text_cep = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.text_numero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_rua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text_bairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_id_pessoa = new System.Windows.Forms.Label();
            this.lbl_numero_chamada = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lbl_id_celula = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mask_horario = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.list_dia_semana = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_lider_treinamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_lider = new System.Windows.Forms.TextBox();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(1255, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 24);
            this.label12.TabIndex = 103;
            this.label12.Text = "Lista de pessoas da celula:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(830, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 24);
            this.label11.TabIndex = 102;
            this.label11.Text = "Lista de pessoas sem celula:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(330, 512);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 32);
            this.button4.TabIndex = 101;
            this.button4.Text = "buscar CEP";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // text_cep
            // 
            this.text_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_cep.Location = new System.Drawing.Point(180, 512);
            this.text_cep.Margin = new System.Windows.Forms.Padding(4);
            this.text_cep.Name = "text_cep";
            this.text_cep.Size = new System.Drawing.Size(140, 30);
            this.text_cep.TabIndex = 100;
            this.text_cep.TextChanged += new System.EventHandler(this.text_cep_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(103, 522);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 24);
            this.label10.TabIndex = 99;
            this.label10.Text = "Cep:";
            // 
            // text_numero
            // 
            this.text_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_numero.Location = new System.Drawing.Point(180, 671);
            this.text_numero.Margin = new System.Windows.Forms.Padding(4);
            this.text_numero.Name = "text_numero";
            this.text_numero.Size = new System.Drawing.Size(140, 30);
            this.text_numero.TabIndex = 98;
            this.text_numero.TextChanged += new System.EventHandler(this.text_numero_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(67, 680);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 24);
            this.label9.TabIndex = 97;
            this.label9.Text = "Numero:";
            // 
            // text_rua
            // 
            this.text_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_rua.Location = new System.Drawing.Point(180, 613);
            this.text_rua.Margin = new System.Windows.Forms.Padding(4);
            this.text_rua.Name = "text_rua";
            this.text_rua.Size = new System.Drawing.Size(307, 30);
            this.text_rua.TabIndex = 96;
            this.text_rua.TextChanged += new System.EventHandler(this.text_rua_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(103, 623);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 24);
            this.label8.TabIndex = 95;
            this.label8.Text = "Rua:";
            // 
            // text_bairro
            // 
            this.text_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_bairro.Location = new System.Drawing.Point(180, 560);
            this.text_bairro.Margin = new System.Windows.Forms.Padding(4);
            this.text_bairro.Name = "text_bairro";
            this.text_bairro.Size = new System.Drawing.Size(307, 30);
            this.text_bairro.TabIndex = 94;
            this.text_bairro.TextChanged += new System.EventHandler(this.text_bairro_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(103, 570);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 93;
            this.label7.Text = "Bairro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(214, 477);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 24);
            this.label6.TabIndex = 92;
            this.label6.Text = "Local da reunião:";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1194, 62);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(351, 324);
            this.listBox1.TabIndex = 91;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_id.AutoSize = true;
            this.lbl_id.Enabled = false;
            this.lbl_id.Location = new System.Drawing.Point(1563, 659);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 17);
            this.lbl_id.TabIndex = 88;
            this.lbl_id.Click += new System.EventHandler(this.lbl_id_Click);
            // 
            // lbl_id_pessoa
            // 
            this.lbl_id_pessoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_id_pessoa.AutoSize = true;
            this.lbl_id_pessoa.Enabled = false;
            this.lbl_id_pessoa.Location = new System.Drawing.Point(1730, 643);
            this.lbl_id_pessoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_pessoa.Name = "lbl_id_pessoa";
            this.lbl_id_pessoa.Size = new System.Drawing.Size(0, 17);
            this.lbl_id_pessoa.TabIndex = 87;
            // 
            // lbl_numero_chamada
            // 
            this.lbl_numero_chamada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_numero_chamada.AutoSize = true;
            this.lbl_numero_chamada.Enabled = false;
            this.lbl_numero_chamada.Location = new System.Drawing.Point(1710, 576);
            this.lbl_numero_chamada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numero_chamada.Name = "lbl_numero_chamada";
            this.lbl_numero_chamada.Size = new System.Drawing.Size(0, 17);
            this.lbl_numero_chamada.TabIndex = 86;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(1194, 394);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 47);
            this.button2.TabIndex = 85;
            this.button2.Text = "adicionar na celula";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.Enabled = false;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(814, 62);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(351, 324);
            this.listBox2.TabIndex = 84;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // lbl_id_celula
            // 
            this.lbl_id_celula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_id_celula.AutoSize = true;
            this.lbl_id_celula.Location = new System.Drawing.Point(1884, 684);
            this.lbl_id_celula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_celula.Name = "lbl_id_celula";
            this.lbl_id_celula.Size = new System.Drawing.Size(0, 17);
            this.lbl_id_celula.TabIndex = 83;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 598);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 117);
            this.button1.TabIndex = 82;
            this.button1.Text = "cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mask_horario
            // 
            this.mask_horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mask_horario.Location = new System.Drawing.Point(260, 379);
            this.mask_horario.Margin = new System.Windows.Forms.Padding(4);
            this.mask_horario.Mask = "00:00";
            this.mask_horario.Name = "mask_horario";
            this.mask_horario.Size = new System.Drawing.Size(107, 30);
            this.mask_horario.TabIndex = 81;
            this.mask_horario.ValidatingType = typeof(System.DateTime);
            this.mask_horario.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mask_horario_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(122, 389);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 80;
            this.label5.Text = "Horario:";
            // 
            // list_dia_semana
            // 
            this.list_dia_semana.FormattingEnabled = true;
            this.list_dia_semana.ItemHeight = 16;
            this.list_dia_semana.Items.AddRange(new object[] {
            "domingo",
            "segunda-feira",
            "terça-feira",
            "quarta-feira",
            "quinta-feira",
            "sexta-feira",
            "sabado"});
            this.list_dia_semana.Location = new System.Drawing.Point(260, 273);
            this.list_dia_semana.Margin = new System.Windows.Forms.Padding(4);
            this.list_dia_semana.Name = "list_dia_semana";
            this.list_dia_semana.Size = new System.Drawing.Size(365, 68);
            this.list_dia_semana.TabIndex = 79;
            this.list_dia_semana.SelectedIndexChanged += new System.EventHandler(this.list_dia_semana_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(71, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 78;
            this.label4.Text = "dia da reunião:";
            // 
            // text_lider_treinamento
            // 
            this.text_lider_treinamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_lider_treinamento.Location = new System.Drawing.Point(260, 214);
            this.text_lider_treinamento.Margin = new System.Windows.Forms.Padding(4);
            this.text_lider_treinamento.Name = "text_lider_treinamento";
            this.text_lider_treinamento.Size = new System.Drawing.Size(247, 30);
            this.text_lider_treinamento.TabIndex = 77;
            this.text_lider_treinamento.TextChanged += new System.EventHandler(this.text_lider_treinamento_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 24);
            this.label3.TabIndex = 76;
            this.label3.Text = "Lider em treinamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(75, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 75;
            this.label2.Text = "Lider da celula:";
            // 
            // text_lider
            // 
            this.text_lider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_lider.Location = new System.Drawing.Point(260, 146);
            this.text_lider.Margin = new System.Windows.Forms.Padding(4);
            this.text_lider.Name = "text_lider";
            this.text_lider.Size = new System.Drawing.Size(247, 30);
            this.text_lider.TabIndex = 74;
            this.text_lider.TextChanged += new System.EventHandler(this.text_lider_TextChanged);
            // 
            // text_nome
            // 
            this.text_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_nome.Location = new System.Drawing.Point(260, 76);
            this.text_nome.Margin = new System.Windows.Forms.Padding(4);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(247, 30);
            this.text_nome.TabIndex = 73;
            this.text_nome.TextChanged += new System.EventHandler(this.text_nome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 72;
            this.label1.Text = "nome da celula:";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(1295, 603);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(213, 107);
            this.button5.TabIndex = 104;
            this.button5.Text = "salvar celula";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(1414, 394);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 47);
            this.button6.TabIndex = 105;
            this.button6.Text = "remover da celula";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(814, 435);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(814, 394);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 28);
            this.button3.TabIndex = 107;
            this.button3.Text = "visualizar foto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form_celula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 786);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.text_cep);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text_numero);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.text_rua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_bairro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_id_pessoa);
            this.Controls.Add(this.lbl_numero_chamada);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lbl_id_celula);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mask_horario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.list_dia_semana);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_lider_treinamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_lider);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label1);
            this.Name = "Form_celula";
            this.Text = "Form_celula";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_celula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox text_cep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_numero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_rua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_bairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_id_pessoa;
        private System.Windows.Forms.Label lbl_numero_chamada;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lbl_id_celula;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mask_horario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox list_dia_semana;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_lider_treinamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_lider;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}