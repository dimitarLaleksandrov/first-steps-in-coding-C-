using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
                string input = Console.ReadLine();
                double allTickets = 0;
                double studentCounter = 0;
                double standardCounter = 0;
                double kidCounter = 0;
                while (input != "Finish")
                {
                    int availavbeSpace = int.Parse(Console.ReadLine());
                    double currentTicketSell = 0.0;
                    string tiketType = null;
                    while (tiketType != "End" && currentTicketSell < availavbeSpace)
                    {
                        tiketType = Console.ReadLine();
                        if (tiketType == "student")
                        {
                            studentCounter++;
                        }
                        else if (tiketType == "standard")
                        {
                            standardCounter++;
                        }
                        else if (tiketType == "kid")
                        {
                            kidCounter++;
                        }
                        if (tiketType != "End")
                        {
                            currentTicketSell++;
                        }
                    }
                    Console.WriteLine($"{input} - {(currentTicketSell / availavbeSpace) * 100:f2}% full.");
                    allTickets += currentTicketSell;
                    input = Console.ReadLine();
                }
                double allKidTickets = kidCounter / allTickets * 100;
                double allStandardTickets = standardCounter / allTickets * 100;
                double allStudentTickets = studentCounter / allTickets * 100;
                Console.WriteLine($"Total tickets: {allTickets}");
                Console.WriteLine($"{allStudentTickets:f2}% student tickets.");
                Console.WriteLine($"{allStandardTickets:f2}% standard tickets.");
                Console.WriteLine($"{allKidTickets:f2}% kids tickets.");
            }
        }
    }
