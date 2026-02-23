using UnityEngine;

// HOW TO MAKE A C# VARIABLE
// Public/Private [Data Type] [Variable Name]
public class PlayerController : MonoBehaviour
{
    // Step 1: Create our variables
    public float moveSpeed = 5f;
    public Rigidbody rb;

    // Step 2: Assign/Initialize our variables
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    private void FixedUpdate()
    {
         // Step 3: Every frame, gather movement input from the player
        float xInput = Input.GetAxis("Horizontal"); // Left & Right Movement
        float zInput = Input.GetAxis("Vertical"); // Forward & Back

        Vector3 movement = new Vector3(xInput, 0, zInput); // The direction the player will move 

        // Step 4: Apply movement to the plauyer based on the player input
        rb.AddForce(movement * moveSpeed * Time.deltaTime, ForceMode.Impulse);
    }

   


}
