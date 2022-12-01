using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebHealthy.Models
{
    public class Usuario
{
        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string NomeUsuario { get; set; }

        [Display(Name = "Observação Médica")]
        public string Observação { get; set; }

        [Display(Name = "Idade do Usuário")]
        [Required(ErrorMessage = "Idade é obrigatória")]
        public string Idade { get; set; }

        [Display(Name = "Seu Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Insira um email válido")]
        public string Email { get; set; }

        [Display(Name = "Nome de Usuário")]
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras e de 5 a 15 caracteres")]
        [Required(ErrorMessage = "Nome de Usuário é obrigatório")]
        public string Login { get; set; }

        [Display(Name = "Qual o seu Sexo")]
        [Required(ErrorMessage = "Sexo é obrigatório")]
        public string Sexo { get; set; }

        [Display(Name = "Digite sua Altura")]
        [Required(ErrorMessage = "Sua Altura é obrigatória")]
        public double Altura { get; set; }

        [Display(Name = "Digite seu Peso")]
        [Required(ErrorMessage = "Seu Peso é obrigatório")]
        public double Peso { get; set; }

        [Display(Name = "Crie sua Senha")]
        [Required(ErrorMessage = "Senha é obrigatório")]
        public string Senha { get; set; }

        [Display(Name = "Confirmar Senha")]
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "As senhas não correspondem")]
        public string ConfSenha { get; set; }

        [Display(Name = "Você já praticou atividades físicas antes?")]
        public string AttFis { get; set; }
    }
}