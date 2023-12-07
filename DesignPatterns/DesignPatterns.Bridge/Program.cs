// DESACOPLAR UMA ABSTRAÇÃO DA SUA IMPLEMENTAÇÃO,
// DE MODO QUE AS DUAS POSSAM VARIAR INDEPENDENTEMENTE

using DesignPatterns.Bridge;

JanelaAbstrata janela = new JanelaDialogo(new JanelaWindows());
janela.Desenhar();

janela = new JanelaDialogo(new JanelaLinux());
janela.Desenhar();
