using business.classes;
using database.banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
   public class senha
    {
        private string hash;

        public string Hash
        {
            get
            {
                return hash;
            }

            set
            {                
                hash = criptografadaSHA512(value);
            }
        }

        public senha()
        {

        }

        public void salvar()
        {
            Pessoa pes = new Pessoa();
            string insert_padrao = "insert into senha (hash, senha_pessoa) values ('@valor', IDENT_CURRENT('pessoa'))";
            string insert = insert_padrao.Replace("@valor", Hash);
            pes.bd.montar_sql(insert, null, null, true);
        }

        public string criptografadaSHA512(string valor)
        {
            var _stringHash = "";
            try
            {
                UnicodeEncoding _encode = new UnicodeEncoding();
                byte[] _hashBytes, _messageBytes = _encode.GetBytes(valor);

                SHA512Managed _sha512Manager = new SHA512Managed();


                _hashBytes = _sha512Manager.ComputeHash(_messageBytes);

                foreach (byte b in _hashBytes)
                {
                    _stringHash += String.Format("{0:x2}", b);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _stringHash;
        }
    }
}
