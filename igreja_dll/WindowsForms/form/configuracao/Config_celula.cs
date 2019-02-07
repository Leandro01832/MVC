using business.classes;
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

namespace igreja2.form.configuracao
{
    public partial class Config_celula : Form
    {
        public Config_celula()
        {
            InitializeComponent();
        }

        private void Config_celula_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Celula cel = new Celula();
            DataTable dtable = cel.bd.listar("select * from celula order by id_celula asc", false, false, false, "");
            foreach (DataRow dtrow in dtable.Rows)
            {
                ArrayList lista = new ArrayList();
                lista.Add(dtrow);
                //exibe os registros no listbox
                listBox1.Items.Add(dtrow.ItemArray[0] + " - " + dtrow.ItemArray[1]);
            }
        }      

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string listbox = listBox1.Text;
            Regex reg = new Regex(@"(\d+)");
            string id = reg.Match(listbox).ToString();

            Celula cel = new Celula();
            List<Pessoa> pessoa = new List<Pessoa>();
            cel.Celulaid = int.Parse(id);
            pessoa = cel.preenchercelula(cel.Celulaid);

            numericUpDown1.Visible = true;
            button1.Visible = true;

            label1.Text = "O numero de pessoas que tem na celula é: " + pessoa.Count.ToString() +
                "\n O numero de pessoas que podem estar na celula é: " + cel.Maximo_pessoa.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string listbox = listBox1.Text;
            Regex reg = new Regex(@"(\d+)");
            string id = reg.Match(listbox).ToString();

            Celula cel = new Celula();
            List<Pessoa> pessoa = new List<Pessoa>();
            cel.Celulaid = int.Parse(id);
            pessoa = cel.preenchercelula(cel.Celulaid);

            if (numericUpDown1.Value < pessoa.Count)
            {
                MessageBox.Show("O numero não pode ser menor que o numero de pessoas na celula");
            }
            else
            {
                cel.bd.montar_sql("update celula set max_pessoa='" + numericUpDown1.Value.ToString() + "' where id_celula='" + id + "'", null, null);
            }           

           
        }
    }
}
