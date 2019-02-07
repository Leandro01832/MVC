using business.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsForms.form.info;

namespace igreja2.form.atualização
{
    public partial class dados_membro : Form
    {
        Pessoa pessoa = new Pessoa();

        public dados_membro()
        {
            InitializeComponent();

        }

        public dados_membro(Pessoa p)
        {
            InitializeComponent();
            pessoa = p;
        }

        Membro mem = new Membro();

        private void button2_Click(object sender, EventArgs e)
        {
            Membro_Aclamacao mem = new Membro_Aclamacao();
            //mem.Cpf = mask_verifica_cpf.Text;
            //if (text_nome.Text != "")
            //{
            //    mem.Nome = text_nome.Text;
            //}

            Atualizar_membro men = new Atualizar_membro(mem);
            men.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mem.Endereco = mem.recuperar_membro(23).Endereco;
            mem.Telefone = mem.recuperar_membro(23).Telefone;
        }

        private void text_nome_TextChanged(object sender, EventArgs e)
        {
            Pessoa pes = new Pessoa();
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            Pessoa pes = new Pessoa();
            // pes.foto(pictureBox1);
            // Visualizar_foto visu = new Visualizar_foto(pictureBox1);
            // visu.Show();
        }

        private void dados_membro_Load(object sender, EventArgs e)
        {
            
        }

        private void telefoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telefone tel;
            if (pessoa != null)
                tel = new telefone(pessoa);
            else
                tel = new telefone(mem);
            tel.MdiParent = MDIsingleton.InstanciaMDI();
            tel.Show();
        }

        private void endereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            endereco end;
            if (pessoa != null)
                end = new endereco(pessoa);
            else
                end = new endereco(mem);
            end.MdiParent = MDIsingleton.InstanciaMDI();
            end.Show();
        }

        private void dadosPessoaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dados_pessoais dad;
            if (pessoa != null)
            dad = new Dados_pessoais(pessoa);
            else
            dad = new Dados_pessoais(mem);
            dad.MdiParent = MDIsingleton.InstanciaMDI();
            dad.Show();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Pessoa> lista = new List<Pessoa>();
            var select = "select Nome, P.Id, Img from Pessoa as P inner join Membro as M on P.Id=M.Id WHERE P.Nome LIKE '" + textBox1.Text + "%'";
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
            dataGridView1.Height =550;
            var linhas = dataGridView1.RowCount;
            for (int i = 0; i < linhas; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                row.Height = 150;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           var valor = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            mem = mem.recuperar_membro(int.Parse(valor));            
            this.Text = "informações - " + mem.recuperar_membro(int.Parse(valor)).Nome;
        }

        private void chamadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chamada cham;
            if (pessoa != null)
                cham = new chamada(pessoa);
            else
                cham = new chamada(mem);
            cham.MdiParent = MDIsingleton.InstanciaMDI();
            cham.Show();
        }

        private void celulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            celula cel;
            if (pessoa.Celula != null)
            { cel = new celula(pessoa); }
            else
            {                
                cel = new celula(mem);
            }
            cel.MdiParent = MDIsingleton.InstanciaMDI();
            cel.Show();
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historico hist;
            if (pessoa != null)
                hist = new historico(pessoa);
            else
                hist = new historico(mem);
            hist.MdiParent = MDIsingleton.InstanciaMDI();
            hist.Show();
        }

        private void reuniõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reuniao reu;
            if (pessoa != null)
                reu = new reuniao(pessoa);
            else
                reu = new reuniao(mem);
            reu.MdiParent = MDIsingleton.InstanciaMDI();
            reu.Show();
        }

        private void ministériosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ministerio hist;
            if (pessoa != null)
                hist = new ministerio(pessoa);
            else
                hist = new ministerio(mem);
            hist.MdiParent = MDIsingleton.InstanciaMDI();
            hist.Show();
        }

        private void liderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void liderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lider lid;
            if (pessoa.Cargo_Lider != null)
            { lid = new lider(pessoa); }
            else
            { lid = new lider(mem); }
            lid.MdiParent = MDIsingleton.InstanciaMDI();
            lid.Show();
        }

        private void liderEmTreinamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lider_treinamento lid;
            if (pessoa.Cargo_Lider_Treinamento != null)
            { lid = new lider_treinamento(pessoa); }
            else
            { lid = new lider_treinamento(mem); }
            lid.MdiParent = MDIsingleton.InstanciaMDI();
            lid.Show();
        }

        private void supervisorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            supervisor sup;
            if (pessoa.Cargo_Supervisor != null)
            { sup = new supervisor(pessoa); }
            else
            { sup = new supervisor(mem); }
            sup.MdiParent = MDIsingleton.InstanciaMDI();
            sup.Show();
        }

        private void supervisorEmTreinamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            supervisor_treinamento sup;
            if (pessoa.Cargo_Supervisor_Treinamento != null)
            { sup = new supervisor_treinamento(pessoa); }
            else
            { sup = new supervisor_treinamento(mem); }
            sup.MdiParent = MDIsingleton.InstanciaMDI();
            sup.Show();
        }

        private void fotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foto fot;
            if (pessoa.Img != null)
            { fot = new foto(pessoa); }
            else
            { fot = new foto(mem); }
            fot.MdiParent = MDIsingleton.InstanciaMDI();
            fot.Show();
        }
    }
}
