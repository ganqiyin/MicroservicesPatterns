namespace GR.Entities
{

    /// <summary>
    /// 实体基类
    /// </summary>
    public abstract class EntityBase : EntityBase<string>
    {

    }

    /// <summary>
    /// 实体基类
    /// </summary>
    public abstract class EntityBase<TKey>
    {
        /// <summary>
        /// 主键
        /// </summary>
        public TKey Id { get; set; }
 
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }

}
