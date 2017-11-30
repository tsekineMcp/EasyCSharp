# About Generics

At first, we declare abstract data types called `type parameters`, and then when using `generic`, it enables to specify a data type.

```csharp
// usual declaration of variables
string Value;
```

In the case of usual variables, for example, variables declared as string can only store string values.
However, when using generic, we can specify data type, generic variables can store any type of values.

## Usage scene of generics

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
As you can see, `Value` property is declared using type paremeter `T`.

## Creation generic method

### What is generic method?

Generic method is a method, which uses type parameters.

The following example shows declaration of generic method.

```csharp
void Method<T1, T2>(T1 value1, T2 value2)
```

## Generic classes

Generic class is a class, which uses type parameters.
Operations such as adding and removing items from the collection and performed in basically the same way regardless of the type of data being stored.

```csharp
class Tuple<T1, T2>
```

The following example shows declaration of generic class:
```csharp
Tuple<string, int> t = new Tuple<string, int>();
```

New class is inherited from generic class:
```csharp
class InheritsClass<T> : BaseClass<T>
```

## Generic Interfaces

```csharp
interface ITuple<T1, T2>
```
2
```csharp
class Class : IInterface<string>
{
	public string Value {get; set;}
}

interface IInterface<T>
{
	T Value {get; set;}
}
```

As follows, generic classes are inherited with implements of generic interfaces.
```csharp
class Sample<T> : ISample<T>
{
	public T Value {get; set;}
}

interface ISample<T>
{
	T Value {get; set;}
}
```
