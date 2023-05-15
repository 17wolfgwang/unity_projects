using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other) {
        switch (other.gameObject.tag)
        {
            case "Friendly" :
                Debug.Log("Friendly");
                break;
            case "Finish" : 
                Debug.Log("done");
                break;
            case "Fuel" :
                Debug.Log("pick Fuel");
                break;
            default:
                ReloadLevel();
                break;
        }    
    }

    void ReloadLevel() {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
