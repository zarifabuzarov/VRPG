using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinsCounterText;
    public TextMeshProUGUI timerText;
    public Slider heathlSlider;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        heathlSlider.maxValue = player.healthMax;
        heathlSlider.value = player.health;
        coinsCounterText.text = player.coins.ToString();
        timerText.text = Time.time.ToString();

    }
}
