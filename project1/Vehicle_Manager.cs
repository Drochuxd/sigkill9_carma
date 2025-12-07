using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1;
// remove me

namespace project1
{
	public class Vehicle_Manager
	{
		public List<Car> vehicle_list;
		public bool alert_on;

		public Vehicle_Manager()
		{
			this.vehicle_list = new List<Car>();
			this.vehicle_list.Add(new Car(1, "5 miles", new List<HeatedSeat>([new HeatedSeat(), new HeatedSeat()]), new List<Camera>([new Camera(1)])));
            this.vehicle_list.Add(new Car(2, "nowhere", new List<HeatedSeat>([new HeatedSeat(), new HeatedSeat(), new HeatedSeat()]), new List<Camera>()));
            this.alert_on = false;
		}

		public void add_car(Car vehicle)
		{
			this.vehicle_list.Add(vehicle);
		}

		public void remove_car(int index)
		{
			this.vehicle_list.RemoveAt(index);
		}

		public void set_pwd(string pwd, int index)
		{
			this.vehicle_list[index].Router_Menu(false, pwd);
		}

		
	}
}
