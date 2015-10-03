using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
-Добавить поддержку операций с векторами
*/
namespace ProgramLogicName
{
    class ProgramLogic
    {
       
        public void VectorOps()
        {
            Console.WriteLine("Выберите номер операции с векторами:\n\n1) Найти орт вектора\n2) Найти длину вектора\n3) Найти сумму векторов");
            int switcher = int.Parse(Console.ReadLine());
            switch (switcher)
            {
                case 1:
                                        VecOrt();
                    break;
                case 2:
                    VecLen();
                    break;
                case 3:
                    VecSumm();
                    break;
            };
        }
        public void VecLen()
        {
            Console.WriteLine("Введите координату x вектора");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y вектора");
            double y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату z вектора");
            double z = int.Parse(Console.ReadLine());
            double len = Math.Sqrt(x * x + y * y + z * z);
            Console.WriteLine("Длина вектора = " + Math.Round(len, 4));
        }
        public void MatrixOps()
        {
            Console.WriteLine("Выберите номер операции с матрицами:\n\n1) Найти определитель матрицы\n2) Найти транспонированную матрицу");
            int switcher = int.Parse(Console.ReadLine());
            switch (switcher)
            {
                case 1:
                    Console.Clear();
                    MatrixDetOps();

                    break;
                case 2:
                    Console.Clear();
                    break;
               
            };
        }
        public void MatrixDet2()
        {
            double[] array = new double[4];

            for (int i = 0; i <=3; i++)
            {
                Console.WriteLine("Введите " + i + " элемент матрицы)");
                array[i] = double.Parse( Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Матрица:\n    " + array[0] +" || "+ array[1]+"\n    ======\n    "+ array[2] +" || " + array[3]);
            Console.WriteLine("Определитель равен " + (array[0]*array[3] - array[1] * array[2]));
        }
        public void MatrixDetOps()
        {
            Console.WriteLine("Выберите номер размерности матрицы:\n\n1) 2x2\n2) 3x3");
            int switcher = int.Parse(Console.ReadLine());
            switch (switcher)
            {
                case 1:
                    MatrixDet2();
                    break;
                case 2:

                    break;

            };
        }
        public void VecSumm()
        {
            Console.WriteLine("Введите координату x вектора 1");
            double x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y вектора 1");
            double y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату z вектора 1");
            double z1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату x вектора 2");
            double x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y вектора 2");
            double y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату z вектора 2");
            double z2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Сумма векторов = с{" + Math.Round(x1+x2) + "," + Math.Round(y1+y2) + "," + Math.Round(z1+z2) + "}");
        }
        public void VecOrt()
        {
            Console.WriteLine("Введите координату x вектора");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y вектора");
            double y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату z вектора");
            double z = int.Parse(Console.ReadLine());
            double len = Math.Sqrt(x * x + y * y + z * z);
            Console.WriteLine("Орт вектора равен с{"+Math.Round(x/len,4)+","+ Math.Round(y / len, 4) + ","+ Math.Round(z / len, 4) + "}");
        }
  
        public void FindDiskRoots(double a, double b, double c,out double disk, out int state, out double root1, out double root2)
        {
            disk = b * b - 4 * a * c;
            if (disk > 0)
            {
                root1 = (-b + Math.Sqrt(disk)) / (2 * a);
                root2 = (-b - Math.Sqrt(disk)) / (2 * a);
                state = 2;
            }
            else
            {
                if (disk == 0)
                {
                    root1 = (-b) / (2 * a);
                    root2 = 0;
                    state = 1;
                }
                else { root1 = 0; root2 = 0; state = 0; }
            }
            
        }
    }
}
