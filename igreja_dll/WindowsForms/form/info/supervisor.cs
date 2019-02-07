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
    public partial class supervisor : Form
    {
        Pessoa pessoa = new Pessoa();
        Membro m = new Membro();
        Visitante v = new Visitante();
        Crianca c = new Crianca();

        public supervisor(Membro mem)
        {
            InitializeComponent();
            m = mem;
        }

        public supervisor(Visitante visi)
        {
            InitializeComponent();
            v = visi;
        }

        public supervisor(Crianca cri)
        {
            InitializeComponent();
            c = cri;
        }

        public supervisor(Pessoa p)
        {
            InitializeComponent();
            pessoa = p;
        }

        private void supervisor_Load(object sender, EventArgs e)
        {
            if (m.Cargo_Supervisor == null && pessoa.Cargo_Supervisor == null
                && v.Cargo_Supervisor == null && c.Cargo_Supervisor == null)
            {
                label1.Text = "Esta pessoa não é um Supervisor";
            }
            else
            {
                label1.Text = "Esta pessoa é um Supervisor";
            }
        }
    }
}
