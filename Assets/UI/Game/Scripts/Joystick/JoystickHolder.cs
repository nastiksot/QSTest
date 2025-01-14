﻿using Plugins.JoystickUtils.Core;
using UnityEngine;

namespace UI.Game.Scripts.Joystick
{
    public class JoystickHolder : MonoBehaviour
    {
        [SerializeField] private CanvasGroup joystickCanvas;
        [SerializeField] private JoystickController joystickController;

        public CanvasGroup JoystickCanvas => joystickCanvas;
        public JoystickController JoystickController => joystickController;

        /// <summary>
        /// Reset joystick position to center
        /// </summary>
        public void ResetJoystickCenter()
        {
            joystickController.ResetJoystickPosition();
        }
    }
}