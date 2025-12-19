using UnityEngine;

public class stickonplatform : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 
     private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")) {
            other.transform.parent = this.transform;
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")) {
            other.transform.parent = null;
        }
    }
    
        
}

