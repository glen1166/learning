using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class ClosingState : LiftState
    {
        public override void Open()
        {
            base.context.SetLiftState(Context.openningState);
            base.context.GetLiftState().Open();
        }

        public override void Close()
        {
            Console.WriteLine("Lift is closing.");
        }

        public override void Run()
        {
            base.context.SetLiftState(Context.runningState);
            base.context.GetLiftState().Run();
        }

        public override void Stop()
        {
            base.context.SetLiftState(Context.stoppingState);
            base.context.GetLiftState().Stop();
        }
    }
}
