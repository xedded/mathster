using Mathster.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mathster.Models
{
    public class QuestionService
    {
        //List<char> countList = new List<char>();
        //public List<char> CorrectAnswersCounted()
        //{
        //    char letter = ;
        //    countList.Add(letter);

        //    return countList;
        //}
         SubtractionIndexVM SubtractionRandomizer(int id) 
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            switch (id)
            {
                case 1:
                    a = 5;
                    b = 21;
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
            int number1 = rdm.Next(a, b);  //Ändrat
            int number2 = rdm.Next(c, d);

            int product = number1 - number2;
            int[] arrayProduct = new int[2] { number1, number2 };

            int rangeMin = product - 5;
            int rangeMax = product + 5;

            if (number1<number2)
            {
                number1 += number2;
            }

            if (rangeMin < 0)
            {
                rangeMin = 0;
            }


            int fakeNumber1 = rdm.Next(rangeMin, rangeMax);
            while (fakeNumber1 >= product)
            {
                fakeNumber1 = rdm.Next(rangeMin, rangeMax);
            }
            int fakeNumber2 = rdm.Next(rangeMin, rangeMax);
            while (fakeNumber2 == fakeNumber1 || fakeNumber2 >= product)
            {
                fakeNumber2 = rdm.Next(rangeMin, rangeMax);
            }
            int fakeNumber3 = rdm.Next(rangeMin, rangeMax);
            while (fakeNumber3 == fakeNumber2 || fakeNumber3 == fakeNumber1 || fakeNumber3 >= product)
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
         public MultiplicationIndexVM GetMultiplicationIndexVM (Level level, GameType gameType)
        {
        
            return new MultiplicationIndexVM { Level = level, GameType = gameType};
        }
         GameNewQuestionVM MultiplicationRandomizer(Level level)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            switch (level)
            {
                case Level.Easy:
                    a = 2;
                    b = 6;
                    c = 0;
                    d = 11;
                    break;

                case Level.Medium:
                    a = 3;
                    b = 11;
                    c = 5;
                    d = 11;
                    break;

                case Level.Hard:
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

            

            GameNewQuestionVM gameNewQuestion = new GameNewQuestionVM
            {
                Factors = arrayProduct,
                ResultOptions = arrayFakeNumbers,
                PreviousCorrectAnswer=null,
                QuestionIndex = 1,
                QuestionTotal=20,

            };
            return gameNewQuestion;

        }
         GameNewQuestionVM DivisionRandomizer(Level level)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            switch (level)
            {
                case Level.Easy:
                    a = 2;
                    b = 6;
                    c = 0;
                    d = 11;
                    break;

                case Level.Medium:
                    a = 3;
                    b = 11;
                    c = 5;
                    d = 11;
                    break;

                case Level.Hard:
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

            GameNewQuestionVM gameNewQuestion = new GameNewQuestionVM
            {
                Factors = arrayProduct,
                ResultOptions = arrayFakeNumbers,
                PreviousCorrectAnswer = null,
                QuestionIndex = 1,
                QuestionTotal = 20,

            };
            return gameNewQuestion;
        }


        //Addition
        AdditionIndexVM AdditionRandomizer(int id)
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

        public GameNewQuestionVM GetNewQuestion(Level level, int? clickedAnswer, HttpContext httpContext, GameType gameType)
        {
            const string correctPreviousResultKey = "correctPreviousResult";
            const string listOfAnswersKey = "ListOfAnswers";

            if (clickedAnswer == null)
            {
                List<string> userAnswers = new List<string>();

                httpContext.Session.SetString(listOfAnswersKey, JsonConvert.SerializeObject(userAnswers));
            }
          
            var correctPreviousResult = httpContext.Session.GetInt32(correctPreviousResultKey);
            
            var listOfAnswers = JsonConvert.DeserializeObject<List<string>>(httpContext.Session.GetString("ListOfAnswers"));

            bool isAnswerCorrect;
            if (correctPreviousResult == clickedAnswer)
            {
                isAnswerCorrect = true;
                listOfAnswers.Add("Rätt");
                httpContext.Session.SetString(listOfAnswersKey, JsonConvert.SerializeObject(listOfAnswers));

            }
            else
            {
                isAnswerCorrect = false;
                listOfAnswers.Add("Fel");
                httpContext.Session.SetString(listOfAnswersKey, JsonConvert.SerializeObject(listOfAnswers));
            }

            var model = new GameNewQuestionVM();
                
            switch (gameType)
            {
                case GameType.Multiplication:
                    model = MultiplicationRandomizer(level);
                    model.PreviousCorrectAnswer = isAnswerCorrect;
                    model.QuestionIndex = listOfAnswers.Count;
                    model.List = listOfAnswers;
                    var factor1 = model.Factors[0];
                    var factor2 = model.Factors[1];
                    var resultOfFactors = factor1 * factor2;
                    httpContext.Session.SetInt32(correctPreviousResultKey, resultOfFactors);
                    return model;


                    
                case GameType.Division:
                     model = DivisionRandomizer(level);
                    model.PreviousCorrectAnswer = isAnswerCorrect;
                    model.QuestionIndex = listOfAnswers.Count;
                    model.List = listOfAnswers;
                     factor1 = model.Factors[0];
                     factor2 = model.Factors[1];
                     resultOfFactors = factor1 / factor2;
                    httpContext.Session.SetInt32(correctPreviousResultKey, resultOfFactors);
                    return model;
                    
                case GameType.Addition:
                    model = MultiplicationRandomizer(level);
                    model.PreviousCorrectAnswer = isAnswerCorrect;
                    model.QuestionIndex = listOfAnswers.Count;
                    model.List = listOfAnswers;
                    factor1 = model.Factors[0];
                    factor2 = model.Factors[1];
                    resultOfFactors = factor1 + factor2;
                    httpContext.Session.SetInt32(correctPreviousResultKey, resultOfFactors);
                    return model;
                case GameType.Subtraction:
                    model = MultiplicationRandomizer(level);
                    model.PreviousCorrectAnswer = isAnswerCorrect;
                    model.QuestionIndex = listOfAnswers.Count;
                    model.List = listOfAnswers;
                    factor1 = model.Factors[0];
                    factor2 = model.Factors[1];
                    resultOfFactors = factor1 - factor2;
                    httpContext.Session.SetInt32(correctPreviousResultKey, resultOfFactors);
                    return model;

                default:
                    throw new NotImplementedException();

            }

            
        }
    }
}
