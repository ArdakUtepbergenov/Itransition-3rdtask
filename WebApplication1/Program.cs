var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/utepbergenovardak8_gmail_com", (string? x, string? y) =>
{
    if (!(long.TryParse(x, out long xNum) && long.TryParse(y, out long yNum)))
    {
    return "NaN";
    }

    bool areNatural = xNum > 0 && yNum > 0;
    if (areNatural)
    {
        long a = xNum;
        long b = yNum;
        while (b != 0)
        {
            long c = b;
            b = a % b;
            a = c;
        }

    return (xNum*yNum/a).ToString();
    }
    return "NaN";
    
});

app.Run();