#🤖 PromptBotBlazor Documentation
___________________________

#Project Overview
PromptBotBlazor is an AI-powered web application built using Blazor WebAssembly on the .NET 8 framework. The project focuses on generating and managing text prompts using a locally trained machine learning model. It leverages ML.NET for AI predictions, ensuring that no external AI APIs are required. The application follows clean architecture and clean code principles to ensure maintainability, testability, and scalability. The entire solution is developed using C#, making it a full-stack .NET environment.

#💡 Project Objective

Build a chatbot that generates and manages text prompts using a locally trained machine learning model.
Provide a seamless user experience through a Blazor WebAssembly UI.
Ensure the application is self-contained by using ML.NET for AI predictions, eliminating the need for external APIs.
Follow clean architecture principles for a scalable and maintainable codebase.


#🧼 Key Features

🌐 Blazor WebAssembly UI: A responsive and interactive user interface built with Razor Components.
🧠 Local ML.NET Model: A custom machine learning model trained locally for AI predictions and prompt classification.
🧼 Clean Architecture: Strict separation of concerns with modular components and reusable services.
⚙️ Full-Stack .NET Environment: Built entirely with C# and .NET, with no reliance on external APIs.
🧩 Error Handling and Validation: Robust data and model management with proper error handling.


#🧼 Clean Code & Architecture
The project adheres to Clean Code Principles, including:

Clear Folder Structure: Organized into distinct folders (UI, Services, Models, ML).
Separation of Concerns: Each layer (UI, business logic, data) is isolated for better maintainability.
Dependency Injection: Interface-driven design for loose coupling and testability.
Readable Codebase: Well-structured, documented, and easy-to-understand code.
Comprehensive Documentation: Inline comments and guides for contributors.


#🧠 Machine Learning (ML.NET)

Model Training: The app uses ML.NET to train a custom machine learning model on labeled data within the project.
Local Predictions: The model performs prompt predictions and classifications locally, requiring no internet or cloud services.
Data Management: Includes error handling and validation for data preprocessing and model management.
No External APIs: Unlike earlier iterations, the project no longer relies on external APIs (e.g., Hugging Face or AraGPT2).


#⚙️ Tech Stack

Blazor WebAssembly (.NET 8): For the frontend and application logic.
ML.NET: For training and consuming the machine learning model.
C#: The primary programming language for the entire project.
Razor Components: For building the UI.
Clean Architecture: For structuring the codebase.


#🖼️ Screenshots

![image](https://github.com/user-attachments/assets/3f7ba325-8ab5-4189-be24-156e4ecaa49f)

![image](https://github.com/user-attachments/assets/05e9cb01-0f59-46cd-b212-53eef5bf6861)

![image](https://github.com/user-attachments/assets/a700ea8f-30df-4d61-aec5-32811b1fb6d0)

![image](https://github.com/user-attachments/assets/52ae8851-c6d6-4cd4-94c1-e6ba455146f2)

![image](https://github.com/user-attachments/assets/c1c6684a-8105-4ba1-8917-e4e88a554024)




#🚀 Getting Started
Prerequisites

.NET 8 SDK: Required to build and run the Blazor WebAssembly application.
Visual Studio or VS Code: Recommended for development and debugging.
Git: For cloning the repository.

Steps to Run the Project

Clone the Repository:
git clone https://github.com/your-username/PromptBotBlazor.git


Navigate to the Project Directory:
cd PromptBotBlazor


Run the Application:
dotnet run


Access the Application:

Open your browser and navigate to https://localhost:5001 (or the port specified in the console output).



#Notes

The ML.NET model is already trained and included in the project. If you need to retrain the model, ensure you have the labeled data in the correct format (e.g., data.csv) and update the training pipeline in the ML folder.
No additional setup is required since the project does not rely on external APIs.


#Challenges and Limitations

Data Dependency: The quality of the ML.NET model’s predictions depends on the size and quality of the training data. Small datasets may lead to poor performance.
Computational Resources: Training the ML.NET model locally can be resource-intensive, especially for large datasets.
Model Complexity: The current ML.NET model is designed for text classification and prediction. It may not handle complex generative tasks as effectively as large language models (e.g., GPT).
Arabic Language Support: While the app supports Arabic prompts, the model may need further tuning to handle colloquial dialects (e.g., Egyptian Arabic) effectively.


#Unit Testing:
Add unit tests for services and ML components to improve reliability.




#Project Timeline

Start: The project began as a Rule-Based Chatbot relying on data.csv for predefined responses.
Initial Development: Evolved into a Generative AI app using external APIs (e.g., Hugging Face Inference API, AraGPT2).
Final Version: Transitioned to a fully local solution using ML.NET for training and predictions, adhering to clean architecture principles.
Current Date: April 22, 2025. The project now operates as a self-contained AI-powered Blazor WebAssembly app.


#Contact 

Developer: [Hagar Atia .
Email: [shamsatia96@gmail.com]
LinkedIn: [https://www.linkedin.com/in/hagar-atia-%F0%9F%87%B5%F0%9F%87%B8-b8740a250?lipi=urn%3Ali%3Apage%3Ad_flagship3_profile_view_base_contact_details%3B7DzrVwWuRQGNNbEmzFKKPw%3D%3D]


