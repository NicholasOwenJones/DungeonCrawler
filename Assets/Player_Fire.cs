using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Fire : MonoBehaviour
{
    public GameObject player;
    public int delayer = 21, delayTime = 20;
    public bool fire;

    public List<GameObject> items;

    public GameObject[] healthPotionItems;



    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        items = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        fire = Input.GetKeyUp("space");
        if (fire == true && delayer >= delayTime)
        {
            Debug.LogWarning("FIRE!");
            foreach(GameObject go in items)
            {
                Instantiate(go, new Vector3(player.transform.localPosition.x + 1f, player.transform.localPosition.y, player.transform.localPosition.z), Quaternion.identity);
            }
            delayer = 0;
        }
    }

    private void FixedUpdate()
    {
        delayer +=1;
    }

    public void AddItem()
    {
        int rand = Random.Range(0, healthPotionItems.Length);
        items.Add(healthPotionItems[rand]);
    }
}
