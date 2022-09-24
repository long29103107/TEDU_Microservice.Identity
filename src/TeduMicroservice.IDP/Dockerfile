FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TeduMicroservice.IDP/TeduMicroservice.IDP.csproj","TeduMicroservice.IDP/"]
RUN dotnet restore "TeduMicroservice.IDP.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "TeduMicroservice.IDP.csproj" -c Release -o /app/build

FROM build as publish
RUN dotnet publish "TeduMicroservice.IDP.csproj" -c Release -o /app/publish

FROM base as Final
WORKDIR /APP
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet","TeduMicroservice.IDP.dll"]