using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

namespace BobboNet.CameraAudioListener.FMOD
{
    public class CameraAudioListenerFMOD : ICameraAudioListener
    {
        public void Setup(Camera mainCamera)
        {
            mainCamera.gameObject.AddComponent<StudioListener>();
        }
    }

}
