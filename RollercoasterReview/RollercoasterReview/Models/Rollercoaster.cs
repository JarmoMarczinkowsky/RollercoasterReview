namespace RollercoasterReview.Models
{
    public class Rollercoaster
    {
        public int RollercoasterId { get; set; }
        public string Name { get; set; }
        public string BackgroundInfo { get; set; }
        public DateTime Year { get; set; }
        public string Image { get; set; }
        public int ParkId { get; set; }
        public virtual Park Park { get; set; }
    }
}
