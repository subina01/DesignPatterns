# Builder Design Pattern in C#

## Overview

This project demonstrates the **Builder Design Pattern** in C#. The Builder pattern is used to construct complex objects step by step. 
It allows you to produce different types and representations of an object using the same construction process. This pattern also adheres 
to the **Single Responsibility Principle** by separating the construction logic from the representation.

## Features

* Implements the **Builder Design Pattern** for constructing `CellPhone` objects.
* Provides flexibility to configure various properties such as:
  - Processor
  - Screen Size
  - Battery
  - Camera
  - Brand
* Demonstrates the separation of object construction and representation.

## Project Structure

* `Program.cs`: Entry point for the application, showcasing the Builder pattern in action.
* `CellPhone.cs`: Defines the `CellPhone` class, the complex object being constructed.
* `ICellPhoneBuilder.cs`: The builder interface that defines the construction steps.
* `SamsungPhoneBuilder.cs`: A concrete builder for creating Samsung phones.
* `Shop.cs`: The **Director** class that co-ordinates the building process.

## How It Works

1. **Product (CellPhone)**:
   * Represents the complex object being constructed.
   * Contains properties like Processor, ScreenSize, Battery, Camera, and Brand.
   * Overrides `ToString()` to provide a readable representation of the object.

2. **Builder Interface (ICellPhoneBuilder)**:
   * Defines methods for setting different properties of the product.

3. **Concrete Builder (SamsungPhoneBuilder)**:
   * Implements the builder interface to construct and configure a specific type of product (`Samsung` phones in this case).

4. **Director (Shop)**:
   * Encapsulates the construction logic for building a product.
   * Calls the builder's methods to configure the product step by step.

5. **Main Program**:
   * Demonstrates the creation of a `CellPhone` using the `Shop` class and the `SamsungPhoneBuilder`.

## How to Run

1. Clone or copy the project files into a console application.
2. Build and run the project.
3. Observe the output, which demonstrates the creation of a `CellPhone` object using the Builder pattern.

### Example Output

Processor: , ScreenSize: 4, battery: 0, camera: 0
