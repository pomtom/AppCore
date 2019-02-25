# This File will be used for Linux platform

FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
MAINTAINER PramodLawate
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["AppCore/AppCore.csproj", "AppCore/"]
RUN dotnet restore "AppCore/AppCore.csproj"
COPY . .
WORKDIR "/src/AppCore"
RUN dotnet build "AppCore.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AppCore.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AppCore.dll"]