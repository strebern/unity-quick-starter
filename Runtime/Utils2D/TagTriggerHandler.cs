using UnityEngine;
using QuickStarter.Events;

namespace QuickStarter.Utils2D
{
    [RequireComponent(typeof(Collider2D))]
    public class TagTriggerHandler : MonoBehaviour
    {
        [Header("Tag")]
        public string TagName;

        [Header("Events")]
        public StringEvent OnTriggerEnter;
        public StringEvent OnTriggerStay;
        public StringEvent OnTriggerExit;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag(TagName))
            {
                if (OnTriggerEnter != null)
                {
                    OnTriggerEnter.Invoke(TagName);
                }
            }
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag(TagName))
            {
                if (OnTriggerStay != null)
                {
                    OnTriggerStay.Invoke(TagName);
                }
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag(TagName))
            {
                if (OnTriggerExit != null)
                {
                    OnTriggerExit.Invoke(TagName);
                }
            }
        }
    }
}
