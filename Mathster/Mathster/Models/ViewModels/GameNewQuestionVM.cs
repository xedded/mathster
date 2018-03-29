using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mathster.Models.ViewModels
{
    public class GameNewQuestionVM
    {
        public int[] Factors { get; set; }
        public int[] ResultOptions { get; set; }
        
        public bool? PreviousCorrectAnswer { get; set; }
        public int QuestionIndex { get; set; }
        public int QuestionTotal { get; set; }

    }
}
