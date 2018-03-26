using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mathster.Models.ViewModels
{
    public class MultiplikationIndexVM
    {
        public int[] MultipliedFactors { get; set; }
        public int[] ResultOptions { get; set; }
        public int CorrectAnswer { get; set; } //Index??
    }
}
