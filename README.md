# Meal Order Collection System 🍽️

A dynamic web application built with **ASP.NET Core MVC** to manage and track cafeteria meal orders. This project demonstrates foundational backend architecture, data binding, and routing using an in-memory mock database.

## 🚀 Features
*   **Dashboard (Index):** Displays a summary of successfully collected meals and the total collection count.
*   **All Orders:** Lists all registered meal orders (both collected and pending) with dynamic status indicators.
*   **Order Details:** Dynamic routing to view specific details of a single order using its unique Order ID.
*   **Collect Meal:** A form-based interface to update the status of a pending order to "Collected" with real-time timestamping.

## 💻 Tech Stack
*   **Backend:** C#, ASP.NET Core 8.0 (MVC Pattern)
*   **Frontend:** HTML5, CSS3, Razor Syntax (`.cshtml`)
*   **Data Management:** In-Memory Mock Data (Static Repository Pattern)

## 🏗️ Architecture & Concepts Learned
*   **Model-View-Controller (MVC):** Separation of application logic, user interface, and data models.
*   **Model Binding:** Securely passing form data (Order IDs) via HTTP POST requests to Controller actions.
*   **Tag Helpers & Routing:** Utilizing `asp-controller`, `asp-action`, and `asp-route-id` for seamless navigation.
*   **LINQ Queries:** Filtering and finding specific objects within a static generic list.

## 🛠️ Installation & Setup
To run this project locally, ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed.

1. Clone the repository:
   ```bash
   git clone [https://github.com/aysem-aksit/MealOrderCollection.git](https://github.com/aysem-aksit/MealOrderCollection.git)