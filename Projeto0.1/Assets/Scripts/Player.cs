using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    
    [SerializeField] private PlayerInput _playerInput;
    private GameControls _controls;
    private Vector2 _moveInput;
    private bool _isatirando;
    private int _points; 
    private int _currentEnergy;
    [ SerializeField] private int 

    private void OnEnable()
    {
        _playerInput.onActionTriggered += OnAction;
    }

    private void OnDisable()
    {
        _playerInput.onActionTriggered += OnAction;
    }

    private void Awake()
    {
        _controls = new GameControls();
    }

    // Só funciona quando estiver alguma forma de ação input/Jogo 
    private void OnAction(InputAction.CallbackContext PlayerAct)
    {
        // Está chegando uma ação e o if quer saber se a ação é igual ao nome da ação de atirar, e se for faz o jogador se o jogador 
        if (PlayerAct.action.name == _controls.GamePlay.Tiro.name)
        {
            // fazer o jogador atirar 
            //Input antigo
            //KeyDown (no momento em que o jogador aperta) 
            // Key (no momento que o jogador está apertando) 
            //Keyup(no momento que o jogador solta) Input System
            //
            if (PlayerAct.started)
                _isatirando = true;
            else if (PlayerAct.canceled)
                _isatirando = false;

        }
        
        if (PlayerAct.action.name == _controls.GamePlay.Movimento.name)
        {
            _moveInput = PlayerAct.ReadValue<Vector2>();
        }

        // Start is called before the first frame update
        void Start()
        {

        }
    }

    private void AddPoints(int amount)
    {
        _point += amount;
    }
       

}
