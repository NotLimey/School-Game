using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        SceneManager.LoadScene("Home");
    }
}
