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
                    model.GameTypeVideo = "https://www.youtube.com/embed/YXFWS4cmcsA?rel=0&autoplay=1";
                    return model;
                 
                case GameType.Division:
                    model.GameTypeVideo = "https://www.youtube.com/embed/4S-69OQokFA?rel=0&autoplay=1";
                    return model;
                 
                case GameType.Addition:
                    model.GameTypeVideo = "https://www.youtube.com/embed/Z4XQWOVs2_g?rel=0&autoplay=1";
                    return model;
                 
                case GameType.Subtraction:
                    model.GameTypeVideo = "https://www.youtube.com/embed/WQaT1rGs8ao?rel=0&autoplay=1";
                    return model;
           

                    default: throw new NotImplementedException();
               
            }
            
           
        }
       
    }
}
