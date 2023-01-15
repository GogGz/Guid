namespace GUID;
class Program
{
    static void Main(string[] args)
    {
        Guid obj = Guid.NewGuid();
        Console.WriteLine("Create guid: " + obj.ToString());

        obj = Guid.Empty;

        if (obj == Guid.Empty)
        {
            Console.WriteLine("guid is empty");
        }

        Console.WriteLine(obj.ToString());

        string str = Guid.Empty.ToString();

        Console.WriteLine("string represent empty guid: " + str);

        string str1 = Guid.NewGuid().ToString();

        Console.WriteLine("new guid to string: " + str1);

            
    }
}

