using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_app
{
    public class Object_Group
    {
        private int Id { get; set; }
        public string Name { get; set; }

        public string ToString      //missing ()?
        {
            get { return Name; }
        }
        private void GetObject_Group()
        {
            string sql = "SELECT [Id],[Name] FROM [Object_Group] WHERE Id="+this.Id.ToString();
        }



        public Object_Group(int Id)
        {
            this.Id = Id;
            if (this.Id > 0)
            {
                this.GetObject_Group();
            }
        }

    }
}
