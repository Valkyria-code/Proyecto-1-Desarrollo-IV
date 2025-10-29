# 🧮 Proyecto #1 – Aplicación Calculadora

- Materia: Desarrollo de Software IV
- Profesor: Regis Rivera
- IDE: Visual Studio .NET 2022
- Lenguaje: C# (Windows Forms)
- Base de Datos: Microsoft SQL Server

# 📊 Calculadora Científica - Windows Forms

Aplicación de calculadora desarrollada en C# con Windows Forms que permite realizar operaciones matemáticas básicas y avanzadas, con almacenamiento de historial en base de datos SQL Server.

## 👥 Integrantes del Grupo
- [Nombre del Integrante 1]
- [Nombre del Integrante 2]

**Curso:** Desarrollo de Software IV  
**Profesor:** Regis Rivera  
**Proyecto:** #1 - Aplicaciones Windows Forms con C#

---

## 🎯 Características Principales

### Operaciones Básicas
- ✅ Suma (+)
- ✅ Resta (-)
- ✅ Multiplicación (*)
- ✅ División (/)

### Operaciones Avanzadas
- ✅ Potencia (x^y)
- ✅ Elevar al cuadrado (x²)
- ✅ Raíz cuadrada (√x)
- ✅ Raíz n-ésima (ⁿ√x)
- ✅ Porcentajes (%)

### Funcionalidades Adicionales
- ✅ Soporte para números negativos
- ✅ Soporte para números decimales
- ✅ Uso de paréntesis para operaciones complejas
- ✅ Botón ANS (último resultado)
- ✅ Clear Entry (CE) - Borra el último carácter
- ✅ Clear (C) - Limpia toda la entrada
- ✅ Historial de operaciones almacenado en base de datos
- ✅ Interfaz expandible para visualizar historial

---

## 🗄️ Base de Datos

### Estructura

**Base de datos:** `Calculadora`

**Tabla:** `Historial`

| Campo     | Tipo          | Descripción                    |
|-----------|---------------|--------------------------------|
| Id        | INT (PK)      | Identificador único            |
| Operacion | NVARCHAR(500) | Expresión matemática ingresada |
| Resultado | NVARCHAR(100) | Resultado del cálculo          |
| Fecha     | DATETIME      | Fecha y hora del cálculo       |

### Script de Creación
```sql
CREATE DATABASE Calculadora;
GO

USE Calculadora;
GO

CREATE TABLE Historial (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Operacion NVARCHAR(500) NOT NULL,
    Resultado NVARCHAR(100) NOT NULL,
    Fecha DATETIME DEFAULT GETDATE()
);
```

---

## 🛠️ Tecnologías Utilizadas

- **Lenguaje:** C# (.NET Framework)
- **IDE:** Visual Studio 2022
- **Framework:** Windows Forms
- **Base de Datos:** Microsoft SQL Server
- **ORM:** ADO.NET (SqlClient)

---

## 📋 Requisitos Previos

1. **Visual Studio 2022** o superior
2. **SQL Server** (cualquier versión: Express, Developer, etc.)
3. **.NET Framework 4.7.2** o superior
4. **SQL Server Management Studio (SSMS)** - Opcional para administración de BD

---

## 🚀 Instalación y Configuración

### 1. Clonar el Repositorio
```bash
git clone [URL_DEL_REPOSITORIO]
cd Proyecto_1
```

### 2. Configurar la Base de Datos

#### Opción A: Usando SSMS
1. Abrir SQL Server Management Studio
2. Conectarse a tu instancia de SQL Server
3. Ejecutar el script de creación de la base de datos (ver sección "Script de Creación")

#### Opción B: Desde Visual Studio
1. Abrir **Server Explorer**
2. Crear nueva conexión a SQL Server
3. Ejecutar el script SQL proporcionado

### 3. Configurar la Cadena de Conexión

Editar el archivo `Form1.cs` y modificar la cadena de conexión según tu configuración:
```csharp
string connectionString = @"Server=.;Database=Calculadora;TrustServerCertificate=true;Integrated Security=SSPI;";
```

**Ejemplos de cadenas de conexión:**

- **SQL Server Express local:**
```
  Server=.\SQLEXPRESS;Database=Calculadora;Integrated Security=True;
```

- **Con usuario y contraseña:**
```
  Server=localhost;Database=Calculadora;User Id=tu_usuario;Password=tu_contraseña;
```

### 4. Compilar y Ejecutar

1. Abrir `Proyecto_1.sln` en Visual Studio 2022
2. Restaurar paquetes NuGet si es necesario
3. Presionar **F5** o clic en **Iniciar** para ejecutar

