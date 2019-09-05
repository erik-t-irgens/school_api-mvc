# School MVC/API

#### _School MVC and API that allows for Student and Course creation with a many-to-many relationship - August 2019_

#### _By **Erik Irgens**_

## Description

This application was intended to learn more closely the details of how to separate an MVC and an API application to work together dependantly, with the MVC making full CRUD calls to the API in the backend. For now, this application takes the form of a school where you may create new students and new courses. This uses a many to many relationship SQL table, where many students may be in many classes, and many classes may be assigned to a student.

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **User can create a new student in the MVC and have it populate the API** | New student creation | API is updated with user's information  |
| **User should be able to delete, edit, and view details of each student** | Student is clicked | Student details will appear in the correct path  |
| **User can create a new course in the MVC and have it populate the API** | New course creation | API is updated with user's information  |
| **User should be able to delete, edit, and view details of each course** | course is clicked | course details will appear in the correct path  |

## Setup/Installation Requirements

1. Clone this repository:
    ```
    $ git clone https://github.com/erik-t-irgens/school_api-mvc
    ```
2. Run each application in their root directories (MVC and API directories)
    ```
    $ dotnet run
    ```
3. Visit the MVC localhost:5000/
    ```
    localhost:5000/
    ```

## Known Bugs
* The complete CRUD of this application may not be functional at this time.

## Technologies Used
* C#/.NET, ASP.NET Core 2.2, MVC/API architecture, Linq, MySQL and SQL databases

## Support and contact details

_Please contact Erik Irgens with questions and comments._

### License

*GNU GPLv3*

Copyright (c) 2019 **_Erik Irgens_**
