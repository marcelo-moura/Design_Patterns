// EVITAR O ACOPLAMEMENTO DO REMETENTE DE UMA SOLICITAÇÃO AO SEU RECEPTOR,
// AO DAR A MAIS DE UM OBJETO A OPORTUNIDADE DE TRATAR A SOLICITAÇÃO.
// ENCADEAR OS OBJETOS RECEPTORES, PASSANDO A SOLICITAÇÃO AO LONGO DA CADEIA ATÉ QUE UM OBJETO A TRATE

using DesignPatterns.ChainOfResponsibility;

Handler handler1 = new ConcreteHandler1();
Handler handler2 = new ConcreteHandler2();
Handler handler3 = new ConcreteHandler3();
handler1.SetSuccessor(handler2);
handler2.SetSuccessor(handler3);

// Send requests to the chain
int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

foreach (int request in requests)
{
    handler1.HandleRequest(request);
}
