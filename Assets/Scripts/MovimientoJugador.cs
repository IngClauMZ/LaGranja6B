using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoJugador : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Moverse(InputAction.CallbackContext entradaTeclado){
        if(entradaTeclado.performed){
            Debug.Log("Hola Mundo");
        }
        
    }
}
