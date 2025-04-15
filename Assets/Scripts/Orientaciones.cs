using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientaciones : MonoBehaviour
{
    public string NombreAlumno;
    public string Orientacion;
    public int AñoAlumno;
    // Start is called before the first frame update
    void Start()
    {
        if (NombreAlumno == "")
        {
            Debug.Log("El nombre no puede ser vacío.");
            return;
        }
        else if (AñoAlumno >= 1 && AñoAlumno <= 5)
        {
            if (Orientacion == "D" || Orientacion == "T" || Orientacion == "G" || Orientacion == "M" || Orientacion == "H")
            {
                if (AñoAlumno >= 3)
                {
                    Debug.Log("Muchas gracias " + NombreAlumno + "!");
                    return;
                }
                else
                {
                    Debug.Log("Error. Aún estás en el ciclo básico");
                    return;
                }
            }
            else Debug.Log("Solo puede ingresar T, D, G, M o H");
        }
        else
        {
            Debug.Log("Error");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
