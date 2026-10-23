using MicrogameCourse.Framework;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace MicrogameCourse.Microgames
{

public class RCPlaneGame : MicrogameBehaviour
{
    [SerializeField] private RectTransform playArea;
    public GameObject RingLow;
    public GameObject RingMid;
    public GameObject RingHigh;
    [SerializeField] private TextMeshProUGUI progressText;
    [SerializeField, Min (1)] private int pointsRemaining = 5;

    public RCPlaneControl rCPlaneControl;
    public RingSpawnScript ringSpawnScript;

    private int pointsLeft;

    public override void Begin(MicrogameSession session)
        {
            base.Begin(session);
            pointsLeft = pointsRemaining;
            rCPlaneControl.GameOn = true;
            UpdateProgress();
            
        }

    public void RingsCollected()
        {
            if (!isRunning) return;
            
            pointsLeft--;
            UpdateProgress();

            if (pointsLeft == 0)
            Win();
        }
        
    private void UpdateProgress()
        {

            progressText.text = $"Points Left: {pointsLeft}";
        }

}
}
