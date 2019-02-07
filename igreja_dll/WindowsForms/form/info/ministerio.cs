using business.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.form.info
{
    public partial class ministerio : Form
    {
        Pessoa pessoa = new Pessoa();
        Membro m = new Membro();
        Visitante v = new Visitante();
        Crianca c = new Crianca();

        public ministerio(Membro mem)
        {
            InitializeComponent();
            m = mem;
        }

        public ministerio(Visitante visi)
        {
            InitializeComponent();
            v = visi;
        }

        public ministerio(Crianca cri)
        {
            InitializeComponent();
            c = cri;
        }

        public ministerio(Pessoa p)
        {
            InitializeComponent();
            pessoa = p;
        }

        private void ministerio_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "Nome";
            dataGridView1.Columns[1].HeaderText = "Proposito";
            dataGridView1.Columns[2].HeaderText = "Máximo de pessoas";
            dataGridView1.Columns[3].HeaderText = "Lider";

            if (pessoa.Ministerios != null)
            {
                for (int i = 0; i < pessoa.Ministerios.Count; i++)
                {

                    dataGridView1.Rows[i].Cells[0].Value = pessoa.Ministerios[i].Nome;
                    dataGridView1.Rows[i].Cells[1].Value = pessoa.Ministerios[i].Proposito;
                    dataGridView1.Rows[i].Cells[2].Value = pessoa.Ministerios[i].Maximo_pessoa;
                    dataGridView1.Rows[i].Cells[3].Value = pessoa.Ministerios[i].recuperar(pessoa.Ministerios[i].lider_ministerio).Nome;
                }
            }
            else if (m.Ministerios != null)
            {
                for (int i = 0; i < m.Ministerios.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = m.Ministerios[i].Nome;
                    dataGridView1.Rows[i].Cells[1].Value = m.Ministerios[i].Proposito;
                    dataGridView1.Rows[i].Cells[2].Value = m.Ministerios[i].Maximo_pessoa;
                    dataGridView1.Rows[i].Cells[3].Value = m.Ministerios[i].recuperar(m.Ministerios[i].lider_ministerio).Nome;
                }
            }

            else if (v.Ministerios != null)
            {
                for (int i = 0; i < v.Ministerios.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = v.Ministerios[i].Nome;
                    dataGridView1.Rows[i].Cells[1].Value = v.Ministerios[i].Proposito;
                    dataGridView1.Rows[i].Cells[2].Value = v.Ministerios[i].Maximo_pessoa;
                    dataGridView1.Rows[i].Cells[3].Value = v.Ministerios[i].recuperar(v.Ministerios[i].lider_ministerio).Nome;
                }
            }
            else
            {
                for (int i = 0; i < c.Ministerios.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = c.Ministerios[i].Nome;
                    dataGridView1.Rows[i].Cells[1].Value = c.Ministerios[i].Proposito;
                    dataGridView1.Rows[i].Cells[2].Value = c.Ministerios[i].Maximo_pessoa;
                    dataGridView1.Rows[i].Cells[3].Value = c.Ministerios[i].recuperar(v.Ministerios[i].lider_ministerio).Nome;
                }
            }
        }
    }
}
