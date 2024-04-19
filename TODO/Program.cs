using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* TODO list should:
             * Allow me to add to the list
             * allow me to see what's in the list
             * allow me to remove from the list
             * allow me to exit
             */

            Console.WriteLine("TODO list");

            List<string> TODOlist = new List<string>();

            while (true)
            {
                Console.WriteLine("Here what you can do: ");
                Console.WriteLine("0 - exit");
                Console.WriteLine("1 - view TODO list");
                Console.WriteLine("2 - add to TODO list");
                Console.WriteLine("3 - remove from TODO list");

                Console.Write(">");
                string userinput = Console.ReadLine();
                bool ParseResult = int.TryParse(userinput, out int result);
                if (!ParseResult)
                {
                    Console.WriteLine("your input must be from the options");

                    continue;
                }

                if (result == 0)
                {
                    break;
                }

                else if (result == 1)
                {
                    Console.WriteLine("Your TODO list :");
                    // todo: print a different output when the list is empty
                    for (int i = 0; i < TODOlist.Count;i++)
                    {
                        string items = TODOlist[i];
                        Console.WriteLine("\t"+ i+ " - "+ items);
                    }
                }
                else if (result == 2)
                {
                    Console.WriteLine("enter your todo and press enter");
                    Console.Write(">");
                    string newTODOlistitem = Console.ReadLine();
                    TODOlist.Add(newTODOlistitem);

                    // todo : make suer the user input is valid
                }
                else if (result == 3) // removing
                {
                    Console.WriteLine("place enter the number of the item to remove");
                    Console.Write(">");
                    string userinputforremovitems = Console.ReadLine();
                    bool RemoveIndexParseReuslt = int.TryParse(userinputforremovitems, out int RemoveIndex);
                    if (!RemoveIndexParseReuslt)
                    {
                        Console.WriteLine("your input must be from the options");
                        continue;
                    }
                    if (RemoveIndex >= 0 && RemoveIndex < TODOlist.Count)
                    {
                        TODOlist.RemoveAt(RemoveIndex);
                        Console.WriteLine("Item at " + RemoveIndex + " was removed successfully.");

                    }
                    else
                    {
                        Console.WriteLine("input must be less then the size of the list and not a negative number");
                    }
                }
                else
                {
                    Console.WriteLine("invalid opation");
                }
                
            }
            
        }
    }
}
