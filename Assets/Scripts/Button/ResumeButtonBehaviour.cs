using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeButtonBehaviour: MonoBehaviour
{
    public void OnResumeButtonPressed()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<MovementComponent>().Pause();
    }
}
