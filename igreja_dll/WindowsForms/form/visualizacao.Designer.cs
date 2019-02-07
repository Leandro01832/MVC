namespace igreja2.form
{
    partial class visualizacao
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
            this.check_visitas = new System.Windows.Forms.CheckBox();
            this.check_reconciliacao = new System.Windows.Forms.CheckBox();
            this.check_transferencia = new System.Windows.Forms.CheckBox();
            this.check_membro = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.check_documento = new System.Windows.Forms.CheckBox();
            this.check_foto = new System.Windows.Forms.CheckBox();
            this.check_todos_campos = new System.Windows.Forms.CheckBox();
            this.check_faltas = new System.Windows.Forms.CheckBox();
            this.check_endereço = new System.Windows.Forms.CheckBox();
            this.check_telefones = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.check_aclamacao = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pessoa_listBox_status = new System.Windows.Forms.ListBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.pessoa_radioButton_feminino = new System.Windows.Forms.RadioButton();
            this.pessoa_radioButton_masculino = new System.Windows.Forms.RadioButton();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_estado_civil = new System.Windows.Forms.Label();
            this.pessoa_listestado_civil = new System.Windows.Forms.ListBox();
            this.pessoa_numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.pessoa_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_menor_de = new System.Windows.Forms.Label();
            this.lbl_maior_de = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgdados = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdados)).BeginInit();
            this.SuspendLayout();
            // 
            // check_visitas
            // 
            this.check_visitas.AutoSize = true;
            this.check_visitas.Enabled = false;
            this.check_visitas.Location = new System.Drawing.Point(210, 182);
            this.check_visitas.Margin = new System.Windows.Forms.Padding(4);
            this.check_visitas.Name = "check_visitas";
            this.check_visitas.Size = new System.Drawing.Size(244, 21);
            this.check_visitas.TabIndex = 274;
            this.check_visitas.Text = "data de visita e condição religiosa";
            this.check_visitas.UseVisualStyleBackColor = true;
            // 
            // check_reconciliacao
            // 
            this.check_reconciliacao.AutoSize = true;
            this.check_reconciliacao.Enabled = false;
            this.check_reconciliacao.Location = new System.Drawing.Point(210, 125);
            this.check_reconciliacao.Margin = new System.Windows.Forms.Padding(4);
            this.check_reconciliacao.Name = "check_reconciliacao";
            this.check_reconciliacao.Size = new System.Drawing.Size(161, 21);
            this.check_reconciliacao.TabIndex = 272;
            this.check_reconciliacao.Text = "ano de reconciliação";
            this.check_reconciliacao.UseVisualStyleBackColor = true;
            // 
            // check_transferencia
            // 
            this.check_transferencia.AutoSize = true;
            this.check_transferencia.Enabled = false;
            this.check_transferencia.Location = new System.Drawing.Point(210, 100);
            this.check_transferencia.Margin = new System.Windows.Forms.Padding(4);
            this.check_transferencia.Name = "check_transferencia";
            this.check_transferencia.Size = new System.Drawing.Size(270, 21);
            this.check_transferencia.TabIndex = 271;
            this.check_transferencia.Text = "cidade, estado e igreja - transferência";
            this.check_transferencia.UseVisualStyleBackColor = true;
            // 
            // check_membro
            // 
            this.check_membro.AutoSize = true;
            this.check_membro.Enabled = false;
            this.check_membro.Location = new System.Drawing.Point(210, 78);
            this.check_membro.Margin = new System.Windows.Forms.Padding(4);
            this.check_membro.Name = "check_membro";
            this.check_membro.Size = new System.Drawing.Size(281, 21);
            this.check_membro.TabIndex = 270;
            this.check_membro.Text = "verificar desligamento e ano de batismo";
            this.check_membro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 269;
            this.label1.Text = "Escolha a classe:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "pessoas",
            "membros",
            "membros por batismo",
            "membros por aclamação",
            "membros por transferência",
            "membros por reconciliação",
            "visitantes",
            "crianças"});
            this.comboBox1.Location = new System.Drawing.Point(241, 33);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 24);
            this.comboBox1.TabIndex = 268;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // check_documento
            // 
            this.check_documento.AutoSize = true;
            this.check_documento.Location = new System.Drawing.Point(11, 100);
            this.check_documento.Margin = new System.Windows.Forms.Padding(4);
            this.check_documento.Name = "check_documento";
            this.check_documento.Size = new System.Drawing.Size(107, 21);
            this.check_documento.TabIndex = 267;
            this.check_documento.Text = "documentos";
            this.check_documento.UseVisualStyleBackColor = true;
            this.check_documento.CheckedChanged += new System.EventHandler(this.check_documento_CheckedChanged);
            // 
            // check_foto
            // 
            this.check_foto.AutoSize = true;
            this.check_foto.Location = new System.Drawing.Point(11, 210);
            this.check_foto.Margin = new System.Windows.Forms.Padding(4);
            this.check_foto.Name = "check_foto";
            this.check_foto.Size = new System.Drawing.Size(54, 21);
            this.check_foto.TabIndex = 266;
            this.check_foto.Text = "foto";
            this.check_foto.UseVisualStyleBackColor = true;
            // 
            // check_todos_campos
            // 
            this.check_todos_campos.AutoSize = true;
            this.check_todos_campos.Location = new System.Drawing.Point(11, 78);
            this.check_todos_campos.Margin = new System.Windows.Forms.Padding(4);
            this.check_todos_campos.Name = "check_todos_campos";
            this.check_todos_campos.Size = new System.Drawing.Size(137, 21);
            this.check_todos_campos.TabIndex = 265;
            this.check_todos_campos.Text = "todos os campos";
            this.check_todos_campos.UseVisualStyleBackColor = true;
            // 
            // check_faltas
            // 
            this.check_faltas.AutoSize = true;
            this.check_faltas.Location = new System.Drawing.Point(11, 182);
            this.check_faltas.Margin = new System.Windows.Forms.Padding(4);
            this.check_faltas.Name = "check_faltas";
            this.check_faltas.Size = new System.Drawing.Size(64, 21);
            this.check_faltas.TabIndex = 264;
            this.check_faltas.Text = "faltas";
            this.check_faltas.UseVisualStyleBackColor = true;
            this.check_faltas.CheckedChanged += new System.EventHandler(this.check_faltas_CheckedChanged);
            // 
            // check_endereço
            // 
            this.check_endereço.AutoSize = true;
            this.check_endereço.Location = new System.Drawing.Point(11, 153);
            this.check_endereço.Margin = new System.Windows.Forms.Padding(4);
            this.check_endereço.Name = "check_endereço";
            this.check_endereço.Size = new System.Drawing.Size(90, 21);
            this.check_endereço.TabIndex = 263;
            this.check_endereço.Text = "endereço";
            this.check_endereço.UseVisualStyleBackColor = true;
            this.check_endereço.CheckedChanged += new System.EventHandler(this.check_endereço_CheckedChanged);
            // 
            // check_telefones
            // 
            this.check_telefones.AutoSize = true;
            this.check_telefones.Location = new System.Drawing.Point(11, 125);
            this.check_telefones.Margin = new System.Windows.Forms.Padding(4);
            this.check_telefones.Name = "check_telefones";
            this.check_telefones.Size = new System.Drawing.Size(88, 21);
            this.check_telefones.TabIndex = 262;
            this.check_telefones.Text = "telefones";
            this.check_telefones.UseVisualStyleBackColor = true;
            this.check_telefones.CheckedChanged += new System.EventHandler(this.check_telefones_CheckedChanged);
            // 
            // check_aclamacao
            // 
            this.check_aclamacao.AutoSize = true;
            this.check_aclamacao.Enabled = false;
            this.check_aclamacao.Location = new System.Drawing.Point(210, 153);
            this.check_aclamacao.Margin = new System.Windows.Forms.Padding(4);
            this.check_aclamacao.Name = "check_aclamacao";
            this.check_aclamacao.Size = new System.Drawing.Size(196, 21);
            this.check_aclamacao.TabIndex = 273;
            this.check_aclamacao.Text = "denominação - aclamação";
            this.check_aclamacao.UseVisualStyleBackColor = true;
            this.check_aclamacao.CheckedChanged += new System.EventHandler(this.check_aclamacao_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(157, 813);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 37);
            this.button2.TabIndex = 260;
            this.button2.Text = "exportar para excel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pessoa_listBox_status
            // 
            this.pessoa_listBox_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pessoa_listBox_status.FormattingEnabled = true;
            this.pessoa_listBox_status.ItemHeight = 16;
            this.pessoa_listBox_status.Items.AddRange(new object[] {
            "residente em Cataguases",
            "residente em outra cidade de Minas Gerais",
            "residente em outro estado do Brasil",
            "residente em outro país"});
            this.pessoa_listBox_status.Location = new System.Drawing.Point(1122, 251);
            this.pessoa_listBox_status.Margin = new System.Windows.Forms.Padding(4);
            this.pessoa_listBox_status.Name = "pessoa_listBox_status";
            this.pessoa_listBox_status.Size = new System.Drawing.Size(289, 68);
            this.pessoa_listBox_status.TabIndex = 259;
            this.pessoa_listBox_status.SelectedIndexChanged += new System.EventHandler(this.pessoa_listBox_status_SelectedIndexChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(1043, 254);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(64, 25);
            this.lbl_status.TabIndex = 256;
            this.lbl_status.Text = "status";
            // 
            // pessoa_radioButton_feminino
            // 
            this.pessoa_radioButton_feminino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pessoa_radioButton_feminino.AutoSize = true;
            this.pessoa_radioButton_feminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pessoa_radioButton_feminino.Location = new System.Drawing.Point(829, 176);
            this.pessoa_radioButton_feminino.Margin = new System.Windows.Forms.Padding(4);
            this.pessoa_radioButton_feminino.Name = "pessoa_radioButton_feminino";
            this.pessoa_radioButton_feminino.Size = new System.Drawing.Size(106, 29);
            this.pessoa_radioButton_feminino.TabIndex = 253;
            this.pessoa_radioButton_feminino.TabStop = true;
            this.pessoa_radioButton_feminino.Text = "feminino";
            this.pessoa_radioButton_feminino.UseVisualStyleBackColor = true;
            this.pessoa_radioButton_feminino.CheckedChanged += new System.EventHandler(this.pessoa_radioButton_feminino_CheckedChanged);
            // 
            // pessoa_radioButton_masculino
            // 
            this.pessoa_radioButton_masculino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pessoa_radioButton_masculino.AutoSize = true;
            this.pessoa_radioButton_masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pessoa_radioButton_masculino.Location = new System.Drawing.Point(664, 176);
            this.pessoa_radioButton_masculino.Margin = new System.Windows.Forms.Padding(4);
            this.pessoa_radioButton_masculino.Name = "pessoa_radioButton_masculino";
            this.pessoa_radioButton_masculino.Size = new System.Drawing.Size(121, 29);
            this.pessoa_radioButton_masculino.TabIndex = 252;
            this.pessoa_radioButton_masculino.TabStop = true;
            this.pessoa_radioButton_masculino.Text = "masculino";
            this.pessoa_radioButton_masculino.UseVisualStyleBackColor = true;
            this.pessoa_radioButton_masculino.CheckedChanged += new System.EventHandler(this.pessoa_radioButton_masculino_CheckedChanged);
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sexo.Location = new System.Drawing.Point(586, 180);
            this.lbl_sexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(60, 25);
            this.lbl_sexo.TabIndex = 254;
            this.lbl_sexo.Text = "sexo:";
            // 
            // lbl_estado_civil
            // 
            this.lbl_estado_civil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_estado_civil.AutoSize = true;
            this.lbl_estado_civil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado_civil.Location = new System.Drawing.Point(978, 171);
            this.lbl_estado_civil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estado_civil.Name = "lbl_estado_civil";
            this.lbl_estado_civil.Size = new System.Drawing.Size(108, 25);
            this.lbl_estado_civil.TabIndex = 251;
            this.lbl_estado_civil.Text = "estado civil";
            // 
            // pessoa_listestado_civil
            // 
            this.pessoa_listestado_civil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pessoa_listestado_civil.FormattingEnabled = true;
            this.pessoa_listestado_civil.ItemHeight = 16;
            this.pessoa_listestado_civil.Items.AddRange(new object[] {
            "casado(a)",
            "separado(a)",
            "solteiro(a)",
            "viuvo(a)"});
            this.pessoa_listestado_civil.Location = new System.Drawing.Point(1122, 163);
            this.pessoa_listestado_civil.Margin = new System.Windows.Forms.Padding(4);
            this.pessoa_listestado_civil.Name = "pessoa_listestado_civil";
            this.pessoa_listestado_civil.Size = new System.Drawing.Size(160, 36);
            this.pessoa_listestado_civil.TabIndex = 250;
            this.pessoa_listestado_civil.SelectedIndexChanged += new System.EventHandler(this.pessoa_listestado_civil_SelectedIndexChanged);
            // 
            // pessoa_numericUpDown2
            // 
            this.pessoa_numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pessoa_numericUpDown2.Location = new System.Drawing.Point(942, 77);
            this.pessoa_numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.pessoa_numericUpDown2.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.pessoa_numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pessoa_numericUpDown2.Name = "pessoa_numericUpDown2";
            this.pessoa_numericUpDown2.Size = new System.Drawing.Size(80, 22);
            this.pessoa_numericUpDown2.TabIndex = 249;
            this.pessoa_numericUpDown2.Value = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.pessoa_numericUpDown2.ValueChanged += new System.EventHandler(this.pessoa_numericUpDown2_ValueChanged);
            // 
            // pessoa_numericUpDown1
            // 
            this.pessoa_numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pessoa_numericUpDown1.Location = new System.Drawing.Point(942, 40);
            this.pessoa_numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.pessoa_numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pessoa_numericUpDown1.Name = "pessoa_numericUpDown1";
            this.pessoa_numericUpDown1.Size = new System.Drawing.Size(80, 22);
            this.pessoa_numericUpDown1.TabIndex = 248;
            this.pessoa_numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pessoa_numericUpDown1.ValueChanged += new System.EventHandler(this.pessoa_numericUpDown1_ValueChanged);
            // 
            // lbl_menor_de
            // 
            this.lbl_menor_de.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_menor_de.AutoSize = true;
            this.lbl_menor_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_menor_de.Location = new System.Drawing.Point(829, 77);
            this.lbl_menor_de.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_menor_de.Name = "lbl_menor_de";
            this.lbl_menor_de.Size = new System.Drawing.Size(97, 24);
            this.lbl_menor_de.TabIndex = 247;
            this.lbl_menor_de.Text = "menor de:";
            // 
            // lbl_maior_de
            // 
            this.lbl_maior_de.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_maior_de.AutoSize = true;
            this.lbl_maior_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_maior_de.Location = new System.Drawing.Point(829, 40);
            this.lbl_maior_de.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_maior_de.Name = "lbl_maior_de";
            this.lbl_maior_de.Size = new System.Drawing.Size(89, 24);
            this.lbl_maior_de.TabIndex = 246;
            this.lbl_maior_de.Text = "maior de:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(19, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 43);
            this.button1.TabIndex = 245;
            this.button1.Text = "generalizar dados";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgdados
            // 
            this.dgdados.AllowUserToAddRows = false;
            this.dgdados.AllowUserToDeleteRows = false;
            this.dgdados.AllowUserToOrderColumns = true;
            this.dgdados.BackgroundColor = System.Drawing.Color.White;
            this.dgdados.ColumnHeadersHeight = 18;
            this.dgdados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgdados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgdados.Location = new System.Drawing.Point(32, 389);
            this.dgdados.Margin = new System.Windows.Forms.Padding(0);
            this.dgdados.Name = "dgdados";
            this.dgdados.ReadOnly = true;
            this.dgdados.Size = new System.Drawing.Size(1658, 416);
            this.dgdados.TabIndex = 244;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(662, 290);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 21);
            this.checkBox1.TabIndex = 275;
            this.checkBox1.Text = "Desligamento";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(829, 290);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(113, 21);
            this.checkBox2.TabIndex = 276;
            this.checkBox2.Text = "Falescimento";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // visualizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 944);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.check_visitas);
            this.Controls.Add(this.check_reconciliacao);
            this.Controls.Add(this.check_transferencia);
            this.Controls.Add(this.check_membro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.check_documento);
            this.Controls.Add(this.check_foto);
            this.Controls.Add(this.check_todos_campos);
            this.Controls.Add(this.check_faltas);
            this.Controls.Add(this.check_endereço);
            this.Controls.Add(this.check_telefones);
            this.Controls.Add(this.check_aclamacao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pessoa_listBox_status);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.pessoa_radioButton_feminino);
            this.Controls.Add(this.pessoa_radioButton_masculino);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.lbl_estado_civil);
            this.Controls.Add(this.pessoa_listestado_civil);
            this.Controls.Add(this.pessoa_numericUpDown2);
            this.Controls.Add(this.pessoa_numericUpDown1);
            this.Controls.Add(this.lbl_menor_de);
            this.Controls.Add(this.lbl_maior_de);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgdados);
            this.Name = "visualizacao";
            this.Text = "visualizacao";
            this.Load += new System.EventHandler(this.visualizacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check_visitas;
        private System.Windows.Forms.CheckBox check_reconciliacao;
        private System.Windows.Forms.CheckBox check_transferencia;
        private System.Windows.Forms.CheckBox check_membro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox check_documento;
        private System.Windows.Forms.CheckBox check_foto;
        private System.Windows.Forms.CheckBox check_todos_campos;
        private System.Windows.Forms.CheckBox check_faltas;
        private System.Windows.Forms.CheckBox check_endereço;
        private System.Windows.Forms.CheckBox check_telefones;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox check_aclamacao;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox pessoa_listBox_status;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.RadioButton pessoa_radioButton_feminino;
        private System.Windows.Forms.RadioButton pessoa_radioButton_masculino;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_estado_civil;
        private System.Windows.Forms.ListBox pessoa_listestado_civil;
        private System.Windows.Forms.NumericUpDown pessoa_numericUpDown2;
        private System.Windows.Forms.NumericUpDown pessoa_numericUpDown1;
        private System.Windows.Forms.Label lbl_menor_de;
        private System.Windows.Forms.Label lbl_maior_de;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgdados;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}