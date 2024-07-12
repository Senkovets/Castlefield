using UnityEngine;
using UnityEngine.UI;

public class BarrackBuildingState : BaseBuildState
{
    public BarrackBuildingState(Text statustext, IStationStateSwithcer stateSwithcer) : base(statustext, stateSwithcer)
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
        Debug.Log("Solider++");
    }

    public override void Upgrade()
    {
        throw new System.NotImplementedException();
    }
}