var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

int lcm = 0;




app.MapGet("/utepbergenovardak8_gmail_com", (string x, string y) =>
{

    if (!(int.TryParse(x, out int xNum) && int.TryParse(y, out int yNum)))
    {
    return "NaN";
    }

    bool areNatural = xNum > 0 && yNum > 0;
    if (areNatural)
    {
        for (int i = Math.Max(xNum,yNum); i <= xNum*yNum; i++)
    {
        if (i % xNum == 0 && i % yNum == 0)
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