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
    public partial class Web : Form
    {
        public Web()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://www.facebook.com/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://www.youtube.com/");
        }
    }
}
