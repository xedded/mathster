using Mathster.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mathster.Models
{
    public class Repository
    {
        
        public MultiplikationIndexVM MultiplicationRandomizer(int id)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            switch (id)
            {
                case 1:
                    a = 2;
                    b = 6;
                    c = 0;
                    d = 11;
                    break;

                case 2:
                    a = 3;
                    b = 11;
                    c = 5;
                    d = 11;
                    break;

                case 3:
                    a = 6;
                    b = 16;
                    c = 3;
                    d = 16;
                    break;


                default:
                    break;
            }

            
           
            Random rdm = new Random();
            int number1 = rdm.Next(a, b);  //Ändrat
            int number2 = rdm.Next(c, d);

            int product = number1 * number2;
            int[] arrayProduct = new int[2] { number1, number2 };

            int rangeMin = product - 5;
            if (rangeMin < 0)
            {
                rangeMin = 0;
            }
            int rangeMax = product + 5;


            int fakeNumber1 = rdm.Next(rangeMin, rangeMax);
            while (fakeNumber1 == product)
            {
                fakeNumber1 = rdm.Next(rangeMin, rangeMax);
            }
            int fakeNumber2 = rdm.Next(rangeMin, rangeMax);
            while (fakeNumber2 == fakeNumber1 || fakeNumber2 == product)
            {
                fakeNumber2 = rdm.Next(rangeMin, rangeMax);
            }
            int fakeNumber3 = rdm.Next(rangeMin, rangeMax);
            while (fakeNumber3 == fakeNumber2 || fakeNumber3 == fakeNumber1 || fakeNumber3 == product)
            {
                fakeNumber3 = rdm.Next(rangeMin, rangeMax);
            }

            List<int> list = new List<int> { product, fakeNumber1, fakeNumber2, fakeNumber3 };

            // Ändringar!!

            List<int> sortedList = list.OrderBy(v => v).ToList();
            int[] arrayFakeNumbers = sortedList.ToArray();
            //int[] arrayFakeNumbers = new int[4] { product, fakeNumber1, fakeNumber2, fakeNumber3};

            MultiplikationIndexVM multiplikationIndexVM = new MultiplikationIndexVM
            {
                CorrectAnswer = product,
                MultipliedFactors = arrayProduct,
                ResultOptions = arrayFakeNumbers

            };
            return multiplikationIndexVM;

        }
        public DivisionIndexVM DivisionRandomizer(int id)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            switch (id)
            {
                case 1:
                    a = 2;
                    b = 6;
                    c = 0;
                    d = 11;
                    break;

                case 2:
                    a = 3;
                    b = 11;
                    c = 5;
                    d = 11;
                    break;

                case 3:
                    a = 6;
                    b = 16;
                    c = 3;
                    d = 16;
                    break;


                default:
                    break;
            }
            Random rdm = new Random();
            int number1 = rdm.Next(a, b);
            int number2 = rdm.Next(c, d);

            int product = number1 * number2;
            int[] arrayProduct = new int[2] { product, number1 };

            int rangeMin = number2 - 3;
            if (rangeMin < 0)
            {
                rangeMin = 0;
            }
            int rangeMax = number2 + 3;


            int fakeNumber1 = rdm.Next(rangeMin, rangeMax);
            while (fakeNumber1 == number2)
            {
                fakeNumber1 = rdm.Next(rangeMin, rangeMax);
            }
            int fakeNumber2 = rdm.Next(rangeMin, rangeMax);
            while (fakeNumber2 == fakeNumber1 || fakeNumber2 == number2)
            {
                fakeNumber2 = rdm.Next(rangeMin, rangeMax);
            }
            int fakeNumber3 = rdm.Next(rangeMin, rangeMax);
            while (fakeNumber3 == fakeNumber2 || fakeNumber3 == fakeNumber1 || fakeNumber3 == number2)
            {
                fakeNumber3 = rdm.Next(rangeMin, rangeMax);
            }

            List<int> list = new List<int> { number2, fakeNumber1, fakeNumber2, fakeNumber3 };

            // Ändringar!!

            List<int> sortedList = list.OrderBy(v => v).ToList();
            int[] arrayFakeNumbers = sortedList.ToArray();
            //int[] arrayFakeNumbers = new int[4] { product, fakeNumber1, fakeNumber2, fakeNumber3};

            DivisionIndexVM divisionIndexVM = new DivisionIndexVM
            {
                CorrectAnswer = number2,
                NumeratiorDenumerator = arrayProduct,
                ResultOptions = arrayFakeNumbers

            };
            return divisionIndexVM;
        }


        //Addition
        public AdditionIndexVM AdditionRandomizer(int id)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            switch (id)
            {
                case 1:
                    a = 1;
                    b = 10;
                    c = 0;
                    d = 11;
                    break;

                case 2:
                    a = 10;
                    b = 85;
                    c = 1;
                    d = 11;
                    break;

                case 3:
                    a = 30;
                    b = 100;
                    c = 10;
                    d = 21;
                    break;


                default:
                    break;
            }
            Random rdm = new Random();
            int number1 = rdm.Next(a, b);
            int number2 = rdm.Next(c, d);

            int sum = number1 + number2;
            int[] arraySum = new int[2] { number1, number2 };

            int rangeMin = sum - 10;
            if (rangeMin < 0)
            {
                rangeMin = 0;
            }
            int rangeMax = sum + 10;


            int fakeNumber1 = rdm.Next(rangeMin, rangeMax);
            while (fakeNumber1 == sum)
            {
                fakeNumber1 = rdm.Next(rangeMin, rangeMax);
            }
            int fakeNumber2 = rdm.Next(rangeMin, rangeMax);
            while (fakeNumber2 == fakeNumber1 || fakeNumber2 == sum)
            {
                fakeNumber2 = rdm.Next(rangeMin, rangeMax);
            }
            int fakeNumber3 = rdm.Next(rangeMin, rangeMax);
            while (fakeNumber3 == fakeNumber2 || fakeNumber3 == fakeNumber1 || fakeNumber3 == sum)
            {
                fakeNumber3 = rdm.Next(rangeMin, rangeMax);
            }

            List<int> list = new List<int> { sum, fakeNumber1, fakeNumber2, fakeNumber3 };

            // Ändringar!!

            List<int> sortedList = list.OrderBy(v => v).ToList();
            int[] arrayFakeNumbers = sortedList.ToArray();
            //int[] arrayFakeNumbers = new int[4] { product, fakeNumber1, fakeNumber2, fakeNumber3};

            AdditionIndexVM additionIndexVM = new AdditionIndexVM
            {
                AddedNumbers = arraySum,
                ResultOptions = arrayFakeNumbers,
                CorrectAnswer = sum,

            };
            return additionIndexVM;

        }
    }
}
