using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HurtPlayer : MonoBehaviour
{
    public float score = 0;
    public float health = 30;
    public GameObject Player;
    public GameObject Healthbar;
    public GameObject Score;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health -= 10;
            Player.transform.position = new Vector3(-25.0f, Player.transform.position.y, -25.0f);
            Debug.Log("sivsbv");
        }
    }

    private void Update()
    {

        if (health <= 0)
        {
            Destroy(Player);
            Debug.Log("End");
            Application.Quit();
        }

        score++;
        Score.GetComponent<Text>().text = "Score: " + score;
        Healthbar.GetComponent<Text>().text = "Health: " + health + "/30";
    }
}
