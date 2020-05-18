namespace FrontlineMaster.Entity.Common
{
    public class CodeValueEntity
    {
        public int CodeValId { get; set; }
        public string ValCode { get; set; }
        public string ValDesc { get; set; }
        public string TypeCode { get; set; }
        public int SeqNo { get; set; }
        public bool? IsActive { get; set; }
    }
}
