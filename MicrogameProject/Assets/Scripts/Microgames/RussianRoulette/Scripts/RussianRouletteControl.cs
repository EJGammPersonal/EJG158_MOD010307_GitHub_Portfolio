using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

using UnityEngine.UI;
public enum RevolverState {Loading, PFirst, JFirst, PlayerTurn, JimothyTurn, PlayerShooting, JimothyShooting, Victory, Dead}

public class RussianRouletteControl : MonoBehaviour
{
    public GameObject revolver;
    public GameObject Jimothy;
    public GameObject bullet;
    public RevolverState state;
    public bool CoinFlipped = false;
    public int BulletChamber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI GameMaster;
    public CoinControl coinControl;
    public int turnOrder;

    public void GameStart()
    {
        state = RevolverState.Loading;
        StartCoroutine(RouletteSetup());
    }

    IEnumerator RouletteSetup()
    {
        GameMaster.text = "Welcome to my game...";
        yield return new WaitForSeconds(2f);
        GameMaster.text = "When you're ready, Flip this coin";
        yield return new WaitForSeconds(2f);
        GameMaster.text = "Blue for you first, Red for me.";

        if (Keyboard.current.spaceKey.isPressed == true && CoinFlipped == false) 
        {
            coinControl.FlipCoin();
            if CoinResult
        }
    }

    IEnumerator Player()
    {
        GameMaster.text = "The Barrel Spins, The Game Begins";
        BulletChamber = Random.Range(1, 6);
    }

}

