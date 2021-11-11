
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public GameObject panelFinJuego; // aparece panel de fin del juego
    private contrller Generadores; // se apaga la maquina 

    public Text HigScoreTxt;
    public int HigScore;
    
    public Text ScoreTxt;
    public Text TimerTxt;

    private float timer = 30f;
    private int ScoreSum = 0;

    public bool start;

    private void Start()
    {
        Generadores = GameObject.Find("Generadores").GetComponent<contrller>();
        HigScore = PlayerPrefs.GetInt("HighScore", 0);
    }
    private void Update()
    {
        if (start)
        {
            if (timer <= 0)
            {
                GameOff();
            }
            else
            {
                timer -= Time.deltaTime;
                TimerTxt.text = timer.ToString("N0");
            }
        }
    }

    private void GameOff() {
        panelFinJuego.SetActive(true);
        ScoreTxt.enabled = false;
        TimerTxt.enabled = false;
        Generadores.active = false;
        if (ScoreSum > PlayerPrefs.GetInt("HighScore", 0))
        {
            Debug.Log("Entra al condicional");
            PlayerPrefs.SetInt("HighScore", ScoreSum);
            HigScoreTxt.text = ScoreSum.ToString();
        }
        HigScoreTxt.text = HigScore.ToString();
        Debug.Log("highScore: " + HigScore.ToString());
        start = false;
    }
    public void gameOn() {
        ScoreSum = 0;
        ScoreTxt.text = ScoreSum.ToString();
        start = true;
        timer = 30f;
        panelFinJuego.SetActive(false);
        ScoreTxt.enabled = true;
        TimerTxt.enabled = true;
        Generadores.active = true;
    }

    public void Score(int cant)
    {
        ScoreSum += cant;
        ScoreTxt.text = ScoreSum.ToString();
    }
}
