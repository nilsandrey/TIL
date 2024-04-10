# Polymorphic Serialization

<https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/polymorphism>

> TIL we can directly serialize properties of derived classes with System.Text.Json beginning with .NET 7. However, it feels not clean enough to have references to the derived types in the base type. 🤔 
> <https://twitter.com/nilsandrey/status/1778125599761924302>

```csharp
[JsonDerivedType(typeof(WeatherForecastWithCity))]
public abstract class WeatherForecastBase
{
    public DateTimeOffset Date { get; set; }
    public int TemperatureCelsius { get; set; }
    public string? Summary { get; set; }
}

public class WeatherForecastWithCity : WeatherForecastBase
{
    public string? City { get; set; }
}
```
