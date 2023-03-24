using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
<<<<<<< Updated upstream

    public void ReactToHit() {
        StartCoroutine(Die());
=======
    bool isAlive = true;
    public void ReactToHit()
    {
        if (isAlive) {
            WanderingAI enemyAI = GetComponent<WanderingAI>();
            if (enemyAI != null)
            {
                enemyAI.ChangeState(EnemyStates.dead);
            }
            Animator enemyAnimator = GetComponent<Animator>();
            if (enemyAnimator != null)
            {
                Debug.Log("In the animator");
                enemyAnimator.SetTrigger("Die");
            }
            //StartCoroutine(Die());
            Messenger.Broadcast(GameEvent.ENEMY_DEAD);
            isAlive = false;
        }
        

>>>>>>> Stashed changes
    }

    private IEnumerator Die() {
        iTween.RotateAdd(this.gameObject, new Vector3(-75, 0, 0), 1);
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }
}
