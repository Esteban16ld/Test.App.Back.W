namespace Test.App.Back.W.Models
{
    public class DriversModel
    {
        public int Id { get; set; }
        public string Identification { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool IsOccupied { get; set; }
        public string CarType { get; set; }
    }
}
