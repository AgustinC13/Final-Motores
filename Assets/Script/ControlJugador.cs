using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ControlJugador : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    Rigidbody2D bird;

    int score = 0;

    bool dead = false;

    void Start()
    {
        bird = transform.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown("space") && !dead)
        {
            bird.velocity = new Vector2(0, 6.5f);
        }
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }

        if (score == 10)
        {
            SceneManager.LoadScene("Victoria");
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("Derrota");
    }

    private void OnCollisionEnter2D()
    {
        dead = true;
        score = 0;
        scoreText.text = "Puntos: 0";
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "PointTrigger")
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
}
