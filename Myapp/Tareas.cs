namespace ejercicio1
{
    public class Tareas
    {
        public Tareas(int TareaID, string Descripcion, int Duracion){
            this.TareaID = TareaID;
            this.Descripcion = Descripcion;
            this.Duracion = Duracion; 
        }
        
        public int TareaID; //Numerado en ciclo iterativo
        public string Descripcion; //
        public int Duracion; // entre 10 – 100
    }
}
