using System;
using UnityEngine;
using UnityEngine.Experimental.VFX;

namespace UnityEditor.VFX
{
    [VFXInfo(category = "Spawner")]
    class VFXSpawnerConstantRate : VFXAbstractSpawner
    {
        public override string name { get { return "ConstantRate"; } }
        public override VFXTaskType spawnerType { get { return VFXTaskType.kSpawnerConstantRate; } }
        public class InputProperties
        {
            [Min(0)]
            public float Rate = 10;
        }
    }
}
