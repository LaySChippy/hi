using System.Runtime.Serialization;
using System.Collections;
using UnityEngine;

public class movingplatform : MonoBehaviour
{
    [SerializeField] private GameObject pointA;
    [SerializeField] private GameObject pointB;
    [SerializeField] private float speed = 2f;
    [SerializeField] private float delay = 1f;
    [SerializeField] GameObject platform;
    private Vector3 targetPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       platform.transform.position = pointA.transform.position;
       targetPosition = pointB.transform.position;
       StartCoroutine(MovePlatform()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator MovePlatform()
    {
        while (true)
        {
            while (Vector3.Distance(platform.transform.position, targetPosition) > 0.1f)
            {
                platform.transform.position = Vector3.MoveTowards(platform.transform.position, targetPosition, speed * Time.deltaTime);
                yield return null;
            }
            yield return new WaitForSeconds(delay);
            targetPosition = targetPosition == pointA.transform.position ? pointB.transform.position : pointA.transform.position;
        }
    }
}
