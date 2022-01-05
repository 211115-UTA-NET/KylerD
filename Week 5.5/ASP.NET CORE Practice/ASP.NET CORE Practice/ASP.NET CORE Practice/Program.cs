using System.Net.Mime;
using System.Text;
using System.Xml.Serialization;
using ASP.NET_CORE_Practice;
using Microsoft.AspNetCore.Server.Kestrel.Core;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<KestrelServerOptions>(options => options.AllowSynchronousIO = true);
WebApplication app = builder.Build();

app.Run(context =>
{
    string filePath = context.Request.Query["path"];

    //Console.WriteLine("===");
    //Console.WriteLine(filePath);
    //Console.WriteLine("===");

    if (File.Exists(filePath))
    {
        context.Response.StatusCode = (200);
        context.Response.ContentType = "text/plain";

        string reader = File.ReadAllText(filePath);
        context.Response.Body.Write(Encoding.UTF8.GetBytes(reader));

        return Task.CompletedTask;
    }
    else
    {
        context.Response.StatusCode = 401;
        context.Response.ContentType = "text/plain";
        context.Response.Body.Write(Encoding.UTF8.GetBytes("Error, no file"));

        return Task.CompletedTask;
    }
});

app.Run();



//var serializer = new XmlSerializer();
//List<Data> theData = new()
//{
//    new Data { Number = 3, More = new() },
//    new Data { Number = 2, More = new() },
//    new Data { Number = 5 }
//};

//app.Use(async (context, next) =>
//{
//    if (context.Request.Path.StartsWithSegments("/data"))
//    {
//        context.Response.StatusCode = StatusCodes.Status200OK;
//        context.Response.ContentType = MediaTypeNames.Text.Xml;

//        serializer.Serialize(stream: context.Response.Body, o: theData);
//    }
//    else
//    {
//        await next(context);
//    }
//});