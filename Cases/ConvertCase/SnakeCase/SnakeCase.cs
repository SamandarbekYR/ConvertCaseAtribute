using System.Text;

namespace Cases.ConvertCase;

public static class SnakeCase
{
    public static string SnakeCaseConvert(this string name)
    {
        if (string.IsNullOrEmpty(name))
            return string.Empty;

        var result = new StringBuilder();
        result.Append(char.ToLower(name[0]));

        for (int i = 1; i < name.Length; i++)
        {
            if (char.IsUpper(name[i]))
            {
                result.Append('_');
                result.Append(char.ToLower(name[i]));
            }
            else
            {
                result.Append(name[i]);
            }
        }

        return result.ToString();
    }
}
