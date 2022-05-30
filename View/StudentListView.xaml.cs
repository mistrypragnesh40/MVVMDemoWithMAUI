using MVVMDemoWithMAUI.ViewModel;

namespace MVVMDemoWithMAUI.View;

public partial class StudentListView : ContentPage
{
	public StudentListView()
	{
		InitializeComponent();
		this.BindingContext = new StudentListViewModel();
	}
}