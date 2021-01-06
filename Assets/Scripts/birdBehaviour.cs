using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class birdBehaviour : MonoBehaviour
{
    Vector3 _initialPosition;
    private bool _birdWasLaunched;
    [SerializeField]
    private float _timeSittingAround;
    [SerializeField]
    private float _launchPower = 500;

    public void Awake()
    {
        _initialPosition = transform.position;
    }

    public void Update()
    {
        if (_birdWasLaunched && 
            GetComponent<Rigidbody2D>().velocity.magnitude <= 0.1)
        {
            _timeSittingAround += Time.deltaTime;
        }

        if (transform.position.y > 10 ||
            transform.position.y < -8.40 ||
            transform.position.x > 14.40 ||
            transform.position.x < -14.40 ||
            _timeSittingAround > 3)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }

    public void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }
    public void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
        Vector2 directionToInitialPosition = _initialPosition - transform.position;
        GetComponent<Rigidbody2D>().AddForce(directionToInitialPosition * _launchPower);
        GetComponent<Rigidbody2D>().gravityScale = 1;
        _birdWasLaunched = true;
    }

    private void OnMouseDrag()
    {
        Vector3 newposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newposition.x, newposition.y);
    }
}
