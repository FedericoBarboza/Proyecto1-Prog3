using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1_Prog3
{
public class IteradorDepto : Iterador{
    private List<Departamento> lista = new List<Departamento>();
    private int pos = -1;

    public IteradorDepto()
    {
        PersistenciaDepartamento persistencia = Sistema.fabricaPersistencia.ObtenerPersistenciaDepartamento();
        this.lista = persistencia.lista();
    }


    public Departamento siguiente()
    {
        pos++;
        return lista[pos];
    }

    public bool hayMas()
    {
            bool result=false;
            if (lista.Count > pos+1)
                result=true;
            return result;
    }

}
}