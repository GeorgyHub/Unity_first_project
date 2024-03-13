using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMenu : MonoBehaviour
{
    public GameObject settings;
    public void New_Game() 
    {
        Application.LoadLevel(1);
    }

    public void Load_Game()
    {

    }
    public void Settings()
    {
        settings.SetActive(!settings.activeSelf);
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void SetMusic(float value)
    {
        Sound.music = value;
    }
    public void SetEffects(float value)
    {
        Sound.effects = value;
    }
}
