using System;
using System.ComponentModel.DataAnnotations;
namespace ProyectoCiclo3.App.Dominio{
    public class Rutas{
        public int id {get; set;}
        [Required]
        public int origen {get; set;} 
        [Required]
        public int destino {get; set;} 
        public int tiempo_estimado {get; set;} 
    }
}