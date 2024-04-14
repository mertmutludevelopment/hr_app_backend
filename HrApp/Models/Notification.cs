namespace HrApp.Models
{
    public class Notification
    {
        public int Id{ get; set; }

        public string NotificationDescription { get; set; }

        public int? NotificationReceiverId { get; set; }

        public int NotificationSenderId { get; set; }

        public string NotificationSenderFullname { get; set; }

        public string NotificationSenderDepartment { get; set; }


    }
}
