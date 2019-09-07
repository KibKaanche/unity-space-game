using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public Transform Bullet;
    public Transform CannonPosition;
    public int Score;
    public Text ScoreText;
    public Text TimeText; //How to fix?
    public Slider HealthBar; //How to decrease by 5% with collision?


    void Start()
    {
        
        
    }

    void Update(){

        ScoreText.text = "Marcador: " + Score;
       
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        gameObject.transform.Translate(new Vector3(h, v, 0));

        if (Input.GetKeyDown(KeyCode.Space)) {
            Shoot();
        }
    }

    void Shoot() {
        Instantiate(Bullet, CannonPosition.position, Quaternion.identity);
    }
}
