using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour, IPointerUpHandler
{
   
    public void OnPointerUp(PointerEventData eventData)
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }

}