using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPricee = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());
            int trashetHeadset = lostGames / 2;
            int trashetMouse = lostGames / 3;
            int trashetKeyboard = lostGames / 6;
            int trashetDisplay = lostGames / 12;
            decimal headSet = headsetPrice * trashetHeadset;
            decimal mouses = mousePrice * trashetMouse;
            decimal keyboard = keyboardPricee * trashetKeyboard;
            decimal display = displayPrice * trashetDisplay;
            //Console.WriteLine(headSet);
            decimal allPrice = headSet + mouses + keyboard + display;
            Console.WriteLine($"Rage expenses: {allPrice:f2} lv.");
        }
    }
}
