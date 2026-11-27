using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreWeighting : MonoBehaviour
{
    public enum ResultSprite { Cherry, Lemon, Melon, Heart, Bar, BarBar, BarBarBar, Cleat, Clover, Bell, Sevens}

    public ResultSprite a;
    public ResultSprite b;
    public ResultSprite c;
    public TextMeshProUGUI Scoretext;
    public int ResultScore;

    public int CheckLine()
    {
        ResultSprite[] lineResults = { a, b, c };
        return CheckLine(lineResults);
    }

    public int CheckLine(ResultSprite[] lineResults)
    {
        if (lineResults == null || lineResults.Length < 3)
        {
            ResultScore = 0;
        }
        else
        {
            ResultSprite a = lineResults[0];
            ResultSprite b = lineResults[1];
            ResultSprite c = lineResults[2];

            if (a == b && a == c)
            {
                ResultScore += a switch
                {
                    ResultSprite.Cherry => 100,
                    ResultSprite.Lemon => 200,
                    ResultSprite.Melon => 300,
                    ResultSprite.Heart => 400,
                    ResultSprite.Bar => 1000,
                    ResultSprite.BarBar => 2000,
                    ResultSprite.BarBarBar => 3000,
                    ResultSprite.Cleat => 4000,
                    ResultSprite.Clover => 5000,
                    ResultSprite.Bell => 6000,
                    ResultSprite.Sevens => 7777,
                    _ => 50
                };
                Debug.Log("Triples");
            }
            else if (a == b || a == c || b == c)
            {
                ResultSprite pear = a == b || a == c ? a : b;
                ResultScore += pear switch
                {
                    ResultSprite.Cherry => 10,
                    ResultSprite.Lemon => 20,
                    ResultSprite.Melon => 30,
                    ResultSprite.Heart => 40,
                    ResultSprite.Bar => 100,
                    ResultSprite.BarBar => 200,
                    ResultSprite.BarBarBar => 300,
                    ResultSprite.Cleat => 400,
                    ResultSprite.Clover => 500,
                    ResultSprite.Bell => 600,
                    ResultSprite.Sevens => 777,
                    _ => 0
                };
                Debug.Log("Pairs");
            }
            else
            {
                ResultScore = 0;
            }
        }

        Scoretext.text = "Score" + ResultScore;
        

        return ResultScore;
    }
}