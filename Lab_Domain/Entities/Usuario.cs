﻿using Lab_Domain.Enums;

namespace Lab_Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Chave { get; set; }
        public EnumPerfil Perfil { get; set; }
        public string Senha { get; set; }

        public bool ValidaSenha(string senha)
        {
            if (Senha == senha)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
