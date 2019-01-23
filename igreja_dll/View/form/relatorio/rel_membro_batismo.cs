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
    public partial class rel_membro_batismo : Form
    {
        public rel_membro_batismo()
        {
            InitializeComponent();
        }

        private void rel_membro_batismo_Load(object sender, EventArgs e)
        {
            Membro_Batismo memb = new Membro_Batismo();
            string comando = memb.recuperar();

            bindingSource_membro_batismo.DataSource = 
                memb.bd.montar_relatorio(comando, false, false, null);


            this.reportViewer1.RefreshReport();
        }
    }
}
