using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class OpenningState : LiftState
    {
        public override void Open()
        {
            Console.WriteLine("Lift is openning.");
        }

        public override void Close()
        {
            base.context.SetLiftState(Context.closingState);
            base.context.GetLiftState().Close();
        }

        public override void Run()
        {
            // do nothing
        }

        public override void Stop()
        {
            // do nothing
        }
    }
}
