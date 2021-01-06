using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    public void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        SceneManager.LoadScene("Level2");
    }
}

