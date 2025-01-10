using System.ComponentModel.DataAnnotations.Schema;

namespace Cases.ConvertCase;

[AttributeUsage(AttributeTargets.Property)]
public class SnakeCaseColumnAttribute : ColumnAttribute
{
    public SnakeCaseColumnAttribute(string name) 
        : base(name.SnakeCaseConvert())
    { }
}
