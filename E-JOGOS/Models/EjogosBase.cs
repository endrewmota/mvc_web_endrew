using System;
using System.IO;

namespace E_JOGOS.Models
{
    public class EjogosBase
    {
        //Criar uma funcao para criar a pasta e o arquivo

        //string path é o parametro da funcao que terá o caminho para analise
        public void CreateFolderAndFile(string path)
        {
            //pasta / arquivo.csv;

            string folder = path.Split('/')[0];//recebe nome da pasta
            string file = path.Split('/')[1];//recebe o nome do arquivo

            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!Directory.Exists(file))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
