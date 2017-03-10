using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TibolaNutricao.Data
{
    public class RefeicaoDAO
    {
        private SQLiteConnection Con { get; set; }
        private ObservableCollection<Refeicao> lista { get; set; }
        public ObservableCollection<Refeicao> Lista
        {
            get
            {
                if(lista == null)
                {
                    lista = GetAll();
                }
                return lista;
            }
            private set
            {
                lista = value;
            }
        }
        
        public RefeicaoDAO(SQLiteConnection con)
        {
            this.Con = con;
            Con.CreateTable<Refeicao>();
        }

        public void Salvar(Refeicao refeicao)
        {
            Con.Insert(refeicao);
            Lista.Add(refeicao);
        }

        internal void Remove(Refeicao refeicao)
        {
            Con.Delete<Refeicao>(refeicao.ID);
            Lista.Remove(refeicao);
        }

        public ObservableCollection<Refeicao> GetAll()
        {
           return new ObservableCollection<Refeicao>(Con.Table<Refeicao>());
        }

    }
}
