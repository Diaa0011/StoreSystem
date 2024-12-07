# Store Management System
An ASP.NET MVC application designed to manage stores and their inventory.
This project demonstrates the implementation of a many-to-many relationship between stores and items, along with CRUD operations for managing them.

## Features
* **Store Management:** Create, update, view, and delete stores.
* **Item Management:** Create, update, view, and delete items.
* **Store-Item Association:** Manage the association between stores and items via a join table.
* **Clean MVC Architecture:** Follows the ASP.NET MVC pattern for a structured and scalable design. 
* **Entity Relationships:** Implements a many-to-many relationship between stores and items using Entity Framework.

## Technologies Used
* **Framework:** ASP.NET Core MVC
* **Database:** Entity Framework Core (Code First Approach)/MSSQL SERVER
* **Language:** C#
* **UI:** Razor Pages, Bootstrap (Optional for Styling)
* **Development** Tools: Visual Studio, Git

### Installation
1. Clone the repository:
```
git clone https://github.com/Diaa0011/StoreSystem
```
2. Navigate to the project directory:
```
cd StoreSystem
```
3. Restore NuGet packages:
```
dotnet restore
```
4. Update the database:
```
dotnet ef database update
```
5. Run the application:
```
dotnet run
```
## Database Schema
The system contains the following tables:
1. **Stores:** Contains store information.
2. **Items:** Contains item details.
3. **StoreItems:** Represents the many-to-many relationship between stores and items.

## Example Usage
1. Add a new store and a few items.
2. Associate items with stores using the StoreItem management interface.
3. View stores to see their associated items or vice versa.

## Future Enhancements
* Implement search and filtering features.
* Add user authentication for admin operations.
* Enhance the UI for better usability.

## License
This project is licensed under the MIT License. See the [LICENSE](./LICENSE) file for more details.





