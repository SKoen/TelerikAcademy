using System;
using System.Text;

class Get
{
    static void Main()
    {
        Console.Write("Enter URL: ");
        string url = Console.ReadLine();
        string protocol = string.Empty;
        string server = string.Empty;
        string resource = string.Empty;
        int position = 0, positionTwo = 0;

        protocol = url.Substring(0, 4);
         position = url.IndexOf('w');
         positionTwo = url.IndexOf('/', position);
        server = url.Substring(position, positionTwo - position);
        resource = url.Substring(positionTwo, url.Length - positionTwo);
        Console.WriteLine("[protocol]: {0}\n[server]: {1}\n[resource]: {2}", protocol,server,resource);
    }
}
