using UnityEngine;

namespace QuickStarter
{
    [RequireComponent(typeof(ParticleSystem))]
    [RequireComponent(typeof(ParticleSystemRenderer))]
    public class ParticleSystemController : MonoBehaviour
    {
        [Header("Layer Settings")]
        [Tooltip("Leave empty if it uses the Unity default sorting layer.")]
        public string SortingLayer;
        public int OrderInLayer;

        [Header("Particle System Settings")]
        [SerializeField] private bool _startEmittingOnAwake;

        private ParticleSystem _particleSystem;
        private ParticleSystemRenderer _particleSystemRenderer;
        private ParticleSystem.EmissionModule _emissionModule;

        // MONO

        private void Awake()
        {
            InitializeReferences();

            if (SortingLayer != "")
            {
                SetSortingLayer(SortingLayer);
            }
            SetOrderInLayer(OrderInLayer);

            if (_startEmittingOnAwake)
            {
                StartEmitting();
            }
            else
            {
                StopEmitting();
            }
        }

        // PUBLIC

        public void Pause()
        {
            _particleSystem.Pause();
        }

        public void Play()
        {
            _particleSystem.Play();
        }

        public void SetSortingLayer(string sortingLayer)
        {
            _particleSystemRenderer.sortingLayerName = sortingLayer;
            SortingLayer = sortingLayer;
        }

        public void SetOrderInLayer(int orderInLayer)
        {
            _particleSystemRenderer.sortingOrder = orderInLayer;
            OrderInLayer = orderInLayer;
        }

        public void StartEmitting()
        {
            Debug.Log(_emissionModule);
            _emissionModule.enabled = true;
        }

        public void StopEmitting()
        {
            _emissionModule.enabled = false;
        }

        // PRIVATE

        private void InitializeReferences()
        {
            _particleSystem = GetComponent<ParticleSystem>();
            _particleSystemRenderer = GetComponent<ParticleSystemRenderer>();
            _emissionModule = _particleSystem.emission;
        }
    }
}
