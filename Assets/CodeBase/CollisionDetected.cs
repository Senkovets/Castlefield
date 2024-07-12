using Dreamteck.Splines;
using Constans;
using UnityEngine;

public class CollisionDetected : MonoBehaviour
{
    private Fraction _fraction;
    private void Start()
    {
        _fraction = GetComponent<Fraction>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Fraction fraction;

        if (other.gameObject.TryGetComponent<Fraction>(out fraction))
        {
            if (_fraction.Affiliation == fraction.Affiliation)
                return;
        }

        if (other.gameObject.CompareTag(nameof(Tags.Unit)))
        {
            Debug.Log("Драка");
            var follower = GetComponent<SplineFollower>();

            follower.followSpeed = 0;
        }
    }
}
