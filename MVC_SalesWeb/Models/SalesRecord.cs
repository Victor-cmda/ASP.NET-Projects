using MVC_SalesWeb.Models.Enums;
using System;

namespace MVC_SalesWeb.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amont { get; set; }
        public SalesStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
            
        }

        public SalesRecord(int id, DateTime date, double amont, SalesStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amont = amont;
            Status = status;
            Seller = seller;
        }
    }
}
