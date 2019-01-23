using business.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.classes;

namespace View.form.cadastro
{
    public partial class Form_crianca : Form
    {
        public Form_crianca()
        {
            InitializeComponent();
        }
        Pessoa pes = new Pessoa();
        Telefone tel = new Telefone();
        Crianca cri = new Crianca();

        private void button1_Click(object sender, EventArgs e)
        {
            Crianca cri = new Crianca(text_nome2.Text, radioButton_masculino2.Checked,
              radioButton_feminino2.Checked, mask_data_nascimento2.Text, text_rg.Text, false,
              text_email.Text, text_cpf.Text, 0, textpais2.Text, text_cidade2.Text, text_bairro2.Text,
              text_rua2.Text, text_estado2.Text, int.Parse(text_numero2.Text), int.Parse(text_cep.Text),
              text_complemento2.Text, "", "", mask_tel1_2.Text, mask_tel2_2.Text, mask_tel3.Text,
              picEmp.ImageLocation, text_nome_pai.Text, text_nome_mae.Text );  

            cri.salvar();
            cri.bd.montar_sql("", picEmp, null);
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            
            cri.foto(picEmp);
            Visualizar_foto visu = new Visualizar_foto(picEmp);
            visu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string urlconsulta = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml";
            DataSet retornaendereco = new DataSet();
            retornaendereco.ReadXml(urlconsulta.Replace("@cep", text_cep.Text));

            string retorno = retornaendereco.Tables[0].Rows[0]["resultado"].ToString();

            if (retorno == "0")
            {
                MessageBox.Show("CEP invalido");
            }
            else
            {
                text_cidade2.Text = retornaendereco.Tables[0].Rows[0]["cidade"].ToString();
                text_estado2.Text = retornaendereco.Tables[0].Rows[0]["uf"].ToString();
                text_rua2.Text = retornaendereco.Tables[0].Rows[0]["logradouro"].ToString();
                text_bairro2.Text = retornaendereco.Tables[0].Rows[0]["bairro"].ToString();
            }
        }

        private void text_nome2_TextChanged(object sender, EventArgs e)
        {
            pes.Nome = text_nome2.Text;
            Form_crianca_Load(text_nome2.Text, e);
        }

        private void Form_crianca_Load(object sender, EventArgs e)
        {
            if (pes.Nome == null || pes.Pais == null || pes.Cep == 0 ||
                pes.Estado == null || pes.Cidade == null || pes.Bairro == null
                || pes.Rua == null || pes.Numero_casa == 0 
                || pes.Sexo_feminino == false && pes.Sexo_masculino == false
                || cri.Nome_mae == null || cri.Nome_pai == null)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void textpais2_TextChanged(object sender, EventArgs e)
        {
            pes.Pais = textpais2.Text;
            Form_crianca_Load(textpais2.Text, e);
        }

        private void text_cep_TextChanged(object sender, EventArgs e)
        {
            if (text_cep.Text == "")
            {
                pes.Cep = 0;
                Form_crianca_Load(text_cep.Text, e);
            }
            else
            {
                try
                {
                    pes.Cep = long.Parse(text_cep.Text);
                    Form_crianca_Load(text_cep.Text, e);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Você não digitou um numero." +
                        "\n Por favor digite um numero.");
                    pes.Cep = 0;
                    Form_crianca_Load(text_cep.Text, e);
                    text_cep.Text = "";
                    return;
                }
                finally
                {

                }
            }
        }

        private void text_estado2_TextChanged(object sender, EventArgs e)
        {
            pes.Estado = text_estado2.Text;
            Form_crianca_Load(text_estado2.Text, e);
        }

        private void text_cidade2_TextChanged(object sender, EventArgs e)
        {
            pes.Cidade = text_cidade2.Text;
            Form_crianca_Load(text_cidade2.Text, e);
        }

        private void text_bairro2_TextChanged(object sender, EventArgs e)
        {
            pes.Bairro = text_bairro2.Text;
            Form_crianca_Load(text_bairro2.Text, e);
        }

        private void text_rua2_TextChanged(object sender, EventArgs e)
        {
            pes.Rua = text_rua2.Text;
            Form_crianca_Load(text_rua2.Text, e);
        }

        private void text_complemento2_TextChanged(object sender, EventArgs e)
        {
            pes.Complemento = text_complemento2.Text;
            Form_crianca_Load(text_complemento2.Text, e);
        }

        private void text_numero2_TextChanged(object sender, EventArgs e)
        {
            if (text_numero2.Text == "")
            {
                pes.Numero_casa = 0;
                Form_crianca_Load(text_numero2.Text, e);
            }
            else
            {
                try
                {
                    pes.Numero_casa = int.Parse(text_numero2.Text);
                    Form_crianca_Load(text_numero2.Text, e);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Você não digitou um numero." +
                        "\n Por favor digite um numero.");
                    pes.Numero_casa = 0;
                    Form_crianca_Load(text_numero2.Text, e);
                    text_numero2.Text = "";
                    return;
                }
                finally
                {

                }
            }
        }

        private void text_email_TextChanged(object sender, EventArgs e)
        {
            pes.Email = text_email.Text;
            Form_crianca_Load(text_email.Text, e);
        }

        private void mask_tel1_2_TextChanged(object sender, EventArgs e)
        {
            tel.Fone = mask_tel1_2.Text;
            Form_crianca_Load(mask_tel1_2.Text, e);
        }

        private void mask_tel2_2_TextChanged(object sender, EventArgs e)
        {
            tel.Celular = mask_tel2_2.Text;
            Form_crianca_Load(mask_tel2_2.Text, e);
        }

        private void mask_tel3_TextChanged(object sender, EventArgs e)
        {
            tel.Whatsapp = mask_tel3.Text;
            Form_crianca_Load(mask_tel3.Text, e);
        }

        private void text_rg_TextChanged(object sender, EventArgs e)
        {
            pes.Rg = text_rg.Text;
            Form_crianca_Load(text_rg.Text, e);
        }

        private void text_cpf_TextChanged(object sender, EventArgs e)
        {
            pes.Cpf = text_cpf.Text;
            Form_crianca_Load(text_cpf.Text, e);
        }

        private void mask_data_nascimento2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("coloque uma data valida");
        }

        private void radioButton_masculino2_CheckedChanged(object sender, EventArgs e)
        {
            pes.Sexo_masculino = radioButton_masculino2.Checked;
            Form_crianca_Load(radioButton_masculino2.Checked, e);
        }

        private void radioButton_feminino2_CheckedChanged(object sender, EventArgs e)
        {
            pes.Sexo_feminino = radioButton_feminino2.Checked;
            Form_crianca_Load(radioButton_masculino2.Checked, e);
        }

        private void text_nome_mae_TextChanged(object sender, EventArgs e)
        {
            cri.Nome_mae = text_nome_mae.Text;
            Form_crianca_Load(text_nome_mae.Text, e);
        }

        private void text_nome_pai_TextChanged(object sender, EventArgs e)
        {
            cri.Nome_pai = text_nome_pai.Text;
            Form_crianca_Load(text_nome_pai.Text, e);
        }
    }
}
