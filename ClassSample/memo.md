# Class syntax

## インスタンス

```csharp
型名 変数名 = new 型名([引数リスト]);
```

でインスタンスを生成。

## プロパティ

オブジェクトが保持する情報を取得したり、設定したりするさいに、
変数のように使用できる。

構文は以下の通り

```csharp
[keyword] Type propertyName
{
    get
    {
        // 値が取得されるときの処理
        return hoge
    }

    set
    {
        // 値が設定されるときの処理
        hoge = value // valueキーワードをつかう
    }
}

```

プロパティ内で、値のvalidationみたいなこともできる利点がある。

### Set Accessor in Detail

A code as below,

```csharp
// this code come from the official document
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-properties
class Person
{
    private string name;  // the name field
    public string Name    // the Name property
    {
        get
        {
            return name;
        }
        set
        {
            name = value; //下記のコード、"Joe"がvalueの該当する
        }
    }
}
```

When we assign a value to the proeperty, the set accessor is invoked by using an argument that provides the new value. For example,

```csharp
Person person = new Person();
person.Name = "Joe";  // the set accessor is invoked here

System.Console.Write(person.Name);  // the get accessor is invoked here
```


## Constructors

### Constructor syntax

```csharp
[keyword] ClassName ([arg list])
{
    // code...
}
```
> A constructor is a method whose name is the same as the name of its type.

というわけで、コンストラクタは、クラス名とメソッド名を同じにする。

実例は以下の通り。

```csharp
public class Person
{
   private string last;
   private string first;
   
   public Person(string lastName, string firstName) // クラス名と同じ
   {
      last = lastName;
      first = firstName;
   }
   
   // Remaining implementation of Person class.
}
```

**Destructor**

覚えなくていいが、constructorと同様、クラス名と同じメソッド名にするが、チルダを付ける。

```csharp
class Sample
{
    ~Sample()
    {
        Console.WriteLine("release memory");
    }
}
```