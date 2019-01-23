using database.banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Collections;

namespace business.classes
{
    [Table("Reuniao")]
    public class Reuniao : modelocrud<Reuniao>
    {
       
        private int id;
        private DateTime data_reuniao;
        private DateTime horario_inicio;
        private DateTime horario_fim;
        private string local_reuniao;

        [Display(Name = "Código")]
        [Key]
        public int cronologiaid
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

        [Display(Name = "Data da reunião")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data_reuniao
        {
            get
            {
                return data_reuniao;
            }

            set
            {
                if(value >= DateTime.Now)
                data_reuniao = value;
                else
                {
                    MessageBox.Show("A data precisa ser maior ou igual ao dia atual");
                    data_reuniao = DateTime.Now;
                }
            }
        }

        [Display(Name = "Horário de início")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public DateTime Horario_inicio
        {
            get
            {
                return horario_inicio;
            }

            set
            {
                horario_inicio = value;
            }
        }

        [Display(Name = "Horário de termino")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public DateTime Horario_fim
        {
            get
            {
                return horario_fim;
            }

            set
            {
                if (value > horario_inicio)
                horario_fim = value;
                else
                {
                    MessageBox.Show("O horario que termina a reunião deve ser maior que o horario de inicio");
                    horario_fim = horario_inicio.AddHours(1);
                }
            }
        }

        [Display(Name = "Local da reunião")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Local_reuniao
        {
            get
            {
                return local_reuniao;
            }

            set
            {
                if(value != "")
                local_reuniao = value;
                else
                {
                    MessageBox.Show("Informe o local da reunião");
                    local_reuniao = null;
                }
            }
        }

        public List<Pessoa> Pessoas { get; set; }

        public Reuniao()
        {
            bd = new BDcomum();
        }

        public override string alterar()
        {
            throw new NotImplementedException();
        }

        public override string excluir()
        {
            throw new NotImplementedException();
        }

        public override Reuniao recuperar(int id)
        {
            throw new NotImplementedException();
        }

        public override string salvar()
        {
            insert_padrao = "insert into cronologia_ministerio (crono_data_reuniao," +
                " crono_horario_inicio, crono_horario_fim, crono_local_reuniao, crono_ministerio) " +
        " values ('@data', '@horario_inicio', '@horario_fim', '@local_reuniao', IDENT_CURRENT('cronologia'))";

            Insert = insert_padrao.Replace("@data", data_reuniao.ToString("yyyy-MM-dd"));
            Insert = Insert.Replace("@horario_inicio", horario_inicio.ToString("HH:mm:ss"));
            Insert = Insert.Replace("@horario_fim", horario_fim.ToString("HH:mm:ss"));
            Insert = Insert.Replace("@local_reuniao", local_reuniao);

            return bd.montar_sql(Insert, null, null);
        }     

        public override IEnumerable<Reuniao> recuperartodos()
        {
            throw new NotImplementedException();
        }
    }
}
