using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.banco;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Collections;

namespace business.classes
{
   [Table("Endereco_celula")]    
    public class Endereco_Celula : modelocrud<Endereco_Celula>
    {
      

        private int id;
        private string cel_bairro;
        private string cel_rua;
        private int cel_numero;       

        [Key, ForeignKey("Celula")]
        public int enderecoid { get; set; }

        public virtual Celula Celula { get; set; }

        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Cel_bairro
        {
            get
            {
                return cel_bairro;
            }

            set
            {
                if(value != "")
                cel_bairro = value;
                else
                {
                    MessageBox.Show("Informe o bairro para reunião de celula");
                    cel_bairro = null;
                }
            }
        }

        [Display(Name = "Rua")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Cel_rua
        {
            get
            {
                return cel_rua;
            }

            set
            {
                if(value != "")
                cel_rua = value;
                else
                {
                    MessageBox.Show("Informe a rua para reunião de celula");
                    cel_rua = null;
                }
            }
        }

        [Display(Name = "Numero")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public int Cel_numero
        {
            get
            {
                return cel_numero;
            }

            set
            {
                if(value != 0)
                cel_numero = value;
                else
                {
                    MessageBox.Show("Informe o numero da casa para reunião de celula");
                    cel_numero = 0;
                }
            }
        }

        public Endereco_Celula()
        {
            bd = new BDcomum();
        }

        public override string alterar(int id)
        {
            throw new NotImplementedException();
        }

        public override string excluir(int id)
        {
            throw new NotImplementedException();
        }

        public override Endereco_Celula recuperar(int id)
        {
            throw new NotImplementedException();
        }

        public override string salvar()
        {
            insert_padrao =
             "insert into Endereco_celula (Cel_bairro, Cel_rua, Cel_numero, enderecoid) values ('@bairro', '@rua', '@numero', IDENT_CURRENT('Pessoa'))";
                        
            Insert = insert_padrao.Replace("@bairro", Cel_bairro);
            Insert = Insert.Replace("@rua", Cel_rua);
            Insert = Insert.Replace("@numero", Cel_numero.ToString());

            return bd.montar_sql(Insert, null, null);
        }      

        public override IEnumerable<Endereco_Celula> recuperartodos()
        {
            throw new NotImplementedException();
        }
    }
}
