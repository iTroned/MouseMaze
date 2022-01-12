using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Runtime.InteropServices;



public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI attemptsTXT;
    public TextMeshProUGUI timeTXT;

    private int attempts = 0;
    private float time = 0f;
    private bool mazeStarted = false;

  
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        attemptsTXT.color = Color.black;
        timeTXT.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            QuitApp();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }
        if (mazeStarted)
        {
            time += Time.deltaTime;
        }
        attemptsTXT.text = "Attempts: " + attempts.ToString();
        timeTXT.text = "Time: " + time.ToString("F1");

    }

    public void QuitApp()
    {
        Application.Quit();
    }

    public void Restart()
    {
        mazeStarted = false;
        time = 0f;
        attempts = 0;
    }

    public void HitWall()
    {
        if (mazeStarted)
        {
            attempts++;
            mazeStarted = false;
            attemptsTXT.color = Color.red;
        }
        
    }
    public void HitStart()
    {
        if (!mazeStarted)
        {
            mazeStarted = true;
            attemptsTXT.color = Color.black;
            time = 0f;
        }
        
    }
    public void HitStop()
    {
        if (mazeStarted)
        {
            mazeStarted = false;
            attemptsTXT.color = Color.green;
        }
    }
    

}
