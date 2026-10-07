# Prueba TFT — ASP.NET Web Forms

Práctica en C# con ASP.NET Web Forms, .NET Framework 4.8 y Microsoft Access.

## Contenido

- `PruebaTFT.sln`: solución de Visual Studio.
- `PruebaTFT/Practica.aspx`: interfaz y controles de servidor.
- `PruebaTFT/Practica.aspx.cs`: saludo, consulta SELECT e inserción INSERT.
- `PruebaTFT/App_Data/PruebaTFT.accdb`: base de datos de ejemplo con la tabla Personas.

## Abrir y ejecutar

1. Abre `PruebaTFT.sln` en Visual Studio 2022 con la carga de trabajo Desarrollo de ASP.NET y web y las herramientas de .NET Framework 4.8.
2. Necesitas el proveedor Microsoft ACE OLEDB 12.0 compatible con IIS Express de 64 bits, configurado en el proyecto.
3. Selecciona `Practica.aspx` como página de inicio y ejecuta con IIS Express.
4. Prueba Saludar, Ver personas y Guardar persona.

La base de datos se localiza mediante `Server.MapPath`, dentro de `App_Data`. Guardar persona modifica esta base de datos de práctica.

El repositorio excluye los archivos locales de Visual Studio, resultados de compilación y archivos temporales.
