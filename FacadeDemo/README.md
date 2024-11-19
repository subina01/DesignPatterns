# Structural Design Pattern - Implementation

- Structural Design pattern is a pattern which manages the structure of Objects and Classes in order to increase the flexibility and reusability of classes.
- 
## Facade Design Pattern

- A **Structural Pattern** Where multiple complex subsystems functionality made accessible through simple Interface. This pattern hides the system complexity from the user and gives easy to use interface to the user.

### Problem Statement Used In the Program

- We are developing a financial System Which handles transaction, Loan Information, Customer Data.
- Thus the backend of the system may contain large no of class for services **AccountService**, **Loan Service**,**CustomerService**
- Now the problem is user has to know the every detail of those services to work with the system

### How This Pattern Solves the Problem

- We create a *BankFacade* Class Which hides the complexity of the complex subsystem classes.
- providing a single easy to use Interface. 
- The client program access the subsystem using that interface.
- 
### Expected Output

-Loan Application Processing
-Loan Approved!!

## When To Use This Pattern?

-To Simplify Interaction with Complex Subsystems
-To Provide Unified Access to Multiple Subsystems
-To Hide Subsystem Implementation Details

## Real Life Uses

-- Video Streaming Platforms
-- Travel Booking
-- Operating System
-- Ecommerce Platform

