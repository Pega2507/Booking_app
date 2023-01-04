using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_app
{
    public class Object
    {
        private int Id { get; set; }
        public string Name { get; set; }
        public string Localization { get; set; }
        public int Group_Id { get; set; }

        public string ToString      //missing ()?
        {
            get { return Name; }
        }
        private void GetObject()
        {
            string sql = "SELECT [Id],[Name],[Group_Id],[Localization] FROM [Object] WHERE Id=" + this.Id.ToString();
        }



        public Object(int Id)
        {
            this.Id = Id;
            if (this.Id > 0)
            {
                this.GetObject();
            }
        }

    }
}