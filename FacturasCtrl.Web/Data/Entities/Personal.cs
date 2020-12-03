using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Personal
    {
        public int Id { get; set; }


        //Relaciones, como la información de mypersonal es igual a la de user queda en user y se hace la relación
        //Al decirle que cada persona tiene una relación con user, mypersonal toma todos los campos de user

        public User User { get; set; }


    }
}