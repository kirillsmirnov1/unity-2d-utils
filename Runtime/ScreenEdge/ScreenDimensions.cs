﻿using UnityEngine;

namespace TwoDimUtils.ScreenEdge 
{
    public class ScreenDimensions : MonoBehaviour
    {
        private Vector2 _dimensions;
        private bool _dimensionsNotSet = true;

        public Vector2 Dimensions
        {
            get
            {
                if (_dimensionsNotSet)
                {
                    _dimensions = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
                    _dimensionsNotSet = false;
                }

                return _dimensions;
            }
        }
    }
}