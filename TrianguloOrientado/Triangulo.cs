namespace TrianguloOrientado
{
    public class Triangulo
    {
        //atributos, caracteristicas
        public decimal ladoX;
        public decimal ladoY;
        public decimal ladoZ;

        //métodos, comportamentos, ações
        public bool Validar()
        {
            decimal aux1 = (ladoX + ladoY) - ladoZ;
            decimal aux2 = (ladoX + ladoZ) - ladoY;
            decimal aux3 = (ladoY + ladoZ) - ladoX;

            if (aux1 < 0 || aux2 < 0 || aux3 < 0)
            {                
                return false;
            }
            else
                return true;
        }
        public string ObterTipo()
        {
            bool trianguloEhValido = Validar();

            if (trianguloEhValido == false)
                return "Triângulo Inválido";

            else if (ladoX == ladoY && ladoY == ladoZ)            
                return "Equilátero";            
            
            else if ((ladoX != ladoY && ladoY != ladoZ))            
                return "Escaleno";

            else 
                return "Isósceles";
        }

    }


}