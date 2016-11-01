using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace HelloWord
{
	public class HomeTabbedPage : TabbedPage
	{
		public HomeTabbedPage()
		{
			ObservableCollection<Refeicao> refeicoes = new ObservableCollection<Refeicao>();

			this.Children.Add(new CadastroRefeicao(refeicoes));
			this.Children.Add(new ListRefeicoes(refeicoes));

		}
	}
}

