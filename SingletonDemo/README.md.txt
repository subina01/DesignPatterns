# Singleton Design Pattern Demo in C#

This project demonstrates the implementation of the **Singleton Design Pattern** in C#. The Singleton design pattern ensures that a class has only one instance and provides a global point of access to it. This is useful when you want to control access to shared resources, such as logging or database connections.

## Overview of Singleton Design Pattern

The **Singleton** pattern ensures that a class has only one instance throughout the application. It provides a global point of access to this instance, ensuring that no additional instances of the class are created, even when accessed from different places in the program.

### Key Concepts
1. **Private Static Instance**: A private static instance is created inside the class, which is the only object that can be used.
2. **Private Constructor**: The constructor is private to prevent external instantiation, ensuring that the object can only be created through the static method.
3. **Global Access Point**: The static property `GetInstance` is the global access point to the single instance.

## Code Explanation

- **Singleton Class**:
  - The `Singleton` class is a sealed class, which prevents other classes from inheriting it, ensuring that the Singleton principle is not violated.
  - The `counter` variable tracks how many times the `Singleton` instance is accessed. Each time the `GetInstance` method is called, the counter increments.
  - The `GetInstance` method returns the single instance of the class. It uses **eager loading** (instance is created when the class is loaded), which means the instance is created immediately when the program starts.
  - The `PrintDetails` method simply prints the passed message to the console.

- **Program Class**:
  - The `Program` class contains the `Main` method that demonstrates the Singleton pattern by calling two methods: `PrintEmpDetails()` and `PrintStuDetails()`.
  - Both methods use the same `Singleton` instance to print messages indicating whether it’s from the Employee or Student.

## How to Run the Project

### Prerequisites

- Ensure you have a C# compatible IDE like **Visual Studio** or **Visual Studio Code**.


### Steps to Run

1. Clone the repository:
   ```bash
   git https://github.com/subina01/DesignPatterns/tree/main
   cd SingletonDemo
