# Use the official .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copy the project file and restore dependencies
COPY TodoApp.WebApi.csproj ./
RUN dotnet restore

# Copy the remaining source code and build the app
COPY . ./
RUN dotnet publish -c Release -o /out

# Use the .NET runtime image for the final container
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

# Copy the published application from the build stage
COPY --from=build /out ./

# Expose the application port
EXPOSE 5000
EXPOSE 5001

# Set the entry point
ENTRYPOINT ["dotnet", "TodoApp.WebApi.dll"]
