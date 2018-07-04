using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEF_Practice02.EF
{
    [Table("TypeAssemblyFile")]
    public class TypeAssemblyFile
    {
        [Key]
        public int    TypeId   { get; set; }
        public string FileName { get; set; }
    }
}