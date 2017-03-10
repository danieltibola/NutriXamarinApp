using TibolaNutricao.Data;
using TibolaNutricao.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TibolaNutricao
{
    public partial class CadastroRefeicao : ContentPage
    {
        private RefeicaoDAO dao;
        public CadastroRefeicao(RefeicaoDAO dao)
        {
            CadastroRefeicaoViewModel vm = new CadastroRefeicaoViewModel(dao, this);
            BindingContext = vm;
            InitializeComponent();
        }
    }
}
