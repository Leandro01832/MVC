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
    public partial class rel_visitante : Form
    {
        public rel_visitante()
        {
            InitializeComponent();
        }

        private void rel_visitante_Load(object sender, EventArgs e)
        {

            Visitante visi = new Visitante();
            string comando = visi.recuperar();

            bindingSource_visitante.DataSource =
                visi.bd.montar_relatorio(comando, false, false, null);

            this.reportViewer1.RefreshReport();
        }
    }
}
