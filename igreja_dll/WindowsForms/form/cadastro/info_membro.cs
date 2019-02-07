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
using database.banco;
using business.classes;

namespace igreja2.form.cadastro
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

            memb.Endereco = new Endereco();
            memb.Telefone = new Telefone();
            memb_trans.Endereco = new Endereco();
            memb_trans.Telefone = new Telefone();
            memb_acla.Endereco = new Endereco();
            memb_acla.Telefone = new Telefone();
        }

        Membro_Transferencia memb_trans = new Membro_Transferencia();

        Membro_Reconciliacao memb = new Membro_Reconciliacao();

        Membro_Aclamacao memb_acla = new Membro_Aclamacao();

        private void info_membro_Load(object sender, EventArgs e)
        {      

            //if (memb_trans.Nome_cidade_transferencia == null || memb_trans.Estado_transferencia == null 
            //    || memb_trans.Nome_igreja_transferencia == null)
            //{
            //    button4.Enabled = false;
            //}
            //else
            //{
            //    button4.Enabled = true;
            //}

            //if (memb.Data_reconciliacao == 0)
            //{
            //    button4.Enabled = false;
            //}
            //else
            //{
            //    button4.Enabled = true;
            //}

            //if (memb_acla.Denominacao == null)
            //{
            //    button4.Enabled = false;
            //}
            //else
            //{
            //    button4.Enabled = true;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
              
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            memb.Nome = text_nome.Text;
            memb.Email = text_email.Text;
            memb.Sexo_feminino = radio_sexo_feminino.Checked;
            memb.Sexo_masculino = radio_sexo_masculino.Checked;
            memb.Rg = text_rg.Text;
            memb.Cpf = text_cpf.Text;
            memb.Estado_civil = listBox_estado_civil.Text;
            memb.Endereco.Pais = text_pais.Text;
            memb.Endereco.Cep = long.Parse(text_cep.Text);
            memb.Endereco.Estado = textBox_estado.Text;
            memb.Endereco.Cidade = textBox_cidade.Text;
            memb.Endereco.Bairro = text_bairro.Text;
            memb.Endereco.Rua = text_rua.Text;
            memb.Endereco.Complemento = text_complemento.Text;
            memb.Endereco.Numero_casa = int.Parse(text_numero_casa.Text);
            memb.Telefone.Fone = maskedText_tel1.Text;
            memb.Telefone.Celular = maskedText_tel2.Text;
            memb.Telefone.Whatsapp = maskedText_tel3.Text;
            memb.Data_nascimento = Convert.ToDateTime(maskedText_data_nascimento.Text);
            memb.Data_batismo = int.Parse(mask_ano_batismo.Text);
            memb.Falescimento = radio_falescimento.Checked;
            memb.Desligamento = false;
            memb.Data_reconciliacao = int.Parse(text_reconciliacao.Text);
            memb.salvar();
            memb.bd.montar_sql("", pictureBox1, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            memb_acla.Nome = text_nome.Text;
            memb_acla.Email = text_email.Text;
            memb_acla.Sexo_feminino = radio_sexo_feminino.Checked;
            memb_acla.Sexo_masculino = radio_sexo_masculino.Checked;
            memb_acla.Rg = text_rg.Text;
            memb_acla.Cpf = text_cpf.Text;
            memb_acla.Estado_civil = listBox_estado_civil.Text;
            memb_acla.Endereco.Pais = text_pais.Text;
            memb_acla.Endereco.Cep = long.Parse(text_cep.Text);
            memb_acla.Endereco.Estado = textBox_estado.Text;
            memb_acla.Endereco.Cidade = textBox_cidade.Text;
            memb_acla.Endereco.Bairro = text_bairro.Text;
            memb_acla.Endereco.Rua = text_rua.Text;
            memb_acla.Endereco.Complemento = text_complemento.Text;
            memb_acla.Endereco.Numero_casa = int.Parse(text_numero_casa.Text);
            memb_acla.Telefone.Fone = maskedText_tel1.Text;
            memb_acla.Telefone.Celular = maskedText_tel2.Text;
            memb_acla.Telefone.Whatsapp = maskedText_tel3.Text;
            memb_acla.Data_nascimento = Convert.ToDateTime(maskedText_data_nascimento.Text);
            memb_acla.Data_batismo = int.Parse(mask_ano_batismo.Text);
            memb_acla.Falescimento = radio_falescimento.Checked;
            memb_acla.Desligamento = false;
            memb_acla.Denominacao = text_denominacao.Text;
            memb_acla.salvar();
            memb_acla.bd.montar_sql("", pictureBox1, null);
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
                Membro_Batismo mem = new Membro_Batismo();
                mem.Endereco = new Endereco();
                mem.Telefone = new Telefone();
                mem.Sexo_feminino = radio_sexo_feminino.Checked;
                mem.Sexo_masculino = radio_sexo_masculino.Checked;
                mem.Nome = text_nome.Text;
                mem.Email = text_email.Text;
                mem.Rg = text_rg.Text;
                mem.Cpf = text_cpf.Text;
                mem.Estado_civil = listBox_estado_civil.Text;
                mem.Endereco.Pais = text_pais.Text;
                mem.Endereco.Cep = long.Parse(text_cep.Text);
                mem.Endereco.Estado = textBox_estado.Text;
                mem.Endereco.Cidade = textBox_cidade.Text;
                mem.Endereco.Bairro = text_bairro.Text;
                mem.Endereco.Rua = text_rua.Text;
                mem.Endereco.Complemento = text_complemento.Text;
                mem.Endereco.Numero_casa = int.Parse(text_numero_casa.Text);
                mem.Telefone.Fone = maskedText_tel1.Text;
                mem.Telefone.Celular = maskedText_tel2.Text;
                mem.Telefone.Whatsapp = maskedText_tel3.Text;
                mem.Data_nascimento = Convert.ToDateTime(maskedText_data_nascimento.Text);
                mem.Data_batismo = int.Parse(mask_ano_batismo.Text);
                mem.Falescimento = radio_falescimento.Checked;
                mem.Desligamento = false;
                mem.salvar();
                mem.bd.montar_sql("", pictureBox1, null);                
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
                memb.Data_reconciliacao = 0;
                info_membro_Load(text_reconciliacao.Text, e);
            }
            else
            {
                memb.Data_reconciliacao = int.Parse(text_reconciliacao.Text);
                info_membro_Load(text_reconciliacao.Text, e);
            }            
        }

        private void text_denominacao_TextChanged(object sender, EventArgs e)
        {                     
            memb_acla.Denominacao = text_denominacao.Text;
            info_membro_Load(text_denominacao.Text, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {           
            memb_trans.Nome = text_nome.Text;
            memb_trans.Email = text_email.Text;
            memb_trans.Sexo_feminino = radio_sexo_feminino.Checked;
            memb_trans.Sexo_masculino = radio_sexo_masculino.Checked;
            memb_trans.Rg = text_rg.Text;
            memb_trans.Cpf = text_cpf.Text;
            memb_trans.Estado_civil = listBox_estado_civil.Text;
            memb_trans.Endereco.Pais = text_pais.Text;
            memb_trans.Endereco.Cep = long.Parse(text_cep.Text);
            memb_trans.Endereco.Estado = textBox_estado.Text;
            memb_trans.Endereco.Cidade = textBox_cidade.Text;
            memb_trans.Endereco.Bairro = text_bairro.Text;
            memb_trans.Endereco.Rua = text_rua.Text;
            memb_trans.Endereco.Complemento = text_complemento.Text;
            memb_trans.Endereco.Numero_casa = int.Parse(text_numero_casa.Text);
            memb_trans.Telefone.Fone = maskedText_tel1.Text;
            memb_trans.Telefone.Celular = maskedText_tel2.Text;
            memb_trans.Telefone.Whatsapp = maskedText_tel3.Text;
            memb_trans.Data_nascimento = Convert.ToDateTime(maskedText_data_nascimento.Text);
            memb_trans.Data_batismo = int.Parse(mask_ano_batismo.Text);
            memb_trans.Falescimento = radio_falescimento.Checked;
            memb_trans.Desligamento = false;
            memb_trans.Nome_cidade_transferencia = text_cidade.Text;
            memb_trans.Nome_igreja_transferencia = text_nome_igreja.Text;
            memb_trans.Estado_transferencia = text_estado.Text;
            memb_trans.salvar();
            memb_trans.bd.montar_sql("", pictureBox1, null);
        }
    }
}
