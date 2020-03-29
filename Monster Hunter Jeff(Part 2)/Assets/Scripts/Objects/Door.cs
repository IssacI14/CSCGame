using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DoorType
{
    key,
    enemy,
    button
}

public class Door : Interactable
{
    [Header("Door variables")]
    public DoorType thisDoorType;
    public bool open = false;
    public Inventory playerInventory;
    public SpriteRenderer doorSprite;
    public BoxCollider2D physicsCollider;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (playerInRange && thisDoorType == DoorType.key)
            {
                //Does the play have a key?
                if(playerInventory.numberOfKeys > 0)
                {
                    //Remove a player key
                    playerInventory.numberOfKeys--;
                    //If so then call the open method
                    Open();
                }
            }
        }
    }

    public void Open()
    {
        //Turn off the doors sprite renderer
        doorSprite.enabled = false;
        //Set open to true
        open = true;
        //Turn off the doors box collider
        physicsCollider.enabled = false;
    }

    public void CLose()
    {

    }
}
