namespace 骰子比大小
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Player = 0, Rot = 0;
            Console.WriteLine("开始游戏");
            Console.WriteLine("一共十轮");
            for (int i = 0; i < 10; i++)
            { 
            Console.WriteLine($"现在是第{i+1}轮");
                Console.ReadKey(true);
                Console.WriteLine("电脑回合");
                
                int RotDice=Random.Shared.Next(1,7);
                Console.WriteLine($"电脑的点数是{RotDice}");
                Console.WriteLine("点击任意地方继续");
                Console.ReadKey(true);
               
                int PlayerDice=Random.Shared.Next(1,7);
                Console.WriteLine($"你的点数是{PlayerDice}");
                if (RotDice < PlayerDice)
                {
                    Player++;
                    Console.WriteLine("这次你赢");
                }
                else if (RotDice > PlayerDice)
                {
                    Rot++;
                    Console.WriteLine("这次你输");
                }
                else 
                {
                Console.WriteLine("打平了");
                   
                }
                Console.WriteLine($"当前你与电脑的比分为{Player}：{Rot}\n");
                Console.WriteLine("点击任意地方下一步");
                Console.ReadKey(true);
            }
            Console.WriteLine("游戏结束");
            Console.WriteLine($"最终你的比分为{Player}：{Rot}");
            if (Player > Rot)
            {
                Console.WriteLine("你赢了");
            }
            else if (Player < Rot)
            {
                Console.WriteLine("你输了");
            }
            else
            {
                Console.WriteLine("打平了");
            }
            Console.WriteLine("点击任意键退出");
            Console.ReadKey(true);
        }
    }
}
