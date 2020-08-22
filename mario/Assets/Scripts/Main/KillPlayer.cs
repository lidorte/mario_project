using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    [SerializeField] private GameObject MainPlayer;

    public IEnumerator OnTriggerEnter(Collider col)
    {
        MainPlayer.SetActive(false);
        yield return new WaitForSeconds(1);
        Application.LoadLevel(0);
        GlobalCoins.CoinCount = 0;
    }
}
