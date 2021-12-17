using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; ; i++)
            {
                Console.Write("Нажмите '1' для расчета арифметической прогрессии, '2' для геометрической прогрессии: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Введите первое значение ряда: ");
                    int first = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите номер последнего значения ряда: ");
                    int last = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите значение разницы: ");
                    int dif = Convert.ToInt32(Console.ReadLine());
                    ArithProgression Prog1 = new ArithProgression(dif, first, last);
                    Prog1.SetStart(first);
                    Prog1.GetNext(dif, first, last);
                    Console.WriteLine();
                    Prog1.Resert();
                    Console.Write("Нажмите Enter для продолжения");
                }
                if (choice == 2)
                {
                    Console.Write("Введите первое значение ряда: ");
                    int first = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите номер последнего значения ряда: ");
                    int last = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите значение знаменателя: ");
                    int den = Convert.ToInt32(Console.ReadLine());
                    GeomProgression Prog2 = new GeomProgression(den, first, last);
                    Prog2.SetStart(first);
                    Prog2.GetNext(den, first, last);
                    Console.WriteLine();
                    Prog2.Resert();
                    Console.Write("Нажмите Enter для продолжения");
                }
                else
                    Console.Write("Нажмите Enter и введите '1' или '2'");
                Console.ReadKey();
            }
        }
    }
    interface ISeries
    {
        void SetStart(int first);
        int GetNext(int dif, int first, int last);
        void Resert();
    }
    class ArithProgression : ISeries
    {
        public int Dif { set; get; }
        public int first;
        public int last;
        public int First
        {
            set { first = value; }
            get { return first; }
        }
        public int Last
        {
            set { last = value; }
            get { return last; }
        }
        public ArithProgression(int dif, int first, int last)
        {
            Dif = dif;
            First = first;
            Last = last;
        }
        public void SetStart(int First)
        {
            Console.Write("Ряд: {0}", First);
        }
        public int GetNext(int Dif, int First, int Last)
        {
            for (int j = 1; j < last; j++)
            {
                Console.Write(", {0}", First += Dif);
            }
            return First;
        }
        public void Resert()
        {
            Console.WriteLine("Первое значение: {0}", First);
        }
    }
    class GeomProgression : ISeries
    {
        public int Den { set; get; }
        public int first;
        public int last;
        public int First
        {
            set { first = value; }
            get { return first; }
        }
        public int Last
        {
            set { last = value; }
            get { return last; }
        }
        public GeomProgression(int den, int first, int last)
        {
            Den = den;
            First = first;
            Last = last;
        }
        public void SetStart(int First)
        {
            Console.Write("Ряд: {0}", First);
        }
        public int GetNext(int Den, int First, int Last)
        {
            for (int j = 1; j < Last; j++)
            {
                Console.Write(", {0}", First *= Den);
            }
            return First;
        }
        public void Resert()
        {
            Console.WriteLine("Первое значение: {0}", First);
        }
    }

}
