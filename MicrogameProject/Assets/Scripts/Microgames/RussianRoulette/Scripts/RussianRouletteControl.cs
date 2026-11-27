using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

using UnityEngine.UI;
public enum RevolverState {Loading, Waiting, PFirst, JFirst, PlayerTurn, JimothyTurn, PlayerShooting, JimothyShooting, Victory, Dead}

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
    public int JimAI;
    public bool PSpun;
    public bool JSpun;
    public bool PShotJim;
    public bool JShotPlayer;
    public int TurnCount;

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
            StartCoroutine(Waiting());
        }
    }

    IEnumerator Waiting()
    {
        if (turnOrder == 1)
        {
            StartCoroutine(JFirst());
        }
        
        if (turnOrder == 2)
        {
            StartCoroutine(PFirst());
        }
        yield return new WaitForSeconds(2f);
    }

    IEnumerator PFirst()
    {
        GameMaster.text = "Lucky you... It chose Blue...";
        GameMaster.text = "The Barrel Spins, The Game Begins";
        BulletChamber = Random.Range(1, 6);
        TurnCount += 1;
        yield return new WaitForSeconds(2f);

        StartCoroutine(JimothyTurn());
    }

    IEnumerator JFirst()
    {
        GameMaster.text = "Your luck's dead! Coin chose red!";
        GameMaster.text = "The Barrel Spins, The Game Begins";
        BulletChamber = Random.Range(1, 6);
        TurnCount += 1;
        yield return new WaitForSeconds(2f);

        StartCoroutine(PlayerTurn());

    }

    IEnumerator PlayerTurn()
    {
        TurnCount += 1;
        yield return new WaitForSeconds(2f);
        StartCoroutine(JimothyTurn());
    }

    IEnumerator JimothyTurn()
    {
        TurnCount += 1;
        yield return new WaitForSeconds(2f);
        StartCoroutine(PlayerTurn());
    }

}

