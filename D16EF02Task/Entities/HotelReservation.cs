using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace D16EF02Task.Entities
{
    public class HotelReservation
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public required string FirstName { get; set; }
        [MaxLength(50)]
        public required string LastName { get; set; }
        [MaxLength(50)]
        public required string BirthDay { get; set; }
        [MaxLength(50)]
        public required string Gender { get; set; }
        [MaxLength(50)]
        public required string PhoneNumber { get; set; }
        [MaxLength(50)]
        public required string EmailAddress { get; set; }
        public required int NumberOfGuest { get; set; }
        public required string StreetAddress { get; set; }
        [MaxLength(50)]
        public required string AptSuite { get; set; }
        public required string City { get; set; }
        [MaxLength(50)]
        public required string State { get; set; }
        [Column(TypeName = "nchar(10)")]
        public required string ZipCode { get; set; }
        [Column(TypeName = "nchar(10)")]
        public required string RoomType { get; set; }
        [Column(TypeName = "nchar(10)")]
        public required string RoomFloor { get; set; }
        [Column(TypeName = "nchar(10)")]
        public required string RoomNumber { get; set; }
        public required double TotalBill { get; set; }
        [Column(TypeName = "nchar(10)")]
        public required string PaymentType { get; set; }
        [Column(TypeName = "nchar(10)")]
        public required string CardType { get; set; }
        [MaxLength(50)]
        public required string CardNumber { get; set; }
        [MaxLength(50)]
        public required string CardExp { get; set; }
        [Column(TypeName = "nchar(10)")]
        public required string CardCvc { get; set; }
        [Column(TypeName = "date")]
        public required DateTime ArrivalTime { get; set; }
        [Column(TypeName = "date")]
        public required DateTime LeavingTime { get; set; }
        public required bool CheckIn { get; set; }
        public required int BreakFast { get; set; }
        public required int Lunch { get; set; }
        public required int Dinner { get; set; }
        public required bool Cleaning { get; set; }
        public required bool Towel { get; set; }
        public required bool Surprise { get; set; }
        public required int FoodBill { get; set; }
    }
}
