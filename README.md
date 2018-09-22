Write stdin to stdout and file in Windows Console.
> 1. Download [exe file](https://github.com/winp/extra-tee/releases/download/1.0.0/etee.exe).
> 2. Copy to `C:\Program_Files\Scripts`.
> 3. Add `C:\Program_Files\Scripts` to `PATH` environment variable.


```batch
> etee [--append|-a] [<output file>]

:: [] -> optional argument
:: <> -> argument value
```

```batch
:: view chapter 1 verse 1 of Bhagvad Gita
> etee < gita\c1\v1.txt

:: view chapter 1 verse 1 and save to c1.txt
> type gita\c1\v1.txt | etee gita\c1.txt

:: view chapter 1 verse 2 and append to c1.txt
> type gita\c1\v2.txt | etee --append gita\c1.txt
```


[![Merferry](https://i.imgur.com/6HVu894.jpg)](https://merferry.github.io)
