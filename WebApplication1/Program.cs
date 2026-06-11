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
        for (long i = xNum; i > 0; i--)
    {
        if (xNum % i == 0 && yNum % i == 0)
        {
            lcm = i;
        }
    }
    return (xNum*yNum/lcm).ToString();
    }
    return "NaN";
    
});

app.Run();