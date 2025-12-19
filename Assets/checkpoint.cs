using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public DeathScript deathScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            deathScript.currentCheckpoint = this.transform;
        }
    }
}
