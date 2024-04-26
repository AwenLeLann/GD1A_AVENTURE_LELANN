using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContexteClue : MonoBehaviour
{
    public GameObject contexteClue;
    public bool contextActive = false;
    public void ChangeContext(){
        contextActive = !contextActive;
        if(contextActive){
            contexteClue.SetActive(true);
        }else{
            contexteClue.SetActive(false);
        }
    }
    
    
    
}
