using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.form
{
    public partial class Visualizar_foto : Form
    {
        public Visualizar_foto(PictureBox foto)
        {
            InitializeComponent();
            pictureBox1.Image = foto.Image;
        }

        private void Visualizar_foto_Load(object sender, EventArgs e)
        {

        }
    }
}
