# Proof IT

## Introduction

This task is created with intention to test your Java coding and analytical skills when you're at home, without stress and without any distractions.

Do this task at your own pace.

Please read task description carefully and implement needed functionality.

Write code by keeping in mind the best code writing and testing practices (clean code, clean architecture, good code readibility)

Make sure your code is tested and working according to task description.

Write unit tests.

**Things you may use to achieve the needed result:**

- Java 8+
- jUnit 4+
- Framework or library that supports dependency injection
- Any source on the internet that may help you

**Expected result:**

- Java 8+ project
  - Solution compressed as zip file or hosted on GitHub (preferred)
  - Unit tests for the implementation
  - Please use build tool such as Maven or Gradle
  - Implementation description

## Task description
Bus charter company wants to provide new service for travel agencies – draft ticket price. To receive draft ticket price, following data must be provided:
- List of passengers
- List of luggage items of each passenger
Draft ticket price is calculated as following:
1. Base price for an adult is provided by already existing service returning number from database based on given route (bus terminal name).
2. Child passengers receive 50% discount.
3. Luggage price is 30% of base price.
4. Tax rates are provided by already existing service, which provides list of percentage rates on given day of purchase.
The result of calculation should contain both total price and prices for each individual item.

## Needed functionality
Task is to design input and output data structure and implement functionality for calculating the draft price for a ticket.

API for base price service and tax rate service can be assumed as needed. API must be implemented as web service.
No GUI is needed, passenger data will be sent through the API directly to the methods that will be created.
No database is needed, functionality may not store any data (although it is not prohibited if needed). It should receive passenger data, calculate price, and return result.

**Acceptance criteria:**

Given:
- The base price for route to Vilnius, Lithuania is 10 EUR
- Two passengers:
  - Adult carrying two bags
  - Child carrying one bag
- Tax rates on given date are:
  - VAT = 21

Result should be:
- Ticket prices:
  - Adult (10 EUR + 21%) = 12.10 EUR
  - Two bags (2 x 10 EUR x 30% + 21%) = 7.26 EUR
  - Child (10 EUR x 50% + 21%) = 6.05 EUR
  - One bag (10 EUR x 30% + 21%) = 3.63 EUR
- Total price = 29.04 EUR