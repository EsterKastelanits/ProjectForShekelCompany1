URLS: (can using swagger)
1. https://localhost:44319/api/Customer/GetCustomersGroups
2. https://localhost:44319/api/Customer/AddCustomer?customerId=7878&name=Leah&address=TelAviv&phone=0563289745&factoryCode=12&groupCode=11

I added more options in order to check the insertion
3. https://localhost:44319/api/Customer/AddGroupToDb?groupCode=13&groupName=Dafna
4. https://localhost:44319/api/Customer/AddFactoryToDb?groupCode=13&factoryCode=36&factoryName=DafnaFactory
5. https://localhost:44319/api/Customer/GetGroups
6. https://localhost:44319/api/Customer/GetFactories
7. https://localhost:44319/api/Customer/GetCustomers


I implement the application in .NET Core.

I added relations between tables to avoid missing information.

Using design pattern of dependency injection.

In CustomerDbManager - Method for each get/post method. (adding options)

I writed minimal Try Catch.