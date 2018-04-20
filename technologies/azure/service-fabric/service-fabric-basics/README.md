# Azure Service Fabric - Basic concepts

## What is it?
- Azure Service Fabric is focused on `Microservice` applications
- It is for **Microservice applications running on containers** (+ also supports process)
- It is a **platform to package, deploy, and manage microservices and containers** 
- Idea is to ease out the **infrastructure problems** and focus on making the microservice app **scalable, reliable, and manageable**

## What are the current options for building Microservice applications on Azure?

### Azure Container Services
- Microsoft's implementation of open-source container technologies based on `docker`
- Helps automate the running of containers in Azure cloud  
- Docker is a container technology alone, but there are more to it - like managing containers in terms of deployment, scaling, healing, configuration, storage, networking, etc. which makes the application useful.
- This leads us to the need of **container orchestrator** 
    - Popular Container Orchestrators
        - Docker Swarm
        - DC/OS
        - Kubernetes
- Azure supports all of these

### Azure Service Fabric
- Is all about `Microservices`
- Helps create scalable applications working on hundreds of machines in a cluster
- Helps solve:
    - Communication between microservices
    - Service discovery
    - Telemetry
    - Provision and upgrade
    - Testing microservices locally
    - Manging downtimes
    - Scaling in and out
- It is another step forward in `Microservice design`

### Azure Functions
- It is another option to create `Microservices`
- Like a regular C# function, we can create a function which will be triggered upon an event
- This function in turn becomes a micro-micro service
- We don't need to provision a server for this solution - and hence it is a `serverless technology`
- It can be thought of as an event-driven observer pattern

## Programming Models in Azure Service Fabric
- Three main approaches to create a Microservice in Service Fabric
    - **Reliable Services**
        - Simliar to a windows service or Linux daemon application
        - Think of them as a Console application and we are not required to use Service Fabric tools
        - There are two types - **Stateless** and **Stateful** 
        - Stateless are more of like console applications in look and beahavior
        - Stateful have their own transactional replicated storage
    - **Reliable Actors**
        - Implementation of [`Virtual Actor pattern`](https://www.microsoft.com/en-us/research/project/orleans-virtual-actors/?from=http%3A%2F%2Fresearch.microsoft.com%2Fen-us%2Fprojects%2Forleans%2F)
        - Built on top of **Stateful reliable services**
    - **Guest Executables**
        - Let's any application written in any languages to work with Service Fabric as a service without modifying them
        - Treated as **stateless services**
        - Useful for deploying an existing executable to Service Fabric

## Reliable Services
