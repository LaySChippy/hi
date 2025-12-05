using UnityEngine;

public class camerabehaviour : MonoBehaviour
{
    [SerializeField] private GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.transform.position;
        Transform new_position = new Vector3()
        transform.position = target.transform.position;
    }
}
