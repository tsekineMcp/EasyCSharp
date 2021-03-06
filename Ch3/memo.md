# Learning C\# memo

## 型変換

- 暗黙
- キャスト　`()` で指定 `(int) a` など
- as演算子
- is 演算子

### それぞれの挙動

- 暗黙　int からlongなど、メモリ容量の大きいものへの変換は単純に代入すればよい。
```cs
int a = 5;
long b = a;
```

キャスト
```cs
long a = 0;
int b = (int)a;
```

**キャストによって変換できない場合は例外エラーが出る**

as演算子

```cs
object x = "abc";
string s = x as string;
```

参照型だけに使用できる。
型変換に失敗してもエラーは発生しないが、null値を変換結果として返す。
（参照型だけに使用できる理由は、null値をとれるのが基本的には参照型だけなので。）

is 演算子

左オペランドが右オペランドで指定した型に**キャストできるかどうか**を示す値を返す。


### Parseメソッド、TryParseメソッド

```cs
string s = "12345";

int i = int.Parse(s);
int j = 0;
if (int.TryParse(s, out j)) // out は結果をjに格納するキーワード
{
    // code
}
```

- Parse: 指定された値が変換できない場合、例外エラーが発生する。
- TryParse: 変換できなくても結果を返すのみで例外エラーを出さない。


