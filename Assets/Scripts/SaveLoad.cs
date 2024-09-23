using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoad : MonoBehaviour
{
    public string theText = null;
    public GameObject ourNote = null;
    public GameObject placeholder = null;
    public GameObject saveAnim = null;

    private void Start()
    {
        theText = PlayerPrefs.GetString("NoteContents");
        placeholder.GetComponent<InputField>().text = theText;
    }

    public void SaveNote()
    {
        theText = ourNote.GetComponent<Text>().text;
        PlayerPrefs.SetString("NoteContents", theText);
        StartCoroutine(SaveTextRoll());
    }

    IEnumerator SaveTextRoll()
    {
        saveAnim.GetComponent<Animator>().Play("SavedTextFade");
        yield return new WaitForSeconds(1);
        saveAnim.GetComponent<Animator>().Play("Idle");
    }
}
