using System;

namespace MO_LAB1
{
    public class Programm
    {
        public static void Main()
        {
            Console.WriteLine("F = cx -> max/min; Ax <=/>=/= b; x >= 0"); //условие задачи
            double[] vec_c = { 1, 3, 8};
            double[] vec_b = { 7, 2, 4 };
            double[][] matrix_A = { new double[] { 1, 1, 1 }, new double[] { 1, 1, 0 }, new double[] { 0, 0.5, 2 } };
            string aspiration = "max";
            string[] chars = { "<=", "<=", "<=" };
            try //запускаем симплекс метод и ищем оптимальное решение, если оно существует
            {
                X.Simplex_method(vec_c, vec_b, matrix_A, aspiration, chars);
            }
            catch(Exception exep) //если не существует опорного или оптимального решения, то прекращаем поиск и выводим сообщение об ошибке
            {
                Console.WriteLine(exep.Message);
                return;
            }
        }
    }
}
