using System.ComponentModel;
using Xamarin.Forms;
using Readbooks.ViewModels;

namespace Readbooks.Views
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