var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!!!");

app.MapGet("/add", (int num1, int num2)  => AddNum(num1, num2));

app.MapGet("/subtract", (int num1, int num2) => SubtNum(num1, num2));

app.MapGet("/subtract", (int num1, int num2) => MultNum(num1, num2));

app.Run();


string AddNum(int num1, int num2)
{
    return $"Summan av {num1} och {num2} är: {num1 + num2}";
}
string SubtNum(int num1, int num2)
{
    return $"Differensen av {num1} och {num2} är: {num1 - num2}";
}
string MultNum(int num1, int num2)
{
    return $"Differensen av {num1} och {num2} är: {num1 * num2}";
}