using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private int timeToWait = 3;
    private MeshRenderer meshRend;
    Rigidbody rb;

    void Start()
    {
        meshRend = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Time.time >= timeToWait)
        {
            meshRend.enabled = true;
            rb.useGravity = true;
            //Debug.Log("Lookout Below!");
        }
        
    }
}
