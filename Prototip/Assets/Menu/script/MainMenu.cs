﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public Slider sliderMusic;

	public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

		
    public void changeSliderMusic()
    {
        AudioListener.volume = sliderMusic.value;
    }


    public void QuitGame()
    {
        Debug.Log("Izlaz");
        Application.Quit();
    }
}
