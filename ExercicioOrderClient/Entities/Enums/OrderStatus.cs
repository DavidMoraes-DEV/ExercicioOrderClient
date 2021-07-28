using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioOrderClient.Entities.Enums
{
    enum OrderStatus
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
