var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // Bu �ekilde MCV �ablonu projeye tan�t�lm�� oluyor.
var app = builder.Build();

// app.MapGet("/", () => "Hello World!"); // localhost html sayfas�nda Hello World! yazar.
// app.MapGet("abc", () => "deneme"); // localhost/abc �eklinde istek atarsak html sayfas�nda deneme yazar.
// app.MapDefaultControllerRoute(); // default rooting ekleme i�in.

app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.UseStaticFiles(); //middleware (projemizdeki statik dosyalar� kullanabilmek i�in.)

app.UseRouting();

app.Run();

// bo� projede;
// mvc olu�turabiliriz. (view'e ihtiyac�m�z olur.)
// rest api de olu�turabiliriz. (view'e ihtiyac�m�z olmaz.)
// razor pages �ablonu da kullanarak proje geli�tirebiliriz.
//yukar�dakilerin hepsi ASP.NET CORE Projesidir. (Bu proje �ablonlar� kurs boyunca g�r�lecektir.)


// builder.Services.AddControllers(); Rest Api kullan�rken Controller e�le�tirmesi yap�yoruz,View'ler ile �al��mad���m�z i�in.

// builder.Services.AddRazorPages(); Razor Pages �ablonuyla �al��mak istedi�imizde bu servis eklenir.
