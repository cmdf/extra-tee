# otee

Write stdin to stdout and file in Windows Console.


## usage

```batch
> otee [--append|-a] [<output file>]

:: [] -> optional argument
:: <> -> argument value
```

```batch
:: view chapter 1 verse 1 of Bhagvad Gita
> otee < gita\c1\v1.txt

:: view chapter 1 verse 1 and save to c1.txt
> type gita\c1\v1.txt | otee gita\c1.txt

:: view chapter 1 verse 2 and append to c1.txt
> type gita\c1\v2.txt | otee --append gita\c1.txt
```
