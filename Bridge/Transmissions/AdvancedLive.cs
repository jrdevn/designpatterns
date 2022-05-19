using Bridge.Platforms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Transmissions
{
    public class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform ) : base(platform)
        {
                
        }

        public void Subtitle()
        {
            Console.WriteLine("Legendas ativadas na transmissão!");
        }

        public void Comments()
        {
            Console.WriteLine("Comentários liberados para a live.");
        }

        public void Recording()
        {
            Console.WriteLine("Habilitado a gravação da live...");
        }

    }
}
