using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeManager : MonoBehaviour
{
    public static TimeSpan TimePlayed { get; set; }
    public static TimeSpan GameTime { get; set; }
    public static Image timeFilterScreen; //used to control the color of the sky
    public static TimeManager Instance;


    private void Start()
    {
        //DontDestroyOnLoad (this);
        timeFilterScreen = this.transform.GetChild(0).GetComponent<Image>();
        StartCoroutine(TimeStep());
        //timeFilterScreen.GetComponent<Image>().color = new Color((1f / 255f) * 8f, 0, (1f / 255f) * 32f, (1f / 255f) * 160f); //8, 0, 32, 160 rgba values - 8-10pm?
        //^^Default Test Values for Shadow Layer^^
    }

    private IEnumerator TimeStep()
    {
        while (this.enabled == true)
        {
            TimePlayed = TimePlayed.Add(new TimeSpan(0, 0, 1));
            GameTime = GameTime.Add(new TimeSpan(0, 0, 30));
            //timeFilterScreen.GetComponent<Image>().color = new Color((1f / 255f) * 8f, 0, (1f / 255f) * 32f, (1f / 255f) * (160f + GameTime.Minutes)); //8, 0, 32, 160 rgba values - 8-10pm?
            yield return new WaitForSeconds(1f);
        }
        yield return null;
    }

}