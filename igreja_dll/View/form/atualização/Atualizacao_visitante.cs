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
    public partial class Atualizacao_visitante : Form
    {
        public Atualizacao_visitante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visitante visi = new Visitante();
            visi.Nome = text_nome.Text;
          
            visi.Data_nascimento = Convert.ToDateTime(text_data_nascimento.Text);
            visi.Rg = text_rg.Text;
            visi.Falescimento = false;
            visi.Email = textemail.Text;
            visi.Cpf = text_cpf.Text;
            visi.Falta = 0;
            visi.Pais = textpais.Text;
            visi.Cidade = text_cidade.Text;
            visi.Bairro = text_bairro.Text;
            visi.Rua = text_rua.Text;
            visi.Estado = text_estado.Text;
            visi.Numero_casa = int.Parse(text_numero.Text);
            visi.Cep = int.Parse(text_cep.Text);
            visi.Complemento = text_complemento.Text;
            visi.Estado_civil = listestado_civil.Text;
            visi.Status = listBox_status.Text;
            visi.Fone = text_telefone.Text;
            visi.Celular = text_celular.Text;
            visi.Whatsapp = text_whatsapp.Text;

            visi.Data_visita = Convert.ToDateTime(text_visita.Text);
            // visi.Condicao_religiosa = list_condicao.Text;

            visi.alterar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Visitante visi = new Visitante();

            visi.Cpf = mask_verifica_cpf.Text;
            if (text_nome.Text != "")
            {
                visi.Nome = text_nome.Text;
            }

            string comando = visi.recuperar();

            visi.bd.buscar_dados(comando, text_nome, text_cpf, text_rg, listestado_civil, textpais, text_cep, text_estado, text_cidade, text_bairro,
              text_rua, text_numero, text_complemento, textemail, text_telefone, text_celular, text_whatsapp, listBox_status, text_data_nascimento,
              radio_falescimento, pictureBox1, null, null, text_visita, list_condicao, null, null, null, null, null, null, null, lbl_id,
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
