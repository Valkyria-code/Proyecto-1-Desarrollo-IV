# 🧮 Proyecto #1 – Aplicación Calculadora

- Materia: Desarrollo de Software IV
- Profesor: Regis Rivera
- IDE: Visual Studio .NET 2022
- Lenguaje: C# (Windows Forms)
- Base de Datos: Microsoft SQL Server

## 📘 Descripción General

Este proyecto consiste en el desarrollo de una aplicación tipo calculadora creada con Windows Forms en C#, que permite realizar diversas operaciones matemáticas básicas y almacenar los cálculos realizados en una base de datos de Microsoft SQL Server.

El objetivo principal es reforzar los conocimientos de programación en C#, conexión a bases de datos y trabajo colaborativo mediante GitHub.

## ⚙️ Funcionalidades Principales

La aplicación permite al usuario realizar las siguientes operaciones:

- ➕ Suma

- ➖ Resta

- ✖️ Multiplicación

- ➗ División

- 🧹 Borrar (C / CE)

- ² Número elevado al cuadrado

- √ Raíz cuadrada

- 🔢 Números negativos y decimales

## 💾 Integración con Base de Datos

Cada cálculo realizado se guarda automáticamente en una tabla dentro de una base de datos SQL Server.

El usuario podrá visualizar el historial de operaciones mediante un botón opcional “Mostrar cálculos”.

### Ejemplo de estructura de tabla:

Campo	Tipo de dato	Descripción
Id	INT (PK, Identity)	Identificador único
Operación	VARCHAR(50)	Tipo de operación realizada
Valor1	FLOAT	Primer valor
Valor2	FLOAT	Segundo valor (si aplica)
Resultado	FLOAT	Resultado del cálculo
Fecha	DATETIME	Fecha y hora del cálculo

## 🧩 Aspectos Técnicos

- Aplicación desarrollada con Windows Forms.

- Integración directa con Microsoft SQL Server.

- Código estructurado en capas (interfaz, lógica y conexión a base de datos).

- Énfasis en el back-end más que en el diseño visual.

- Repositorio único y colaborativo en GitHub.

## 🧠 Funcionalidades Opcionales

El proyecto puede incluir funcionalidades adicionales, como:

- 🧮 Cálculos científicos (por ejemplo, seno, coseno, tangente).

- 🧾 Botón “Mostrar cálculos” que despliega en pantalla el historial guardado en la base de datos.

- 👩‍💻 Equipo de Desarrollo

## Integrantes del grupo:

- Valerie De Gracia

- Estefany Zambrano

(Ambos colaboraron en el desarrollo del código y la gestión del repositorio en GitHub.)

## 🧱 Presentación del Proyecto

Durante la exposición, se presentarán los siguientes elementos:

- 📊 Diagrama de base de datos.

- 🖼️ Capturas de pantalla de la aplicación en funcionamiento.

- 💬 Explicación general del código fuente.

- 💻 Demostración funcional de la calculadora y su conexión con la base de datos.
