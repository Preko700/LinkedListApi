# LinkedListApi

LinkedListApi es un proyecto desarrollado en **C# .NET Core 8** que implementa una API REST sencilla para manejar una lista enlazada en memoria estática. Este proyecto permite agregar, eliminar y consultar nodos en la lista enlazada, usando endpoints RESTful.

## Características

- **GET /linked-list/**: Devuelve el estado actual de la lista enlazada.
- **POST /linked-list/**: Agrega un nodo a la lista enlazada con un valor proporcionado. Retorna un `GUID` único generado para el nodo.
- **DELETE /linked-list/{id}**: Elimina un nodo de la lista enlazada utilizando su `GUID`.

## Tecnologías Utilizadas

- **Lenguaje:** C#
- **Framework:** .NET Core 8
- **Estructura de Datos:** Lista enlazada implementada en memoria estática
- **Formato de Comunicación:** JSON
- **Herramientas de Desarrollo:** Visual Studio 2022

## Requisitos Previos

Antes de comenzar, asegúrate de tener instalado lo siguiente:

- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) con el workload de **ASP.NET y desarrollo web**
- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)

## Configuración del Proyecto

1. Clona el repositorio:
   ```bash
   git clone https://github.com/Preko700/LinkedListApi.git
   cd LinkedListApi
   ```

2. Abre el proyecto en **Visual Studio 2022**.

3. Restaura las dependencias del proyecto:
   - Visual Studio lo hace automáticamente al abrir el proyecto.
   - Alternativamente, puedes usar:
     ```bash
     dotnet restore
     ```

4. Ejecuta la aplicación:
   - Presiona `F5` o haz clic en el botón "Iniciar" en Visual Studio.
   - La API estará disponible en `https://localhost:<puerto>` o `http://localhost:<puerto>`.

## Endpoints de la API

### **GET /linked-list/**
- **Descripción:** Obtiene el estado actual de la lista enlazada.
- **Respuesta exitosa:** 
  ```json
  [
    {
      "id": "GUID",
      "value": "valor"
    },
    {
      "id": "GUID",
      "value": "otro valor"
    }
  ]
  ```

### **POST /linked-list/**
- **Descripción:** Agrega un nuevo nodo a la lista enlazada.
- **Request Body:**
  ```json
  {
    "value": "valor"
  }
  ```
- **Respuesta exitosa:**
  ```json
  {
    "id": "GUID"
  }
  ```

### **DELETE /linked-list/{id}**
- **Descripción:** Elimina un nodo de la lista enlazada utilizando su `GUID`.
- **Parámetro:**
  - `id`: El GUID del nodo a eliminar.
- **Respuesta exitosa:** Código de estado `204 No Content`.

## Ejemplo de Pruebas con Postman

1. Descarga e instala [Postman](https://www.postman.com/downloads/).

2. Configura los siguientes endpoints para probar la API:

- **GET /linked-list/**
  - Método: `GET`
  - URL: `http://localhost:<puerto>/linked-list/`

- **POST /linked-list/**
  - Método: `POST`
  - URL: `http://localhost:<puerto>/linked-list/`
  - Headers:
    - `Content-Type: application/json`
  - Body:
    ```json
    {
      "value": "Ejemplo de valor"
    }
    ```

- **DELETE /linked-list/{id}**
  - Método: `DELETE`
  - URL: `http://localhost:<puerto>/linked-list/{id}`

## Estructura del Proyecto

```
LinkedListApi/
├── Controllers/
│   └── LinkedListController.cs  -> Controlador para los endpoints de la API
├── Models/
│   ├── LinkedList.cs            -> Modelo de la lista enlazada
│   ├── LinkedListNode.cs        -> Modelo de un nodo de la lista enlazada
│   └── AddNodeRequest.cs        -> DTO para solicitudes POST
├── Services/
│   └── LinkedListService.cs     -> Servicio singleton para manejar la lógica de la lista
├── Program.cs                   -> Configuración y punto de entrada de la aplicación
├── Properties/                  -> Configuración del proyecto
└── README.md                    -> Documentación del proyecto
```

## Contribuciones

¡Las contribuciones son bienvenidas! Si deseas contribuir:

1. Haz un fork del repositorio.
2. Crea una rama para tu funcionalidad (`git checkout -b feature/nueva-funcionalidad`).
3. Haz commit de tus cambios (`git commit -m 'Añade nueva funcionalidad'`).
4. Sube tu rama (`git push origin feature/nueva-funcionalidad`).
5. Abre un Pull Request en este repositorio.

## Licencia

Este proyecto está bajo la [Apache 2.0](https://github.com/Preko700/LinkedListApi?tab=Apache-2.0-1-ov-file). Siéntete libre de usarlo, modificarlo y distribuirlo.
