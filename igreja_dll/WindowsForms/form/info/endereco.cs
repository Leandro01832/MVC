using business.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.form.info
{
    public partial class endereco : Form
    {
        public endereco(Membro mem)
        {
            InitializeComponent();
            textpais.Text = mem.Endereco.Pais;
            text_cep.Text = mem.Endereco.Pais;
            text_estado.Text = mem.Endereco.Estado;
            text_cidade.Text = mem.Endereco.Cidade;
            text_bairro.Text = mem.Endereco.Bairro;
            text_rua.Text = mem.Endereco.Rua;
            text_complemento.Text = mem.Endereco.Complemento;
            text_numero.Text = mem.Endereco.Numero_casa.ToString();
        }

        public endereco(Visitante visi)
        {
            InitializeComponent();
            textpais.Text = visi.Endereco.Pais;
            text_cep.Text = visi.Endereco.Pais;
            text_estado.Text = visi.Endereco.Estado;
            text_cidade.Text = visi.Endereco.Cidade;
            text_bairro.Text = visi.Endereco.Bairro;
            text_rua.Text = visi.Endereco.Rua;
            text_complemento.Text = visi.Endereco.Complemento;
            text_numero.Text = visi.Endereco.Numero_casa.ToString();
        }

        public endereco(Crianca cri)
        {
            InitializeComponent();
            textpais.Text = cri.Endereco.Pais;
            text_cep.Text = cri.Endereco.Pais;
            text_estado.Text = cri.Endereco.Estado;
            text_cidade.Text = cri.Endereco.Cidade;
            text_bairro.Text = cri.Endereco.Bairro;
            text_rua.Text = cri.Endereco.Rua;
            text_complemento.Text = cri.Endereco.Complemento;
            text_numero.Text = cri.Endereco.Numero_casa.ToString();
        }

        public endereco(Pessoa p)
        {
            InitializeComponent();
            textpais.Text = p.Endereco.Pais;
            text_cep.Text = p.Endereco.Pais;
            text_estado.Text = p.Endereco.Estado;
            text_cidade.Text = p.Endereco.Cidade;
            text_bairro.Text = p.Endereco.Bairro;
            text_rua.Text = p.Endereco.Rua;
            text_complemento.Text = p.Endereco.Complemento;
            text_numero.Text = p.Endereco.Numero_casa.ToString();
        }

        private void textpais_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_cep_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_estado_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_cidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_bairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_rua_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_complemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void endereco_Load(object sender, EventArgs e)
        {

        }
    }
}
