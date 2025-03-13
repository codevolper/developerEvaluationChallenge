# Developer Evaluation Challenge
Challenge code for technical job test

# Sales API Application
API with complete CRUD that handles sales records and their products associate using a defined pattern by the company that was follwed. The project was coded using ASP.NET Core Web API Application and 
Entity Framework Core with relational database Postgres 

# Features
* Create Sale record
* Read Sale records
* Update Sale records
* Delete Sale records

# Business Rules

* Discount Tiers:
  - 4+ items: 10% discount
  - 10-20 items: 20% discount

* Restrictions:
  - Maximum limit: 20 items per product
  - No discounts allowed for quantities below 4 items
 
# Prerequisites
* .NET 8 SDK
* Visual Studio 2022 or any preferred IDE

# Installation
* Clone the repository
```
  https://github.com/codevolper/developerEvaluationChallenge
```
* Restore dependencies
```
  dotnet restore
```
* Build the project
```
  dotnet build
```
* Update EF migration database
```
  dotnet ef database update 
```
* Run the application
```
  dotnet run --project projectName.sln
```  

# Legacy
* Legacy Scripts generated to run in Postgres database if is needed
```
CREATE TABLE "Sales" (
    "Id" UUID PRIMARY KEY DEFAULT gen_random_uuid(),  -- Unique identifier with a default UUID generator
    "SaleNumber" VARCHAR(255) NOT NULL,               -- Sale number
    "SaleDate" TIMESTAMP NOT NULL,                    -- Date and time of the sale
    "CustomerName" VARCHAR(255),                      -- Customer's name (denormalized)
    "BranchLocation" VARCHAR(255)                     -- Branch location                               
);

CREATE TABLE "SalesProduct" (
    "Id" UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    "SaleId" UUID NOT NULL REFERENCES "Sales"("Id"),
    "ProductName" VARCHAR(255) NOT NULL,
    "Quantity" INT NOT NULL,
    "UnitPrice" INT NOT NULL,
    "Discount" INT,
    "TotalAmount" INT
);

select * from "Sales";
select * from "SalesProduct";
```

* Json Object to use in postman or swagger tests
```
{
  "id": "1c2d3e4f-5678-90ab-cdef-1234567890ab",
  "saleNumber": "SN1001",
  "saleDate": "2025-03-13T00:42:13.110Z",
  "customerName": "Alice Johnson",
  "branchLocation": "New York Store",
  "products": [
    {
      "id": "2d3e4f56-7890-abcd-ef12-34567890abcd",
      "saleId": "1c2d3e4f-5678-90ab-cdef-1234567890ab",
      "productName": "Gaming Laptop",
      "quantity": 1,
      "unitPrice": 1500,
      "discount": 200
    },
    {
      "id": "3e4f5678-90ab-cdef-1234-567890abcdef",
      "saleId": "1c2d3e4f-5678-90ab-cdef-1234567890ab",
      "productName": "Wireless Mouse",
      "quantity": 2,
      "unitPrice": 50,
      "discount": 10
    }
  ]
}
```

