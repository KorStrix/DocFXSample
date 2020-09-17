using UnityEngine;


namespace DocFXTest
{
    /// <summary>
    /// 이 코드는 샘플입니다. <see cref="SampleBehaviour_ForDocFX"/>
    /// </summary>
    public class SampleBehaviour_ForDocFX_Base : MonoBehaviour
    {
        /// <summary>
        /// 이 함수는 Start 함수입니다.
        /// </summary>
        void Start()
        {

        }

        /// <summary>
        /// 이 함수는 public 함수입니다.
        /// </summary>
        public void Public_Function()
        {
            Debug.Log("테스트 로그");
        }

        /// <summary>
        /// 이 함수는 virtual 함수입니다.
        /// </summary>
        public virtual void Virtual_Function()
        {

        }

        protected virtual void Virtual_Protected()
        {

        }
    }
}
