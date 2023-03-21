namespace RollercoasterReview.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public ICollection<Rollercoaster>? Rollercoasters { get; set; }
    }
}
