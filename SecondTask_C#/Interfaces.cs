using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using SortingMethods;

namespace Interfaces
{
    internal enum Modes
    {
        ArrayFillMode = ConsoleKey.F1,
        ArrayEditMode = ConsoleKey.F2,
        SortCompareMode = ConsoleKey.F3,
        loadMode = ConsoleKey.F4,
        saveMode = ConsoleKey.F5,
        exitMode = ConsoleKey.Escape,

    }


    internal class Interface
    {
        static public void DrawBorder(String border = "-")
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write(border);
            }
            Console.WriteLine();
        }


        static public void DrawArrayFillMenu(List<double> arr)
        {
            String menuLabel = "ArrayFillMenu";
            String keyBinds = "F1 - ArrayFill, F2 - ArrayEdit, F3 - SortCompare, F4 - LoadArray, F5 - SaveArray, Esc - Exit";
            String description1 = "F9 - Delete all number from array";
            String description2 = "F10 - Generate number for array";

            Console.Clear();

            DrawBorder("=");
            Console.SetCursorPosition((Console.WindowWidth - menuLabel.Length) / 2, 0);
            Console.WriteLine(menuLabel);

            Console.SetCursorPosition((Console.WindowWidth - keyBinds.Length) / 2, 1);
            Console.WriteLine(keyBinds);
            DrawBorder("=");

            Console.SetCursorPosition((Console.WindowWidth - description1.Length) / 2, 3);
            Console.WriteLine(description1);
            DrawBorder();

            Console.SetCursorPosition((Console.WindowWidth - description2.Length) / 2, 5);
            Console.WriteLine(description2);
            DrawBorder("=");

            int i = 0;
            arr.ForEach(x => Console.Write("Arr[" + ++i + "]: " + x + "; "));

            Console.WriteLine();
            DrawBorder("=");
        }


        static public void DrawGenerateArrayMenu(List<double> arr, int numCount, int precision, int minNum, int maxNum)
        {
            String menuLabel = "GenerateArraMenu";
            String keyBinds = "F1 - ArrayFill, F2 - ArrayEdit, F3 - SortCompare, F4 - LoadArray, F5 - SaveArray, Esc - Exit";
            String description1 = "F9 - Delete all number from array";
            String description2 = "numCount: " + Convert.ToString(numCount) + ", minNum: " + Convert.ToString(minNum) + ", maxNum: " + Convert.ToString(maxNum) + ", precision: " + Convert.ToString(precision);


            Console.Clear();

            DrawBorder("=");
            Console.SetCursorPosition((Console.WindowWidth - menuLabel.Length) / 2, 0);
            Console.WriteLine(menuLabel);

            Console.SetCursorPosition((Console.WindowWidth - keyBinds.Length) / 2, 1);
            Console.WriteLine(keyBinds);
            DrawBorder("=");

            Console.SetCursorPosition((Console.WindowWidth - description1.Length) / 2, 3);
            Console.WriteLine(description1);
            DrawBorder();

            Console.SetCursorPosition((Console.WindowWidth - description2.Length) / 2, 5);
            Console.WriteLine(description2);
            DrawBorder("=");

            int i = 0;
            arr.ForEach(x => Console.Write("Arr[" + ++i + "]: " + x + "; "));

            Console.WriteLine();
            DrawBorder("=");
        }


        static public void DrawArrayEditMenu(List<double> arr)
        {
            String menuLabel = "DrawArrayEditMenu";
            String keyBinds = "F1 - ArrayFill, F2 - ArrayEdit, F3 - SortCompare, F4 - LoadArray, F5 - SaveArray, Esc - Exit";
            String description = "F9 - Delete all number from array";

            Console.Clear();

            DrawBorder("=");
            Console.SetCursorPosition((Console.WindowWidth - menuLabel.Length) / 2, 0);
            Console.WriteLine(menuLabel);

            Console.SetCursorPosition((Console.WindowWidth - keyBinds.Length) / 2, 1);
            Console.WriteLine(keyBinds);
            DrawBorder("=");

            Console.SetCursorPosition((Console.WindowWidth - description.Length) / 2, 3);
            Console.WriteLine(description);
            DrawBorder("=");

            int i = 0;
            arr.ForEach( x => Console.Write("Arr[" + ++i + "]: " + x + "; "));

            Console.WriteLine();
            DrawBorder("=");
        }




        static public void MainHandle(List<double> arr)
        {
            Modes mod = Modes.ArrayFillMode;

            while (true)
            {
                switch (mod)
                {
                    case Modes.ArrayFillMode:
                        ArrayFillHandle(arr, ref mod);
                        break;

                    case Modes.ArrayEditMode:
                        ArrayEditHandle(arr, ref mod);
                        break;

                    case Modes.SortCompareMode:
                        SortCompareHandle(arr, ref mod);
                        break;

                    case Modes.loadMode:
                        
                        break;

                    case Modes.saveMode:
                       
                        break;

                    case Modes.exitMode:
                        Console.Clear();
                        Console.WriteLine("Goodbye");
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Error");
                        return;
                }
            }
        }


        static public Modes KeyToMode(ConsoleKey key)
        {
            Modes mod = (Modes)key;
            return (mod);
        }


        static public void ArrayFillHandle(List<double> arr, ref Modes gMod)
        {
            String input = "";
            double num = double.NaN;
            ConsoleKey lMod;

            bool randomFillFlag = false;

            while (true)
            {
                DrawArrayFillMenu(arr);

                // number enter
                while (true)
                {
                    try
                    {
                        lMod = InputHandler(ref input, ("Num[" + (arr.Count + 1) + "]: "), new List<ConsoleKey> { ConsoleKey.F9, ConsoleKey.F10});
                        if (lMod == ConsoleKey.F9) { arr.Clear(); gMod = Modes.ArrayFillMode; return; }
                        else if (lMod == ConsoleKey.F10) { randomFillFlag = true; break; }
                        else if (lMod != ConsoleKey.Enter) { gMod = KeyToMode(lMod); return; }

                        num = Convert.ToDouble(input);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Not a double number. Try again\n");
                        continue;
                    }
                    break;
                }

                if (randomFillFlag)
                {
                    RandomGenerateArrayHandler(arr, ref gMod);
                    randomFillFlag = false;
                }
                else
                {
                    arr.Add(num);
                }
            }
        }


        static public void RandomGenerateArrayHandler(List<double> arr, ref Modes gMod)
        {
            String input = "";
            ConsoleKey lMod;

            Random rnd = new Random();

            int numCount = 0;
            int precision = 0;
            int minNum = -10;
            int maxNum = 10;

            while (true)
            {
                DrawGenerateArrayMenu(arr, numCount, precision, minNum, maxNum);

                // Enter minimum num 
                while (true)
                {
                    try
                    {
                        lMod = InputHandler(ref input, ("Minimum number: "), new List<ConsoleKey> { ConsoleKey.F9 });
                        if (lMod == ConsoleKey.F9) { arr.Clear(); gMod = Modes.ArrayFillMode; return; }
                        else if (lMod != ConsoleKey.Enter) { gMod = KeyToMode(lMod); return; }

                        minNum = Convert.ToInt32(input);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Not a int number. Try again\n");
                        continue;
                    }
                    break;
                }

                // Enter maximum num 
                while (true)
                {
                    try
                    {
                        lMod = InputHandler(ref input, ("Maximum number: "), new List<ConsoleKey> { ConsoleKey.F9 });
                        if (lMod == ConsoleKey.F9) { arr.Clear(); gMod = Modes.ArrayFillMode; return; }
                        else if (lMod != ConsoleKey.Enter) { gMod = KeyToMode(lMod); return; }

                        maxNum = Convert.ToInt32(input);

                        if (maxNum < minNum) { throw new Exception("Index cant lower then minimum. Try again\n"); }
                    }
                    catch (Exception err)
                    {
                        if (err.Message != "Index cant lower then minimum. Try again\n")
                        {
                            Console.WriteLine("Not a int number. Try again\n");
                        }
                        else
                        {
                            Console.WriteLine(err.Message);
                        }

                        continue;
                    }
                    break;
                }

                // Enter precision
                while (true)
                {
                    try
                    {
                        lMod = InputHandler(ref input, ("Precision: "), new List<ConsoleKey> { ConsoleKey.F9 });
                        if (lMod == ConsoleKey.F9) { arr.Clear(); gMod = Modes.ArrayFillMode; return; }
                        else if (lMod != ConsoleKey.Enter) { gMod = KeyToMode(lMod); return; }

                        precision = Convert.ToInt32(input);
                        if (precision < 0) { throw new Exception("Index cant be negative. Try again\n"); }
                    }
                    catch (Exception err)
                    {
                        if (err.Message != "Index cant be negative. Try again\n")
                        {
                            Console.WriteLine("Not a int number. Try again\n");
                        }
                        else
                        {
                            Console.WriteLine(err.Message);
                        }

                        continue;
                    }
                    break;
                }

                // Enter count of number 
                while (true)
                {
                    try
                    {
                        lMod = InputHandler(ref input, ("Count of random numbers: "), new List<ConsoleKey> { ConsoleKey.F9 });
                        if (lMod == ConsoleKey.F9) { arr.Clear(); gMod = Modes.ArrayFillMode; return; }
                        else if (lMod != ConsoleKey.Enter) { gMod = KeyToMode(lMod); return; }

                        numCount = Convert.ToInt32(input);

                        if (numCount < 0) { throw new Exception("Index cant be negative. Try again\n"); }
                    }
                    catch (Exception err)
                    {
                        if (err.Message != "Index cant be negative. Try again\n")
                        {
                            Console.WriteLine("Not a int number. Try again\n");
                        }
                        else
                        {
                            Console.WriteLine(err.Message);
                        }

                        continue;
                    }
                    break;
                }

                // Generate numbers
                try
                {
                    for (int i = 0; i < numCount; i++)
                    {
                        arr.Add(Convert.ToDouble(rnd.Next(Convert.ToInt32(minNum * Math.Pow(10, precision)), Convert.ToInt32(maxNum * Math.Pow(10, precision)))) / Math.Pow(10, precision));
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Very big precision or randome range");
                    continue;
                }
            } 
        }


        static public void ArrayEditHandle(List<double> arr, ref Modes gMod)
        {
            String input = "";
            int index = -1;
            double num = double.NaN;
            ConsoleKey lMod;

            while (true)
            {
                DrawArrayEditMenu(arr);

                // Index enter
                while (true)
                {
                    try
                    {
                        lMod = InputHandler(ref input, ("Index: "), new List<ConsoleKey> { ConsoleKey.F9 });
                        if (lMod == ConsoleKey.F9) { arr.Clear(); gMod = Modes.ArrayFillMode; return; }
                        else if (lMod != ConsoleKey.Enter) { gMod = KeyToMode(lMod); return; }

                        index = Convert.ToInt32(input);

                        if (index < 0) { throw new Exception("Index cant be negative. Try again\n"); }
                        if (index == 0) { throw new Exception("Index cant zero. Try again\n"); }
                        if (index > arr.Count) { throw new Exception("Index not in range. Try again\n"); }
                    }
                    catch (Exception err)
                    {
                        if (err.Message != "Index cant be negative. Try again\n" &&
                            err.Message != "Index cant zero. Try again\n" &&
                            err.Message != "Index not in range. Try again\n")

                        {
                            Console.WriteLine("Not a double number. Try again\n");
                        }
                        else
                        {
                            Console.WriteLine(err.Message);
                        }
                        continue;
                    }
                    break;
                }

                // Num enter
                while (true)
                {
                    try
                    {
                        lMod = InputHandler(ref input, ("Number: "), new List<ConsoleKey> { ConsoleKey.F9 });
                        if (lMod == ConsoleKey.F9) { arr.Clear(); gMod = Modes.ArrayFillMode; return; }
                        else if (lMod != ConsoleKey.Enter) { gMod = KeyToMode(lMod); return; }

                        num = Convert.ToDouble(input);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Not a double number. Try again\n");
                        continue;
                    }
                    break;
                }

                arr[index-1] = num;
            }
        }


        static public void SortCompareHandle(List<double> arr, ref Modes gMod)
        {
            String input = "";
            int index = -1;
            double num = double.NaN;
            ConsoleKey lMod;

            while (true)
            {
                DrawArrayEditMenu(arr);

                // Index enter
                while (true)
                {
                    try
                    {
                        lMod = InputHandler(ref input, ("Index: "), new List<ConsoleKey> { ConsoleKey.F9 });
                        if (lMod == ConsoleKey.F9) { arr.Clear(); gMod = Modes.ArrayFillMode; return; }
                        else if (lMod != ConsoleKey.Enter) { gMod = KeyToMode(lMod); return; }

                        index = Convert.ToInt32(input);

                        if (index < 0) { throw new Exception("Index cant be negative. Try again\n"); }
                        if (index == 0) { throw new Exception("Index cant zero. Try again\n"); }
                        if (index > arr.Count) { throw new Exception("Index not in range. Try again\n"); }
                    }
                    catch (Exception err)
                    {
                        if (err.Message != "Index cant be negative. Try again\n" &&
                            err.Message != "Index cant zero. Try again\n" &&
                            err.Message != "Index not in range. Try again\n")
                            
                        {
                            Console.WriteLine("Not a double number. Try again\n");
                        }
                        else
                        {
                            Console.WriteLine(err.Message);
                        }
                        continue;
                    }
                    break;
                }

                // Num enter
                while (true)
                {
                    try
                    {
                        lMod = InputHandler(ref input, ("Number: "), new List<ConsoleKey> { ConsoleKey.F9 });
                        if (lMod == ConsoleKey.F9) { arr.Clear(); gMod = Modes.ArrayFillMode; return; }
                        else if (lMod != ConsoleKey.Enter) { gMod = KeyToMode(lMod); return; }

                        num = Convert.ToDouble(input);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Not a double number. Try again\n");
                        continue;
                    }
                    break;
                }

                arr[index] = num;
            }
        }


        static public ConsoleKey InputHandler(ref String output, String msg = "", List<ConsoleKey> trackedKeys = null)
        {
            String input = "";
            trackedKeys = trackedKeys ?? new List<ConsoleKey>();

            Console.Write(msg);

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                // Tracing Enter 
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    output = input;
                    return ConsoleKey.Enter;
                }

                // Tracing Escape 
                else if (key.Key == ConsoleKey.Escape)
                {
                    output = input;
                    return ConsoleKey.Escape;
                }

                // Tracing Backspace 
                else if (key.Key == ConsoleKey.Backspace || key.Key == ConsoleKey.Delete)
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        input = input.Substring(0, input.Length - 1);

                        Console.CursorLeft -= 1;
                        Console.Write(" ");
                        Console.CursorLeft -= 1;
                    }
                }

                // Tracing F1 - F5 to menu swaps
                else if (key.Key == ConsoleKey.F1 || key.Key == ConsoleKey.F2 || key.Key == ConsoleKey.F3 || key.Key == ConsoleKey.F4 || key.Key == ConsoleKey.F5)
                {
                    output = input;
                    return key.Key;
                }

                // Tracing needed keys
                else if (trackedKeys.Contains(key.Key))
                {
                    output = input;
                    return key.Key;
                }

                // tracing all keys
                else
                {
                    Console.Write(key.KeyChar);
                    input += key.KeyChar;
                }
            }
        }
    }
}
