using Mathster.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mathster.Models
{
    public class Repository
    {
        public MultiplikationIndexVM MultiplicationRandomizer()
        {
            Random rdm = new Random();
            int number1 = rdm.Next(3, 11);  //Ändrat
            int number2 = rdm.Next(0, 11);

            int product = number1 * number2;
            int[] arrayProduct = new int[2] { number1, number2};

            int rangeMin = product - 5; 
            if (rangeMin<0)
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
            while (fakeNumber2== fakeNumber1 || fakeNumber2==product)
            {
                fakeNumber2 = rdm.Next(rangeMin, rangeMax);
            }
            int fakeNumber3 = rdm.Next(rangeMin, rangeMax);
            while (fakeNumber3 == fakeNumber2 || fakeNumber3== fakeNumber1 || fakeNumber3==product)
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
    }
}
