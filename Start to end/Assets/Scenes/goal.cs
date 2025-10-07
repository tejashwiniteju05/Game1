using System.Collections;
using UnityEngine;

public class CapsuleWallReset : MonoBehaviour
{
    public Transform startPoint;   // Drag the start point here in Inspector

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("walls"))
        {
            StartCoroutine(RestartAfterHit(collision.gameObject));
        }
    }

    IEnumerator RestartAfterHit(GameObject wall)
    {
        Renderer rend = wall.GetComponent<Renderer>();
        Color originalColor = rend.material.color;

        // Turn wall red
        rend.material.color = Color.red;

        // Wait 1 second
        yield return new WaitForSeconds(0.5f);

        // Reset capsule position
        transform.position = startPoint.position;
        GetComponent<Rigidbody>().velocity = Vector3.zero;

        // Restore wall color
        rend.material.color = originalColor;
    }
}
