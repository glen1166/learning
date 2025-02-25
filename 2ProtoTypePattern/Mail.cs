using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ProtoTypePattern
{
    internal class Mail : ICloneable
    {
        public Mail(AdvTemplate advTemplate)
        {
            this.Context = advTemplate.GetAdvContext();
            this.Subject = advTemplate.GetAdvSubject();
        }

        /// <summary>
        /// 收件人
        /// </summary>
        public string? Receiver { get; set; }
        
        /// <summary>
        /// 邮件名称
        /// </summary>
        public string? Subject { get; set; }
        
        /// <summary>
        /// 称谓
        /// </summary>
        public string? Appellation { get; set; }
        
        /// <summary>
        /// 邮件内容
        /// </summary>
        public string? Context { get; set; }

        /// <summary>
        /// 邮件尾部，一般都是加上"XXX版权所有"等信息
        /// </summary>
        public string? Tail { get; set; }
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
