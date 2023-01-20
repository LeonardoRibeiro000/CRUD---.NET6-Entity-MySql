using Microsoft.EntityFrameworkCore;
using CrudMySql.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();




// Conexão com o Banco de dados "Mysql"
builder.Services.AddDbContext<Contexto>
    (options => options.UseMySql("server=localhost;initial catalog=Crud_Mysql_Entity;uid=root;pwd=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.25-mysql")));

    var app = builder.Build();



// Configure the HTTP request pipeline. ====================================================================================================
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Produtoes}/{action=Index}/{id?}"); //Alterar pattern com o nome do controller criado

app.Run();
