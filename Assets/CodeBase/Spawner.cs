using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    public GameObject SpawnUnit;
    public float StartDelay;
    public float SpawnTime;
    void Start()
    {
        InvokeRepeating(nameof(Spawn), StartDelay, SpawnTime);
    }
    private void Spawn()
    {
        Instantiate(SpawnUnit, _spawnPoint.position, SpawnUnit.transform.rotation);
    }
}
