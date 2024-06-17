using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float autoDelay = 60f;
    public float goldGain = 1f;

    public TextMeshProUGUI text_gold;
    public TextMeshProUGUI text_auto;

    public float currentGold;


    void Start()
    {
        currentGold = 0;

        StartCoroutine(AutoClick());
    }

    // Update is called once per frame
    void Update()
    {
        text_gold.text = (int)currentGold + " $";
        text_auto.text = (int)goldGain + " $/" + (int)autoDelay + "s";
    }

    public void MouseClicked()
    {
        Debug.Log("mouse clicked");
        currentGold+=goldGain;
    }

    IEnumerator AutoClick()
    {
        while(true)
        {
            yield return new WaitForSeconds(autoDelay);
            MouseClicked();
        }
    }

    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameObject("GameManager").AddComponent<GameManager>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (_instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
}
