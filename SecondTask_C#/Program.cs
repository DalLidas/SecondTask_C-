using static Interfaces.Interface;

namespace SecondTask_C_
{
    internal class Program
    {
        static public void БездарнаяФункция()
        {
            String msg = "Creator: Mukhametov Danil 423 group version 2";
            Console.SetCursorPosition((Console.WindowWidth - msg.Length) / 2, (Console.WindowHeight - 1) / 2);
            Console.WriteLine(msg);
            Console.ReadKey(true);
        }


        static void Main(string[] args)
        {
            List<double> arr = new List<double>();
            String resultTable = "";

            БездарнаяФункция();

            MainHandle(arr, ref resultTable);

            Console.ReadKey(true);

            return;
        }
    }
}
