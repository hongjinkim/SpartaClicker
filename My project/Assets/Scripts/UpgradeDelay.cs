using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeDelay : Upgrade
{
    public override void Clicked()
    {
        base.Clicked();
        GameManager.Instance.autoDelay /= 2;
    }
}
