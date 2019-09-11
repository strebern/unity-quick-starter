﻿using UnityEngine;

namespace Common.TransformUtils
{
    public class ScaleModifier : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] private ScaleModifierSettings settings;

        private float _timer = 0f;
        private bool _modifyingScale = false;
        private Vector3 _increaseRatio;
        private Vector3 _startScale;

        // CORE

        private void Awake()
        {
            _increaseRatio = settings.TargetSize - settings.StartSize;

            if (settings.StartIncreaseOnAwake)
            {
                StartModifyingScale();
            }
        }

        private void OnEnable()
        {
            _timer = 0f;
        }

        private void Update()
        {
            if (_timer < settings.SecondsBeforeFullSize && _modifyingScale)
            {
                _timer += Time.deltaTime;
                ModifyScale();
            }
        }

        // PUBLIC

        public void ResetScale()
        {
            _modifyingScale = false;
            _timer = 0f;
            transform.localScale = settings.StartSize;
        }

        public void StartModifyingScale()
        {
            _timer = 0f;
            _modifyingScale = true;
        }

        // PRIVATE

        private void ModifyScale()
        {
            var currentScale = transform.localScale;
            currentScale.x = settings.StartSize.x + _timer / settings.SecondsBeforeFullSize * _increaseRatio.x;
            currentScale.y = settings.StartSize.y + _timer / settings.SecondsBeforeFullSize * _increaseRatio.y;
            currentScale.z = settings.StartSize.z + _timer / settings.SecondsBeforeFullSize * _increaseRatio.z;
            transform.localScale = currentScale;
        }
    }
}
