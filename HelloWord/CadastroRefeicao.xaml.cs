using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace HelloWord
{
	public partial class CadastroRefeicao : ContentPage
	{

		public ObservableCollection<Refeicao> Refeicoes { get; set;}

		public CadastroRefeicao(ObservableCollection<Refeicao> refeicoes)
		{
			InitializeComponent();
			this.Refeicoes = refeicoes;
		}

		public void AtualizaContador(Object sender, EventArgs args)
		{
			double valor = sldCalorias.Value;
			lblCalorias.Text = valor.ToString();

		}

		public void SalvaRefeicao(Object sender, EventArgs args)
		{
			string descricao = txtDescricao.Text;
			double valor = sldCalorias.Value;


			Refeicao refeicao = new Refeicao(descricao, calorias: valor);
			Refeicoes.Add(refeicao);

			string msg = "A refeição " + descricao + " de " + valor + " calorias";

			DisplayAlert("Salvar Refeição", msg, "Ok" );
			LimpaForm();

		}


		public void LimpaForm()
		{
			sldCalorias.Value = 10;
			txtDescricao.Text = "";
		}


	}
}
