using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseScript : MonoBehaviour
{
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            gm.HitWall();
        }
        else if(collision.gameObject.tag == "Start")
        {
            gm.HitStart();
        }
        else if(collision.gameObject.tag == "Stop")
        {
            gm.HitStop();
        }
    }
}
