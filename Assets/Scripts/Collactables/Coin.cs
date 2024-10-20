using UnityEngine;

public class Coin : MonoBehaviour
{
    [Tooltip("The amount of score this coin is worth")]
    public int scoreValue = 300;

    // When the player collides with the coin
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Add score to the GameManager
            GameManager.AddScore(scoreValue);
            Debug.Log("collided");
            // Destroy the coin
            Destroy(gameObject);
        }
    }
}
