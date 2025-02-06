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
        if (Value == 0)
        {
            // This will cause an exception if Value is accessed before it's set
            // because it will be assigned to the default value of 0 for the int variable which will lead to infinite loop
            Value = DoSomethingElse();
        }
        else
        {
            //some code here
        }
    }

    private int DoSomethingElse()
    {
        return Value + 1; //Potential StackOverflowException
    }
}