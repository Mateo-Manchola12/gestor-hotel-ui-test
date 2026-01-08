using System.Windows.Controls;

namespace GestorHotel.Views;

/// <summary>
/// Interaction logic for ReservasView.xaml
/// </summary>
public partial class ReservasView : Page
{
    public ReservasView()
    {
        InitializeComponent();
        LoadSampleData();
    }

    private void LoadSampleData()
    {
        // Sample data for demonstration
        var reservas = new[]
        {
            new { Id = "R001", Huesped = "Juan García", Habitacion = "101", CheckIn = "2024-01-15", CheckOut = "2024-01-20", Noches = 5, Total = "$250.00", Estado = "Confirmada" },
            new { Id = "R002", Huesped = "María López", Habitacion = "102", CheckIn = "2024-01-18", CheckOut = "2024-01-22", Noches = 4, Total = "$300.00", Estado = "En curso" },
            new { Id = "R003", Huesped = "Carlos Rodríguez", Habitacion = "201", CheckIn = "2024-01-20", CheckOut = "2024-01-25", Noches = 5, Total = "$750.00", Estado = "Confirmada" },
            new { Id = "R004", Huesped = "Ana Martínez", Habitacion = "202", CheckIn = "2024-01-22", CheckOut = "2024-01-24", Noches = 2, Total = "$150.00", Estado = "Pendiente" },
            new { Id = "R005", Huesped = "Pedro Sánchez", Habitacion = "301", CheckIn = "2024-01-25", CheckOut = "2024-02-01", Noches = 7, Total = "$1,750.00", Estado = "Confirmada" }
        };
        dgReservas.ItemsSource = reservas;
    }
}
