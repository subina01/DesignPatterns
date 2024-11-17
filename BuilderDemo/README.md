# BuilderDemo - Builder Design Pattern in C#

This project demonstrates the **Builder Design Pattern** used to construct complex objects in a step-by-step manner. In this example, we construct a **CellPhone** with various configurable properties such as **processor**, **screen size**, **battery**, and **camera**. The Builder pattern allows for flexible object construction without needing to specify all parameters at once.

## Design Pattern Used

### Builder Design Pattern

The **Builder** pattern is used to separate the construction of a complex object from its representation. This allows the same construction process to create different representations (e.g., different phone models). The key components of the Builder pattern in this example include:

- **Director (Shop)**: Responsible for managing the construction process and deciding the order of construction steps.
- **Builder (ICellPhoneBuilder and SamsungPhoneBuilder)**: Defines the steps required to build the product. The concrete builder (`SamsungPhoneBuilder`) implements these steps for constructing a Samsung phone.
- **Product (CellPhone)**: The final product that is built using the builder.

## Key Classes and Methods

### Shop Class (Director)

- **Purpose**: The `Shop` class is the director that orchestrates the phone construction process. It constructs a Samsung phone by calling the appropriate builder methods.
- **Key Methods**:
  - `ConstructSamsungPhone()`: Uses the builder to construct a Samsung phone by setting various phone attributes like screen size, battery, etc.

### ICellPhoneBuilder Interface (Builder)

- **Purpose**: Defines the abstract methods that every builder (like `SamsungPhoneBuilder`) must implement.
- **Key Methods**:
  - `GetPhone()`: Returns the final constructed `CellPhone` object.
  - `SetBattery(int battery)`: Sets the battery of the phone.
  - `SetCamera(int camera)`: Sets the camera of the phone.
  - `SetOs(string processor)`: Sets the processor of the phone.
  - `SetScreenSize(double screenSize)`: Sets the screen size of the phone.

### SamsungPhoneBuilder Class (Concrete Builder)

- **Purpose**: A concrete implementation of the `ICellPhoneBuilder` interface that builds a Samsung phone with specific attributes (processor, screen size, battery, camera).
- **Key Methods**:
  - Implements all builder methods (`SetBattery()`, `SetCamera()`, `SetOs()`, `SetScreenSize()`).
  - Returns a `CellPhone` object by using the `GetPhone()` method.

### CellPhone Class (Product)

- **Purpose**: The final product that is constructed. It contains various attributes such as processor, screen size, battery, camera, and brand.
- **Constructor**: Takes the processor, screen size, battery, camera, and brand as parameters to initialize a `CellPhone`.
- **ToString()**: Overrides the `ToString()` method to provide a string representation of the phone's details.

## How the Application Works

1. **Director (Shop)**: The `Shop` class calls the builder (`SamsungPhoneBuilder`) and orchestrates the construction of the phone.
2. **Builder (SamsungPhoneBuilder)**: The `SamsungPhoneBuilder` sets the specific properties of the phone, such as screen size, processor, battery, and camera.
3. **Product (CellPhone)**: The `CellPhone` is built step by step by the builder and is returned to the `Shop` for use.

### Expected Output

Processor: , ScreenSize: 4, battery: 0, camera:0


## Benefits of the Factory Design Pattern

- **Encapsulation**: The Factory pattern encapsulates the object creation process and hides the complexity from the client.
- **Flexibility**: New products can be added without changing the client code. The client interacts only with the abstract factory.
- **Maintainability**: As product creation logic is centralized in the factory, it is easier to maintain and extend.
- **Loose Coupling**: The client is decoupled from the concrete classes and interacts with abstract product interfaces.
