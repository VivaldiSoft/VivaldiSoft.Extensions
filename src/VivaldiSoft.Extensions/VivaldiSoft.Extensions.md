<a name='assembly'></a>
# VivaldiSoft.Extensions

## Contents

- [ArrayExtensions](#T-VivaldiSoft-Extensions-ArrayExtensions 'VivaldiSoft.Extensions.ArrayExtensions')
  - [ArrayEqual\`\`1(first,second)](#M-VivaldiSoft-Extensions-ArrayExtensions-ArrayEqual``1-``0[],``0[]- 'VivaldiSoft.Extensions.ArrayExtensions.ArrayEqual``1(``0[],``0[])')
  - [Combine\`\`1(first,second)](#M-VivaldiSoft-Extensions-ArrayExtensions-Combine``1-``0[],``0[]- 'VivaldiSoft.Extensions.ArrayExtensions.Combine``1(``0[],``0[])')
  - [SetAllValues\`\`1(array,value)](#M-VivaldiSoft-Extensions-ArrayExtensions-SetAllValues``1-``0[],``0- 'VivaldiSoft.Extensions.ArrayExtensions.SetAllValues``1(``0[],``0)')
  - [SplitByNumberOfDivisions\`\`1(array,numberOfDivisions)](#M-VivaldiSoft-Extensions-ArrayExtensions-SplitByNumberOfDivisions``1-``0[],System-Int32- 'VivaldiSoft.Extensions.ArrayExtensions.SplitByNumberOfDivisions``1(``0[],System.Int32)')
  - [SplitByNumberOfElementsInDivision\`\`1(array,elementsInDivision)](#M-VivaldiSoft-Extensions-ArrayExtensions-SplitByNumberOfElementsInDivision``1-``0[],System-Int32- 'VivaldiSoft.Extensions.ArrayExtensions.SplitByNumberOfElementsInDivision``1(``0[],System.Int32)')
  - [SubArray\`\`1(array,index,length)](#M-VivaldiSoft-Extensions-ArrayExtensions-SubArray``1-``0[],System-Int32,System-Int32- 'VivaldiSoft.Extensions.ArrayExtensions.SubArray``1(``0[],System.Int32,System.Int32)')
- [Base64Extensions](#T-VivaldiSoft-Extensions-Base64Extensions 'VivaldiSoft.Extensions.Base64Extensions')
  - [Base64Decode(base64EncodedData)](#M-VivaldiSoft-Extensions-Base64Extensions-Base64Decode-System-String- 'VivaldiSoft.Extensions.Base64Extensions.Base64Decode(System.String)')
  - [Base64Encode(plainText)](#M-VivaldiSoft-Extensions-Base64Extensions-Base64Encode-System-String- 'VivaldiSoft.Extensions.Base64Extensions.Base64Encode(System.String)')
- [ByteExtensions](#T-VivaldiSoft-Extensions-ByteExtensions 'VivaldiSoft.Extensions.ByteExtensions')
  - [BytesToHexa(bytes,separator)](#M-VivaldiSoft-Extensions-ByteExtensions-BytesToHexa-System-Byte[],System-String- 'VivaldiSoft.Extensions.ByteExtensions.BytesToHexa(System.Byte[],System.String)')
  - [BytesToString(bytes)](#M-VivaldiSoft-Extensions-ByteExtensions-BytesToString-System-Byte[]- 'VivaldiSoft.Extensions.ByteExtensions.BytesToString(System.Byte[])')
  - [HexaToBytes(value,separator)](#M-VivaldiSoft-Extensions-ByteExtensions-HexaToBytes-System-String,System-String- 'VivaldiSoft.Extensions.ByteExtensions.HexaToBytes(System.String,System.String)')
  - [StringToBytes(value)](#M-VivaldiSoft-Extensions-ByteExtensions-StringToBytes-System-String- 'VivaldiSoft.Extensions.ByteExtensions.StringToBytes(System.String)')
- [DataTableExtensions](#T-VivaldiSoft-Extensions-DataTableExtensions 'VivaldiSoft.Extensions.DataTableExtensions')
  - [ToHtmlTable(dataTable,tableCssClasses)](#M-VivaldiSoft-Extensions-DataTableExtensions-ToHtmlTable-System-Data-DataTable,VivaldiSoft-Extensions-DataTableExtensions-TableCssClasses- 'VivaldiSoft.Extensions.DataTableExtensions.ToHtmlTable(System.Data.DataTable,VivaldiSoft.Extensions.DataTableExtensions.TableCssClasses)')
- [DateTimeExtensions](#T-VivaldiSoft-Extensions-DateTimeExtensions 'VivaldiSoft.Extensions.DateTimeExtensions')
  - [DateTimeToUnixTimeStamp(date)](#M-VivaldiSoft-Extensions-DateTimeExtensions-DateTimeToUnixTimeStamp-System-DateTime- 'VivaldiSoft.Extensions.DateTimeExtensions.DateTimeToUnixTimeStamp(System.DateTime)')
  - [UnixTimeStampToDateTime(unixTimestamp)](#M-VivaldiSoft-Extensions-DateTimeExtensions-UnixTimeStampToDateTime-System-Int64- 'VivaldiSoft.Extensions.DateTimeExtensions.UnixTimeStampToDateTime(System.Int64)')
- [IntegerExtensions](#T-VivaldiSoft-Extensions-IntegerExtensions 'VivaldiSoft.Extensions.IntegerExtensions')
  - [RoundNumber(value,step)](#M-VivaldiSoft-Extensions-IntegerExtensions-RoundNumber-System-Double,System-Int32- 'VivaldiSoft.Extensions.IntegerExtensions.RoundNumber(System.Double,System.Int32)')
  - [RoundNumber(value,step,min,max)](#M-VivaldiSoft-Extensions-IntegerExtensions-RoundNumber-System-Double,System-Int32,System-Int32,System-Int32- 'VivaldiSoft.Extensions.IntegerExtensions.RoundNumber(System.Double,System.Int32,System.Int32,System.Int32)')
- [ListExtensions](#T-VivaldiSoft-Extensions-ListExtensions 'VivaldiSoft.Extensions.ListExtensions')
  - [IndexOfMax\`\`1(values)](#M-VivaldiSoft-Extensions-ListExtensions-IndexOfMax``1-System-Collections-Generic-IList{``0}- 'VivaldiSoft.Extensions.ListExtensions.IndexOfMax``1(System.Collections.Generic.IList{``0})')
  - [IndexOfMin\`\`1(values)](#M-VivaldiSoft-Extensions-ListExtensions-IndexOfMin``1-System-Collections-Generic-IList{``0}- 'VivaldiSoft.Extensions.ListExtensions.IndexOfMin``1(System.Collections.Generic.IList{``0})')
  - [IsSame\`\`1(first,second)](#M-VivaldiSoft-Extensions-ListExtensions-IsSame``1-System-Collections-Generic-IList{``0},System-Collections-Generic-IList{``0}- 'VivaldiSoft.Extensions.ListExtensions.IsSame``1(System.Collections.Generic.IList{``0},System.Collections.Generic.IList{``0})')
  - [Median(values)](#M-VivaldiSoft-Extensions-ListExtensions-Median-System-Collections-Generic-IEnumerable{System-Double}- 'VivaldiSoft.Extensions.ListExtensions.Median(System.Collections.Generic.IEnumerable{System.Double})')
  - [Shuffle\`\`1(values)](#M-VivaldiSoft-Extensions-ListExtensions-Shuffle``1-System-Collections-Generic-IList{``0}- 'VivaldiSoft.Extensions.ListExtensions.Shuffle``1(System.Collections.Generic.IList{``0})')
- [StringExtensions](#T-VivaldiSoft-Extensions-StringExtensions 'VivaldiSoft.Extensions.StringExtensions')
  - [Left(str,length)](#M-VivaldiSoft-Extensions-StringExtensions-Left-System-String,System-Int32- 'VivaldiSoft.Extensions.StringExtensions.Left(System.String,System.Int32)')
  - [Mid(str,startIndex,length)](#M-VivaldiSoft-Extensions-StringExtensions-Mid-System-String,System-Int32,System-Int32- 'VivaldiSoft.Extensions.StringExtensions.Mid(System.String,System.Int32,System.Int32)')
  - [Right(str,length)](#M-VivaldiSoft-Extensions-StringExtensions-Right-System-String,System-Int32- 'VivaldiSoft.Extensions.StringExtensions.Right(System.String,System.Int32)')
  - [TrimNonPrintableAscii(value)](#M-VivaldiSoft-Extensions-StringExtensions-TrimNonPrintableAscii-System-String- 'VivaldiSoft.Extensions.StringExtensions.TrimNonPrintableAscii(System.String)')
- [TableCssClasses](#T-VivaldiSoft-Extensions-DataTableExtensions-TableCssClasses 'VivaldiSoft.Extensions.DataTableExtensions.TableCssClasses')

<a name='T-VivaldiSoft-Extensions-ArrayExtensions'></a>
## ArrayExtensions `type`

##### Namespace

VivaldiSoft.Extensions

##### Summary

A static class of extension methods for [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

<a name='M-VivaldiSoft-Extensions-ArrayExtensions-ArrayEqual``1-``0[],``0[]-'></a>
### ArrayEqual\`\`1(first,second) `method`

##### Summary

Checks if the Arrays are equal.

##### Returns

Returns `true`if all element match and `false`otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [\`\`0[]](#T-``0[] '``0[]') | The [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array')that contains data to compare with. |
| second | [\`\`0[]](#T-``0[] '``0[]') | The [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array')that contains data to compare to. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Array type. |

##### Example

```csharp
var first= new double[] { 0, 0, 0, 0, 0 };
var second = new double[] { 0, 0, 0, 0, 0 };
var result = first.ArrayEqual(second);
/*
result is true
*/ 
```

<a name='M-VivaldiSoft-Extensions-ArrayExtensions-Combine``1-``0[],``0[]-'></a>
### Combine\`\`1(first,second) `method`

##### Summary

Combine the Arrays.

##### Returns

T[].

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [\`\`0[]](#T-``0[] '``0[]') | First element to combine. |
| second | [\`\`0[]](#T-``0[] '``0[]') | Second element to combine. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Array type. |

##### Example

```csharp
var first= new double[] { 0, 1, 2 };
var second = new double[] { 3, 4, 5 };
var result = first.Combine(second);
/*
result contains the values { 0, 1, 2, 3, 4, 5 }
*/ 
```

<a name='M-VivaldiSoft-Extensions-ArrayExtensions-SetAllValues``1-``0[],``0-'></a>
### SetAllValues\`\`1(array,value) `method`

##### Summary

Sets all values.

##### Returns

A reference to the changed array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based array. |
| value | [\`\`0](#T-``0 '``0') | The value. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array that will be modified. |

##### Example

```csharp
var array = new double[] { 0, 0, 0, 0, 0 };
var result = array.SetAllValues(1);
/*
result contains the values { 1, 1, 1, 1, 1 }
*/ 
```

<a name='M-VivaldiSoft-Extensions-ArrayExtensions-SplitByNumberOfDivisions``1-``0[],System-Int32-'></a>
### SplitByNumberOfDivisions\`\`1(array,numberOfDivisions) `method`

##### Summary

Split an array into subarrays by specifying the number of divisions.

##### Returns

Subarrays.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | Array to split. |
| numberOfDivisions | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of divisions. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array that will be split. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.DivideByZeroException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DivideByZeroException 'System.DivideByZeroException') | Number of divisions is zero. |

##### Example

```csharp
var array = new double[] { 0, 1, 2 };
var numberOfDivisions = 2;
var result = array.SplitByNumberOfDivisions(numberOfDivisions);
/*
result contains the values { { 0, 1 }, { 2 } }
*/ 
```

<a name='M-VivaldiSoft-Extensions-ArrayExtensions-SplitByNumberOfElementsInDivision``1-``0[],System-Int32-'></a>
### SplitByNumberOfElementsInDivision\`\`1(array,elementsInDivision) `method`

##### Summary

Split an array into subarrays by specifying the number of elements in each division.

##### Returns

Subarrays.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | Array to split. |
| elementsInDivision | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Elements in each division. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array that will be split. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.DivideByZeroException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DivideByZeroException 'System.DivideByZeroException') | Number of elements in division is zero. |

##### Example

```csharp
var array = new double[] { 0, 1, 2 };
var elementsInDivision = 2;
var result = array.SplitByNumberOfElementsInDivision(elementsInDivision);
/*
result contains the values { { 0, 1 }, { 2 } }
*/ 
```

<a name='M-VivaldiSoft-Extensions-ArrayExtensions-SubArray``1-``0[],System-Int32,System-Int32-'></a>
### SubArray\`\`1(array,index,length) `method`

##### Summary

Subs the array.

##### Returns

T[].

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The data. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array that will be modified. |

##### Example

```csharp
var array = new double[] { 0, 1, 2, 3, 4, 5 };
var index = 1;
var length = 4;
var result = array.SubArray(index, length);
/*
result contains the values { 1, 2, 3, 4 }
*/ 
```

<a name='T-VivaldiSoft-Extensions-Base64Extensions'></a>
## Base64Extensions `type`

##### Namespace

VivaldiSoft.Extensions

##### Summary

A static class of methods for Base64 strings.

<a name='M-VivaldiSoft-Extensions-Base64Extensions-Base64Decode-System-String-'></a>
### Base64Decode(base64EncodedData) `method`

##### Summary

Converts the specified string, which encodes binary data as base-64 digits, to an equivalent plain text string.

##### Returns

Plain text string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| base64EncodedData | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String encoded with base-64 digits. |

##### Example

```csharp
var value = "MDEyMzQ1Njc4OQ==";
var result = value.Base64Decode();
/*
result is "0123456789"
*/ 
```

<a name='M-VivaldiSoft-Extensions-Base64Extensions-Base64Encode-System-String-'></a>
### Base64Encode(plainText) `method`

##### Summary

Converts the value of a plain text string to its equivalent string representation that is encoded with base-64 digits.

##### Returns

String encoded with base-64 digits.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| plainText | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Plain text string. |

##### Example

```csharp
var value = "0123456789";
var result = value.Base64Encode();
/*
result is "MDEyMzQ1Njc4OQ=="
*/ 
```

<a name='T-VivaldiSoft-Extensions-ByteExtensions'></a>
## ByteExtensions `type`

##### Namespace

VivaldiSoft.Extensions

##### Summary

A static class of extension methods for [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte')[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

<a name='M-VivaldiSoft-Extensions-ByteExtensions-BytesToHexa-System-Byte[],System-String-'></a>
### BytesToHexa(bytes,separator) `method`

##### Summary

Converts the numeric value of a byte array to its equivalent hexadecimal string.

##### Returns

Hexadecimal string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | The value. |
| separator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Hexadecimal values separator. |

##### Example

```csharp
var array = new byte[] { 48, 49, 50, 51, 52 };
var separator = "-";
var result = array.BytesToHexa(separator);
/*
result is "30-31-32-33-34"
*/ 
```

<a name='M-VivaldiSoft-Extensions-ByteExtensions-BytesToString-System-Byte[]-'></a>
### BytesToString(bytes) `method`

##### Summary

Decodes a sequence of bytes from the specified byte array into a string.

##### Returns

A string that contains the results of decoding the specified sequence of bytes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | The byte array containing the sequence of bytes to decode. |

##### Example

```csharp
var array = new byte[] { 48, 49, 50, 51, 52 };
var result = array.BytesToString();
/*
result is "01234"
*/ 
```

##### Remarks

Equivalent to System.Text.Encoding.UTF8.GetString().

<a name='M-VivaldiSoft-Extensions-ByteExtensions-HexaToBytes-System-String,System-String-'></a>
### HexaToBytes(value,separator) `method`

##### Summary

Converts the hexadecimal string to its quivalent numeric value byte array.

##### Returns

Byte array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value. |
| separator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Hexadecimal values separator. |

##### Example

```csharp
var value = "30-31-32-33-34";
var separator = "-";
var result = value.HexaToBytes(separator);
/*
result contains the values { 48, 49, 50, 51, 52 }
*/ 
```

<a name='M-VivaldiSoft-Extensions-ByteExtensions-StringToBytes-System-String-'></a>
### StringToBytes(value) `method`

##### Summary

Encodes a set of characters into a sequence of bytes.

##### Returns

A byte array containing the results of encoding the specified set of characters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The character array containing the characters to encode. |

##### Example

```csharp
var value = "01234";
var result = value.StringToBytes();
/*
result contains the values { 48, 49, 50, 51, 52 }
*/ 
```

##### Remarks

Equivalent to System.Text.Encoding.UTF8.GetBytes().

<a name='T-VivaldiSoft-Extensions-DataTableExtensions'></a>
## DataTableExtensions `type`

##### Namespace

VivaldiSoft.Extensions

##### Summary

A static class of extension methods for [DataTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.DataTable 'System.Data.DataTable').

<a name='M-VivaldiSoft-Extensions-DataTableExtensions-ToHtmlTable-System-Data-DataTable,VivaldiSoft-Extensions-DataTableExtensions-TableCssClasses-'></a>
### ToHtmlTable(dataTable,tableCssClasses) `method`

##### Summary

Convert a DataTable to the equivalent HTML table.

##### Returns

HTML table.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataTable | [System.Data.DataTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.DataTable 'System.Data.DataTable') | DataTable to convert. |
| tableCssClasses | [VivaldiSoft.Extensions.DataTableExtensions.TableCssClasses](#T-VivaldiSoft-Extensions-DataTableExtensions-TableCssClasses 'VivaldiSoft.Extensions.DataTableExtensions.TableCssClasses') | Optional parameter. CSS classes. |

##### Example

```csharp
DataTable table = new DataTable(new DataTableExtensions.TableCssClasses()
{
    Table = "class-table",
    Tr = "class-tr-1 class-tr-2",
    Th = "class-th",
    Td = "class-td",
});
// populate table
var result = table.ToHtmlTable(); 
```

<a name='T-VivaldiSoft-Extensions-DateTimeExtensions'></a>
## DateTimeExtensions `type`

##### Namespace

VivaldiSoft.Extensions

##### Summary

A static class of extension methods for [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime').

<a name='M-VivaldiSoft-Extensions-DateTimeExtensions-DateTimeToUnixTimeStamp-System-DateTime-'></a>
### DateTimeToUnixTimeStamp(date) `method`

##### Summary

Converts DateTime to unix time stamp.

##### Returns

The unix time stamp.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The DateTime. |

##### Example

```csharp
DateTime date = DateTime.Parse("02/16/2008 12:15:12", new CultureInfo("en-US"));
var result = date.DateTimeToUnixTimeStamp();
/*
result is 1203164112
*/ 
```

<a name='M-VivaldiSoft-Extensions-DateTimeExtensions-UnixTimeStampToDateTime-System-Int64-'></a>
### UnixTimeStampToDateTime(unixTimestamp) `method`

##### Summary

Converts unix time stamp to DateTime.

##### Returns

The DateTime.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| unixTimestamp | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The unix time stamp. |

##### Example

```csharp
long unixTimestamp = 1203164112;
var result = unixTimestamp.UnixTimeStampToDateTime().ToString("MM/dd/yyyy HH:mm:ss");
/*
result is 02/16/2008 12:15:12
*/ 
```

<a name='T-VivaldiSoft-Extensions-IntegerExtensions'></a>
## IntegerExtensions `type`

##### Namespace

VivaldiSoft.Extensions

##### Summary

A static class of extension methods for [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32').

<a name='M-VivaldiSoft-Extensions-IntegerExtensions-RoundNumber-System-Double,System-Int32-'></a>
### RoundNumber(value,step) `method`

##### Summary

Rounds a value to the nearest integer with the given step.

##### Returns

The number nearest to value that is multiple of the given step.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | A double-precision floating-point number to be rounded. |
| step | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Step number to round. |

##### Example

```csharp
double value = 12;
int step = 5;
var result = value.RoundNumber(step);
/*
result is 10
*/ 
```

<a name='M-VivaldiSoft-Extensions-IntegerExtensions-RoundNumber-System-Double,System-Int32,System-Int32,System-Int32-'></a>
### RoundNumber(value,step,min,max) `method`

##### Summary

Rounds a value to the nearest integer with the given step and within the determined range.

##### Returns

The number nearest to value that is multiple of the given step and within the determined range.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | A double-precision floating-point number to be rounded. |
| step | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Step number to round. |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Minimum value. |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Maximum value. |

##### Example

```csharp
double value = 12;
int step = 5;
int min = 0;
int max = 20;
var result = value.RoundNumber(step, min, max);
/*
result is 10
*/ 
```

<a name='T-VivaldiSoft-Extensions-ListExtensions'></a>
## ListExtensions `type`

##### Namespace

VivaldiSoft.Extensions

##### Summary

A static class of extension methods for [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1').

<a name='M-VivaldiSoft-Extensions-ListExtensions-IndexOfMax``1-System-Collections-Generic-IList{``0}-'></a>
### IndexOfMax\`\`1(values) `method`

##### Summary

Find the index of the maximum value of the list.

##### Returns

Index of the maximum value of the list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | The list of elements. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the list. |

##### Example

```csharp
var values = new double[] { 10, 11, 12, 13, 12, 11, 10 };
var result = values.IndexOfMax();
/*
result is 3
*/ 
```

<a name='M-VivaldiSoft-Extensions-ListExtensions-IndexOfMin``1-System-Collections-Generic-IList{``0}-'></a>
### IndexOfMin\`\`1(values) `method`

##### Summary

Find the index of the minimum value of the list.

##### Returns

Index of the minimum value of the list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | The list of elements. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the list. |

##### Example

```csharp
var values = new double[] { 13, 12, 11, 10, 11, 12, 13 };
var result = values.IndexOfMin();
/*
result is 3
*/ 
```

<a name='M-VivaldiSoft-Extensions-ListExtensions-IsSame``1-System-Collections-Generic-IList{``0},System-Collections-Generic-IList{``0}-'></a>
### IsSame\`\`1(first,second) `method`

##### Summary

Determine if two sequences contains exactly the same elements.

##### Returns

True if two sequences contains exactly the same elements, false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | The first list of elements. |
| second | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | The second list of elements. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the list. |

##### Example

```csharp
var first = new double[] { 0, 1 };
var second = new double[] { 1, 0 };
var result = first.IsSame(second);
/*
result is true
*/ 
```

<a name='M-VivaldiSoft-Extensions-ListExtensions-Median-System-Collections-Generic-IEnumerable{System-Double}-'></a>
### Median(values) `method`

##### Summary

Gets the value of the middle element of the list after sorted.

##### Returns

Index of the middle element.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Collections.Generic.IEnumerable{System.Double}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Double}') | The list of elements. |

##### Example

```csharp
var values = new double[] { 2, 3, 5, 1, 4 };
var result = values.Median();
/*
result is 3
*/ 
```

<a name='M-VivaldiSoft-Extensions-ListExtensions-Shuffle``1-System-Collections-Generic-IList{``0}-'></a>
### Shuffle\`\`1(values) `method`

##### Summary

Shuffle the elements of the list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | The list of elements. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the list. |

##### Example

```csharp
var values = new double[] { 0, 1, 2, 3, 4, 5 };
values.Shuffle(); 
```

<a name='T-VivaldiSoft-Extensions-StringExtensions'></a>
## StringExtensions `type`

##### Namespace

VivaldiSoft.Extensions

##### Summary

A static class of extension methods for [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

<a name='M-VivaldiSoft-Extensions-StringExtensions-Left-System-String,System-Int32-'></a>
### Left(str,length) `method`

##### Summary

Returns a string containing a specified number of characters from the left side of a string.

##### Returns

Returns a string containing a specified number of characters from the left side of a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String expression from which the leftmost characters are returned. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Numeric expression indicating how many characters to return. |

##### Example

```csharp
var value = "abcdefghij";
var length = 5;
var result = value.Left(length);
/*
result is "abcde"
*/ 
```

<a name='M-VivaldiSoft-Extensions-StringExtensions-Mid-System-String,System-Int32,System-Int32-'></a>
### Mid(str,startIndex,length) `method`

##### Summary

Returns a string that contains a specified number of characters starting from a specified position in a string.

##### Returns

A string that consists of the specified number of characters starting from the specified position in the string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String expression from which characters are returned. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Starting position of the characters to return. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of characters to return. |

##### Example

```csharp
var value = "abcdefghij";
var startIndex = 3;
var length = 5;
var result = value.Mid(startIndex, length);
/*
result is "defgh"
*/ 
```

<a name='M-VivaldiSoft-Extensions-StringExtensions-Right-System-String,System-Int32-'></a>
### Right(str,length) `method`

##### Summary

Returns a string containing a specified number of characters from the right side of a string.

##### Returns

Returns a string containing a specified number of characters from the right side of a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String expression from which the rightmost characters are returned. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Numeric expression indicating how many characters to return. |

##### Example

```csharp
var value = "abcdefghij";
var length = 5;
var result = value.Right(length);
/*
result is "fghij"
*/ 
```

<a name='M-VivaldiSoft-Extensions-StringExtensions-TrimNonPrintableAscii-System-String-'></a>
### TrimNonPrintableAscii(value) `method`

##### Summary

Returns a string without the non-printable ASCII characters from a string (characters between space and tilde).

##### Returns

A string without the non-printable ASCII characters from a string (characters between space and tilde).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String to remove the non-printable ASCII characters. |

##### Example

```csharp
var value = (char)0x12 + " a~";
var result = value.TrimNonPrintableAscii();
/*
result is " a~"
*/ 
```

<a name='T-VivaldiSoft-Extensions-DataTableExtensions-TableCssClasses'></a>
## TableCssClasses `type`

##### Namespace

VivaldiSoft.Extensions.DataTableExtensions

##### Summary

CSS classes.
