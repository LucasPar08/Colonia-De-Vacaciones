
using UnityEngine;

public class ColoniaVacaciones : MonoBehaviour
{
    public int Juveniles;
    public int Infantiles;

    void Start()
    {
        // Start is called before the first frame
        if (Juveniles < 0 || Juveniles > 100 || Infantiles < 0 || Infantiles > 100)
        {
            Debug.LogError("Error: Tiene que ser un numero menor o igual a 100.");
            return;
        }

        int profesoresJuveniles = 0;
        if (Juveniles >= 20)
        {
            profesoresJuveniles = Juveniles / 20;
        }
        int profesoresInfantiles = 0;
        if (Infantiles >= 10)
        {
            profesoresInfantiles = Infantiles / 10;
        }

        int listaEsperaJuveniles = Juveniles - (profesoresJuveniles * 20);
        int listaEsperaInfantiles = Infantiles - (profesoresInfantiles * 10);
        int totalListaEspera = listaEsperaJuveniles + listaEsperaInfantiles;

        int totalProfesores = profesoresJuveniles + profesoresInfantiles;
        int coordinadores = (totalProfesores + 4) / 5;

        Debug.Log("Se necesitan " + profesoresJuveniles + " profesores para los inscriptos juveniles.");
        Debug.Log("Se necesitan " + profesoresInfantiles + " profesores para los inscriptos infantiles.");
        Debug.Log("Se necesitan " + coordinadores + " coordinadores.");
        Debug.Log("Inscriptos en lista de espera: " + totalListaEspera);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

x

