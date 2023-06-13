using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawn : MonoBehaviour
{
    public GameObject enemySpawn1;// 存放陨石prefab
    public GameObject enemySpawn2;
    public GameObject enemySpawn3;
    public GameObject enemySpawn4;
    public GameObject enemySpawn5;
    public GameObject enemySpawn6;
    public GameObject enemySpawn7;
    public GameObject enemySpawn8;
    public GameObject enemySpawn9;
    public GameObject enemySpawn10;
    public GameObject enemySpawn11;
    public GameObject gameObject;//Plyaer
    public int enemyCount;// 每一波陨石的个数
    public float startWait;// 开始游戏后玩家的准备时间
    public float spawnTime;// 生成下一波敌人的时间间隔

    public float waveWait;// 生成下一波敌人的等待时间

    void Start()
    {
        StartCoroutine(spawnWaves());
    }

    // 协同函数
    IEnumerator spawnWaves()
    {
        // 开始游戏后，不会立即有敌人，需要给玩家一些准备时间waitTime
        yield return new WaitForSeconds(startWait);
        // 循环生成一波一波的敌人
        while (true)
        {
            for (int i = 0; i < enemyCount; ++i)
            {
                Vector3 spawnPosition = gameObject.transform.position;
                spawnPosition.x = spawnPosition.x + Random.Range(-30f, 30f);
                spawnPosition.y = spawnPosition.y + Random.Range(-30f, 30f);
                if(((spawnPosition.x - gameObject.transform.position.x) * (spawnPosition.x - gameObject.transform.position.x)) + ((spawnPosition.y - gameObject.transform.position.y) * (spawnPosition.y - gameObject.transform.position.y)) < 200f)
                {
                    continue;
                }
                Quaternion spawnRotation = Quaternion.identity;
                int randomnumber = 0;
                randomnumber = Random.Range(1, 12);
                switch (randomnumber)
                {
                    case 1:
                        Instantiate(enemySpawn1, spawnPosition, spawnRotation);
                        break;
                    case 2:
                        Instantiate(enemySpawn2, spawnPosition, spawnRotation);
                        break;
                    case 3:
                        Instantiate(enemySpawn3, spawnPosition, spawnRotation);
                        break;
                    case 4:
                        Instantiate(enemySpawn4, spawnPosition, spawnRotation);
                        break;
                    case 5:
                        Instantiate(enemySpawn5, spawnPosition, spawnRotation);
                        break;
                    case 6:
                        Instantiate(enemySpawn6, spawnPosition, spawnRotation);
                        break;
                    case 7:
                        Instantiate(enemySpawn7, spawnPosition, spawnRotation);
                        break;
                    case 8:
                        Instantiate(enemySpawn8, spawnPosition, spawnRotation);
                        break;
                    case 9:
                        Instantiate(enemySpawn9, spawnPosition, spawnRotation);
                        break;
                    case 10:
                        Instantiate(enemySpawn10, spawnPosition, spawnRotation);
                        break;
                    case 11:
                        Instantiate(enemySpawn11, spawnPosition, spawnRotation);
                        break;
                }
                // 加入生成一波子弹的时间间隔
                yield return new WaitForSeconds(spawnTime);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }

}
