using System.Windows.Controls;

namespace GestorHotel.Views;

/// <summary>
/// Interaction logic for HuespedesView.xaml
/// </summary>
public partial class HuespedesView : Page
{
    public HuespedesView()
    {
        InitializeComponent();
        LoadSampleData();
    }

    private void LoadSampleData()
    {
        // Sample data for demonstration
        var huespedes = new[]
        {
            new { Id = "001", Nombre = "Juan García", Documento = "12345678", Email = "juan.garcia@email.com", Telefono = "+34 600 123 456", Pais = "España" },
            new { Id = "002", Nombre = "María López", Documento = "87654321", Email = "maria.lopez@email.com", Telefono = "+34 600 987 654", Pais = "España" },
            new { Id = "003", Nombre = "Carlos Rodríguez", Documento = "45678912", Email = "carlos.rodriguez@email.com", Telefono = "+52 55 1234 5678", Pais = "México" },
            new { Id = "004", Nombre = "Ana Martínez", Documento = "78945612", Email = "ana.martinez@email.com", Telefono = "+57 300 456 7890", Pais = "Colombia" },
            new { Id = "005", Nombre = "Pedro Sánchez", Documento = "32165498", Email = "pedro.sanchez@email.com", Telefono = "+54 11 2345 6789", Pais = "Argentina" }
        };
        dgHuespedes.ItemsSource = huespedes;
    }
}
