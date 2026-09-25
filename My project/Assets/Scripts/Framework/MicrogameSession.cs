using System;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
public sealed class MicrogameSession : MonoBehaviour
{
    private enum Phase {Ready, Playing, Results}
    [SerializeField] private MicrogameBehaviour game;
    [SerializeField] private GameObject readyPanel;
    [SerializeField] private GameObject resultsPanel;
    [SerializeField] private GameObject playArea;
    [SerializeField] private Text timerText;
    [SerializeField] private Text resultText;
    [SerializeField, Min(1f)] private float durationSeconds = 10f;

    private Phase currentPhase;
    private float remainingSeconds;
    private void Awake()
    {
        currentPhase = Phase.Ready;
        readyPanel.SetActive(true);
        playArea.SetActive(false);
        resultsPanel.SetActive(false);
        timerText.text = string.Empty;

    }

    public void StartGame()
    {
        if (currentPhase != Phase.Ready || game == null) return;

        remainingSeconds = durationSeconds;
        readyPanel.SetActive(false);
        playArea.SetActive(true);
        resultsPanel.SetActive(false);
        currentPhase = Phase.Playing;
        ShowTime();
    }

    private void Update()
    {
        if (currentPhase != Phase.Playing) return;
        remainingSeconds = MathF.Max(0F, remainingSeconds - Time.deltaTime);
        ShowTime();
        if (remainingSeconds <=0f) Finish(false);
    }

    public void Finish(bool won)
    {
        if (currentPhase != Phase.Playing) return;

        currentPhase = Phase.Results;
        game.End();
        playArea.SetActive(false);
        resultsPanel.SetActive(true);
        resultText.text = won ? "Winner!" : "Times Up!";
    }

    private void ShowTime()
    {
        timerText.text = $"Time : (remainingSeconds: 0.0)";
    }
}
