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

        public void UpdateDates (DateTime chackIn, DateTime checkOut)
        {
            CheckIn = chackIn;
            CheckOut = checkOut;   
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
