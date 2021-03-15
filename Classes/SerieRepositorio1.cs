using System.Collections.Generic;
using DioSerie1.Interfaces;

namespace DioSerie1
{
    public class SerieRepositorio1 : Irepositorio<Serie>

    {
        void Irepositorio<Serie>.Atualiza(int id, Serie entidade)
        {
            throw new System.NotImplementedException();
        }

        void Irepositorio<Serie>.Exclui(int id)
        {
            throw new System.NotImplementedException();
        }

        void Irepositorio<Serie>.Insere(Serie entidade)
        {
            throw new System.NotImplementedException();
        }

        List<Serie> Irepositorio<Serie>.Lista()
        {
            throw new System.NotImplementedException();
        }

        int Irepositorio<Serie>.ProximoId()
        {
            throw new System.NotImplementedException();
        }

        Serie Irepositorio<Serie>.RetornaPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}