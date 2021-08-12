using System;
using TechTalk.SpecFlow;

namespace HudlApiTest.PostObjects
{
    public class NewOpponentPostObject
    {
        public NewOpponentPostObject(Table table)
        {
            gameId = table.Rows[0][1];
            sqlId = table.Rows[1][1];
            date = table.Rows[2][1];
            opponent = table.Rows[3][1];
            opponentId = table.Rows[4][1];
            isHome = true;
            gameType =  Convert.ToInt32(table.Rows[6][1]);
            gameId = table.Rows[7][1];
            category = new int[]{};
        }

        public string gameId { get; set; }
        public string sqlId { get; set; }
        public string date { get; set; }
        public string opponent { get; set; }
        public string opponentId { get; set; }
        public bool isHome { get; set; }
        public int gameType { get; set; }
        public int[] category { get; set; }
    }
}
