using MicrogameCourse.Framework;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace MicrogameCourse.Microgames
{

public class ClawMachineGame : MicrogameBehaviour
{
    [SerializeField] private RectTransform playArea;
    public GameObject PlushieSingle;
    public GameObject PlushiePair;
    public GameObject PlushieTriple;
    public GameObject BigPlushie;
    public GameObject LegendaryPlushie;
    [SerializeField] private TextMeshProUGUI progressText;
    public int pointsRemaining = 5;

    public RCPlaneControl rCPlaneControl;
    public RingSpawnScript ringSpawnScript;

    public int pointsLeft;

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

            if (pointsLeft <= 0)
            Win();
        }
        
    public void UpdateProgress()
        {
            
            progressText.text = $"Points Left: {pointsLeft}";
        }

}
}
