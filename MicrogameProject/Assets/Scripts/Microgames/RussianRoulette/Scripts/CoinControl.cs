using UnityEngine;

public class CoinControl : MonoBehaviour
{
    public GameObject Coin;
    public int CoinResult;
    public RussianRouletteControl russianRouletteControl;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void FlipCoin()
    {
        CoinResult = Random.Range(0, 2);  
        if (CoinResult == 0)
        {
            Coin.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
            russianRouletteControl.turnOrder = 1;
            russianRouletteControl.state = RevolverState.JFirst;
            Debug.Log("Jimothy Starts");
        }
        else if (CoinResult == 1)
        {
            Coin.GetComponent<Renderer>().material.color = new Color(0, 0, 255);
            russianRouletteControl.turnOrder = 2;
            russianRouletteControl.state = RevolverState.PFirst;
            Debug.Log("Player Starts");
        }


    }
}
