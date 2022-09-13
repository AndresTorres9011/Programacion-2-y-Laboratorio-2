namespace Clase_02_01
{
    internal static class Validador
    {
        public static bool ValidarRango(int numero, int minimo, int maximo)
        {
            return numero > minimo && numero < maximo;
        }

        public static bool ValidarRespuesta(char respuesta)
        {
            bool retorno = false;

            if (respuesta=='s')
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
