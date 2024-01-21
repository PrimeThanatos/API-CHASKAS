using API_CHASKAS.Domain.Interfaces;
using API_CHASKAS.Infrastructure.Db;
using API_CHASKAS.Infrastructure.Persistance.ArPriceRepository;
using API_CHASKAS.Infrastructure.Persistance.CategoriesRepository;
using API_CHASKAS.Infrastructure.Persistance.CustomerRepository;
using API_CHASKAS.Infrastructure.Persistance.PaymentMethodRepository;
using API_CHASKAS.Infrastructure.Persistance.ProductsRepository;
using API_CHASKAS.Infrastructure.Persistance.PurshaseRepository;
using API_CHASKAS.Infrastructure.Persistance.PurshaseInvoiceRepository;
using API_CHASKAS.Infrastructure.Persistance.PurshasePaymentRepository;
using API_CHASKAS.Infrastructure.Persistance.RecipeRepository;
using API_CHASKAS.Infrastructure.Persistance.SaleInvoiceRepository;
using API_CHASKAS.Infrastructure.Persistance.StepRepository;
using API_CHASKAS.Infrastructure.Persistance.SuppliesRepository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IPostgresqlConnect, DBPostgresqlConnect>();

   // Dependencias para los repositorios
    builder.Services.AddScoped<IArPriceRepository, ArPriceRepository>();
    builder.Services.AddScoped<ICategoriesRepository, CategoriesRepository>();
    builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
    builder.Services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
    builder.Services.AddScoped<IProductsRepository, ProductsRepository>();
    builder.Services.AddScoped<IPurshaseRepository, PurshaseRepository>();
    builder.Services.AddScoped<IPurshaseInvoiceRepository, PurshaseInvoiceRepository>();
    builder.Services.AddScoped<IPurshasePaymentPaymentRepository, PurshasePaymentRepository>();
    builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
    builder.Services.AddScoped<ISaleInvoiceRepository, SaleInvoiceRepository>();
    builder.Services.AddScoped<IStepRepository, StepRepository>();
    builder.Services.AddScoped<ISuppliesRepository, SuppliesRepository>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
