namespace View.form.cadastro
{
    partial class info_membro
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.text_nome_igreja = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_reconciliacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_estado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_cidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_denominacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.radio_sexo_feminino = new System.Windows.Forms.RadioButton();
            this.radio_sexo_masculino = new System.Windows.Forms.RadioButton();
            this.maskedText_data_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.radio_falescimento = new System.Windows.Forms.RadioButton();
            this.text_email = new System.Windows.Forms.TextBox();
            this.text_falta = new System.Windows.Forms.TextBox();
            this.text_pais = new System.Windows.Forms.TextBox();
            this.textBox_cidade = new System.Windows.Forms.TextBox();
            this.text_bairro = new System.Windows.Forms.TextBox();
            this.text_rua = new System.Windows.Forms.TextBox();
            this.textBox_estado = new System.Windows.Forms.TextBox();
            this.text_numero_casa = new System.Windows.Forms.TextBox();
            this.text_cep = new System.Windows.Forms.TextBox();
            this.text_complemento = new System.Windows.Forms.TextBox();
            this.listBox_estado_civil = new System.Windows.Forms.ListBox();
            this.listBox_status = new System.Windows.Forms.ListBox();
            this.maskedText_tel1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedText_tel2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedText_tel3 = new System.Windows.Forms.MaskedTextBox();
            this.mask_ano_batismo = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text_rg = new System.Windows.Forms.TextBox();
            this.text_cpf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(51, 16);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(0, 17);
            this.lbl_nome.TabIndex = 56;
            this.lbl_nome.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(489, 118);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 21);
            this.radioButton2.TabIndex = 55;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "não";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(406, 118);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 21);
            this.radioButton1.TabIndex = 54;
            this.radioButton1.Text = "sim";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(364, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 17);
            this.label9.TabIndex = 53;
            this.label9.Text = "Você é menbro por transferência?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(402, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "Você é menbro por reconciliação?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Você é menbro por aclamação?";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(588, 467);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 37);
            this.button3.TabIndex = 50;
            this.button3.Text = "adicionar informação";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(766, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 37);
            this.button2.TabIndex = 49;
            this.button2.Text = "adicionar informação";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 37);
            this.button1.TabIndex = 48;
            this.button1.Text = "adicionar informação";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_nome_igreja
            // 
            this.text_nome_igreja.Location = new System.Drawing.Point(537, 223);
            this.text_nome_igreja.Name = "text_nome_igreja";
            this.text_nome_igreja.Size = new System.Drawing.Size(213, 22);
            this.text_nome_igreja.TabIndex = 47;
            this.text_nome_igreja.TextChanged += new System.EventHandler(this.text_nome_igreja_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "nome da igreja:";
            // 
            // text_reconciliacao
            // 
            this.text_reconciliacao.Location = new System.Drawing.Point(439, 351);
            this.text_reconciliacao.Name = "text_reconciliacao";
            this.text_reconciliacao.Size = new System.Drawing.Size(62, 22);
            this.text_reconciliacao.TabIndex = 45;
            this.text_reconciliacao.TextChanged += new System.EventHandler(this.text_reconciliacao_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Você é menbro por batismo?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "ano de reconciliação:";
            // 
            // text_estado
            // 
            this.text_estado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_estado.Location = new System.Drawing.Point(368, 226);
            this.text_estado.MaxLength = 2;
            this.text_estado.Name = "text_estado";
            this.text_estado.Size = new System.Drawing.Size(46, 29);
            this.text_estado.TabIndex = 42;
            this.text_estado.TextChanged += new System.EventHandler(this.text_estado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "estado:";
            // 
            // text_cidade
            // 
            this.text_cidade.Location = new System.Drawing.Point(134, 223);
            this.text_cidade.Name = "text_cidade";
            this.text_cidade.Size = new System.Drawing.Size(171, 22);
            this.text_cidade.TabIndex = 40;
            this.text_cidade.TextChanged += new System.EventHandler(this.text_cidade_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "cidade:";
            // 
            // text_denominacao
            // 
            this.text_denominacao.Location = new System.Drawing.Point(390, 472);
            this.text_denominacao.Name = "text_denominacao";
            this.text_denominacao.Size = new System.Drawing.Size(171, 22);
            this.text_denominacao.TabIndex = 38;
            this.text_denominacao.TextChanged += new System.EventHandler(this.text_denominacao_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "denominação:";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(809, 11);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(80, 22);
            this.text_nome.TabIndex = 57;
            this.text_nome.Visible = false;
            // 
            // radio_sexo_feminino
            // 
            this.radio_sexo_feminino.AutoSize = true;
            this.radio_sexo_feminino.Checked = true;
            this.radio_sexo_feminino.Location = new System.Drawing.Point(832, 39);
            this.radio_sexo_feminino.Name = "radio_sexo_feminino";
            this.radio_sexo_feminino.Size = new System.Drawing.Size(17, 16);
            this.radio_sexo_feminino.TabIndex = 58;
            this.radio_sexo_feminino.TabStop = true;
            this.radio_sexo_feminino.UseVisualStyleBackColor = true;
            this.radio_sexo_feminino.Visible = false;
            // 
            // radio_sexo_masculino
            // 
            this.radio_sexo_masculino.AutoSize = true;
            this.radio_sexo_masculino.Checked = true;
            this.radio_sexo_masculino.Location = new System.Drawing.Point(809, 39);
            this.radio_sexo_masculino.Name = "radio_sexo_masculino";
            this.radio_sexo_masculino.Size = new System.Drawing.Size(17, 16);
            this.radio_sexo_masculino.TabIndex = 59;
            this.radio_sexo_masculino.TabStop = true;
            this.radio_sexo_masculino.UseVisualStyleBackColor = true;
            this.radio_sexo_masculino.Visible = false;
            // 
            // maskedText_data_nascimento
            // 
            this.maskedText_data_nascimento.Location = new System.Drawing.Point(809, 61);
            this.maskedText_data_nascimento.Name = "maskedText_data_nascimento";
            this.maskedText_data_nascimento.Size = new System.Drawing.Size(80, 22);
            this.maskedText_data_nascimento.TabIndex = 60;
            this.maskedText_data_nascimento.Visible = false;
            // 
            // radio_falescimento
            // 
            this.radio_falescimento.AutoSize = true;
            this.radio_falescimento.Checked = true;
            this.radio_falescimento.Location = new System.Drawing.Point(855, 39);
            this.radio_falescimento.Name = "radio_falescimento";
            this.radio_falescimento.Size = new System.Drawing.Size(17, 16);
            this.radio_falescimento.TabIndex = 62;
            this.radio_falescimento.TabStop = true;
            this.radio_falescimento.UseVisualStyleBackColor = true;
            this.radio_falescimento.Visible = false;
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(909, 11);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(80, 22);
            this.text_email.TabIndex = 63;
            this.text_email.Visible = false;
            // 
            // text_falta
            // 
            this.text_falta.Location = new System.Drawing.Point(909, 89);
            this.text_falta.Name = "text_falta";
            this.text_falta.Size = new System.Drawing.Size(80, 22);
            this.text_falta.TabIndex = 65;
            this.text_falta.Visible = false;
            // 
            // text_pais
            // 
            this.text_pais.Location = new System.Drawing.Point(809, 118);
            this.text_pais.Name = "text_pais";
            this.text_pais.Size = new System.Drawing.Size(80, 22);
            this.text_pais.TabIndex = 66;
            this.text_pais.Visible = false;
            // 
            // textBox_cidade
            // 
            this.textBox_cidade.Location = new System.Drawing.Point(909, 117);
            this.textBox_cidade.Name = "textBox_cidade";
            this.textBox_cidade.Size = new System.Drawing.Size(80, 22);
            this.textBox_cidade.TabIndex = 67;
            this.textBox_cidade.Visible = false;
            // 
            // text_bairro
            // 
            this.text_bairro.Location = new System.Drawing.Point(809, 146);
            this.text_bairro.Name = "text_bairro";
            this.text_bairro.Size = new System.Drawing.Size(80, 22);
            this.text_bairro.TabIndex = 68;
            this.text_bairro.Visible = false;
            // 
            // text_rua
            // 
            this.text_rua.Location = new System.Drawing.Point(909, 146);
            this.text_rua.Name = "text_rua";
            this.text_rua.Size = new System.Drawing.Size(80, 22);
            this.text_rua.TabIndex = 69;
            this.text_rua.Visible = false;
            // 
            // textBox_estado
            // 
            this.textBox_estado.Location = new System.Drawing.Point(809, 174);
            this.textBox_estado.Name = "textBox_estado";
            this.textBox_estado.Size = new System.Drawing.Size(80, 22);
            this.textBox_estado.TabIndex = 70;
            this.textBox_estado.Visible = false;
            // 
            // text_numero_casa
            // 
            this.text_numero_casa.Location = new System.Drawing.Point(909, 174);
            this.text_numero_casa.Name = "text_numero_casa";
            this.text_numero_casa.Size = new System.Drawing.Size(80, 22);
            this.text_numero_casa.TabIndex = 71;
            this.text_numero_casa.Visible = false;
            // 
            // text_cep
            // 
            this.text_cep.Location = new System.Drawing.Point(699, 11);
            this.text_cep.Name = "text_cep";
            this.text_cep.Size = new System.Drawing.Size(80, 22);
            this.text_cep.TabIndex = 72;
            this.text_cep.Visible = false;
            // 
            // text_complemento
            // 
            this.text_complemento.Location = new System.Drawing.Point(699, 61);
            this.text_complemento.Name = "text_complemento";
            this.text_complemento.Size = new System.Drawing.Size(80, 22);
            this.text_complemento.TabIndex = 73;
            this.text_complemento.Visible = false;
            // 
            // listBox_estado_civil
            // 
            this.listBox_estado_civil.FormattingEnabled = true;
            this.listBox_estado_civil.ItemHeight = 16;
            this.listBox_estado_civil.Location = new System.Drawing.Point(12, 11);
            this.listBox_estado_civil.Name = "listBox_estado_civil";
            this.listBox_estado_civil.Size = new System.Drawing.Size(120, 84);
            this.listBox_estado_civil.TabIndex = 74;
            this.listBox_estado_civil.Visible = false;
            // 
            // listBox_status
            // 
            this.listBox_status.FormattingEnabled = true;
            this.listBox_status.ItemHeight = 16;
            this.listBox_status.Location = new System.Drawing.Point(150, 11);
            this.listBox_status.Name = "listBox_status";
            this.listBox_status.Size = new System.Drawing.Size(120, 84);
            this.listBox_status.TabIndex = 75;
            this.listBox_status.Visible = false;
            // 
            // maskedText_tel1
            // 
            this.maskedText_tel1.Location = new System.Drawing.Point(12, 101);
            this.maskedText_tel1.Name = "maskedText_tel1";
            this.maskedText_tel1.Size = new System.Drawing.Size(80, 22);
            this.maskedText_tel1.TabIndex = 76;
            this.maskedText_tel1.Visible = false;
            // 
            // maskedText_tel2
            // 
            this.maskedText_tel2.Location = new System.Drawing.Point(109, 101);
            this.maskedText_tel2.Name = "maskedText_tel2";
            this.maskedText_tel2.Size = new System.Drawing.Size(80, 22);
            this.maskedText_tel2.TabIndex = 77;
            this.maskedText_tel2.Visible = false;
            // 
            // maskedText_tel3
            // 
            this.maskedText_tel3.Location = new System.Drawing.Point(12, 129);
            this.maskedText_tel3.Name = "maskedText_tel3";
            this.maskedText_tel3.Size = new System.Drawing.Size(80, 22);
            this.maskedText_tel3.TabIndex = 78;
            this.maskedText_tel3.Visible = false;
            // 
            // mask_ano_batismo
            // 
            this.mask_ano_batismo.Location = new System.Drawing.Point(109, 129);
            this.mask_ano_batismo.Name = "mask_ano_batismo";
            this.mask_ano_batismo.Size = new System.Drawing.Size(80, 22);
            this.mask_ano_batismo.TabIndex = 79;
            this.mask_ano_batismo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(898, 375);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // text_rg
            // 
            this.text_rg.Location = new System.Drawing.Point(909, 61);
            this.text_rg.Name = "text_rg";
            this.text_rg.Size = new System.Drawing.Size(80, 22);
            this.text_rg.TabIndex = 81;
            this.text_rg.Visible = false;
            // 
            // text_cpf
            // 
            this.text_cpf.Location = new System.Drawing.Point(809, 90);
            this.text_cpf.Name = "text_cpf";
            this.text_cpf.Size = new System.Drawing.Size(80, 22);
            this.text_cpf.TabIndex = 82;
            this.text_cpf.Visible = false;
            // 
            // info_membro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 544);
            this.Controls.Add(this.text_cpf);
            this.Controls.Add(this.text_rg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mask_ano_batismo);
            this.Controls.Add(this.maskedText_tel3);
            this.Controls.Add(this.maskedText_tel2);
            this.Controls.Add(this.maskedText_tel1);
            this.Controls.Add(this.listBox_status);
            this.Controls.Add(this.listBox_estado_civil);
            this.Controls.Add(this.text_complemento);
            this.Controls.Add(this.text_cep);
            this.Controls.Add(this.text_numero_casa);
            this.Controls.Add(this.textBox_estado);
            this.Controls.Add(this.text_rua);
            this.Controls.Add(this.text_bairro);
            this.Controls.Add(this.textBox_cidade);
            this.Controls.Add(this.text_pais);
            this.Controls.Add(this.text_falta);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.radio_falescimento);
            this.Controls.Add(this.maskedText_data_nascimento);
            this.Controls.Add(this.radio_sexo_masculino);
            this.Controls.Add(this.radio_sexo_feminino);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_nome_igreja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_reconciliacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_estado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_cidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_denominacao);
            this.Controls.Add(this.label1);
            this.Name = "info_membro";
            this.Text = "info_membro";
            this.Load += new System.EventHandler(this.info_membro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_nome_igreja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_reconciliacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_estado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_cidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_denominacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.RadioButton radio_sexo_feminino;
        private System.Windows.Forms.RadioButton radio_sexo_masculino;
        private System.Windows.Forms.MaskedTextBox maskedText_data_nascimento;
        private System.Windows.Forms.RadioButton radio_falescimento;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.TextBox text_falta;
        private System.Windows.Forms.TextBox text_pais;
        private System.Windows.Forms.TextBox textBox_cidade;
        private System.Windows.Forms.TextBox text_bairro;
        private System.Windows.Forms.TextBox text_rua;
        private System.Windows.Forms.TextBox textBox_estado;
        private System.Windows.Forms.TextBox text_numero_casa;
        private System.Windows.Forms.TextBox text_cep;
        private System.Windows.Forms.TextBox text_complemento;
        private System.Windows.Forms.ListBox listBox_estado_civil;
        private System.Windows.Forms.ListBox listBox_status;
        private System.Windows.Forms.MaskedTextBox maskedText_tel1;
        private System.Windows.Forms.MaskedTextBox maskedText_tel2;
        private System.Windows.Forms.MaskedTextBox maskedText_tel3;
        private System.Windows.Forms.MaskedTextBox mask_ano_batismo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox text_rg;
        private System.Windows.Forms.TextBox text_cpf;
    }
}