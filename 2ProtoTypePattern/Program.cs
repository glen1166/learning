//模拟发送邮件
using _2ProtoTypePattern;

int i = 0;

Mail mail = new Mail(new AdvTemplate());
mail.Tail = "XX银行版权所有";
while (i < 10)
{
    Mail cloneMail = (Mail)mail.Clone();
    cloneMail.Appellation = "客户" + i;
    cloneMail.Receiver = "客户" + i + "@qq.com";
    SendMail(cloneMail);
    i++;
}

