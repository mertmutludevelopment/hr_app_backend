namespace HrApp.Models
{
    public class DeclinedLeave
    {
        public int Id { get; set; }

        public string Reason { get; set; }

        public int StartLeaveDay { get; set; }

        public int StartLeaveMonth { get; set; }

        public int StartLeaveYear { get; set; }

        public int EndLeaveDay { get; set; }

        public int EndLeaveMonth { get; set; }

        public int EndLeaveYear { get; set; }

        public int NumberOfLeaveDay { get; set; }

        public int UserId { get; set; }

        public string Fullname { get; set; }
    }
}
