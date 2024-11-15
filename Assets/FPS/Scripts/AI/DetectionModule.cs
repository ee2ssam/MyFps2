using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.Events;

namespace Unity.FPS.AI
{
    /// <summary>
    /// 적 디텍팅 구현
    /// </summary>
    public class DetectionModule : MonoBehaviour
    {
        #region Variables
        private ActorManager actorManager;

        public UnityAction OnDetectedTarge;     //적을 감지하면 등록된 함수 호출
        public UnityAction OnLostTarge;         //적을 놓치면 등록됨 함수 호출
        #endregion

        private void Start()
        {
            //참조
            actorManager = GameObject.FindObjectOfType<ActorManager>();
        }

        //디텍팅
        public void HandleTargetDetection(Actor actor, Collider[] selfCollider)
        {

        }

        //적을 감지하면
        public void OnDetected()
        {
            OnDetectedTarge?.Invoke();
        }

        //적을 놓치면
        public void OnLost()
        {
            OnLostTarge?.Invoke();
        }
    }
}