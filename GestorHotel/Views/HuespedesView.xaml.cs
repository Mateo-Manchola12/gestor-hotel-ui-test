using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows;

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
        // Space-themed sample data for demonstration
        var reservations = new[]
        {
            new ReservationData 
            { 
                GuestName = "Xylara-Torak", 
                GuestType = "Diplomat",
                RoomNumber = "Suite 401",
                RoomType = "Suite Lunar",
                CheckIn = "May 4, 2024",
                CheckOut = "May 6, 2024",
                Status = "Confirmada",
                StatusStyle = FindResource("StatusBadgeConfirmed") as Style,
                Employee = "Kargox",
                AvatarColor1 = Color.FromRgb(139, 92, 246),
                AvatarColor2 = Color.FromRgb(79, 70, 229)
            },
            new ReservationData 
            { 
                GuestName = "Zelora Primee", 
                GuestType = "Explorer",
                RoomNumber = "Pod 206",
                RoomType = "Pod Estelar",
                CheckIn = "May 4, 2024",
                CheckOut = "May 6, 2024",
                Status = "Pendiente",
                StatusStyle = FindResource("StatusBadgePending") as Style,
                Employee = "Lyana-2X",
                AvatarColor1 = Color.FromRgb(59, 130, 246),
                AvatarColor2 = Color.FromRgb(37, 99, 235)
            },
            new ReservationData 
            { 
                GuestName = "Captain Vlex", 
                GuestType = "Commander",
                RoomNumber = "Estelar 305",
                RoomType = "Habitación Estelar",
                CheckIn = "May 4, 2024",
                CheckOut = "May 6, 2024",
                Status = "Confirmada",
                StatusStyle = FindResource("StatusBadgeConfirmed") as Style,
                Employee = "Vornak",
                AvatarColor1 = Color.FromRgb(16, 185, 129),
                AvatarColor2 = Color.FromRgb(5, 150, 105)
            },
            new ReservationData 
            { 
                GuestName = "Dr. Zorgul", 
                GuestType = "Scientist",
                RoomNumber = "Galáctica 708",
                RoomType = "Galáctica",
                CheckIn = "May 4, 2024",
                CheckOut = "May 6, 2024",
                Status = "Pendiente",
                StatusStyle = FindResource("StatusBadgePending") as Style,
                Employee = "Elar-7",
                AvatarColor1 = Color.FromRgb(168, 85, 247),
                AvatarColor2 = Color.FromRgb(126, 34, 206)
            },
            new ReservationData 
            { 
                GuestName = "Kargox", 
                GuestType = "Trader",
                RoomNumber = "Galáctica 708",
                RoomType = "Galáctica",
                CheckIn = "May 4, 2024",
                CheckOut = "May 6, 2024",
                Status = "Cancelada",
                StatusStyle = FindResource("StatusBadgeCancelled") as Style,
                Employee = "Elar-7",
                AvatarColor1 = Color.FromRgb(59, 130, 246),
                AvatarColor2 = Color.FromRgb(29, 78, 216)
            }
        };
        icHuespedes.ItemsSource = reservations;
    }
    
    private void Row_MouseEnter(object sender, MouseEventArgs e)
    {
        if (sender is Border border)
        {
            border.Background = new SolidColorBrush(Color.FromRgb(45, 32, 85));
        }
    }
    
    private void Row_MouseLeave(object sender, MouseEventArgs e)
    {
        if (sender is Border border)
        {
            border.Background = new SolidColorBrush(Colors.Transparent);
        }
    }
}

public class ReservationData
{
    public string GuestName { get; set; } = "";
    public string GuestType { get; set; } = "";
    public string RoomNumber { get; set; } = "";
    public string RoomType { get; set; } = "";
    public string CheckIn { get; set; } = "";
    public string CheckOut { get; set; } = "";
    public string Status { get; set; } = "";
    public Style? StatusStyle { get; set; }
    public string Employee { get; set; } = "";
    public Color AvatarColor1 { get; set; }
    public Color AvatarColor2 { get; set; }
}
