using UnityEngine;

public class mapBorders : MonoBehaviour
{
    public Transform basketBallRespawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered this trigger has the "basketball" tag.
        if (other.CompareTag("basketball"))
        {
            // 'other' is the Collider of the ball that hit the border.
            // We can get its Transform and Rigidbody directly from it.

            // 1. Move the ball that hit the trigger to the respawn position.
            other.transform.position = basketBallRespawn.position;

            // 2. Get the ball's Rigidbody to stop its movement.
            Rigidbody ballRigidbody = other.GetComponent<Rigidbody>();

            // 3. Always check if the component exists before trying to use it.
            if (ballRigidbody != null)
            {
                ballRigidbody.linearVelocity = Vector3.zero;
                ballRigidbody.angularVelocity = Vector3.zero;
            }
        }
    }
}
