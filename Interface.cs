using System;
using System.Collections.Generic;
using System.Text;

namespace _3B_PracticeProblem
{
        interface IPhone
        {
            public void GetPhoneDetails();

        }
        interface ICamera
        {
            public void GetCameraDetails();
        }

        public class Interface : IPhone, ICamera
        {
            public void GetPhoneDetails()
            {
                Console.WriteLine("Redmi");
            }
            public void GetCameraDetails()
            {
                Console.WriteLine("24 Mega Pixel Camera");
            }
            public void GetDetails()
            {
                Console.WriteLine("its a Redmi Smartphone");
            }
        }
}
