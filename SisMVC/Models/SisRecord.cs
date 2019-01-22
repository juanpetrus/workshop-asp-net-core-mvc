using System;
using SisMVC.Models.Enums;

namespace SisMVC.Models
{
    public class SisRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SisStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SisRecord()
        {
        }

        public SisRecord(int id, DateTime date, double amount, SisStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
