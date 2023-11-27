using System.Collections;

namespace IteratorDemo;

public class PropertyIterator : IEnumerable<(string name, object? value, Type type)>
{
    private readonly List<(string name, object? value, Type type)> _list;

    public PropertyIterator(object obj)
    {
        
        _list = obj
            .GetType()    
            .GetProperties()
            .Select(prop=> (prop.Name, prop.GetValue(obj), prop.PropertyType))
            .ToList();
    }
    
    public IEnumerator<(string name, object? value, Type type)> GetEnumerator()
    {
        return _list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}