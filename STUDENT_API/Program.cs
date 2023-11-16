using Microsoft.EntityFrameworkCore;
using STUDENT_API;

var builder = WebApplication.CreateBuilder(args); //bilder bilda nasu app
//servis je neki kod koji je vec odradjen i dodajemo ga nasoj aplikaciji(komponenta api-a)
// Add services to the container.

builder.Services.AddControllers();  //kontroleri su funkcije koje se pokrecu kada neko posalje request na neki od nasih endpoint-ova
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//moram da dodam ovaj servis!!
builder.Services.AddCors(options => { //CORS - pravilo pomocu kojeg dozvoljavamo sa kojih hostova moze da se posalje request (sa kojih hostova requestove ce da prihvati, a koje da odbije)
    //u argumente mi je lambda izdraz, u njemu konfigurisemo cors policy
    options.AddPolicy("pravilo", argument =>
    {
        argument.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
    });
});
//14. dodajemo servise DbContext 
//--prvo smo morali da napravimo dataContext da bismo dodali dbContext service)
// --da bismo napravili data context trebala nam je klasa Student tj model-- 
//db context nam omogucava da radimo sa bazom zato dodajemo service

builder.Services.AddDbContext<DataContext>(options =>
{
    //16.kazemo dbContext sa kojim tipom baze ce da radi (sa kojom bazom radi u zagradama - to je ConnectionString (ono sto kopiramo sa sql-a) )
    options.UseSqlServer("Server=.;Database=Studenti;Trusted_Connection=True;");
    //17. MIGRACIJE MIGRACIJEEEEEEEE, otvorim tools->Nuget package.. -> package manager CONSOLE i pisemo Add-Migration i neko ime migracije i posle to dodajemo na bazu Update-Migration
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//posle swaggera i pre autorizacije moramo da kazemo aplikaciji da koristi moja Cors pravila
app.UseCors("pravilo");

app.UseAuthorization();

app.MapControllers();

app.Run();
