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
    public partial class Config_supervisor : Form
    {
        public Config_supervisor()
        {
            InitializeComponent();
        }

       

        private void Config_supervisor_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Cargo_Supervisor sup = new Cargo_Supervisor();
            DataTable dtable = sup.bd.listar("select * from supervisor inner join pessoa on pes_id=super_pessoa order by id_supervisor asc", false, false, false, "");
            foreach (DataRow dtrow in dtable.Rows)
            {
                ArrayList lista = new ArrayList();
                lista.Add(dtrow);
                //exibe os registros no listbox
                listBox1.Items.Add(dtrow.ItemArray[0] + " - " + dtrow.ItemArray[4]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string listbox = listBox1.Text;
            Regex reg = new Regex(@"(\d+)");
            string id = reg.Match(listbox).ToString();

            Cargo_Supervisor sup = new Cargo_Supervisor();
            List<Celula> celula = new List<Celula>();
            sup.Supervisorid = int.Parse(id);
            celula = sup.preenchersupervisor(sup.Supervisorid);

            numericUpDown1.Visible = true;
            button1.Visible = true;

            label1.Text = "O numero de celulas do supervisor é: " + celula.Count.ToString() +
                "\n O numero de celulas que o supervisor pode ter é: " + sup.Maximo_celula.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string listbox = listBox1.Text;
            Regex reg = new Regex(@"(\d+)");
            string id = reg.Match(listbox).ToString();

            Cargo_Supervisor sup = new Cargo_Supervisor();
            List<Celula> pessoa = new List<Celula>();
            sup.Supervisorid = int.Parse(id);
            pessoa = sup.preenchersupervisor(sup.Supervisorid);

            if (numericUpDown1.Value < pessoa.Count)
            {
                MessageBox.Show("O numero não pode ser menor que o numero de celulas do supervisor");
            }
            else
            {
                sup.bd.montar_sql("update supervisor set maximo_celula='" + numericUpDown1.Value.ToString() + "' where id_supervisor='" + id + "'", null, null);
            }
        }
    }
}
