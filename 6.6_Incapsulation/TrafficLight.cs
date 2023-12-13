using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _6._6_Incapsulation
{
    public class TrafficLight
    {
        private void ChangeColor(String color) { }
        public String GetColor(String color) => throw new NotImplementedException();
    }
}
