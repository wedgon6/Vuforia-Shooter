using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _trakeblePlayer;
    [SerializeField] private Slider _slider;



    private void Start()
    {
        _slider.maxValue = _trakeblePlayer.Health;
    }

    private void OnEnable()
    {
        _trakeblePlayer.HealthChenget += OnHealthChenged;
    }

    private void OnDisable()
    {
        _trakeblePlayer.HealthChenget -= OnHealthChenged;
    }

    private void OnHealthChenged(int health)
    {
        _slider.value = health;
    }
}
