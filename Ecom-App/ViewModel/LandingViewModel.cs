using Ecom_App.Model;
using Ecom_App.View;
using System.Windows.Input;

namespace Ecom_App.ViewModel;

public class LandingViewModel : BaseViewModel
{
    public List<string> Sections => new List<string> 
    { 
        "Trending", 
        "Tops", 
        "Bottoms", 
        "Footwear" 
    };
   
    public List<Product> Products => ProductRepo.AllProducts;

    public Product? SelectedProduct { get; set; }

    public ICommand ProductSelected => new Command(obj =>
    {
        if (SelectedProduct != null)
            Application
                .Current?
                .MainPage?
                .Navigation
                .PushAsync(new DetailsPage(SelectedProduct));

        SelectedProduct = null;
    });
}
