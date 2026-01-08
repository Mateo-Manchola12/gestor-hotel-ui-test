# Gestor de Hotel - Sistema de Gestión Hotelera

Sistema de gestión hotelera desarrollado en C# con WPF (Windows Presentation Foundation).

## Características

Este sistema incluye las siguientes vistas principales:

- **Habitaciones**: Gestión completa de habitaciones del hotel (agregar, editar, eliminar, buscar)
- **Huéspedes**: Administración de información de huéspedes
- **Reservas**: Control de reservaciones con fechas de check-in y check-out
- **Reseñas**: Gestión de reseñas y calificaciones de huéspedes
- **Empleados**: Administración de personal del hotel

## Requisitos

- .NET 10.0 o superior
- Windows (para ejecutar aplicaciones WPF)

## Instalación

1. Clone el repositorio:
```bash
git clone https://github.com/Mateo-Manchola12/gestor-hotel-ui-test.git
```

2. Navegue al directorio del proyecto:
```bash
cd gestor-hotel-ui-test/GestorHotel
```

3. Restaure las dependencias:
```bash
dotnet restore
```

4. Compile el proyecto:
```bash
dotnet build
```

5. Ejecute la aplicación:
```bash
dotnet run
```

## Estructura del Proyecto

```
GestorHotel/
├── Views/              # Vistas de la aplicación
│   ├── HabitacionesView.xaml
│   ├── HuespedesView.xaml
│   ├── ReservasView.xaml
│   ├── ResenasView.xaml
│   └── EmpleadosView.xaml
├── Models/             # Modelos de datos
├── ViewModels/         # ViewModels (MVVM)
├── App.xaml           # Configuración de la aplicación
└── MainWindow.xaml    # Ventana principal con navegación
```

## Uso

La aplicación cuenta con un menú de navegación superior que permite acceder a cada una de las secciones:

- Haga clic en cualquier opción del menú para navegar entre las diferentes vistas
- Cada vista incluye funciones de búsqueda y gestión de datos
- Los datos de ejemplo se cargan automáticamente para demostración

## Tecnologías Utilizadas

- C# 12
- WPF (Windows Presentation Foundation)
- .NET 10.0
- XAML para diseño de interfaz

## Autor

Mateo Manchola
