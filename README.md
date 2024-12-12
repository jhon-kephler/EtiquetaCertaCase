# Etiqueta Certa Case
This is a case project for the selection process

## Setup

Install [SDK](https://dotnet.microsoft.com/pt-br/download/dotnet/9.0) ASP.Net Core 9

Install [Docker](https://docs.docker.com/desktop/install/windows-install/) 

### Get Start

In the console entry under EtiquetaCertaCase\EtiquetaCertaCaseDB and use the command

##### Login:
  - Email: guest
  - Password: guest

### Database project

```bash
  docker-compose up -d

  docker container ls

  docker inspect "CONTAINER ID" for image postgres
```

Open [Localhost](http://localhost:8080/) 

#### Backend project

Open project EtiquetaCertaCase.sln and run project

### Database Credentials

#### Login PgAdmin:
  - Email: admin@etiquetacerta.com
  - Password: admin

#### Adding new server:

##### In General:
- Name: EtiquetaCertaCase

##### In Connection:
- Host name/address: Use gateway IP to inspect return docker
- Username: sa
- Password: admin

### Project Execution Guide

- Create product
  ```bash
    Post - /api/product/Product
    Request
            {
              "name": "string",
              "category": "string",
              "price": 0
            }
  ```

- Get product
  ```bash
    Get - /api/product/Product
    Request
            /api/product/Product?Id=0
  ```
  
- List product
  ```bash
    Get - /api/product/Product/List
    Request
            /api/product/Product/List
  ```

- Update product
  ```bash
    Put - /api/product/Product
    Request
            {
              "id": 0,
              "name": "string",
              "category": "string",
              "price": 0
            }
  ```

- Delete product
  ```bash
      Delete - /api/product/Product
      Request
              /api/product/Product?Id=0
  ```

### Unit Tests Execution

#### Running Unit Tests

  - Open the terminal in the project root directory where the .csproj file for the test  project is located.

  - Run the following command to execute the unit tests:
			
      ```bash
		dotnet test
      ```

  - The command will:

      - Build the test project and its dependencies.
      - Automatically detect and execute all defined unit tests.
      - Display the results in the terminal.

  - Example output:
    
      ```bash
        Build started...
        Build succeeded.
        Test run for <path>/bin/Debug/net6.0/YourProject.Tests.dll (.NETCoreApp,Version=v6.0)
        Starting test execution, please wait...
        Passed!  5 tests.
        Total tests: 5. Passed: 5. Failed: 0. Skipped: 0.
        Test Run Successful.
      ```

#### Test Project Setup

Ensure the test project includes the necessary dependencies for xUnit. Add them if they are not already configured using the following commands:

      dotnet add package xunit
      dotnet add package xunit.runner.visualstudio

#### Example Test Case

Here is an example of a simple unit test written with xUnit:

      using Xunit;

          public class ProductTests
          {
              [Fact]
              public void CreateProduct_ReturnsValidProduct()
              {
                  // Arrange
                  var productService = new ProductService();

                  // Act
                  var product = productService.CreateProduct("Test Product", "Category", 100);

                  // Assert
                  Assert.NotNull(product);
                  Assert.Equal("Test Product", product.Name);
                  Assert.Equal(100, product.Price);
              }
          }
