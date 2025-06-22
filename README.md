## Technologies
- ASP.NET Core 8 Web API
- Entity Framework Core (SQL Server)
- JWT Bearer Authentication
- ASP.NET Identity (custom `ApplicationUser`)
- FluentValidation
- Swagger (with JWT support)
- Auto-migration of database on app startup

##Instructions
- Update DbConnection in appsettings.json and run the application. Db is created automatically.
- Use api/user/register endpoint to create a user. Use 'Broker' or 'Seeker' as roles.
- Use api/user/login endpoint to generate token and authenticate to access other endpoints. Broker role has access to all endpoints whereas Seeker only has limited access.
