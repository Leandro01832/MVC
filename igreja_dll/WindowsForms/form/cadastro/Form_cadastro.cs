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
using System.Data.SqlClient;
using igreja2.form.cadastro;
using database.banco;
using System.Collections;
using System.Text.RegularExpressions;

namespace igreja2.form.cadastro
{
    public partial class frm_cadastro : Form

    {
        Pessoa pes = new Pessoa();
        
        Telefone tel = new Telefone();
        public frm_cadastro()
        {
            pes.Endereco = new Endereco();
            pes.Telefone = new Telefone();
            InitializeComponent();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            string listbox = listBox1.Text;
            Regex reg = new Regex(@"(\d+)");
            string id = reg.Match(listbox).ToString();
            pes = new Pessoa();
            pes.Endereco = new Endereco();
            pes.Telefone = new Telefone();
            pes.Nome = nome.Text.ToString();
            pes.Sexo_feminino = Convert.ToBoolean( radioButton_feminino.Checked);
            pes.Sexo_masculino = Convert.ToBoolean( radioButton_masculino.Checked);
            pes.Data_nascimento = Convert.ToDateTime( mask_data_nascimento.Text);
            pes.Rg = text_rg.Text.ToString();
            pes.Falescimento = false;
            pes.Email = textemail.Text;
            pes.Cpf = text_cpf.Text;
            pes.Falta = 0;
            pes.Endereco.Pais = textpais.Text;
            pes.Endereco.Cidade = text_cidade.Text;
            pes.Endereco.Bairro = text_bairro.Text;
            pes.Endereco.Rua = text_rua.Text;
            pes.Endereco.Estado = text_estado.Text;
            pes.Endereco.Numero_casa = int.Parse(text_numero.Text);
            pes.Endereco.Cep = long.Parse(text_cep.Text);
            pes.Endereco.Complemento = text_complemento.Text;
            pes.Estado_civil = listestado_civil.Text.ToString();
            pes.Status = listBox_status.Text;
            pes.Telefone.Fone = mask_tel1.Text;
            pes.Telefone.Celular = mask_tel2.Text;
            pes.Telefone.Whatsapp = mask_tel3.Text;
            pes.celula_ = int.Parse(id);
            Celula cel = new Celula();
            pes.Chamada.Numero_chamada = cel.recuperar(int.Parse(id)).Pessoas.Count + 1;
           // pes.img = pictureBox1.ImageLocation;

            form.cadastro.info_membro info = new info_membro(text_nome.Text, radioButton_feminino.Checked, radioButton_masculino.Checked,
            Convert.ToDateTime(mask_data_nascimento.Text), text_rg.Text, textemail.Text, text_cpf.Text, textpais.Text, text_cidade.Text, text_bairro.Text,
            text_rua.Text, text_estado.Text, int.Parse(text_numero.Text), long.Parse(text_cep.Text), text_complemento.Text, listestado_civil.Text,
            listBox_status.Text, mask_tel1.Text, mask_tel2.Text, mask_tel3.Text, mask_ano_batismo.Text, pictureBox1);
            info.Show();           

        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            
            pes.foto(pictureBox1);
            Visualizar_foto visu = new Visualizar_foto(pictureBox1);
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
                text_cidade.Text = retornaendereco.Tables[0].Rows[0]["cidade"].ToString();
                text_estado.Text = retornaendereco.Tables[0].Rows[0]["uf"].ToString();
                text_rua.Text = retornaendereco.Tables[0].Rows[0]["logradouro"].ToString();
                text_bairro.Text = retornaendereco.Tables[0].Rows[0]["bairro"].ToString();
            }
        }

        private void text_nome_TextChanged(object sender, EventArgs e)
        {
            pes.Nome = text_nome.Text;
            frm_cadastro_Load(text_nome.Text, e);
        }

        private void frm_cadastro_Load(object sender, EventArgs e)
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

