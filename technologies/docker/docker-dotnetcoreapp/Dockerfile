FROM microsoft/dotnet:2.1-sdk

WORKDIR /console-app
COPY *.csproj ./
RUN ["dotnet", "restore"]

COPY . .
RUN ["dotnet", "build", "-c", "Release", "-o", "out"]

ENTRYPOINT [ "dotnet", "run", "out/docker-dotnetcoreapp.dll"]