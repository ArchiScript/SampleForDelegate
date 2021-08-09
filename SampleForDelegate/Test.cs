using System;
using System.Collections.Generic;
using System.Text;

namespace SampleForDelegate
{
    public class Test
    {
        public void Devide(int a, int b)
        {
            try
            {
                int c = a / b;
                if (b >= 5)
                {
                    throw new NumberOverFiveException("Число b превысило 5");
                }
            }
            catch (NumberOverFiveException e) { Console.WriteLine(e); }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            //Любое исключение перехватить
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Блок Finally выполнен");
            }
        }
    }
}
