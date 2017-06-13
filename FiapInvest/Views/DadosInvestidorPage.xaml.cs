using FiapInvest.Models;
using Xamarin.Forms;

namespace FiapInvest.Views
{
    public partial class DadosInvestidorPage : ContentPage
    {
        private int IdUsuario = 1;

        public InvestidorModel investidorModel { get; set; }

        public DadosInvestidorPage()
        {
            InitializeComponent();
            investidorModel = new Business.InvestidorBusiness().Consultar(IdUsuario);
            BindingContext = investidorModel;
            ButtonGravar.Clicked += ButtonGravarClicked;
        }


        public void ButtonGravarClicked(object o, System.EventArgs e)
        {
            new Business.InvestidorBusiness().Gravar(investidorModel);
            DisplayAlert("Investidor", investidorModel.NomeInvestidor + " gravado com sucesso", "Fechar");
        }

    }
}
