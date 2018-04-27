# Azure Service Fabric - Basic concepts

- Is Microsoft's **container orchestrator** for deploying microservices across a cluster of machines.
- Azure Service Fabric is a **distributed systems platform**
  - for deploying, and managing scalable and reliable microservices and containers.
- These microservices run on a shared pool of machines, known as **cluster**
- Service fabric is a **microservices platform** that gives every microservice (or container) a *unique name* that can either be *stateless or stateful*.
- It **hosts microservices inside containers** that are deployed and activated across the **Service Fabric Cluster**
- Apps build on Azure Service Fabric:
  - Skype for Business
  - Azure SQL Database
  - Cortana
  - Microsoft Power BI
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
    - Managing downtimes
    - Scaling in and out
- It is another step forward in `Microservice design`

### Azure Functions
- It is another option to create `Microservices`
- Like a regular C# function, we can create a function which will be triggered upon an event
- This function in turn becomes a micro-micro service
- We don't need to provision a server for this solution - and hence it is a `serverless technology`
- It can be thought of as an event-driven observer pattern

## Stateful and Stateless microservices
- Stateless microservice do not maintain a mutable state outside a request and its response from the service. Example of such services:
  - Protocol gateways
  - Web proxies
  - Azure cloud services worker roles
- Stateful microservices maintain a mutable state beyond the request and its response. For example,
   - user accounts
   - databases
   - devices
   - shopping carts
   - Queues

## Programming Models in Azure Service Fabric
- Three main approaches to create a Microservice in Service Fabric
    - **Reliable Services**
        - Similar to a windows service or Linux daemon application
        - Think of them as a Console application and we are not required to use Service Fabric tools
        - There are two types - **Stateless** and **Stateful**
        - Stateless are more of like console applications in look and behavior
        - Stateful have their own transactional replicated storage
    - **Reliable Actors**
        - Implementation of [`Virtual Actor pattern`](https://www.microsoft.com/en-us/research/project/orleans-virtual-actors/?from=http%3A%2F%2Fresearch.microsoft.com%2Fen-us%2Fprojects%2Forleans%2F)
        - Built on top of **Stateful reliable services**
    - **Guest Executables**
        - Let's any application written in any languages to work with Service Fabric as a service without modifying them
        - Treated as **stateless services**
        - Useful for deploying an existing executable to Service Fabric

## Reliable Services
- **Is a programming model** in Azure Service Fabric
- Two types of **reliable services** are: **stateful reliable service** and **stateless reliable service**
- This model helps make the application:
  - **Reliable**: Service stays up even in unreliable situation or network issues. For *stateful service*, the state is preserved.
  - **Available**: Your service is *reachable and responsive*. Service fabric maintains your desired number of running copies.
  - **Scalable**: No tight coupling to hardware service instances can be increased / decreased based on needs.
  - **Consistent**: Information stored in Service fabric is consistent.
- In Azure Service fabric terminology, **any service which runs on the background is a reliable service**


### References
- [.NET application in Azure Service Fabric](https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-quickstart-dotnet)
- [Try Service Fabric - using Party Clusters](https://try.servicefabric.azure.com/)
- [Reliable Services](https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-reliable-services-introduction)
