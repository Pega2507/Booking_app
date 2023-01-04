using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_app
{
    public class Booking
    {
        private int Id { get; set; }
        public int User_Id { get; set; }
        public int Object_Id { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public DateTime Data_Start { get; set; }
        public DateTime Data_End { get; set; }
        public string Description { get; set; }

        private void GetBooking()
        {
            string sql = "SELECT [Id],[Created_at],[Updated_at],[User_Id],[Object_Id],[Data_Start],[Data_End],[Description] FROM [dbo].[Booking] WHERE Id=" + this.Id.ToString();
        }



        public Booking(int Id)
        {
            this.Id = Id;
            if (this.Id > 0)
            {
                this.GetBooking();
            }
        }

    }
}
