using AppCopaHAS.ViewModels;

namespace AppCopaHAS.Views.Jogadores;

public partial class ListagemJogador : ContentPage
{
	ListagemJogadorViewModel viewModel;

	public ListagemJogador()
	{
		InitializeComponent();

        viewModel = new ListagemJogadorViewModel();
		BindingContext = viewModel;
		Title = "Listar Jogadores";
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		_ = viewModel.ObterJogadores();
    }
}