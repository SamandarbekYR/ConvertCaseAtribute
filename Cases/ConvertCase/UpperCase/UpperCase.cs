using System.Text;

namespace Cases.ConvertCase;

public static class UpperCase
{
    public static string UpperCaseConvert(this string name)
    {
        if (string.IsNullOrEmpty(name))
            return string.Empty;

        var result = new StringBuilder();
        result.Append(char.ToUpper((name[0])));

        for (int i = 1; i < name.Length; i++)
        {
            if (char.IsUpper(name[i]))
            {
                result.Append('_');
            }

            result.Append(char.ToUpper(name[i]));
        }

        return result.ToString();
    }
}