using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchServiceCreator.Models
{
    internal class Song
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Attributes
        {
            public string admin { get; set; }
            public string author { get; set; }
            public string copyright { get; set; }
            public DateTime created_at { get; set; }
            public bool hidden { get; set; }
            public DateTime? last_scheduled_at { get; set; }
            public string? last_scheduled_short_dates { get; set; }
            public object notes { get; set; }
            public string themes { get; set; }
            public string title { get; set; }
            public DateTime updated_at { get; set; }
        }

        public class Datum
        {
            public string type { get; set; }
            public string id { get; set; }
            public Attributes attributes { get; set; }
            public Links links { get; set; }
        }

        public class Links
        {
            public string self { get; set; }
        }

        public class Meta
        {
            public int total_count { get; set; }
            public int count { get; set; }
            public List<string> can_order_by { get; set; }
            public List<string> can_query_by { get; set; }
            public Parent parent { get; set; }
        }

        public class Parent
        {
            public string id { get; set; }
            public string type { get; set; }
        }

        public class Root
        {
            public Links links { get; set; }
            public List<Datum> data { get; set; }
            public List<object> included { get; set; }
            public Meta meta { get; set; }
        }

    }
}
