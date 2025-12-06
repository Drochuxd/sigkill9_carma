using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1;

namespace project1
{
	public class Vehicle_Manger
	{
		public List<Car> vehicle_list;

		public Vehicle_Manger()
		{
			this.vehicle_list = new List<Car>();
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
