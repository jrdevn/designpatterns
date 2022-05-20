using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;
using System;

namespace ChainOfResponsability 
{
    public class Program
    {
        static Server server;

        static void Init()
        {
            server = new Server();

            server.RegisterUser("jhonata98@hotmail.com", "dfsyyuh7uh8h90hg78");

            server.RegisterUser("user@hotmail.com", "123456");

            Middleware middleware = new CheckUserMiddleware(server);

            middleware
                      .LinkWith(new CheckPermissionMiddleware())
                      .LinkWith(new CheckWeakPasswordMiddleware()); // adding multiples middlewares

            server.SetMiddleware(middleware);
        }
        static void Main(string[] args)
        {
            Init();

            bool done = false;
            do {
                Console.WriteLine("Digite o seu e-mail");
                string email = Console.ReadLine();

                Console.WriteLine("Digite a sua senha");
                string password = Console.ReadLine();

                done = server.Login(email, password);
            }
            while (!done);

            Console.ReadLine();
        }
    }
}