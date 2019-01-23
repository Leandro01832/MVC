using View.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.form.atualização
{
    public partial class Atualizacao_crianca : Form
    {
        public Atualizacao_crianca()
        {
            InitializeComponent();
        }

        private void Atualizacao_crianca_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crianca cri = new Crianca();
            cri.Nome = text_nome.Text;

            cri.Data_nascimento = Convert.ToDateTime(text_data_nascimento.Text);
            cri.Rg = text_rg.Text;
            cri.Falescimento = false;
            cri.Email = textemail.Text;
            cri.Cpf = text_cpf.Text;
            cri.Falta = 0;
            cri.Pais = textpais2.Text;
            cri.Cidade = text_cidade2.Text;
            cri.Bairro = text_bairro2.Text;
            cri.Rua = text_rua2.Text;
            cri.Estado = text_estado2.Text;
            cri.Numero_casa = int.Parse(text_numero2.Text);
            cri.Cep = int.Parse(text_cep.Text);
            cri.Complemento = text_complemento2.Text;
           // cri.Estado_civil = listestado_civil2.Text;
           // cri.Status = listBox_status.Text;
            cri.Fone = text_telefone.Text;
            cri.Celular = text_celular.Text;
            cri.Whatsapp = text_whatsapp.Text;
            cri.Img = pictureBox1.ImageLocation;

            cri.Nome_mae = text_nome_mae.Text;
            cri.Nome_pai = text_nome_pai.Text;

            cri.alterar();
            cri.bd.montar_sql("", pictureBox1, lbl_id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Crianca cri = new Crianca();

            
            if (text_nome.Text != "")
            {
                cri.Nome = text_nome.Text;
            }

            string comando = cri.recuperar();

            cri.bd.buscar_dados(comando, text_nome, text_cpf, text_rg, listestado_civil, textpais2, text_cep, text_estado2, text_cidade2, text_bairro2,
              text_rua2, text_numero2, text_complemento2, textemail, text_telefone, text_celular, text_whatsapp, listBox_status, text_data_nascimento,
              radio_falescimento, pictureBox1, text_nome_mae, text_nome_pai, null, null, null, null, null, null, null, null, null, lbl_id,
              null, null, null, null, null, null, null, null);
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            Pessoa pes = new Pessoa();
            pes.foto(pictureBox1);
            Visualizar_foto visu = new Visualizar_foto(pictureBox1);
            visu.Show();
        }
    }
}
