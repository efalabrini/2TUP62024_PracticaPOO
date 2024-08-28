namespace Web.Ej2
{
    public class Photobook
    {
        protected int numPages; // atributo protegido

        public Photobook()
        {
            numPages = 16; // por defecto arranca con 16
        }

        public Photobook(int pages)
        {
            this.numPages = pages; // se especifica cantiad.
        }

        public int GetNumberPages()
        {
            return numPages; // retorna numero de páginas.
        }
    }
}
