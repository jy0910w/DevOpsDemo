# 第一階段：Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# 複製所有檔案
COPY . .
RUN dotnet restore DevOpsDemo/DevOpsDemo.csproj
RUN dotnet publish DevOpsDemo/DevOpsDemo.csproj -c Release -o /app/publish

# 第二階段：Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_ENVIRONMENT=Development
EXPOSE 8080
ENTRYPOINT ["dotnet", "DevOpsDemo.dll"]

