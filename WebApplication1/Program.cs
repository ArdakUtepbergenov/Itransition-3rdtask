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
        long minNum = xNum;
        long maxNum = yNum;
        while (maxNum != 0)
        {
            long c = maxNum;
            maxNum = minNum % maxNum;
            minNum = c;
        }

    return (xNum*yNum/minNum).ToString();
    }
    return "NaN";
    
});

app.Run();