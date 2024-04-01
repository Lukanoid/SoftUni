using System.Reflection;
using System.Text;

namespace Stealer;

public class Spy
{
    public string StealFieldInfo(string className, params string[] fieldsToInvestigate)
    {
        Type type = Type.GetType(className);
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Class under investigation: {className}");
        FieldInfo[] fields = type.GetFields((BindingFlags)60);

        Object classInstance = Activator.CreateInstance(type, new object[] { });

        foreach (FieldInfo field in fields.Where(f => fieldsToInvestigate.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return sb.ToString().TrimEnd();
    }

    public string AnalyzeAccessModifiers(string className)
    {
        StringBuilder sb = new StringBuilder();

        Type type = Type.GetType("Stealer." + className);

        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
        MethodInfo[] publicMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
        MethodInfo[] privateMethods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var field in fields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }

        foreach (var publicMethod in publicMethods.Where(m => m.Name.StartsWith("set")))
        {
            sb.AppendLine($"{publicMethod.Name} have to be private!");
        }

        foreach (var publicMethod in publicMethods.Where(m => m.Name.StartsWith("get")))
        {
            sb.AppendLine($"{publicMethod.Name} have to be public!");
        }

        return sb.ToString().TrimEnd();
    }

    public string RevealPrivateMethods(string className)
    {
        Type type = Type.GetType(className);

        StringBuilder sb = new StringBuilder();

        MethodInfo[] methodsInfo = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

        sb.AppendLine($"All Private Methods of Class: {type.FullName}");
        sb.AppendLine($"Base Class: {type.BaseType.Name}");

        foreach (var method in methodsInfo)
        {
            sb.AppendLine($"{method.Name}");
        }

        return sb.ToString().TrimEnd();
    }

    public string CollectGettersAndSetters(string className)
    {
        Type type = Type.GetType(className);

        StringBuilder sb = new StringBuilder();

        MethodInfo[] methods = type.GetMethods((BindingFlags)60);

        foreach (var method in methods.Where(x=>x.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} will return {method.ReturnType}");
        }

        foreach (var method in methods.Where(x => x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
        }

        return sb.ToString().TrimEnd();
    }
}