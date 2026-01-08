using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GestorHotel.Views;

namespace GestorHotel;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        // Navigate to Habitaciones by default
        MainFrame.Navigate(new HabitacionesView());
    }

    private void NavigateToHabitaciones(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new HabitacionesView());
    }

    private void NavigateToHuespedes(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new HuespedesView());
    }

    private void NavigateToReservas(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new ReservasView());
    }

    private void NavigateToResenas(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new ResenasView());
    }

    private void NavigateToEmpleados(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new EmpleadosView());
    }
}