namespace DesignPatterns.Creational.Singleton;

public sealed class AppConfiguration
{
    // Thread-safe, lazy singleton
    private static readonly Lazy<AppConfiguration> _instance =
        new(() => new AppConfiguration());

    public static AppConfiguration Instance => _instance.Value;


    // Double-check locking
    //private static AppConfiguration? _instance;
    //private static readonly object _lock = new();
    //public static AppConfiguration Instance
    //{
    //    get
    //    {
    //        if (_instance is not null) return _instance;

    //        lock (_lock)
    //        {
    //            _instance ??= new AppConfiguration();
    //            return _instance;
    //        }
    //    }
    //}



    private readonly Dictionary<string, string> _values = new();

    // Prevent external construction
    private AppConfiguration()
    {
        LoadDefaults();
    }

    private void LoadDefaults()
    {
        // Simulate loading from env/file/db
        _values["Environment"] = "Production";
        _values["MaxItemsPerPage"] = "50";
        _values["EnableCaching"] = "true";
    }

    public string Get(string key)
    {
        if (!_values.TryGetValue(key, out var value))
            throw new InvalidOperationException($"Config key '{key}' not found.");

        return value;
    }

    // Intentionally no setters → configuration is read-only
    public IReadOnlyDictionary<string, string> Snapshot() => _values;
}