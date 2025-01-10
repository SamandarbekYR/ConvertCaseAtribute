using System.ComponentModel.DataAnnotations.Schema;

namespace Cases.ConvertCase;

[AttributeUsage(AttributeTargets.Property)]
public class UpperCaseColumnAttribute : ColumnAttribute
{
    public UpperCaseColumnAttribute(string name) 
        : base(name.UpperCaseConvert())
    { }
}
