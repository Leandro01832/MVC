using business.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.form.info;

namespace igreja2.form.atualização
{
    public partial class dados_visitante : Form
    {
        Pessoa pessoa = new Pessoa();

        public dados_visitante()
        {
            InitializeComponent();            
        }

        public dados_visitante(Pessoa p)
        {
            InitializeComponent();
            pessoa = p;
        }

        Visitante visi = new Visitante();

        private void Atualizacao_visitante_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var valor = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            visi = visi.recuperar_visitante(int.Parse(valor));
            this.Text = "informações - " + visi.recuperar_visitante(int.Parse(valor)).Nome;
        }

        private void text_nome_TextChanged(object sender, EventArgs e)
        {
            List<Pessoa> lista = new List<Pessoa>();
            var select = "select Nome, P.Id, Img from Pessoa as P inner join Visitante as V on P.Id=V.Id WHERE P.Nome LIKE '" + text_nome.Text + "%'";
            Pessoa p = new Pessoa();
            SqlCommand comando = new SqlCommand(select, p.bd.obterconexao());

            SqlDataAdapter objadp = new SqlDataAdapter(comando);
            DataTable dtlista = new DataTable();

            objadp.Fill(dtlista);
            this.dataGridView1.DataSource = dtlista;

            dataGridView1.Columns[0].HeaderText = "Nome";
            dataGridView1.Columns[1].HeaderText = "ID";
            dataGridView1.Columns[2].HeaderText = "Foto";
            dataGridView1.Columns[2].Width = 350;
            dataGridView1.Columns[2].FillWeight = 300;
            dataGridView1.Height = 550;
            var linhas = dataGridView1.RowCount;
            for (int i = 0; i < linhas; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                row.Height = 150;
            }
        }

        private void chamadaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            chamada cham;
            if (pessoa != null)
                cham = new chamada(pessoa);
            else
                cham = new chamada(visi);
            cham.MdiParent = MDIsingleton.InstanciaMDI();
            cham.Show();
        }

        private void celulaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            celula cel;
            if (pessoa.Celula != null)
            { cel = new celula(pessoa); }
            else
            {
                cel = new celula(visi);
            }
            cel.MdiParent = MDIsingleton.InstanciaMDI();
            cel.Show();
        }

        private void históricoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            historico hist;
            if (pessoa != null)
                hist = new historico(pessoa);
            else
                hist = new historico(visi);
            hist.MdiParent = MDIsingleton.InstanciaMDI();
            hist.Show();
        }

        private void reuniõesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            reuniao hist;
            if (pessoa != null)
                hist = new reuniao(pessoa);
            else
                hist = new reuniao(visi);
            hist.MdiParent = MDIsingleton.InstanciaMDI();
            hist.Show();
        }

        private void ministériosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ministerio hist;
            if (pessoa != null)
                hist = new ministerio(pessoa);
            else
                hist = new ministerio(visi);
            hist.MdiParent = MDIsingleton.InstanciaMDI();
            hist.Show();
        }

        private void liderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void liderToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            lider lid;
            if (pessoa.Cargo_Lider != null)
            { lid = new lider(pessoa); }
            else
            { lid = new lider(visi); }
            lid.MdiParent = MDIsingleton.InstanciaMDI();
            lid.Show();
        }

        private void liderEmTreinamentoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            lider_treinamento lid;
            if (pessoa.Cargo_Lider_Treinamento != null)
            { lid = new lider_treinamento(pessoa); }
            else
            { lid = new lider_treinamento(visi); }
            lid.MdiParent = MDIsingleton.InstanciaMDI();
            lid.Show();
        }

        private void supervisorToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            supervisor sup;
            if (pessoa.Cargo_Supervisor != null)
            { sup = new supervisor(pessoa); }
            else
            { sup = new supervisor(visi); }
            sup.MdiParent = MDIsingleton.InstanciaMDI();
            sup.Show();
        }

        private void supervisorEmTreinamentoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            supervisor_treinamento sup;
            if (pessoa.Cargo_Supervisor_Treinamento != null)
            { sup = new supervisor_treinamento(pessoa); }
            else
            { sup = new supervisor_treinamento(visi); }
            sup.MdiParent = MDIsingleton.InstanciaMDI();
            sup.Show();
        }

        private void endereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            endereco end;
            if (pessoa.Endereco != null)
            { end = new endereco(pessoa); }
            else
            { end = new endereco(visi); }
            end.MdiParent = MDIsingleton.InstanciaMDI();
            end.Show();
        }

        private void telefoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telefone tel;
            if (pessoa.Endereco != null)
            { tel = new telefone(pessoa); }
            else
            { tel = new telefone(visi); }
            tel.MdiParent = MDIsingleton.InstanciaMDI();
            tel.Show();
        }

        private void dadosPessoaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dados_pessoais dp;
            if (pessoa.Endereco != null)
            { dp = new Dados_pessoais(pessoa); }
            else
            { dp = new Dados_pessoais(visi); }
            dp.MdiParent = MDIsingleton.InstanciaMDI();
            dp.Show();
        }

        private void fotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foto fot;
            if (pessoa.Endereco != null)
            { fot = new foto(pessoa); }
            else
            { fot = new foto(visi); }
            fot.MdiParent = MDIsingleton.InstanciaMDI();
            fot.Show();
        }
        
        


             
    }
}
