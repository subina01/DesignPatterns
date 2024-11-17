# Singleton Design Pattern in C#

## Overview

This project demonstrates the **Singleton Design Pattern** in C#. The Singleton pattern ensures a class has only one instance throughout the application and provides a global access point for it. It is commonly used for shared resources, such as logging or database connections.

## Features

* Ensures only one instance of the class is created.
* Provides a global access point to the instance.
* Demonstrates thread safety and controlled access to the Singleton instance.

## Project Structure

* `Program.cs`: Main program demonstrating the Singleton pattern.
* `Singleton.cs`: Contains the implementation of the Singleton class.

## How It Works

1. **Singleton Class**:
   * **Private Static Instance**: A private static instance is created to ensure only one instance of the class exists.
   * **Private Constructor**: The constructor is private, preventing external instantiation of the class.
   * **Global Access Point**: The `GetInstance` method provides a global point of access to the single instance.

2. **Program Class**:
   * Demonstrates the usage of the Singleton instance by calling methods that access the shared resource.

## How to Run

1. Clone or copy the project files into a console application.
2. Build and run the project.
3. Observe how the Singleton instance is accessed and reused across different parts of the application.

## Output

When you run the application, the output shows that all calls to `GetInstance` return the same instance, demonstrating the Singleton behavior.

For example:
```plaintext
Employee message: Singleton instance called. Counter: 1
Student message: Singleton instance called. 

