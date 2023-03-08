using mauiTest.Model;
using mauiTest.ViewModel;

namespace mauiTest.Views;

public partial class CategoryDetail : ContentPage
{
	public CategoryDetail(CategoriesModel data)
	{
		InitializeComponent();
		BindingContext = new CategoryDetailViewModel(data);
	}
}
