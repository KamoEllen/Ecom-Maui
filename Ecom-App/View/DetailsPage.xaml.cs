using Ecom_App.Model;
using Ecom_App.ViewModel;

namespace Ecom_App.View;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(Product selectedProduct)
    {
        InitializeComponent();

        var viewModel = new DetailsViewModel
        {
            SelectedProduct = selectedProduct,
            ProductImages = selectedProduct.Images?.ToList() ?? new List<string>(),
            MoreItems = selectedProduct.Images?.Count ?? 0
        };

        BindingContext = viewModel;
       // SetViewPositions();
       // FadeAndTranslate();
    }


    private void SetViewPositions()
    {
        detailsBtn.Opacity = 0;
        detailsBtn.Scale = 0.2;
        detailsBtn.Rotation = 300;
        imagesView.TranslationX = 300;
        imagesView.Opacity = 0;
        buyBtn.Opacity = 0;
        buyBtn.Scale = 0.2;
        popView.TranslationY = 300;
        popView.Opacity = 0.5;
    }

    private void FadeAndTranslate(VisualElement view, uint fadeLength = 1000, uint translateLength = 1500)
    {
        view.FadeTo(1, fadeLength, Easing.SinInOut);
        view.TranslateTo(0, 0, translateLength, Easing.SinInOut);
    }

    private void FadeAndScale(VisualElement view, uint fadeLength = 1000, uint scaleLength = 1500)
    {
        view.FadeTo(1, fadeLength, Easing.SinInOut);
        view.ScaleTo(1, scaleLength, Easing.SinInOut);
    }

    private void RotateView(VisualElement view) =>
        view.RotateTo(0, 1500, Easing.SinInOut);





}