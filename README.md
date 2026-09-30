# 🛒 CSharp Store

A console-based store management application written in **C#**.

This project was created as part of my C# learning journey to practice programming fundamentals through a small practical application.

## 📌 About the Project

**CSharp Store** is a simple console application that simulates basic operations of a small store.

The application allows the user to:

* 📦 View available products
* 🛒 Buy products
* ➕ Restock products
* 📊 View store statistics
* 🔎 Search for products
* 🚪 Exit the application

The project uses three synchronized arrays:

* Product names
* Product prices
* Product stock quantities

The same index represents the same product across all three arrays.

## ⚙️ Features

### 📦 Product List

Displays all available products with:

* Product number
* Name
* Price
* Current stock

### 🛒 Purchasing

The user can:

* Select a product by name
* Specify the desired quantity
* Check available stock
* Complete a purchase
* Update the remaining stock
* Calculate the purchase cost

### 📥 Restocking

The application allows the user to:

* Select a product by number
* Enter the quantity to add
* Update the current stock

### 📊 Statistics

The current version calculates:

* **Average product price**

### 🔎 Product Search

Products can be searched by name.

The program iterates through the product array and compares the user's input with each product.

## 🧠 C# Concepts Practiced

The main goal of this project was to reinforce C# fundamentals:

* Variables and data types
* One-dimensional arrays
* Array indexes
* `Length`
* `for` loops
* `do while` loops
* `if / else`
* Nested conditions
* Logical operators `&&` and `||`
* `switch / case`
* `break`
* Methods
* Method parameters
* Boolean variables
* String comparison
* Basic arithmetic
* Console input/output

## 🏗️ Project Structure

The application is divided into separate methods:

```text
Program.cs
│
├── ShowTov()
├── BuyTov()
├── AddTov()
├── StatisticsTov()
└── SearchTov()
```

Each method is responsible for a specific operation of the store.

## 🎯 Purpose

The purpose of this project is to practice C# programming by combining several previously learned concepts into one complete console application.

This project is part of my journey toward becoming a confident C# developer.

## 🚀 Future Improvements

Possible improvements for future versions:

* Improve input validation
* Add more statistics
* Add purchase history
* Add customer balance
* Store data between program launches
* Replace arrays with collections
* Introduce classes and objects
* Move the application to a WPF interface

## 🛠️ Technologies

* **C#**
* **.NET**
* Console Application
* Visual Studio

---

### 👨‍💻 Author

**Ivan Ashmarin**

This project is part of my personal C# learning journey.
