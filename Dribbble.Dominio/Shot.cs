using System.Collections.Generic;

namespace Dribbble.Dominio
{
    public class Shot
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int likes_count { get; set; }
        public int comments_count { get; set; }
        public int rebounds_count { get; set; }
        public string url { get; set; }
        public string short_url { get; set; }
        public int views_count { get; set; }
        public int? rebound_source_id { get; set; }
        public string image_url { get; set; }
        public string image_teaser_url { get; set; }
        public string image_400_url { get; set; }
        public Player player { get; set; }
        public string created_at { get; set; }
    }
}