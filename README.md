## Project Overview: GetColoredSquaresAPI

### Description
GetColoredSquaresAPI is an innovative .NET-based API that generates a JSON response featuring a sequence of numbered squares, each associated with specific color codes. This API functions within a user-defined numerical range, determined by the minimum (Min) and maximum (Max) values provided as input. The color-coding of each square is determined by its number: green for numbers divisible by 3, blue for those divisible by 5, and yellow for numbers divisible by both 3 and 5.

### Initial Setup and Requirements
Before diving into GetColoredSquaresAPI, ensure the following prerequisites are met:

1. **.NET CLI Installation:** Confirm the installation of the .NET Command-Line Interface (CLI) on your system.

2. **Integrated Development Environment (IDE):** Have a suitable IDE, like Visual Studio Code (VSCode) or Visual Studio (VSStudio), ready for coding and API interaction.

Adhering to these prerequisites will facilitate a smooth setup and efficient use of GetColoredSquaresAPI.

### Launching the Application: A Step-by-Step Guide

To launch the application, follow these steps:

1. **Navigate to the Solution Directory:** Begin by positioning yourself in the `Ecommar.Catalog.sln` directory, the central location of the project's solution file.

2. **Build the Project:** Run the `dotnet build` command in your CLI. This compiles the project and ensures all dependencies are correctly aligned and the application is set for execution.

3. **Select the Web API Project:** Post-build, locate the `webapi3` project within your solution, which is the specific project to run.

4. **Run the Web API Project:** Execute `dotnet run --project web.api` to initiate the web API project, preparing it to handle incoming requests.

Ensure you follow these steps sequentially and verify that your setup aligns with the prerequisites.

### Using Swagger to Interact with the Square Controller

Engage with the Square Controller through Swagger by following these instructions:

1. **Access Swagger UI:** Once the Web API project is operational, open the Swagger UI in your browser. This interface visually represents the API's endpoints for simplified testing and interaction.

2. **Find the Square Controller:** In Swagger UI, locate the 'Square Controller' or a similar section. This controller manages square-related requests.

3. **Input Interval Values:** In the Square Controller, input the Min and Max values to define your numerical range. These inputs determine the range for the API's square generation.

4. **Execute the Request:** Post input, click the 'Try it out' or 'Execute' button to send your request to the API.

5. **Review the JSON Response:** The API will return a JSON response containing an array of squares, each with a number and a color based on divisibility:
   - Green for divisibility by 3
   - Blue for divisibility by 5
   - Yellow for divisibility by both 3 and 5

6. **Analyse the Outcome:** Examine the JSON response in Swagger UI to understand the squares' colour distribution as per the divisibility rules within your chosen range.

By adhering to these guidelines, you can effectively utilise Swagger to interact with the Square Controller and comprehend the API's response mechanism. 
