 # Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia os arquivos de todos os projetos
COPY . .

# Restaura os pacotes
RUN dotnet restore BloodBank.API/BloodBank.API.csproj

# Build do projeto
RUN dotnet publish BloodBank.API/BloodBank.API.csproj -c Release -o /app/publish

# Etapa 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Porta usada pela aplicação
EXPOSE 8080

# Comando de inicialização
ENTRYPOINT ["dotnet", "BloodBank.API.dll"]
