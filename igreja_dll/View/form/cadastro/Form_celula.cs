
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
using database.banco;
using business.classes;

namespace View.form.cadastro
{
    public partial class Form_celula : Form
    {
        BDcomum bd = new BDcomum();
        public Form_celula()
        {
            InitializeComponent();
        }

        Celula cel = new Celula();
        

        private void Form_celula_Load(object sender, EventArgs e)
        {
            Pessoa pes = new Pessoa();
            bd.montar_relatorio(pes.recuperar(), true, false, listBox2);  
            
            if (cel.Cel_nome == null || cel.Lider == null || cel.Lider_treinamento == null
                || cel.Dia_semana == null || cel.Cel_numero == 0 || cel.Cel_bairro == null
                || cel.Cel_rua == null)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cel.Cel_nome = text_nome.Text;
            cel.Lider = text_lider.Text;
            cel.Lider_treinamento = text_lider_treinamento.Text;
            cel.Dia_semana = list_dia_semana.Text;
            cel.Horario = Convert.ToDateTime(mask_horario.Text);

            cel.Cel_bairro = text_bairro.Text;
            cel.Cel_cep = int.Parse(text_cep.Text);
            cel.Cel_rua = text_rua.Text;
            cel.Cel_numero = int.Parse(text_numero.Text);

            cel.salvar();

            listBox1.Enabled = true;
            listBox2.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = true;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iCont;

            // listBox1.Items.Clear();

            for (iCont = (listBox2.Items.Count) - 1; iCont >= 0; iCont--)

            {

                if (listBox2.GetSelected(iCont) == true)

                {

                    listBox1.Items.Add(listBox2.Items[iCont]);

                    listBox2.Items.RemoveAt(iCont);

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void text_adicionar_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Celula cel = new Celula();
            cel.Cel_nome = text_nome.Text;
            cel.Lider = text_lider.Text;
            cel.Lider_treinamento = text_lider_treinamento.Text;
            cel.Dia_semana = list_dia_semana.Text;
            cel.Horario = Convert.ToDateTime(mask_horario.Text);

            cel.Cel_bairro = text_bairro.Text;
            cel.Cel_cep = int.Parse(text_cep.Text);
            cel.Cel_rua = text_rua.Text;
            cel.Cel_numero = int.Parse(text_numero.Text);

            List<string> nomes = new List<string>();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Pessoa pes = new Pessoa();

                nomes.Add(listBox1.Items[i].ToString());

                MessageBox.Show(nomes[i] + " foi adicionado ao ministerio: " + text_nome.Text);

                string comando = "select * from pessoa where pes_nome='#nome'";

                comando = comando.Replace("#nome", nomes[i]);

                pes.bd.buscar_dados(comando, null, null, null, null, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null, lbl_id,
                null, null, null, null, null, null, null, null);

                string insert_padrao = "insert into celula_pessoa (pes_celula, cel_pessoa) " +
                " values (IDENT_CURRENT('celula'), '@pessoa')";

                string Insert = insert_padrao.Replace("@pessoa", lbl_id.Text);

                pes.bd.montar_sql(Insert, null, null);

                //  Email.Instancia.corpo = " Nós agora vamos ganhar muito dinheiro";
                // Email.Instancia.origem = "eu";
                //Email.Instancia.destino = "outra pessoa";
                //Email.Instancia.titulo = "dinheiro";
               // Email.Instancia.enviaremail();
            }

        }

        private void button4_Click(object sender, EventArgs e)
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
                text_rua.Text = retornaendereco.Tables[0].Rows[0]["logradouro"].ToString();
                text_bairro.Text = retornaendereco.Tables[0].Rows[0]["bairro"].ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int iCont;

           // listBox1.Items.Clear();

            for (iCont = (listBox1.Items.Count) - 1; iCont >= 0; iCont--)

            {

                if (listBox1.GetSelected(iCont) == true)

                {

                    listBox2.Items.Add(listBox1.Items[iCont]);

                    listBox1.Items.RemoveAt(iCont);

                }

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pessoa pes = new Pessoa();
            pes.Nome = listBox2.Text;
            pes.bd.buscar_dados(pes.recuperar(), null, null, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null,
                null, null, null, pictureBox1, null, null, null, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null,
                null, null, null);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Visualizar_foto visu = new Visualizar_foto(pictureBox1);
            visu.Show();
        }

        private void text_nome_TextChanged(object sender, EventArgs e)
        {
            cel.Cel_nome = text_nome.Text;
            Form_celula_Load(text_nome.Text, e);
        }

        private void text_lider_TextChanged(object sender, EventArgs e)
        {
            cel.Lider = text_lider.Text;
            Form_celula_Load(text_lider.Text, e);
        }

        private void text_lider_treinamento_TextChanged(object sender, EventArgs e)
        {
            cel.Lider_treinamento = text_lider_treinamento.Text;
            Form_celula_Load(text_lider_treinamento.Text, e);
        }

        private void list_dia_semana_SelectedIndexChanged(object sender, EventArgs e)
        {
            cel.Dia_semana = list_dia_semana.Text;
            Form_celula_Load(list_dia_semana.Text, e);
        }

        private void mask_horario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("coloque um horario valido");
        }

        private void text_cep_TextChanged(object sender, EventArgs e)
        {
            cel.Cel_cep = int.Parse(text_cep.Text);
            Form_celula_Load(text_cep.Text, e);
        }

        private void text_bairro_TextChanged(object sender, EventArgs e)
        {
            cel.Cel_bairro = text_bairro.Text;
            Form_celula_Load(text_bairro.Text, e);
        }

        private void text_rua_TextChanged(object sender, EventArgs e)
        {
            cel.Cel_rua = text_rua.Text;
            Form_celula_Load(text_rua.Text, e);
        }

        private void text_numero_TextChanged(object sender, EventArgs e)
        {
            if(text_numero.Text == "")
            {
                cel.Cel_numero = 0;
                Form_celula_Load(text_numero.Text, e);
            }
            else
            {
                cel.Cel_numero = int.Parse(text_numero.Text);
                Form_celula_Load(text_numero.Text, e);
            }
            
        }
    }
}
