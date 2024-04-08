using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script will be used for creating our prompts (UI) that appear with all interatable objects
public interface InteractableUI
{
    public string InteractionPromt { get; }

    public bool Interact(Interactor interactor); //will return bool when an interactable object is hit
}

