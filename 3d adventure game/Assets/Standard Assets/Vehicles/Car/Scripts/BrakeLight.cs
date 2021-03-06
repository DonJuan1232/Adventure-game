using UnityEngine;

namespace UnitySampleAssets.Vehicles.Car
{
    public class BrakeLight : MonoBehaviour
    {
        public CarController car; // reference to the car controller, must be dragged in inspector


        private void Update()
        {
            // enable the renderer when the car is braking, disable it otherwise.
            GetComponent<Renderer>().enabled = car.BrakeInput > 0f;
        }
    }
}