using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class CollisionDetect : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject playerAnim;
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(CollisionEnd());

    }
    IEnumerator CollisionEnd(){
        thePlayer.GetComponent<PlayerMovement>().enabled = false;
        playerAnim.GetComponent<Animator>().Play("Sweep Fall");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
    }

}
 