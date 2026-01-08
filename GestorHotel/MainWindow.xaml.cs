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
        // Navigate to Huéspedes by default to match reference design
        MainFrame.Navigate(new HuespedesView());
        btnHuespedes.Background = new SolidColorBrush(Color.FromRgb(61, 45, 109));
    }

    private void NavigateToHabitaciones(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new HabitacionesView());
        UpdateActiveButton(btnHabitaciones);
    }

    private void NavigateToHuespedes(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new HuespedesView());
        UpdateActiveButton(btnHuespedes);
    }

    private void NavigateToReservas(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new ReservasView());
        UpdateActiveButton(btnReservas);
    }

    private void NavigateToResenas(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new ResenasView());
        UpdateActiveButton(btnResenas);
    }

    private void NavigateToEmpleados(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new EmpleadosView());
        UpdateActiveButton(btnEmpleados);
    }
    
    private void UpdateActiveButton(Button activeButton)
    {
        // Reset all buttons
        btnHabitaciones.Background = new SolidColorBrush(Colors.Transparent);
        btnHuespedes.Background = new SolidColorBrush(Colors.Transparent);
        btnReservas.Background = new SolidColorBrush(Colors.Transparent);
        btnResenas.Background = new SolidColorBrush(Colors.Transparent);
        btnEmpleados.Background = new SolidColorBrush(Colors.Transparent);
        
        // Set active button
        activeButton.Background = new SolidColorBrush(Color.FromRgb(61, 45, 109));
    }
}