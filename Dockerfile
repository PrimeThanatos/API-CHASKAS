# Utiliza la imagen de .NET Core SDK para compilar la aplicación
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copia el archivo csproj e restaura las dependencias
COPY Api-Chascas.csproj .
RUN dotnet restore

# Copia todo el contenido y construye la aplicación
COPY . .
RUN dotnet publish -c Release -o out

# Utiliza la imagen de ASP.NET Core para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out .

# Expone el puerto en el que la aplicación escuchará las solicitudes
EXPOSE 80

# Inicia la aplicación al ejecutar el contenedor
ENTRYPOINT ["dotnet", "Api_Chascas.dll"]
