using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other) 
    {
        switch (other.gameObject.tag)
        {
            case "Launch Pad":
                Debug.Log("Let's start!");
                break;
            case "Fuel":
                Debug.Log("Rocket was refueled");
                break;
            case "Finish":
                Debug.Log("Destination reached!");
                break;
            default:
                Debug.Log("You blew up!");
                break;
        }
    }
}
