using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MultipleChoice : MonoBehaviour
{
    public string question;
    public string[] answers;
    public int correctAnswer; 

    enum State { Question, TryAgain, Close };
    State state = State.Question;

    void OnGUI()
    {
        switch (state) {
            case State.Question:
                DoQuestion();
                break;
            case State.TryAgain:
                DoTryAgain();
                break;
            case State.Close:
                DoClose();
                break;
        }
    }
    
    void DoQuestion()
    {
        GUILayout.Label(question);
        for (int i = 0; i &lt; answers.Length; ++i) {
            if (GUILayout.Button(answers[i])) {
                if (i == correctAnswer) {
                    state = State.Close;
                } else {
                    state = State.TryAgain;
                }
            }
        }
    }

    void DoTryAgain()
    {
        GUILayout.Label("Wrong answer.");
        if (GUILayout.Button("Press to try again...")) {
            state = State.Question;
        }
    }

    void DoClose()
    {
        GUILayout.Label("Correct!");
        if (GUILayout.Button("Close")) {
            // Whatever you want to do here (e.g. call Application.Quit()).
        }
    }

}
