using System.ComponentModel.DataAnnotations.Schema;

namespace SequenceHiloPattern.Entitties
{
    public class BaseEntity<T> 
    {
        
        public T ID { get; set; }
    }
}
