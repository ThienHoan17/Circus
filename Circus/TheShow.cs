using System;
using System.Collections.Generic;
using System.Text;

namespace Circus
{
    class TheShow
    {
        List<Viewer> Viewers = new List<Viewer>();
        List<Employee> Employees = new List<Employee>();
        List<Animal> Animals = new List<Animal>();
        ~TheShow()
        {

        }
        public TheShow()
        {

        }
        public TheShow(List<Viewer> _Viewer, List<Employee> _Employee, List<Animal> _Animal)
        {
            Viewers = _Viewer;
            Employees = _Employee;
            Animals = _Animal;
        }
        void CheckSeat(List<Viewer> List, Viewer Check)
        {
            int i = 0;
            while (i < List.Count)
            {
                begin:
                if(Check.SeatCode == List[i].SeatCode)
                {
                    Console.WriteLine("This seat code is already tanken!");
                    Console.WriteLine("Re-enter your seat code!");
                    Check.SeatCode = Console.ReadLine();
                }
                if (Check.SeatCode == List[i].SeatCode) goto begin;
                i++;
            }    
        }
        public void Input()
        {
            int CheckChoice;
            int NumOfViewer = 0;
            int NumOfEmp = 0;
            int NumOfAni = 0;
            
            //Thông tin buổi diễn
            Console.WriteLine("Number of Viewer come to the Show:");
            NumOfViewer = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of Employee:");
            NumOfEmp = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of Animal:");
            NumOfAni = int.Parse(Console.ReadLine());

            //Nhập số lượng người xem
            for(int i = 0; i < NumOfViewer; i++)
            {
                Console.WriteLine("Enter Viewer's Information:");
                Viewer viewer = new Viewer();
                viewer.InputViewer();
                CheckSeat(Viewers, viewer);
                Viewers.Add(viewer);
            }

            //Nhập số lượng nhân viên
            Console.WriteLine("Employee For the show!");
            for (int i = 0; i < NumOfEmp; i++)
            {
                Console.WriteLine("1.Acrobatic Actor");
                Console.WriteLine("2.Balance Actor");
                Console.WriteLine("3.Jungle Actor");
                Console.WriteLine("4.Clown");
                Console.WriteLine("5.Security");
                Console.WriteLine("6.Cleaner");
                Console.WriteLine("Your Choice:");
            Choice:
                CheckChoice = int.Parse(Console.ReadLine());
                if (CheckChoice < 1 || CheckChoice > 6)
                {
                    Console.WriteLine("re-enter your choice!");
                    goto Choice;
                }
                switch (CheckChoice)
                {
                    case 1:
                        AcrobaticActor actor1 = new AcrobaticActor();
                        actor1.InputEmployee();
                        Employees.Add(actor1);
                        break;
                    case 2:
                        BalanceActor actor2 = new BalanceActor();
                        actor2.InputEmployee();
                        Employees.Add(actor2);
                        break;
                    case 3:
                        JungleActor actor3 = new JungleActor();
                        actor3.InputEmployee();
                        Employees.Add(actor3);
                        break;
                    case 4:
                        Clown actor4 = new Clown();
                        actor4.InputEmployee();
                        Employees.Add(actor4);
                        break;
                    case 5:
                        Security emp1 = new Security();
                        emp1.InputEmployee();
                        Employees.Add(emp1);
                        break;
                    case 6:
                        Cleaner emp2 = new Cleaner();
                        emp2.InputEmployee();
                        Employees.Add(emp2);
                        break;
                }    
            }

            //Diễn viên thú cho buổi diễn
            Console.WriteLine("Animals For the Show!");
            for(int i = 0; i < NumOfAni; i++)
            {
                AnimalPerforment ani = new AnimalPerforment();
                ani.InputAnimal();
                Animals.Add(ani);
            }    
        }
        public void Output()
        {
            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine("Viewer come to the Show!");
            foreach(var item in Viewers)
            {
                item.OutputViewer();
                Console.WriteLine("________________________");
            }
            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine("Employees for the show!");
            foreach (var item in Employees)
            {
                item.OutputEmployee();
                Console.WriteLine("________________________");
            }
            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine("Animals for the show!");
            foreach (var item in Animals)
            {
                item.OutputAnimal();
                Console.WriteLine("________________________");
            }
            Console.WriteLine("Sum of ticket:" + TotalProfit(Viewers));
        }
        public int TotalProfit(List<Viewer> List)
        {
            int Total = 0;
            for(int i = 0; i < List.Count; i++)
            {
                Total += List[i].TicketPrice;
            }
            return Total;
        }
    }
}
