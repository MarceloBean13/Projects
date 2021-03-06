//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserRegistration.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Utilizador
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Preenchimento Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preenchimento Obrigatório")]
        [DisplayName("Último Nome")]
        public string UltimoNome { get; set; }

        [Required(ErrorMessage = "Preenchimento Obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preenchimento Obrigatório")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Preenchimento Obrigatório")] 
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password")]
        [DisplayName("Confirmar Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
