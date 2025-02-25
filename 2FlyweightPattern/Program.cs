using _2FlyweightPattern;

for (int i = 0; i < 4; i++)
{
    string subject = "科目" + i;
    for (int j = 0; j < 30; j++)
    {
        string key = subject + "考试地点" + j;
        SignInfoFactory.GetSignInfo(key);
    }
}

