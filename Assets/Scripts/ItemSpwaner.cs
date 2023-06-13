using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpwaner : MonoBehaviour
{
    public GameObject HP;
    public GameObject O2;
    public GameObject Fuel;
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
                spawnPosition.x = spawnPosition.x + Random.Range(0, 12f);
                spawnPosition.y = spawnPosition.y + Random.Range(0, 12f);
                Quaternion spawnRotation = Quaternion.identity;
                int randomnumber = 0;
                randomnumber = Random.Range(1, 4);
                switch (randomnumber)
                {
                    case 1:
                        Instantiate(HP, spawnPosition, spawnRotation);
                        break;
                    case 2:
                        Instantiate(O2, spawnPosition, spawnRotation);
                        break;
                    case 3:
                        Instantiate(Fuel, spawnPosition, spawnRotation);
                        break;
                }
                // 加入生成一波子弹的时间间隔
                yield return new WaitForSeconds(spawnTime);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }

}
