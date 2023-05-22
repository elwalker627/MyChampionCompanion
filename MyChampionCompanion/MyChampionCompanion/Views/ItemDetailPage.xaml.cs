using System.ComponentModel;
using Xamarin.Forms;
using MyChampionCompanion.ViewModels;

namespace MyChampionCompanion.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
