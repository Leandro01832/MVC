
using View.classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using business.classes;
using database.banco;

namespace View.form.cadastro
{
    public partial class Form_supervisor : Form
    {
        public Form_supervisor()
        {
            InitializeComponent();
        }

        Supervisor sup = new Supervisor();
        Supervisor_Treinamento sup_t = new Supervisor_Treinamento();

        private void button1_Click(object sender, EventArgs e)
        {
            Supervisor sup = new Supervisor();
            Supervisor_Treinamento sup_trei = new Supervisor_Treinamento();
            sup.Id = int.Parse(text_id_supervisor.Text);
            sup.salvar();
            sup_trei.Id = int.Parse(text_id_supervisor_treinamento.Text);
            sup_trei.salvar();

            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            listBox1.Enabled = true;
            listBox2.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            text_nome_celula.Enabled = true;
            dateTimePicker1.Enabled = true;

        }

        private void text_id_supervisor_TextChanged(object sender, EventArgs e)
        {
            if (text_id_supervisor.Text != "")
            {
                try
                {
                    sup.Id = int.Parse(text_id_supervisor.Text);
                    Form_supervisor_Load(text_id_supervisor.Text, e);
                    sup.Id = int.Parse(text_id_supervisor.Text);
                    Form_supervisor_Load(text_id_supervisor.Text, e);
                    Pessoa pes = new Pessoa();
                    lbl_id.Text = text_id_supervisor.Text;
                    pes.Id_pessoa = int.Parse(lbl_id.Text);
                    string comando = pes.recuperar();
                    pes.bd.buscar_dados(comando, text_nome_sup, null, null, null, null, null,
                        null, null, null, null, null, null, null, null, null, null, null, null, null,
                        null, null, null, null, null, null, null, null, null, null, null, null, null,
                        null, null, null, null, null, null, null, null);
                }

                catch (Exception ex)
                {
                    sup.Id = 0;
                    MessageBox.Show("Por favor digite um numero.");
                    Form_supervisor_Load(text_id_supervisor.Text, e);
                    text_id_supervisor.Text = "";
                }
                finally
                {

                }               
            }
            else
            {
                sup.Id = 0;
                Form_supervisor_Load(text_id_supervisor_treinamento.Text, e);
            }
        }

        private void text_id_supervisor_treinamento_TextChanged(object sender, EventArgs e)
        {
            if (text_id_supervisor_treinamento.Text != "")
            {
                try
                {
                    sup_t.Id = int.Parse(text_id_supervisor_treinamento.Text);
                    Form_supervisor_Load(text_id_supervisor_treinamento.Text, e);                
                    Pessoa pes = new Pessoa();
                    lbl_id.Text = text_id_supervisor_treinamento.Text;
                    pes.Id_pessoa = int.Parse(lbl_id.Text);
                    string comando = pes.recuperar();
                    pes.bd.buscar_dados(comando, text_nome_sup_treinamento, null, null, null, null, null,
                        null, null, null, null, null, null, null, null, null, null, null, null, null,
                        null, null, null, null, null, null, null, null, null, null, null, null, null,
                        null, null, null, null, null, null, null, null);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Por favor digite um numero.");
                    sup_t.Id = 0;
                    Form_supervisor_Load(text_id_supervisor_treinamento.Text, e);
                    text_id_supervisor_treinamento.Text = "";
                }
                finally
                {

                }
              
            }
            else
            {
                sup_t.Id = 0;
                Form_supervisor_Load(text_id_supervisor_treinamento.Text, e);              
            }

        }

        private void Form_supervisor_Load(object sender, EventArgs e)
        {
            BDcomum bd = new BDcomum();
            DataTable dtable = bd.listar("", true, false, false, "");
            foreach (DataRow dtrow in dtable.Rows)
            {
                ArrayList lista = new ArrayList();
                lista.Add(dtrow);
                //exibe os registros no listbox
                listBox1.Items.Add(dtrow.ItemArray[0] + " - " + dtrow.ItemArray[1]);
            }

            if (sup.Id == 0 || sup_t.Id == 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> nomes = new List<string>();
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                Pessoa pes = new Pessoa();

                nomes.Add(listBox2.Items[i].ToString());

                MessageBox.Show(nomes[i] + " vai ser supervisionada pelo(a): " + text_nome_sup.Text);

                string listbox = listBox2.Items[i].ToString();
                Regex reg = new Regex(@"(\d+)");
                string id = reg.Match(listbox).ToString();
                
                string insert_padrao = "insert into supervisor_celula (cel_supervisor, super_celula) " +
                " values (IDENT_CURRENT('supervisor'), '@celula') " +
                "insert into supervisor_treinamento_celula (cel_supervisor_treinamento, sup_trei_celula) " +
                " values (IDENT_CURRENT('supervisor_treinamento'), '@celula')";

                string Insert = insert_padrao.Replace("@celula", id);

                pes.bd.montar_sql(Insert, null, null);
            }
        }

        private void text_nome_sup_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void text_nome_celula_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_id_celula_TextChanged(object sender, EventArgs e)
        {
            if(text_id_celula.Text != "")
            {
                try
                {                    
                    Celula cel = new Celula();
                    cel.Id = int.Parse(text_id_celula.Text);
                    cel.bd.buscar_dados(cel.recuperar(), text_nome_celula, null, null, null,
                       null, null, null, null, null, null, null, null, null,
                       null, null, null, null, null, null, null, null, null,
                       null, null, null, null, null, null, null, null, null,
                       null, null, null, null, null, null, null, null, null);

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Por favor digite um numero.");
                }
                finally
                {

                }
            }
            else
            {

            }
        }
    }
}