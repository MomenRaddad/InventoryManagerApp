# 🧾 Inventory Management System (Console App)

A simple **console-based inventory management system** built using **C# (.NET)**.  
This application allows users to **view**, **add**, **search**, and **remove** products from an in-memory list.

It’s a beginner-friendly project designed to practice **OOP (Object-Oriented Programming)** and **data handling** concepts.

---

## 🧩 Features

- 🗂️ **View all products** with details (ID, Name, Price, Quantity)
- 🔍 **Search** for a product by name (case-insensitive)
- ➕ **Add** new products dynamically
- ❌ **Remove** products from inventory by name
- 💬 **Simple and interactive** console-based interface

---

## 🏗️ Project Structure

```bash
first_project/
├── models/
│   ├── Product.cs       # Defines the Product class (represents a single product)
│   └── Inventory.cs     # Manages all inventory operations (Add, Search, Remove, View)
└── Program.cs           # Entry point, displays menu and interacts with the user
