namespace labb4
{
    public class Country
    {
        public string Name { get; set; }
        public string Currency { get; set; }
        public int Population { get; set; }
        public string PictureUrl { get; set; }
        public string Description { get; set; }

        public Country(string name, string currency, int population, string pictureUrl, string description)
        {
            Name = name;
            Currency = currency;
            Population = population;
            PictureUrl = pictureUrl;
            Description = description;
        }
    }
}
