namespace WebModeloVistacontrolador.Models
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public Entity(int id)
        {
            this.Id = id;
        }
    }
}
