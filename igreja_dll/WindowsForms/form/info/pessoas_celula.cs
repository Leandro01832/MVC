using business.classes;
using igreja2;
using igreja2.form.atualização;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsForms.form.info
{
    public partial class pessoas_celula : Form
    {
        Membro membro = new Membro();
        Pessoa pessoa = new Pessoa();
        Visitante v = new Visitante();
        Crianca c = new Crianca();

        public pessoas_celula(Membro mem)
        {
            InitializeComponent();
            membro = mem;
        }

        public pessoas_celula(Visitante visi)
        {
            InitializeComponent();
            v = visi;
        }

        public pessoas_celula(Crianca cri)
        {
            InitializeComponent();
            c = cri;
        }

        public pessoas_celula(Pessoa p)
        {
            InitializeComponent();
            pessoa = p;
        }

        private void pessoas_celula_Load(object sender, EventArgs e)
        {
            int DynamicButtonCount = 0;
            List<Button> btnDynamicButton = new List<Button>();
            if (membro.Celula.Pessoas != null)
            {
                foreach (var m in membro.Celula.Pessoas)
                {
                    Button b = new Button();
                    string name = m.Id.ToString() + "_" + "DynamicButton";
                    b.Name = name;
                    b.Text = m.Nome;
                    b.Size = new System.Drawing.Size(200, 30);
                    b.Location = new System.Drawing.Point(200, DynamicButtonCount * 200);
                    b.Click += new EventHandler(this.btnDynamicButton_Click);
                    Controls.Add(b);
                    DynamicButtonCount++;
                }
            }
            else if (pessoa.Celula.Pessoas != null)
            {
                foreach (var p in pessoa.Celula.Pessoas)
                {
                    Button b = new Button();
                    string name = p.Id.ToString() + "_" + "DynamicButton";
                    b.Name = name;
                    b.Text = p.Nome;
                    b.Size = new System.Drawing.Size(200, 30);
                    b.Location = new System.Drawing.Point(200, DynamicButtonCount * 200);
                    b.Click += new EventHandler(this.btnDynamicButton_Click);
                    Controls.Add(b);
                    DynamicButtonCount++;
                }
            }
            else if (v.Celula.Pessoas != null)
            {
                foreach (var visi in v.Celula.Pessoas)
                {
                    Button b = new Button();
                    string name = visi.Id.ToString() + "_" + "DynamicButton";
                    b.Name = name;
                    b.Text = visi.Nome;
                    b.Size = new System.Drawing.Size(200, 30);
                    b.Location = new System.Drawing.Point(200, DynamicButtonCount * 200);
                    b.Click += new EventHandler(this.btnDynamicButton_Click);
                    Controls.Add(b);
                    DynamicButtonCount++;
                }
            }
            else
            {
                foreach (var cri in c.Celula.Pessoas)
                {
                    Button b = new Button();
                    string name = cri.Id.ToString() + "_" + "DynamicButton";
                    b.Name = name;
                    b.Text = cri.Nome;
                    b.Size = new System.Drawing.Size(200, 30);
                    b.Location = new System.Drawing.Point(200, DynamicButtonCount * 200);
                    b.Click += new EventHandler(this.btnDynamicButton_Click);
                    Controls.Add(b);
                    DynamicButtonCount++;
                }
            }
         }
           
         

// Este evento gera Botões Dinâmicos.
        private void btnGenerate_Click(object sender, EventArgs e)
        {
           
        }

        // Este evento é acionado quando um botão é clicado dinâmico.
        protected void btnDynamicButton_Click(object sender, EventArgs e)
        {
            var nome = "";
            if (membro.Celula.Pessoas != null)
            { nome = membro.Nome; }
            else if (pessoa.Celula.Pessoas != null)
            {
                nome = pessoa.Nome;
            }
            else if (v.Celula.Pessoas != null)
            {
                nome = v.Nome;
            }
            else
            {
                nome = c.Nome;
            }

                Pessoa p = new Pessoa();
            Button dynamicButton = (sender as Button);
          //  MessageBox.Show("Você clicou. " + dynamicButton.Name);
            var valor = dynamicButton.Name;
            Regex reg = new Regex(@"(\d+)");
            string id = reg.Match(valor).ToString();
            p = p.recuperar(int.Parse(id));
            dados_membro dp = new dados_membro(p);
            dp.MdiParent = MDIsingleton.InstanciaMDI();
            dp.Show();
            dp.Text = "Informações - "
                + p.recuperar(int.Parse(id)).Nome 
                + " - Item da lista de pessoas da celula de " 
                + nome;
            }
        }
    }

