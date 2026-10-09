using MicrogameCourse.Framework;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace MicrogameCourse.Microgames
{

public sealed class RCPlaneGame : MicrogameBehaviour
{
    [SerializeField] private RectTransform playArea;
    [SerializeField] private RectTransform target;
    [SerializeField] private TextMeshProUGUI progressText;
    [SerializeField, Min (1)] private int ringsRemaining = 5;
    private int ringsLeft;

    public override void Begin(MicrogameSession session)
        {
            base.Begin(session);
            ringsLeft = ringsRemaining;
            UpdateProgress();
            
        }

    public void ringsCollected()
        {
            if (!isRunning) return;

            ringsLeft--;
            UpdateProgress();

            if (ringsLeft == 0)
            Win();
        }
        
    private void UpdateProgress()
        {
            progressText.text = $"Rings Left: {ringsLeft}";
        }
    

}
}
