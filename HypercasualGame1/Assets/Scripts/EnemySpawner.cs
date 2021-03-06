using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpawner : MonoBehaviour
{
    public GameObject theEnemy;
    private int xPos, xPos1;
    private int zPos, zPos1;
    public int enemyCount;
 
    public GameObject targetPlayer;
    NavMeshAgent enemyAgent;

    private void Start()
    {
        enemyAgent = GetComponent<NavMeshAgent>();
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 5)
        {
            xPos = Random.Range(-5, -10);
            zPos = Random.Range(-5, -10);
            Instantiate(theEnemy, new Vector3(xPos, 1, zPos), Quaternion.identity);

            yield return new WaitForSeconds(1f);

            xPos1 = Random.Range(5, 10);
            zPos1 = Random.Range(5, 10);
            Instantiate(theEnemy, new Vector3(xPos1, 1, zPos1), Quaternion.identity);

            yield return new WaitForSeconds(1f);
            enemyCount += 1;
        }
    }

    void Update()
    {
        enemyAgent.SetDestination(targetPlayer.transform.position);
    }

}
    