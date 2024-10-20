# DotNetFireStore 
is a .NET Core Web API project designed to simplify interaction with Google Firestore. It provides an easy-to-use solution for performing CRUD operations and executing queries, all while maintaining a clean architecture.

## Table of Contents
- [Installation](#installation)
- [Instructions](#instructions)
- [Feature](#features)
- [Usage](#usage)
- [License](#license)

## Installation
To get started with the DotNetFireStore project, follow these steps:

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/MohanedZekry/go-router-authentication.git

# Instructions # for Updating Firestore Configuration

1. **Open your `appsettings.json` file** in your .NET Core project.

2. **Locate the Firestore configuration section**, which should look like this:

   ```json
   "Firestore": {
     "ProjectId": "your-firestore-project-id",
     "KeyFilePath": "Path/your-service-key.json"
   },
   
Replace the placeholders with your actual Firestore project details:

- **`your-firestore-project-id`**: Replace this with your Firestore project's ID. You can find this in the Firebase console under your project settings.
- **`Path/your-service-key.json`**: Replace this with the path to your Firestore service account key file (JSON). Make sure this path is accessible from your application.

## Features
- Easy CRUD Operations: Perform create, read, update, and delete operations with minimal effort.
- Flexible Query Support: Execute complex queries to retrieve data based on specific criteria.
- Clean Architecture: Built with the repository pattern, ensuring a separation of concerns and enhancing maintainability.
- Transaction Management: Robust support for managing transactions, ensuring data integrity.

## Usage
After setting up the project, you can start using it to interact with Google Firestore.

## License
This project is licensed under the MIT License. See the LICENSE file for details.

