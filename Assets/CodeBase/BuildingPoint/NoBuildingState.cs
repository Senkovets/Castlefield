using UnityEngine;
using UnityEngine.UI;

public class NoBuildingState : BaseBuildState
{
    public NoBuildingState(Text statustext, IStationStateSwithcer stateSwithcer) : base(statustext, stateSwithcer)
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
        throw new System.NotImplementedException();
    }

    public override void Produce()
    {
        throw new System.NotImplementedException();
    }

    public override void Upgrade()
    {
        throw new System.NotImplementedException();
    }

    
}
