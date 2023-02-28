using System;
using System.Collections.Generic;

#nullable disable

namespace VehicleRentalManagementProject.Models
{
    public partial class ManasTicket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public int AdultCount { get; set; }
        public int RoomNo { get; set; }
        public int FerryId { get; set; }

        public virtual ManasFerry Ferry { get; set; }
    }
}
