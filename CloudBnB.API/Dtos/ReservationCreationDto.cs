namespace CloudBnB.API.Dtos
{
    public class ReservationCreationDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LocationId { get; set; }
        public double? Discount { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class ReservationSuccessfullCreationDto
    {
        public string LocationName { get; set; }
        public string CustomerName { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
    }
}
