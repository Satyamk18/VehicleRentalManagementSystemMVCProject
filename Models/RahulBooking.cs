﻿using System;
using System.Collections.Generic;

#nullable disable

namespace VehicleRentalManagementProject.Models
{
    public partial class RahulBooking
    {
        public int Bookingid { get; set; }
        public int? Uid { get; set; }
        public int? Bid { get; set; }

        public virtual RahulBook BidNavigation { get; set; }
        public virtual RahulUser UidNavigation { get; set; }
    }
}
