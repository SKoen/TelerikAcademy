using System;
using System.Net;

class FileDownloader
{
    static void Main()
    {
        Console.WriteLine("This program downloads a file from internet\nby given URL from the user.");
        Console.Write("Please enter the link of the address: ");
        string link = Console.ReadLine();
        Console.Write("Please enter file name: ");
        string filename = Console.ReadLine();
        string fullAddress = link + "/" + filename;
        WebClient webClient = new WebClient();
        try
        {
            webClient.DownloadFile(fullAddress, filename);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The address can not be null");
        }
        catch (WebException)
        {
            Console.WriteLine("Invalid address or empty file.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("This method does not support simultaneous downloads.");
        }
        finally
        {
            webClient.Dispose();
        }
    }
}