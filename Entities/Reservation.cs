using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;


namespace Excecoes.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() 
        {

        }

        public Reservation(int roomNumber, DateTime chekIn, DateTime chekOut)
        {
            RoomNumber = roomNumber;
            CheckIn = chekIn;
            CheckOut = chekOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public  string UpdateDates (DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                return "Error in reservation: Reservation dates for update must be future dates"; 
            }
            
            if (checkOut <= checkIn)
            {
                return "Error in reservation: Reservation dates for update must be future dates";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            return null;
        }

        public override string ToString()
        {
            return "Room"
                + RoomNumber
                + ", chek-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", chek-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
