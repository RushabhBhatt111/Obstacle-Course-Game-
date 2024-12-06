using UnityEngine;

public class Spinny : MonoBehaviour
{
    [SerializeField] private float xAngle = 0f;
    [SerializeField] float yAngle = 2f;
    [SerializeField] private float zAngle = 0f;
    void Start()
    {
        
    }
    
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
