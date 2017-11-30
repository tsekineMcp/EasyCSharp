# Access modifier

|keyword|accessible scope|
|:---|:---|
|public|no access limitation|
|private|from same class|
|protected|from same class or derived class|
|internal|from same class or same assembly (project)|
|internal protected|internal + derived class|

---
**public**

```csharp
public class Sample
{
    public Sample() {} // constructor
    public void Method() {} // method
    public int Property {get; set;} // property
}
```
---

**private**

```csharp
public class Sample
{
    private int Property{ get; set; }
    private void Method()
    {
        Property = 0;
    }
}
```

アクセサーのみを異なるアクセス修飾子で就職することもできる。

```csharp
public int Property{ get; private set;}
```
この場合、setアクセサーはクラス内部からのみ値を格納することができます。


コンストラクタの宣言をprivateにすることによって、インスタンスの生成ロジックをカプセル化することができます。

```csharp
class Program
{
    static void Main(string[] args)
    {
        // Sample a = new Sample();　こうだとコンパイルエラー

        Sample b = Sample.Method();　// このようにメソッドで呼び出す。
    }
}

public class Sample
{
    private Sample() {} // コンストラクタを非公開にする
    static public Sample Method()
    {
        return new Sample()
    }
}
```
---
**protected**

クラス内か、派生クラスからのみアクセス可能。

---
**internal**

同じプロジェクト内（アセンブリ内）でのみアクセスが可能。

---
**internal protected**

internalでありprotected（両特性）という修飾子
