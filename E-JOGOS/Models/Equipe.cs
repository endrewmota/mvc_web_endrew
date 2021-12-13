using System;
using System.Collections.Generic;
using System.IO;
using E_JOGOS.Interface;

namespace E_JOGOS.Models
{
    public class Equipe : EjogosBase, IEquipe
    {
        //CONSTRUTOR CTOR.

        //FUNCAO QUE VAI EXECUTAR/INICIAR ASSIM QUE A CLASSE FOR INSTANCIADA

        private const string path = "Database / equipe.csv";
        public Equipe()
        {
            CreateFolderAndFile(path);
        }

        public int IdEquipe { get; set; }

        public string Nome { get; set; }

        public string Imagem { get; set; }


        //funcao que vai preparar/converter de string para o
        //tipo de equipe

        //private string
        private string Prepare(Equipe e)
        {
            return $"{e.IdEquipe};{e.Nome};{e.Imagem};";
        }

        public void Create(Equipe nova_equipe)
        {
            //receber um objeto de equipe.
            //e gravar no csv.

            // "item;item;item;"

            string[] linha = { Prepare(nova_equipe) };
       
            File.AppendAllLines(path, linha);

        }


        public void Delete(int idEquipe)
        {
            throw new NotImplementedException();
        }



        public List<Equipe> ReadAll()
        {
            List<Equipe> equipes = new List<Equipe>();
            string[] linhas = File.ReadAllLines(path);

            foreach (string item in linhas)
            {
                Equipe equipe = new Equipe;
                equipe.IdEquipe = int.Parse(item.Split(';')[0]);
                equipe.Nome = item.Split(';')[1];
                equipe.Imagem = item.Split(';')[2];

                equipes.Add(equipe);
            }

            return equipes;
        }

        public void Update(Equipe equipe)
        {
            throw new NotImplementedException();
        }
    }
}
