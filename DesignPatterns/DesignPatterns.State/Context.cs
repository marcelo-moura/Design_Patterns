
// PERMITE A UM OBJETO ALTERAR SEU COMPORTAMENTO QUANDO SEU ESTADO INTERNO MUDA.
// O OBJETO PARECERÁ TER MUDADO DE CLASSE

// Classe do contexto
public class Context
{
    private IState _state;

    public IState State
    {
        get { return _state; }
        set { _state = value; }
    }

    public void Request()
    {
        _state.Handle(this);
    }
}
