namespace AulaPOOCelular
{
    public class Celular
    {
        
        public string nome = "Samsung";
        
        public string modelo = "a21s";

        public string cor = "Azul";

        public string tela = "6.5 polegadas";

        public bool ligado;

        public bool desligado(){
            ligado = false;
            return ligado;
        }

        public bool ligar(){
            ligado = true;
            return ligado;
        }
    }
}