var builder = WebApplication.CreateBuilder(args);


// Add services to the container

var app = builder.Build();

// Config the HTTP request pipeline


app.Run();
