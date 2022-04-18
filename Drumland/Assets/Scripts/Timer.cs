using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
 * Autor: Gala Flores García 
 * Crea el temporizador en cuenta regresiva del nivel 1
 */
public class Timer : MonoBehaviour
{
    [SerializeField]
    private int minutes;

    [SerializeField]
    private int seconds;

    [SerializeField]
    private Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void startTimer()
    {
        writeTimer(minutes, seconds);
        Invoke ("UpdateTimer", 1f);
    }

    public void stopTimer()
    {

    }

    private void writeTimer(int minutes, int seconds)
    {
        if (seconds < 10)
        {
            timerText.text = minutes.ToString() + ":00" + seconds.ToString();
        }
        else
        {
            timerText.text = minutes.ToString() + ":" + seconds.ToString();
        }
    }

    // Update is called once per frame
    private void UpdateTimer()
    {
        if (seconds < 0)
        {
            if (minutes == 0)
            {
                //termina el juego
            } else
            {
                seconds = 59;
            }
        }

        writeTimer(minutes, seconds);
        Invoke("UpdateTimer", 1f);
    }

}
