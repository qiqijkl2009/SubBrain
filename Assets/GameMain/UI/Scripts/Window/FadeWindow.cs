﻿using System;
using DG.Tweening;
using JKFrame;
using UnityEngine;
using UnityEngine.UI;

[UIWindowData(typeof(FadeWindow), true, GameConstant.UIWindow.FADE_WINDOW, 1)]
public class FadeWindow : UI_WindowBase
{
    [SerializeField] private Image _fadeMask;

    public override void OnClose()
    {
        _fadeMask.gameObject.SetActive(false);
    }

    public void FadeIn(float fadeTime, Action afterFade = null)
    {
        _fadeMask.gameObject.SetActive(true);
        _fadeMask.color = Color.black;
        _fadeMask.DOColor(Color.clear, fadeTime).OnComplete(() => { afterFade?.Invoke(); });
    }

    public void FadeOut(float fadeTime, Action afterFade = null)
    {
        _fadeMask.gameObject.SetActive(true);
        _fadeMask.color = Color.clear;
        _fadeMask.DOColor(Color.black, fadeTime).OnComplete(() => { afterFade?.Invoke(); });
    }
}