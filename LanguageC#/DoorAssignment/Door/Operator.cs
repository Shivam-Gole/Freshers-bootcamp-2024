using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent
{
    public class Operator
    {
        public void OperateDoor(SimpleDoor door)
        {
            door.Open();
            door.Close();
        }
    }

}
