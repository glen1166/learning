using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    internal abstract class AbstractLogger
    {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;

        public AbstractLogger(int level)
        {
            this._level = level;
        }

        private readonly int _level;

        //责任链中的下一个元素
        protected AbstractLogger? nextLogger;

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            this.nextLogger = nextLogger;
        }

        public void LogMessage(int level, String message)
        {
            if (this._level == level)
            {
                Write(message);
            }

            if (nextLogger != null)
            {
                nextLogger.LogMessage(level, message);
            }
        }

        abstract protected void Write(String message);
    }
}
