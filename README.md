# 📊 Calculadora Científica - Windows Forms

Aplicación de calculadora desarrollada en C# con Windows Forms que permite realizar operaciones matemáticas básicas y avanzadas, con almacenamiento de historial en base de datos SQL Server.

## 👥 Integrantes del Grupo
- Valerie De Gracia
- Estefany Zambrano

### Otras Especificaciones

- Materia: Desarrollo de Software IV
- Profesor: Regis Rivera
- IDE: Visual Studio .NET 2022
- Lenguaje: C# (Windows Forms)
- Base de Datos: Microsoft SQL Server

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

## 📋 Requisitos Previos

1. **Visual Studio 2022** o superior
2. **SQL Server** (cualquier versión: Express, Developer, etc.)
3. **.NET Framework 4.7.2** o superior
4. **SQL Server Management Studio (SSMS)** - Opcional para administración de BD

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

## 📄 Licencia

Este proyecto fue desarrollado con fines académicos para el curso de Desarrollo de Software IV.

---

## 🤝 Contribuciones

Proyecto desarrollado en colaboración por ambos integrantes del grupo mediante GitHub.

---

**Fecha de Entrega:** 10/29/2025  
**Universidad:** Universidad Tecnológica de Panamá
