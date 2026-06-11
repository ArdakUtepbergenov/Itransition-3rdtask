var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/utepbergenovardak8_gmail_com", (string? x, string? y) =>
{
    long lcm = 0;
    if (!(long.TryParse(x, out long xNum) && long.TryParse(y, out long yNum)))
    {
    return "NaN";
    }

    bool areNatural = xNum > 0 && yNum > 0;
    if (areNatural)
    {
        for (long i = Math.Max(xNum,yNum); i <= xNum*yNum; i++)
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