using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelinePattern
{
    public abstract class BaseDataflowBlock<TInput, TOutput>
    {

        //下一个要执行的过程
        private Action<TOutput>? nextHandler;
        
        /// <summary>
        /// 处理下一个方法
        /// </summary>
        /// <param name="output"></param>
        protected void HandleNext(TOutput output)
        {
            if (this.nextHandler != default)
            {
                this.nextHandler(output);
            }
        }

        /// <summary>
        /// 连接下一个执行单元
        /// </summary>
        /// <typeparam name="TNewOutput"></typeparam>
        /// <param name="newBlock"></param>
        /// <returns></returns>
        public BaseDataflowBlock<TOutput, TNewOutput> LinkTo<TNewOutput>(BaseDataflowBlock<TOutput, TNewOutput> newBlock)
        {
            this.nextHandler = newBlock.Handle;
            return newBlock;
        }

        protected void LogInfo(string message)
        {
            Console.WriteLine($"{DateTime.Now}:{message}");
        }

        public TOutput? OutputData { get; protected set; }

        /// <summary>
        /// 处理数据
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public abstract void Handle(TInput input);




    }
}
