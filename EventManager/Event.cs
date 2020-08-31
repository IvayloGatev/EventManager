using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EventManager
{
    class Event
    {
        private string name;
        private string location;
        private DateTime startDT;
        private DateTime endDT;

        public Event()
        {
            this.name = null;
            this.location = null;
            this.startDT = default(DateTime);
            this.endDT = default(DateTime);
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        public DateTime StartDT
        {
            get { return this.startDT; }
            set { this.startDT = value; }
        }

        public DateTime EndDT
        {
            get { return this.endDT; }
            set { this.endDT = value; }
        }

        public void Create()
        {
            Console.Write("Name: ");
            this.Name = Console.ReadLine();
            Console.Write("Location: ");
            this.Location = Console.ReadLine();
            Console.Write("Start date and time(format: dd.MM.yyyy hh:mm): ");
            this.StartDT = DateTime.Parse(Console.ReadLine());
            Console.Write("End date and time(format: dd.MM.yyyy hh:mm): ");
            this.EndDT = DateTime.Parse(Console.ReadLine());
            while (DateTime.Compare(this.StartDT, this.EndDT) >= 0)
            {
                Console.WriteLine("The end of the event can't be before the start!");
                Console.Write("Please input end date and time(format: dd.MM.yyyy hh:mm) again: ");
                this.EndDT = DateTime.Parse(Console.ReadLine());
            }
        }
    }
}
