using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class StoppingState : LiftState
    {
        public override void Open()
        {
            // do nothing
        }

        public override void Close()
        {
            // do nothing
        }

        public override void Run()
        {
            // do nothing
        }

        public override void Stop()
        {
            Console.WriteLine("Lift is stopping.");
        }
    }
}
