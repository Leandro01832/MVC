using View.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using business.classes;

namespace View.form
{
    public partial class visualizacao : Form
    {
        public visualizacao()
        {
            InitializeComponent();
        }

        Membro_Aclamacao memb_acla = new Membro_Aclamacao();
        Membro mem = new Membro();
        Membro_Reconciliacao memb_reco = new Membro_Reconciliacao();
        Membro_Transferencia memb_trans = new Membro_Transferencia();
        Visitante visi = new Visitante();
        Crianca cri = new Crianca();
        Pessoa pes = new Pessoa();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "pessoas")
            {                
                string comando = pes.recuperar();
                pes.bd.visualizar(comando, dgdados, check_documento, check_telefones, check_endereço, check_faltas, pessoa_numericUpDown1,
                    pessoa_numericUpDown2, pessoa_radioButton_masculino, pessoa_radioButton_feminino, pessoa_listestado_civil, pessoa_listBox_status,
                    checkBox1, checkBox2);
                
            }

            if (comboBox1.Text == "membros por aclamação")
            {                
                string comando = memb_acla.recuperar();
                memb_acla.bd.visualizar(comando, dgdados, check_documento, check_telefones, check_endereço, check_faltas, pessoa_numericUpDown1,
                    pessoa_numericUpDown2, pessoa_radioButton_masculino, pessoa_radioButton_feminino, pessoa_listestado_civil, pessoa_listBox_status,
                    checkBox1, checkBox2);                
            }

            if (comboBox1.Text == "membros por reconciliação")
            {
                string comando = memb_reco.recuperar();
                memb_reco.bd.visualizar(comando, dgdados, check_documento, check_telefones, check_endereço, check_faltas, pessoa_numericUpDown1,
                    pessoa_numericUpDown2, pessoa_radioButton_masculino, pessoa_radioButton_feminino, pessoa_listestado_civil, pessoa_listBox_status,
                    checkBox1, checkBox2);
            }

            if (comboBox1.Text == "membros por transferência")
            {
                string comando = memb_trans.recuperar();
                memb_trans.bd.visualizar(comando, dgdados, check_documento, check_telefones, check_endereço, check_faltas, pessoa_numericUpDown1,
                    pessoa_numericUpDown2, pessoa_radioButton_masculino, pessoa_radioButton_feminino, pessoa_listestado_civil, pessoa_listBox_status,
                    checkBox1, checkBox2);
            }

            if (comboBox1.Text == "membros")
            {
                string comando = memb_trans.recuperar();
                memb_trans.bd.visualizar(comando, dgdados, check_documento, check_telefones, check_endereço, check_faltas, pessoa_numericUpDown1,
                    pessoa_numericUpDown2, pessoa_radioButton_masculino, pessoa_radioButton_feminino, pessoa_listestado_civil, pessoa_listBox_status,
                    checkBox1, checkBox2);
            }

            if (comboBox1.Text == "visitantes")
            {
                string comando = visi.recuperar();
                visi.bd.visualizar(comando, dgdados, check_documento, check_telefones, check_endereço, check_faltas, pessoa_numericUpDown1,
                    pessoa_numericUpDown2, pessoa_radioButton_masculino, pessoa_radioButton_feminino, pessoa_listestado_civil, pessoa_listBox_status,
                    checkBox1, checkBox2);
            }

            if (comboBox1.Text == "crianças")
            {
                string comando = cri.recuperar();
                cri.bd.visualizar(comando, dgdados, check_documento, check_telefones, check_endereço, check_faltas, pessoa_numericUpDown1,
                    pessoa_numericUpDown2, pessoa_radioButton_masculino, pessoa_radioButton_feminino, pessoa_listestado_civil, pessoa_listBox_status,
                    checkBox1, checkBox2);
            }
        }

        private void visualizacao_Load(object sender, EventArgs e)
        {
            check_documento.Checked = true;
            comboBox1.Text = "pessoas";
            Pessoa pes = new Pessoa();
            string comando = pes.recuperar();
            pes.bd.visualizar(comando, dgdados, check_documento, check_telefones, check_endereço, check_faltas, pessoa_numericUpDown1,
                pessoa_numericUpDown2, pessoa_radioButton_masculino, pessoa_radioButton_feminino, pessoa_listestado_civil, pessoa_listBox_status,
                checkBox1, checkBox2);
            dgdados.Columns[0].HeaderText = "Nome";
            dgdados.Columns[1].HeaderText = "RG";
            dgdados.Columns[2].HeaderText = "CPF";
            dgdados.Columns[3].HeaderText = "Data de nascimento";
        }

        private void check_documento_CheckedChanged(object sender, EventArgs e)
        {
            check_telefones.Checked = false;
            check_endereço.Checked = false;
            check_faltas.Checked = false;
            check_aclamacao.Checked = false;
        }

        private void check_telefones_CheckedChanged(object sender, EventArgs e)
        {
            check_documento.Checked = false;
            check_endereço.Checked = false;
            check_faltas.Checked = false;
            check_aclamacao.Checked = false;
        }

        private void check_endereço_CheckedChanged(object sender, EventArgs e)
        {
            check_documento.Checked = false;
            check_telefones.Checked = false;
            check_faltas.Checked = false;
            check_aclamacao.Checked = false;
        }

        private void check_faltas_CheckedChanged(object sender, EventArgs e)
        {
            check_documento.Checked = false;
            check_telefones.Checked = false;
            check_endereço.Checked = false;
            check_aclamacao.Checked = false;
        }

        private void check_aclamacao_CheckedChanged(object sender, EventArgs e)
        {
            check_documento.Checked = false;
            check_telefones.Checked = false;
            check_endereço.Checked = false;
            check_faltas.Checked = false;
        }

        private void pessoa_numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(pessoa_numericUpDown1, e);
        }

        private void pessoa_radioButton_masculino_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(pessoa_radioButton_masculino, e);
        }

        private void pessoa_radioButton_feminino_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(pessoa_radioButton_feminino, e);
        }

        private void pessoa_listestado_civil_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(pessoa_listestado_civil, e);
        }

        private void pessoa_listBox_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(pessoa_listBox_status, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(checkBox2, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(checkBox1, e);
        }

        private void pessoa_numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(pessoa_numericUpDown2, e);
        }
    }
}
