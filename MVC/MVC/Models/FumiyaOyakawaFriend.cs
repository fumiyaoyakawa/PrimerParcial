using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public enum Tipoamigo
    {
        Conocido,
        CompañeroEstudio,
        ColegaDeTrabajo,
        Amigo,
        AmigoDeInfancia,
        Pariente

    }
    public class FumiyaOyakawaFriend
    {
        [Key]
        public int FriendId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Tipoamigo Amigo { get; set; }
        [Required]
        public string Nickname { get; set; }
        public int Birthdate { get; set; }
    }
}