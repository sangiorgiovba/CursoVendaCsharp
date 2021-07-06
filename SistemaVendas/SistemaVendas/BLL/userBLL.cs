using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.BLL
{
    class userBLL
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string s_nome { get; set; }
        public string email { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string contato { get; set; }
        public string endereco { get; set; }
        public string sexo { get; set; }
        public string usuario_tipo { get; set; }
        public DateTime add_data { get; set; }
        public int add_por { get; set; }
    }
}
