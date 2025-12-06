using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1;

namespace project1
{
    public class Car
    {
        public string Location = "";
        public int Car_ID;
        public int Thermostat;
        public List<int> Approved_Drivers;
        public bool Windows_Open;
        public bool Lights_On;
        public bool Ramp;
        public List<HeatedSeat> HeatedSeats;
        public Security_System Car_Security_System;
        public Router router = null;

		public Car(int car_id, String location, List<HeatedSeat> seats, List<Camera> cameras){
			this.Car_ID = car_id;
			this.Location = location;
			this.Thermostat = 70;
			this.Approved_Drivers = new List<int>();
			this.Windows_Open = false;
			this.Lights_On = false;
			this.Ramp = false;
			this.HeatedSeats = seats;
			this.Car_Security_System = new Security_System(cameras);
		}

		public Car(int car_id, String location, List<HeatedSeat> seats, List<Camera> cameras, Router router)
        {
            this.Car_ID = car_id;
            this.Location = location;
            this.Thermostat = 70;
            this.Approved_Drivers = new List<int>();
            this.Windows_Open = false;
            this.Lights_On = false;
            this.Ramp = false;
            this.HeatedSeats = seats;
            this.Car_Security_System = new Security_System(cameras);
            if (router != null ) this.router = router;
        }

        public void add_driver(int driver_ID)
        {
            if (driver_ID != 0 && !this.Approved_Drivers.Contains(driver_ID))
            {
                this.Approved_Drivers.Add(driver_ID);
            }
        }

        public void remove_driver(int driver_ID)
        {
            if (driver_ID != 0 && this.Approved_Drivers.Contains(driver_ID))
            {
                this.Approved_Drivers.Remove(driver_ID);
            }
        }

        public void windows_toggle()
        {
            this.Windows_Open = !this.Windows_Open;
        }

        public void lights_toggle()
        {
            this.Lights_On = !this.Lights_On;
        }

        public void ramp_toggle()
        {
            this.Ramp = !this.Ramp;
        }

        public void set_thermostat(int temperature)
        {
            if(temperature >= 50 && temperature <= 85)
            {
                this.Thermostat = temperature;
            }
        }

        // 0 => fetch; 1 => set
        // returns password if get_pwd else returns ""
        public string Router_Menu(bool get_pwd, string pwd = null)
        {
            if (this.router == null) return "";
            if (get_pwd) return this.router.password;
            if (pwd == null)
            {
                this.router.set_password("");
                return "";
            }
            this.router.set_password(pwd);
            return "";
        }
    }
}

namespace project1
{
    public class HeatedSeat
    {
        public bool Seat_On;
        public int Seat_Temperature;
        public HeatedSeat()
        {
            this.Seat_On = false;
            this.Seat_Temperature = 70;
        }
        public void seat_toggle()
        {
            this.Seat_On = !this.Seat_On;
        }
        public void set_seat_temperature(int temperature)
        {
            if (temperature >= 70 && temperature <= 90)
            {
                this.Seat_Temperature = temperature;
            }
        }
    }
}

namespace project1
{
    public class Router
    {
        public String password = "";

        public Router(String initial_password)
        {
            this.password = initial_password;
        }

        public void set_password(String new_password)
        {
            this.password = new_password;
        }
    }
}