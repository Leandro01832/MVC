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
    public partial class Form_ministerio : Form
    {
        public Form_ministerio()
        {
            InitializeComponent();
        }

        Ministerio minis = new Ministerio();
        Cronologia_Ministerio crono = new Cronologia_Ministerio();

        private void button1_Click(object sender, EventArgs e)
        {
            Ministerio minis = new Ministerio();
            minis.Lider = text_lider.Text;
            minis.Nome = text_nome.Text;
            minis.Proprosito = text_proposito.Text;
            minis.salvar();

            listBox1.Enabled = true;
            listBox2.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            dateTimePicker1.Enabled = true;
            maskedTextBox1.Enabled = true;
            maskedTextBox2.Enabled = true;
            text_local_reuniao.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label8.Enabled = true;
        }

        private void Form_ministerio_Load(object sender, EventArgs e)
        {
            Pessoa pes = new Pessoa();
            pes.bd.montar_relatorio(pes.recuperar(), true, true, listBox1);

            if(minis.Nome == null || minis.Lider == null || minis.Proprosito == null)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }

            if (crono.Local_reuniao == null)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void text_proposito_TextChanged(object sender, EventArgs e)
        {
            minis.Proprosito = text_proposito.Text;
            Form_ministerio_Load(text_proposito.Text, e);
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            int iCont;

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
            Cronologia_Ministerio crono = new Cronologia_Ministerio();
            crono.Data_reuniao = Convert.ToDateTime(dateTimePicker1.Text);
            crono.Horario_inicio = Convert.ToDateTime(maskedTextBox1.Text);
            crono.Horario_fim = Convert.ToDateTime(maskedTextBox2.Text);
            crono.Local_reuniao = text_local_reuniao.Text;
            crono.salvar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ministerio minis = new Ministerio();
            List<string> nomes = new List<string>();
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                Pessoa pes = new Pessoa();

                nomes.Add(listBox2.Items[i].ToString());

                MessageBox.Show(nomes[i] + " foi adicionado ao ministerio: " + text_nome.Text);

                string comando = "select * from pessoa where pes_nome='#nome'";

                comando = comando.Replace("#nome", nomes[i]);

                pes.bd.buscar_dados(comando, null, null, null, null, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null, lbl_id_pessoa,
                null, null, null, null, null, null, null, null); 
                  
                string insert_padrao = "insert into ministerio_pessoa (pes_ministerio, minis_pessoa) " +
                " values (IDENT_CURRENT('ministerio'), '@pessoa')";

                string Insert = insert_padrao.Replace("@pessoa", lbl_id_pessoa.Text);

                pes.bd.montar_sql(Insert, null, null);
            }           
        }

        private void text_nome_TextChanged(object sender, EventArgs e)
        {
            minis.Nome = text_nome.Text;
            Form_ministerio_Load(text_nome.Text, e);
        }

        private void text_lider_TextChanged(object sender, EventArgs e)
        {
            minis.Lider = text_lider.Text;
            Form_ministerio_Load(text_lider.Text, e);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Informe um horario valido");
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Informe um horario valido");
        }

        private void text_local_reuniao_TextChanged(object sender, EventArgs e)
        {
            crono.Local_reuniao = text_local_reuniao.Text;
            Form_ministerio_Load(text_local_reuniao.Text, e);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            crono.Data_reuniao = dateTimePicker1.Value;
            Form_ministerio_Load(dateTimePicker1.Value, e);
        }
    }
}
