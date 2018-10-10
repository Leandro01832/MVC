
using business.classes;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using banco;

namespace negocio
{
   public class gerenciamento
    {
        private int id_pessoa;
        private string nome;
        private byte[] img;
        

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public byte[] Img
        {
            get
            {
                return img;
            }

            set
            {
                img = value;
            }
        }

        public int Id_pessoa
        {
            get
            {
                return id_pessoa;
            }

            set
            {
                id_pessoa = value;
            }
        }

        public List<business.classes.Pessoa> pessoas(string letra)
        {
            bank b = new bank();
            DataTable datatable = b.listar(letra);
            List<business.classes.Pessoa > lista = new List<business.classes.Pessoa>();
            foreach (DataRow dtrow in datatable.Rows)
            {
                var pessoa = new business.classes.Pessoa();
                pessoa.Nome = dtrow["pes_nome"].ToString();
                pessoa.Img = dtrow["pes_foto"].ToString();
                pessoa.Id_pessoa = int.Parse(dtrow["pes_id"].ToString());
                lista.Add(pessoa);         
            }

            return lista;
        }

        public Pessoa pessoa(int id)
        {
            bank b = new bank();
            DataTable datatable = b.buscarporid(id);            
            var pessoa = new Pessoa();
            foreach (DataRow dtrow in datatable.Rows)
            {                
                pessoa.Nome = dtrow["pes_nome"].ToString();
                pessoa.Data_nascimento = Convert.ToDateTime(dtrow["pes_data_nascimento"]);
                pessoa.Img = dtrow["pes_foto"].ToString();
                pessoa.Id_pessoa = int.Parse(dtrow["pes_id"].ToString());
                pessoa.Rg = dtrow["pes_rg"].ToString();
                pessoa.Cpf = dtrow["pes_cpf"].ToString();
                pessoa.Estado_civil = dtrow["pes_estado_civil"].ToString();
                pessoa.Falescimento = Convert.ToBoolean(dtrow["pes_falescimento"]);
                pessoa.Falta = int.Parse(dtrow["pes_falta"].ToString());
                pessoa.Cep = long.Parse(dtrow["end_cep"].ToString());
                pessoa.Pais = dtrow["end_pais"].ToString();
                pessoa.Estado = dtrow["end_estado"].ToString();
                pessoa.Cidade = dtrow["end_cidade"].ToString();
                pessoa.Bairro = dtrow["end_bairro"].ToString();
                pessoa.Numero_casa = int.Parse(dtrow["end_numero"].ToString());
                pessoa.Complemento = dtrow["end_complemento"].ToString();
                pessoa.Email = dtrow["pes_email"].ToString();
                pessoa.Fone = dtrow["tel_telefone"].ToString();
                pessoa.Celular = dtrow["tel_celular"].ToString();
                pessoa.Whatsapp = dtrow["tel_whatsapp"].ToString();
            }

            return pessoa;
        }

       

    }
}
