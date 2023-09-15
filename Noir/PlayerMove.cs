using Cinemachine;
using External_Assets.Stuff_that_can_be_deleted_later.Dialogue_System.Scripts;
using Logic.CameraLogic;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private CharacterController CharacterController;
    public GameObject currentCameraZone;
    public int currentZoneType;
    public float deltaPath;
    [Range(1, 2)] public int controlType = 1;
    public NavMeshAgent player_NavMeshAgent;
    private IMover _mover;
    private IAnimator IAnimator;
    private Animator _animator;

    private void Start()
    {
        Physics.queriesHitTriggers = false;
        _animator = this.GetComponent<Animator>();
        IAnimator = new PlayerAnimate(CharacterController, _animator, player_NavMeshAgent);
    }

    public IEnumerator GetDeltaMotion()
    {
        if ((player_NavMeshAgent.velocity != Vector3.zero || CharacterController.velocity != Vector3.zero) && currentZoneType == 2)
        {
            float prevPos = GetPosition();
            yield return new WaitForSeconds(0.1f);
            float currentPos = GetPosition();
            if (Mathf.Abs(currentPos - prevPos) < 1)
            {
                deltaPath = currentPos - prevPos;
            }
            yield break;
        }
        yield break;
    }

    private void Update()
    {
        _mover.Update(Time.deltaTime);
        IAnimator.Update(Time.deltaTime);
 
        OnDialogEnter();        
        
        if (currentCameraZone != null)
        {
            //Railed camera offset switch by movement
            currentZoneType = currentCameraZone.GetComponent<CameraZoneTriggerInfo>().cameraZoneType;
            if ((player_NavMeshAgent.velocity != Vector3.zero || CharacterController.velocity != Vector3.zero) &&
                currentZoneType == 2)
            {
                StartCoroutine(GetDeltaMotion());
                if (deltaPath > 0.4f)
                {
                    currentCameraZone.GetComponentInChildren<CinemachineTrackedDolly>().m_AutoDolly
                        .m_PositionOffset = -5;
                }
                if (deltaPath < -0.4f)
                {
                    currentCameraZone.GetComponentInChildren<CinemachineTrackedDolly>().m_AutoDolly
                        .m_PositionOffset = 5;
                }
            }
        }
    }

    private float GetPosition()
    {
        if (currentZoneType == 2)
        {
            return currentCameraZone.GetComponentInChildren<CinemachineTrackedDolly>().m_PathPosition;
        }
        else
        {
            return 0;
        }
    }
    
    public void SetMover(IMover mover)
    {
        _mover = mover;
        _mover.StartMove();
    }

    private void OnDialogEnter()
    {
        if (DialogueManager.GetInstance() != null)
            if (DialogueManager.GetInstance().dialogueIsPlaying)
            {
                player_NavMeshAgent.enabled = false;
                _animator.SetBool("isWalking", false);
                _animator.SetBool("isRunning", false);
                return;
            }
    }
}
