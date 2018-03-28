# Why Docker?
- We create our application in our favorite language which runs on our supported operating system. Now, we want this application to be deployed into a different machine.  
What do we need to take care of in this case? Making sure that the OS is supported, making sure that the prerequisite software is installed in that OS, etc.
- Docker is a cute way to isolate our application development from underlying system and application prerequisite.
- Docker lets us do this by containerizing our application and telling docker via configuration on what our applications system requirements are. Doing so, we can easily take our application into different 'machines'.

## What is Docker : A high-level overview
- Docker is a company which created the open-source project 'docker'
- Docker is a technology for automating the build, and deployment of applications
- Docker does this by allowing us to package our application into a standardized unit - called, 'container'
- Containers are portable, and self-sufficient
- These 'containers' can run on the cloud or on-premises and on different operating systems
- Docker helps us not to worry about the underlying software (OS) where our software runs

## How docker does this automation on platform neutral way?
- Docker does so by making itself work on top of the operating system kernel

## What are containers?
- Containerization is an approach to software development in which an application or service, its dependencies, and its configuration are packaged together as a container image.
- We can then test the containerized application as a unit and deploy it as a container image instance to the host operating system.
- Similar to the shipping industry terminology of containers to move goods via different mediums like train, ship or truck regardless of the cargo within them; the software containers are a standard unit of software that can contain different code and dependencies.
- Placing software into containers makes it possible for developers and IT professionals to deploy those containers across environments with little or no modification.
- Containers also isolate applications in a shared operation system.
- Containerized applications run on top of the container host, which in turn runs on the OS.
- They have less footprint than VM images.
- Each container can run an entire application or service.
- Another advantage of container is that we can scale-out our application, by instantiating an image (creating a container) on the host OS.

## Docker Container vs. Image vs. Host vs. Daemon vs. Client vs. Registry
- **Image**: The file system and configuration of our application. Instantiating an image creates a container.
- **Container**: Running instances of Docker images. Containers run the actual application. Container includes an application and all its dependencies.
- **Host**: Is any machine that is running the `Docker daemon` service.
- **Docker daemon**: Is a background service running on the host that manages building, running, and distributing docker containers.
- **Docker client**: The CLI tooling that allows us to interact with the Docker Daemon.
- **Registry**: Stores the docker images. Docker manages a public registry via [Docker Hub](https://hub.docker.com/)  

[Docker Terminology](https://docs.microsoft.com/en-us/dotnet/standard/containerized-lifecycle-architecture/docker-terminology) from Microsoft Docs  

[Containers, Images, and Registries](https://docs.microsoft.com/en-us/dotnet/standard/containerized-lifecycle-architecture/docker-containers-images-and-registries) from Microsoft Docs  

## Docker architecture
![Docker Architecture](https://docs.docker.com/engine/images/architecture.svg "Docker Architecture (Source: docs.docker.com")  

[Docker Architecture](https://docs.docker.com/engine/docker-overview/#docker-architecture) from Docker docs

## VM's vs. Docker containers
![VM's vs. Docker containers](https://docs.microsoft.com/en-us/dotnet/standard/containerized-lifecycle-architecture/media/image3.png "Comparison of traditional VMs to Docker containers (Source: https://docs.microsoft.com/en-us/dotnet/standard/containerized-lifecycle-architecture/what-is-docker)")

## Docker Hub and Container registries

## Container orchestration

### References and Credits
- [Docker Architecture](https://docs.docker.com/engine/docker-overview/#docker-architecture)
- [Containerized Lifecycle Architecture](https://docs.microsoft.com/en-us/dotnet/standard/containerized-lifecycle-architecture/)
