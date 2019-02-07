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
    public partial class lider_treinamento : Form
    {
        Pessoa pessoa = new Pessoa();
        Membro m = new Membro();
        Visitante v = new Visitante();
        Crianca c = new Crianca();

        public lider_treinamento(Membro mem)
        {
            InitializeComponent();
            m = mem;
        }

        public lider_treinamento(Visitante visi)
        {
            InitializeComponent();
            v = visi;
        }

        public lider_treinamento(Crianca cri)
        {
            InitializeComponent();
            c = cri;
        }

        public lider_treinamento(Pessoa p)
        {
            InitializeComponent();
            pessoa = p;
        }

        private void lider_treinamento_Load(object sender, EventArgs e)
        {
            if (m.Cargo_Lider_Treinamento == null && pessoa.Cargo_Lider_Treinamento == null
                && v.Cargo_Lider_Treinamento == null && c.Cargo_Lider_Treinamento == null)
            {
                label1.Text = "Esta pessoa não é um lider em treinamento";
            }
            else
            {
                label1.Text = "Esta pessoa é um lider em treinamento";
            }
        }
    }
}
