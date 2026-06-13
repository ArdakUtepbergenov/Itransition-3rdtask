using System.Numerics;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/utepbergenovardak8_gmail_com", (string? x, string? y) =>
{
    if (!(BigInteger.TryParse(x, out BigInteger xNum) && BigInteger.TryParse(y, out BigInteger yNum)))
    {
    return "NaN";
    }

    bool areNatural = xNum > 0 && yNum > 0;
    if (areNatural)
    {
        BigInteger a = xNum;
        BigInteger b = yNum;
        while (b != 0)
        {
            BigInteger c = b;
            b = a % b;
            a = c;
        }
    BigInteger result = xNum*yNum/a;
    return result.ToString();
    }
    return "NaN";
    
});

app.Run();