using Emailzing.UI.ViewModels;
using System.Windows;

namespace Emailzing.UI.Views
{
	public partial class MainWindow : Window
	{
		private readonly MainWindowViewModel _viewModel;

		public MainWindow(MainWindowViewModel mainWindowViewModel)
		{
			InitializeComponent();

			_viewModel = mainWindowViewModel;
			DataContext = _viewModel;

			_viewModel.Load();
		}
	}
}
