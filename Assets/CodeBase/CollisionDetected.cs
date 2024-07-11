using Dreamteck.Splines;
using UnityEngine;

public class CollisionDetected : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Unit"))
        {
            Debug.Log("Драка");
            //var enemyFollower = collision.gameObject.GetComponent<SplineFollower>();
            var follower = GetComponent<SplineFollower>();

            // enemyFollower.followSpeed = 0;
            follower.followSpeed = 0;
        }
    }
}
