using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    public void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        SceneManager.LoadScene("Level1");
    }
}
