using Ecom_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ecom_App.ViewModel
{
    public class DetailsViewModel : BaseViewModel
    {
        public Product SelectedProduct { get; set; }
        public List<string> ProductImages { get; set; }
        public int MoreItems { get; set; }

        public ICommand CloseCommand => new Command(() => Application.Current.MainPage.Navigation.PopAsync());
    }
}