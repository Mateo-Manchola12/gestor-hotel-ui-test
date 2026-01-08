# Gestor de Hotel - Sistema de Gestión Hotelera

Sistema de gestión hotelera "Galactic Haven" desarrollado en C# con WPF (Windows Presentation Foundation). Este proyecto presenta un tema espacial futurista con un diseño inspirado en una estación espacial intergaláctica.

## 🌌 Características

Este sistema incluye las siguientes vistas principales con tema espacial:

- **Habitaciones**: Galería de tarjetas mostrando habitaciones galácticas (Suite Lunar, Pod Estelar, Galáctica, Observatorio)
- **Huéspedes**: Vista principal con tabla de datos avanzada mostrando reservaciones con estados, avatares y filtros
- **Reservas**: Panel de estadísticas con reservas activas, llegadas y salidas del día
- **Reseñas**: Sistema de calificaciones con tarjetas de reseñas y resumen de ratings
- **Empleados**: Perfiles del personal con tarjetas de empleados

## 🎨 Diseño

El diseño está inspirado en una estación espacial futurista con:
- Paleta de colores cósmicos (púrpura, azul oscuro)
- Barra lateral de navegación
- Avatares con gradientes
- Insignias de estado con códigos de color
- Interfaz moderna con bordes redondeados
- Datos de ejemplo temáticos del espacio

### Paleta de Colores

- **Fondos**: Gradientes oscuros (#1a0a2e, #16213e, #0f3460)
- **Tarjetas**: #1e1536 con bordes #2d2055
- **Acentos**: 
  - Púrpura primario: #5b21b6, #7c3aed
  - Verde éxito: #4ade80
  - Naranja advertencia: #f59e0b
  - Rojo peligro: #991b1b
  - Marrón pendiente: #a16207

## 📋 Requisitos

- .NET 10.0 o superior
- Windows (para ejecutar aplicaciones WPF)
- Visual Studio 2022 o superior (recomendado)

## 🚀 Instalación

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

## 📁 Estructura del Proyecto

```
GestorHotel/
├── Views/                      # Vistas de la aplicación
│   ├── HabitacionesView.xaml   # Vista de habitaciones (galería de tarjetas)
│   ├── HuespedesView.xaml      # Vista principal de huéspedes (tabla de datos)
│   ├── ReservasView.xaml       # Vista de reservas (panel de estadísticas)
│   ├── ResenasView.xaml        # Vista de reseñas (tarjetas de calificaciones)
│   └── EmpleadosView.xaml      # Vista de empleados (perfiles de personal)
├── App.xaml                    # Configuración de la aplicación
├── MainWindow.xaml             # Ventana principal con barra lateral
└── GestorHotel.csproj         # Archivo de proyecto
```

## 💻 Uso

La aplicación cuenta con una barra lateral de navegación que permite acceder a cada sección:

- Haga clic en cualquier opción del menú para navegar entre las diferentes vistas
- La vista de Huéspedes es la predeterminada y muestra la interfaz más completa
- Cada vista incluye datos de ejemplo temáticos del espacio para demostración
- Los controles de navegación están resaltados cuando están activos

### Vistas Detalladas

#### 🏠 Habitaciones
- Diseño de galería de tarjetas
- Muestra tipo de habitación, capacidad, precio
- Indicadores de estado (Disponible, Ocupada, Mantenimiento)

#### 👽 Huéspedes (Vista Principal)
- Tabla de datos completa con avatar
- Barra de botones de acción y filtros
- Insignias de estado codificadas por color
- Controles de paginación
- Efectos hover en filas

#### 📅 Reservas
- Tarjetas de estadísticas (Activas, Llegadas, Salidas)
- Lista de reservas recientes
- Indicadores de estado

#### ⭐ Reseñas
- Resumen de calificación general
- Distribución de estrellas
- Tarjetas de reseñas individuales con avatares

#### 👤 Empleados
- Tarjetas de perfil de empleados
- Información de contacto
- Indicadores de estado

## 🌟 Datos de Ejemplo

El sistema incluye datos de ejemplo temáticos del espacio:

**Huéspedes:**
- Xylara-Torak (Diplomat)
- Zelora Primee (Explorer)
- Captain Vlex (Commander)
- Dr. Zorgul (Scientist)
- Kargox (Trader)

**Personal:**
- Kargox - Gerente de Hospitalidad
- Lyana-2X - Recepcionista
- Vornak - Jefe de Mantenimiento
- Elar-7 - Concierge
- Zara Nova - Chef Ejecutivo

**Habitaciones:**
- Suite Lunar 401
- Pod Estelar 206
- Galáctica 708
- Observatorio 305

## 🛠️ Tecnologías Utilizadas

- C# 12
- WPF (Windows Presentation Foundation)
- .NET 10.0
- XAML para diseño de interfaz

## 📝 Notas

- Este proyecto utiliza datos de ejemplo estáticos para fines de demostración
- No se incluye lógica de negocio ni persistencia de datos
- El diseño está optimizado para pantallas de escritorio
- La aplicación requiere Windows para ejecutarse (limitación de WPF)

## 👨‍💻 Autor

Mateo Manchola

## 📄 Licencia

Este proyecto es de código abierto y está disponible bajo la Licencia MIT.
