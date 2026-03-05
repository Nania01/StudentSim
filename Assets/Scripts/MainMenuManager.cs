using UnityEngine;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    public GameObject mainMenuRoot;
    public GameObject newGameRoot;
    public GameObject nameEntryPopup;
    public TMP_InputField nameInputField;

    public void OpenNewGameMenu()
    {
        mainMenuRoot.SetActive(false);
        newGameRoot.SetActive(true);
    }

    public void BackToMainMenu()
    {
        mainMenuRoot.SetActive(true);
        newGameRoot.SetActive(false);
    }

    public void OpenNameEntry()
    {
        nameEntryPopup.SetActive(true);
    }

    public void CloseNameEntry()
    {
        nameEntryPopup.SetActive(false);
        nameInputField.text = "";
    }

    public void ConfirmCreation()
    {
        string playerName = nameInputField.text;
        if (!string.IsNullOrEmpty(playerName))
        {
            Debug.Log("Студент " + playerName + " готов к учебе!");
        }
    }

    public void ExitGame()
    {
        Debug.Log("Выход...");
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
