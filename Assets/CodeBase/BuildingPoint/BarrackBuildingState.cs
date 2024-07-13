using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BarrackBuildingState : BaseBuildState
{
    public BarrackBuildingState(Text statustext, IStationStateSwithcer stateSwithcer) : base(statustext, stateSwithcer)
    {
    }

    public override void Start()
    {
        Produce();
    }

    public override void Stop()
    {
        StopAllCoroutines();
    }

    public override void Sell()
    {
        Debug.Log("Sell");
        _stateSwither.SwitchSatte<NoBuildingState>();
    }

    public override void Produce()
    {
        StartCoroutine(ProduceCoroutine());
    }

    private IEnumerator ProduceCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            Debug.Log("Coin++");
        }
    }

    public override void Upgrade()
    {
        Debug.Log("UpgradeBarack");
    }
}