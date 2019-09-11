using System.Collections;
using UnityEngine;
using TMPro;
using System;

namespace QuickStarter.UI
{
    public class TimerUpdater : MonoBehaviour
    {
        [Header("HUD")]
        [SerializeField] private TextMeshProUGUI _timerUGUI;

        [Header("Settings")]
        [SerializeField] private float _secondsBetweenUpdates;

        private bool _updating = false;
        private Coroutine _updatingRoutine;
        private float _timerSeconds = 0f;

        // CORE

        private void Start()
        {
            StartTimer();
        }

        private void Update()
        {
            if (_updating)
            {
                _timerSeconds += Time.deltaTime;
            }
        }

        // PUBLIC

        public void UpdateTimer(float seconds)
        {
            _timerUGUI.text = "" + ConvertSecondsToTime(seconds);
        }

        public void StartTimer()
        {
            ResetTimer();
            _updating = true;
            _updatingRoutine = StartCoroutine(UpdateRoutine());
        }

        public void StopTimer()
        {
            _updating = false;
        }

        public void ResetTimer()
        {
            _timerSeconds = 0f;
            if (_updatingRoutine != null)
            {
                StopCoroutine(_updatingRoutine);
            }
        }

        // PRIVATE

        private string ConvertSecondsToTime(float seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            DateTime dateTime = DateTime.Today.Add(time);
            return dateTime.ToString("mm:ss");
        }

        private IEnumerator UpdateRoutine()
        {
            while (_updating)
            {
                yield return new WaitForSeconds(_secondsBetweenUpdates);
                UpdateTimer(_timerSeconds);
            }
        }
    }
}
