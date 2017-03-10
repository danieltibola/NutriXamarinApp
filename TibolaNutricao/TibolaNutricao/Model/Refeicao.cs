using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TibolaNutricao
{
    public class Refeicao
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Descricao { get; set; }
        public double Calorias { get; set; }

        public Refeicao()
        {
                
        }
        public Refeicao(string descricao, double calorias)
        {
            this.Descricao = descricao;
            this.Calorias = calorias;
        }
    }
}
