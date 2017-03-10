using TibolaNutricao.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TibolaNutricao.ViewModel
{
    class CadastroRefeicaoViewModel : INotifyPropertyChanged
    {
        private string descricao;
        private double calorias;
        private RefeicaoDAO dao;
        private ContentPage page;
        public ICommand SalvaRefeicao { get; protected set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                if(value != descricao)
                {
                    descricao = value;
                    OnPropertyChanged("Descricao");
                }
            }
        }

        public double Calorias
        {
            get
            {
                return calorias;
            }
            set
            {
                if(value != calorias)
                {
                    calorias = value;
                    OnPropertyChanged("Calorias");
                }
            }
        }

        private void OnPropertyChanged(string nome)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(nome));
        }

        public CadastroRefeicaoViewModel(RefeicaoDAO dao, ContentPage page)
        {
            this.dao = dao;
            this.page = page;
            SalvaRefeicao = new Command(() =>
            {
                var refeicao = new Refeicao(descricao, calorias);
                dao.Salvar(refeicao);
                string mensagem = string.Format("A refeicao {0} de {1} calorias foi gravada com sucesso", descricao, calorias);
                this.page.DisplayAlert("Refeição Salva", mensagem, "OK");
            });
        }


    }
}
