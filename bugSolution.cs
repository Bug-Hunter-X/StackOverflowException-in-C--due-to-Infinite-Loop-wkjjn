public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void DoSomething()
    {
        int currentValue = Value;
        if (currentValue == 0)
        {
            currentValue = DoSomethingElse();
            Value = currentValue; 
        }
        else
        {
            //some code here
        }
    }

    private int DoSomethingElse()
    {
        return Value + 1; 
    }
}