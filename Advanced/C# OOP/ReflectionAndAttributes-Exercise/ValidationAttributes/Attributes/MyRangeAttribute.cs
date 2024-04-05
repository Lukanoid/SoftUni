namespace ValidationAttributes.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class MyRangeAttribute : MyValidationAttribute
{
    private int minValue;
    private int maxValue;

    public MyRangeAttribute(int minValue, int maxValue) 
    {
        this.minValue = minValue;
        this.maxValue = maxValue;
    }

    public override bool IsValid(object value)
    {
        if(value == null) return false;

        if ((int)value >= minValue && (int)value <= maxValue)
        {
            return true;
        }

        return false;
    }
}