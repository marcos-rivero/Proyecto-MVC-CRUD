var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

if(app.Environment.IsDevelopment()){
	app.UseDeveloperExceptionPage();
}
else{
	app.UseExceptionHandler("/Error");
}

//app.MapGet("/", () => "Hello World!");
//app.UseDefaultFiles();
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(x => {
	x.MapControllerRoute(
		name: "Default",
		pattern: "{controller}/{action}",
		defaults: new {Controller = "App", Action = "Index"}
	);
});

app.Run();
