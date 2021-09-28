using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEstaciones
    {
        List<Estaciones> estaciones;
 
    public RepositorioEstaciones()
        {
            estaciones= new List<Estaciones>()
            {
                new Estaciones{id=1,nombre="nameE",direccion= "dir1",coord_x= 10.2f,coord_y= 4.2f,tipo= "tipo1"},
                new Estaciones{id=1,nombre="nameE",direccion= "dir2",coord_x= 10.2f,coord_y= 4.2f,tipo= "tipo2"},
                new Estaciones{id=1,nombre="nameE",direccion= "dir3",coord_x= 10.2f,coord_y= 4.2f,tipo= "tipo3"}
 
            };
        }
 
        public IEnumerable<Estaciones> GetAll()
        {
            return estaciones;
        }
 
        public Estaciones GetEstacionesWithId(int id){
            return estaciones.SingleOrDefault(b => b.id == id);
        }
    }
}