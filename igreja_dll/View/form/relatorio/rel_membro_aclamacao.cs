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

namespace View.form.relatorio
{
    public partial class rel_membro_aclamacao : Form
    {
        public rel_membro_aclamacao()
        {
            InitializeComponent();
        }

        private void rel_membro_aclamacao_Load(object sender, EventArgs e)
        {

            Membro_Aclamacao memb = new Membro_Aclamacao();

            string comando = memb.recuperar();

            bindingSource_membro_aclamacao.DataSource = 
                memb.bd.montar_relatorio(comando, false, false, null);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
