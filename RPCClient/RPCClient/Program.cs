using System;

namespace RPCClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                var rpcClient = new RpcClientClass();

                Console.WriteLine(" [x] Requesting fib " + i);
                var response = rpcClient.Call(i.ToString());
                Console.WriteLine(" [.] Got '{0}'", response);

                rpcClient.Close();
                i++;
            } while (i <1000);
            

            Console.Read();
        }
    }
}
