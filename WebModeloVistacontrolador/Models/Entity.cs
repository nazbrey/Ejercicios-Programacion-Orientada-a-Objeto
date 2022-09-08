namespace WebModeloVistacontrolador.Models
{
    public abstract class Entity
    {
        public int Id { get; protected set; }

        protected Entity()
        {
        }
        public Entity(int id)
        {
            this.Id = id;
        }
       
    }
}
