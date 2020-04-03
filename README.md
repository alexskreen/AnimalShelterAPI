# Animal Shelter API Application

#### _API for interacting with Animal Shelter MVC_

#### By: **Alex Skreen**, April 3, 2020

## Description

_This API interacts with a custom-built AnimalShelter MVC, and allows users to GET, POST, PUT, and DELETE cats and dogs.

## Specification user stories:
| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| If user visits '/' root route, the application displays a splash page with links to '/Cats', '/Dogs'  and '/Users' | user visits '/' route | application displays homepage |
| Application allows a user to register for an account with Identity | user clicks "login/register" option on splash page, then completes form at '/Account/Register' | application creates new user account and redirects to '/Login' |
| Application allows a registered user to login | registered user clicks "log in" option at '/Account' | application redirects to '/Account/Login' |
| Application allows a registered user to logout | registered user clicks "logout" option at '/Account' | application logs out of user account |
| Only registered, logged-in users are able to create, update, and delete cats | user is not logged in and/or not registered and clicks "add cat", "edit cat", or "delete cat" | user redirected to login page |
If user visits '/Dogs' route, the application displays all dogs in the database, ordered from highest rated to lowest rated | user visits '/Dogs' | application displays list of all cats in order of rating |
| If a registered user clicks "add new dog" link at '/Dogs', the application redirects to a form ('/Dogs/Create') for adding a new dog | registered user clicks "add new dog" | the application redirects to form at 'Dogs/Create' |
| When a registered user submits the new dog form, the application adds the new dog to the dogs table of the alex_skreen database and redirects to '/Dogs' | registered user submits new dog form | the application adds new dog to dogs table and redirects to '/Dogs' |
| A registered user can delete a dog from the list of all dogs | registered user selects "delete dog" option | application deletes dog from database |
| A registered user can edit a dog from the list of all dogs | registered user selects "edit dog" | application redirects to edit form |
| If user visits '/Cats' route, the application displays all cats in the database | user visits '/Cats' | application displays list of all cats |
| If a registered user clicks "add new cat" link at '/Cats', the application redirects to a form ('/Cats/Create') for adding a new cat | registered user clicks "add new cat" | the application redirects to form at 'Cats/Create' |
| When a registered user submits the new cat form, the application adds the new cat to the cats table of the alex_skreen database and redirects to '/Cats' | registered user submits new cat form | the application adds new cat to cats table and redirects to '/Cats' |
| A registered user can delete a cat from the list of all cats | registered user selects "delete cat" option | application deletes cat from database |
| A registered user can edit a cat from the list of all cats | registered user selects "edit cat" | application redirects to edit form |

http://localhost:5004/api/dogs/5

http://azure.cloud/

| Endpoint | Http Action | Return data |
| -------- | ----------- | ----------- |
| /api/dogs | Get | List{ "dogId": 1, "name": "Casey", "breed": "Golden Retriever". "age": 15} |
| /api/dogs | Post | new Dog in database: { "dogId": 2, "name": "brian", "breed": "Flat Coated Retriever". "age": 10} |
| /api/dogs | Put| edit Dog in database: { "dogId": 2, "name": "Brian", "breed": "Flat Coated Retriever". "age": 10} |
| /api/dogs | Delete | delete Dog from database: { "dogId": 6, "name": "Murphy", "breed": "Yellow Lab". "age": 14} |
| /api/cats | Get | List{ "catId": 1, "name": "Stella", "breed": "Polydactyl Turkish Angora". "age": 9} |
| /api/cats | Post | new Cat in database: { "catId": 2, "name": "charles", "breed": "Tuxedo". "age": 5} |
| /api/cats | Put| edit Cat in database: { "catId": 2, "name": "Charlie", "breed": "Tuxedo". "age": 5} |
| /api/cats | Delete | delete Cat from database: { "catId": 6, "name": "Mittens", "breed": "Minx". "age": 6} |

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Install MySQL

#### on macOS:
_Download the MySQL Community Server DMG File [here](https://dev.mysql.com/downloads/file/?id=484914). Follow along with the installer until you reach the configuration page. Once you've reached Configuration, set the following options (or user default if not specified):_
* use legacy password encryption
* set password (and change the password field in appsettings.json file of this repository to match your password)
* click finish
* open Terminal and enter the command ``echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`` if using Git Bash.
* Verify MySQL installation by opening Terminal and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. If you gain access to the MySQL command line, installation is complete. An error (e.g., -bash: mysql: command not found) indicates something went wrong.

#### on Windows:
_Download the MySQL Web Installer [here](https://dev.mysql.com/downloads/file/?id=484919) and follow along with the installer. Click "Yes" if prompted to update, and accept license terms._
* Choose Custom setup type
* When prompted to Select Products and Features, choose the following: MySQL Server (Will be under MySQL Servers) and MySQL Workbench (Will be under Applications)
* Select Next, then Execute. Wait for download and installation (can take a few minutes)
* Advance through Configuration as follows:
  - High Availability set to Standalone.
  - Defaults are OK under Type and Networking.
  - Authentication Method set to Use Legacy Authentication Method.
  - Set password to epicodus. You can use your own if you want but epicodus will be assumed in the lessons.
  - Unselect Configure MySQL Server as a Windows Service.
* Complete installation process

_Add the MySQL environment variable to the System PATH. Instructions for Windows 10:_
* Open the Control Panel and visit _System > Advanced System Settings > Environment Variables..._
* Select _PATH..._, click _Edit..._, then _Add_.
* Add the exact location of your MySQL installation and click _OK_. (This location is likely C:\Program Files\MySQL\MySQL Server 8.0\bin, but may differ depending on your specific installation.)
* Verify installation by opening Windows PowerShell and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. It's working correctly if you gain access to the MySQL command line. Exit MySQL by entering the command ``exit``.

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone`` followed by the URL to this repository
* ``cd AnimalShelterAPI.Solution/AnimalShelter``

_Confirm that you have navigated to the AnimalShelter directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

## Clone the AnimalShelterAPI repository and run the AnimalShelterAPI

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd ~``
* ``cd desktop``
* ``git clone https://github.com/acolistro/AnimalShelterAPI.Solution``
* ``cd AnimalShelterAPI.Solution/AnimalShelter``
* ``dotnet restore``
* ``dotnet build``
* ``dotnet ef database update``
* ``dotnet run`` or ``dotnet watch run``

## Run this MVC application in another Terminal or PowerShell window

_Run this MVC application by entering the following command in Terminal (macOS) or PowerShell (Windows) at the root of the AnimalShelterAPI directory:_
* ``dotnet run`` or ``dotnet watch run``

_To view/edit the source code of this application, open the contents of the AnimalShelterAPI.Solution directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal at the root of the AnimalShelterMVC.Solution directory)._

## Technologies Used

* Git
* C#/.NET
* Visual Studio Code 1.43.1
* dotnet script 0.50.1
* MySQL 8.0.15
* ASP.NET Core MVC 2.2
* Entity Framework Core 2.2
* RestSharp version 106.6.10
* Newtonsoft.Json version 12.0.2
* [AnimalShelter API version 1.0](https://github.com/acolistro/AnimalShelterAPI.Solution)

## License

Licensed under the MIT license.

&copy; 2020 - Alex Skreen