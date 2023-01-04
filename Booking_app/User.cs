using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_app
{
    public class User
    {
        private int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }

        public string ToString      //missing ()?
        {
            get { return Name + " " + Surname; }
        }
        private void GetUser()
        {
            string sql = "SELECT [Id],[Name],[Surname],[Email],[Phone] FROM [User] WHERE Id="+this.Id.ToString();
        }



        public User(int Id)
        {
            this.Id = Id;
            if (this.Id > 0)
            {
                this.GetUser();
            }
        }

    }
}
