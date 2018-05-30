# Moving MVC App to Containers

- Base reference: https://docs.microsoft.com/en-us/aspnet/mvc/overview/deployment/docker-aspnetmvc
- See the `Dockerfile` which uses `microsoft/aspnet` image
- Publish
    - To file system to the path relative to the project - `bin/Release/PublishOutput`
    - Precompiling option can be used for performance
- Build the image
    - Note that there is no `ENTRYPOINT` specified in the `Dockerfile`. We don't need one as when running Windows Server with IIS, IIS process is the entry point (which is configured to start in the `microsoft/aspnet` base image)
    - To build the image, run: `docker build -t mvcapp .` from the location where `Dockerfile` is located
- Start the container
    - `docker run -d --name myapp mvcapp` - we are naming the container
- Run in browser
    - We need to identity the location where applicatin is (it will not work with localhost - at least for now - will be fixed later by docker). Run the below command to understand the IP address and navigate to it to see the application running; 
    ```
    docker inspect -f "{{ .NetworkSettings.Networks.nat.IPAddress }}" myapp
    ```
- Cleaning up
    - `docker stop myapp` to stop the container
    - `docker rm myapp` to remove the container