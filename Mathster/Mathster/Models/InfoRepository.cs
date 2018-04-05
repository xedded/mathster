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
                    model.Info = "https://cdn2.cdnme.se/4790426/8-3/division_2_5ac628092a6b22b30637aa74.png";
                    return model;

                case GameType.Division:
                    model.Info = "https://cdn1.cdnme.se/4790426/8-3/division_1_5ac623f82a6b22b2ff908070.png";
                    return model;

                case GameType.Addition:
                    model.Info = " https://cdn1.cdnme.se/4790426/8-3/addition_5ac62746ddf2b344cb749f14.png";
                    return model;

                case GameType.Subtraction:
                    model.Info = "https://cdn3.cdnme.se/4790426/8-3/matteinfo_5ac61264ddf2b344fab90875.png";
                    return model;


                default: throw new NotImplementedException();

            }
        }
    }
}
