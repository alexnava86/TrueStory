using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System;

public class GameManager : MonoBehaviour
{
    #region Variables
    public bool debugMode;
    private List<string> errorLog = new List<string>();
    private static Text debugModeText;
    private static Canvas gameUI;
    private static Image screen;
    //private static bool debugMode;
    //Singleton
    public static GameManager Instance { get; private set; }
    #endregion

    #region Properties
    public bool DebugMode
    {
        get
        {
            return debugMode;
        }
    }
    #endregion

    #region MonoBehaviour
    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
        gameUI = Resources.Load("Prefabs/Interface/GameUI", typeof(Canvas)) as Canvas;
        debugModeText = gameUI.transform.GetChild(1).GetComponent<Text>();
        screen = gameUI.transform.GetChild(0).GetComponent<Image>();
        //Debug.Log(debugModeText.text);
        StartCoroutine(GameManager.FadeIn());
    }
    private void Start()
    {
        if (DebugMode != true)
        {
            debugModeText.text = "DebugMode=OFF";
        }
        else
        {
            debugModeText.text = "DebugMode=ON";
        }
    }
    private void Update()
    {
        //debugModeText.text = "Time Played:" + TimeManager.TimePlayed.ToString () + debugModeText.text;
    }
    private void OnEnable()
    {
        MapManager.OnMessage += DebugMessage;
    }
    private void OnDisable()
    {
        MapManager.OnMessage -= DebugMessage;
    }
    #endregion

    #region Methods
    //
    public static void StartNewGame()
    {
        //TimeManager.Instance.enabled = true;
    }
    public static void ContinueGame()
    {

    }
    public static void LoadGame() // Opens the load game menu...
    {

    }
    public static void SaveGame() //Opens the save game menu...
    {

    }
    public static void DeleteSave()
    {

    }
    public static void LoadGameFrom(int saveslot)
    {

    }
    public static void SaveGameTo(int saveslot)
    {

    }
    public static void DeleteSaveData(int saveslot)
    {

    }
    public static void CheckForSaveData(int saveslot)
    {

    }
    public static void PauseGame()
    {
        //Time.timeScale = 0;
    }
    public static void GameOver()
    {

    }
    public static void QuitGame()
    {

    }
    public static void RestoreAllGameSettingsToDefault()
    {

    }
    public static void DisplayHUD()
    {

    }
    public static void HideHUD()
    {

    }

    public void DebugMessage(string message)
    {
        debugModeText.text = message + "\n" + debugModeText.text;
    }
    #endregion

    #region Coroutines
    public static IEnumerator FadeIn()
    {
        while (screen.color.a > 0f)
        {
            screen.color = new Color(0f, 0f, 0f, screen.color.a - 0.025f);
            yield return null;
        }

        yield return null;
    }
    public static IEnumerator FadeOut()
    {
        while (screen.color.a < 1f)
        {
            screen.color = new Color(0f, 0f, 0f, screen.color.a + 0.025f);
            yield return null;
        }
        yield return null;
    }
    public static IEnumerator GenerateDialogue(AbstractCharacter character)
    {
        yield return null;
    }
    #endregion
}