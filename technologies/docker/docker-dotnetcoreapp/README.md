# Docker basics with .NET Core app

## Creating a .NET Core Console app using `dotnet` tooling

- Install the dotnet core SDKs and optionally the IDE of choice
- Go to the working folder and do `dotnet new console` which will create a console application
- Build the app - `dotnet build` - which will also restore the necessary packages
- Run the app - `dotnet run` - which will print *Hello World!* in the console

## Creating a `Dockerfile`
- In the Powershell command, run `New-Item Dockerfile`
- Open the `Dockerfile` and start configuring the container
    - Choose the *base image* to start with: `FROM microsoft/dotnet:2.1-sdk`; We will use the *dotnet core 2.1 sdk*
    - Create a *working directory* for the application in docker, say, *console-app*: `WORKDIR /console-app`. This will stand as the directory for the following commands like *RUN, COPY, etc.*
    - Copy the `*.csproj` file to `/app` directory - `COPY *.csproj ./`
    - Restore the packages `RUN ["dotnet", "restore"]`
    - Copy all other files `COPY . .`
    - Build the application in release configuratino to a folder (say, out) - `RUN ["dotnet", "build", "-c", "Release", "-o", "out"]`
    - Set the *Entry point instruction* for the container `ENTRYPOINT [ "dotnet", "run", "out/docker-dotnetcoreapp.dll"]`

## Building the image, and running the container
- Building the image: `docker image build -t console-app-dev .`  
Here we are naming the image `console-app-dev` using `-t`  
```
Sending build context to Docker daemon  187.9kB
Step 1/7 : FROM microsoft/dotnet:2.1-sdk
 ---> c193e46a427c
Step 2/7 : WORKDIR /console-app
Removing intermediate container dd923a2436e5
 ---> e01159f4d12a
Step 3/7 : COPY *.csproj ./
 ---> 07f8d05f3af4
Step 4/7 : RUN ["dotnet", "restore"]
 ---> Running in 637f830e77ca
  Restoring packages for C:\console-app\docker-dotnetcoreapp.csproj...
  Generating MSBuild file C:\console-app\obj\docker-dotnetcoreapp.csproj.nuget.g.props.
  Generating MSBuild file C:\console-app\obj\docker-dotnetcoreapp.csproj.nuget.g.targets.
  Restore completed in 332.59 ms for C:\console-app\docker-dotnetcoreapp.csproj.
Removing intermediate container 637f830e77ca
 ---> c410d9c1eedc
Step 5/7 : COPY . .
 ---> 3411ecbb3c18
Step 6/7 : RUN ["dotnet", "build", "-c", "Release", "-o", "out"]
 ---> Running in 9f6599d1a388
Microsoft (R) Build Engine version 15.7.11.29948 for .NET Core
Copyright (C) Microsoft Corporation. All rights reserved.

  Restoring packages for C:\console-app\docker-dotnetcoreapp.csproj...
  Generating MSBuild file C:\console-app\obj\docker-dotnetcoreapp.csproj.nuget.g.props.
  Generating MSBuild file C:\console-app\obj\docker-dotnetcoreapp.csproj.nuget.g.targets.
  Restore completed in 321.04 ms for C:\console-app\docker-dotnetcoreapp.csproj.
  docker-dotnetcoreapp -> C:\console-app\out\docker-dotnetcoreapp.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:03.63
Removing intermediate container 9f6599d1a388
 ---> 07e7f1385ae1
Step 7/7 : ENTRYPOINT [ "dotnet", "run", "out/docker-dotnetcoreapp.dll"]
 ---> Running in 842204d94bb8
Removing intermediate container 842204d94bb8
 ---> 8204285e7838
Successfully built 8204285e7838
Successfully tagged console-app-dev:latest
```
- Running the container in interactive terminal: `docker container run -it console-app-dev:latest`;  
This will run the container and return the results: 
```
Hello World!
```
- We can see the new image by running `docker images`
```
REPOSITORY             TAG                   IMAGE ID            CREATED             SIZE
console-app-dev        latest                8204285e7838        9 minutes ago       1.8GB
```

## References
[Docker basics with .NET Core](https://docs.microsoft.com/en-us/dotnet/core/docker/docker-basics-dotnet-core)
