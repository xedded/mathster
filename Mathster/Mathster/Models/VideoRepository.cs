using Mathster.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mathster.Models
{
    public class VideoRepository
    {
        public InstructionVideoVM GetVideo(GameType gameType)
        {
            var model = new InstructionVideoVM();
            switch (gameType)
            {
                case GameType.Multiplication:
                    model.MultiplicationVideo = "https://www.youtube.com/embed/xCW3xBNBigg?rel=0&autoplay=1";
                    return model;
                 
                case GameType.Division:
                    model.MultiplicationVideo = "https://www.youtube.com/embed/4S-69OQokFA?rel=0&autoplay=1";
                    return model;
                 
                case GameType.Addition:
                    model.MultiplicationVideo = "https://www.youtube.com/embed/Z4XQWOVs2_g?rel=0&autoplay=1B";
                    return model;
                 
                case GameType.Subtraction:
                    model.MultiplicationVideo = "https://www.youtube.com/embed/WQaT1rGs8ao?rel=0&autoplay=1";
                    return model;
           

                    default: throw new NotImplementedException();
               
            }
            
           
        }
       
    }
}
