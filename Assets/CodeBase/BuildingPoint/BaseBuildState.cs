using UnityEngine;
using UnityEngine.UI;

public abstract class BaseBuildState : MonoBehaviour
{
    protected readonly Text _statusText;
    protected readonly IStationStateSwithcer _stateSwither;

    protected BaseBuildState(Text statustext, IStationStateSwithcer stateSwithcer)
    {
        _statusText = statustext;
        _stateSwither = stateSwithcer;
    }


    public abstract void Start();
    public abstract void Stop();
    public abstract void Produce();
    public abstract void Upgrade();
    public abstract void Sell();

}
