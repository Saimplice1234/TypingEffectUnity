# TypingEffectUnity
๐The script to reproduce the famous typing โ๏ธ effect most popular in video games ๐ฎ this script written in C sharp ๐ฅ๏ธ is oriented unity engine ๐น๏ธ
```C sharp
   foreach(var letter in dialogText[index].ToCharArray()){
                txtDialog.text+=letter;
                AudioTyping.Play();
                yield return new WaitForSeconds(timeDialog); 
       }
```
