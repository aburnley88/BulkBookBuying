﻿using BulkyookBuying.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BulkBookBuying.Models.Models
{
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }
        public string ApplicationuserId { get; set; }
        [ForeignKey("ApplicationuserId")]
        public ApplicationUser ApplicationUser {get; set;}
        [Required]
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        [Required]
        public Double OrderTotal { get; set; }
        public string TrackingNumber { get; set; }
        public string Carrier { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public string TransactionId { get; set; }


        public string PhoneNumber { get; set; }
        public string StreetAddress { get; set; }
        public string  City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Name { get; set; }

    }
}