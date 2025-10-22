Cómo abrir y compilar en Visual Studio Code:
1. Abrir la carpeta del proyecto en Visual Studio Code.
2. Tener instalado el SDK .NET 9.0 para Windows (o ajustar TargetFramework en el .csproj a la versión instalada).
3. En terminal: dotnet restore
4. dotnet build
5. dotnet run
Nota: Este proyecto simula las operaciones de base de datos con un DataSet en memoria. En una implementación real,
debe conectarse a SQL Server y reemplazar los métodos procesar/mantenimiento_usuarios por transacciones a la base de datos.