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

        public Security_System(List<Camera> cameras) 
        {
            this.cameras = cameras;
        }

        public void detect_motion(int camera_id)
        {
            foreach (Camera cam in this.cameras)
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
        public bool Detect_Motion;

        public Camera(int id)
        {
            this.Camera_ID = id;
            this.Detect_Motion = false;
        }

        public void motion_toggle()
        {
            this.Detect_Motion = !this.Detect_Motion;
        }
    }
}
