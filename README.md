## Synopsis

A very simple debugging utility for Xamarin.iOS apps that prints on console a list of opened files by the mobile application.

## Motivation

The latest XCode Instruments lack of File Activity tool to inspect opened file in iOS but only in Mac OS. This projects binds the framework generated [here](https://github.com/sanandrea/FileCounter) in a C# `.dll` that can be used directly in a Xamarin project.
I used the follwong [Guide](https://developer.xamarin.com/guides/cross-platform/macios/binding/objective-sharpie/platform-features/native-frameworks/) to create the binding.

## Installation

Open Project in Xamarin and build it. The output binary is under the `bin` folder.

## Code Example

Add library to a Xamarin.iOS app. Import dll in the source code file:

`using FileCounter.Xamarin;`

then use it in your code:

`FileCounter.Lsof()`

## Contributors

All credits to this awesome SO [answer](http://stackoverflow.com/a/8153026/1073786). Thank you [Rich Waters](http://stackoverflow.com/users/420100/rich-waters)!

## License

The MIT License (MIT)

Copyright (c) 2016 Andi Palo

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
