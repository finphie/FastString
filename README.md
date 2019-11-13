# FastString

[![Build Status](https://github.com/finphie/FastString/workflows/build/badge.svg)](https://github.com/finphie/FastString/actions?query=workflow%3Abuild+branch%3Amaster)

.NET用の高速な文字列処理ライブラリです。

## 説明

FastStringは、.NET Core 3.0/.NET Standard 2.1用の文字列処理を高速化したライブラリです。

## インストール

（準備中）

## 使い方

```csharp
using FastStringUtility;

var str0 = "abc";
var str1 = "def";

// string.Concat(str0, str1);
string result = FastString.Concat(str0, str1);

// string.Join(',', str0, str1);
string result = FastString.Join(',', str0, str1);

// string.IsNullOrEmpty(str0);
bool result = FastString.IsNullOrEmpty(str0);

// string.IsNullOrWhiteSpace(str0);
bool result = FastString.IsNullOrWhiteSpace(str0);
```

```csharp
using System;
using FastStringUtility.Extensions;

var str0 = "abc";
var str1 = "def";

// str0.Insert(1, str1);
string result = str0.AsSpan().Insert(1, str1);
```

## 使用言語

- C# 8.0

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
