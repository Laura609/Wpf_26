using System.Windows;
using static Wpf_26.View.AppClass.AppState;

namespace Wpf_26
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var state = AppStateManager.LoadState();

            // Привяжите свойства state к элементам интерфейса
            DataContext = state;
        }
    }
}