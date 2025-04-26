# Monty Hall Simulation Web Application
Monty Hall Simulation  A web application that simulates the Monty Hall problem using ASP.NET Core Web API (backend) and Angular (frontend), built within a single Visual Studio 2022 solution. Users can run multiple simulations, choose to switch doors or not, and view win/loss results. Basic unit tests are included using xUnit to validate the simulation logic.

## Features

- Run customizable number of Monty Hall simulations
- Choose whether to switch doors or stay with initial choice
- View results: total wins, losses, winning percentage
- Simple and clean user interface
- Basic unit tests with xUnit

## Technologies Used

- Backend: ASP.NET Core Web API (.NET 8)
- Frontend: Angular 17
- Testing: xUnit
- Development Environment: Visual Studio 2022

## Getting Started

### Prerequisites

- .NET 8 SDK
- Node.js & npm
- Angular CLI
- Visual Studio 2022

### Running the Project

1. Clone the Repository

```bash
git clone https://github.com/your-username/MontyHallSimulation.git
cd MontyHallSimulation
```

2. Backend

- Open `MontyHallApplication.sln` in Visual Studio 2022
- Set `MontyHallApplication.Server` as startup project
- Press F5 to run

3. Frontend

```bash
cd ClientApp
npm install
npm start
```

4. Access the Application

Open your browser and go to `http://localhost:4200/`.

## Running Unit Tests

- Open Test Explorer in Visual Studio
- Run all tests to verify backend logic

## Project Structure

```
MontyHallApplication.sln
- MontyHallApplication.Server (C# API)
- MontyHallApplication.ClientApp (Angular Frontend)
- MontyHallSimulationTests (Unit Tests)
```

## About the Monty Hall Problem

The Monty Hall problem is a probability puzzle where switching doors significantly increases the chances of winning.
More info:(https://en.wikipedia.org/wiki/Monty_Hall_problem)

## Author

Nanduni Upekshika.
(www.linkedin.com/in/upekshikasewwandi-9b90b6239)
