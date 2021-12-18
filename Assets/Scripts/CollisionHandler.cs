using UnityEngine;
using UnityEngine.SceneManagement;

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
                ReloadLevel();
                break;
        }
    }

    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
