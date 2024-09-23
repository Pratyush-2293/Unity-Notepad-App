using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public GameObject theText = null;
    public GameObject thePanel = null;

    public void ClearText()
    {
        theText.GetComponent<InputField>().text = "";
    }

    public void CancelButton()
    {
        thePanel.gameObject.SetActive(false);
    }

    public void CloseButton()
    {
        thePanel.gameObject.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
