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
 
        GameNewQuestionVM SubtractionRandomizer(Level level)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            switch (level)
            {
                case Level.Easy:
                    a = 5;
                    b = 21;
                    c = 0;
                    d = 11;
                    break;

                case Level.Medium:
                    a = 10;
                    b = 85;
                    c = 1;
                    d = 11;
                    break;

                case Level.Hard:
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

            int product = number1 - number2;
            int[] arrayProduct = new int[2] { number1, number2 };

            int rangeMin = product - 5;
            int rangeMax = product + 5;

            if (number1 < number2)
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

            

            List<int> sortedList = list.OrderBy(v => v).ToList();
            int[] arrayFakeNumbers = sortedList.ToArray();
           
            GameNewQuestionVM gameNewQuestion = new GameNewQuestionVM
            {
                Factors = arrayProduct,
                ResultOptions = arrayFakeNumbers,
                QuestionTotal = 20,

            };
            return gameNewQuestion;
        }
        public MultiplicationIndexVM GetMultiplicationIndexVM(Level level, GameType gameType)
        {

            return new MultiplicationIndexVM { Level = level, GameType = gameType };
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
            int number1 = rdm.Next(a, b);  
            int number2 = rdm.Next(c, d);

            int product = number1 * number2;
            int[] arrayProduct = new int[2] { number1, number2 };

            int rangeMin = product - d;
            if (rangeMin < 0)
            {
                rangeMin = 0;
            }
            int rangeMax = product + d;


            int fakeNumber1 = rdm.Next(rangeMin, rangeMax);
          
            while (fakeNumber1 == product||fakeNumber1%number1!=0)
            {
                fakeNumber1 = rdm.Next(rangeMin, rangeMax);
            }
            int fakeNumber2 = rdm.Next(rangeMin, rangeMax);
          
            while (fakeNumber2 == fakeNumber1 || fakeNumber2 == product || number2!=0&&fakeNumber2%number2!=0)
            {
                fakeNumber2 = rdm.Next(rangeMin, rangeMax);
            }
            int fakeNumber3 = rdm.Next(rangeMin, rangeMax);
            while (fakeNumber3 == fakeNumber2 || fakeNumber3 == fakeNumber1 || fakeNumber3 == product)
            {
                fakeNumber3 = rdm.Next(rangeMin, rangeMax);
            }

            List<int> list = new List<int> { product, fakeNumber1, fakeNumber2, fakeNumber3 };

          

            List<int> sortedList = list.OrderBy(v => v).ToList();
            int[] arrayFakeNumbers = sortedList.ToArray();
          



            GameNewQuestionVM gameNewQuestion = new GameNewQuestionVM
            {
                Factors = arrayProduct,
                ResultOptions = arrayFakeNumbers,
                QuestionTotal = 20,

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

            int rangeMin = number2 - (b-a);
            if (rangeMin < 0)
            {
                rangeMin = 0;
            }
            int rangeMax = number2 + (b-a);


            int fakeNumber1 = rdm.Next(rangeMin, rangeMax);
            while (fakeNumber1 == number2||product%fakeNumber1!=0)
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
                
               
                QuestionTotal = 20,

            };
            return gameNewQuestion;
        }


        //Addition
        GameNewQuestionVM AdditionRandomizer(Level level)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            switch (level)
            {
                case Level.Easy:
                    a = 1;
                    b = 10;
                    c = 0;
                    d = 11;
                    break;

                case Level.Medium:
                    a = 10;
                    b = 85;
                    c = 1;
                    d = 11;
                    break;

                case Level.Hard:
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

            GameNewQuestionVM gameNewQuestionVM = new GameNewQuestionVM
            {
                Factors = arraySum,
                ResultOptions = arrayFakeNumbers,
                
                
                QuestionTotal = 20,
            };
            return gameNewQuestionVM;

        }

        public GameNewQuestionVM GetNewQuestion(Level level, int? clickedIndex, HttpContext httpContext, GameType gameType)
        {
            const string correctPreviousIndexKey = "correctPreviousIndex";
            const string correctAnswerCountKey = "correctAnswerCount";
            const string currentQuestionIndexKey = "currentQuestionIndex";

            if (clickedIndex == null)
            {
                httpContext.Session.SetInt32(correctAnswerCountKey, 0);
                httpContext.Session.SetInt32(currentQuestionIndexKey, 0);

            }

            var correctPreviousIndex = httpContext.Session.GetInt32(correctPreviousIndexKey);

            //bool isAnswerCorrect = false;
            if (correctPreviousIndex == clickedIndex && correctPreviousIndex != null)
            {
                //isAnswerCorrect = true;
                // Increase correctAnswerIndex

                var correctAnswerCount = httpContext.Session.GetInt32(correctAnswerCountKey);
                correctAnswerCount++;
                httpContext.Session.SetInt32(correctAnswerCountKey, correctAnswerCount.Value);
            }
            // Increase currentQuestionIndex
            var currentQuestionIndex = httpContext.Session.GetInt32(currentQuestionIndexKey);
            currentQuestionIndex++;
            httpContext.Session.SetInt32(currentQuestionIndexKey, currentQuestionIndex.Value);


            var model = new GameNewQuestionVM();

            switch (gameType)
            {
                case GameType.Multiplication:
                    model = MultiplicationRandomizer(level);
                    model.PreviousCorrectAnswerIndex = correctPreviousIndex;
                    model.QuestionIndex = currentQuestionIndex.Value;
                    model.CorrectAnswers = httpContext.Session.GetInt32(correctAnswerCountKey).Value;
                    var factor1 = model.Factors[0];
                    var factor2 = model.Factors[1];
                    var resultOfFactors = factor1 * factor2;
                    //httpContext.Session.SetInt32(correctPreviousIndexKey, model.ResultOptions.Single(o => o == resultOfFactors));
                    httpContext.Session.SetInt32(correctPreviousIndexKey, GetIndexOfPreviousQuestion(model.ResultOptions, resultOfFactors));
                    return model;

                case GameType.Division:
                    model = DivisionRandomizer(level);
                    model.PreviousCorrectAnswerIndex = correctPreviousIndex;
                    model.QuestionIndex = currentQuestionIndex.Value;
                    model.CorrectAnswers = httpContext.Session.GetInt32(correctAnswerCountKey).Value;

                    factor1 = model.Factors[0];
                    factor2 = model.Factors[1];
                    resultOfFactors = factor1 / factor2;
                    //httpContext.Session.SetInt32(correctPreviousIndexKey, model.ResultOptions.Single(o => o == resultOfFactors));
                    httpContext.Session.SetInt32(correctPreviousIndexKey, GetIndexOfPreviousQuestion(model.ResultOptions, resultOfFactors));

                    return model;

                case GameType.Addition:
                    model = AdditionRandomizer(level);
                    model.PreviousCorrectAnswerIndex = correctPreviousIndex;
                    model.QuestionIndex = currentQuestionIndex.Value;
                    model.CorrectAnswers = httpContext.Session.GetInt32(correctAnswerCountKey).Value;

                    factor1 = model.Factors[0];
                    factor2 = model.Factors[1];
                    resultOfFactors = factor1 + factor2;
                    httpContext.Session.SetInt32(correctPreviousIndexKey, GetIndexOfPreviousQuestion(model.ResultOptions, resultOfFactors));
                    return model;
                case GameType.Subtraction:
                    model = SubtractionRandomizer(level);
                    model.PreviousCorrectAnswerIndex = correctPreviousIndex;
                    model.QuestionIndex = currentQuestionIndex.Value;
                    model.CorrectAnswers = httpContext.Session.GetInt32(correctAnswerCountKey).Value;

                    factor1 = model.Factors[0];
                    factor2 = model.Factors[1];
                    resultOfFactors = factor1 - factor2;
                    httpContext.Session.SetInt32(correctPreviousIndexKey, GetIndexOfPreviousQuestion(model.ResultOptions, resultOfFactors));
                    return model;

                default:
                    throw new NotImplementedException();

            }


        }

        private int GetIndexOfPreviousQuestion(int[] resultOptions, int resultOfFactors)
        {
            for (int i = 0; i < 4; i++)
            {
                if (resultOptions[i] == resultOfFactors)
                    return i;

            }
            return 0;
        }
    }
}