---

## 💡 Uso de la Aplicación

### Operaciones Básicas
1. Ingresa números usando los botones numéricos o el teclado
2. Selecciona una operación (+, -, *, /)
3. Ingresa el segundo número
4. Presiona el botón **=** para obtener el resultado

### Operaciones Avanzadas

#### Raíz Cuadrada
```
Ejemplo: √(16) = 4
1. Presiona el botón √
2. Ingresa el número
3. Cierra el paréntesis
4. Presiona =
```

#### Raíz N-ésima
```
Ejemplo: ⁿ√[3](27) = 3
1. Presiona el botón ⁿ√
2. Ingresa el índice (ej: 3)
3. Cierra con ]
4. Abre paréntesis (
5. Ingresa el número (ej: 27)
6. Cierra paréntesis )
7. Presiona =
```

#### Potencias
```
Ejemplo: 2^3 = 8
1. Ingresa la base (2)
2. Presiona el botón ^
3. Ingresa el exponente (3)
4. Presiona =
```

#### Porcentajes
```
Ejemplo: 100+20% = 120
1. Ingresa 100+20
2. Presiona el botón %
3. Presiona =
```

### Historial
- Presiona el botón **Historial** para expandir la ventana
- Visualiza todas las operaciones realizadas
- Presiona nuevamente para contraer la ventana

### Botón ANS
- Presiona **ANS** para insertar el último resultado calculado en la operación actual

---

## 🏗️ Arquitectura del Código

### Métodos Principales

#### `ProcesarRaices(string expresion)`
Procesa y calcula raíces cuadradas (√) y raíces n-ésimas (ⁿ√) antes de evaluar la expresión completa.

#### `ProcesarPotencias(string expresion)`
Convierte operaciones de potencia (^) a su resultado numérico usando `Math.Pow()`, ya que `DataTable.Compute` no soporta este operador.

#### `GuardarEnHistorial(string operacion, string resultado)`
Almacena cada operación realizada en la base de datos SQL Server.

#### `CargarHistorial()`
Recupera y muestra todas las operaciones guardadas en el DataGridView.

---

## 📸 Capturas de Pantalla

### Calculadora - Vista Normal
![Calculadora Normal](screenshots/calculadora-normal.png)

### Calculadora - Vista con Historial
![Calculadora con Historial](screenshots/calculadora-historial.png)

### Base de Datos
![Base de Datos](screenshots/database.png)

---

## 🔧 Características Técnicas

### Procesamiento de Expresiones
La aplicación utiliza un enfoque híbrido para evaluar expresiones matemáticas:

1. **Pre-procesamiento:** Las operaciones no soportadas por `DataTable.Compute` (potencias, raíces) se calculan primero
2. **Evaluación:** Se utiliza `DataTable.Compute` para evaluar la expresión resultante
3. **Post-procesamiento:** El resultado se almacena y se muestra al usuario

### Manejo de Errores
- Validación de expresiones matemáticas
- Captura de excepciones en operaciones de base de datos
- Mensajes de error descriptivos al usuario

### Interfaz de Usuario
- Diseño responsive con ventana expandible
- Botones organizados por categorías
- Feedback visual inmediato

---

## 🐛 Problemas Conocidos y Soluciones

### DataTable.Compute no soporta operador ^
**Solución:** Se implementó el método `ProcesarPotencias()` que convierte las expresiones con ^ a resultados numéricos antes de evaluar.

### Paréntesis anidados en raíces
**Solución:** Sistema de contador de paréntesis para identificar correctamente los cierres correspondientes.

---

## 📝 Notas del Desarrollo

- Se priorizó la funcionalidad del backend sobre el diseño del frontend
- El código está comentado en secciones complejas para facilitar el mantenimiento
- Se utilizó parametrización en consultas SQL para prevenir inyección SQL
- La aplicación soporta operaciones matemáticas encadenadas complejas

---

## 📚 Referencias

- [Documentación de Windows Forms](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
- [ADO.NET SqlClient](https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient)
- [DataTable.Compute Method](https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable.compute)

---

## 📄 Licencia

Este proyecto fue desarrollado con fines académicos para el curso de Desarrollo de Software IV.

---

## 🤝 Contribuciones

Proyecto desarrollado en colaboración por ambos integrantes del grupo mediante GitHub.

**Historial de Commits:** [Ver en GitHub](enlace-a-commits)

---

**Fecha de Entrega:** [Fecha]  
**Universidad:** [Nombre de la Universidad]
