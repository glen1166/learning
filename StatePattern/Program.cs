// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//using StatePattern;

//Context context = new Context();
//context.SetLiftState(Context.openningState);
//context.Open();
//context.Close();
//context.Run();
//context.Stop();


// Assuming you have a DataTable dt with some data
using System.Data;




DataTable dt = new DataTable();
dt.Columns.Add("ID", typeof(int));
dt.Columns.Add("Name", typeof(string));
dt.Rows.Add(DBNull.Value, DBNull.Value); 

foreach(DataRow row in dt.Rows)
{
    var aa = row["ID"];

    UpdateField(ref aa);

    var bb = row["ID"];

    Console.WriteLine(bb.ToString());
}

static void UpdateField(ref object? val)
{
    val = 1;
}

