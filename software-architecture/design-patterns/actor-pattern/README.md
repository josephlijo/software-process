# Actor Pattern / Actor model
- The **Actor model** is a mathematical and conceptual model for concurrent computation.

## Fundamental concepts
- Like in OOP model, where **everything is an object**, the actor model adopts the philosophy that **everything is an actor**
- An **actor** is a primitive unit of computation which receive a **message** and respond to it by doing some king of **computation**
- It is similar to objects in OOP languages, which receives messages (method calls) and does something with it (the method action); The main difference is that **actors are isolated from each other** and they **never share memory**
- An actor is a **computational entity** which in response to a **message** it receives can concurrently:
  - **Send a finite number of messages to other actors**
  - **Create a finite number of new actors**
  - **designate the behavior to be used for the next message it receives**

- Actor model **decouples the sender from the communications sent**, enabling asynchronous communication
- The **recipient of a message are identified by an address**, sometimes called **mailing address**. Thus an actor can communicate with only those actors whose address it has which they can get from the message it receives, or if the address is for an actor that itself created. 

### References
- [The actor model by Brian Storti](https://www.brianstorti.com/the-actor-model/)
- [Actor model, Wikipedia](https://en.wikipedia.org/wiki/Actor_model)
