using System.ComponentModel.DataAnnotations;

namespace Campeonatos.Models
{
    public class TimeUser
    {

        public TimeUser(int userID, int timeID)
        {
            UserID = userID;

            TimeID = timeID;

        }

        [Key]public int UserID { get; private set; }
        public User User { get; private set; }
        [Key] public int TimeID { get;  private set; }
        public Time Time { get; private set; }
    }
}
