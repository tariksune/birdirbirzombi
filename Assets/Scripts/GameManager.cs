using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject playerZombie;
    public GameObject crouchPerson;
    public GameObject playButton;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator SpawnCrouchPerson()
    {
        while (true)
        {
            float waitTime = Random.Range(1f, 5f);
            yield return new WaitForSeconds(waitTime);
            Instantiate(crouchPerson, spawnPoint.position, Quaternion.identity);
        }
    }

    public void GameStart()
    {
        playerZombie.SetActive(true);
        playButton.SetActive(false);
        StartCoroutine("SpawnCrouchPerson");
    }
   
}
