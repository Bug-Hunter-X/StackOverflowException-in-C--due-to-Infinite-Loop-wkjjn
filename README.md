# StackOverflowException in C#

This repository demonstrates a scenario where a StackOverflowException can occur in C# due to an infinite recursive loop triggered by accessing a property before it's initialized.

## Bug Description

The `DoSomething` method attempts to use the `Value` property before it's assigned a non-zero value.  If the initial value of `Value` is 0, the `DoSomethingElse` method is called recursively.  Because `DoSomethingElse` also tries to access `Value`, this leads to an infinite recursion, resulting in a `StackOverflowException`.

## Solution

The solution involves ensuring that `Value` is initialized before it's used within the recursive call, or by restructuring the logic to avoid recursion.  See `bugSolution.cs` for a fix.
