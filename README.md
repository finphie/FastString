# FastString

.NET用の高速な文字列処理ライブラリです。

## 説明

FastStringは、.NET Core 3.0/.NET Standard 2.1, 2.0用の文字列処理を高速化したライブラリです。

## インストール

（準備中）

## 使い方

```csharp
using FastStringUtility;

var str0 = "abc";
var str1 = "def";

// abcdef
var concat = FastString.Concat(str0, str1);

// abc,def
var join = FastString.Join(',', str0, str1);
```

## 使用言語

- C# 7.3

## 開発環境

- Visual Studio 2019
- Visual Studio Code

## 作者

finphie

## ライセンス

MIT

## クレジット

このプロジェクトでは、下記のライブラリを使用しています。

### ライブラリ

- System.Runtime.CompilerServices.Unsafe  
<https://www.nuget.org/packages/System.Runtime.CompilerServices.Unsafe/>  
© Microsoft Corporation
