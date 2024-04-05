using System.Reflection;
using ValidationAttributes.Models;

namespace ValidationAttributes.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class MyRequiredAttribute : MyValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value == null)
        {
            return false;
        }
        return true;
    }
}