using Mathster.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mathster.Models
{
    public class Repository
    {
        public SubtractionIndexVM SubtractionRandomizer()
        {
            Random rdm = new Random();
            int number1 = rdm.Next(50, 101);  //Ändrat
            int number2 = rdm.Next(1, 16);

            int product = number1 - number2;
            int[] arrayProduct = new int[2] { number1, number2 };

            int rangeMin = product - 10;
            int rangeMax = product + 10;


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

            SubtractionIndexVM subtractionIndexVM = new SubtractionIndexVM
            {
                CorrectAnswer = product,
                SubtractionFactors = arrayProduct,
                ResultOptions = arrayFakeNumbers

            };
            return subtractionIndexVM;
        }


        public MultiplikationIndexVM MultiplicationRandomizer()
        {
            Random rdm = new Random();
            int number1 = rdm.Next(3, 11);  //Ändrat
            int number2 = rdm.Next(0, 11);

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
            public DivisionIndexVM DivisionRandomizer()
            {
                Random rdm = new Random();
                int number1 = rdm.Next(3, 11); 
                int number2 = rdm.Next(0, 11);

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
        }

        //Addition
        public AdditionIndexVM AdditionRandomizer()
        {
            Random rdm = new Random();
            int number1 = rdm.Next(1, 86);  
            int number2 = rdm.Next(5, 16);

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
                ResultOptions=arrayFakeNumbers,
                CorrectAnswer= sum,

            };
            return additionIndexVM;

        }
    }
}
