﻿using UnityEngine;

public class GUILabel : IMyGUI
{
    private string text;
    private bool centerFully;

    public GUILabel(string text, bool centerFully = false)
    {
        this.text = text;
        this.centerFully = centerFully;
    }

    public void OnGUI()
    {
        if (centerFully)
        {
            GUILayout.BeginVertical();
            GUILayout.FlexibleSpace();
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
        }

        GUILayout.Label(text);
        if (centerFully)
        {
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.EndVertical();
        }
    }
}