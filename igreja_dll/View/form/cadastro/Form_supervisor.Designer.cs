namespace View.form.cadastro
{
    partial class Form_supervisor
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_id_supervisor = new System.Windows.Forms.TextBox();
            this.text_id_supervisor_treinamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.text_nome_sup = new System.Windows.Forms.TextBox();
            this.text_nome_sup_treinamento = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.text_nome_celula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_id_celula = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "id do supervisor:";
            // 
            // text_id_supervisor
            // 
            this.text_id_supervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_id_supervisor.Location = new System.Drawing.Point(336, 89);
            this.text_id_supervisor.Name = "text_id_supervisor";
            this.text_id_supervisor.Size = new System.Drawing.Size(169, 28);
            this.text_id_supervisor.TabIndex = 1;
            this.text_id_supervisor.TextChanged += new System.EventHandler(this.text_id_supervisor_TextChanged);
            // 
            // text_id_supervisor_treinamento
            // 
            this.text_id_supervisor_treinamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_id_supervisor_treinamento.Location = new System.Drawing.Point(336, 136);
            this.text_id_supervisor_treinamento.Name = "text_id_supervisor_treinamento";
            this.text_id_supervisor_treinamento.Size = new System.Drawing.Size(169, 28);
            this.text_id_supervisor_treinamento.TabIndex = 3;
            this.text_id_supervisor_treinamento.TextChanged += new System.EventHandler(this.text_id_supervisor_treinamento_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "id do supervisor em treinamento:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "cadastrar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_nome_sup
            // 
            this.text_nome_sup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nome_sup.Location = new System.Drawing.Point(541, 89);
            this.text_nome_sup.Name = "text_nome_sup";
            this.text_nome_sup.ReadOnly = true;
            this.text_nome_sup.Size = new System.Drawing.Size(410, 28);
            this.text_nome_sup.TabIndex = 5;
            this.text_nome_sup.TextChanged += new System.EventHandler(this.text_nome_sup_TextChanged);
            // 
            // text_nome_sup_treinamento
            // 
            this.text_nome_sup_treinamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nome_sup_treinamento.Location = new System.Drawing.Point(541, 140);
            this.text_nome_sup_treinamento.Name = "text_nome_sup_treinamento";
            this.text_nome_sup_treinamento.ReadOnly = true;
            this.text_nome_sup_treinamento.Size = new System.Drawing.Size(410, 28);
            this.text_nome_sup_treinamento.TabIndex = 6;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(37, 21);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 24);
            this.lbl_id.TabIndex = 7;
            this.lbl_id.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(735, 318);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(463, 388);
            this.listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.Enabled = false;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(1216, 318);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(463, 388);
            this.listBox2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(882, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "celulas sem supervisor";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(1026, 712);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 47);
            this.button2.TabIndex = 11;
            this.button2.Text = "adicionar para supervisionamento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(1216, 712);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 47);
            this.button3.TabIndex = 12;
            this.button3.Text = "remover supervisionamento";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(1507, 712);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 47);
            this.button4.TabIndex = 13;
            this.button4.Text = "salvar supervisionamento";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1296, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "celulas que serão supervisionadas";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(41, 666);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 28);
            this.button5.TabIndex = 84;
            this.button5.Text = "cadastrar visita";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 595);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(36, 595);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 82;
            this.label7.Text = "data de visita:";
            // 
            // text_nome_celula
            // 
            this.text_nome_celula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_nome_celula.Enabled = false;
            this.text_nome_celula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_nome_celula.Location = new System.Drawing.Point(476, 531);
            this.text_nome_celula.Margin = new System.Windows.Forms.Padding(4);
            this.text_nome_celula.Name = "text_nome_celula";
            this.text_nome_celula.ReadOnly = true;
            this.text_nome_celula.Size = new System.Drawing.Size(252, 30);
            this.text_nome_celula.TabIndex = 81;
            this.text_nome_celula.TextChanged += new System.EventHandler(this.text_nome_celula_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 532);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 25);
            this.label6.TabIndex = 80;
            this.label6.Text = "id da celula a ser visitada:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(36, 477);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 25);
            this.label5.TabIndex = 79;
            this.label5.Text = "marque as datas de visitas:";
            // 
            // text_id_celula
            // 
            this.text_id_celula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_id_celula.Enabled = false;
            this.text_id_celula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_id_celula.Location = new System.Drawing.Point(292, 531);
            this.text_id_celula.Name = "text_id_celula";
            this.text_id_celula.Size = new System.Drawing.Size(169, 28);
            this.text_id_celula.TabIndex = 85;
            this.text_id_celula.TextChanged += new System.EventHandler(this.text_id_celula_TextChanged);
            // 
            // Form_supervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 785);
            this.Controls.Add(this.text_id_celula);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_nome_celula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.text_nome_sup_treinamento);
            this.Controls.Add(this.text_nome_sup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_id_supervisor_treinamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_id_supervisor);
            this.Controls.Add(this.label1);
            this.Name = "Form_supervisor";
            this.Text = "Form_supervisor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_supervisor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_id_supervisor;
        private System.Windows.Forms.TextBox text_id_supervisor_treinamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_nome_sup;
        private System.Windows.Forms.TextBox text_nome_sup_treinamento;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_nome_celula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_id_celula;
    }
}