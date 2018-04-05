using Mathster.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mathster.Models
{
    public class InfoRepository
    {
        public InfoIndexVM GetInfo(GameType gameType)
        {
            var model = new InfoIndexVM();
            switch (gameType)
            {
                case GameType.Multiplication:
                    model.Info = @"C:/Users/Administrator/source/repos/MathsterAcademy/Mathster/Mathster/wwwroot/subt-1.png";
                    return model;

                case GameType.Division:
                    model.Info = "";
                    return model;

                case GameType.Addition:
                    model.Info = "";
                    return model;

                case GameType.Subtraction:
                    model.Info = "";
                    return model;


                default: throw new NotImplementedException();

            }
        }
    }
}
