using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace PRO_001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //using (Models.erp_MYCADBContext db = new Models.erp_MYCADBContext())
            //{
            //    List<Models.MonConsolaUsuariosWeb> lst = (from d in db.MonConsolaUsuariosWeb
            //                                              select d).ToList();
            //    foreach (Models.MonConsolaUsuariosWeb op in lst)
            //    {
            //        Console.WriteLine(op.Correo);

            //    }

            CreateHostBuilder(args).Build().Run();
       
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
