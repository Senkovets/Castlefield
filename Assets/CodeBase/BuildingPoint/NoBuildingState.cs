using System.Collections;
using UnityEngine;

public class NoBuildingState : BaseBuildState
{
    public NoBuildingState(int level, BuildingVisualBehaviour visualBehaviuor, IStationStateSwithcer stateSwithcer) : base(level, visualBehaviuor, stateSwithcer)
    {
    }

    public override void StartState()
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
