# Password Generator

This project is a simple yet effective password generator implemented as a React web application with a C# backend API.

## Description

The Password Generator is a tool that allows users to generate secure passwords with just a click. It uses a C# backend API to generate passwords, ensuring a high level of randomness and security, while providing a user-friendly interface through a React frontend.

## Features

- Simple and intuitive user interface
- One-click password generation
- Clear display of the generated password
- Responsive design that adapts to different screen sizes
- Customizable password generation through API parameters

## Technologies Used

### Frontend
- React
- CSS
- Axios for API calls

### Backend
- C# (.NET Core)
- ASP.NET Core Web API

## Backend Functionality

The backend is a C# API with a single endpoint for password generation. Here's what it does:

- Endpoint: `GET /api/password/generate`
- Optional query parameters:
  - `length`: Determines the password length (default is 12)
  - `includeNumbers`: Whether to include numbers (default is true)
  - `includeSymbols`: Whether to include symbols (default is true)

The password generation logic ensures:
- The password always starts with an uppercase letter
- It includes at least one symbol and two numbers
- The remaining characters are a mix of letters, numbers, and symbols
- The final password is shuffled for added randomness

## Usage

To use the password generator:

1. Click the "Generate Password" button in the frontend
2. The generated password will appear in the designated area

To use the API directly:

```
GET http://localhost:5073/api/password/generate?length=15&includeNumbers=true&includeSymbols=true
```

## Setup and Installation

This project doesn't require installation as it's designed to run on a web server. However, for development purposes:

### Frontend
1. Navigate to the frontend directory
2. Install dependencies: `npm install`
3. Start the development server: `npm start`

### Backend
1. Ensure you have .NET Core SDK installed
2. Navigate to the backend directory
3. Run the API: `dotnet run`

## API

The backend API is set up to run on `http://localhost:5073`. Ensure it's running when using the frontend application.

## Contributing

Contributions are welcome. Please open an issue to discuss any changes you'd like to make.
