namespace WindowsForms.form.info
{
    partial class chamada
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
            this.label3 = new System.Windows.Forms.Label();
            this.text_data_inicio = new System.Windows.Forms.TextBox();
            this.text_numero_chamada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data de inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero da chamada";
            // 
            // text_data_inicio
            // 
            this.text_data_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_data_inicio.Location = new System.Drawing.Point(307, 139);
            this.text_data_inicio.Name = "text_data_inicio";
            this.text_data_inicio.Size = new System.Drawing.Size(169, 30);
            this.text_data_inicio.TabIndex = 3;
            this.text_data_inicio.TextChanged += new System.EventHandler(this.text_data_inicio_TextChanged);
            // 
            // text_numero_chamada
            // 
            this.text_numero_chamada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_numero_chamada.Location = new System.Drawing.Point(307, 210);
            this.text_numero_chamada.Name = "text_numero_chamada";
            this.text_numero_chamada.Size = new System.Drawing.Size(169, 30);
            this.text_numero_chamada.TabIndex = 5;
            this.text_numero_chamada.TextChanged += new System.EventHandler(this.text_numero_chamada_TextChanged);
            // 
            // chamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 391);
            this.Controls.Add(this.text_numero_chamada);
            this.Controls.Add(this.text_data_inicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "chamada";
            this.Text = "chamada";
            this.Load += new System.EventHandler(this.chamada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_data_inicio;
        private System.Windows.Forms.TextBox text_numero_chamada;
    }
}