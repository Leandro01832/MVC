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

namespace igreja2.form.atualização
{
    public partial class atualizacao_celula : Form
    {
        public atualizacao_celula()
        {
            InitializeComponent();
        }

        private void atualizacao_celula_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Celula cel = new Celula();
            IEnumerable<Celula> celulas = cel.recuperartodos();
           DataTable dtable = cel.bd.listar("select * from celula order by id_celula asc", false,false, false, "");
            foreach (var c in celulas)
            {
                ArrayList lista = new ArrayList();
                lista.Add(c);
                //exibe os registros no listbox
                listBox1.Items.Add(c.Cel_nome + " - " + c.Celulaid);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Pessoa p = new Pessoa();
            IEnumerable<Pessoa> lista = p.recuperartodos();
            foreach (var pes in lista)
            {
                ArrayList l= new ArrayList();
                l.Add(pes);
                //exibe os registros no listbox
                listBox2.Items.Add(pes.Nome);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string listbox = listBox1.Text;
            Regex reg = new Regex(@"(\d+)");
            string id = reg.Match(listbox).ToString();           

            Celula cel = new Celula();
            cel.Celulaid = int.Parse(id);
            cel.Pessoas = cel.preenchercelula(cel.Celulaid);

            
            foreach (var c in cel.Pessoas)
            {
                ArrayList lista = new ArrayList();
                lista.Add(c);
                //exibe os registros no listbox
                listBox2.Items.Add(c.Nome + " - " + c.Id + " - " + c.Falta);
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string listbox = listBox1.Text;
            Regex reg = new Regex(@"(\d+)");
            string id = reg.Match(listbox).ToString();

            Celula cel = new Celula();
            cel.Celulaid = int.Parse(id);
            cel.Lider_ = int.Parse(text_lider.Text);
            cel.Lidertreinamento_ = int.Parse(text_lider_treinamento.Text);
            cel.Dia_semana = list_dia_semana.Text;
            cel.Horario = TimeSpan.Parse(mask_horario.Text);
            cel.Endereco_Celula.Cel_bairro = text_bairro.Text;
            cel.Endereco_Celula.Cel_rua = text_rua.Text;
            cel.Endereco_Celula.Cel_numero = int.Parse(text_numero.Text);

            cel.alterar(cel.Celulaid);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
