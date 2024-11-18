# Behavioral Design Pattern - Implementation
- Behavioral Design Patterns focus on communication between objects to achieve specific behavior, often through the use of observers or event-driven mechanisms.

## Observer Design Pattern
- A **Behavioral Pattern** where one object (the subject) notifies a list of dependent objects (observers) about state changes, typically by calling one of their methods.

### Problem Statement Used In the Program
- We have a **WeatherStation** that updates its temperature.
- We want to notify different **MobileAppUser** instances about the changes in the temperature.

### How This Pattern Solves the Problem
- We create a **WeatherStation** class (Subject) that maintains a list of observers (MobileAppUser).
- The **MobileAppUser** class (Observer) updates whenever the temperature changes.
- The client program adds multiple users as observers, sets the temperature, and removes observers when needed.

### Expected Output

User1 Heres your Weather Update: Temperature is 25.5 degree Celsius
User2 Heres your Weather Update: Temperature is 25.5 degree Celsius
User2 Heres your Weather Update: Temperature is 30.0 degree Celsius

## When To Use This Pattern?
- When you need to notify multiple objects about an event or state change without tight coupling between the subject and observers.
- When multiple objects need to be updated simultaneously without needing to know who or what is being updated.
Advantages
- The subject and observers are loosely coupled, making the system more flexible.
- Flexibility
- Scalability