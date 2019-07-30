# NativeHotKeys

## Dedication / Recognition
This code was originally written by [Tom Shelton](http://tom-shelton.net/). Back in 2010.
All recognition and thanks goes to Tom for a great library. 

## About

__NativeHotKeys__ allows you to easily add 'HotKeys' to you application and monitor and react to those hotkeys even if you application is minimized. 

Syntax is very simple

```csharp
    HotKey hotKey = new HotKey();
    hotKey.RegisterHotkey(Modifiers.Ctrl | Modifiers.Shift, Keys.A);
    hotKey.HotKeyPressed += (o, e) =>
                {
                    // Do something
                };
    
```

