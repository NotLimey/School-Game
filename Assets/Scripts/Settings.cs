using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        SceneManager.LoadScene("Settings");
    }
}
