# Vehicle Management System - Design Patterns Implementation

## Descripción del Proyecto

Este proyecto implementa un sistema de gestión de vehículos utilizando patrones de diseño orientados a mejorar la estructura, escalabilidad y mantenibilidad del código. Los patrones de diseño aplicados son **Builder**, **Factory Method** y **Singleton**, siguiendo los principios SOLID para garantizar un código modular y extensible.

El sistema está diseñado para:
- Agregar vehículos como **Mustang**, **Explorer** y **Escape** utilizando diferentes patrones de diseño.
- Gestionar una colección en memoria de vehículos para pruebas, en ausencia de una base de datos.
- Prepararse para futuras extensiones, como la adición de nuevos modelos de vehículos.

---

## Características

### 🚗 **Patrones de Diseño Implementados**

1. **Builder**: Permite crear vehículos con configuraciones flexibles (color, marca, modelo, año, etc.).
2. **Factory Method**: Gestiona la creación de vehículos de forma polimórfica según el modelo solicitado.
3. **Singleton**: Mantiene una única instancia de una colección en memoria para gestionar los vehículos.

### ⚙️ **Principios SOLID Aplicados**
- **Principio de Responsabilidad Única (SRP)**: Cada clase tiene una única responsabilidad.
- **Principio de Abierto-Cerrado (OCP)**: Las clases son abiertas para extensión pero cerradas para modificación.
- **Principio de Inversión de Dependencia (DIP)**: Se utiliza una interfaz (`IVehicleRepository`) para abstraer la lógica de gestión de vehículos.

### 🛠️ **Componentes Clave**
- **Vehículo**: Clase base que modela las propiedades y el comportamiento de los vehículos.
- **Repositorio**: Administra los vehículos utilizando una colección en memoria.
- **Controlador**: Gestiona las solicitudes de agregar vehículos y operaciones relacionadas.

---

## Tecnologías Utilizadas

- **C#** con **ASP.NET Core** para la construcción del backend.
- **Patrones de diseño**: Builder, Factory Method, Singleton.
- **Inyección de dependencias** para desacoplar componentes.
- **Colección en memoria** como solución temporal para la ausencia de una base de datos.

---

## Instalación y Ejecución

1. **Clona el repositorio:**
   ```bash
   git clone https://github.com/tu-usuario/vehicle-management-system.git
   cd vehicle-management-system
   
# Configuración y Uso del Proyecto

## Configura el Entorno de Desarrollo

1. **Instala .NET SDK 6.0 o Superior**  
   Asegúrate de tener instalado el SDK de .NET 6.0 o una versión más reciente. Puedes descargarlo desde [aquí](https://dotnet.microsoft.com/download).

2. **Abre el Proyecto**  
   Abre la solución del proyecto en tu IDE favorito, como Visual Studio, Rider o Visual Studio Code.

3. **Ejecuta el Proyecto**  
   Ejecuta el siguiente comando en la terminal:

# Guía de Uso del Sistema

## Accede al Sistema

Una vez ejecutado el proyecto, visita [http://localhost:5000](http://localhost:5000) en tu navegador para interactuar con el sistema.

---

## Ejemplos de Uso

### Agregar un Vehículo (Mustang)
1. Navega a la ruta `/AddMustang`.
2. El sistema creará un vehículo utilizando el patrón **Factory Method** y lo añadirá a la colección en memoria.

### Listar Vehículos
1. Accede a la página principal (`/`).
2. Podrás visualizar todos los vehículos almacenados en la colección.

---

# Contacto
Email: csanchez.lospinos@gmail.com
cel: +593 98 050 9556



   
