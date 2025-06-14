using Art_Gallery;
using Art_Gallery.CustomerItems;
using Art_Gallery.Model.ArtPieceItems;
using Art_Gallery.Model.CategoryItems;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICustomerRepo,CustomerRepo>();
builder.Services.AddScoped<IArtPieceRepo,ArtPieceRepo>();
builder.Services.AddScoped<ICategoryRepo,CategoryRepo>();
builder.Services.AddDbContext<AppDbContext>(op=>op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));   
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
