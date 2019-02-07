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
    public partial class reuniao : Form
    {
        Pessoa pessoa = new Pessoa();
        Membro m = new Membro();
        Visitante v = new Visitante();
        Crianca c = new Crianca();

        public reuniao(Membro mem)
        {
            InitializeComponent();
            m = mem;
        }

        public reuniao(Visitante visi)
        {
            InitializeComponent();
            v = visi;
        }

        public reuniao(Crianca cri)
        {
            InitializeComponent();
            c = cri;
        }

        public reuniao(Pessoa p)
        {
            InitializeComponent();
            pessoa = p;
        }

        private void reuniao_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "Data da reunião";
            dataGridView1.Columns[1].HeaderText = "Horário de início";
            dataGridView1.Columns[2].HeaderText = "Horário final";
            dataGridView1.Columns[3].HeaderText = "Local da reunião";

            if (pessoa.Reuniao != null)
            {
                for (int i = 0; i < pessoa.Reuniao.Count; i++)
                {

                    dataGridView1.Rows[i].Cells[0].Value = pessoa.Reuniao[i].Data_reuniao;
                    dataGridView1.Rows[i].Cells[1].Value = pessoa.Reuniao[i].Horario_inicio;
                    dataGridView1.Rows[i].Cells[2].Value = pessoa.Reuniao[i].Horario_fim;
                    dataGridView1.Rows[i].Cells[3].Value = pessoa.Reuniao[i].Local_reuniao;
                }
            }
            else if(m.Reuniao != null)
            {
                for (int i = 0; i < m.Historico.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = m.Reuniao[i].Data_reuniao;
                    dataGridView1.Rows[i].Cells[1].Value = m.Reuniao[i].Horario_inicio;
                    dataGridView1.Rows[i].Cells[2].Value = m.Reuniao[i].Horario_fim;
                    dataGridView1.Rows[i].Cells[3].Value = m.Reuniao[i].Local_reuniao;
                }
            }

            else if(v.Reuniao != null)
            {
                for (int i = 0; i < v.Historico.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = v.Reuniao[i].Data_reuniao;
                    dataGridView1.Rows[i].Cells[1].Value = v.Reuniao[i].Horario_inicio;
                    dataGridView1.Rows[i].Cells[2].Value = v.Reuniao[i].Horario_fim;
                    dataGridView1.Rows[i].Cells[3].Value = v.Reuniao[i].Local_reuniao;
                }
            }
            else
            {
                for (int i = 0; i < c.Historico.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = c.Reuniao[i].Data_reuniao;
                    dataGridView1.Rows[i].Cells[1].Value = c.Reuniao[i].Horario_inicio;
                    dataGridView1.Rows[i].Cells[2].Value = c.Reuniao[i].Horario_fim;
                    dataGridView1.Rows[i].Cells[3].Value = c.Reuniao[i].Local_reuniao;
                }
            }
        }
    }
}
