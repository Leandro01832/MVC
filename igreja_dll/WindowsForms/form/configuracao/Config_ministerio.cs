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
    public partial class Config_ministerio : Form
    {
        public Config_ministerio()
        {
            InitializeComponent();
        }

        private void Config_ministerio_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Ministerio minis = new Ministerio();
            DataTable dtable = minis.bd.listar("select * from ministerio order by id_ministerio asc", false, false, false, "");
            foreach (DataRow dtrow in dtable.Rows)
            {
                ArrayList lista = new ArrayList();
                lista.Add(dtrow);
                //exibe os registros no listbox
                listBox1.Items.Add(dtrow.ItemArray[0] + " - " + dtrow.ItemArray[2]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string listbox = listBox1.Text;
            Regex reg = new Regex(@"(\d+)");
            string id = reg.Match(listbox).ToString();

            Ministerio minis = new Ministerio();
            List<Pessoa> pessoa = new List<Pessoa>();
            minis.ministerioid = int.Parse(id);
            pessoa = minis.preencherministerio(minis.ministerioid);

            numericUpDown1.Visible = true;
            button1.Visible = true;

            label1.Text = "O numero de pessoas que tem no ministerio é: " + pessoa.Count.ToString() +
                "\n O numero de pessoas que podem estar no ministerio é: " + minis.Maximo_pessoa.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string listbox = listBox1.Text;
            Regex reg = new Regex(@"(\d+)");
            string id = reg.Match(listbox).ToString();

            Ministerio minis = new Ministerio();
            List<Pessoa> pessoa = new List<Pessoa>();
            minis.ministerioid = int.Parse(id);
            pessoa = minis.preencherministerio(minis.ministerioid);

            if (numericUpDown1.Value < pessoa.Count)
            {
                MessageBox.Show("O numero não pode ser menor que o numero de pessoas do ministerio");
            }
            else
            {
                minis.bd.montar_sql("update ministerio set max_pessoa='" + numericUpDown1.Value.ToString() + "' where id_ministerio='" + id + "'", null, null);
            }

        }
    }
}
