# Factory Design Pattern in C#

## Overview
This project demonstrates the **Factory Design Pattern** in C#, which abstracts the process of object creation, promoting loose coupling.

## Features
* Implements an abstract factory and concrete products.
* Provides three types of products:
  * Vehicle
  * Food
  * Clothes
* Encapsulates object creation logic.

## Project Structure
* `Program.cs`: Main program for demonstrating factory usage.
* `Factory.cs`: Factory and SubFactory implementations.
* `Product.cs`: Abstract product interface and concrete product implementations.

## How to Run
1. Clone or copy the project files into a console application.
2. Build and run the project.
3. Modify the input in `ProductionProcess` to test different products.

## Output
* Input: `"Product1"` → Output: `Vehicle`
* Input: `"Product2"` → Output: `Food`
* Input: `"Product3"` → Output: `Clothes`

## Benefits
* Encapsulation of object creation logic.
* Loose coupling between client code and concrete implementations.
* Easy to extend by adding new products.
