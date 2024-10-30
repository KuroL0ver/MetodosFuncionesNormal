namespace MetodosFuncionesNormal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje("Mensaje Desde el Método...1");
            MostrarMensaje("Mensaje Desde el Método...2");

            Sumar(2, 5);
            Sumar(3, 9);
        }

        static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        static void Sumar(int primerNumero, int segundoNumero)
        {
            int total = primerNumero + segundoNumero;
            MostrarMensaje(total.ToString());
        }
    }
}
