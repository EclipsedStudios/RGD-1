using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Movement Controls
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        // Interaction Controls
        if (Input.GetButtonDown("Interact") || Input.GetKeyDown(KeyCode.Space))
        {
            // Left mouse button click or spacebar press for interaction
            Interact();
        }
    }

    void Interact()
    {
        // Interaction logic
        Debug.Log("Action");
    }
}

