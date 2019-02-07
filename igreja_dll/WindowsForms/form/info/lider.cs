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
    public partial class lider : Form
    {
        Membro m = new Membro();
        Pessoa pessoa = new Pessoa();
        Visitante v = new Visitante();
        Crianca c = new Crianca();

        public lider(Membro mem)
        {
            InitializeComponent();
            m = mem;
        }

        public lider(Visitante visi)
        {
            InitializeComponent();
            v = visi;
        }

        public lider(Crianca cri)
        {
            InitializeComponent();
            c = cri;
        }

        public lider(Pessoa p)
        {
            InitializeComponent();
            pessoa = p;
        }

        private void lider_Load(object sender, EventArgs e)
        {
            if (m.Cargo_Lider == null && pessoa.Cargo_Lider == null
                && v.Cargo_Lider == null && c.Cargo_Lider == null)
            {
                label1.Text = "Esta pessoa não é um lider";
            }
            else 
            {
                label1.Text = "Esta pessoa é um lider";
            }
        }
    }
}
