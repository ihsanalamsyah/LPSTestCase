

#region Test Playground

//string? result = ApplicationCheck.ApplicationCheckFunc();
//int number = ApplicationCheck.number;
string resultGetInfo = "";
//ApplicationInfo result2 = ApplicationGetInfo.GetInfo(out resultGetInfo);
Console.WriteLine(resultGetInfo);

//string laptop = Laptop.GetLaptop("MacOS");

//Console.WriteLine(laptop);

//var result10 = ProgramChac.MainChach();
#endregion



#region Kumpulan Class Test Case
//1
class ApplicationCheck
{

    class Application
    {
        public ProtectClass? Protect { get; set; }
    }
    class ProtectClass
    {
        public string? ShieldLastRun { get; set; }
    }
    public static string? ApplicationCheckFunc()
    {
        Application application = new Application();

        string? result = application?.Protect?.ShieldLastRun;
        return result;
    }
}



//2
public class ApplicationGetInfo
{

    public static ApplicationInfo GetInfo(out string? resultGetInfo)
    {

        ApplicationInfo applicationInfo = new ApplicationInfo
        {
            Path = "C:/apps/",
            Name = "Shield.exe"
        };
        resultGetInfo = "C:";
        return applicationInfo;

    }

}
public class ApplicationInfo
{
    public string? Path { get; set; }
    public string? Name { get; set; }
}

//3
public class Laptop
{
    private string Os { get; set; }
    private Laptop(string os)
    {
        Os = os;
    }
    public static string GetLaptop(string os)
    {
        Laptop laptop = new Laptop(os);
        return laptop.Os;
    }

}

//4
namespace MemoryLeakExample
{
    class Program
    {
        static void Main()
        {
            var myList = new List<Prod>();
            for (int i = 0; i < 1000; i++)
            {
                myList.Add(new Prod(Guid.NewGuid().ToString(), i));
            }
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"Prod id: {myList[i].SKU} dengan harga: {myList[i].Price}");
            }
        }
    }
    class Prod
    {
        public string SKU { get; set; }
        public decimal Price { get; set; }
        public Prod(string sku, decimal price)
        {
            SKU = sku;
            Price = price;
        }
    }
}

//5
namespace MemoryLeakExample2
{
    class Program
    {
        static void Main()
        {
            EventPublish publisher = new EventPublish();

            EventSubs subscribe = new EventSubs(publisher);
            publisher.TriggerEvent();
        }
    }
    class EventPublish
    {
        public event EventHandler MyEvent;

        public void RaiseEvent()
        {
            MyEvent?.Invoke(this, EventArgs.Empty);
        }

        public void TriggerEvent()
        {
            RaiseEvent();
        }

    }
    class EventSubs
    {
        public EventSubs(EventPublish publish)
        {
            publish.MyEvent += OnMyEvent;
        }
        private void OnMyEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event process");
        }
    }
}


//6
namespace MemoryLeakExample3
{
    class Program
    {
        static void Main()
        {
            RootNode rootNode = new RootNode();
            TreeNode newNode = new TreeNode();
            for (int i = 0; i < 1000; i++)
            {
                TreeNode childNode = new TreeNode();
                newNode.AddChildren(childNode);
            }
            rootNode.AddToRoot(newNode, "Root Node");

            Console.WriteLine($"Count Root Node {newNode.ChildrenCount}");
        }
    }
    class TreeNode
    {
        private readonly List<TreeNode> _children = new List<TreeNode>();
        public void AddChildren(TreeNode args)
        {
            _children.Add(args);
        }
        public int ChildrenCount => _children.Count;

    }
    class RootNode
    {
        private string? Name { get; set; }
        private TreeNode? Node { get; set; }

        public void AddToRoot(TreeNode node, string name)
        {
            Node = node;
            Name = name;
        }
    }
}


//7
class ProgramChac
{
    public static void MainChach()
    {
        Console.WriteLine("Input your name to cache");
        string? s = Console.ReadLine();
        Orang orang = new Orang
        {
            Nama = s
        };
        for (int i = 0; i < 1000; i++)
        {
            Chace.AddCahc(i, orang);
        }
        Console.WriteLine($"Chache Created Loop 1000x with value {orang.Nama}");
        Orang? hasilChace = Chace.GetObjChac(10);
        Console.WriteLine($"Chache Get with key {10} dengan nama: {hasilChace?.Nama} ");
    }
}
class Chace
{
    private static readonly Dictionary<int, object> chace = new Dictionary<int, object>();
    public static void AddCahc(int i, object obj)
    {
        chace.Add(i, obj);
    }
    public static Orang? GetObjChac(int i)
    {
        Orang? hasilWhere = chace.Where(x => x.Key == i).FirstOrDefault().Value as Orang;
        return hasilWhere;
    }

}
public class Orang
{
    public string? Nama { get; set; }
}

#endregion

