# Azure Service Bus
- Provides mechanism for applications or services to interact with each other, either on cloud or on premise

## Types of communication between applications?
- Application and services might need to interact with each other. There are many ways to do it: 
	- Using a **simple queue** to which one application will send, and other receive messages - **has intermediary (broker), one-directional, single recipient**
	- **Advanced queue** with **publish and subscribe** mechanism - **has intermediary (broker), one-directional, multiple subscribers**
	- **Direct message relay** between two application **without a intermediary (broker)**

## Bus vs. Queue (Message Bus vs. Message Queue) - the difference
- **Message bus** lets different applications to communicate with each other *through a shared set of interfaces* via **Pub/Sub mechanism**
```
		||
		||	App B
App A	||
		||
		||	App C
		||
	Message Bus
```
- In **Message Queue**, two or more process share the same *pipe of communication*, *often in* FIFO model which means once a recipient takes the message, it is dequed, *Enque, Deque mechanism*
	- Some queue implementation, allow a process (or application) to filter the messages (on whether or not it should take the message)
```
App A						App 1

App B   -------------------
		-------------------	App 2

App C						App 3
```

## Examples of Bus and Queue implementations

## Azure Service Bus 