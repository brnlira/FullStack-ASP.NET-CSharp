using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;
        private readonly iJogador _jogadorC;

        public JogoFODA(iJogador jogadorA, iJogador jogadorB, iJogador jogadorC)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
            _jogadorC = jogadorC;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogadorA.Corre());
            System.Console.Write(_jogadorA.Chuta());
            System.Console.Write(_jogadorA.Passe());
            //
            System.Console.WriteLine("");
            System.Console.WriteLine("PRÓXIMO JOGADOR");
            System.Console.WriteLine("");
            //
            System.Console.Write(_jogadorB.Corre());
            System.Console.Write(_jogadorB.Chuta());
            System.Console.Write(_jogadorB.Passe());
            //
            System.Console.WriteLine("");
            System.Console.WriteLine("PRÓXIMO JOGADOR");
            System.Console.WriteLine("");
            //
            System.Console.Write(_jogadorC.Corre());
            System.Console.Write(_jogadorC.Chuta());
            System.Console.Write(_jogadorC.Passe());
        }
    }
} 