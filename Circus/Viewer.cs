using System;
using System.Collections.Generic;
using System.Text;

namespace Circus
{
    class Viewer
    {
        private string vName;
        private string vSeatCode;
        private int vAge;
        private int vTicketPrice;

        public string Name { get => vName; set => vName = value; }
        public string SeatCode { get => vSeatCode; set => vSeatCode = value; }
        public int Age { get => vAge; set => vAge = value; }
        public int TicketPrice { get => vTicketPrice; set => vTicketPrice = value; }
        ~Viewer()
        {

        }
        public Viewer()
        {

        }
        public Viewer(string _vName, string _vSeatCode, int _vAge, int _vTicketPrice)
        {
            vName = _vName;
            vAge = _vAge;
            vSeatCode = _vSeatCode;
            vTicketPrice = _vTicketPrice;
        }
        
        public void InputViewer()
        {
            Console.WriteLine("Input name of viewer:");
            vName = Console.ReadLine();
            Console.WriteLine("Input Age of viewer:");
            vAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Input viewer's seatcode:");
            Checkpoint:
            vSeatCode = Console.ReadLine();
            if (CountTicketPrice() == 0)
            {
                Console.WriteLine("This seat code is not exist!");
                Console.WriteLine("Re-enter your seat code!");
                goto Checkpoint;
            }
        }
        public void OutputViewer()
        {
            Console.WriteLine("Viewer's name: " + vName);
            Console.WriteLine("Viewer's age: " + vAge);
            Console.WriteLine("Viewer's seat code: " + vSeatCode);
            Console.WriteLine("View's ticket price: " + vTicketPrice);
        }
        int CountTicketPrice()
        {
            //check ghế xem tốt nhất
            if (vSeatCode.StartsWith("A") || vSeatCode.StartsWith("B")) return vTicketPrice = 10;
            else if (vSeatCode.StartsWith("C") || vSeatCode.StartsWith("D")) return vTicketPrice = 9;
            else if (vSeatCode.StartsWith("E") || vSeatCode.StartsWith("F")) return vTicketPrice = 8;
            else return 0;
        }
    }
}
