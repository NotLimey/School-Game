using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    void OnMouseDown()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