            if (pes.Nome == "" || pes.Rg == "" || pes.Cpf == "" || pes.Estado_civil == ""
                || pes.Endereco.Pais == "" || pes.Endereco.Cep == 0 || pes.Endereco.Estado == "" || pes.Endereco.Cidade == ""
                || pes.Endereco.Bairro == "" || pes.Endereco.Rua == "" || pes.Endereco.Numero_casa == 0 || pes.Status == ""
                || pes.Sexo_feminino == false && pes.Sexo_masculino == false)
            {
                cadastrar.Enabled = false;
            }
            else
            {
                cadastrar.Enabled = true;
            }
        }

        private void text_rg_TextChanged(object sender, EventArgs e)
        {
            pes.Rg = text_rg.Text;
            frm_cadastro_Load(text_rg.Text, e);
        }

        private void text_cpf_TextChanged(object sender, EventArgs e)
        {
            pes.Cpf = text_cpf.Text;
            frm_cadastro_Load(text_rg.Text, e);
        }

        private void listestado_civil_SelectedIndexChanged(object sender, EventArgs e)
        {
            pes.Estado_civil = listestado_civil.Text;
            frm_cadastro_Load(listestado_civil.Text, e);
        }

        private void textpais_TextChanged(object sender, EventArgs e)
        {
            pes.Endereco.Pais = textpais.Text;
            frm_cadastro_Load(textpais.Text, e);
        }

        private void text_cep_TextChanged(object sender, EventArgs e)
        {
            if(text_cep.Text == "")
            {
                pes.Endereco.Cep = 0;
                frm_cadastro_Load(text_cep.Text, e);
            }
            else
            {
                try
                {
                    pes.Endereco.Cep = long.Parse(text_cep.Text);
                    frm_cadastro_Load(text_cep.Text, e);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Você não digitou um numero." +
                        "\n Por favor digite um numero.");
                    pes.Endereco.Cep = 0;
                    frm_cadastro_Load(text_cep.Text, e);
                    text_cep.Text = "";
                    return;
                }
                finally
                {

                }
                
            }          
        }

        private void text_estado_TextChanged(object sender, EventArgs e)
        {
            pes.Endereco.Estado = text_estado.Text;
            frm_cadastro_Load(text_estado.Text, e);
        }

        private void text_cidade_TextChanged(object sender, EventArgs e)
        {
            pes.Endereco.Cidade = text_cidade.Text;
            frm_cadastro_Load(text_cidade.Text, e);
        }

        private void text_bairro_TextChanged(object sender, EventArgs e)
        {
            pes.Endereco.Bairro = text_bairro.Text;
            frm_cadastro_Load(text_bairro.Text, e);
        }

        private void text_rua_TextChanged(object sender, EventArgs e)
        {
            pes.Endereco.Rua = text_rua.Text;
            frm_cadastro_Load(text_bairro.Text, e);
        }

        private void text_numero_TextChanged(object sender, EventArgs e)
        {
            if(text_numero.Text == "")
            {
                pes.Endereco.Numero_casa = 0;
                frm_cadastro_Load(text_numero.Text, e);
            }
            else
            {
                try
                {
                    pes.Endereco.Numero_casa = int.Parse(text_numero.Text);
                    frm_cadastro_Load(text_numero.Text, e);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Você não digitou um numero.\n Por favor digite um numero.");
                    pes.Endereco.Numero_casa = 0;                   
                    frm_cadastro_Load(text_numero.Text, e);
                    text_numero.Text = "";
                    return;
                }
                finally
                {
                   
                }
               
            }            
        }

        private void text_complemento_TextChanged(object sender, EventArgs e)
        {
            pes.Endereco.Complemento = text_complemento.Text;
            frm_cadastro_Load(text_complemento.Text, e);
        }

        private void textemail_TextChanged(object sender, EventArgs e)
        {
            pes.Email = textemail.Text;
            frm_cadastro_Load(textemail.Text, e);
        }

        private void listBox_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            pes.Status = listBox_status.Text;
            frm_cadastro_Load(listBox_status.Text, e);
        }

        private void mask_tel1_TextChanged(object sender, EventArgs e)
        {
            tel.Fone = mask_tel1.Text;
            frm_cadastro_Load(mask_tel1.Text, e);
        }

        private void mask_tel2_TextChanged(object sender, EventArgs e)
        {
            tel.Celular = mask_tel2.Text;
            frm_cadastro_Load(mask_tel2.Text, e);
        }

        private void mask_tel3_TextChanged(object sender, EventArgs e)
        {
            tel.Whatsapp = mask_tel3.Text;
            frm_cadastro_Load(mask_tel3.Text, e);
        }

        private void mask_data_nascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("coloque uma data valida");
        }

        private void radioButton_masculino_CheckedChanged(object sender, EventArgs e)
        {
            pes.Sexo_masculino = radioButton_masculino.Checked;
            frm_cadastro_Load(radioButton_masculino.Checked, e);
        }

        private void radioButton_feminino_CheckedChanged(object sender, EventArgs e)
        {
            pes.Sexo_feminino = radioButton_feminino.Checked;
            frm_cadastro_Load(radioButton_feminino.Checked, e);
        }

        private void mask_ano_batismo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("informe o ano de batismo");
            frm_cadastro_Load(mask_ano_batismo.Text, e);
        }

        private void mask_data_nascimento_Leave(object sender, EventArgs e)
        {
            if (!mask_data_nascimento.MaskCompleted)
            {
                MessageBox.Show("Você não colocou a data completa");
                mask_data_nascimento.Focus();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
