using Unity.VisualScripting;
using UnityEngine;

public class sigmaboy : MonoBehaviour
{

    [SerializeField] private float speed = 10;
    [SerializeField] private float maxDistance = 10;

    private Vector3 start_position;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        start_position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(maxDistance*Mathf.Sin(Time.time * speed) + (start_position.x+maxDistance), transform.position.y);
    }
}
