using Newtonsoft.Json;

namespace HomeWork3_FacadeAndAAA.DataModels
{
    public class petModels
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("category")]                                                                                                                                                                                                                                                                                                                                          ///CREATED BY JUSTIN SALAZAR :)
        public Category Category { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("photoUrls")]
        public List<string> PhotoUrls { get; set; }

        [JsonProperty("tags")]
        public List<CategoryT> Tags { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class Category
    {   
        //previously i have constructors here, but i removed it already, kinda complicated to use.
        [JsonProperty("id")]                                                                                                                                                                                                                                                                                                            ///CREATED BY JUSTIN SALAZAR :)
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
    public class CategoryT                                                                                                                                                                                                                                                                                                                                                                          ///CREATED BY JUSTIN SALAZAR :)
    {
        //previously i have constructors here, but i removed it already, kinda complicated to use.
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

}
