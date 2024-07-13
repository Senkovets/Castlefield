using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NoBuildingState : BaseBuildState
{
    public NoBuildingState(Text statustext, IStationStateSwithcer stateSwithcer) : base(statustext, stateSwithcer)
    {
    }
    public override void Start()
    {

    }

    public override void Stop()
    {

    }

    public override void Sell()
    {

    }

    public override void Produce()
    {

    }

    public override void Upgrade()
    {
        Debug.Log("Upgrade");
        _stateSwither.SwitchSatte<EconomicsBuildingState>();
    }

    
}
