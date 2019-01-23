using View.classes;
using View.form.cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.form.atualização;

namespace View.form.atualização
{
    public partial class Atualizacao_membro : Form
    {
        public Atualizacao_membro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Membro_Aclamacao mem = new Membro_Aclamacao();
            mem.Cpf = mask_verifica_cpf.Text;
            if (text_nome.Text != "")
            {
                mem.Nome = text_nome.Text;
            }

            Atualizar_membro men = new Atualizar_membro(text_nome.Text,  
            Convert.ToDateTime(text_data_nascimento.Text), text_rg.Text, textemail.Text, text_cpf.Text, textpais.Text, text_cidade.Text, text_bairro.Text,
            text_rua.Text, text_estado.Text, int.Parse(text_numero.Text), long.Parse(text_cep.Text), text_complemento.Text, listestado_civil.Text,
            listBox_status.Text, text_telefone.Text, text_celular.Text, text_whatsapp.Text, text_ano_batismo.Text, pictureBox1, lbl_id.Text);
            men.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Membro mem = new Membro();

            mem.Cpf = mask_verifica_cpf.Text;
            if (text_nome.Text != "")
            {
                mem.Nome = text_nome.Text;
            }

            string comando = mem.recuperar();

            mem.bd.buscar_dados(comando, text_nome, text_cpf, text_rg, listestado_civil, textpais, text_cep, text_estado, text_cidade, text_bairro,
              text_rua, text_numero, text_complemento, textemail, text_telefone, text_celular, text_whatsapp, listBox_status, text_data_nascimento,
              radio_falescimento, pictureBox1, null, null, null, null, null, null, null, null, null, text_ano_batismo, radio_desligamento, lbl_id,
              null, null, null, null, null, null, null,null);          

        }

        private void text_nome_TextChanged(object sender, EventArgs e)
        {
            Pessoa pes = new Pessoa();           
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
