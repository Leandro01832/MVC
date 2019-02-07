using business.classes;
using igreja2;
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
    public partial class celula : Form
    {
        Membro membro = new Membro();
        Pessoa pessoa = new Pessoa();
        Visitante v = new Visitante();
        Crianca c = new Crianca();

        public celula(Membro mem)
        {
            InitializeComponent();
            Pessoa p = new Pessoa();
            text_nome_celula.Text = mem.Celula.Cel_nome;
            text_lider.Text = p.recuperar(mem.Celula.Lider_).Nome;
            text_lider_treinamento.Text = p.recuperar(mem.Celula.Lidertreinamento_).Nome;
            text_supervisor.Text = p.recuperar(mem.Celula.Supervisor_).Nome;
            text_supervisor_treinamento.Text = p.recuperar(mem.Celula.Supervisortreinamento_).Nome;
            text_horario.Text = p.Celula.Horario.ToString();
            text_dia_semana.Text = mem.Celula.Dia_semana;
            text_bairro.Text = mem.Celula.Endereco_Celula.Cel_bairro;
            text_rua.Text = mem.Celula.Endereco_Celula.Cel_rua;
            text_numero.Text = mem.Celula.Endereco_Celula.Cel_numero.ToString();
            text_maximo.Text = mem.Celula.Maximo_pessoa.ToString();
            membro = mem;
        }

        public celula(Visitante visi)
        {
            InitializeComponent();
            Pessoa p = new Pessoa();
            text_nome_celula.Text = visi.Celula.Cel_nome;
            text_lider.Text = p.recuperar(visi.Celula.Lider_).Nome;
            text_lider_treinamento.Text = p.recuperar(visi.Celula.Lidertreinamento_).Nome;
            text_supervisor.Text = p.recuperar(visi.Celula.Supervisor_).Nome;
            text_supervisor_treinamento.Text = p.recuperar(visi.Celula.Supervisortreinamento_).Nome;
            text_horario.Text = p.Celula.Horario.ToString();
            text_dia_semana.Text = visi.Celula.Dia_semana;
            text_bairro.Text = visi.Celula.Endereco_Celula.Cel_bairro;
            text_rua.Text = visi.Celula.Endereco_Celula.Cel_rua;
            text_numero.Text = visi.Celula.Endereco_Celula.Cel_numero.ToString();
            text_maximo.Text = visi.Celula.Maximo_pessoa.ToString();
            v = visi;
        }

        public celula(Crianca cri)
        {
            InitializeComponent();
            Pessoa p = new Pessoa();
            text_nome_celula.Text = cri.Celula.Cel_nome;
            text_lider.Text = p.recuperar(cri.Celula.Lider_).Nome;
            text_lider_treinamento.Text = p.recuperar(cri.Celula.Lidertreinamento_).Nome;
            text_supervisor.Text = p.recuperar(cri.Celula.Supervisor_).Nome;
            text_supervisor_treinamento.Text = p.recuperar(cri.Celula.Supervisortreinamento_).Nome;
            text_horario.Text = p.Celula.Horario.ToString();
            text_dia_semana.Text = cri.Celula.Dia_semana;
            text_bairro.Text = cri.Celula.Endereco_Celula.Cel_bairro;
            text_rua.Text = cri.Celula.Endereco_Celula.Cel_rua;
            text_numero.Text = cri.Celula.Endereco_Celula.Cel_numero.ToString();
            text_maximo.Text = cri.Celula.Maximo_pessoa.ToString();
            c = cri;
        }

        public celula(Pessoa p)
        {
            InitializeComponent();
            text_nome_celula.Text = p.Celula.Cel_nome;
            text_lider.Text = p.recuperar(p.Celula.Lider_).Nome;
            text_lider_treinamento.Text = p.recuperar(p.Celula.Lidertreinamento_).Nome;
            text_supervisor.Text = p.recuperar(p.Celula.Supervisor_).Nome;
            text_supervisor_treinamento.Text = p.recuperar(p.Celula.Supervisortreinamento_).Nome;
            text_horario.Text = p.Celula.Horario.ToString();
            text_dia_semana.Text = p.Celula.Dia_semana;
            text_bairro.Text = p.Celula.Endereco_Celula.Cel_bairro;
            text_rua.Text = p.Celula.Endereco_Celula.Cel_rua;
            text_numero.Text = p.Celula.Endereco_Celula.Cel_numero.ToString();
            text_maximo.Text = p.Celula.Maximo_pessoa.ToString();
            pessoa = p;
        }

        private void text_nome_celula_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_lider_TextChanged(object sender, EventArgs e)
        {

        }

        private void celula_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pessoas_celula pessoas;
            if (membro.Celula != null)
            { pessoas = new pessoas_celula(membro); }
            else if (v.Celula != null)
            { pessoas = new pessoas_celula(v); }
            else if (pessoa.Celula != null)
            {
              pessoas = new pessoas_celula(pessoa);
            }
            else
            {
                pessoas = new pessoas_celula(c);
            }
            pessoas.MdiParent = MDIsingleton.InstanciaMDI();
            pessoas.Show();
            
        }
    }
}
