using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        SceneManager.LoadScene("Home");
    }
}

