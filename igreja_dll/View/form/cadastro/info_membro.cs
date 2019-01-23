using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using business.classes;

namespace View.form.cadastro
{
    public partial class info_membro : Form
    {
       public info_membro(string nome, bool sexo_feminino, bool sexo_masculino, DateTime data_nascimento, string rg, string email,
       string cpf, string pais, string cidade, string bairro, string rua, string estado, int numero_casa, long cep, string complemento,
       string estado_civil, string status, string tel1, string tel2, string tel3, string ano_batismo, PictureBox foto)
        {
            InitializeComponent();
            
            text_nome.Text = nome;
            radio_sexo_feminino.Checked = sexo_feminino;
            radio_sexo_masculino.Checked = sexo_masculino;
            maskedText_data_nascimento.Text = data_nascimento.ToString();
            text_rg.Text = rg;
          //  radio_falescimento.Checked = falescimento;
            text_email.Text = email;
            text_cpf.Text = cpf;
           // text_falta.Text = falta.ToString();
            text_pais.Text = pais;
            textBox_cidade.Text = cidade;
            text_bairro.Text = bairro;
            text_rua.Text = rua;
            textBox_estado.Text = estado;
            text_numero_casa.Text = numero_casa.ToString();
            text_cep.Text = cep.ToString();
            text_complemento.Text = complemento;
            listBox_estado_civil.Text = estado_civil;
            listBox_status.Text = status;
            maskedText_tel1.Text = tel1;
            maskedText_tel2.Text = tel2;
            maskedText_tel3.Text = tel3;
            mask_ano_batismo.Text = ano_batismo;
            pictureBox1 = foto;

        }

        Membro_Transferencia memb_trans = new Membro_Transferencia();

        Membro_Reconciliacao memb = new Membro_Reconciliacao();

        Membro_Aclamacao memb_acla = new Membro_Aclamacao();

        private void info_membro_Load(object sender, EventArgs e)
        {      

            if (memb_trans.Nome_cidade_transferencia == null || memb_trans.Estado_transferencia == null 
                || memb_trans.Nome_igreja_transferencia == null)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }

            if (memb.Data_reconciliação == 0)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }

            if (memb_acla.Denominacao == null)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Membro_Transferencia memb_trans = new Membro_Transferencia(text_nome.Text, radio_sexo_masculino.Checked,
               radio_sexo_feminino.Checked, maskedText_data_nascimento.Text, text_rg.Text, radio_falescimento.Checked,
               text_email.Text, text_cpf.Text, 0, text_pais.Text, textBox_cidade.Text, text_bairro.Text, text_rua.Text,
               textBox_estado.Text, int.Parse(text_numero_casa.Text), int.Parse(text_cep.Text), text_complemento.Text, listBox_estado_civil.Text,
               listBox_status.Text, maskedText_tel1.Text, maskedText_tel2.Text, maskedText_tel3.Text, text_cidade.Text,
               text_estado.Text, text_nome_igreja.Text, int.Parse(mask_ano_batismo.Text), pictureBox1.ImageLocation);         
                        
            memb_trans.salvar();
            Pessoa pes = new Pessoa();
            pes.bd.montar_sql("", pictureBox1, null);   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Membro_Reconciliacao memb = new Membro_Reconciliacao(text_nome.Text, radio_sexo_masculino.Checked,
               radio_sexo_feminino.Checked, maskedText_data_nascimento.Text, text_rg.Text, radio_falescimento.Checked,
               text_email.Text, text_cpf.Text, 0, text_pais.Text, textBox_cidade.Text, text_bairro.Text, text_rua.Text,
               textBox_estado.Text, int.Parse(text_numero_casa.Text), int.Parse(text_cep.Text), text_complemento.Text, listBox_estado_civil.Text,
               listBox_status.Text, maskedText_tel1.Text, maskedText_tel2.Text, maskedText_tel3.Text, int.Parse(mask_ano_batismo.Text), 
               pictureBox1.ImageLocation, int.Parse(text_reconciliacao.Text));          

            memb.salvar();
            Pessoa pes = new Pessoa();
            pes.bd.montar_sql("", pictureBox1, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Membro_Aclamacao memb = new Membro_Aclamacao(text_nome.Text, radio_sexo_masculino.Checked,
               radio_sexo_feminino.Checked, maskedText_data_nascimento.Text, text_rg.Text, radio_falescimento.Checked,
               text_email.Text, text_cpf.Text, 0, text_pais.Text, textBox_cidade.Text, text_bairro.Text, text_rua.Text,
               textBox_estado.Text, int.Parse(text_numero_casa.Text), int.Parse(text_cep.Text), text_complemento.Text, listBox_estado_civil.Text,
               listBox_status.Text, maskedText_tel1.Text, maskedText_tel2.Text, maskedText_tel3.Text, int.Parse(mask_ano_batismo.Text),
               pictureBox1.ImageLocation, text_denominacao.Text);          

            memb.salvar();
            Pessoa pes = new Pessoa();
            pes.bd.montar_sql("", pictureBox1, null);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
              MessageBox.Show("informação adicionada em batismos");                               
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Membro_Batismo mem = new Membro_Batismo(text_nome.Text, radio_sexo_masculino.Checked,
               radio_sexo_feminino.Checked, maskedText_data_nascimento.Text, text_rg.Text, radio_falescimento.Checked,
               text_email.Text, text_cpf.Text, 0, text_pais.Text, textBox_cidade.Text, text_bairro.Text, text_rua.Text,
               textBox_estado.Text, int.Parse(text_numero_casa.Text), int.Parse(text_cep.Text), text_complemento.Text, listBox_estado_civil.Text,
               listBox_status.Text, maskedText_tel1.Text, maskedText_tel2.Text, maskedText_tel3.Text, int.Parse(mask_ano_batismo.Text),
               pictureBox1.ImageLocation);               

                mem.salvar();
                Pessoa pes = new Pessoa();
                pes.bd.montar_sql("", pictureBox1, null);
            }
        }

        private void text_cidade_TextChanged(object sender, EventArgs e)
        {
            memb_trans.Nome_cidade_transferencia = text_cidade.Text;
            info_membro_Load(text_cidade.Text, e);
        }

        private void text_estado_TextChanged(object sender, EventArgs e)
        {           
            memb_trans.Estado_transferencia = text_estado.Text;
            info_membro_Load(text_estado.Text, e);
        }

        private void text_nome_igreja_TextChanged(object sender, EventArgs e)
        {          
            memb_trans.Nome_igreja_transferencia = text_nome_igreja.Text;
            info_membro_Load(text_nome_igreja.Text, e);
        }

        private void text_reconciliacao_TextChanged(object sender, EventArgs e)
        {          
            if (text_reconciliacao.Text == "")
            {
                memb.Data_reconciliação = 0;
                info_membro_Load(text_reconciliacao.Text, e);
            }
            else
            {
                memb.Data_reconciliação = int.Parse(text_reconciliacao.Text);
                info_membro_Load(text_reconciliacao.Text, e);
            }            
        }

        private void text_denominacao_TextChanged(object sender, EventArgs e)
        {                     
            memb_acla.Denominacao = text_denominacao.Text;
            info_membro_Load(text_denominacao.Text, e);
        }
    }
}
