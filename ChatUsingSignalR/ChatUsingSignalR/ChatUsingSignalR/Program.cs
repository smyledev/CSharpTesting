using ChatUsingSignalR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(o =>
{
    o.AddPolicy("AllowAnyOrigin", p => p
        .WithOrigins("null") 
         .AllowAnyHeader()
        .AllowCredentials());
});
builder.Services.AddSignalR();

var app = builder.Build();
app.UseCors("AllowAnyOrigin");
app.MapHub<ChatHub>("/advanced");
app.Run();
