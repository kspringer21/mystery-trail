using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class MultipleChoice : MonoBehaviour
{
    public TMP_Text question;
    public TMP_Text correctText;
    public TMP_Text incorrectText;

    public GameObject[] answers;
    public GameObject next;
    public GameObject goBack;
    public int correctAnswer; 

    public void ChoiceOptionCorrect(){
        question.gameObject.SetActive(false);
        correctText.gameObject.SetActive(true);
        answers[0].SetActive(false);
        answers[1].SetActive(false);
        answers[2].SetActive(false);
        answers[3].SetActive(false);
        next.SetActive(true);
        Mapbox.Examples.SpawnPOIsOnMap.poiIndex += 1;
        RadialProgress.currentValue = RadialProgress.currentValue + (float)16.1667;
        Debug.Log(RadialProgress.currentValue);
    }

     public void ChoiceOptionIncorrect(){
        question.gameObject.SetActive(false);
        incorrectText.gameObject.SetActive(true);
        answers[0].SetActive(false);
        answers[1].SetActive(false);
        answers[2].SetActive(false);
        answers[3].SetActive(false);
        goBack.SetActive(true);
    }
    
    public void redisplayQuestion(){
        question.gameObject.SetActive(true);
        incorrectText.gameObject.SetActive(false);
        answers[0].SetActive(true);
        answers[1].SetActive(true);
        answers[2].SetActive(true);
        answers[3].SetActive(true);
        goBack.SetActive(false);

    }


}
