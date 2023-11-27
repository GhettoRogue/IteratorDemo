namespace IteratorDemo;

public static class PropInfo
{
    public static IEnumerable<object> GetProperties(this object obj)
    {
        return obj
            .GetType()
            .GetProperties()
            .Select(prop => new
            {
                Name = prop.Name,
                Value = prop.GetValue(obj),
                Type = prop.PropertyType
            });
    }
}