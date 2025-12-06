using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class Security_System
    {
        public List<Camera> cameras;
        public Security_System() 
        {
            cameras = new List<Camera>();
        }

        public void detect_motion(int camera_id)
        {
            foreach (Camera cam in cameras)
            {
                if (cam.Detect_Motion)
                {
                    // Logic to handle motion detection to Notification System
                }
            }
        }
    }
}

namespace project1
{
    public class Camera
    {
        public int Camera_ID;
        public Boolean Detect_Motion;

        public Camera(int id)
        {
            Camera_ID = id;
            Detect_Motion = false;
        }

        public void motion_toggle()
        {
            Detect_Motion = !Detect_Motion;
        }
    }
}
