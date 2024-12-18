namespace DateTimeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2024 - 12 - 24);
            var today = DateTime.Today;
            var now = DateTime.Now;
            //Console.WriteLine("Todays Time In Hour:" + now.Hour);
            //Console.WriteLine("Todays Time In Minute:" + now.Minute);

            var Tomarrow = today.AddDays(1);
            var Yesterday = today.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd hh:mm:ss"));
        }
    }
}
