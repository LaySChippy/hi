using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public Transform currentCheckpoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("AAAAAAAAAAA");
        if (other.CompareTag("Player"))
        {
            other.transform.position = currentCheckpoint.position;
            other.transform.rotation = Quaternion.identity;
        }
    }
}
