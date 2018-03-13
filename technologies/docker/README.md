## What is Docker?

- Docker is a company which created the open-source project 'docker'
- We create our application in our favorite language which runs on our supported operating system. Now, we want this application to be deployed into a different machine.  
What do we need to take care of in this case? Making sure that the OS is supported, making sure that the prerequisite software is installed in that OS, etc.
- Docker is a cute way to isolate our application development from underlying system and applicaion prerequisite.
- Docker lets us do this by containerizing our application and telling docker via configuration on what our applicaitons system requirements are. Doing so, we can easily take our application into different 'machines' (in docker terms, it is an image).

### In essence
- Docker is a technology for automating the build, and deployment of applications
- Docker allows us to package our application into a standardized unit - called, 'container'
- Containers are portable, and self-sufficient 
- Container is a stripped down version of an Operating system 
- These 'containers' can run on the cloud or on-premises and on different operating systems
- Docker helps us not to worry about the underlying sofware (OS) where our software runs
- We can get our Node.js or .NET or Java application or a combination of a all applicaiton into a container
- Our package - the container - should now run on top of the OS (or a combination of OS + other software) - and that software is called the image. 
- In essence - docker can be used to build, deploy, and run containers for software applications which can run on different images

## How docker does this automation on platform neutral way? 
- Docker does so by making itself work on top of the operating system kernel
-  