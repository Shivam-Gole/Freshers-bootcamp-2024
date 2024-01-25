using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent
{
    public class Program
    {
        static void Main()
        {
            SimpleDoor simpleDoor = new SimpleDoor();
            SmartDoor smartDoor = new SmartDoor(true, true, true);

            Operator doorOperator = new Operator();

            doorOperator.OperateDoor(simpleDoor);
            Console.WriteLine();

            doorOperator.OperateDoor(smartDoor);
        }
    }
}
