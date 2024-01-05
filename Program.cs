namespace SN_Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Fan fan1 = new Fan(
                Fan.FanStatus["FAST"],
                10,
                "yellow",
                true
            );

            Fan fan2 = new Fan(
                Fan.FanStatus["MEDIUM"],
                5,
                "blue",
                false
            );

            Console.WriteLine(fan1);
            Console.WriteLine("======================================");
            Console.WriteLine(fan2);
        }
    }
}