using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Level
{
    public int amount;
    public int rate;
}

public class LevelController : MonoBehaviour {

    public GameObject spawn;

    public GameObject source;

    public List<Level> levelList;

    public float spawnRadius;
    public float levelBufferTime;

    int spawnCount;
    int currentLevel;
    float spawnAngle;
    Vector2 spawnPos;

    Timer timer;

	// Use this for initialization
	void Start ()
    {
        spawnCount = 0;
        currentLevel = 0;
        timer = new Timer(levelList[currentLevel].rate);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(currentLevel < levelList.Count)
            timer.update(spawnVirus);
	}

    void spawnVirus()
    {
        spawnAngle = Random.Range(0, 360);
        spawnPos = new Vector2(spawnRadius * Mathf.Cos(spawnAngle), spawnRadius * Mathf.Sin(spawnAngle));
        Instantiate(spawn, spawnPos, Quaternion.identity);

        spawnCount++;

        if(spawnCount >= levelList[currentLevel].amount)
        {
            currentLevel++;
            spawnCount = 0;
            timer = new Timer(levelList[currentLevel].rate);
        }
    }
}
