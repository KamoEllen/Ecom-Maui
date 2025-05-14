using Ecom_App.ViewModel;
namespace Ecom_App.View;

public partial class LandingPage : ContentPage
{
    public LandingPage()
    {
        InitializeComponent();

        this.BindingContext = new LandingViewModel();
        (SectionList.Children[0] as RadioButton).IsChecked = true;

        colView.ItemsLayout = new GridItemsLayout(3, ItemsLayoutOrientation.Vertical)
        {
            HorizontalItemSpacing = 10,
            VerticalItemSpacing = 10
        };
    }
}