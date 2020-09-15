using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinalProject.Models‏
{
    public partial class Films
    {
        public Films()
        {
            MovieClose = new HashSet<MovieClose>();
            MovieOpen = new HashSet<MovieOpen>();
        }

        public int FilmId { get; set; }
        public string FilmName { get; set; }

        [JsonIgnore]
        public virtual ICollection<MovieClose> MovieClose { get; set; }
        public virtual ICollection<MovieOpen> MovieOpen { get; set; }
    }
}
