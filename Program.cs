using TheFirm2.model;
using TheFirm2.model.interfaces;

namespace TheFirm2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployee manager = new ITManager(23456, new List<Worker> { new ITWorker(18656, "IT", ESex.Male) }, ESex.Female);
            Employee hIT = new HeadOfIT(56000, ESex.Female);
            ((HeadOfIT)hIT).Addmanager((ITManager)manager);
            Console.WriteLine($"Manager: {manager.Print()}");
            Console.WriteLine($"Head Of IT: {hIT.Print()}");
        }
    }
}