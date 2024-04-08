using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object1 : MonoBehaviour, InteractableUI // This allows the Object script to call to the InteractableUI script
{
    [SerializeField] private string prompt;
    public string InteractionPromt => prompt;

    public bool Interact(Interactor interactor)
    {
        // This line of code will check the player for a money amount Var inventory = interactor.GetComponent<Inventory>();

        //if (inventory == null) return false;
        Debug.Log("Opening Chest!");
        return true;
    }
}

