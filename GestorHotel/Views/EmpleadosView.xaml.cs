using System.Windows.Controls;

namespace GestorHotel.Views;

/// <summary>
/// Interaction logic for EmpleadosView.xaml
/// </summary>
public partial class EmpleadosView : Page
{
    public EmpleadosView()
    {
        InitializeComponent();
        LoadSampleData();
    }

    private void LoadSampleData()
    {
        // Sample data for demonstration
        var empleados = new[]
        {
            new { Id = "E001", Nombre = "Laura Fernández", Cargo = "Recepcionista", Departamento = "Recepción", Email = "laura.fernandez@hotel.com", Telefono = "+34 600 111 222" },
            new { Id = "E002", Nombre = "Miguel Torres", Cargo = "Gerente", Departamento = "Administración", Email = "miguel.torres@hotel.com", Telefono = "+34 600 222 333" },
            new { Id = "E003", Nombre = "Carmen Ruiz", Cargo = "Camarera", Departamento = "Limpieza", Email = "carmen.ruiz@hotel.com", Telefono = "+34 600 333 444" },
            new { Id = "E004", Nombre = "Roberto Díaz", Cargo = "Chef", Departamento = "Cocina", Email = "roberto.diaz@hotel.com", Telefono = "+34 600 444 555" },
            new { Id = "E005", Nombre = "Isabel Moreno", Cargo = "Recepcionista", Departamento = "Recepción", Email = "isabel.moreno@hotel.com", Telefono = "+34 600 555 666" }
        };
        dgEmpleados.ItemsSource = empleados;
    }
}
