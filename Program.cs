using System;
using System.Collections.Generic;

namespace ThirdHomework
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public void Ex1()
        {
            int count = 0;
            for (int i = 2; i <= 100;)
            {
                if (i == 2)
                {
                    Console.WriteLine(i);
                    count++;
                    i++;
                }
                else if (i == 3)
                {
                    Console.WriteLine(i);
                    count++;
                    i += 2;
                }
                else if (i == 5)
                {
                    Console.WriteLine(i);
                    count++;
                    i += 2;
                }
                else
                {
                    if ((i % 3 != 0))
                    {
                        if (i % 5 != 0)
                        {
                            Console.WriteLine(i);
                            count++;
                            i += 2;
                        }
                        else
                        {
                            i += 2;
                        }
                    }
                    else
                    {
                        i += 2;
                    }
                }
            }
            Console.WriteLine($"W przedziale 0 - 100 jest {count} liczb pierwszych.");
        }

        public void Ex2()
        {
            int a = 0;
            do
            {
                if (a % 2 == 0)
                    Console.WriteLine(a);
                a++;
            } while (a <= 1000);
        }

        public void Ex3()
        {
            Console.Write("Podaj ile liczb w ciągu Fibonacciego chcesz zobaczyć. ");
            int howMany;
            Int32.TryParse(Console.ReadLine(), out howMany);

            int firstNum = 0;
            int secondNum = 1;
            int anotherNum = 0;
            for (int i = 1; i < howMany; i++)
            {
                anotherNum = firstNum + secondNum;
                Console.WriteLine(anotherNum);
                firstNum = secondNum;
                secondNum = anotherNum;
            }
        }

        public void Ex4()
        {
            int number;
            Console.WriteLine("Podaj liczbę, do której ma zostać wyświetlona piramida liczb.");
            Int32.TryParse(Console.ReadLine(), out number);
            int countNumberInLine = 0;
            int numberOfLine = 1;
            for (int i = 1; i <= number; i++)
            {
                Console.Write($"{i} ");
                countNumberInLine++;
                if (countNumberInLine == numberOfLine)
                {
                    Console.Write("\r\n");
                    countNumberInLine = 0;
                    numberOfLine++;
                }
            }
        }
        public void Ex5()
        {
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
        }

        public void Ex6()
        {
            double sum = 0;
            for (double i = 0; i < 21; i++)
            {
                if (i == 0)
                    continue;
                sum += (1 / i);
            }
            Console.WriteLine(sum);
        }

        public void Ex7()
        {
            Console.Write("Podaj liczbę, a narysuję diament, którego przekątna ma długość równą liczbie, którą podałeś: ");
            int windth;
            int counterOfStars = 0;
            int line = 1;
            int k = 0;           
            Int32.TryParse(Console.ReadLine(), out windth);

            // Pierwsza połowa diamentu
            for (int i = 0; i < (windth - 1) / 2; i++)
            {
                //Wcięcia
                for (int j = ((windth - 1) / 2) - i ; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                
                //Gwiazdki
                for (; counterOfStars < windth - 2; )
                {
                    Console.Write("*");
                    counterOfStars++;
                    if (counterOfStars == line + k)
                    {
                        k += 1;                       
                        break;
                    }
                }
                Console.Write("\r\n");
                counterOfStars = 0;
                line++;
            }

            // Środek diamentu
            for (int i = 0; i < windth; i++)
            {
                Console.Write("*");
            }
            Console.Write("\r\n");

            counterOfStars = 0;
            k = 2;
            line = 0;
            int m = 0;
            // Druga połowa diamentu
            for (int i = 0; i < (windth - 1) / 2; i++)
            {    
                //Wcięcia
                for (int l = 0; m >= l; l++)
                {
                    Console.Write(" ");
                }
                m++;
                //Gwiazdki
                for (; line <= ((windth - 1) / 2);)
                {
                    Console.Write("*");
                    counterOfStars++;
                    if (counterOfStars == windth - k)
                    {
                        k += 2;
                        break;
                    }
                }
                Console.Write("\r\n");
                line++;
                counterOfStars = 0;
            }
        }

        public void Ex8()
        {
            Console.WriteLine("Podaj ciąg znaków, a ja wyświetle go odwróconego.");
            string chars = Console.ReadLine();
            List<char> chars2 = new List<char>();
            foreach (var item in chars)
            {
                chars2.Add(item);
            }
            for (int i = (chars2.Count - 1); i >= 0; i--)
            {
                Console.Write(chars2[i]);
            }
            Console.WriteLine();
        }

        public void Ex9()
        {
            int number;
            Console.WriteLine("Podaj liczbę, a ja zamienie ją na liczbę binarną.");
            Int32.TryParse(Console.ReadLine(), out number);
            List<int> numbers = new List<int>();

            while (number > 0)
            {
                int digit = number % 2;
                numbers.Add(digit);
                number /= 2;
            }
            Console.Write("Podana liczba w zapisie binarnym ma postać: ");
            for (int i = (numbers.Count - 1); i >= 0; i--)
            {
                Console.Write(numbers[i]);
            }
            Console.WriteLine();
        }

        public void Ex10()
        {   
            int firstNum;
            int secondNum;
            Console.WriteLine("Podaj dwie liczby, a powiem Ci ich najmniejszą wspólną wielokrotność.");
            Console.Write("Pierwsza liczba: ");
            Int32.TryParse(Console.ReadLine(), out firstNum);
            Console.Write("Druga liczba: ");
            Int32.TryParse(Console.ReadLine(), out secondNum);
            int a = nwd(firstNum, secondNum);
            Console.WriteLine($"Najmniejsza wspólna wielokrotność tych liczb to: {(firstNum*secondNum)/a}");
        }
        static int nwd(int a, int b)
        {
            int c;
            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return a;
        }
    }
}
