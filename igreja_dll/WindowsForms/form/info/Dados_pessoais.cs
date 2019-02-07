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
    public partial class Dados_pessoais : Form
    {
        public Dados_pessoais(Membro mem)
        {
            InitializeComponent();
            text_nome.Text = mem.Nome;
            text_rg.Text = mem.Rg;
            text_cpf.Text = mem.Cpf;
            textemail.Text = mem.Email;
            listBox_status.Text = mem.Status;
            listestado_civil.Text = mem.Estado_civil;
            text_data_nascimento.Text = mem.Data_nascimento.ToString();
            text_ano_batismo.Text = mem.Data_batismo.ToString();
            radio_falescimento.Checked = mem.Falescimento;
            radio_desligamento.Checked = mem.Desligamento;
        }

        public Dados_pessoais(Visitante visi)
        {
            InitializeComponent();
            text_nome.Text = visi.Nome;
            text_rg.Text = visi.Rg;
            text_cpf.Text = visi.Cpf;
            textemail.Text = visi.Email;
            listBox_status.Text = visi.Status;
            listestado_civil.Text = visi.Estado_civil;
            text_data_nascimento.Text = visi.Data_nascimento.ToString();            
            radio_falescimento.Checked = visi.Falescimento;            
        }

        public Dados_pessoais(Crianca cri)
        {
            InitializeComponent();
            text_nome.Text = cri.Nome;
            text_rg.Text = cri.Rg;
            text_cpf.Text = cri.Cpf;
            textemail.Text = cri.Email;
            listBox_status.Text = cri.Status;
            listestado_civil.Text = cri.Estado_civil;
            text_data_nascimento.Text = cri.Data_nascimento.ToString();
            radio_falescimento.Checked = cri.Falescimento;
        }

        public Dados_pessoais(Pessoa p)
        {
            InitializeComponent();
            text_nome.Text = p.Nome;
            text_rg.Text = p.Rg;
            text_cpf.Text = p.Cpf;
            textemail.Text = p.Email;
            listBox_status.Text = p.Status;
            listestado_civil.Text = p.Estado_civil;
            text_data_nascimento.Text = p.Data_nascimento.ToString();            
            radio_falescimento.Checked = p.Falescimento;            
        }

        private void Dados_pessoais_Load(object sender, EventArgs e)
        {

        }

        private void text_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
