### Pet Shelter
## By Alex Johnson

An Api for managing pet residents. 

🐱 [Documentation](#api-documentation)

🐶 [Project Details](#project-details)

🐱 [Setup/Installation Guide](#setup/installation-guide)

🐶 [Bugs](#known-bugs)

🐱 [License](#license)


## Technologies Used

   * C#
   * ASP.Net 6
   * EFCore
   * MySQL
   * LINQ
   * Newtonsoft
   * RESTsharp
   * bootstrap

## Project Details
* Implement an API with full CRUD functionality
* Implement one(or more) of the following: authentication, versioning, pagination, or CORS
* full API documentation required.

## Setup/Installation Guide
 
# Set up the API
* Clone the repository 
* Navigate to the `PetShelterApi` folder
* Open a command line and enter the following:
  ```
  dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
  dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
  dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
  dotnet add package RestSharp --version 108.0.3	
  dotnet add package Newtonsoft.Json --version 13.0.2
  dotnet ef database update
  ```
* add a file in the PetShelterApi directory called `appsettings.json` and add the following code, replacing the password/user field with your credentials:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=PetShelterApi;uid=[YOUR_UID];pwd=[YOUR_PASSWORD];"
  }
}
```

# Client Setup

* Navigate to the `PetShelterClient` directory, opening a command line interface
* Enter the following commands:
 ```
 dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
 dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 6.0.0
 dotnet add package RestSharp --version 108.0.3	
 dotnet add package Newtonsoft.Json --version 13.0.2
 ```
 * In the `PetShelterClient` directory create a file called appsettings.json and enter the following code:
 ```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
 ```

# Running the program
* Start the API by opening a command line in the `PetShelterApi` directory and enter `dotnet run`
* Start the client by opening a command line in the `PetShelterClient` directory and enter `dotnet run`


### API Documentation

## Endpoints
```
GET http://localhost:5000/api/animals/
GET http://localhost:5000/api/animals/{id}
POST http://localhost:5000/api/animals/
PUT http://localhost:5000/api/animals/{id}
DELETE http://localhost:5000/api/animals/{id}
```
## Attribute Queries
You may also query certain attributes by using the following syntax in your GET requests:
| Parameter | DataType | Returns |
| ------ | ------ | ----------------------------------------------------- |
| Name | String | All names matching the input string |
| Species | String | All species matching the input string |
| SubSpecies | String | All SubSpecies of the parent species (eg, german shepherd) |
| Age | Integer | All animals at least [input value] years old |

    
## Examples
  * The following query will return all animals named "Kvothe":
      ```
      GET http://localhost:5001/api/animals?name=Kvothe
      ```
      Partial name matching is allowed (eg, querying 'sa' would return Sam, Lisa, etc )

  * The following query will return all animals at least 3 years old:
      ```
      GET http://localhost:5001/api/Location?minimumAge=3
      ```
  * You can query multiple fields by concatening requests with &, like this:
      ```
      GET http://localhost:5001/api/Location?species=Cat&minimumAge=3
      ```
  * You may query specific entry IDs by appending it to the end:
      ```
      GET https://localhost:5001/api/Animals/4
      ```

  * A body is required for POST requests. Example of a good request would be:
      ```
      { 
        "name": "Bongo Jones",
        "species": "Cat",
        "subSpecies": "Tabby",
        "age": 3,
      }
      ```
  * An ID is required for PUT requests (modifying an existing entry) including the ID of the entry:
      ```
      {
        "animalId": 1,
        "name": "Kvothe",
        "species": "Cat",
        "subSpecies": "Himalayan",
        "age": 10,
      }
      ```
  * To delete an entry, simply enter the id of the entry you'd like to delete:
      ```
      DELETE  https://localhost:5001/api/Animals/8
      ```




* Run the API 
  
* Clone this repo 


## Known Bugs


## Thanks


## License

MIT License

Copyright (c) 2023 Alex Johnson 

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.




