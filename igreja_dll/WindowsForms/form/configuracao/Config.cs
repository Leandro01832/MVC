using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace igreja2.form.configuracao
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void celulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config_celula conf = new Config_celula();
            conf.MdiParent = MDIsingleton.InstanciaMDI();
            conf.Show();
        }

        private void supervisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config_supervisor conf = new Config_supervisor();
            conf.MdiParent = MDIsingleton.InstanciaMDI();
            conf.Show();
        }

        private void supervisorEmTreinamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conf_supervisor_treinamento conf = new Conf_supervisor_treinamento();
            conf.MdiParent = MDIsingleton.InstanciaMDI();
            conf.Show();
        }

        private void ministerioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config_ministerio conf = new Config_ministerio();
            conf.MdiParent = MDIsingleton.InstanciaMDI();
            conf.Show();
        }

        private void siteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config_layout conf = new Config_layout();
            conf.MdiParent = MDIsingleton.InstanciaMDI();
            conf.Show();
        }
    }
}
