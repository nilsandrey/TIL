# Swagger filter

There are types in a swagger generation whose schemas that don't automatically get exported. This is the case for example, when you define a base class for a parameter and expect that the open API docs reflect each possible derived value and its structure. At least happened to me with abstract base classes or records. You must explicitly instruct to spin out the schemas to swagger at startup. 

This is a sample code that took a list of base classes and exported all it's derived types:

```c#
/// <summary>
/// Swagger filter for enriching types schemas like derived types.
/// </summary>
internal class SwaggerFilter : ISchemaFilter
{
	private static readonly List<Type> AbstractBaseTypes = new()
	{
		typeof(BaseRecord1),
		typeof(BaseClass1),
		typeof(BaseClass2)
	};

	public void Apply(OpenApiSchema schema, SchemaFilterContext context) =>
		AbstractBaseTypes
			.Find(abstractType => abstractType == context.Type)?.Assembly.GetTypes()
			.Where(type => type.IsSubclassOf(context.Type))
			.ToList().ForEach(type =>
				schema.AnyOf.Add(context.SchemaGenerator.GenerateSchema(type, context.SchemaRepository))
			);
}
```

and then at Startup:

```csharp
...
builder.Services
	.AddEndpointsApiExplorer()
	.AddSwaggerGen(options =>
	{
		options.ConfigureSwagger(builder.Configuration).EnableAnnotations();
		options.SchemaGeneratorOptions.SupportNonNullableReferenceTypes = true;
		options.SchemaFilter<SwaggerFilter>(); // 👈
	})
...
```

// TODO: Take shots of the open api docs 
