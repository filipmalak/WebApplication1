using Microsoft.AspNetCore.Mvc;
using WebApplication1.DB;
using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Needed for controller base approach
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// GET /api/Schronisko
app.MapGet("/api/schronisko", () =>
{
    return Results.Ok(Db.Schronisko);
});

// GET /api/Schronisko/1
app.MapGet("/api/schronisko/{id:int}", (int id) =>
{
    var zwierze = Db.Schronisko.FirstOrDefault(st => st.Id == id);
    return zwierze is null ? Results.NotFound() : Results.Ok(zwierze);
});


// POST api/Schronisko
app.MapPost("/api/schronisko", ([FromBody] Zwierze zwierze) =>
{
    Db.Schronisko.Add(zwierze);
    return Results.Created($"/api/schronisko/{zwierze.Id}", zwierze);
});

// PUT api/Schronisko/1
app.MapPut("/api/schronisko/{id:int}", (int id, [FromBody] Zwierze data) =>
{
    var zwierze = Db.Schronisko.FirstOrDefault(st => st.Id == id);
    if (zwierze is null) return Results.NotFound($"Zwierze with id {id} not found");
    
    zwierze.Imie = data.Imie;
    zwierze.Kategoria = data.Kategoria;
    zwierze.Masa = data.Masa;
    zwierze.Kolor_siersci = data.Kolor_siersci;
    return Results.Ok(zwierze);
});

//usuwanie
app.MapDelete("/api/schronisko/{id:int}", (int id) =>
{
    var zwierze = Db.Schronisko.Where(st => st.Id != id);
    Db.Schronisko = zwierze.ToList();
    return Results.Ok();
});


//wizyty powiązane z danym zwierzęciem
app.MapGet("/api/schronisko/{id:int}/appointments", (int id) =>
{
    var zwierze = Db.Schronisko.FirstOrDefault(st => st.Id == id);
    if (zwierze is null) return Results.NotFound($"Zwierze with id {id} not found");
    
    var wizyty = Db.Wizyty.Where(w => w.zwierze == zwierze).ToList();
    return wizyty.Count == 0 ? Results.NotFound() : Results.Ok(wizyty);
});


//dodawanie nowych wizyt
app.MapPost("/api/schronisko/{id:int}/appointments", 
    (int id, [FromBody] Appointment wizyta) =>
    {
        var zwierze = Db.Schronisko.FirstOrDefault(st => st.Id == id);
        if (zwierze is null) return Results.NotFound($"Zwierze with id {id} not found");

        wizyta.zwierze = zwierze;
        Db.Wizyty.Add(wizyta);
        return Results.Created($"/api/schronisko/{zwierze.Id}/appointments/{wizyta.id}", wizyta);
    });








// Needed for controller base approach
app.MapControllers();

app.UseHttpsRedirection();

app.Run();

