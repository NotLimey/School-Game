using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        SceneManager.LoadScene("Levels");
    }

    public void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
