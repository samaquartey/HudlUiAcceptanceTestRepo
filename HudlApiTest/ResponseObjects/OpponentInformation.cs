using System;

namespace HudlApiTest.ResponseObjects
{
    public class OpponentInformation
    {
        public string gameId { get; set; }
        public string sqlId { get; set; }
        public DateTime date { get; set; }
        public string opponent { get; set; }
        public string opponentId { get; set; }
        public bool IsHome { get; set; }
        public int gameType { get; set; }
        public int[] categories { get; set; }
    }
}
