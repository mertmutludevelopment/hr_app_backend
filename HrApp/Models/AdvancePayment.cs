namespace HrApp.Models
{
    public class AdvancePayment
    {
        public int Id { get; set; }

        public int AdvanceAmount { get; set; }

        public int StartDay { get; set; }

        public int StartMonth { get; set; }

        public int StartYear { get; set; }

        public int EndDay { get; set; }

        public int EndMonth { get; set; }

        public int EndYear { get; set; }

        public int UserId { get; set; }

        public string Fullname { get; set; }
    }
}
