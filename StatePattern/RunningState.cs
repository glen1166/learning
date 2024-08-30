using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class RunningState:LiftState
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
            Console.WriteLine("Lift is running.");
        }

        public override void Stop()
        {
            base.context.SetLiftState(Context.stoppingState);
            base.context.GetLiftState().Stop();
        }
    }
}
