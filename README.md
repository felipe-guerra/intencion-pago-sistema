# 📌 Sistema de Registro de Intenciones de Pago

## 1. 📖 Descripción general

Este proyecto es una solución fullstack que permite gestionar intenciones de pago de clientes en mora.

El sistema permite:
- Registrar una intención de pago
- Consultar el historial de intenciones registradas
- Evaluar si un cliente aplica a campaña de descuento según su nivel de mora

El objetivo es simular un proceso de cobranza para campañas de recuperación de cartera.

---

## 2. 🧱 Arquitectura del sistema

El sistema está compuesto por dos aplicaciones independientes:

Frontend (Angular 17)
        ↓ HTTP REST
Backend (ASP.NET Core Web API .NET 8)
        ↓
Datos en memoria (sin base de datos)

---

## 3. ⚙️ Tecnologías utilizadas

Backend:
- .NET 8
- ASP.NET Core Web API
- C#

Frontend:
- Angular 17
- TypeScript
- HTML / CSS
- RxJS

---

## 4. 📦 Requisitos previos

- .NET SDK 8
- Node.js (LTS recomendado)
- Angular CLI

Instalación Angular CLI:
npm install -g @angular/cli

---

## 5. 🚀 Ejecución del proyecto

### 🔵 Backend (.NET 8)

cd CobranzaAPI
dotnet restore
dotnet run

URL base:
http://localhost:5151/api/intencionpago

---

### 🟢 Frontend (Angular 17)

cd intencion-pago-app
npm install
ng serve

URL de la aplicación:
http://localhost:4200

---

## 6. 🔌 Endpoints del API

### 📍 GET - Obtener historial

GET /api/intencionpago

Descripción:
Retorna todas las intenciones de pago registradas.

Ejemplo de respuesta:

{
  "exito": true,
  "mensaje": "Consulta exitosa",
  "data": [
    {
      "codigoCliente": 1,
      "montoPropuesto": 150,
      "comentario": "Pago parcial",
      "fechaRegistro": "2026-04-27T10:20:30"
    }
  ]
}

---

### 📍 POST - Registrar intención

POST /api/intencionpago

Headers:
Content-Type: application/json

Body:

{
  "codigoCliente": 1,
  "montoPropuesto": 150,
  "comentario": "Puedo pagar en cuotas"
}

Respuesta exitosa:

{
  "exito": true,
  "mensaje": "Operación realizada correctamente",
  "data": {
    "codigoCliente": 1,
    "montoPropuesto": 150,
    "comentario": "Puedo pagar en cuotas",
    "fechaRegistro": "2026-04-27T10:30:00"
  }
}

---

## 7. 🧠 Reglas de negocio

- Se valida que el cliente exista
- El monto debe ser mayor a 0
- El comentario es obligatorio
- Se calcula la mora máxima del cliente
- Si la mora es mayor a 120 días, el cliente aplica a campaña de descuento

---

## 8. 💻 Funcionalidades del frontend

- Registro de intención de pago
- Validaciones en tiempo real
- Visualización de historial en tabla
- Indicador de carga (loading)
- Navegación entre registro e historial

---

## 9. 🔗 Integración

El frontend consume el backend en:

http://localhost:5151/api/intencionpago

Comunicación mediante HTTP REST con JSON.

---

## 10. 🧪 Pruebas con Postman

GET:
http://localhost:5151/api/intencionpago

POST:
http://localhost:5151/api/intencionpago

Body:

{
  "codigoCliente": 2,
  "montoPropuesto": 200,
  "comentario": "Pago mensual"
}

---

## 11. 📝 Notas importantes

- No se utiliza base de datos
- Datos simulados en memoria
- Proyecto separado en frontend y backend
- Diseñado como prueba técnica

---

## 🏁 Resultado

Este proyecto demuestra:

- Consumo de API REST
- Separación de frontend y backend
- Lógica de negocio en .NET
- Manejo de formularios en Angular
- Validaciones y flujo de datos