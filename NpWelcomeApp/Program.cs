using System.Net;
using System.Net.NetworkInformation;

//IPAddress localIp = new(new byte[] { 127, 0, 0, 1 });
//IPAddress localIp2 = IPAddress.Parse("127.0.0.1");
//IPAddress localIp3 = IPAddress.Loopback;
// IPAddress.Any : 0.0.0.0
// IPAddress.Broadcast : 255.255.255.255
//Console.WriteLine(localIp3);

// scheme:[//[user_id:password]@domen:port]path[?query][#fragment] - URI (URL)



//string uriStr = "http://shop.com:80/clothes/mens?brand=adidas&size=43#part2";
//Uri uri = new Uri(uriStr);

//Console.WriteLine(uri.AbsolutePath);
//Console.WriteLine(uri.AbsoluteUri);
//Console.WriteLine(uri.Fragment);
//Console.WriteLine(uri.Host);
//Console.WriteLine(uri.Port);
//Console.WriteLine(uri.PathAndQuery);
//Console.WriteLine(uri.Query);
//Console.WriteLine(uri.Scheme);

//Console.WriteLine(string.Join("--", uri.Segments));

//string yandex = "yandex.ru";
////Console.WriteLine(Dns.GetHostName());

//var yandexEntry = await Dns.GetHostEntryAsync(yandex);

//Console.WriteLine(yandexEntry.HostName);

//foreach(var ip in yandexEntry.AddressList)
//    Console.WriteLine($"\t{ip}");



//var properties = IPGlobalProperties.GetIPGlobalProperties();
//var tcpConnects = properties.GetActiveTcpConnections();

//Console.WriteLine($"Count of TCP connects: {tcpConnects.Length}");
//foreach( var tcpConnection in tcpConnects )
//{
//    Console.WriteLine($"Local address: {tcpConnection.LocalEndPoint.Address}");
//    Console.WriteLine($"Remote address: {tcpConnection.RemoteEndPoint.Address}");
//    Console.WriteLine($"State: {tcpConnection.State}");
//    Console.WriteLine();
//}

