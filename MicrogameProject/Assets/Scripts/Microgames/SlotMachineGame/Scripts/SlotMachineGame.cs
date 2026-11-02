using MicrogameCourse.Framework;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace MicrogameCourse.Microgames
{

public class SlotMachineGame : MicrogameBehaviour
{
    [SerializeField] private RectTransform playArea;
    
    [SerializeField] private TextMeshProUGUI progressText;
    public int pointsRemaining = 5;
    public int pointsLeft;

    public SlotMachine SlotMachine;

    public override void Begin(MicrogameSession session)
        {
            base.Begin(session);
            pointsLeft = pointsRemaining;
            SlotMachine.GameOn = true;
            UpdateProgress();
            
        }

    public void tokensLeft()
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
