//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyanmarTravellers.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public long id { get; set; }
        public long course_id { get; set; }
        public long seat_id { get; set; }
        public Nullable<long> sale_id { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Seat Seat { get; set; }
        public virtual Sale Sale { get; set; }

        public override string ToString()
        {
            var result = "";

            result += Seat.seat_no + " | ";
            result += Course.FromLocation.name + " | ";
            result += Course.ToLocation.name + " | ";
            result += Course.Bus.plate_no;

            return result;
        }
    }
}
