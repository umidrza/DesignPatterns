namespace DesignPatterns.Behavioral.Interpreter;

public sealed class Context
{
    private readonly Dictionary<string, object> _values = new(StringComparer.OrdinalIgnoreCase);

    public void Set(string key, object value)
    {
        _values[key.Trim()] = value;
    }

    public T Get<T>(string key)
    {
        if (!_values.TryGetValue(key, out var value))
            throw new InvalidOperationException($"Key '{key}' not found in context.");

        return (T)Convert.ChangeType(value, typeof(T));
    }
}