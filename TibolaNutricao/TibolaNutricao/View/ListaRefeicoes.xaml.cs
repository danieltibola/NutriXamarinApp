using TibolaNutricao.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TibolaNutricao
{
    public partial class ListaRefeicoes : ContentPage
    {
        public ObservableCollection<Refeicao> Refeicoes { get; set; }
        private RefeicaoDAO dao;
        public ListaRefeicoes(RefeicaoDAO dao)
        {
            BindingContext = this;
            this.dao = dao;
            Refeicoes = dao.Lista;
            InitializeComponent();

        }

        public async void AcaoItem (Object sender, ItemTappedEventArgs e)
        {
            var refeicao = e.Item as Refeicao;
            var resposta = await DisplayAlert("Remover refeição", "Deseja remover a refeição " + refeicao.Descricao, "Sim", "Não");
            if (resposta)
            {
                dao.Remove(refeicao);
                await DisplayAlert("Remover refeição", "Refeição removida com sucesso", "OK");
            }
        }
    }
}
