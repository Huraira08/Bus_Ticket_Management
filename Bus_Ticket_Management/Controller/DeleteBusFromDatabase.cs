using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Management.Controller
{
    class DeleteBusFromDatabase
    {
        public static void DeleteBus(string busId)
        {
            Model.DatabaseConnection.DeleteBus(busId);
        }
    }
}
