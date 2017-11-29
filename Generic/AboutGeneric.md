# About Generic

At first, we declare abstract data types called `type parameters`, and then when using `generic`, it enables to specify a data type.

```csharp
// usual declaration of variables
string Value;
```

In the case of usual variables, for example, variables declared as string can only store string values.
However, when using generic, we can specify data type, generic variables can store any type of values.

## Usage scene of generic

Generic is useful when executing method or class which process commonly at multiple data types.


Example: Value property in the StockString can store string value only as following.

```csharp
class StockString
{
	public string Value {get ; set ;}
}
```

Therefore, when would like to store multiple data types such as int or bool, we need to declare class for every data types, as following.

```csharp
class StockInt
{
	public int Value {get; set;}
}
class StockBool
{
	public bool Value {get; set;}
}
```

As following, you can see that generic makes the code shorter.
```csharp
class Stock<T>
{
	public T Value {get; set;}
}
```
As you can see, `Value` property is declared using type paremeter `T`

