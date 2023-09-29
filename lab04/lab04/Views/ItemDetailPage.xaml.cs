using lab04.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace lab04.Views
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