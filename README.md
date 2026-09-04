# DrinkDemo

A small Blazor WebAssembly standalone application demonstrating object-oriented
design in C#. It models a base `Drink` class with `Juice`, `Beer`, and `Soda`
derived types, each overriding a `description` property to build up its own
summary text. Sample instances (Orange Juice, Budweiser, Pepsi) are stored in
a list and rendered on the page.

## Features
- Abstract `Drink` base class with `drink_name`, `is_carbonated`, and an overridable
  `description` property.
- `Juice` adds a `fruit_type` property; description includes the fruit.
- `Beer` adds an `alcohol_content_percentage` property; description includes the ABV%.
- `Soda` uses the base carbonation info only.
- A sample list of drinks is displayed in the UI, looping through each
  instance and printing its description.

## Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (10.0 recommended)
- A modern web browser

Verify your SDK install:
```bash
dotnet --version
```

## Getting Started
1. Clone the repository:
   ```bash
   git clone https://github.com/Llamallava/DrinkDemo.git
   cd DrinkDemo
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Run the app locally:
   ```bash
   dotnet run
   ```

4. Open the URL shown in the console in your browser.

## Project Structure

```
├── Models/
│   ├── Drink.cs        # Abstract base class
│   ├── Juice.cs        # Juice : Drink
│   ├── Beer.cs         # Beer : Drink
│   └── Soda.cs         # Soda : Drink
├── Pages/
│   └── VendingMachine.razor     # Displays the drink list
├── Program.cs           # WASM host setup
└── wwwroot/              # Static assets
```
