using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DoorType{
    key,
    enemy,
    button
}

public class Door : Interactable
{
    [Header("Variable porte")]
    public DoorType thisDoorType;
    public bool open = false;
    public Inventory playerInventory;
    public SpriteRenderer doorSprite;
    public BoxCollider2D physicsCollider;

    
    public void Update(){
        if(Input.GetKeyDown(KeyCode.E)){
            if(playerInRange && thisDoorType == DoorType.key){
                //Joueur à une clé ? Si oui open 
                if(playerInventory.numberOfKeys > 0){
                    //enlever clé
                    playerInventory.numberOfKeys--;
                    Open();
                }
            }
        }
    } 

    public void Open(){
        //Sprite renderer off +  box collider off
        doorSprite.enabled = false;
        open = true;
        physicsCollider.enabled = false;
    }

    public void Close(){

    }
}
