using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Pacman : MonoBehaviour
{
    private Vector3 dir;
    public float gravity = -9.8f;
    public float strength = 5f;

    private int score;

    public Text ScoreText;
    public AudioClip jump;
    public AudioClip scorePoint;

    public ChangeMedal obj;


    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<AudioSource>().clip = jump;
            GetComponent<AudioSource>().Play();
           dir = Vector3.up*strength;
        }

        dir.y += gravity * Time.deltaTime;
        transform.position += dir * Time.deltaTime;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene(2);
        }else if(collision.gameObject.tag == "Score")
        {
            GetComponent<AudioSource>().clip = scorePoint;
            GetComponent<AudioSource>().Play();
            score++;
            ScoreText.text = score.ToString();
            obj.Checkmedal(score);

        }
    }


}
