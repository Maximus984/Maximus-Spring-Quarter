using UnityEngine;

public class pickup : MonoBehaviour
{
    // Step 1: Make our variables
    public float rotationSpeed = 5f;

    // Step 2: Detect collision with other objects
    private void OnTriggerEnter(Collider other)
    {
        // something has collided with the pick up
        // Step 3: Verify if a collision was the player
        PlayerController playerController = other.gameObject.GetComponent<PlayerController>();

        if (playerController != null) // If the player controller variable is not empty, we hit the player
        {
             // Step 4: Destory this pickup when touched by the player
            // Destroy this pickup
            Destroy(gameObject);
        }
    }

    private void Update() // Update is called once per frame
    {
        // Stepd 5: Make this pickup rotate every frame
        transform.Rotate(new Vector3(15, 15, 15) * rotationSpeed * Time.deltaTime);
    }
}