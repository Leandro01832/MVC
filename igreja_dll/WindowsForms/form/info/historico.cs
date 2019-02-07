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
    public partial class historico : Form
    {
        Membro m = new Membro();
        Pessoa pessoa = new Pessoa();
        Visitante v = new Visitante();
        Crianca c = new Crianca();

        public historico(Membro mem)
        {
            InitializeComponent();
            m = mem;
        }

        public historico(Visitante visi)
        {
            InitializeComponent();
            v = visi;
        }

        public historico(Crianca cri)
        {
            InitializeComponent();
            c = cri;
        }

        public historico(Pessoa p)
        {
            InitializeComponent();
            pessoa = p;
        }

        private void historico_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "Data de inicio";
            dataGridView1.Columns[1].HeaderText = "Data final";
            dataGridView1.Columns[2].HeaderText = "Numero da chamada";
            dataGridView1.Columns[3].HeaderText = "Faltas";

            if (pessoa.Historico != null)
            {
                for (int i = 0; i < pessoa.Historico.Count; i++)
                {

                    dataGridView1.Rows[i].Cells[0].Value = pessoa.Historico[i].Data_inicio;
                    dataGridView1.Rows[i].Cells[1].Value = pessoa.Historico[i].Data_inicio.AddDays(60);
                    dataGridView1.Rows[i].Cells[2].Value = pessoa.Chamada.Numero_chamada;
                    dataGridView1.Rows[i].Cells[3].Value = pessoa.Historico[i].Falta;
                }
            }
            else if(m.Historico != null)
            {
                for (int i = 0; i < m.Historico.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = m.Historico[i].Data_inicio;
                    dataGridView1.Rows[i].Cells[1].Value = m.Historico[i].Data_inicio.AddDays(60);
                    dataGridView1.Rows[i].Cells[2].Value = m.Chamada.Numero_chamada;
                    dataGridView1.Rows[i].Cells[3].Value = m.Historico[i].Falta;
                }
            }

            else if(v.Historico != null)
            {                
              for (int i = 0; i < v.Historico.Count; i++)
              {
                  dataGridView1.Rows[i].Cells[0].Value = v.Historico[i].Data_inicio;
                  dataGridView1.Rows[i].Cells[1].Value = v.Historico[i].Data_inicio.AddDays(60);
                  dataGridView1.Rows[i].Cells[2].Value = v.Chamada.Numero_chamada;
                  dataGridView1.Rows[i].Cells[3].Value = v.Historico[i].Falta;
              }                
            }
            else
            {
                for (int i = 0; i < c.Historico.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = c.Historico[i].Data_inicio;
                    dataGridView1.Rows[i].Cells[1].Value = c.Historico[i].Data_inicio.AddDays(60);
                    dataGridView1.Rows[i].Cells[2].Value = c.Chamada.Numero_chamada;
                    dataGridView1.Rows[i].Cells[3].Value = c.Historico[i].Falta;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
