using System;
using System.ComponentModel.DataAnnotations;

namespace aulawebapi.Models
{
    public class Pessoa
    {
        [Key]
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
    }
}