using CobranzaAPI.Models;

namespace CobranzaAPI.Data;

public static class FakeOperaciones
{
    public static List<Operacion> Operaciones = new()
    {
        new Operacion { IdOperacion = 1236, CodigoCliente = 1, Mora = 90, Estado = "Castigada" },
        new Operacion { IdOperacion = 4567, CodigoCliente = 2, Mora = 33, Estado = "Mora" },
        new Operacion { IdOperacion = 9877, CodigoCliente = 3, Mora = 60, Estado = "Mora" },
        new Operacion { IdOperacion = 4444, CodigoCliente = 5, Mora = -50, Estado = "Al día" },
        new Operacion { IdOperacion = 5555, CodigoCliente = 6, Mora = 16, Estado = "Mora" },
        new Operacion { IdOperacion = 7777, CodigoCliente = 7, Mora = 91, Estado = "Mora" },
        new Operacion { IdOperacion = 9991, CodigoCliente = 1, Mora = 12, Estado = "Mora" },
        new Operacion { IdOperacion = 9992, CodigoCliente = 2, Mora = 5, Estado = "Mora" },
        new Operacion { IdOperacion = 9993, CodigoCliente = 2, Mora = 60, Estado = "Mora" },
        new Operacion { IdOperacion = 9994, CodigoCliente = 3, Mora = -50, Estado = "Al día" },
        new Operacion { IdOperacion = 9995, CodigoCliente = 6, Mora = 16, Estado = "Mora" },


        new Operacion
        {
            IdOperacion = 8888,
            CodigoCliente = 8,
            Mora = 180,
            Estado = "Castigada"
        }

    };
}