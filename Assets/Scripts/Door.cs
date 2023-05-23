using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

public class Door : Interactive
{
    public string To;
    private string From;
    private Item Key { get; set; }
    //public Door From { get; set; } Not sure this is even necessary?
    public bool Locked;
    public Dictionary<string, Vector2> to;

    protected void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.GetComponent<Player>() != null)
        {
            if (Input.GetButtonDown("Button1"))
            {
                interact += OpenDoor;
                interact(collider.GetComponent<Player>());
            }
        }
    }
    private void OpenDoor(AbstractCharacter character)
    {
        if (Locked != true)
        {
            StartCoroutine(GameManager.FadeOut());
            Application.LoadLevel(To);
        }
        else if (character.Inventory.Contains(Key)) // || (character can pick lock)
        {
            //Animate door opening
            //save object data to map, send event to MapManager.Map
            //Fade out
            //Load new scene
        }
    }
}
