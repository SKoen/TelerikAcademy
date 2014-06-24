using System;

class PrintCardsNames
{
    static void Main()
    {
        int cards = 52;
        string[] arr = {"Club", "Diamond", "Heart", "Spade"};
        for (int i = 0; i < arr.Length; i++)
        {
            for (int l = 0; l < 12; l++)
            {
                switch (l)
                {
                    case 0: Console.WriteLine("Ace {0}", arr[i]);
                        break;
                    case 1: Console.WriteLine("Two of {0}", arr[i]);
                        break;
                    case 2: Console.WriteLine("Three of {0}", arr[i]);
                        break;
                    case 3: Console.WriteLine("Four of {0}", arr[i]);
                        break;
                    case 4: Console.WriteLine("Five of {0}", arr[i]);
                        break;
                    case 5: Console.WriteLine("Six of {0}", arr[i]);
                        break;
                    case 6: Console.WriteLine("Seven of {0}", arr[i]);
                        break;
                    case 7: Console.WriteLine("Eight of {0}", arr[i]);
                        break;
                    case 8: Console.WriteLine("Nine of {0}", arr[i]);
                        break;
                    case 9: Console.WriteLine("Ten of {0}", arr[i]);
                        break;
                    case 10: Console.WriteLine("Jack of {0}", arr[i]);
                        break;
                    case 11: Console.WriteLine("Queen of {0}", arr[i]);
                        break;
                    case 12: Console.WriteLine("King of {0}", arr[i]);
                        break;
                    default: Console.WriteLine("Not a Card");
                        break;
                }
               
            }
            Console.WriteLine();
        }
    }
}
