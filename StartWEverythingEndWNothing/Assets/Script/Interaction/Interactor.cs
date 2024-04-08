using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Interactor : MonoBehaviour
{
    [SerializeField] private Transform interactionPoint;
    [SerializeField] private float interactionPointRadius;
    [SerializeField] private LayerMask interactableMask;//This creates a variable that allows you to choose what layer this script interacts with meaning if you pick a different layer than an object within your game it will not be interactable
    [SerializeField] private InteractionPromptUI interactionPromptUI;

    private readonly Collider[] colliders = new Collider[3];
    [SerializeField] private int numFound;

    private InteractableUI interactable;

    private void Update()
    {
        //This will add to the colliders array eachtime the player collides with another abject with the max number of objects set currently to 3
        numFound = Physics.OverlapSphereNonAlloc(interactionPoint.position, interactionPointRadius, colliders,
            (int)interactableMask);

        if (numFound > 0)
        {
            var interactable = colliders[0].GetComponent<InteractableUI>(); // this creates a variable that will equal the first collider in the collider array carrying the monobehavior InteractableUI

            if (interactable != null)
            {
                if (!interactionPromptUI.IsDisplayed) interactionPromptUI.SetUp(interactable.InteractionPromt);
            }
        }
        else
        {
            if (interactable != null) interactable = null;
            if (interactionPromptUI.IsDisplayed) interactionPromptUI.Close();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(interactionPoint.position, interactionPointRadius); //This allows us to see our interaction point within unity
    }
}

