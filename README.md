# TypingEffectUnity
📜The script to reproduce the famous typing ✍️ effect most popular in video games 🎮 this script written in C sharp 🖥️ is oriented unity engine 🕹️
```C sharp
   foreach(var letter in dialogText[index].ToCharArray()){
                txtDialog.text+=letter;
                AudioTyping.Play();
                yield return new WaitForSeconds(timeDialog); 
       }
```
