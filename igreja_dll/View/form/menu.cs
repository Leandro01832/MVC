
using View.form.cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.form.relatorio;
using View.classes;
using System.Data.SqlClient;
using database.banco;
using View.form.teste;
using business.classes;
using View.form.atualização;

namespace View.form
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        

        DateTime atual = DateTime.Now;
        DateTime mes_niver;
        string mesniver;
        
        private void menbroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastro frm = new frm_cadastro();
            frm.MdiParent = MDIsingleton.InstanciaMDI();
            frm.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            Chamada cha = new Chamada();
            cha.recuperar();

            Pessoa pes = new Pessoa();
            BDcomum bd = new BDcomum();
            SqlCommand verifica = new SqlCommand("select * from pessoa inner join telefone on pes_id=tel_pessoa " +
                " inner join endereco on pes_id=end_pessoa order by pes_data_nascimento asc", bd.obterconexao());
            try
            {
               SqlDataReader rd = verifica.ExecuteReader();
                int qtd = 0;                
                if (rd.HasRows == true)
                {                   
                    while (rd.Read())
                    {

                       // progressBar1.Value += 1;
                        label2.Text = Convert.ToString(rd["pes_nome"]);
                        label1.Text = Convert.ToString(rd["pes_data_nascimento"]);
                        label4.Text = Convert.ToString(rd["tel_telefone"]);
                        label5.Text = Convert.ToString(rd["tel_celular"]);
                        label6.Text = Convert.ToString(rd["tel_whatsapp"]);
                        label7.Text = Convert.ToString(rd["end_cep"]);
                        label8.Text = Convert.ToString(rd["end_rua"]);
                        label9.Text = Convert.ToString(rd["end_bairro"]);
                        label10.Text = Convert.ToString(rd["end_numero"]);
                        mesniver = label1.Text;
                        string mes = Convert.ToDateTime(mesniver).ToString( atual.Year + "-MM-dd");
                        DateTime niver = Convert.ToDateTime(mes);
                        //   idade = atual - Convert.ToDateTime(label1.Text);
                        //   idad = idade.Days / 365;
                        if (niver >= atual.AddDays(-1) && mes_niver < atual.AddDays(30))
                        {
                            MessageBox.Show(label2.Text + " vai fazer aniversario. Dê os parabêns para ele(a)."); /*+ " Data de aniversario: " + mesniver.ToString() + 
                                    " telefone fixo: " + label4.Text + " telefone celular: " + label5.Text + " whatsapp: " + label6.Text + " cep: " + label7.Text +
                                     " rua: " + label8.Text + " bairro: " + label9.Text + " nº: " + label10.Text);*/
                            qtd += 1;
                            progressBar1.Maximum = qtd;
                            progressBar1.Minimum = 0;
                        } 
                    }
                }
            }
            catch
            {
                MessageBox.Show("nimguem mais esta fazendo aniversário.");
            }
            finally
            {
                bd.obterconexao().Close();
                label1.Text = null;
                label2.Text = null;
                label4.Text = null;
                label5.Text = null;
                label6.Text = null;
                label7.Text = null;
                label8.Text = null;
                label9.Text = null;
                label10.Text = null;
                label11.Text = null;
                label12.Text = null;
                label13.Text = null;
                label14.Text = null;
                label15.Text = null;
                label16.Text = null;
                label17.Text = null;
                label18.Text = null;
                label19.Text = null;
                label20.Text = null;
                label21.Text = null;

            }

        }

        private void visitantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_visitante visi = new Form_visitante();
            visi.MdiParent = MDIsingleton.InstanciaMDI();
            visi.Show();
        }

        private void criançasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_crianca crianca = new Form_crianca();
            crianca.MdiParent = MDIsingleton.InstanciaMDI();
            crianca.Show();
        }

        private void celulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_celula cel = new Form_celula();
            cel.MdiParent = MDIsingleton.InstanciaMDI();
            cel.Show();
        }

        private void menbroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Atualizacao_membro mem = new Atualizacao_membro();
            mem.MdiParent = MDIsingleton.InstanciaMDI();
            mem.Show();
        }

        private void visitantesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Atualizacao_visitante visi = new Atualizacao_visitante();
            visi.MdiParent = MDIsingleton.InstanciaMDI();
            visi.Show();
        }

        private void criançasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atualizacao_crianca cri = new Atualizacao_crianca();
            cri.MdiParent = MDIsingleton.InstanciaMDI();
            cri.Show();
        }

        private void visõesDePessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visualizacao visu = new visualizacao();
            visu.MdiParent = MDIsingleton.InstanciaMDI();
            visu.Show();
        }

        private void relatorioDeMenbrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rel_membro rel = new rel_membro();
            rel.MdiParent = MDIsingleton.InstanciaMDI();
            rel.Show();
        }

        private void relatórioDeMenbrosPorTransferênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rel_membro_transferencia rel = new rel_membro_transferencia();
            rel.MdiParent = MDIsingleton.InstanciaMDI();
            rel.Show();
        }

        private void relatórioDeMenbrosPorAclamaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rel_membro_reconciliacao rel = new rel_membro_reconciliacao();
            rel.MdiParent = MDIsingleton.InstanciaMDI();
            rel.Show();
        }

        private void relatórioDeMenbrosPorAclamaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rel_membro_aclamacao rel = new rel_membro_aclamacao();
            rel.MdiParent = MDIsingleton.InstanciaMDI();
            rel.Show();
        }

        private void relatórioDeVisitantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rel_visitante visi = new rel_visitante();
            visi.MdiParent = MDIsingleton.InstanciaMDI();
            visi.Show();
        }

        private void relatórioDeMenbrosPorBatismoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rel_membro_batismo rel = new rel_membro_batismo();
            rel.MdiParent = MDIsingleton.InstanciaMDI();
            rel.Show();
        }

        private void celulaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            atualizacao_celula cel = new atualizacao_celula();
            cel.MdiParent = MDIsingleton.InstanciaMDI();
            cel.Show();
        }

        private void ministérioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ministerio minis = new Form_ministerio();
            minis.MdiParent = MDIsingleton.InstanciaMDI();
            minis.Show();
        }

        private void supervisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_supervisor sup = new Form_supervisor();
            sup.MdiParent = MDIsingleton.InstanciaMDI();
            sup.Show();
        }

        private void teste1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teste1 test = new teste1();
            test.Show();
        }

        private void históricoDeChamadasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ministérioToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void supervisorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
