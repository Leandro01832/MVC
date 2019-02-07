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
    public partial class chamada : Form
    {
        Pessoa pessoa = new Pessoa();

        public chamada(Membro mem)
        {
            InitializeComponent();
            text_data_inicio.Text = mem.Chamada.Data_inicio.ToString();
            text_numero_chamada.Text = mem.Chamada.Numero_chamada.ToString();
        }

        public chamada(Visitante visi)
        {
            InitializeComponent();
            text_data_inicio.Text = visi.Chamada.Data_inicio.ToString();
            text_numero_chamada.Text = visi.Chamada.Numero_chamada.ToString();
        }

        public chamada(Crianca cri)
        {
            InitializeComponent();
            text_data_inicio.Text = cri.Chamada.Data_inicio.ToString();
            text_numero_chamada.Text = cri.Chamada.Numero_chamada.ToString();
        }

        public chamada(Pessoa p)
        {
            InitializeComponent();
            text_data_inicio.Text = p.Chamada.Data_inicio.ToString();
            text_numero_chamada.Text = p.Chamada.Numero_chamada.ToString();
            pessoa = p;
        }

        private void text_data_inicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_numero_chamada_TextChanged(object sender, EventArgs e)
        {

        }

        private void chamada_Load(object sender, EventArgs e)
        {

        }
    }
}
