using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitCount = 0;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hitCount++;
        }
        
        //Debug.Log("You Bumped into a thing this many times: " + hitCount);
    }
}
