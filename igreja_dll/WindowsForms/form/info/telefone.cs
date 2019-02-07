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
    public partial class telefone : Form
    {
        public telefone(Membro mem)
        {
            InitializeComponent();
            text_telefone.Text = mem.Telefone.Fone;
            text_celular.Text = mem.Telefone.Celular;
            text_whatsapp.Text = mem.Telefone.Whatsapp;
        }

        public telefone(Visitante visi)
        {
            InitializeComponent();
            text_telefone.Text = visi.Telefone.Fone;
            text_celular.Text = visi.Telefone.Celular;
            text_whatsapp.Text = visi.Telefone.Whatsapp;
        }

        public telefone(Crianca cri)
        {
            InitializeComponent();
            text_telefone.Text = cri.Telefone.Fone;
            text_celular.Text = cri.Telefone.Celular;
            text_whatsapp.Text = cri.Telefone.Whatsapp;
        }

        public telefone(Pessoa p)
        {
            InitializeComponent();
            text_telefone.Text = p.Telefone.Fone;
            text_celular.Text = p.Telefone.Celular;
            text_whatsapp.Text = p.Telefone.Whatsapp;
        }

        private void text_telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_celular_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_whatsapp_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefone_Load(object sender, EventArgs e)
        {

        }
    }
}
