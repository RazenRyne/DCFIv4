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
    public interface IUserService
    {
        [OperationContract]
        Boolean AuthenticateUser(string username, string password, ref string message);
        [OperationContract]
        User GetUser(string username);
        [OperationContract]
        Boolean CreateUser(ref User user, ref string message);
        [OperationContract]
        Boolean UpdateUser(ref User user, ref string message);
        [OperationContract]
        List<User> GetAllUsers();
        [OperationContract]
        Boolean DeactivateUser(int userId, ref string message);
        [OperationContract]
        Boolean ActivateUser(int userId, ref string message);
        [OperationContract]
        Boolean DeleteUser(int userId, ref string message);
        [OperationContract]
        List<UserType> GetAllUserTypes();
        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "eSARService.ContractType".
    [DataContract]
    public class User
    {
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
        [DataMember]
        public string UserTypeCode { get; set; }
        [DataMember]
        public bool Deactivated { get; set; }
    }
    [DataContract]
    public class UserType
    {
        [DataMember]
        public string UserTypeCode{ get; set; }
        [DataMember]
        public string UsersType { get; set; }
    }
}