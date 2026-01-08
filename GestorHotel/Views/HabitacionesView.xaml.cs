using System.Windows.Controls;

namespace GestorHotel.Views;

/// <summary>
/// Interaction logic for HabitacionesView.xaml
/// </summary>
public partial class HabitacionesView : Page
{
    public HabitacionesView()
    {
        InitializeComponent();
        LoadSampleData();
    }

    private void LoadSampleData()
    {
        // Sample data for demonstration
        var habitaciones = new[]
        {
            new { Numero = "101", Tipo = "Individual", Capacidad = 1, Precio = "$50.00", Estado = "Disponible", Piso = "1" },
            new { Numero = "102", Tipo = "Doble", Capacidad = 2, Precio = "$75.00", Estado = "Ocupada", Piso = "1" },
            new { Numero = "201", Tipo = "Suite", Capacidad = 4, Precio = "$150.00", Estado = "Disponible", Piso = "2" },
            new { Numero = "202", Tipo = "Doble", Capacidad = 2, Precio = "$75.00", Estado = "Mantenimiento", Piso = "2" },
            new { Numero = "301", Tipo = "Suite Premium", Capacidad = 6, Precio = "$250.00", Estado = "Disponible", Piso = "3" }
        };
        dgHabitaciones.ItemsSource = habitaciones;
    }
}
