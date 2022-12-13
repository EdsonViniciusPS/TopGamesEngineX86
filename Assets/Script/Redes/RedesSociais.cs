using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedesSociais : MonoBehaviour
{
    [SerializeField]
    string TelegramUrl;

    [SerializeField]
    string PixUrl;

    public void Telegram()
    {
        Application.OpenURL(TelegramUrl);
    }

    public void BuyPixCoin()
    {
        Application.OpenURL(PixUrl);
    }
}
