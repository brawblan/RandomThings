FROM mcr.microsoft.com/dotnet/sdk:10.0-noble AS build
WORKDIR /RandomThings

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:10.0@sha256:7feda9a96737a8c268cc7636c92d0efda3512ef019e3c409dd97c7c9ae9e2bdb
WORKDIR /RandomThings
COPY --from=build /RandomThings/out .
ENTRYPOINT ["dotnet", "DotNet.Docker.dll"]