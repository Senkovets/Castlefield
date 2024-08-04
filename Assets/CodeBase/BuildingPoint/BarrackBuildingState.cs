using UnityEngine;
using UnityEngine.UI;

public class BarrackBuildingState : BaseBuildState
{
    public BarrackBuildingState(int level, BuildingVisualBehaviour visualBehaviuor, IStationStateSwithcer stateSwithcer) : base(level, visualBehaviuor, stateSwithcer)
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
        Debug.Log("Sell");
        _stateSwither.SwitchSatte<NoBuildingState>();
    }

    public override void Produce()
    {
        Debug.Log("Unit++");
        _visualBehaviuor.BarrackProduce();
    }

    public override void Upgrade()
    {
        Debug.Log("UpgradeBarack");
        _stateSwither.SwitchSatte<NoBuildingState>();
    }
}