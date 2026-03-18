# # NCSafari: Advanced Animal Management System

A C# console application designed to demonstrate the power of **Object-Oriented Programming (OOP)**, custom **Interfaces**, and **Globalisation**. This project simulates a safari environment where animals are managed based on their biological traits, sorted by physical attributes, and formatted for international research experts.

## 🚀 Key Features

### 1. Environment-Based Animal Logic
The system uses a robust class hierarchy (`Animal`, `Tiger`, `Penguin`, etc.) and functional interfaces (`IFly`, `ISwim`, `IHunt`) to categorise animals. 
* **Dynamic Environments:** `Sky`, `Water`, and `HuntingGround` classes manage animal interactions based on their capabilities.
* **Interface-Driven Actions:** Animals perform specific logic only if they implement the required interface (e.g., only hunters can hunt in the `HuntingGround`).

### 2. Custom Sorting (`IComparer<T>`)
Includes a flexible `CompareWeight` class that implements `IComparer<Animal>`. 
* **Directional Sorting:** Supports both **Ascending** and **Descending** orders via a constructor toggle.
* **Logic:** Efficiently handles null checks and weight comparisons to reorder lists of animals from heaviest to lightest or vice-versa.

### 3. Internationalisation (`IFormattable`)
The `WeightFormatter` class implements the built-in `IFormattable` interface to provide culture-aware data for global experts.
* **Multi-Unit Support:** Converts raw Kilogram data into Grams or Ounces.
* **Culture Sensitivity:** Utilises `IFormatProvider` and `CultureInfo` to automatically switch between decimal points (UK/US) and decimal commas (Europe).
* **Robust Formatting:** Uses the `"N2"` standard numeric format to ensure precision and include thousands separators.

## 🛠️ Technical Stack
* **Language:** C# 12.0 / .NET 8.0+
* **Environment:** Windows 11 (PowerShell 7.5.4)
* **IDE/Tools:** Obsidian (Engineering Vault), VS Code / Visual Studio

## 📖 Usage Example

```csharp
// Sorting Animals by Weight
var animals = new List<Animal> { /* ... */ };
animals.Sort(new CompareWeight(isDescending: true));

// Formatting for International Experts
WeightFormatter formatter = new WeightFormatter(tiger);
Console.WriteLine(formatter.ToString("kg", new CultureInfo("de-DE"))); 
// Output: This Tiger's weight is 100,40 kilograms.