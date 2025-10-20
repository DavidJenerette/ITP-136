using System.ComponentModel.Design;

namespace Mid_Term_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double BagTotal, SeatTotal;
            string Name, Address, Date;
            Console.WriteLine("Welcome to Reynold's Airlines");
            Console.WriteLine("To schedule a flight we will need some information first");
            Console.WriteLine("What is your name?");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("What is your address");
            Address = Convert.ToString(Console.ReadLine());
            Console.WriteLine("What is today's date (Please enter in a MM/DD/YY format)");
            Date = Convert.ToString(Console.ReadLine());

            BagTotal = Baggage();
            Console.ReadKey();
            SeatTotal = Seats();
            Console.ReadKey();
            Receipt(BagTotal, SeatTotal, Name, Address, Date);
        }

        static double Baggage()
        {
            double x, y = 25;
            double BagTotal;
            Console.WriteLine("Do you have bags to check? ($25 fee per bag)");
            Console.WriteLine("Please input the number of bags. Input 0 if there are no bags.");
            x = Convert.ToDouble(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("There are no bags to check so no additional fee will be charged");
                BagTotal = x * y;
                Console.WriteLine("Your total baggage fee is " + BagTotal.ToString("C"));
            }
            else
            {
                if (x > 0)
                {
                    Console.WriteLine(Convert.ToDouble(x) + " bags will be checked for this flight");
                    BagTotal = x * y;
                    Console.WriteLine("Your total baggage fee is " + BagTotal.ToString("C"));
                }
            }
            BagTotal = x * y;
            return BagTotal;
        }
        static double Seats()
        {
            double x, y = 30;
            double SeatTotal;
            Console.WriteLine("Do you want to have VIP seats during your flight? ($30 fee per bag)");
            Console.WriteLine("Please input the number of seats. Input 0 if you don't want any");
            x = Convert.ToDouble(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("No VIP seats are being purchased so no additional fee will be charged");
                SeatTotal = x * y;
                Console.WriteLine("Your total fee for VIP seats is " + SeatTotal.ToString("C"));
            }
            else
            {
                if (x > 0)
                {
                    Console.WriteLine(Convert.ToDouble(x) + " VIP seats will be reserved for your flight");
                    SeatTotal = x * y;
                    Console.WriteLine("Your total fee for VIP seats is " + SeatTotal.ToString("C"));
                }
            }
            SeatTotal = x * y;
            return SeatTotal;
        }
        static void Receipt(double BagTotal, double SeatTotal, string Name, string Address, string Date)
        {
            double Ticket = 120;
            double Tax1 = 1.05;
            double Tax2 = .05;
            double TaxAmount;
            double Subtotal;
            double Total;
            Subtotal = Ticket + BagTotal + SeatTotal;
            TaxAmount = Subtotal * Tax2;
            Total = Subtotal * Tax1;
            
            Console.WriteLine("==================================");
            Console.WriteLine("        Reynolds Airlines         ");
            Console.WriteLine("==================================");
            Console.WriteLine("      Phone: (555)-555-5555       ");
            Console.WriteLine("     Address: 123 Parham Rd.       ");
            Console.WriteLine("                                  ");
            Console.WriteLine("  California Ticket - " + Ticket.ToString("C"));
            Console.WriteLine("    Baggage Fee - " + BagTotal.ToString("C"));
            Console.WriteLine("   VIP Seats Fee - " + SeatTotal.ToString("C"));
            Console.WriteLine("                                  ");
            Console.WriteLine("         Subtotal - " + Subtotal.ToString("C"));
            Console.WriteLine("            Tax - " + TaxAmount.ToString("C"));
            Console.WriteLine("          Total - " + Total.ToString("C"));
            Console.WriteLine("==================================");
            Console.WriteLine("       Name: " + Name);
            Console.WriteLine("      Address: " + Address);
            Console.WriteLine("       Date: " + Date);
            Console.WriteLine("      Card: 5555 5555 5555 5555");
            Console.WriteLine("                                  ");
            Console.WriteLine("Thank you for using Reynolds Airlines");
        }
    }
}
