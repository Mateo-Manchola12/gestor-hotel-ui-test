using System.Windows.Controls;

namespace GestorHotel.Views;

/// <summary>
/// Interaction logic for ResenasView.xaml
/// </summary>
public partial class ResenasView : Page
{
    public ResenasView()
    {
        InitializeComponent();
        LoadSampleData();
    }

    private void LoadSampleData()
    {
        // Sample data for demonstration
        var resenas = new[]
        {
            new { Id = "RE001", Huesped = "Juan García", Habitacion = "101", Calificacion = "⭐⭐⭐⭐⭐", Fecha = "2024-01-21", Comentario = "Excelente servicio y habitación muy limpia" },
            new { Id = "RE002", Huesped = "María López", Habitacion = "102", Calificacion = "⭐⭐⭐⭐", Fecha = "2024-01-23", Comentario = "Muy buena experiencia, pero el WiFi era lento" },
            new { Id = "RE003", Huesped = "Carlos Rodríguez", Habitacion = "201", Calificacion = "⭐⭐⭐⭐⭐", Fecha = "2024-01-26", Comentario = "Suite increíble con vista espectacular" },
            new { Id = "RE004", Huesped = "Ana Martínez", Habitacion = "202", Calificacion = "⭐⭐⭐", Fecha = "2024-01-25", Comentario = "Bien en general, pero podría mejorar el desayuno" },
            new { Id = "RE005", Huesped = "Pedro Sánchez", Habitacion = "301", Calificacion = "⭐⭐⭐⭐⭐", Fecha = "2024-02-02", Comentario = "Perfecta para familias, muy espaciosa y cómoda" }
        };
        dgResenas.ItemsSource = resenas;
    }
}
