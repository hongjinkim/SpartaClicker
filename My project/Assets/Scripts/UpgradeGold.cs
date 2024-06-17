using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeGold : Upgrade
{
    public override void Clicked()
    {
        base.Clicked();
        GameManager.Instance.goldGain *= 2;
    }
}
