using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Context
    {
        public static OpenningState openningState = new OpenningState();
        public static ClosingState closingState = new ClosingState();
        public static RunningState runningState = new RunningState();
        public static StoppingState stoppingState = new StoppingState();

        private LiftState? liftState;

        public LiftState? GetLiftState()
        {
            return liftState;
        }

        public void SetLiftState(LiftState liftState)
        {
            this.liftState = liftState;
            this.liftState.SetContext(this);
        }

        public void Open()
        {
            this.liftState?.Open();
        }

        public void Close()
        {
            this.liftState?.Close();
        }

        public void Run()
        {
            this.liftState?.Run();
        }

        public void Stop()
        {
            this.liftState?.Stop();
        }
    }
}
