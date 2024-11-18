using System.Reflection;

public class Program
{
    public static void Main()
    {
        // Get the path of the current directory (where the executable is running)
        var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        // Construct the relative path to the DLL
        var dllPath = Path.Combine(baseDirectory, "Ag.Biosecurity.ImportServices.Model.dll"); // Update with the actual folder and file name

        // Load the assembly from the relative path
        var assembly = Assembly.LoadFrom(dllPath);

        var types = assembly.GetTypes();


        var filteredTypes = types.Where(t => t.FullName.StartsWith("Ag.Biosecurity.ImportServices.Model")); // Specify the actual namespace

        var dataDictionary = new List<DictionaryEntry>();

        foreach (var type in filteredTypes)
        {
            foreach (var property in GetAllProperties(type))
            {
                var entry = new DictionaryEntry
                {
                    ClassName = type.Name,
                    PropertyName = property.Name,
                    DataType = GetDataType(property),
                    Description = GetDescription(property) // Custom method to extract description, if available
                };
                dataDictionary.Add(entry);
            }
        }

        ExportToCsv(dataDictionary, "DataDictionary.csv");
    }

    public static IEnumerable<PropertyInfo> GetAllProperties(Type type)
    {
        // Retrieve all properties including inherited properties
        var properties = new List<PropertyInfo>();
        while (type != null && type != typeof(object))
        {
            properties.AddRange(type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            type = type.BaseType;
        }
        return properties;
    }

    public static string GetDescription(PropertyInfo property)
    {
        // Optionally retrieve description using attributes or custom annotations
        var attribute = property.GetCustomAttribute<System.ComponentModel.DescriptionAttribute>();
        return attribute?.Description ?? "No description available";
    }

    public static string GetDataType(PropertyInfo property)
    {
        if (property.PropertyType.Name.StartsWith("List"))
        {
            if (property.PropertyType.GenericTypeArguments[0].Name.StartsWith("Reference"))
            {
                return $"List<Reference<{property.PropertyType.GenericTypeArguments[0].GenericTypeArguments[0].Name}>>";
            }
            return $"List<{property.PropertyType.GenericTypeArguments[0].FullName.Split('.').Last()}>";
        }
        if (property.PropertyType.Name.StartsWith("Reference"))
        {
            return $"Reference<{property.PropertyType.FullName.Split(',').First().Split('.').Last()}>";
        }
        else if (property.PropertyType.Name.StartsWith("Nullable"))
        {
            return $"{property.PropertyType.GenericTypeArguments[0].Name} (nullable)";
        }
        else
            return property.PropertyType.Name;
    }

    public static void ExportToCsv(List<DictionaryEntry> dataDictionary, string filePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            writer.WriteLine("ObjectName,PropertyName,DataType,Description");
            foreach (var entry in dataDictionary)
            {
                writer.WriteLine($"{entry.ClassName},{entry.PropertyName},{entry.DataType},{entry.Description}");
            }
        }
    }

    public class DictionaryEntry
    {
        public string ClassName { get; set; }
        public string PropertyName { get; set; }
        public string DataType { get; set; }
        public string Description { get; set; }
    }
}
