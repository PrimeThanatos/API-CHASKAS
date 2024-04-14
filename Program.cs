using API_CHASKAS.Domain.Interfaces;
using API_CHASKAS.Infrastructure.Db;
using API_CHASKAS.Infrastructure.Persistance.ArPriceRepository;
using API_CHASKAS.Infrastructure.Persistance.CategoriesRepository;
using API_CHASKAS.Infrastructure.Persistance.CustomerRepository;
using API_CHASKAS.Infrastructure.Persistance.PaymentMethodRepository;
using API_CHASKAS.Infrastructure.Persistance.ProductsRepository;
using API_CHASKAS.Infrastructure.Persistance.PurchaseRepository;
using API_CHASKAS.Infrastructure.Persistance.PurchaseInvoiceRepository;
using API_CHASKAS.Infrastructure.Persistance.PurchasePaymentRepository;
using API_CHASKAS.Infrastructure.Persistance.RecipeRepository;
using API_CHASKAS.Infrastructure.Persistance.SaleInvoiceRepository;
using API_CHASKAS.Infrastructure.Persistance.StepRepository;
using API_CHASKAS.Infrastructure.Persistance.SuppliesRepository;
using API_CHASKAS.Aplication.Interfaces;
using API_CHASKAS.Aplication.Services;
using API_CHASKAS.Aplication.DTOs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IPostgresqlConnect, DBPostgresqlConnect>();

   // Dependencias para los repositorios
    builder.Services.AddScoped<IArPriceRepository, ArPriceRepository>();
    builder.Services.AddScoped<ICategoriesRepository, CategoriesRepository>();
    builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
    builder.Services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
    builder.Services.AddScoped<IProductsRepository, ProductsRepository>();
    builder.Services.AddScoped<IPurchaseRepository, PurchaseRepository>();
    builder.Services.AddScoped<IPurchaseInvoiceRepository, PurchaseInvoiceRepository>();
    builder.Services.AddScoped<IPurchasePaymentPaymentRepository, PurchasePaymentRepository>();
    builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
    builder.Services.AddScoped<ISaleInvoiceRepository, SaleInvoiceRepository>();
    builder.Services.AddScoped<IStepRepository, StepRepository>();
    builder.Services.AddScoped<ISuppliesRepository, SuppliesRepository>();

     // Dependencias para los Servicios
    builder.Services.AddScoped<IArPriceService, ArPriceService>();
    builder.Services.AddScoped<ICategoryService, CategoryService>();
    builder.Services.AddScoped<ICustomerService<DtoCustomer>, CustomerService>();
    builder.Services.AddScoped<IPaymentMethodService<DtoPaymentMethod>, PaymentMethodService>();

    builder.Services.AddScoped<IProductsService<DtoProducts>, ProductsService>();
    builder.Services.AddScoped<IPurchaseInvoicesService<DtoPurchaseInvoice>, PurchaseInvoiceInvoicesService>();
    builder.Services.AddScoped<IPurchasePaymentService<DtoPurchasePayment>, PurchasePaymentService>();
    builder.Services.AddScoped<IPurchaseService<DtoPurchase>, PurchasesService>();
    builder.Services.AddScoped<IRecipeService<DtoRecipe>, RecipeService>();
    builder.Services.AddScoped<ISaleInvoiceService<DtoSaleInvoice>, SaleInvoiceService>();
    builder.Services.AddScoped< IStepService<DtoStep>, StepService>();
    builder.Services.AddScoped<ISupplierService<DtoSupplier>, SupplierService>();




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

app.UseCors(options =>
{
    options.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
});


app.MapControllers();

app.Run();
