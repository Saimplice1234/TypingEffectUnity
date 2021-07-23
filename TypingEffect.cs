using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TypingEffect : MonoBehaviour
{   
    public int index=0;
    public string[] dialogText;
    public float timeDialog;
    public Text txtDialog;
    private AudioSource AudioTyping;

    void Awake(){
        AudioTyping=GameObject.Find("Typing").GetComponent<AudioSource>();
    }
    void OnEnable(){
        startDialog();
    }
    void OnDisable(){
        txtDialog.text="";
    }
    
    public void startDialog(){
        StartCoroutine(showDialog());
    }

    IEnumerator showDialog(){
            
            foreach(var letter in dialogText[index].ToCharArray()){
                txtDialog.text+=letter;
                AudioTyping.Play();
                yield return new WaitForSeconds(timeDialog); 
            }
    }
}
