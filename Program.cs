var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // Bu þekilde MCV þablonu projeye tanýtýlmýþ oluyor.
var app = builder.Build();

// app.MapGet("/", () => "Hello World!"); // localhost html sayfasýnda Hello World! yazar.
// app.MapGet("abc", () => "deneme"); // localhost/abc þeklinde istek atarsak html sayfasýnda deneme yazar.
// app.MapDefaultControllerRoute(); // default rooting ekleme için.

app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.UseStaticFiles(); //middleware (projemizdeki statik dosyalarý kullanabilmek için.)

app.UseRouting();

app.Run();

// boþ projede;
// mvc oluþturabiliriz. (view'e ihtiyacýmýz olur.)
// rest api de oluþturabiliriz. (view'e ihtiyacýmýz olmaz.)
// razor pages þablonu da kullanarak proje geliþtirebiliriz.
//yukarýdakilerin hepsi ASP.NET CORE Projesidir. (Bu proje þablonlarý kurs boyunca görülecektir.)


// builder.Services.AddControllers(); Rest Api kullanýrken Controller eþleþtirmesi yapýyoruz,View'ler ile çalýþmadýðýmýz için.

// builder.Services.AddRazorPages(); Razor Pages þablonuyla çalýþmak istediðimizde bu servis eklenir.
