﻿using UnityEngine;

namespace TwoDimUtils.ScreenEdge
{
    public class ScreenEdgesHighTop : ScreenEdges
    {
#pragma warning disable 0649
        [SerializeField] private float additionalHeight = 5f;
#pragma warning restore 0649

        private float HalfHeight => additionalHeight * 0.5f;

        protected override void SpawnTopEdge()
            => SpawnEdge(
                Vector3.up * (Dim.y + additionalHeight), 
                Quaternion.Euler(0, 0, 180), 
                Vector3.one * Dim.x);
        
        protected override void SpawnLeftEdge() 
            => SpawnEdge(
                Vector3.left * Dim.x + Vector3.up * HalfHeight, 
                Quaternion.Euler(0, 0, -90), 
                Vector3.one * (Dim.y + HalfHeight));
        
        protected override void SpawnRightEdge() 
            => SpawnEdge(Vector3.right * Dim.x + Vector3.up * HalfHeight, 
                Quaternion.Euler(0, 0, 90), 
                Vector3.one * (Dim.y + HalfHeight));
    }
}