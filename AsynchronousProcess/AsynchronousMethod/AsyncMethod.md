# Asynchronous methods

## What is async method?

Strinctly saying, async methods can just execute async processings, actually, we need to implement async processing in method.

## Syntax

```csharp
async void Sleep(int second)
{
// processings
}
```

## Limits of async method

Compared to usual methods, it is incapable to use `ref` or `out` keywords 
when declaring arguments of async methods.
It is capable to specify `void`, `Task`, `Task<TResult>`, `ValueTask<TResult>` as return values.

It should be noted, `ValueTask` type needs `System.Threading.Tasks` extentions.

Sample code