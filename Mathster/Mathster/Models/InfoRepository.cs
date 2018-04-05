using Mathster.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
                    model.Info = "https://cdn3.cdnme.se/4790426/8-3/matteinfo_5ac61264ddf2b344fab90875.png";
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
