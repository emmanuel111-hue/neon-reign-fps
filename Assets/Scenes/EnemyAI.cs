using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float speed = 3.5f;
    public float detectionRange = 15f;

    void Update()
    {
        if (!player) return;

        float distance = Vector3.Distance(transform.position, player.position);
        if (distance < detectionRange)
        {
            transform.LookAt(player);
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }
}
