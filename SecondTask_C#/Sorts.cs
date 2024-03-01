using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SortingMethods
{
    public abstract  class SortMetrics
    {
        static readonly Stopwatch timer = new Stopwatch();

        private double sortTime = 0;
        private int compareCount = 0;
        private int swapCount = 0;

        protected SortMetrics() { }

        public virtual String GetName() { return ""; }
        public virtual void Sort(List<double> arr) { }

        //
        //Swap operators
        protected void Swap(List<double> arr, int aIndex, int bIndex)
        {
            UpSwapCount();

            var buff = arr[aIndex];
            arr[aIndex] = arr[bIndex];
            arr[bIndex] = buff;
        }

        //
        //Comparison operators
        protected bool Greater(double aValue, double bValue)
        {
            UpCompareCount();

            return aValue > bValue;
        }
        protected bool GreaterE(double aValue, double bValue)
        {
            UpCompareCount();

            return aValue >= bValue;
        }
        protected bool Lower(double aValue, double bValue)
        {
            UpCompareCount();

            return aValue <  bValue;
        }
        protected bool LowerE(double aValue, double bValue)
        {
            UpCompareCount();

            return aValue <= bValue;
        }

        //
        //Increment or Decrement metrics
        protected void UpCompareCount()
        {
            ++compareCount;
        }
        protected void DownCompareCount()
        {
            --compareCount;
        }
        protected void UpSwapCount()
        {
            ++swapCount;
        }
        protected void DownSwapCount()
        {
            --swapCount;
        }

        //
        //measure execution time
        protected void StartTimer()
        {
            timer.Start();
        }
        protected void StopTimer()
        {
            timer.Stop();
            sortTime = timer.Elapsed.TotalMilliseconds;
        }

        //
        //Turn to zero some metrics
        public void NullifySortTime()
        {
            sortTime = 0;
        }
        public void NullifyCompareCount()
        {
            compareCount = 0;
        }
        public void NullifySwapCount()
        {
            swapCount = 0;
        }
        public void NullifyAllMetrics()
        {
            NullifySortTime();
            NullifyCompareCount();
            NullifySwapCount();
        }

        //
        //Get metrics
        public String GetSortTime()
        {
            return sortTime.ToString();
        }
        public String GetCompareCount()
        {
            return compareCount.ToString();
        }
        public String GetSwapCount()
        {
            return swapCount.ToString();
        }
    }

    public class ShellSort : SortMetrics
    {
        public override String GetName() { 
            return "ShellSort"; 
        }
        public override void Sort(List<double> arr)
        {
            StartTimer();

            //расстояние между элементами, которые сравниваются
            var d = arr.Count / 2;
            while (d >= 1)
            {
                for (var i = d; i < arr.Count; i++)
                {
                    var j = i;
                    while ((j >= d) && Greater(arr[j - d], arr[j]))  // (j >= d) && (arr[j - d] > arr[j])
                    {
                        Swap(arr, j, j - d);
                        j = j - d;
                    }
                }

                d = d / 2;
            }

            StopTimer();
        }
    }

    public class ShekerSort : SortMetrics
    {
        public override String GetName()
        {
            return "ShekerSort";
        }
        public override void Sort(List<double> arr)
        {
            StartTimer();
            
            int left = 0, right = arr.Count - 1; // левая и правая границы сортируемой области массива
            int flag = 1;  // флаг наличия перемещений
                           // Выполнение цикла пока левая граница не сомкнётся с правой
                           // и пока в массиве имеются перемещения

            while ((left < right) && flag > 0)
            {
                flag = 0;
                for (int i = left; i < right; i++)  //двигаемся слева направо
                {
                    // если следующий элемент меньше текущего,
                    if (Greater(arr[i], arr[i + 1])) 
                    {             
                        Swap(arr, i, i + 1);  // меняем их местами
                        flag = 1;  // перемещения в этом цикле были
                    }
                }
                right--; // сдвигаем правую границу на предыдущий элемент
                for (int i = right; i > left; i--)  //двигаемся справа налево
                {
                    // если предыдущий элемент больше текущего,
                    if (Greater(arr[i - 1], arr[i])) 
                    {           
                        Swap(arr, i, i - 1);  // меняем их местами
                        flag = 1;  // перемещения в этом цикле были
                    }
                }
                left++; // сдвигаем левую границу на следующий элемент
            }

            StopTimer();
        }
    }
}