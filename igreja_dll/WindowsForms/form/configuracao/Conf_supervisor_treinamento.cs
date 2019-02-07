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
    public partial class Conf_supervisor_treinamento : Form
    {
        public Conf_supervisor_treinamento()
        {
            InitializeComponent();
        }

        private void Conf_supervisor_treinamento_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Cargo_Supervisor_Treinamento sup = new Cargo_Supervisor_Treinamento();
            DataTable dtable = sup.bd.listar("select * from supervisor_treinamento inner join pessoa on pes_id=sup_treinamento_pessoa order by id_sup_treinamento asc", false, false, false, "");
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

            Cargo_Supervisor_Treinamento sup = new Cargo_Supervisor_Treinamento();
            List<Celula> celula = new List<Celula>();
            sup.Supervisortreinamentoid = int.Parse(id);
            celula = sup.preenchersupervisor_treinamento();

            numericUpDown1.Visible = true;
            button1.Visible = true;

            label1.Text = "O numero de celulas do supervisor em treinamento é: " + celula.Count.ToString() +
                "\n O numero de celulas que o supervisor em treinamento pode ter é: " + sup.buscarmaximo().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string listbox = listBox1.Text;
            Regex reg = new Regex(@"(\d+)");
            string id = reg.Match(listbox).ToString();

            Cargo_Supervisor_Treinamento sup = new Cargo_Supervisor_Treinamento();
            List<Celula> pessoa = new List<Celula>();
            sup.Supervisortreinamentoid = int.Parse(id);
            pessoa = sup.preenchersupervisor_treinamento();

            if (numericUpDown1.Value < pessoa.Count)
            {
                MessageBox.Show("O numero não pode ser menor que o numero de celulas do supervisor em treinamento");
            }
            else
            {
                sup.bd.montar_sql("update supervisor_treinamento set max_celula='" + numericUpDown1.Value.ToString() + "' where id_sup_treinamento='" + id + "'", null, null);
            }
        }
    }
}
