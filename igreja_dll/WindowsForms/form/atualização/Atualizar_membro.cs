using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using business.classes;

namespace igreja2.form.atualização
{
    public partial class Atualizar_membro : Form
    {
        public Atualizar_membro(Membro mem)
        {
            InitializeComponent();
            text_nome.Text = mem.Nome;            
            maskedText_data_nascimento.Text = mem.Data_nascimento.ToString();
            maskedText_rg.Text = mem.Rg;
            //  radio_falescimento.Checked = falescimento;
            //text_email.Text = email;
            //maskedText_cpf.Text = cpf;
            //// text_falta.Text = falta.ToString();
            //text_pais.Text = pais;
            //textBox_cidade.Text = cidade;
            //text_bairro.Text = bairro;
            //text_rua.Text = rua;
            //textBox_estado.Text = estado;
            //text_numero_casa.Text = numero_casa.ToString();
            //text_cep.Text = cep.ToString();
            //text_complemento.Text = complemento;
            //listBox_estado_civil.Text = estado_civil;
            //listBox_status.Text = status;
            //maskedText_tel1.Text = tel1;
            //maskedText_tel2.Text = tel2;
            //maskedText_tel3.Text = tel3;
            //mask_ano_batismo.Text = ano_batismo;
            //pictureBox1 = foto;
            //lbl_id.Text = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Membro_Transferencia mem = new Membro_Transferencia();
            mem.Id = int.Parse(lbl_id.Text);
            mem.Nome = text_nome.Text;
            mem.Sexo_feminino = radio_sexo_feminino.Checked;
            mem.Sexo_masculino = radio_sexo_masculino.Checked;
            string sqlFormattedDate = maskedText_data_nascimento.Text;
            mem.Data_nascimento = Convert.ToDateTime(sqlFormattedDate);
            mem.Rg = maskedText_rg.Text;
            mem.Falescimento = false;
            mem.Email = text_email.Text;
            mem.Cpf = maskedText_cpf.Text;
            mem.Falta = 0;
            mem.Endereco.Pais = text_pais.Text;
            mem.Endereco.Cidade = textBox_cidade.Text;
            mem.Endereco.Bairro = text_bairro.Text;
            mem.Endereco.Rua = text_rua.Text;
            mem.Endereco.Estado = textBox_estado.Text;
            mem.Endereco.Numero_casa = int.Parse(text_numero_casa.Text);
            mem.Endereco.Cep = int.Parse(text_cep.Text);
            mem.Endereco.Complemento = text_complemento.Text;
            mem.Estado_civil = listBox_estado_civil.Text;
            mem.Status = listBox_status.Text;
            mem.Telefone.Fone = maskedText_tel1.Text;
            mem.Telefone.Celular = maskedText_tel2.Text;
            mem.Telefone.Whatsapp = maskedText_tel3.Text;            
            mem.Data_batismo = int.Parse(mask_ano_batismo.Text);
           // mem.Img = pictureBox1.ImageLocation;

            mem.Nome_cidade_transferencia = text_cidade.Text;
            mem.Nome_igreja_transferencia = text_nome_igreja.Text;
            mem.Estado_transferencia = text_estado.Text;

            mem.alterar(mem.Id);
            mem.bd.montar_sql("", pictureBox1, lbl_id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Membro_Reconciliacao mem = new Membro_Reconciliacao();
            mem.Id = int.Parse(lbl_id.Text);
            mem.Nome = text_nome.Text;
            mem.Sexo_feminino = radio_sexo_feminino.Checked;
            mem.Sexo_masculino = radio_sexo_masculino.Checked;
            mem.Data_nascimento = Convert.ToDateTime(maskedText_data_nascimento.Text);
            mem.Rg = maskedText_rg.Text;
            mem.Falescimento = false;
            mem.Email = text_email.Text;
            mem.Cpf = maskedText_cpf.Text;
            mem.Falta = 0;
            mem.Endereco.Pais = text_pais.Text;
            mem.Endereco.Cidade = textBox_cidade.Text;
            mem.Endereco.Bairro = text_bairro.Text;
            mem.Endereco.Rua = text_rua.Text;
            mem.Endereco.Estado = textBox_estado.Text;
            mem.Endereco.Numero_casa = int.Parse(text_numero_casa.Text);
            mem.Endereco.Cep = int.Parse(text_cep.Text);
            mem.Endereco.Complemento = text_complemento.Text;
            mem.Estado_civil = listBox_estado_civil.Text;
            mem.Status = listBox_status.Text;
            mem.Telefone.Fone = maskedText_tel1.Text;
            mem.Telefone.Celular = maskedText_tel2.Text;
            mem.Telefone.Whatsapp = maskedText_tel3.Text;
            mem.Data_batismo = int.Parse(mask_ano_batismo.Text);
           // mem.Img = pictureBox1.ImageLocation;

            mem.Data_reconciliacao = int.Parse(text_reconciliacao.Text);

            mem.alterar(mem.Id);
            mem.bd.montar_sql("", pictureBox1, lbl_id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Membro_Aclamacao mem = new Membro_Aclamacao();
            mem.Id = int.Parse(lbl_id.Text);
            mem.Nome = text_nome.Text;
            mem.Sexo_feminino = radio_sexo_feminino.Checked;
            mem.Sexo_masculino = radio_sexo_masculino.Checked;
            mem.Data_nascimento = Convert.ToDateTime(maskedText_data_nascimento.Text);
            mem.Rg = maskedText_rg.Text;
            mem.Falescimento = false;
            mem.Email = text_email.Text;
            mem.Cpf = maskedText_cpf.Text;
            mem.Falta = 0;
            mem.Endereco.Pais = text_pais.Text;
            mem.Endereco.Cidade = textBox_cidade.Text;
            mem.Endereco.Bairro = text_bairro.Text;
            mem.Endereco.Rua = text_rua.Text;
            mem.Endereco.Estado = textBox_estado.Text;
            mem.Endereco.Numero_casa = int.Parse(text_numero_casa.Text);
            mem.Endereco.Cep = int.Parse(text_cep.Text);
            mem.Endereco.Complemento = text_complemento.Text;
            mem.Estado_civil = listBox_estado_civil.Text;
            mem.Status = listBox_status.Text;
            mem.Telefone.Fone = maskedText_tel1.Text;
            mem.Telefone.Celular = maskedText_tel2.Text;
            mem.Telefone.Whatsapp = maskedText_tel3.Text;
            mem.Data_batismo = int.Parse(mask_ano_batismo.Text);
           // mem.Img = pictureBox1.ImageLocation;

            mem.Denominacao = text_denominacao.Text;

            mem.alterar(mem.Id);
            mem.bd.montar_sql("", pictureBox1, lbl_id);
        }

        private void Atualizar_membro_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Membro_Batismo mem = new Membro_Batismo();
            mem.Id = int.Parse(lbl_id.Text);
            mem.Nome = text_nome.Text;
            mem.Sexo_feminino = radio_sexo_feminino.Checked;
            mem.Sexo_masculino = radio_sexo_masculino.Checked;
            mem.Data_nascimento = Convert.ToDateTime(maskedText_data_nascimento.Text);
            mem.Rg = maskedText_rg.Text;
            mem.Falescimento = false;
            mem.Email = text_email.Text;
            mem.Cpf = maskedText_cpf.Text;
            mem.Falta = 0;
            mem.Endereco.Pais = text_pais.Text;
            mem.Endereco.Cidade = textBox_cidade.Text;
            mem.Endereco.Bairro = text_bairro.Text;
            mem.Endereco.Rua = text_rua.Text;
            mem.Endereco.Estado = textBox_estado.Text;
            mem.Endereco.Numero_casa = int.Parse(text_numero_casa.Text);
            mem.Endereco.Cep = int.Parse(text_cep.Text);
            mem.Endereco.Complemento = text_complemento.Text;
            mem.Estado_civil = listBox_estado_civil.Text;
            mem.Status = listBox_status.Text;
            mem.Telefone.Fone = maskedText_tel1.Text;
            mem.Telefone.Celular = maskedText_tel2.Text;
            mem.Telefone.Whatsapp = maskedText_tel3.Text;
            mem.Data_batismo = int.Parse(mask_ano_batismo.Text);
            //mem.Img = pictureBox1.ImageLocation;


            mem.alterar(mem.Id);
            mem.bd.montar_sql("", pictureBox1, lbl_id);
        }
    }
}
