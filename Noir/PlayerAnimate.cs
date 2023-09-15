using UnityEngine;
using UnityEngine.AI;

public class PlayerAnimate : IAnimator
{
    private CharacterController _characterController;
    private NavMeshAgent _meshAgent;
    private Animator _animator;

    public PlayerAnimate(CharacterController characterController, Animator animator, NavMeshAgent meshAgent)
    {
        _characterController = characterController;
        _animator = animator;
        _meshAgent = meshAgent;
    }

    public void Update(float deltaTime)
    {
        SwitchAnimation();
    }

    private void SwitchAnimation()
    {
       if(_characterController.velocity != Vector3.zero || _meshAgent.velocity != Vector3.zero)
        {
            _animator.SetBool("isWalking", true);
        }
       else if (_characterController.velocity == Vector3.zero || _meshAgent.velocity == Vector3.zero)
        {
            _animator.SetBool("isWalking", false);
        }
    }
}