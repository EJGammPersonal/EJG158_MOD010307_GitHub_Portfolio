using MicrogameCourse.Framework;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace MicrogameCourse.Microgames
{

public sealed class RCPlaneControl : MicrogameBehaviour
{
    [SerializeField] private RectTransform playArea;
    [SerializeField] private RectTransform target;
    [SerializeField] private TextMeshProUGUI progressText;

    public float power = 15f;
    public float maxSpeed = 15f;
    public float UpForce = 15f;

    private void Awake()
        {
            currentPhase = Phase.Ready;
            readyPanel.SetActive(true);
            playArea.SetActive(false);
            resultsPanel.SetActive(false);
            timerText.text = string.Empty;
        }

    private void Update()
        {
            
        }

}