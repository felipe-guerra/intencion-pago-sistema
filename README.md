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

Clonar el repositorio desde GitHub (público):
git clone https://github.com/felipe-guerra/intencion-pago-sistema.git

### 🔵 Backend (.NET 8)

cd intencion-pago-sistema
cd CobranzaAPI
dotnet restore
dotnet run

URL base:
http://localhost:5151/api/intencionpago

---

### 🟢 Frontend (Angular 17)

cd intencion-pago-sistema
cd intencion-pago-app
npm install
ng serve

URL de la aplicación:
http://localhost:4200

---

## 6. 🔌 Endpoints del API


### 📍 POST - Registrar intención

POST /api/intencionpago

## 🧪 POSTMAN
[http://localhost:5151/api/IntencionPago]

Headers:
Content-Type: application/json

---

### ❌ NO califica:
Body:
{
"codigoCliente": 1,
"montoPropuesto": 500,
"comentario": "Quiero convenio de pago"
}

Respuesta:

{
"exito": true,
"mensaje": "Operación realizada correctamente",
"data": {
"codigoCliente": 1,
"nombreCliente": "JEAN CARLOS ROMERO ARMIJOS",
"moraMaxima": 90,
"aplicaDescuento": false,
"mensaje": "Cliente no califica para descuento"
},
"errores": null
}

---

### ✅ SI califica:

{
"codigoCliente": 8,
"montoPropuesto": 500,
"comentario": "Prueba descuento"
}

Respuesta:

{
"exito": true,
"mensaje": "Operación realizada correctamente",
"data": {
"codigoCliente": 8,
"nombreCliente": "MARIA FERNANDA LOPEZ",
"moraMaxima": 180,
"aplicaDescuento": true,
"mensaje": "Cliente califica para campaña de descuento"
},
"errores": null
}

---

### ❌ NO existe:

{
"codigoCliente": 999,
"montoPropuesto": 500,
"comentario": "Cliente inexistente"
}

Respuesta:

{
"exito": false,
"mensaje": "Cliente no encontrado",
"data": null,
"errores": null
}


### 📍 GET - Obtener historial

GET /api/intencionpago

Descripción:
Retorna todas las intenciones de pago registradas.

Ejemplo de respuesta:

🧪 Desde Postman con GET

GET
http://localhost:5151/api/intencionpago

Respuesta:

{
    "exito": true,
    "mensaje": "Consulta exitosa",
    "data": [
        {
            "codigoCliente": 1,
            "montoPropuesto": 500,
            "comentario": "Quiero convenio de pago",
            "fechaRegistro": "2026-04-27T16:07:46.1054685-05:00",
            "aplicaDescuento": false
        },
        {
            "codigoCliente": 8,
            "montoPropuesto": 500,
            "comentario": "Prueba descuento",
            "fechaRegistro": "2026-04-27T16:08:01.5728673-05:00",
            "aplicaDescuento": true
        }
    ],
    "errores": null
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


## 10. 📝 Notas importantes

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