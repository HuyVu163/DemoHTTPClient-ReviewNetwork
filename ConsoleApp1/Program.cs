﻿using System.Net;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        //code này là vd1

        /* Uri info = new Uri("https://www.domain.com:80/info?id=123#fragment");
         Uri page = new Uri("https://www.domain.com/info/page.html");
         WriteLine($"Host: {info.Host}");
         WriteLine($"Port: {info.Port}");
         WriteLine($"PathAndQuery: {info.PathAndQuery}");
         WriteLine($"Query: {info.Query}");
         WriteLine($"Fragment: {info.Fragment}");
         WriteLine($"Default HTTP port: {info.Port}");
         WriteLine($"IsBaseOf: {info.IsBaseOf(page)}");
         Uri relative = info.MakeRelativeUri(page);
         WriteLine($"IsAbsoluteUri: {relative.IsAbsoluteUri}");
         WriteLine($"RelativeUri: {relative.ToString()}");
         ReadLine();*/

        //code này là vd2

        // Create a request for the URL.
        WebRequest request = WebRequest.Create("http://www.contoso.com/default.html");
        // If required by the server, set the credentials.
        request.Credentials = CredentialCache.DefaultCredentials;
        // Get the response.
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        // Display the status
        Console.WriteLine("Status: " + response.StatusDescription);
        Console.WriteLine(new string('*', 50));
        // Get the stream containing content returned by the server.
        Stream dataStream = response.GetResponseStream();
        // Open the stream using a StreamReader for easy access.
        StreamReader reader = new StreamReader(dataStream);
        // Read the content.
        string responseFromServer = reader.ReadToEnd();
        // Display the content.
        Console.WriteLine(responseFromServer);
        Console.WriteLine(new string('*', 50));
        // Cleanup the streams and the response.
        reader.Close();
        dataStream.Close();
        response.Close();
    }
}