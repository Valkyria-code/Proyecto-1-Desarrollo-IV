# 🌐 Web API Calculadora - REST API con C#

API REST desarrollada en ASP.NET Web API que expone los datos almacenados en la base de datos de la calculadora del Proyecto #1, permitiendo consultar y crear cálculos mediante peticiones HTTP.

## 👥 Integrantes del Grupo
- Valerie De Gracia
- Estefany Zambrano

**Curso:** Desarrollo de Software IV  
**Profesor:** Regis Rivera  
**Proyecto:** #2 - API REST con C#

---

## 🎯 Descripción del Proyecto

Este proyecto implementa una Web API RESTful que permite:
- Consultar todos los cálculos almacenados
- Filtrar operaciones por tipo (suma, resta, multiplicación, división)
- Buscar cálculos con resultados mayores a un valor específico
- Crear nuevos cálculos mediante POST

La API se conecta a la misma base de datos SQL Server utilizada por la calculadora de Windows Forms del Proyecto #1, permitiendo que diferentes aplicaciones accedan a los datos de forma estandarizada.

---

## 🏗️ Arquitectura del Sistema

```
┌──────────────────┐
│  Calculadora     │
│  Windows Forms   │ (Proyecto #1)
│  (Cliente 1)     │
└────────┬─────────┘
         │ INSERT
         ↓
┌─────────────────────────┐
│    SQL Server           │
│    Base de datos:       │
│    Calculadora          │
│    Tabla: Historial     │
└────────┬────────────────┘
         │ SELECT/INSERT
         ↓
┌──────────────────┐
│   Web API REST   │ (Proyecto #2)
│   (ASP.NET)      │
└────────┬─────────┘
         │ HTTP/JSON
         ↓
┌──────────────────┐
│  Postman /       │
│  Aplicaciones    │
│  Consumidoras    │
│  (Clientes N)    │
└──────────────────┘
```

---

## 📋 Endpoints Disponibles

### **Operaciones GET**

| Método | Endpoint | Descripción |
|--------|----------|-------------|
| GET | `/api/calculos` | Obtiene todos los cálculos |
| GET | `/api/calculos/sumas` | Obtiene solo sumas |
| GET | `/api/calculos/restas` | Obtiene solo restas |
| GET | `/api/calculos/multiplicaciones` | Obtiene solo multiplicaciones |
| GET | `/api/calculos/divisiones` | Obtiene solo divisiones |
| GET | `/api/calculos/mayores/{valor}` | Obtiene cálculos con resultado > valor |

### **Operaciones POST**

| Método | Endpoint | Descripción |
|--------|----------|-------------|
| POST | `/api/calculos` | Crea un nuevo cálculo |

---

## 🔧 Tecnologías Utilizadas

- **Framework:** ASP.NET Web API (.NET Framework 4.7.2+)
- **IDE:** Visual Studio 2022
- **Base de Datos:** Microsoft SQL Server
- **Acceso a Datos:** ADO.NET (System.Data.SqlClient)
- **Formato de Intercambio:** JSON
- **Herramienta de Pruebas:** Postman

---

## 🗄️ Base de Datos

### Configuración
- **Base de datos:** `Calculadora` (misma del Proyecto #1)
- **Tabla:** `Historial`

### Estructura de la tabla

| Campo | Tipo | Descripción |
|-------|------|-------------|
| Id | INT (PK, Identity) | Identificador único |
| Operacion | NVARCHAR(500) | Expresión matemática |
| Resultado | NVARCHAR(100) | Resultado del cálculo |
| Fecha | DATETIME | Fecha y hora del cálculo |

---

## 💻 Arquitectura del Código

### Patrón de Diseño: Three-Layer Architecture

```
┌─────────────────────┐
│   CalculosController│ ← Capa de Presentación
│   (API Controller)  │   - Recibe peticiones HTTP
│                     │   - Valida entrada
│                     │   - Retorna respuestas JSON
└──────────┬──────────┘
           │
           ↓
┌─────────────────────┐
│  CalculoService     │ ← Capa de Lógica de Negocio
│  (Business Logic)   │   - Procesa datos
│                     │   - Ejecuta consultas SQL
│                     │   - Maneja transacciones
└──────────┬──────────┘
           │
           ↓
┌─────────────────────┐
│   SQL Server        │ ← Capa de Datos
│   (Historial)       │   - Almacena información
│                     │   - Ejecuta queries
└─────────────────────┘
```

### Componentes Principales

#### **1. CalculosController (Controllers)**
- Maneja las peticiones HTTP
- Define los endpoints con atributos `[Route]`
- Retorna respuestas en formato JSON
- Códigos HTTP: 200 (OK), 201 (Created), 400 (Bad Request), 500 (Error)

#### **2. CalculoService (Services)**
- Implementa la lógica de acceso a datos
- Usa ADO.NET para comunicarse con SQL Server
- Operaciones asíncronas con `async/await`
- Prevención de SQL Injection con parámetros

#### **3. Modelos (Models)**
- **Calculo:** Representa una fila de la tabla Historial (para GET)
- **CalculoRequest:** Representa los datos para crear un cálculo (para POST)

---

## 📊 Características Técnicas

### Programación Asíncrona
- Todos los métodos usan `async/await`
- Mejora el rendimiento y escalabilidad
- Permite manejar múltiples peticiones simultáneas

```csharp
public async Task<IHttpActionResult> ObtenerTodos()
{
    var calculos = await _calculoService.ObtenerTodosAsync();
    return Ok(calculos);
}
```

### Separación de Responsabilidades
- **Controller:** Solo maneja HTTP
- **Service:** Solo maneja lógica de negocio y BD
- **Model:** Solo representa datos

### Filtrado Inteligente
Los endpoints de tipo de operación usan un método compartido:
```csharp
private async Task<List<Calculo>> ObtenerPorOperadorAsync(string operador)
```
Esto evita duplicación de código (DRY principle).

---

## 🐛 Manejo de Errores

| Código | Significado | Cuándo se retorna |
|--------|-------------|-------------------|
| 200 | OK | Operación exitosa |
| 201 | Created | Cálculo creado exitosamente |
| 400 | Bad Request | Datos de entrada inválidos |
| 500 | Internal Server Error | Error en el servidor/BD |

---

## 🤝 Contribuciones

Proyecto desarrollado en colaboración por ambos integrantes del grupo mediante GitHub.
