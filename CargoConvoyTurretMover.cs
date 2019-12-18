namespace Assets.Scripts
{
    using System.Collections;
    using System.Collections.Generic;
    using Jundroo.SimplePlanes.ModTools.PrefabProxies;
    using Jundroo.SimplePlanes.ModTools.AI;
    using SimplePlanesReflection.Assets.Scripts.Levels.Enemies;
    using UnityEngine;

    public class CargoConvoyTurretMover : MonoBehaviour
    {
        [SerializeField]
        private RotatingWeaponProxy[] MovablesProxies = null;

        private GameObject[] Movables;

        void Start()
        {
            Movables = new GameObject[MovablesProxies.Length];

            for (int i = 0; i < MovablesProxies.Length; i++)
            {
                Movables[i] = GameObject.Find(MovablesProxies[i].name);
            }
        }

        // Update is called once per frame
        void Update()
        {
            // Speed: 7
            // Along the direction 0, 210, 0 in world space

            Vector3 turretTranslation = Quaternion.Euler(0, 210, 0) * Vector3.forward * Time.deltaTime * 7;

            for (int i = 0; i < Movables.Length; i++)
            {
                Movables[i].transform.Translate(turretTranslation, Space.World);
            }
        }
    }
}