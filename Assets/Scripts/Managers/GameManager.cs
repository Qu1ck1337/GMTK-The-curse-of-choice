using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Player _player;
    private UIAssistant _uiAssistant;

    public static GameManager Self;
    public UIAssistant UIAssistant => _uiAssistant;
    public Player Player => _player;

    private void Awake()
    {
        Self = this;
        _uiAssistant = GetComponent<UIAssistant>();
    }

    public void ResetAllForNextStep()
    {
        _uiAssistant.ResetDicePlace();

    }
}