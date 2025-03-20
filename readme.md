# 🚗 Chevrolet Clone

A web project to display Chevrolet cars in a column format, with images and detailed information for each vehicle.

## 📌 Features
- Display a list of cars with an image, name, and price.
- API to manage cars (list, add, update, and delete).
- Responsive interface styled with Bootstrap.

## 🛠 Technologies Used
- **ASP.NET Core** (Backend)
- **Entity Framework Core** (ORM for database management)
- **C#** (Programming language)
- **Bootstrap** (Styling)
- **JavaScript** (API requests)
- **HTML/CSS** (Structure and design)

## 📋 Prerequisites
Before running the project, make sure you have installed:
- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (version 7)
- A **code editor** such as [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)
- **Git** (optional but recommended)

## 🚀 How to Run the Project

### 🔹 1. Clone the Repository
```sh
git clone 
cd chevroletClone
```
### 🔹 2. Install Dependencies
```sh
dotnet restore
```
### 🔹 3. Compile and Run the Project
```sh
dotnet run
```
or

```sh
dotnet watch run
```
### 🔹 4. Open in Browser
```sh
http://localhost:5197
```
## 📡 API Endpoints
The application exposes a REST API for car management:

Method	Route	Description

```sh
GET    /api/car          # Returns all cars
GET    /api/car/{id}     # Returns a specific car
POST   /api/car          # Adds a new car
PUT    /api/car/{id}     # Updates an existing car
DELETE /api/car/{id}     # Removes a car
```

## 🚀 Home Layout
![Home Image](wwwroot/img/home.png)
