using System.Reflection;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Models;

public static class Validator
{
    public static bool IsValid(object obj)
    {
        Type type = obj.GetType();

        PropertyInfo[] properties = type.GetProperties();

        foreach (var property in properties)
        {
            object value = property.GetValue(obj);

            var attributes = property.GetCustomAttributes<MyValidationAttribute>(inherit: true);

            foreach (var attribute in attributes)
            {
                if (!attribute.IsValid(value))
                {
                    return false;
                }
            }
        }

        return true;
    }
}