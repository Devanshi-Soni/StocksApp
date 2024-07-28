# IPO Details App

## Project Overview

This is an ASP.NET Core MVC application that retrieves and displays IPO details using the external API from [Finnhub](https://finnhub.io/). This project demonstrates my skills in ASP.NET Core and C#, and it follows the MVC pattern for clean separation of concerns.

## Features

- Fetches IPO details from Finnhub API
- Displays IPO details in a user-friendly format
- Implements HttpClient for API calls
- Follows the MVC design pattern

## Skills Demonstrated

- ASP.NET Core
- MVC Pattern
- C#
- HttpClient for API integration
- GitHub for version control

## Installation and Setup

To install and run this project on your PC, follow these steps:

### Prerequisites

- .NET Core SDK installed on your machine. You can download it from [here](https://dotnet.microsoft.com/download).
- An IDE like Visual Studio or Visual Studio Code.

### Steps

1. **Clone the repository:**

   ```bash
   git clone https://github.com/yourusername/IPODetailsApp.git
   cd IPODetailsApp
2. **Create a secrets.json file in the IPODetailsApp project folder (next to appsettings.json) and add your API key**
    
    {
    "FinnhubApiKey": "YOUR_API_KEY_HERE"
    }
3. Restore dependencies:
 
   ```bash
   dotnet restore
4. Build the project:
    
   dotnet build
5. Run the project:

    dotnet run
6. Open your browser and navigate to https://localhost:5001 or http://localhost:5000 to view the application.


## Project Structure
- Controllers: Contains the IPOController which handles the API calls and business logic.
- Models: Contains the IPOModel representing the data structure.
- Views: Contains the Razor views for displaying IPO details.
- Services: Contains the FinnhubService for interacting with the Finnhub API.

## Contributing
If you have any suggestions or improvements, feel free to create an issue or submit a pull request.

## License
This project is licensed under the MIT License. See the LICENSE file for more details.
