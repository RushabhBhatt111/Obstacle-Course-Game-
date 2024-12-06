using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5.0f;
    void Start()
    {
        MyFirstMethod();
    }

    void Update()
    {
         MovePlayer();
    }

    void MyFirstMethod()
    {
        Debug.Log("This is where i Define the method");
        Debug.Log("Use Arrow keys to move");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(xValue,yValue,zValue);
    }
}
