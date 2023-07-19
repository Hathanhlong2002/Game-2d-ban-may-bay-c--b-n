using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] List<GameObject> listEnemiesPos = new List<GameObject>();
    [SerializeField] Sprite[] enemiesSprite;
    private GameObject enemyPrefab;
    private GameObject enemyParent;
    // [SerializeField] List<GameObject> listEnemiesGameObject;
    private GameObject arrayPos;

    private void Awake()
    {
        enemiesSprite = Resources.LoadAll<Sprite>("Space");
        arrayPos = GameObject.Find("ListPosEnemy");
        enemyPrefab=GameObject.Find("Enemy");
        enemyParent=GameObject.Find("ListEnemies");
    }

    void Start()
    {
        Transform[] childTransformsPos = arrayPos.GetComponentsInChildren<Transform>();
        foreach (Transform childTransform in childTransformsPos)
        {
            if (childTransform != arrayPos.transform)
            {
                listEnemiesPos.Add(childTransform.gameObject);
            }
        }
    }
    void Update()
    {
        CheckCountEnemies();
    }
    private void SpawnEnemy()
    {
        int randomNum=Random.Range(0,listEnemiesPos.Count);
        int randomSprite=Random.Range(0,enemiesSprite.Length);
        GameObject enemy = Instantiate(enemyPrefab, listEnemiesPos[randomNum].transform.position, Quaternion.identity);
        SpriteRenderer spriteRenderer = enemy.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = enemiesSprite[randomSprite];
        enemy.transform.SetParent(enemyParent.transform);
        enemy.name=randomNum.ToString();
        // listEnemiesGameObject.Add(enemy); 
    }
    private void CheckCountEnemies()
    {
        int childCount = enemyParent.transform.childCount;
        if( childCount<10 )
        {
            SpawnEnemy();
        }
    }
}
