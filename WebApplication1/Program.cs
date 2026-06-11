var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

int lcm = 0;




app.MapGet("/utepbergenovardak8_gmail_com", (int x, int y) =>
{

    bool areNatural = x > 0 && y > 0;
    if (areNatural)
    {
        for (int i = Math.Max(x,y); i <= x*y; i++)
    {
        if (i % x == 0 && i % y == 0)
        {
            lcm = i;
            break;
        }
    }
    return lcm.ToString();
    }
    return "NaN";
    
});

app.Run();