# Restaurant Menu System

-> Project Description

The Restaurant Menu System is an enterprise-style application developed in multiple design sprints.
It models restaurant menus, food items, nutrition data, and order flows, and provides a professional UI interface that will integrate with other enterprise components such as:
.POS System
.Inventory System
.Transactions System
.Database System
The project has evolved from a backend design model into a multi-page web application using ASP.NET Razor Pages.

-> Live Links

.Executive Summary:
https://fsyed7.github.io/restaurant-menu-system/index.html

.Doxygen Documentation:
https://fsyed7.github.io/restaurant-menu-system/html/index.html

-> System Components

The system is built around the following core models:
.FoodItem → Represents a dish including name, price, category, stock, and nutrition.
.NutritionStats → Stores calories, protein, fat, and carbs.
.Menu → Groups food items into sections such as Dinner and Drinks.
.Toppings → Optional add-ons associated with menu items.
.Order Cart → Holds multiple dishes with quantities and selected toppings.

-> Sprint History
# Sprint 1 – Project Foundation
Focus: Design & structure
.Defined system concept and goals
.Created UML class diagram
.Authored executive summary website
.Built initial C++ class skeletons
.Configured Doxygen for documentation
.Planned testing strategy

# Sprint 2 – Functional Expansion & Early Integration
Focus: Backend logic + system communication design
.Implemented models and business logic
.Attempted enterprise integration planning
.Defined data exchange formats with:
->Database System
->Inventory System
->Transactions System
->POS System
.Created architecture table mapping teams to data fields
.Identified API boundaries and responsibilities

# Sprint 3 – UI Transformation & Architecture Refinement
Focus: User experience + enterprise readiness
Major improvements:
.Migrated from WinForms UI → ASP.NET Razor Pages
.Built multi-page web interface:
->Home
->Menus
->Item Details
->Order Summary
->About

.Implemented:
->Shopping cart system
->Topping selections
->Order summary calculation
.Restructured services for integration readiness
.Added:
->Improved UI layout and styling
->Responsive design
->Data models ready for API replacement
.Finalized enterprise workflow diagrams

# Planned Integration
This system is API-ready and structured for future integration:

System	      | Purpose	                | Data
Database	    |Stores food & menu data	|MenuId, FoodId, Name, Price
Inventory   	|Tracks stock	            |FoodId, QuantitySold
Transactions	|Processes payments       |TransactionId, Date, Amount
POS	          |Order processing         |ItemId, Quantity

All current services use mock data and can be swapped for real APIs without changing UI logic.

# Testing & Validation
.Manual UI validation
.Business logic testing
.Regression verification across sprints
.Doxygen verification of model documentation

# Technologies Used
.C# / .NET
.ASP.NET Razor Pages
.Doxygen
.GitHub Pages
.UML (PlantUML)
.Visual Studio

# Team Members
.Faisal Ahmed Syed
.Ella Kubica
.Le Phuong Anh Do



