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
using business.classes;

namespace View.form.cadastro
{
    public partial class Form_visitante : Form
    {
        public Form_visitante()
        {
            InitializeComponent();
        }

        Pessoa pes = new Pessoa();
        Telefone tel = new Telefone();
        Visitante visi = new Visitante();

        private void button1_Click(object sender, EventArgs e)
        {
            Visitante visi = new Visitante(text_nome2.Text, radioButton_masculino2.Checked,
              radioButton_feminino2.Checked, mask_data_nascimento2.Text, text_rg.Text, false,
              textemail2.Text, text_cpf.Text, 0, textpais2.Text, text_cidade2.Text, text_bairro2.Text,
              text_rua2.Text, text_estado2.Text, int.Parse(text_numero2.Text), int.Parse(text_cep.Text),
              text_complemento2.Text, listestado_civil2.Text, listBox_status.Text, mask_tel1_2.Text,
              mask_tel2_2.Text, mask_tel3.Text, picEmp.ImageLocation, mask_visita.Text, list_condicao.Text);          

            visi.salvar();
            visi.bd.montar_sql("", picEmp, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            visi.foto(picEmp);
            Visualizar_foto visu = new Visualizar_foto(picEmp);
            visu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void Form_visitante_Load(object sender, EventArgs e)
        {
            if (pes.Nome == null || pes.Rg == null || pes.Cpf == null || pes.Estado_civil == null
                || pes.Pais == null || pes.Cep == 0 || pes.Estado == null || pes.Cidade == null
                || pes.Bairro == null || pes.Rua == null || pes.Numero_casa == 0 || pes.Status == null
                || pes.Sexo_feminino == false && pes.Sexo_masculino == false
                || visi.Condicao_religiosa == null)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void text_nome2_TextChanged(object sender, EventArgs e)
        {
            pes.Nome = text_nome2.Text;
            Form_visitante_Load(text_nome2.Text, e);
        }

        private void text_rg_TextChanged(object sender, EventArgs e)
        {
            pes.Rg = text_rg.Text;
            Form_visitante_Load(text_rg.Text, e);
        }

        private void text_cpf_TextChanged(object sender, EventArgs e)
        {
            pes.Cpf = text_cpf.Text;
            Form_visitante_Load(text_cpf.Text, e);
        }

        private void listestado_civil2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pes.Estado_civil = listestado_civil2.Text;
            Form_visitante_Load(listestado_civil2.Text, e);
        }

        private void textpais2_TextChanged(object sender, EventArgs e)
        {
            pes.Pais = textpais2.Text;
            Form_visitante_Load(textpais2.Text, e);
        }

        private void text_cep_TextChanged(object sender, EventArgs e)
        {
            if (text_cep.Text == "")
            {
                pes.Cep = 0;
                Form_visitante_Load(text_cep.Text, e);
            }
            else
            {
                try
                {
                    pes.Cep = long.Parse(text_cep.Text);
                    Form_visitante_Load(text_cep.Text, e);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Você não digitou um numero." +
                        "\n Por favor digite um numero.");
                    pes.Cep = 0;
                    Form_visitante_Load(text_cep.Text, e);
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
            Form_visitante_Load(text_estado2.Text, e);
        }

        private void text_cidade2_TextChanged(object sender, EventArgs e)
        {
            pes.Cidade = text_cidade2.Text;
            Form_visitante_Load(text_cidade2.Text, e);
        }

        private void text_bairro2_TextChanged(object sender, EventArgs e)
        {
            pes.Bairro = text_bairro2.Text;
            Form_visitante_Load(text_bairro2.Text, e);
        }

        private void text_rua2_TextChanged(object sender, EventArgs e)
        {
            pes.Rua = text_rua2.Text;
            Form_visitante_Load( text_rua2.Text, e);
        }

        private void text_numero2_TextChanged(object sender, EventArgs e)
        {
            if (text_numero2.Text == "")
            {
                pes.Numero_casa = 0;
                Form_visitante_Load(text_numero2.Text, e);
            }
            else
            {
                try
                {
                    pes.Numero_casa = int.Parse(text_numero2.Text);
                    Form_visitante_Load(text_numero2.Text, e);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Você não digitou um numero." +
                        "\n Por favor digite um numero.");
                    pes.Numero_casa = 0;
                    Form_visitante_Load(text_numero2.Text, e);
                    text_numero2.Text = "";
                    return;
                }
                finally
                {

                }
            }
        }

        private void text_complemento2_TextChanged(object sender, EventArgs e)
        {
            pes.Complemento = text_complemento2.Text;
            Form_visitante_Load(text_complemento2.Text, e);
        }

        private void textemail2_TextChanged(object sender, EventArgs e)
        {
            pes.Email = textemail2.Text;
            Form_visitante_Load(textemail2.Text, e);
        }

        private void mask_tel1_2_TextChanged(object sender, EventArgs e)
        {
            tel.Fone = mask_tel1_2.Text;
            Form_visitante_Load(mask_tel1_2.Text, e);
        }

        private void mask_tel2_2_TextChanged(object sender, EventArgs e)
        {
            tel.Celular = mask_tel2_2.Text;
            Form_visitante_Load(mask_tel2_2.Text, e);
        }

        private void mask_tel3_TextChanged(object sender, EventArgs e)
        {
            tel.Whatsapp = mask_tel3.Text;
            Form_visitante_Load(mask_tel3.Text, e);
        }

        private void listBox_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            pes.Status = listBox_status.Text;
            Form_visitante_Load(listBox_status.Text, e);
        }

        private void mask_data_nascimento2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("coloque uma data valida");
        }

        private void mask_visita_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("coloque uma data valida");
        }

        private void radioButton_masculino2_CheckedChanged(object sender, EventArgs e)
        {
            pes.Sexo_masculino = radioButton_masculino2.Checked;
            Form_visitante_Load(radioButton_masculino2.Checked, e);
        }

        private void radioButton_feminino2_CheckedChanged(object sender, EventArgs e)
        {
            pes.Sexo_feminino = radioButton_feminino2.Checked;
            Form_visitante_Load(radioButton_feminino2.Checked, e);
        }

        private void list_condicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            visi.Condicao_religiosa = list_condicao.Text;
            Form_visitante_Load(list_condicao.Text, e);
        }
    }
}
