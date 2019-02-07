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
using System.Collections;
using System.Text.RegularExpressions;

namespace igreja2.form.cadastro
{
    public partial class Form_crianca : Form
    {
        public Form_crianca()
        {
            InitializeComponent();
            cri.Telefone = new Telefone();
            cri.Endereco = new Endereco();
        }
        
        Crianca cri = new Crianca();

        private void button1_Click(object sender, EventArgs e)
        {
            string listbox = listBox1.Text;
            Regex reg = new Regex(@"(\d+)");
            string id = reg.Match(listbox).ToString();
            cri.Nome = text_nome2.Text;
            cri.Email = text_email.Text;
            cri.Rg = text_rg.Text;
            cri.Cpf = text_cpf.Text;
            cri.Endereco.Pais = textpais2.Text;
            cri.Endereco.Cep = long.Parse(text_cep.Text);
            cri.Endereco.Estado = text_estado2.Text;
            cri.Endereco.Cidade = text_cidade2.Text;
            cri.Endereco.Bairro = text_bairro2.Text;
            cri.Endereco.Rua = text_rua2.Text;
            cri.Endereco.Complemento = text_complemento2.Text;
            cri.Endereco.Numero_casa = int.Parse(text_numero2.Text);
            cri.Telefone.Fone = mask_tel1_2.Text;
            cri.Telefone.Celular = mask_tel2_2.Text;
            cri.Telefone.Whatsapp = mask_tel3.Text;
            cri.Data_nascimento = Convert.ToDateTime(mask_data_nascimento2.Text);
            cri.Falescimento = false;
            cri.Sexo_feminino = radioButton_feminino2.Checked;
            cri.Sexo_masculino = radioButton_masculino2.Checked;
            cri.Nome_mae = text_nome_mae.Text;
            cri.Nome_pai = text_nome_pai.Text;
            cri.celula_ = int.Parse(id);
            Celula cel = new Celula();
            cri.Chamada.Numero_chamada = cel.recuperar(int.Parse(id)).Pessoas.Count + 1;
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
            cri.Nome = text_nome2.Text;
            Form_crianca_Load(text_nome2.Text, e);
        }

        private void Form_crianca_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Celula cel = new Celula();
            IEnumerable<Celula> celulas = cel.recuperartodos();
            DataTable dtable = cel.bd.listar("select * from Celula order by Celulaid asc", false, false, false, "");
            foreach (var c in celulas)
            {
                ArrayList lista = new ArrayList();
                lista.Add(c);
                //exibe os registros no listbox
                listBox1.Items.Add(c.Cel_nome + " - " + c.Celulaid);
            }


            if (cri.Nome == null || cri.Endereco.Pais == null || cri.Endereco.Cep == 0 ||
                cri.Endereco.Estado == null || cri.Endereco.Cidade == null || cri.Endereco.Bairro == null
                || cri.Endereco.Rua == null || cri.Endereco.Numero_casa == 0 
                || cri.Sexo_feminino == false && cri.Sexo_masculino == false
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
            cri.Endereco.Pais = textpais2.Text;
            Form_crianca_Load(textpais2.Text, e);
        }

        private void text_cep_TextChanged(object sender, EventArgs e)
        {
            if (text_cep.Text == "")
            {
                cri.Endereco.Cep = 0;
                Form_crianca_Load(text_cep.Text, e);
            }
            else
            {
                try
                {
                    cri.Endereco.Cep = long.Parse(text_cep.Text);
                    Form_crianca_Load(text_cep.Text, e);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Você não digitou um numero." +
                        "\n Por favor digite um numero.");
                    cri.Endereco.Cep = 0;
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
            cri.Endereco.Estado = text_estado2.Text;
            Form_crianca_Load(text_estado2.Text, e);
        }

        private void text_cidade2_TextChanged(object sender, EventArgs e)
        {
            cri.Endereco.Cidade = text_cidade2.Text;
            Form_crianca_Load(text_cidade2.Text, e);
        }

        private void text_bairro2_TextChanged(object sender, EventArgs e)
        {
            cri.Endereco.Bairro = text_bairro2.Text;
            Form_crianca_Load(text_bairro2.Text, e);
        }

        private void text_rua2_TextChanged(object sender, EventArgs e)
        {
            cri.Endereco.Rua = text_rua2.Text;
            Form_crianca_Load(text_rua2.Text, e);
        }

        private void text_complemento2_TextChanged(object sender, EventArgs e)
        {
            cri.Endereco.Complemento = text_complemento2.Text;
            Form_crianca_Load(text_complemento2.Text, e);
        }

        private void text_numero2_TextChanged(object sender, EventArgs e)
        {
            if (text_numero2.Text == "")
            {
                cri.Endereco.Numero_casa = 0;
                Form_crianca_Load(text_numero2.Text, e);
            }
            else
            {
                try
                {
                    cri.Endereco.Numero_casa = int.Parse(text_numero2.Text);
                    Form_crianca_Load(text_numero2.Text, e);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Você não digitou um numero." +
                        "\n Por favor digite um numero.");
                    cri.Endereco.Numero_casa = 0;
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
            cri.Email = text_email.Text;
            Form_crianca_Load(text_email.Text, e);
        }

        private void mask_tel1_2_TextChanged(object sender, EventArgs e)
        {
            cri.Telefone.Fone = mask_tel1_2.Text;
            Form_crianca_Load(mask_tel1_2.Text, e);
        }

        private void mask_tel2_2_TextChanged(object sender, EventArgs e)
        {
            cri.Telefone.Celular = mask_tel2_2.Text;
            Form_crianca_Load(mask_tel2_2.Text, e);
        }

        private void mask_tel3_TextChanged(object sender, EventArgs e)
        {
            cri.Telefone.Whatsapp = mask_tel3.Text;
            Form_crianca_Load(mask_tel3.Text, e);
        }

        private void text_rg_TextChanged(object sender, EventArgs e)
        {
            cri.Rg = text_rg.Text;
            Form_crianca_Load(text_rg.Text, e);
        }

        private void text_cpf_TextChanged(object sender, EventArgs e)
        {
            cri.Cpf = text_cpf.Text;
            Form_crianca_Load(text_cpf.Text, e);
        }

        private void mask_data_nascimento2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("coloque uma data valida");
        }

        private void radioButton_masculino2_CheckedChanged(object sender, EventArgs e)
        {
            cri.Sexo_masculino = radioButton_masculino2.Checked;
            Form_crianca_Load(radioButton_masculino2.Checked, e);
        }

        private void radioButton_feminino2_CheckedChanged(object sender, EventArgs e)
        {
            cri.Sexo_feminino = radioButton_feminino2.Checked;
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
