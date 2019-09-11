using UnityEngine;
using Common.Events;

namespace Common.Utils2D
{
    [RequireComponent(typeof(Collider2D))]
    public class LayerCollisionHandler : MonoBehaviour
    {
        [Header("Layer")]
        public string LayerName;

        [Header("Events")]
        public StringEvent OnLayerCollisionEnter;
        public StringEvent OnLayerCollisionStay;
        public StringEvent OnLayerCollisionExit;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer(LayerName))
            {
                if (OnLayerCollisionEnter != null)
                {
                    OnLayerCollisionEnter.Invoke(LayerName);
                }
            }
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer(LayerName))
            {
                if (OnLayerCollisionStay != null)
                {
                    OnLayerCollisionStay.Invoke(LayerName);
                }
            }
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer(LayerName))
            {
                if (OnLayerCollisionExit != null)
                {
                    OnLayerCollisionExit.Invoke(LayerName);
                }
            }
        }
    }
}
