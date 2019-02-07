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
    public partial class supervisor_treinamento : Form
    {
        Membro m = new Membro();
        Pessoa pessoa = new Pessoa();
        Visitante v = new Visitante();
        Crianca c = new Crianca();

        public supervisor_treinamento(Membro mem)
        {
            InitializeComponent();
            m = mem;
        }

        public supervisor_treinamento(Visitante visi)
        {
            InitializeComponent();
            v = visi;
        }

        public supervisor_treinamento(Crianca cri)
        {
            InitializeComponent();
            c = cri;
        }

        public supervisor_treinamento(Pessoa p)
        {
            InitializeComponent();
            pessoa = p;
        }

        private void supervisor_treinamento_Load(object sender, EventArgs e)
        {
            if (m.Cargo_Supervisor_Treinamento == null && pessoa.Cargo_Supervisor_Treinamento == null
                && v.Cargo_Supervisor_Treinamento == null && c.Cargo_Supervisor_Treinamento == null)
            {
                label1.Text = "Esta pessoa não é um Supervisor em treinamento";
            }
            else
            {
                label1.Text = "Esta pessoa é um Supervisor em treinamento";
            }
        }
    }
}
