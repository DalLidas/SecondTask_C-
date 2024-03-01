using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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


        static public void DrawCompareMenu(List<double> arr)
        {
            String menuLabel = "DrawArrayEditMenu";
            String keyBinds = "F1 - ArrayFill, F2 - ArrayEdit, F3 - SortCompare, F4 - LoadArray, F5 - SaveArray, Esc - Exit";
            String description = "";

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
            arr.ForEach(x => Console.Write("Arr[" + ++i + "]: " + x + "; "));

            Console.WriteLine();
            DrawBorder("=");
        }

        
        static public void DrawLoadMenu(List<double> arr)
        {
            String menuLabel = "LoadMenuMenu";
            String keyBinds = "F1 - ArrayFill, F2 - ArrayEdit, F3 - SortCompare, F4 - LoadArray, F5 - SaveArray, Esc - Exit";
            String description = "";

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
            arr.ForEach(x => Console.Write("Arr[" + ++i + "]: " + x + "; "));

            Console.WriteLine();
            DrawBorder("=");
        }

        static public void DrawSaveMenu(List<double> arr)
        {
            String menuLabel = "SaveMenu";
            String keyBinds = "F1 - ArrayFill, F2 - ArrayEdit, F3 - SortCompare, F4 - LoadArray, F5 - SaveArray, Esc - Exit";
            String description = "";

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
            arr.ForEach(x => Console.Write("Arr[" + ++i + "]: " + x + "; "));

            Console.WriteLine();
            DrawBorder("=");
        }
        

        static public void MainHandle(List<double> arr, ref String resultTable)
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
                        SortCompareHandle(arr, ref mod, ref resultTable);
                        break;

                    case Modes.loadMode:
                        LoadHandle(arr, ref mod);
                        break;

                    case Modes.saveMode:
                        SaveHandle(arr, ref mod, ref resultTable);
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

        
        static public void SortCompareHandle(List<double> arr, ref Modes gMod, ref String resultTable)
        {
            String input = "";
            bool errFlag = false;
            ConsoleKey lMod;

            List<double> buff1 = new List<double>(arr);
            List<double> buff2 = new List<double>(arr);
            List<double> corector = new List<double>(arr);

            ShekerSort shekerSort = new ShekerSort();
            ShellSort shellSort = new ShellSort();
            corector.Sort();

            while (true)
            {
                DrawCompareMenu(arr);

                Console.WriteLine("Array: ");
                arr.ForEach(x => Console.Write(x + " "));

                Console.WriteLine("\n\nExpected sorted array: ");
                corector.ForEach(x => Console.Write(x + " "));

                shekerSort.Sort(buff1);
                
                // Sort check
                for (int i = 0; i < buff1.Count; i++)
                {
                    if (buff1[i] != corector[i])
                    {
                        errFlag = true;
                        break;
                    }
                }

                shellSort.Sort(buff2);

                // Sort check
                for (int i = 0; i < buff1.Count; i++)
                {
                    if (buff1[i] != corector[i])
                    {
                        errFlag = true;
                        break;
                    }
                }

                if (errFlag)
                {
                    errFlag = false;
                    Console.WriteLine("\nSorting error");
                    Console.ReadKey(true);
                    continue;
                }

                Console.WriteLine("\n\nShekerResult: ");
                buff1.ForEach(x => Console.Write(x + " "));
                Console.WriteLine("\n\nShellResult: ");
                buff2.ForEach(x => Console.Write(x + " "));

                resultTable = SortCompareTable(shekerSort, shellSort);

                Console.WriteLine('\n' + resultTable);

                // Save expression
                while (true)
                {
                    try
                    {
                        lMod = InputHandler(ref input, "Do you want save result of sort metrics? (Y/N): ");
                        if (lMod != ConsoleKey.Enter) { gMod = KeyToMode(lMod); return; }
                        if (input == "Y" || input == "y") { gMod = Modes.saveMode; return; }
                        else if (input == "N" || input == "n") { break; }
                        else { continue; }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
            }
        }


        static public String SortCompareTable(SortMetrics metrics1, SortMetrics metrics2)
        {
            String str0 = String.Format("|{0,13}|{1,13}|{2,13}|{3,13}|", "", "CompareCount", "SwapCount", "SortTime");
            String str1 = String.Format("|{0,13}|{1,13}|{2,13}|{3,13}|", metrics1.GetName(), metrics1.GetCompareCount(), metrics1.GetSwapCount(), metrics1.GetSortTime());
            String str2 = String.Format("|{0,13}|{1,13}|{2,13}|{3,13}|", metrics2.GetName(), metrics2.GetCompareCount(), metrics2.GetSwapCount(), metrics2.GetSortTime());

            String resultTable = "";

            for (int i = 0; i < str1.Length; i++)
            {
                if (i % 14 == 0)
                {
                    resultTable += "+";
                }
                else
                {
                    resultTable += "-";
                }
            }

            resultTable += '\n';
            resultTable += str0;
            resultTable += '\n';

            for (int i = 0; i < str1.Length; i++)
            {
                if (i % 14 == 0)
                {
                    resultTable += "+";
                }
                else
                {
                    resultTable += "-";
                }
            }

            resultTable += '\n';
            resultTable += str1;
            resultTable += '\n';
            resultTable += str2;
            resultTable += '\n';

            for (int i = 0; i < str1.Length; i++)
            {
                if (i % 14 == 0)
                {
                    resultTable += "+";
                }
                else
                {
                    resultTable += "-";
                }
            }

            resultTable += '\n';

            return resultTable;
        }


        static public void LoadHandle(List<double> arr, ref Modes gMod)
        {
            String input = "";
            ConsoleKey lMod;

            while (true)
            {
                DrawLoadMenu(arr);

                // File path enter
                while (true)
                {
                    try
                    {
                        lMod = InputHandler(ref input, "File path: ");
                        if (lMod != ConsoleKey.Enter) { gMod = KeyToMode(lMod); return; }
                        if (!System.IO.File.Exists(input)) { throw new Exception("Not correct file path. Try again\n"); }
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message);
                        continue;
                    }
                    break;
                }

                
                try
                {
                    // Read all string from file
                    String[] fileData = System.IO.File.ReadAllLines(input);
                    String str = fileData[1];
                    arr.Clear();
                    String buff = "";

                    // Read num from string
                    for (int i = 0; i < str.Length; ++i)
                    {
                        if (str[i] != ' ')
                        {
                            buff += str[i];
                        }
                        else
                        {
                            arr.Add(Convert.ToDouble(buff));
                            buff = "";
                        }
                    }
                    
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }


        static public void SaveHandle(List<double> arr, ref Modes gMod, ref String resultTable)
        {
            String input = "";
            ConsoleKey lMod;
            List<double> corector = new List<double>(arr);
            corector.Sort();

            while (true)
            {
                DrawSaveMenu(arr);

                if (resultTable != "")
                {
                    Console.WriteLine("Sorted array: ");
                    corector.ForEach(x => Console.Write(x + " "));
                }
                Console.WriteLine('\n');

                // File path enter
                while (true)
                {
                    try
                    {
                        lMod = InputHandler(ref input, "File path: ");
                        if (lMod != ConsoleKey.Enter) { gMod = KeyToMode(lMod); return; }
                        if (System.IO.File.Exists(input)) { throw new Exception("File alredy exist. Try again\n"); }
                        if (!MaskFit(input)) { throw new Exception("Not correct file path. Try again\n"); }
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message);
                        continue;
                    }
                    break;
                }

                try
                {
                    using (System.IO.StreamWriter fileStream = new System.IO.StreamWriter(input))
                    {

                        fileStream.WriteLine("Array:");
                        for (int i = 0; i < arr.Count; ++i)
                        {
                            fileStream.Write(arr[i] + " ");
                        }

                        if (resultTable != "")
                        {
                            fileStream.WriteLine("\nSortedArray:");
                            for (int i = 0; i < corector.Count; ++i)
                            {
                                fileStream.Write(corector[i] + " ");
                            }
                            fileStream.WriteLine('\n' + resultTable);
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error while write to file. Try again\n");
                    continue;
                }


                Console.WriteLine("All data saved");
                Console.ReadKey(true);
            }
        }


        static public bool MaskFit(string filePath)
        {
            Regex mask = new Regex("((/./)?([cC][oO][nN]))|((/./)?([cC][oO][nN]\\.))|((/./)?([cC][oO][nN]\\.)(.*))");

            return !mask.IsMatch(filePath);
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
