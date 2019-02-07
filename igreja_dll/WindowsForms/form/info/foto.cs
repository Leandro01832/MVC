using business.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.form.info
{
    public partial class foto : Form
    {
        public foto(Membro mem)
        {
            InitializeComponent();
            if (mem.Img == null)
            {
                if (pictureBox1 != null) { pictureBox1.Image = null; }
            }
            else
            {
                MemoryStream memory = new MemoryStream(mem.Img);
                if (pictureBox1 != null) { pictureBox1.Image = Image.FromStream(memory); }
            }
        }

        public foto(Visitante visi)
        {
            InitializeComponent();
            if (visi.Img == null)
            {
                if (pictureBox1 != null) { pictureBox1.Image = null; }
            }
            else
            {
                MemoryStream memory = new MemoryStream(visi.Img);
                if (pictureBox1 != null) { pictureBox1.Image = Image.FromStream(memory); }
            }
        }

        public foto(Crianca cri)
        {
            InitializeComponent();
            if (cri.Img == null)
            {
                if (pictureBox1 != null) { pictureBox1.Image = null; }
            }
            else
            {
                MemoryStream memory = new MemoryStream(cri.Img);
                if (pictureBox1 != null) { pictureBox1.Image = Image.FromStream(memory); }
            }
        }

        public foto(Pessoa p)
        {
            InitializeComponent();
            if (p.Img == null)
            {
                if (pictureBox1 != null) { pictureBox1.Image = null; }
            }
            else
            {
                MemoryStream memory = new MemoryStream(p.Img);
                if (pictureBox1 != null) { pictureBox1.Image = Image.FromStream(memory); }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void foto_Load(object sender, EventArgs e)
        {

        }
    }
}
