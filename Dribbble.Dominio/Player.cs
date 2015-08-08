using System.Collections.Generic;

namespace Dribbble.Dominio
{
    public class Player
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public int followers_count { get; set; }
        public int draftees_count { get; set; }
        public int likes_count { get; set; }
        public int likes_received_count { get; set; }
        public int comments_count { get; set; }
        public int comments_received_count { get; set; }
        public int rebounds_count { get; set; }
        public int rebounds_received_count { get; set; }
        public string url { get; set; }
        public string avatar_url { get; set; }
        public string username { get; set; }
        public string twitter_screen_name { get; set; }
        public string website_url { get; set; }
        public int? drafted_by_player_id { get; set; }
        public int shots_count { get; set; }
        public int following_count { get; set; }
        public string created_at { get; set; }
    }
}