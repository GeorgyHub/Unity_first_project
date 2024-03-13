using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UI;

public class DayNight : MonoBehaviour
{
    public Text _gameTime;
    public Transform direcrionalLight;
    public float fullDay = 120f;
    [Range(0, 1)] public float currentTime;

    private float h, m;
    private string hour, min;

    void Start()
    {
        _gameTime.text = "00:00";
    }

    // Update is called once per frame
    void Update()
    {
        TimeCount();

        currentTime += Time.deltaTime / fullDay;

        if (currentTime >= 1) currentTime = 0; else if (currentTime < 0) currentTime = 0;

        direcrionalLight.localRotation = Quaternion.Euler((currentTime * 360f) - 90, 170, 0);
    }

    void TimeCount() 
    {
        h = 24 * currentTime;
        m = 60 * (h - Mathf.Floor(h));

        if (m < 10) min = "0" + (int)m; else min = ((int)m).ToString();
        if (h < 10) hour = "0" + (int)h; else hour = ((int)h).ToString();

        _gameTime.text = hour + ":" + min;
    }
}
