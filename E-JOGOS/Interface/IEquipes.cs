using System;
using System.Collections.Generic;
using E_JOGOS.Models;

namespace E_JOGOS.Interface
{
    public interface IEquipe
    {
        //CREATE
        //READALL
        //UPDATE
        //DELETE

        void Create(Equipe nova_equipe);
        List<Equipe> ReadAll();
        void Update(Equipe equipe);
        void Delete(int idEquipe);
    }
}
