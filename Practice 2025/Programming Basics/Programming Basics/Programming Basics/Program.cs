// See https://aka.ms/new-console-template for more information
decimal strawberrysInLv = decimal.Parse(Console.ReadLine());
decimal bannanasKilo = decimal.Parse(Console.ReadLine());
decimal orangesKilo = decimal.Parse(Console.ReadLine());
decimal raspberriesKilo = decimal.Parse(Console.ReadLine());
decimal strawberrysKilo = decimal.Parse(Console.ReadLine());

decimal raspberriesPrice = strawberrysInLv / 2;
decimal orangesPrice = raspberriesPrice -(0.4m * raspberriesPrice);
decimal bannanasPrice = raspberriesPrice - (raspberriesPrice * 0.8m);

decimal raspberriesSum = raspberriesKilo * raspberriesPrice;
decimal orangesSum = orangesKilo * orangesPrice;
decimal bannanasSum = bannanasPrice * bannanasKilo;
decimal strawberrysSum = strawberrysInLv * strawberrysKilo;

decimal allSum = Math.Round(raspberriesSum + orangesSum + bannanasSum + strawberrysSum, 2);
Console.WriteLine(allSum.ToString());






