using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChurchServiceCreator.Models.Song;

namespace ChurchServiceCreator.Models
{
    public class SongSchedule
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Arrangement
        {
            public Data data { get; set; }
        }

        public class Attributes
        {
            public string arrangement_name { get; set; }
            public string key_name { get; set; }
            public string plan_dates { get; set; }
            public DateTime plan_sort_date { get; set; }
            public bool plan_visible { get; set; }
            public string service_type_name { get; set; }
        }

        public class Data
        {
            public string type { get; set; }
            public string id { get; set; }
            public Attributes attributes { get; set; }
            public Relationships relationships { get; set; }
            public Links links { get; set; }
        }

        public class Item
        {
            public Data data { get; set; }
        }

        public class Key
        {
            public Data data { get; set; }
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
            public List<string> can_filter { get; set; }
            public Parent parent { get; set; }
        }

        public class Parent
        {
            public string id { get; set; }
            public string type { get; set; }
        }

        public class Plan
        {
            public Data data { get; set; }
        }

        public class Relationships
        {
            public Arrangement arrangement { get; set; }
            public Key key { get; set; }
            public Plan plan { get; set; }
            public ServiceType service_type { get; set; }
            public Item item { get; set; }
        }

        public class Root
        {
            public Links links { get; set; }
            public List<Data> data { get; set; }
            public List<object> included { get; set; }
            public Meta meta { get; set; }
        }

        public class ServiceType
        {
            public Data data { get; set; }
        }
    }
}
