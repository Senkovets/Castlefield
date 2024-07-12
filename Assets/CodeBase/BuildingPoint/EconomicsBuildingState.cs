using UnityEngine;
using UnityEngine.UI;

public class EconomicsBuildingState : BaseBuildState
{
    public EconomicsBuildingState(Text statustext, IStationStateSwithcer stateSwithcer) : base(statustext, stateSwithcer)
    {
    }

    public override void Start()
    {
        throw new System.NotImplementedException();
    }

    public override void Stop()
    {
        throw new System.NotImplementedException();
    }

    public override void Sell()
    {
        _stateSwither.SwitchSatte<NoBuildingState>();
    }

    public override void Produce()
    {
        Debug.Log("Coin++");
    }

    public override void Upgrade()
    {
        Debug.Log("UpgradeEconom");
    }
}
