using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using database.banco;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Collections;

namespace business.classes
{
    
    public class Endereco : modelocrud<Endereco>
    {
        
        private int    id;        
        private string pais;
        private string estado;
        private string cidade;
        private string bairro;
        private string rua;
        private int    numero_casa;
        private long   cep;
        private string complemento;


        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Pais
        {
            get
            {
                return pais;
            }

            set
            {
                
                pais = value;
                
            }
        }

        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                if(value != "")
                estado = value;
                else
                {
                    MessageBox.Show("Estado precisa ser preenchido corretamente!!!");
                    estado = null;
                }
            }
        }

        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                if(value != "")
                cidade = value;
                else
                {
                    MessageBox.Show("cidade precisa ser preenchido corretamente!!!");
                    cidade = null;
                }
            }
          
        }

        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                if(value != "")
                bairro = value;
                else
                {
                    MessageBox.Show("bairro precisa ser preenchido corretamente!!!");
                    bairro = null;
                }
            }
        }

        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Rua
        {
            get
            {
                return rua;
            }

            set
            {
                if (value!= "")
                rua = value;
                else
                {
                    MessageBox.Show("rua precisa ser preenchido corretamente!!!");
                    rua = null;
                }
            }
        }

        [Display(Name = "Numero da casa")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public int Numero_casa
        {
            get
            {
                return numero_casa;
            }

            set
            {
                if (value != 0)
                numero_casa = value;
                else
                {
                    MessageBox.Show("numero da casa precisa ser preenchido corretamente!!!");
                    numero_casa = 0;
                }
            }
        }

        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public long Cep
        {
            get
            {
                return cep;
            }

            set
            {
                if(value != 0)
                cep = value;
                else
                {
                    MessageBox.Show("Cep precisa ser preenchido corretamente!!!");
                    cep = 0;
                }
            }
        }

        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Complemento
        {
            get
            {
                return complemento;
            }

            set
            {                
                complemento = value;
            }
        }

        [Key, ForeignKey("Pessoa")]
        public int EnderecoId
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public virtual Pessoa Pessoa { get; set; }

        public Endereco()
        {
            bd = new BDcomum();
        }

        public override string salvar()
        {
            insert_padrao =
        "insert into Endereco (Pais, Estado, Cidade, Bairro, Rua, Numero_casa, Cep, Complemento, EnderecoId) values " +
        " ('@pais', '@estado', '@cidade', '@bairro', '@rua', '@numero_casa', '@cep', '@complemento', IDENT_CURRENT('Pessoa'))";           
         
            Insert = insert_padrao.Replace("@pais", Pais);
            Insert = Insert.Replace("@estado", Estado);
            Insert = Insert.Replace("@cidade", Cidade);
            Insert = Insert.Replace("@bairro", Bairro);
            Insert = Insert.Replace("@rua", Rua);
            Insert = Insert.Replace("@numero_casa", Numero_casa.ToString());
            Insert = Insert.Replace("@cep", Cep.ToString());
            Insert = Insert.Replace("@complemento", Complemento);

            return Insert;
        }

        public override string alterar(int id)
        {
            throw new NotImplementedException();
        }

        public override string excluir(int id)
        {
            throw new NotImplementedException();
        }

        public override Endereco recuperar(int id)
        {
            throw new NotImplementedException();
        }      

        public override IEnumerable<Endereco> recuperartodos()
        {
            throw new NotImplementedException();
        }
    }







}
