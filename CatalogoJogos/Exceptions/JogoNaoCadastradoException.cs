using System;

namespace CatalogoJogos.Exceptions
{
    public class JogoNaoCadastradoException: Exception
    {
        public JogoNaoCadastradoException()
            :base("Este jogo não está cadastrado")
        {}
    }
}
