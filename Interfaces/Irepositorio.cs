using System.Collections.Generic;

namespace DioSerie1.Interfaces
{
    public interface Irepositorio<T>
    {
       List<T> Lista();
        T RetornaPorId(int id);        
        void Insere(T entidade);        
        void Exclui(int id);        
        void Atualiza(int id, T entidade);
        int ProximoId();  
    }
}