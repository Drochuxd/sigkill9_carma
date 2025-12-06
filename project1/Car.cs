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
        public static string Location = "";
        public int Car_ID;
        public int Thermostat;
        public List<int> Approved_Drivers;
        public Boolean Engine_On;
        public Boolean Windows_Open;
        public Boolean Lights_On;
        public Boolean Ramp;
        public List<HeatedSeat> HeatedSeats;
        public Security_System Car_Security_System;

        public Car(int car_id, String location, List<HeatedSeat> seats)
        {
            Car_ID = car_id;
            Location = location;
            Thermostat = 70;
            Approved_Drivers = new List<int>();
            Engine_On = false;
            Windows_Open = false;
            Lights_On = false;
            Ramp = false;
            HeatedSeats = seats;
            Car_Security_System = new Security_System();
            Car_Security_System.cameras.Add(new Camera(1));
        }

        public void add_driver(int driver_ID)
        {
            if (driver_ID != 0 && !Approved_Drivers.Contains(driver_ID))
            {
                Approved_Drivers.Add(driver_ID);
            }
        }

        public void remove_driver(int driver_ID)
        {
            if (driver_ID != 0 && Approved_Drivers.Contains(driver_ID))
            {
                Approved_Drivers.Remove(driver_ID);
            }
        }

        public void engine_toggle()
        {
            Engine_On = !Engine_On;
        }

        public void windows_toggle()
        {
            Windows_Open = !Windows_Open;
        }

        public void lights_toggle()
        {
            Lights_On = !Lights_On;
        }

        public void ramp_toggle()
        {
            Ramp = !Ramp;
        }

        public void set_thermostat(int temperature)
        {
            if(temperature >= 50 && temperature <= 85)
            {
                Thermostat = temperature;
            }
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
            Seat_On = false;
            Seat_Temperature = 70;
        }
        public void seat_toggle()
        {
            Seat_On = !Seat_On;
        }
        public void set_seat_temperature(int temperature)
        {
            if (temperature >= 70 && temperature <= 90)
            {
                Seat_Temperature = temperature;
            }
        }
    }
}

namespace project1
{
    public class Router
    {
        public static String password = "";

        public Router(String initial_password)
        {
            password = initial_password;
        }

        public static void set_password(String new_password)
        {
            password = new_password;
        }
    }
}