# Structural Design Pattern - Implementation

- Structural Design Pattern manages the structure of the object and class for making software reusable and Flexible.

## Adapter Design Pattern

- Structural Pattern that allows to incompactible interface to interact.
- It Wraps an adapter Class Making it compactible with the client interface.

### Problem Statement Used In the Program
-We have a  charger USB-A
-We have a Phone that needs Type C charger

### How this pattern solves the problem

- We create a class for *(OldCharger)*
- We Create an Interface *(ITypeCPhone)*
- We create an Adapter Class which lets oldcharger be compactible with TypeCPhone
- Client Program uses Adapter to charge new Phone With Old Charger

### Expected Output
Using Adapter to Connect
USB-A charger connected


### When To Use This Pattern?
- When old system is no longer compactible with new system.
- When systems have interfaces that mismatch

### Advantages
- Code Reusability
- Flexibility
- Scalability

### Other realife Uses
- Integrating new Api with old one
- Using old gaming controller for new gaming system



