# FactoryDemo - Factory Design Pattern in C#

## Overview

This project demonstrates the **Factory Design Pattern** in C#. The Factory Design Pattern is a creational design pattern that provides a way to create objects without specifying the exact class of object that will be created. Instead, a factory method is used to instantiate and return an object of a specific type based on given criteria.

The program simulates a factory producing different types of products (such as vehicles, food, and clothes) based on a string input.

## Features

- Demonstrates how the Factory Design Pattern can be implemented in C#.
- Abstract product interface to define common methods for all product types.
- Concrete product classes representing various types of products.
- A factory class that creates products based on specific input.
- Example of how to use the factory method to retrieve products and call methods on them.

## Project Structure

1. **ProductionFactory Interface**: 
   - Defines the method `ProducedGood()` that all concrete products must implement.

2. **Concrete Products**:
   - `Product1`: Produces a **Vehicle**.
   - `Product2`: Produces **Food**.
   - `Product3`: Produces **Clothes**.

3. **Factory Class**:
   - An abstract class containing the `ProductionProcess()` method to create products based on input.

4. **SubFactory Class**:
   - A concrete subclass of `Factory`, implementing the `ProductionProcess()` method to return the appropriate product.

5. **Program Class**:
   - The entry point of the application, demonstrating the usage of the Factory Design Pattern.

## Example Output

Running the program will produce output based on the product type selected:

Food
Vehicle
Clohes

## Benefits of the Factory Design Pattern

- **Encapsulation**: The Factory pattern encapsulates the object creation process and hides the complexity from the client.
- **Flexibility**: New products can be added without changing the client code. The client interacts only with the abstract factory.
- **Maintainability**: As product creation logic is centralized in the factory, it is easier to maintain and extend.
- **Loose Coupling**: The client is decoupled from the concrete classes and interacts with abstract product interfaces.
