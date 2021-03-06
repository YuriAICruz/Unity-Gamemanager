﻿using System;
using UnityEngine;

namespace GameManagement
{
    public abstract class GameManager : MonoBehaviour
    {
        public event Action LevelStart, PlayerDie, Pause, UnPause, GameOver;

        protected bool _paused;
        
        public virtual void OnGameOver()
        {
            if (GameOver != null) GameOver();
        }

        public virtual void OnPlayerDie()
        {
            if (PlayerDie != null) PlayerDie();
        }

        public virtual void OnLevelStart()
        {
            if (LevelStart != null) LevelStart();
        }

        public void OnPause()
        {
            _paused = !_paused;

            if (_paused)
            {
                Pause?.Invoke();
            }
            else
            {
                UnPause?.Invoke();
            }
        }
    }
}