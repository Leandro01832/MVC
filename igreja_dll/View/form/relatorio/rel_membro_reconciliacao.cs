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

namespace View.form.relatorio
{
    public partial class rel_membro_reconciliacao : Form
    {
        public rel_membro_reconciliacao()
        {
            InitializeComponent();
        }

        private void rel_membro_reconciliacao_Load(object sender, EventArgs e)
        {
            Membro_Reconciliacao memb = new Membro_Reconciliacao();
            string comando = memb.recuperar();

            bindingSource_membro_reconciliacao.DataSource = 
                memb.bd.montar_relatorio(comando, false, false, null);

            this.reportViewer1.RefreshReport();
        }
    }
}
