namespace _01.Stealer
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fieldsNames)
        {
            var sb = new StringBuilder();
            var targetType = Type.GetType(className);

            sb.AppendLine($"Class under investigation: {targetType}");

            var classInstance = Activator.CreateInstance(targetType);

            var fields = targetType.GetFields(BindingFlags.Instance | BindingFlags.Static |
                BindingFlags.Public | BindingFlags.NonPublic);

            foreach (var field in fields.Where(f => fieldsNames.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().Trim();
        }

        public string AnalyzeAcessModifiers(string className)
        {
            var sb = new StringBuilder();
            var targetType = Type.GetType(className);

            var wrongFields = targetType.GetFields(BindingFlags.Instance | BindingFlags.Static |
                BindingFlags.Public);

            foreach (var field in wrongFields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            var pulbicMethods = targetType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            var nonpulbicMethods = targetType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var method in nonpulbicMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }

            foreach (var method in pulbicMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }

            return sb.ToString().Trim();
        }

        public string RevealPrivateMethods(string className)
        {
            var targetType = Type.GetType(className);
            var sb = new StringBuilder();
            sb.AppendLine($"All Private Methods of Class: {targetType}");

            var baseType = targetType.BaseType;
            sb.AppendLine($"Base Class: {baseType.Name}");

            var privateMethods = targetType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (var method in privateMethods)
            {
                sb.AppendLine(method.Name);
            }

            return sb.ToString().Trim();
        }

        public string CollectGettersAndSetters(string className)
        {
            var targetType = Type.GetType(className);
            var methods = targetType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            var sb = new StringBuilder();

            foreach (var method in methods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }

            foreach (var method in methods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return sb.ToString().Trim();
        }
    }
}
