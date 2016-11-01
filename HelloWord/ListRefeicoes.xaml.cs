using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace HelloWord
{
	public partial class ListRefeicoes : ContentPage
	{

		public ObservableCollection<Refeicao> Refeicoes { get; set; }
		public string Titulo { get; set; }

		public ListRefeicoes(ObservableCollection<Refeicao> refeicoes)
		{
			Titulo = "Lista Refeições";
			BindingContext = this;
			Refeicoes = refeicoes;

			InitializeComponent();

		}


		public async void AcaoItem(Object sender, ItemTappedEventArgs args)
		{
			Refeicao refeicao = args.Item as Refeicao;
			string msg = "Você deseja remover a refeição : " + refeicao.Descricao;
			var resposta = await DisplayAlert("Remover item", msg, "Sim", "Não");

			if (resposta)
			{
				Refeicoes.Remove(refeicao);
				await DisplayAlert("Sucesso", "Refeição Removida com Sucesso", "Ok");
			}

		}
	}
}
