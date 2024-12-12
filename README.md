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
