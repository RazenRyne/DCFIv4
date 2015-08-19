using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eSARService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITraitService
    {
        [OperationContract]
        List<Trait> GetAllTraits();
        [OperationContract]
        List<Trait> GetAllTraitsOfGradeLevel(string gradeLevel);
        [OperationContract]
        Boolean CreateTrait(ref Trait trait, ref string message);
        [OperationContract]
        Boolean UpdateTrait(ref Trait trait, ref string message);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "eSARService.ContractType".
    [DataContract]
    public class Trait
    {
        [DataMember]
        public string TraitCode { get; set; }
        [DataMember]
        public string GradeLevel { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
   
}
