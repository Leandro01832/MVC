
using business.classes;
using database.banco;
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


namespace View.form.atualização
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
            
            
           DataTable dtable = cel.bd.listar("select * from celula order by id_celula asc", false,false, false, "");
            foreach (DataRow dtrow in dtable.Rows)
            {
                ArrayList lista = new ArrayList();
                lista.Add(dtrow);
                //exibe os registros no listbox
                listBox1.Items.Add(dtrow.ItemArray[0] + " - " + dtrow.ItemArray[1]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Celula cel = new Celula();
            DataTable dtable = cel.bd.listar(cel.recuperar(), false, true, false, "");
            foreach (DataRow dtrow in dtable.Rows)
            {
                ArrayList lista = new ArrayList();
                lista.Add(dtrow);
                //exibe os registros no listbox
                listBox2.Items.Add(dtrow.ItemArray[1]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string listbox = listBox1.Text;
            Regex reg = new Regex(@"(\d+)");
            string id = reg.Match(listbox).ToString();           

            Celula cel = new Celula();
            cel.Id = int.Parse(id);
            cel.bd.buscar_dados(cel.recuperar(), null, null, null, null, null, null, null,
               null, null, null, null, null, null, null, null, null, null, null, null, null,
               null, null, null, null, null, null, null, null, null, null, null, null,
               list_dia_semana, mask_horario, text_lider, text_lider_treinamento, text_bairro,
               text_rua, text_numero, null);
            
            DataTable dtable = cel.bd.listar(cel.recuperar(), false, false, true, id);
            foreach (DataRow dtrow in dtable.Rows)
            {
                ArrayList lista = new ArrayList();
                lista.Add(dtrow);
                //exibe os registros no listbox
                listBox2.Items.Add(dtrow.ItemArray[0] + " - " + dtrow.ItemArray[1] + " - " + dtrow.ItemArray[5]);
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
            cel.Id = int.Parse(id);
            cel.Lider = text_lider.Text;
            cel.Lider_treinamento = text_lider_treinamento.Text;
            cel.Dia_semana = list_dia_semana.Text;
            cel.Horario = Convert.ToDateTime(mask_horario.Text);
            cel.Cel_bairro = text_bairro.Text;
            cel.Cel_rua = text_rua.Text;
            cel.Cel_numero = int.Parse(text_numero.Text);

            cel.alterar();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
