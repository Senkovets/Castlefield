using UnityEngine;
using UnityEngine.UI;

public abstract class BaseBuildState 
{
    protected int _level;
    protected BuildingVisualBehaviour _visualBehaviuor;
    protected IStationStateSwithcer _stateSwither;

    protected BaseBuildState(int level,BuildingVisualBehaviour visualBehaviuor, IStationStateSwithcer stateSwithcer)
    {
        _level = level;
        _visualBehaviuor = visualBehaviuor;
        _stateSwither = stateSwithcer;
    }


    public abstract void StartState();
    public abstract void Stop();
    public abstract void Produce();
    public abstract void Upgrade();
    public abstract void Sell();

}
