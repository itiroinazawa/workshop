using System;
using System.Collections.Generic;
using System.Text;

namespace ConstantsProject
{
    public class TextGenerator
    {
        public String MetodoPrincipal()
        {
            string texto = "";

            return texto;
        }

        private String GerarLoremIpsum()
        {
            string texto = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                            Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. 
                            Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
                            Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            return texto;
        }

        private String GerarDilmesIpsum()
        {
            string texto = @"Todos as descrições das pessoas são sobre a humanidade do atendimento, 
                            a pessoa pega no pulso, examina, olha com carinho. Então eu acho que vai ter outra coisa, 
                            que os médicos cubanos trouxeram pro brasil, um alto grau de humanidade.";

            string texto2 = @"Primeiro eu queria cumprimentar os internautas. 
                            -Oi Internautas! Depois dizer que o meio ambiente é sem dúvida nenhuma uma ameaça ao desenvolvimento sustentável. 
                            E isso significa que é uma ameaça pro futuro do nosso planeta e dos nossos países. 
                            O desemprego beira 20%, ou seja, 1 em cada 4 portugueses.";

            return texto + texto2;
        }
    }
}
