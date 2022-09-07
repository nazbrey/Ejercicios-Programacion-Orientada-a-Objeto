namespace WebModeloVistacontrolador.Models
{
    public abstract class Entity
    {
        public int Id { get; protected set; }

        public Entity(int id)
        {
            this.Id = id;
        }
    }
}
