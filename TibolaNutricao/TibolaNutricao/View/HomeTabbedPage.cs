using TibolaNutricao.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace TibolaNutricao
{
    public class HomeTabbedPage : TabbedPage
    {
        public HomeTabbedPage()
        {
            SQLiteConnection con = DependencyService.Get<ISqlite>().GetConnection();
            var dao = new RefeicaoDAO(con);

            var telaCadastro = new CadastroRefeicao(dao);
            var telaRefeicoes = new ListaRefeicoes(dao);

            this.Children.Add(telaCadastro);
            this.Children.Add(telaRefeicoes);
        }
    }
}
