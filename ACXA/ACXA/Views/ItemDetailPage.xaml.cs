using System.ComponentModel;
using ACXA.ViewModels;
using Xamarin.Forms;

namespace ACXA.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage ( ) {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}