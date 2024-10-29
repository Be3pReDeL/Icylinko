using UnityEngine;

public class DestroyGameobjectAnimator : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) => Destroy(animator.gameObject);
}